const { explainNode } = require('../utils/explain-dep.js')
const npa = require('npm-package-arg')
const semver = require('semver')
const { relative, resolve } = require('node:path')
const validName = require('validate-npm-package-name')
const { output } = require('proc-log')
const ArboristWorkspaceCmd = require('../arborist-cmd.js')

class Explain extends ArboristWorkspaceCmd {
  static description = 'Explain installed packages'
  static name = 'explain'
  static usage = ['<package-spec>']
  static params = [
    'json',
    'workspace',
  ]

  static ignoreImplicitWorkspace = false

  // TODO
  /* istanbul ignore next */
  static async completion (opts, npm) {
