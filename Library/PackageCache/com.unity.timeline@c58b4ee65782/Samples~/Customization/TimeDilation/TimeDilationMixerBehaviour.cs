ng" />
              <CmdletParameterMetadata Aliases="StoragePoolOtherUsageDescription">
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- PhysicalDisks -->
            <Parameter ParameterName="PhysicalDisks">
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance[]" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_PhysicalDisk" />
              <CmdletParameterMetadata IsMandatory="true">
                <ValidateNotNull />
                <ValidateNotNullOrEmpty />
              </CmdletParameterMetadata>
            </Parameter>
            <!-- ProvisioningTypeDefault -->
            <Parameter ParameterName="ProvisioningTypeDefault">
              <Type PSType="StorageSubSystem.ProvisioningType" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- MediaTypeDefault -->
            <Parameter ParameterName="MediaTypeDefault">
              <Type PSType="StorageSubSystem.MediaType" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- EnclosureAwareDefault -->
            <Parameter ParameterName="EnclosureAwareDefault">
              <Type PSType="System.Boolean" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- FaultDomainAwarenessDefault -->
            <Parameter ParameterName="FaultDomainAwarenessDefault">
              <Type PSType="StorageSubSystem.FaultDomainType" />
              <CmdletParameterMetadata />
            </Parameter>
            <!-- ResiliencySettingNameDefault -->
            <Parameter ParameterName="Resilie