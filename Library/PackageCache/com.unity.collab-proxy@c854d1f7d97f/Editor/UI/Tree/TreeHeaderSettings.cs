.ClientSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="comContracts" type="System.ServiceModel.Configuration.ComContractsSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="commonBehaviors" type="System.ServiceModel.Configuration.CommonBehaviorsSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowDefinition="MachineOnly" allowExeDefinition="MachineOnly"/>
            <section name="diagnostics" type="System.ServiceModel.Configuration.DiagnosticSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="extensions" type="System.ServiceModel.Configuration.ExtensionsSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="machineSettings" type="System.ServiceModel.Configuration.MachineSettingsSection, SMDiagnostics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowDefinition="MachineOnly" allowExeDefinition="MachineOnly"/>
            <section name="protocolMapping" type="System.ServiceModel.Configuration.ProtocolMappingSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="serviceHostingEnvironment" type="System.ServiceModel.Configuration.ServiceHostingEnvironmentSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" allowDefinition="MachineToApplication"/>
            <section name="services" type="System.ServiceModel.Configuration.ServicesSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="standardEndpoints" type="System.ServiceModel.Configuration.StandardEndpointsSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="routing" type="System.ServiceModel.Routing.Configuration.RoutingSection, System.ServiceModel.Routing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
            <section name="tracking" type="System.ServiceModel.Activities.Tracking.Configuration.TrackingSection, System.ServiceModel.Activities, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" />
        </sectionGroup>
        <sectionGroup name="system.serviceModel.activation" type="System.ServiceModel.Activation.Configuration.ServiceModelActivationSectionGroup, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089">
            <section name="diagnostics" type="System.ServiceModel.Activation.Configuration.DiagnosticSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="net.pipe" type="System.ServiceModel.Activation.Configuration.NetPipeSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
            <section name="net.tcp" type="System.ServiceModel.Activation.Configuration.NetTcpSection, System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"/>
        </sectionGroup>
        <sectionGroup name="system.transactions" type="System.Transactions.Configuration.TransactionsSectionGroup, System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, Custom=null">
           <section name="defaultSettings" type="System.Transactions.Configuration.DefaultSettingsSection, System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, Custom=null" />
           <section name="machineSettings" type="System.Transactions.Configuration.MachineSettingsSection, System.Transactions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, Custom=null" allowDefinition="MachineOnly" allowExeDefinition="MachineOnly"/>
        </sectionGroup>
        <sectionGroup name="system.web" type="System.Web.Configuration.SystemWebSectionGroup, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a">
            <section name="anonymousIdentification" type="System.Web.Configuration.AnonymousIdentificationSection, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" allowDefinition="MachineToApplication" />
            <section name="authentication" type="System.Web.Configuration.AuthenticationSection, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" allowDefinition="MachineToApplication" />
            <section name="authorization" type="System.Web.Configuration.AuthorizationSection, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
            <section name="browserCaps" type="System.Web.Configuration.HttpCapabilitiesSectionHandler, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
            <section name="clientTarget" type="System.Web.Configuration.ClientTargetSection, System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" />
            <section name="compilation" type="System.Web.C