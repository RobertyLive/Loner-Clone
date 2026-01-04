# Setting up the project

Open a terminal in the package root.
Run `npm install`
Run `npm run build` or `npm run watch`

# Homescreen setup

Homescreen is a UXP plugin that is currently integrated in a variary of host applications.
We will be bundled by their codebase as an NPM package and rendered inside their plugin.

- [Enable Homescreen debugging](https://wiki.corp.adobe.com/pages/viewpage.action?pageId=2925384851)
- [Enable Homescreen stage](https://wiki.corp.adobe.com/pages/viewpage.action?spaceKey=DIPES&title=First+Mile+-+OnBoarding#FirstMileOnBoarding-TestingwithStageaccounts)
- [Homescreen Repo](https://git.corp.adobe.com/CCX/ccx-start-uxp)

# Install internal build of UXP Developer Tools

1. If you already have a UDT version installed from public adobe domains (Ex. developer.adobe.com), uninstall it
2. Download and install the [internal build](https://artifactory.corp.adobe.com/artifactory/npm-torq-release-local/uxp-developer-tools/udt-2.0.0-beta-master.33-internal/) of UDT (comes with First Party Plugin features)

# Photoshop UXP Setup
1. Download the Creative Cloud application from the Workspace ONE Intelligent Hub OR from the stage environment [here](https://stage.creativecloud.adobe.com/apps/download/creative-cloud). I suggest the stage environment so you can test on both stage and prod the applications.
2. Install the latest Photoshop edition from inside of Creative Cloud

# Photoshop - Testing other locales
1. Download from [this](https://artifactory.corp.adobe.com/ui/native/generic-DI-builds-local/Installers/26.6/Application/macuniversal/beta/20250406.m.3035/release/Raw%20Build/) location the locales
2. Unzip it and move the locales to the Photoshop locales folder
3. Restart application.
4. Go to Photoshop => Settings => Interface => UI language
5. Select desired language and restart photoshop

Note: This is just for development. A real user has to go to CCD, change language and reinstall host application. 

# Install other applications as well such as
We need to test on all UXP applications we will support. There are different behaviors on some UXP API's depending on the host application. As such install these as well:
- Illustrator 
   -- NOTE: In order to enable development mode in Illustrator it needs this `AIFeatures.cfg` file to be updated in `/Applications/Adobe Illustrator 2025/AIFeatures.cfg`
   -- NOTE: UDT Still does not see it linked, but you can access the dev tools through `chrome://inspect`
- Premiere Pro
- InDesign

# Troubleshooting Setup
1. If you can't see the plugin in UDT after creating the symlink, go to System Settings => Go to Privacy & Settings => Set desired host app to have Full disk access
2. If you are running a HS build that has a PROD UAM bundled with it and you want to enable development mode in it, add this config in com.adobe.uam inside a debug.json file `{ "port": 9252, "breakOnStart": false }`
3. If you're attempting to install a specific app but HS with UAM is not rendering check the HS manifest.json minVersion and the currently installed version of the app. 
You can either downgrade locally the minVersion of HS or install the beta version of the app (if latest CCD version of the app is smaller than the minVersion of manifest.json)
4. If you have a com.adobe.uam set as a direct UXP plugin build in UXP Extensions, and another copy in HS build folder, HS will not render UAM at all due to having the 2 versions present. 
5. If nothing appears in chrome://inspect try to toggle Discover USB Devices. Should fix it.
6. If you dont see the webview API requests in devTools try to right click the webview and hit reload. Requests should appear now.
7. Make sure you did all the required steps from HS readme

# Setting UAM in HS
1. Checkout this branch `cranete/IAW-16472_integrate_uam` of the [Homescreen Repo](https://git.corp.adobe.com/CCX/ccx-start-uxp) 
2. Install a supported Node version (ex: `18.17.1`)
3. Follow the HS readme instructions to create a build
4. Inside UXP UAM project Run `npm run build:uxp:hs` or `npm run watch:hs`
5. This will create a build folder called `com.adobe.uam` that can be linked to `HS_PROJECT/_dist`
6. Link the above dist folder of UAM UXP Trigger to HS `HS_PROJECT/_dist/com.adobe.uam`. Example:
`sudo ln -s /Users/stivan/Documents/Git/PandoraUI-account-management/packages/uxp-plugin-account-menu-trigger/com.adobe.uam /Users/stivan/Documents/UXP/ccx-start-uxp/_dist/com.adobe.ccx.start`

# Open UXP console

1. Go to chrome://inspect
2. Go to configure and add localhost:9252 (if its not already there)
3. Target (Adobe UXP) Unified Account Menu should appear in the list. Click inspect

## Open UXP console - Alternative

1. Open UDT (UXP Developer Tools) and Photoshop
2. Click refresh plugin list
3. Find `com.adobe.uam` under Host Name - First Party list
4. Go to Actions menu and click Debug.
NOTE: Not all applications show up in UDT. You may need to use chrome://inspect

# Webview debugging

1. Go to host app and trigger the action that displays the webview
2. If the webview has the `uxpAllowInspector=true` attribute, it will be inspectable
3. Right click on the webview window and click inspect
4. This opens a Chrome Developer Tools specific to that Webview.

# Documentation

### UXP

- [UXP Architecture Diagram](https://wiki.corp.adobe.com/display/UXP/UXP+Architecture+Diagr