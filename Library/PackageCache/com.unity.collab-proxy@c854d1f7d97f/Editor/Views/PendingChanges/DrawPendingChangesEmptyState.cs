{
  "_id": "com.unity.ide.visualstudio",
  "name": "com.unity.ide.visualstudio",
  "description": "Code editor integration for supporting Visual Studio as code editor for unity. Adds support for generating csproj files for intellisense purposes, auto discovery of installations, etc.",
  "provider": "upm",
  "versions": {
    "2.0.22": {
      "_upm": {
        "changelog": "Integration:\n\n- Add support for `XDG_DATA_DIRS` and `.desktop` files on Linux for `VS Code` discovery.\n- Use compile-time platform-specifics instead of using runtime conditions.\n\nProject generation:\n\n- Suppress `USG0001` warnings.\n- Mark referenced assemblies as private (to not copy extra files to output directory when building).\n- Add Unity capability to SDK-Style projects.\n- Prevent circular dependency errors with SDK-Style projects."
      },
      "type": "assets",
      "unity": "2019.4",
      "upmCi": {
        "footprint": "0b7347d4363afca9be389b61f0e25489ae3995b8"
      },
      "repository": {
        "url": "https://github.cds.internal.unity3d.com/unity/com.unity.ide.visualstudio.git",
        "type": "git",
        "revision": "700b44077345e97d37d464ff25507638983aed64"
      },
      "unityRelease": "25f1",
      "relatedPackages": {
        "com.unity.ide.visualstudio.tests": "2.0.22"
      },
      "documentationUrl": "https://docs.unity3d.com/Packages/com.unity.ide.visualstudio@2.0/manual/index.html",
      "name": "com.unity.ide.visualstudio",
      "version": "2.0.22",
      "displayName": "Visual Studio Editor",
      "description": "Code editor integration for supporting Visual Studio as code editor for unity. Adds support for generating csproj files for intellisense purposes, auto discovery of installations, etc.",
      "dependencies": {
        "com.unity.test-framework": "1.1.9"
      },
      "dist": {
        "shasum": "8140e851d83e922ca2021b04a89519de94ebe38c",
        "tarball": "https://download.packages.unity.com/com.unity.ide.visualstudio/-/com.unity.ide.visualstudio-2.0.22.tgz"
      }
    },
    "2.0.21": {
      "_upm": {
        "changelog": "Integration:\n\n- Only disable the legacy `com.unity.ide.vscode` package going forward.\n- Fix json parsing issues with specific non-UTF code pages.\n\nProject generation:\n\n- Target `netstandard2.1` instead of `netstandard2.0`.\n- Set `defaultSolution` in `settings.json`.\n- Remove `files.exclude` entries for root `csproj` and `sln` files in `settings.json` when needed.\n- Add `vstuc` launch configuration to `launch.json` when needed.\n- Add `visualstudiotoolsforunity.vstuc` entry to `extensions.json` when needed.\n- You can prevent the package from patching those configuration files by creating a `.vscode/.vstupatchdisable` file."
      },
      "type": "assets",
      "unity": "2019.4",
      "upmCi": {
        "footprint": "33ecd838a074080a82176ca86b21c837ba396a28"
      },
      "repository": {
        "url": "https://github.cds.internal.unity3d.com/unity/com.unity.ide.visualstudio.git",
        "type": "git",
        "revision": "eb2b500b99f6429d3d9dcb8acbcbd366dfbb42be"
      },
      "unityRelease": "25f1",
      "relatedPackages": {
        "com.unity.ide.visualstudio.tests": "2.0.21"
      },
      "documentationUrl": "https://docs.unity3d.com/Packages/com.unity.ide.visualstudio@2.0/manual/index.html",
      "name": "com.unity.ide.visualstudio",
      "version": "2.0.21",
      "displayName": "Visual Studio Editor",
      "description": "Code editor integration for supporting Visual Studio as code editor for unity. Adds support for generating csproj files for intellisense purposes, auto discovery of installations, etc.",
      "dependencies": {
        "com.unity.test-framework": "1.1.9"
      },
      "dist": {
        "shasum": "7fc41c79cffea7f8fcb18d8abb16ba6dfdae4df3",
        "tarball": "https://download.packages.unity.com/com.unity.ide.visualstudio/-/com.unity.ide.visualstudio-2.0.21.tgz"
      }
    },
    "2.0.20": {
      "_upm": {
        "changelog": "Integration:\n\n- Internal API refactoring."
      },
      "type": "assets",
      "unity": "2019.4",
      "upmCi": {
        "footprint": "7d769a8558c7768417b16fc2ac8477cf69234049"
      },
      "repository": {
        "url": "https://github.cds.internal.unity3d.com/unity/com.unity.ide.visualstudio.git",
        "type": "git",
        "revision": "b7bf23d23806ac75645bfa12acadcfc11468a383"
      },
      "unityRelease": "25f1",
      "relatedPackages": {
        "com.unity.ide.visualstudio.tests": "2.0.20"
      },
      "documentationUrl": "https://docs.unity3d.com/Packages/com.unity.ide.visualstudio@2.0/manual/index.html",
      "name": "com.unity.ide.visualstudio",
      "version": "2.0.20",
      "displayName": "Visual Studio Editor",
      "description": "Code editor integration for supporting Visual Studio as code editor for unity. Adds support for generating csproj files for intellisense purposes, auto discovery of installations, etc.",
      "dependencies": {
        "com.unity.test-framework": "1.1.9"
      },
      "dist": {
        "shasum": "c4ee6f0704b6c90bfaed5b7a9dbac7b2f5734552",
        "tarball": "https://download.packages.unity.com/com.unity.ide.visualstudio/-/com.unity.ide.visualstudio-2.0.20.tgz"
      }
    },
    "2.0.18": {
      "_upm": {
        "changelog": "Integration:\n\n- Performance improvements with `EditorApplication.update` ca