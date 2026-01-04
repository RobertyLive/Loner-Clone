{
	"__metadata": {
		"id": "0ea05e3f-5a38-419d-8305-f6c3f6d409d2",
		"publisherDisplayName": "Ionide",
		"publisherId": "6841d314-11e9-4ec1-a088-08558c6effee",
		"installedTimestamp": 1767482657579,
		"targetPlatform": "undefined",
		"size": 144425363
	},
	"activationEvents": [
		"onCommand:workbench.action.tasks.runTask",
		"onDebugInitialConfigurations:coreclr",
		"onDebugDynamicConfigurations:coreclr",
		"onDebugResolve:coreclr",
		"workspaceContains:**/*.fs",
		"workspaceContains:**/*.fsproj",
		"workspaceContains:**/*.fsx",
		"workspaceContains:**/*.sln"
	],
	"badges": [
		{
			"description": "Open Collective Backers",
			"href": "https://opencollective.com/ionide",
			"url": "https://img.shields.io/opencollective/backers/ionide.svg?color=blue&style=for-the-badge"
		},
		{
			"description": "Open Collective Sponsors",
			"href": "https://opencollective.com/ionide",
			"url": "https://img.shields.io/opencollective/sponsors/ionide.svg?color=Blue&style=for-the-badge"
		}
	],
	"bugs": {
		"url": "https://github.com/ionide/ionide-vscode-fsharp/issues"
	},
	"categories": [
		"Linters",
		"Programming Languages",
		"Snippets"
	],
	"contributes": {
		"breakpoints": [
			{
				"language": "fsharp"
			}
		],
		"configurationDefaults": {
			"explorer.fileNesting.patterns": {
				"*.fs": "${basename}.fsi, ${basename}.fs.js, ${basename}.fs.js.map",
				"*.fsl": "${basename}.fsi, ${basename}.fs",
				"*.fsy": "${basename}.fsi, ${basename}.fs"
			},
			"files.associations": {
				".fantomasignore": "ignore"
			}
		},
		"colors": [
			{
				"defaults": {
					"dark": "#696969",
					"highContrast": "#A2E2A2",
					"light": "#919191"
				},
				"description": "Foreground color for F# LineLenses",
				"id": "fsharp.linelens"
			},
			{
				"defaults": {
					"dark": "#696969",
					"highContrast": "#A2E2A2",
					"light": "#919191"
				},
				"description": "Foreground color for F# Pipeline Hints",
				"id": "fsharp.pipelineHints"
			},
			{
				"defaults": {
					"dark": "#FFCC00",
					"highContrast": "#FFFF00",
					"light": "#FFCC00"
				},
				"description": "Text colors for warnings shown in the status bar",
				"id": "fsharp.statusBarWarnings"
			}
		],
		"commands": [
			{
				"command": "fsi.Start",
				"title": "FSI: Start"
			},
			{
				"command": "fsi.SendLine",
				"title": "FSI: Send Line"
			},
			{
				"command": "fsi.SendSelection",
				"title": "FSI: Send Selection"
			},
			{
				"command": "fsi.SendSelectionExtendedToWholeLine",
				"title": "FSI: Send Selection Extended To Whole Line"
			},
			{
				"command": "fsi.SendLastSelection",
				"title": "FSI: Send Last Selection"
			},
			{
				"command": "fsi.SendFile",
				"icon": {
					"dark": "./images/send-dark.svg",
					"light": "./images/send-light.svg"
				},
				"title": "FSI: Send File"
			},
			{
				"command": "fsi.SendProjectReferences",
				"title": "FSI: Send References from project"
			},
			{
				"command": "fsi.GenerateProjectReferences",
				"title": "FSI: Generate script file with references from project"
			},
			{
				"command": "fsi.OpenWatcher",
				"title": "FSI: Open Watcher"
			},
			{
				"command": "fsharp.scriptrunner.run",
				"icon": {
					"dark": "./images/run-dark.svg",
					"light": "./images/run-light.svg"
				},
				"title": "F#: Run script"
			},
			{
				"command": "fsharp.NewProject",
				"icon": {
					"dark": "./images/add-dark.svg",
					"light": "./images/add-light.svg"
				},
				"title": "F#: New Project"
			},
			{
				"command": "fsharp.AddFileToProject",
				"title": "F#: Add Current File To Project"
			},
			{
				"command": "fsharp.getHelp",
				"title": "F#: Get Help"
			},
			{
				"command": "fsharp.generateDoc",
				"title": "F#: Generate Documentation"
			},
			{
				"command": "fsharp.clearCache",
				"title": "F#: Clear Project Cache"
			},
			{
				"command": "fsharp.changeWorkspace",
				"title": "F#: Change Workspace or Solution"
			},
			{
				"command": "fsharp.fsdn",
				"title": "F#: Search by signatures on FSDN"
			},
			{
				"command": "MSBuild.buildCurrent",
				"title": "MSBuild: Build current project"
			},
			{
				"command": "MSBuild.buildSelected",
				"title": "MSBuild: Build project"
			},
			{
				"command": "MSBuild.rebuildCurrent",
				"title": "MSBuild: Rebuild current project"
			},
			{
				"command": "MSBuild.rebuildSelected",
				"title": "MSBuild: Rebuild project"
			},
			{
				"command": "MSBuild.cleanCurrent",
				"title": "MSBuild: Clean current project"
			},
			{
				"command": "MSBuild.cleanSelected",
				"title": "MSBuild: Clean project"
			},
			{
				"command": "MSBuild.restoreSelected",
				"title": "MSBuild: Restore project"
			},
			{
				"command": "MSBuild.buildCurrentSolution",
				"title": "MSBuild: Build current solution"
			},
			{
				"command": "MSBuild.rebuildCurrentSolution",
				"title": "MSBuild: Rebuild current solution"
			},
			{
				"command": "MSBuild.cleanCurrentSolution",
				"title": "MSBuild: Clean current solution"
			},
			{
				"command": "fsharp.explorer.moveUp",
				"icon": {
					"dark": "./images/up-mono-dark.svg",
					"light": "./images/up-mono-light.svg"
				},
				"title": "Move file up"
			},
			{
				"command": "fsharp.explorer.moveDown",
				"icon": {
					"dark": "./images/down-mono-dark.svg",
					"light": "./images/down-mono-light.svg"
				},
				"title": "Move file down"
			},
			{
				"command": "fsharp.explorer.renameFile",
				"title": "Rename file"
			},
			{
				"command": "fsharp.explorer.removeFile",
				"title": "Remove file"
			},
			{
				"command": "fsharp.explorer.addAbove",
				"title": "Add file above"
			},
			{
				"command": "fsharp.explorer.addBelow",
				"title": "Add file below"
			},
			{
				"command": "fsharp.explorer.addFile",
				"title": "Add file"
			},
			{
				"command": "fsharp.explorer.addExistingFile",
				"title": "Add existing file"
			},
			{
				"command": "fsharp.explorer.showProjectLoadFailedInfo",
				"icon": {
					"dark": "./images/icon-status-dark.svg",
					"light": "./images/icon-status-light.svg"
				},
				"title": "Show info about failed project loading"
			},
			{
				"command": "fsharp.explorer.showProjectStatus",
				"icon": {
					"dark": "./images/icon-status-dark.svg",
					"light": "./images/icon-status-light.svg"
				},
				"title": "Show project status"
			},
			{
				"command": "fsharp.explorer.addProjecRef",
				"title": "Add project reference"
			},
			{
				"command": "fsharp.explorer.removeProjecRef",
				"title": "Remove project reference"
			},
			{
				"command": "fsharp.explorer.openProjectFile",
				"icon": {
					"dark": "images/open-file-mono-dark.svg",
					"light": "images/open-file-mono-light.svg"
				},
				"title": "Open project file"
			},
			{
				"command": "fsharp.explorer.refresh",
				"title": "Refresh Explorer"
			},
			{
				"command": "fsharp.explorer.clearCache",
				"title": "Clear project cache"
			},
			{
				"category": "F#",
				"command": "fsharp.diagnostics.getInfos",
				"title": "Get info for diagnostics"
			},
			{
				"command": "fsharp.explorer.msbuild.build",
				"title": "Build"
			},
			{
				"command": "fsharp.explorer.msbuild.rebuild",
				"title": "Rebuild"
			},
			{
				"command": "fsharp.explorer.msbuild.clean",
				"title": "Clean"
			},
			{
				"command": "fsharp.explorer.msbuild.restore",
				"title": "Restore"
			},
			{
				"command": "fsharp.explorer.solution.build",
				"title": "Build"
			},
			{
				"command": "fsharp.explorer.solution.rebuild",
				"title": "Rebuild"
			},
			{
				"command": "fsharp.explorer.solution.clean",
				"title": "Clean"
			},
			{
				"command": "fsharp.explorer.solution.restore",
				"title": "Restore"
			},
			{
				"command": "fsharp.explorer.project.run",
				"icon": {
					"dark": "./images/run-mono-dark.svg",
					"light": "./images/run-mono-light.svg"
				},
				"title": "Run"
			},
			{
				"command": "fsharp.explorer.project.debug",
				"icon": {
					"dark": "./images/debug-mono-dark.svg",
					"light": "./images/debug-mono-light.svg"
				},
				"title": "Debug"
			},
			{
				"command": "fsharp.explorer.project.setDefault",
				"title": "Set as startup project"
			},
			{
				"command": "fsharp.explorer.project.sendFSI",
				"title": "Send references for FSI"
			},
			{
				"command": "fsharp.explorer.project.generateFSI",
				"title": "Generate references for FSI"
			},
			{
				"command": "fsharp.runDefaultProject",
				"icon": "./images/run.png",
				"title": "F#: Run Default Project"
			},
			{
				"command": "fsharp.debugDefaultProject",
				"icon": "./images/debug.png",
				"title": "F#: Debug Default Project"
			},
			{
				"command": "fsharp.chooseDefaultProject",
				"title": "F#: Choose Default Project"
			},
			{
				"command": "fsharp.explorer.solution.addProject",
				"title": "Add project"
			},
			{
				"category": "F#",
				"command": "fsharp.htmlConverter.convert",
				"description": "Converts your selection to Elmish by assuming that your selection is HTML code",
				"title": "Convert html to Elmish"
			},
			{
				"category": "F#",
				"command": "fsharp.revealInSolutionExplorer",
				"icon": {
					"dark": "./images/auto-reveal-dark.svg",
					"light": "./images/auto-reveal-light.svg"
				},
				"title": "Reveal in solution explorer"
			},
			{
				"category": "F#",
				"command": "fsharp.openInfoPanel",
				"description": "Opens Info Panel displaying documentation",
				"title": "Open Info Panel"
			},
			{
				"category": "F#",
				"command": "fsharp.updateInfoPanel",
				"description": "Updates Info Panel with documentation of current symbol",
				"title": "Update Info Panel"
			},
			{
				"command": "fsharp.showDocumentation",
				"title": "Show Documentation for given symbol"
			},
			{
				"category": "F#",
				"command": "fsharp.openInfoPanel.lock",
				"icon": {
					"dark": "./images/lock-solid.svg",
					"light": "./images/lock-solid-light.svg"
				},
				"title": "Lock Info Panel"
			},
			{
				"category": "F#",
				"command": "fsharp.openInfoPanel.unlock",
				"icon": {
					"dark": "./images/lock-open-solid.svg",
					"light": "./images/lock-open-solid-light.svg"
				},
				"title": "Unlock Info Panel"
			},
			{
				"category": "F#",
				"command": "fsharp.restartLanguageService",
				"title": "Restart Language Service"
			}
		],
		"configuration": {
			"properties": {
				"FSharp.abstractClassStubGeneration": {
					"default": true,
					"description": "Enables a codefix that generates missing members for an abstract class when in an type inheriting from that abstract class.",
					"type": "boolean"
				},
				"FSharp.abstractClassStubGenerationMethodBody": {
					"default": "failwith \"Not Implemented\"",
					"description": "The expression to fill in the right-hand side of inherited members when generating missing members for an abstract base class",
					"type": "string"
				},
				"FSharp.abstractClassStubGenerationObjectIdentifier": {
					"default": "this",
					"description": "The name of the 'self' identifier in an inherited member. For example, `this` in the expression `this.Member(x: int) = ()`",
					"type": "string"
				},
				"FSharp.addFsiWatcher": {
					"default": false,
					"description": "Enables a panel for FSI that shows the value of all existing bindings in the FSI session",
					"type": "boolean"
				},
				"FSharp.analyzersPath": {
					"default": [
						"packages/Analyzers",
						"analyzers"
					],
					"description": "Directories in the array are used as a source of custom analyzers. Requires restart.",
					"scope": "machine-overridable",
					"type": "array"
				},
				"FSharp.excludeAnalyzers": {
					"default": [],
					"description": "The names of custom analyzers that should not be executed.",
					"scope": "machine-overridable",
					"type": "array"
				},
				"FSharp.includeAnalyzers": {
					"default": [],
					"description": "The names of custom analyzers that should exclusively be executed, others should be ignored.",
					"scope": "machine-overridable",
					"type": "array"
				},
				"FSharp.autoRevealInExplorer": {
					"default": "sameAsFileExplorer",
					"description": "Controls whether the solution explorer should automatically reveal and select files when opening them. If `sameAsFileExplorer` is set, then the value of the `explorer.autoReveal` setting will be used instead.",
					"enum": [
						"sameAsFileExplorer",
						"enabled",
						"disabled"
					],
					"scope": "window",
					"type": "string"
				},
				"FSharp.codeLenses.references.enabled": {
					"description": "If enabled, code lenses for reference counts for methods and functions will be shown.",
					"type": "boolean",
					"default": true
				},
				"FSharp.codeLenses.signature.enabled": {
					"description": "If enabled, code lenses for type signatures on methods and functions will be shown.",
					"type": "boolean",
					"default": true
				},
				"FSharp.disableFailedProjectNotifications": {
					"default": false,
					"description": "Disables popup notifications for failed project loading",
					"type": "boolean"
				},
				"FSharp.dotnetRoot": {
					"description": "Sets the root path for finding locating the dotnet CLI binary. Defaults to the `dotnet` binary found on your system PATH.",
					"type": "string"
				},
				"FSharp.enableAdaptiveLspServer": {
					"default": true,
					"description": "Enables Enable LSP Server based on FSharp.Data.Adaptive. This can improve stability. Requires restart.",
					"markdownDeprecationMessage": "This setting has b