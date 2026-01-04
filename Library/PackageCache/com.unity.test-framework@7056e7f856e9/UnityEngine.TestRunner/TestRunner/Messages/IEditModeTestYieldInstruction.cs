cture.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_Partition" />
              <CmdletParameterMetadata PSName="Partition" ValueFromPipeline="true" CmdletParameterSets="ByPartition" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- Volume -->
          <Association Association="MSFT_StorageSubSystemToVolume" SourceRole="Volume" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_Volume" />
              <CmdletParameterMetadata PSName="Volume" ValueFromPipeline="true" CmdletParameterSets="ByVolume" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- FileServer -->
          <Association Association="MSFT_StorageSubSystemToFileServer" SourceRole="FileServer" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_FileServer" />
              <CmdletParameterMetadata PSName="FileServer" ValueFromPipeline="true" CmdletParameterSets="ByFileServer" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- StorageFaultDomain-->
          <Association Association="MSFT_StorageSubSystemToStorageFaultDomain" SourceRole="StorageFaultDomain" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_StorageFaultDomain" />
              <CmdletParameterMetadata PSName="StorageFaultDomain" ValueFromPipeline="true" CmdletParameterSets="ByStorageFault