<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<assembly xmlns="urn:schemas-microsoft-com:asm.v3" manifestVersion="1.0" description="OpenSSH-based secure shell (SSH) client, for secure key management and access to remote machines." displayName="OpenSSH Client" copyright="Copyright (c) Microsoft Corporation. All Rights Reserved" supportInformation="http://support.microsoft.com/?kbid=777777">
  <assemblyIdentity name="OpenSSH-Client-Package" version="10.0.26100.7309" processorArchitecture="amd64" language="neutral" buildType="release" publicKeyToken="31bf3856ad364e35" />
  <package identifier="KB777778" releaseType="OnDemand Pack">
    <mum2:customInformation xmlns:mum2="urn:schemas-microsoft-com:asm.v3">
      <mum2:FodInformation Id="433" />
    </mum2:customInformation>
    <parent buildCompare="GE" revisionCompare="GE">
      <assemblyIdentity name="Microsoft-NanoServer-Edition-Core-Package" version="10.0.0.0" processorArchitecture="amd64" language="neutral" buildType="release" publicKeyToken="31bf3856ad364e35" />
    </parent>
    <parent buildCompare="GE" revisionCompare="GE">
      <assemblyIdentity name="Microsoft-Windows-Client-Features-Package" version="10.0.26100.7309" processorArchitecture="amd64" language="neutral" buildType="release" publicKeyToken="31bf3856ad364e35" />
    </parent>
    <parent buildCompare="GE" revisionCompare="GE">
      <assemblyIdentity name="Microsoft-Windows-Server-Features-Package" version="10.0.26100.7309" processorArchitecture="amd64" language="neutral" buildType="release" publicKeyToken="31bf3856ad364e35" />
    </parent>
    <declareCapability>
      <cap