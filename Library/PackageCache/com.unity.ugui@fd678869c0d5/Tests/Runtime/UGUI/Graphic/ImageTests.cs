e PSType="StorageSubSystem.CreateVirtualDisk.ParityLayout" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- RequestNoSinglePointOfFailure -->
            <Parameter ParameterName="RequestNoSinglePointOfFailure">
              <Type PSType="System.Boolean" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- ProvisioningType -->
            <Parameter ParameterName="ProvisioningType">
              <Type PSType="StorageSubSystem.ProvisioningType" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- IsEnclosureAware -->
            <Parameter ParameterName="IsEnclosureAware">
              <Type PSType="System.Management.Automation.SwitchParameter" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- FaultDomainAwareness -->
            <Parameter ParameterName="FaultDomainAwareness">
              <Type PSType="StorageSubSystem.FaultDomainType" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- CMDLET OUTPUT -->
            <Parameter ParameterName="CreatedVirtualDisk">
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" />
              <CmdletOutputMetadata />
            </Parameter>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByFriendlyName">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByUniqueId" Aliases="StorageSubsystemId" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemFriendlyName -->
            <Property PropertyName="FriendlyName">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemFriendlyName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByFriendlyName" Position="0" ErrorOnNoMatch="true" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemName -->
            <Property PropertyName="Name">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByName" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
      <!--

      //
      // New-MaskingSet
      //

      -->
      <Cmdlet>
        <CmdletMetadata Verb="New" Noun="MaskingSet" />
        <Method MethodName="CreateMaskingSet">
          <Parameters>
            <!-- FriendlyName -->
            <Parameter ParameterName="FriendlyName">
              <Type PSType="System.String" />
              <CmdletParameterMetadata Aliases="MaskingSetFriendlyName">
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- VirtualDiskNames -->
            <Parameter ParameterName="VirtualDiskNames">
              <Type PSType="System.String[]" />
              <CmdletParameterMetadata>
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- InitiatorAddresses -->
            <Parameter ParameterName="InitiatorAddresses">
              <Type PSType="System.String[]" />
              <CmdletParameterMetadata>
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- TargetPortAddresses -->
            <Parameter ParameterName="TargetPortAddresses">
              <Type PSType="System.String[]" />
              <CmdletParameterMetadata>
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- DeviceNumbers -->
            <Parameter ParameterName="DeviceNumbers">
              <Type PSType="System.String[]"/>
              <CmdletParameterMetadata>
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- DeviceAccesses -->
            <Parameter ParameterName="DeviceAccesses">
              <Type PSType="StorageSubSystem.CreateMaskingSet.DeviceAccess[]" />
              <CmdletParameterMetadata>
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- HostMode -->
            <Parameter ParameterName="HostType">
              <Type PSType="StorageSubSystem.CreateMaskingSet.HostMode" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- CMDLET OUTPUT -->
            <Parameter ParameterName="CreatedMaskingSet">
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" />
              <CmdletOutputMetadata />
            </Parameter>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByFriendlyName">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByUniqueId" Aliases="StorageSubsystemId" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemFriendlyName -->
            <Property PropertyName="FriendlyName">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemFriendlyName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByFriendlyName" Position="0" ErrorOnNoMatch="true" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemName -->
            <Property PropertyName="Name">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByName" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
      <!--

      //
      // New-StorageFileServer
      //

      -->
      <Cmdlet>
        <CmdletMetadata Verb="New" Noun="StorageFileServer" />
        <Method MethodName="CreateFileServer">
          <Parameters>
            <Parameter ParameterName="HostNames">
              <Type PSType="System.String[]" />
              <CmdletParameterMetadata IsMandatory="true">
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <Parameter ParameterName="FileSharingProtocols">
              <Type PSType="StorageSubSystem.CreateFileServer.FileSharingProtocol[]"/>
              <CmdletParameterMetadata PSName="Protocols" IsMandatory="true">
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <Parameter ParameterName="FriendlyName">
              <Type PSType="System.String" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- CMDLET OUTPUT -->
            <Parameter ParameterName="CreatedFileServer">
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" />
              <CmdletOutputMetadata />
            </Parameter>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByFriendlyName">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery>
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByUniqueId" Aliases="StorageSubSystemId" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemFriendlyName -->
            <Property PropertyName="FriendlyName">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata  PSName="StorageSubSystemFriendlyName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByFriendlyName" Position="0" ErrorOnNoMatch="true" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemName -->
            <Property PropertyName="Name">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata  PSName="StorageSubSystemName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByName" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
      <!--

      //
      // Get-StorageDiagnosticInfo
      //

      -->
      <Cmdlet>
        <CmdletMetadata Verb="Get" Noun="StorageDiagnosticInfoInternal" />
        <Method MethodName="GetDiagnosticInfo">
          <Parameters>
            <Parameter ParameterName="DestinationPath">
              <Type PSType="System.String" />
              <CmdletParameterMetadata IsMandatory="true" >
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <Parameter ParameterName="TimeSpan">
              <Type PSType="System.UInt32" />
              <CmdletParameterMetadata />
            </Parameter>
            <Parameter ParameterName="ActivityId">
              <Type PSType="System.String" />
              <CmdletParameterMetadata />
            </Parameter>
            <Parameter ParameterName="ExcludeOperationalLog">
              <Type PSType="System.Management.Automation.SwitchParameter" />
              <CmdletParameterMetadata />
            </Parameter>
            <Parameter ParameterName="ExcludeDiagnosticLog">
              <Type PSType="System.Management.Automation.SwitchParameter" />
              <CmdletParameterMetadata />
            </Parameter>
            <Parameter ParameterName="IncludeLiveDump">
              <Type PSType="System.Management.Automation.SwitchParameter" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByUniqueId">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" CmdletParameterSets="ByUniqueId" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
      <!--

      //
      // Clear-StorageDiagnosticInfo
      //

      -->
      <Cmdlet>
        <CmdletMetadata Verb="Clear" Noun="StorageDiagnosticInfo" />
        <Method MethodName="ClearDiagnosticInfo">
          <Parameters>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByFriendlyName">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByUniqueId" Aliases="StorageSubsystemId" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemFriendlyName -->
            <Property PropertyName="FriendlyName">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemFriendlyName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByFriendlyName" Position="0" ErrorOnNoMatch="true" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemName -->
            <Property PropertyName="Name">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByName" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
      <!--

      //
      // Start-StorageDiagnosticLog
      //

      -->
      <Cmdlet>
        <CmdletMetadata Verb="Start" Noun="StorageDiagnosticLog" Aliases="Enable-StorageDiagnosticLog" />
        <Method MethodName="StartDiagnosticLog">
          <Parameters>
            <Parameter ParameterName="Level" DefaultValue="Informational">
              <Type PSType="StorageSubSystem.EnableDiagnosticLog.Level" />
              <CmdletParameterMetadata />
            </Parameter>
            <Parameter ParameterName="MaxLogSize">
              <Type PSType="System.UInt64" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByFriendlyName">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByUniqueId" Aliases="StorageSubsystemId" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemFriendlyName -->
            <Property PropertyName="FriendlyName">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemFriendlyName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByFriendlyName" Position="0" ErrorOnNoMatch="true" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemName -->
            <Property PropertyName="Name">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByName" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
      <!--

      //
      // Stop-StorageDiagnosticLog
      //

      -->
      <Cmdlet>
        <CmdletMetadata Verb="Stop" Noun="StorageDiagnosticLog" Aliases="Disable-StorageDiagnosticLog" />
        <Method MethodName="StopDiagnosticLog">
          <Parameters>
            <!-- SourceCaller -->
            <Parameter ParameterName="cim:operationOption:SourceCaller" DefaultValue="Microsoft.PowerShell">
              <Type PSType="System.String" />
            </Parameter>
          </Parameters>
        </Method>
        <GetCmdletParameters DefaultCmdletParameterSet="ByFriendlyName">
          <QueryableProperties>
            <!-- StorageSubSystemUniqueId -->
            <Property PropertyName="UniqueId">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="false">
                <CmdletParameterMetadata PSName="StorageSubSystemUniqueId" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByUniqueId" Aliases="StorageSubsystemId" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemFriendlyName -->
            <Property PropertyName="FriendlyName">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemFriendlyName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByFriendlyName" Position="0" ErrorOnNoMatch="true" />
              </RegularQuery>
            </Property>
            <!-- StorageSubSystemName -->
            <Property PropertyName="Name">
              <Type PSType="System.String" />
              <RegularQuery AllowGlobbing="true">
                <CmdletParameterMetadata PSName="StorageSubSystemName" IsMandatory="true" ValueFromPipelineByPropertyName="true" CmdletParameterSets="ByName" />
              </RegularQuery>
            </Property>
          </QueryableProperties>
        </GetCmdletParameters>
      </Cmdlet>
    </InstanceCmdlets>
  </Class>
  <Enums>
    <Enum EnumName="StorageSubSystem.EnableDiagnosticLog.Level" UnderlyingType="System.UInt16">
      <Value Name="Critical" Value="1" />
      <Value Name="Error" Value="2" />
      <Value Name="Warning" Value="3" />
      <Value Name="Informational" Value="4" />
      <Value Name="Verbose" Value="5" />
    </Enum>
    <Enum EnumName="StorageSubSystem.NameFormat" UnderlyingType="System.UInt16">
      <Value Name="Other" Value="1" />
      <Value Name="IP" Value="2" />
      <Value Name="Dial" Value="3" />
      <Value Name="HID" Value="4" />
      <Value Name="NWA" Value="5" />
      <Value Name="HWA" Value="6" />
      <Value Name="X25" Value="7" />
      <Value Name="ISDN" Value="8" />
      <Value Name="IPX" Value="9" />
      <Value Name="DCC" Value="10" />
      <Value Name="ICD" Value="11" />
      <Value Name="E164" Value="12" />
      <Value Name="SNA" Value="13" />
      <Value Name="OID" Value="14" />
      <Value Name="OSI" Value="14" />
      <Value Name="WWN" Value="15" />
      <Value Name="NAA" Value="16" />
    </Enum>
    <Enum EnumName="StorageSubSystem.HealthStatus" UnderlyingType="System.UInt16">
      <Value Name="Healthy" Value="0" />
      <Value Name="Warning" Value="1" />
      <Value Name="Unhealthy" Value="2" />
    </Enum>
    <Enum EnumName="StorageSubSystem