e="VirtualDisk" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_VirtualDisk" />
              <CmdletParameterMetadata PSName="VirtualDisk" ValueFromPipeline="true" CmdletParameterSets="ByVirtualDisk" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- MaskingSet -->
          <Association Association="MSFT_StorageSubSystemToMaskingSet" SourceRole="MaskingSet" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_MaskingSet" />
              <CmdletParameterMetadata PSName="MaskingSet" ValueFromPipeline="true" CmdletParameterSets="ByMaskingSet" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- TargetPort -->
          <Association Association="MSFT_StorageSubSystemToTargetPort" SourceRole="TargetPort" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_TargetPort" />
              <CmdletParameterMetadata PSName="TargetPort" ValueFromPipeline="true" CmdletParameterSets="ByTargetPort" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- TargetPortal -->
          <Association Association="MSFT_StorageSubSystemToTargetPortal" SourceRole="TargetPortal" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_TargetPortal" />
              <CmdletParameterMetadata PSName="TargetPortal" ValueFromPipeline="true" CmdletParameterSets="ByTargetPortal" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- InitiatorId -->
          <Association Association="MSFT_StorageSubSystemToInitiatorId" SourceRole="InitiatorId" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Management.Infrastructure.CimInstance#MSFT_InitiatorId" />
              <CmdletParameterMetadata PSName="InitiatorId" ValueFromPipeline="true" CmdletParameterSets="ByInitiatorId" ErrorOnNoMatch="false" />
            </AssociatedInstance>
          </Association>
          <!-- OffloadDataTransferSetting -->
          <Association Association="MSFT_StorageSubSystemToOffloadDataTransferSetting" SourceRole="OffloadDataTransferSetting" ResultRole="StorageSubSystem">
            <AssociatedInstance>
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance" ETSType="Microsoft.Manag