<?xml version="1.0" encoding="utf-8"?>
<PackageManifest Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema/2011">
  <Metadata>
    <Identity Id="TestWindow.Microsoft.0771d463-d74d-4e95-aac2-39d3c7ec1f97" Version="17.12.0.2453101" Language="en-US" Publisher="Microsoft" />
    <DisplayName>Test Explorer Window</DisplayName>
    <Description>Test Explorer Window</Description>
    <PackageId>Microsoft.VisualStudio.TestTools.TestPlatform.IDE</PackageId>
    <AllowClientRole>true</AllowClientRole>
  </Metadata>
  <Installation SystemComponent="true">
    <InstallationTarget Version="[17.0,18.0)" Id="Microsoft.VisualStudio.Enterprise">
      <ProductArchitecture>amd64</ProductArchitecture>
    </InstallationTarget>
    <InstallationTarget Version="[17.0,18.0)" Id="Microsoft.VisualStudio.Enterprise">
      <ProductArchitecture>x86</ProductArchitecture>
    </InstallationTarget>
    <InstallationTarget Version="[17.0,18.0)" Id="Microsoft.VisualStudio.Pro">
      <ProductArchitecture>amd64</ProductArchitecture>
    </InstallationTarget>
    <InstallationTarget Version="[17.0,18.0)" Id="Microsoft.VisualStudio.Pro">
      <ProductArchitecture>x86</ProductArchitecture>
    </InstallationTarget>
    <InstallationTarget Version="[17.0,18.0)" Id="Microsoft.VisualStudio.Community">
      <ProductArchitecture>amd64</ProductArchitecture>
    </InstallationTarget>
    <InstallationTarget Version="[17.0,18.0)" Id="Microsoft.VisualStudio.Community">
      <ProductArchitecture>x86</ProductArchitecture>
    </InstallationTarget>
  </Installation>
  <Dependencies>
    <Dependency Id="Microsoft.Framework.NDP" DisplayName="Microsoft .NET Framework" Version="4.5" />
  </Dependencies>
  <Prerequisites>
    <Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[17.0,18.0)" DisplayName="Visual Studio core editor" />
    <Prerequisite Id="Microsoft.VisualStudio.Component.Roslyn.LanguageServices" Version="[17.0,18.0)" DisplayName="C# and Visual Basic" />
    <Prerequisite Id="Microsoft.VisualStudio.TestTools.TestPlatform.V2.CLI" Version="[17.0,18.0)" DisplayName="Visual Studio Test Platform" />
    <Prerequisite Id="Microsoft.VisualStudio.Cache.Service" Version="[0.0,18.0)" DisplayName="Visual Studio Cache Service" />
  </Prerequisites>
  <Assets>
    <Asset Type="Microsoft.VisualStudio.VsPackage" Path="Microsoft.VisualStudio.TestWindow.pkgdef" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.Core.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.VSTest.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.Interfaces.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.Internal.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.Copilot.InlineValues.DataProviders.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.Copilot.InlineValues.dll" />
    <Asset Type="Microsoft.VisualStudio.MefComponent" Path="Microsoft.VisualStudio.TestWindow.Copilot.Internal.dll" />
    <Asset Type="Microsoft.VisualStudio.VsPackage" Path="TestWindowProvideCodeBase.pkgdef" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="TestStore\arm64\Microsoft.VisualStudio.TestWindow.TestWindowStoreService.arm64.servicehub.service.json" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="TestStore\arm64\TestDiscoveryListener.arm64.servicehub.service.json" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="TestStore\arm64\LiveUnitTestingTestStoreService.arm64.servicehub.service.json" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="TestStore\arm64\CodeLensTestInformationService.arm64.servicehub.service.json" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="TestStore\x64\Microsoft.VisualStudio.TestWindow.TestWindowStoreService.x64.servicehub.service.json" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="TestStore\x64\TestDiscoveryListener.x64.servicehub.service.json" />
    <Asset Type="Microsoft.ServiceHub.Service" Path="Te