SType="string[]"/>
              <CmdletParameterMetadata PSName="RemoteAddress"/>
            </Parameter>
            <Parameter ParameterName="cim:OperationOption:Protocol">
              <Type PSType="string"/>
              <CmdletParameterMetadata PSName="Protocol"/>
            </Parameter>
            <Parameter ParameterName="cim:OperationOption:LocalPort">
              <Type PSType="string[]"/>
              <CmdletParameterMetadata PSName="LocalPort"/>
            </Parameter>
            <Parameter ParameterName="cim:OperationOption:RemotePort">
              <Type PSType="string[]"/>
              <CmdletParameterMetadata PSName="RemotePort"/>
            </Parameter>
            <Parameter ParameterName="cim:OperationOption:InterfaceAlias">
              <Type PSType="System.Management.Automation.WildcardPattern[]"/>
              <CmdletParameterMetadata PSName="InterfaceAlias"/>
            </Parameter>
            <Parameter ParameterName="cim:OperationOption:InterfaceType">
              <Type PSType="NetSecurity.InterfaceType"/>
              <CmdletParameterMetadata PSName="InterfaceType"/>
            </Parameter>
          </Parameters>
        </Method>
      </Cmdlet>
      <Cmdlet>
        <CmdletMetadata Verb="Show"/>
        <Method MethodName="EnumerateFull">
          <ReturnValue>
            <Type PSType="System.Int32"/>
            <CmdletOutputMetadata>
              <ErrorCode/>
            </CmdletOutputMetadata>
          </ReturnValue>
          <Parameters>
            <Parameter ParameterName="cim:OperationOption:PolicyStore">
              <Type PSType="string"/>
              <CmdletParameterMetadata PSName="PolicyStore"/>
            </Parameter>
            <Parameter ParameterName="cim:OperationOption:GPOSession">
              <Type PSType="string"/>
              <CmdletParameterMetadata PSName="GPOSession"/>
            </Parameter>
            <Parameter ParameterName="Dependents">
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance[]" ETSType="Microsoft.Management.Infrastructure.CimInstance#root/standardcimv2/NetSecurityDeepEnumElement"/>
              <CmdletOutputMetadata PSName="Dependents"/>
            </Parameter>
          </Parameters>
        </Method>
      </Cmdlet>
      <Cmdlet>
        <CmdletMetadata Verb="Find"/>
        <Method MethodName="Find">
          <ReturnValue>
            <Type PSType="System.Int32"/>
            <CmdletOutputMetadata>
              <ErrorCode/>
            </CmdletOutputMetadata>
          </ReturnValue>
          <Parameters>
            <Parameter ParameterName="LocalAddress">
              <Type PSType="string"/>
              <CmdletParameterMetadata PSName="LocalAddress"/>
            </Parameter>
            <Parameter ParameterName="RemoteAddress">
              <Type PSType="string"/>
              <CmdletParameterMetadata IsMandatory="true" PSName="RemoteAddress"/>
            </Parameter>
            <Parameter ParameterName="Protocol">
              <Type PSType="string"/>
              <CmdletParameterMetadata PSName="Protocol"/>
            </Parameter>
            <Parameter ParameterName="LocalPort">
              <Type PSType="uint16"/>
              <CmdletParameterMetadata PSName="LocalPort"/>
            </Parameter>
            <Parameter ParameterName="RemotePort">
              <Type PSType="uint16"/>
              <CmdletParameterMetadata PSName="RemotePort"/>
            </Parameter>
            <Parameter ParameterName="CmdletOutput">
              <Type PSType="Microsoft.Management.Infrastructure.CimInstance[]"/>
              <CmdletOutputMetadata PSName="CmdletOutput"/>
            </Parameter>
          </Parameters>
        </Method>
      </Cmdlet>
    </StaticCmdlets>
  </Class>
  <Enums>
    <Enum EnumName="NetSecurity.Enabled" UnderlyingType="uint16">
      <Value Name="True" Value="1"/>
      <Value Name="False" Value="2"/>
    </Enum>
    <Enum EnumName="NetSecurity.Profile" UnderlyingType="uint16" BitwiseFlags="true">
      <Value Name="Any" Value="0"/>
      <Value Name="Public" Value="4"/>
      <Value Name="Private" Value="2"/>
      <Value Name="Domain" Value="1"/>
      <Value Name="NotApplicable" Value="65535"/>
    </Enum>
    <Enum EnumName="NetSecurity.IPsecMode" UnderlyingType="uint16">
      <Value Name="None" Value="0"/>
      <Value Name="Transport" Value="3"/>
      <Value Name="Tunnel" Value="2"/>
    </Enum>
    <Enum EnumName="NetSecurity.SecurityPolicy" UnderlyingType="uint16">
      <Value Name="None