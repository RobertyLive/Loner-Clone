.TH "NPM-VERSION" "1" "April 2024" "" ""
.SH "NAME"
\fBnpm-version\fR - Bump a package version
.SS "Synopsis"
.P
.RS 2
.nf
npm version \[lB]<newversion> | major | minor | patch | premajor | preminor | prepatch | prerelease | from-git\[rB]

alias: verison
.fi
.RE
.SS "Configuration"
.SS "\fBallow-same-version\fR"
.RS 0
.IP \(bu 4
Default: false
.IP \(bu 4
Type: Boolean
.RE 0

.P
Prevents throwing an error when \fBnpm version\fR is used to set the new version to the same value as the current version.
.SS "\fBcommit-hooks\fR"
.RS 0
.IP \(bu 4
Default: true
.IP \(bu 4
Type: Boolean
.RE 0

.P
Run git commit hooks when using the \fBnpm version\fR command.
.SS "\fBgit-tag-version\fR"
.RS 0
.IP \(bu 4
Default: true
.IP \(bu 4
Type: Boolean
.RE 0

.P
Tag the commit when using the \fBnpm version\fR command. Setting this to false results in no commit being made at all.
.SS "\fBjson\fR"
.RS 0
.IP \(bu 4
Default: false
.IP \(bu 4
Type: Boolean
.RE 0

.P
Whether or not to output JSON data, rather than the normal output.
.RS 0
.IP \(bu 4
In \fBnpm pkg set\fR it enables parsing set values with JSON.parse() before saving them to your \fBpackage.json\fR.
.RE 0

.P
Not supported by all npm commands.
.SS "\fBpreid\fR"
.RS 0
.IP \(bu 4
Default: ""
.IP \(bu 4
Type: String
.RE 0

.P
The "prerelease identifier" to use as a prefix for the "prerelease" part of a semver. Like the \fBrc\fR in \fB1.2.0-rc.8\fR.
.SS "\fBsign-git-tag\fR"
.RS 0
.IP \(bu 4
Default: false
.IP \(bu 4
Type: Boolean
.RE 0

.P
If set to true, then the \fBnpm version\fR command will tag the version using \fB-s\fR to add a signature.
.P
Note that git requires you to have set up GPG keys in your git configs for this to work properly.
.SS "\fBworkspace\fR"
.RS 0
.IP \(bu 4
Default:
.IP \(bu 4
Type: String (can be set multiple times)
.RE 0

.P
Enable running a command in the context of the configured workspaces of the current project while filtering by running only the workspaces defined by this configuration option.
.P
Valid values for the \fBworkspace\fR config are either:
.RS 0
.IP \(bu 4
Workspace names
.IP \(bu 4
Path to a workspace directory
.IP \(bu 4
Path to a parent workspace directory (will result in selecting all workspaces within that folder)
.RE 0

.P
When set for the \fBnpm init\fR command, this may be set to the folder of a workspace which does not yet exist, to create the folder and set it up as a brand new workspace within the project.
.P
This value is not exported to the environment for child processes.
.SS "\fBworkspaces\fR"
.RS 0
.IP \(bu 4
Default: null
.IP \(bu 4
Type: null or Boolean
.RE 0

.P
Set to true to run the command in the context of \fBall\fR configured workspaces.
.P
Explicitly setting this to false will cause commands like \fBinstall\fR to ignore workspaces altogether. When not set explicitly:
.RS 0
.IP \(bu 4
Commands that operate on the \fBnode_modules\fR tree (install, update, etc.) will link workspaces into the \fBnode_modules\fR folder. - Commands that do other things (test, exec, publish, etc.) will operate on the root project, \fIunless\fR one or more workspaces are specified in the \fBworkspace\fR config.
.RE 0

.P
This value is not exported to the environment for child processes.
.SS "\fBworkspaces-update\fR"
.RS 0
.IP \(bu 4
Default: true
.IP \(bu 4
Type: Boolean
.RE 0

.P
If set to true, the npm cli will run an update after operations that may possibly change the workspaces installed to the \fBnode_modules\fR folder.
.SS "\fBinclude-workspace-root\fR"
.RS 0
.IP \(bu 4
Default: false
.IP \(bu 4
Type: Boolean
.RE 0

.P
Include the workspace root when workspaces are enabled for a command.
.P
When false, specifying individual workspaces via the \fBworkspace\fR config, or all workspaces via the \fBworkspaces\fR flag, will cause npm to operate only on the specified workspaces, and not on the root project.
.P
This value is not exported to the environment for child processes.
.SS "Description"
.P
Run this in a package directory to bump the version and write the new data back to \fBpackage.json\fR, \fBpackage-lock.json\fR, and, if present, \fBnpm-shrinkwrap.json\fR.
.P
The \fBnewversion\fR argument should be a valid semver string, a valid second argument to \fBsemver.inc\fR \fI\(lahttps://github.com/npm/node-semver#functions\(ra\fR (one of \fBpatch\fR, \fBmi