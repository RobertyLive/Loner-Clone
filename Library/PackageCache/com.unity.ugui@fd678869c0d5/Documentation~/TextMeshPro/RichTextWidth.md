const native = require('./discord_zstd.node');

// Init logging
const isFileManagerAvailable = window?.DiscordNative?.fileManager;
const isLogDirAvailable = isFileManagerAvailable?.getAndCreateLogDirectorySync;
let initializeArgs = {};
if (isLogDirAvailable) {
  const logDirectory = window.DiscordNative.fileManager.getAndCreateLogDirectorySync();
  const logLevel = window.DiscordNative.fileManager.logLevelSync();

  initializeArgs = {
    logDirectory: logDirectory,
    logLevel: logLevel,
    logNumFiles: 1,
    logFileSize: 3 * 1024 * 1024,
  };
}
native.initializeLogging(initializeArgs);

// Returning the real context to web JS doesn't seem to work, so we will hold onto
// it here a