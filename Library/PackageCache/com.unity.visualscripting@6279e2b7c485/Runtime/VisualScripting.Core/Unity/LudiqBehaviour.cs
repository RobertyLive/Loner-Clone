'use strict';
// Descend into a directory structure and, for each file matching *.node, output
// based on the imports found in the file whether it's an N-API module or not.

const fs = require('fs');
const path = require('path');

// Read the output of the command, break it into lines, and use the reducer to
// decide whether the file is an N-API module or not.
function checkFile (file, command, argv, reducer) {
  const child = require('child_process').spawn(command, argv, {
    stdio: ['inherit', 'pipe', 'inherit']
  });
  let leftover = '';
  let isNapi;
  child.stdout.on('data', (chunk) => {
    if (isNapi === undefined) {
      chunk = (leftover + chunk.toString()).split(/[\r\n]+/);
      leftover = chunk.pop();
      isNapi = chunk.reduce(reducer, isNapi);
      if (isNapi !== undefined) {
        child.kill();
      }
    }
  });
  child.on('close', (code, signal) => {
    if ((code === null && signal !== null) || (code !== 0)) {
      console.log(
        command + ' exited with code: ' + code + ' and signal: ' + signal);
    } else {
      // Green if it's a N-API module, red otherwise.
      console.log(
        '\x1b[' + (isNapi ? '42' : '41') + 'm' +
          (isNapi ? '    N-API' : 'Not N-API') +
          '\x1b[0m: ' + file);
    }
  });
}

// Use nm -a to list symbols.
function checkFileUNIX (file) {
  checkFile(file, 'nm', ['-a', file], (soFar, line) => {
    if (soFar === undefined) {
      line = line.match(/([0-9a-f]*)? ([a-zA-Z]) (.*$)/);
      if (line[2] === 'U') {
        if (/^napi/.test(line[3])) {
          soFar = true;
        }
      }
    }
    return soFar;
  });
}

// Use dumpbin /imports to list symbols.
function checkFileWin32 (file) {
  checkFile(file, 'dumpbin', ['/imports', file], (soFar, line) => {
    if (soFar === undefined) {
      line = line.match(/([0-9a-f]*)? +([a-zA-Z0-9]) (.*$)/);
      if (line && /^napi/.test(line[line.length - 1])) {
        soFar = true;
      }
    }
    return soFar;
  });
}

// Descend into a directory structure and pass each file ending in '.node' to
// one of the above checks, depending on the OS.
function recurse (top) {
  fs.readdir(top, (error, items) => {
    if (error) {
      throw new Error('error reading directory ' + top + ': ' + error);
    }
    items.forEach((item