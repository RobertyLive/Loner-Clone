<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<assembly
    xmlns="urn:schemas-microsoft-com:asm.v3"
    xmlns:xsd="http://www.w3.org/2001/XMLSchema"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
    manifestVersion="1.0"
    >
  <assemblyIdentity
      language="neutral"
      name="Microsoft-Windows-CAPI2-certs"
      processorArchitecture="*"
      version="0.0.0.0"
      />
  <migration
      critical="Yes"
      replacementSettingsVersionRange="0-3"
      scope="Upgrade,MigWiz,USMT,Data"
      settingsVersion="4"
      >
    <migXml xmlns="">
      <rules context="User">
        <include>
          <objectSet>
            <pattern type="File">%CSIDL_APPDATA%\Microsoft\SystemCertificates\My\Certificates[*]</pattern>
            <pattern type="File">%CSIDL_APPDATA%\Microsoft\SystemCertificates\Request\Certificates[*]</pattern>
            <pattern type="Registry">HKCU\SOFTWARE\Microsoft\SystemCertificates\*[*]</pattern>
          </objectSet>
        </include>
        <merge script="MigXmlHelper.SourcePriority()">
          <objectSet>
            <pattern type="File">%CSIDL_APPDATA%\Microsoft\SystemCertificates\My\Certificates[*]</pattern>
            <pattern type="File">%CSIDL_APPDATA%\Microsoft\SystemCertificates\Request\Certificates[*]</pattern>
            <pattern type="Registry">HKCU\SOFTWARE\Microsoft\SystemCertificates\*[*]</pattern>
          </objectSet>
        </merge>
      </rules>
    </migXml>
    <machineSpecific>
      <migXml xmlns="">
        <rules context="System">
          <include>
            <objectSet>
              <pattern type="Registry">HKLM\SOFTWARE\Microsoft\SystemCertificates\My\Certificates\*[*]</pattern>
              <pattern type="File">%windir%\ServiceProfiles\NetworkService\AppData\Roaming\Microsoft\SystemCertificates\My\Certificates[*]</pattern>
              <pattern type="File">%windir%\System32\config\systemprofile\AppData\Roaming\Microsoft\SystemCertificates\My\Certificates[*]</pattern>
              <pattern type="Registry">HKLM\SOFTWARE\Microsoft\Cryptography\OID\EncodingType 0\CryptDllFindOIDInfo\*[*]</pattern>
              <pattern type="Registry">HKLM\SOFTWARE\WOW6432Node\Microsoft\Cryptography\OID\EncodingType 0\CryptDllFindOIDInfo\*[*]</pattern>
              <pattern type="Registry">HKLM\SOFTWARE\Microsoft\Cryptography\OID\EncodingType 1\CertDllVerifyRevocation\DEFAULT [Dll]</pattern>
              <pattern type="Registry">HKLM\SOFTWARE\WOW6432Node\Microsoft\Cryptography\OID\EncodingType 1\CertDllVerifyRevocation\DEFAULT [Dll]</pattern>
            </objectSet>
          </include>
          <merge script="MigXmlHelper.SourcePriority()">
            <objectSet>
              <pattern type="Registry">HKLM\SOFTWARE\Microsoft\SystemCertificates\My\Certificates\*[*]</pattern>
              <pattern type="File">%windir%\ServiceProfiles\NetworkService\AppData\Roaming\Microsoft\SystemCertificates\My\Certificates[*]</pattern>
              <pattern type="File">%windir%\System32\config\systemprofile\AppData\Roaming\Microsoft\SystemCertificates\My\Certificates[*]</pattern>
            </objectSet>
          </merge>
          <merge script="MigXmlHelper.DestinationPriority()">
            <objectSet>
              <pattern type="Registry">HKLM\SOFTWARE\Microsoft\Cryptography\OID\EncodingType 0\CryptDllFindOIDInfo\*[*]</pattern>
              <pattern type="Registry">HKLM\SOFTWARE\WOW6432Node\Microsoft\Cryptography\OID\EncodingType 0\CryptDllFindOIDInfo\*[*]</pattern>
            </objectSet>
          </merge>
          <contentModify script="MigXmlHelper.MergeMultiSzContent()">
            <objectSet>
              <pattern type="Registry">HKLM\SOFTWARE\Microsoft\Cryptography\OID\EncodingType 1\CertDllVerifyRevocation\DEFAULT [Dll]</pattern>
              <pattern type="Registry">HKLM\SOFTWARE\WOW6432Node\Microsoft\Cryptography\OID\EncodingType 1\CertDllVerifyRevocation\DEFAULT [Dll]</pattern>
            </objectSet>
          </contentModify>
        </rules>
      </migXml>
    </machineSpecific>
    <migXml xmlns="">
      <rules context="System">
        <include>
          <objectSet>
            <pattern type