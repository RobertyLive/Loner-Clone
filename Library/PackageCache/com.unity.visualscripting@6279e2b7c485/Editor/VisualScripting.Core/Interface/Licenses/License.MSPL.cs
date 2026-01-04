ent path</param>
            <param name="configContext">reserved, in ASP.NET used to convey virtual path of config being evaluated</param>
            <param name="section">the xml node rooted at the section to handle</param>
            <returns>a new config object</returns>
        </member>
        <member name="M:System.Configuration.IgnoreSectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)">
            <summary>
                Given a partially composed config object (possibly null) and some input from the config system,
                return a further partially composed config object.
            </summary>
        </member>
        <member name="T:System.Configuration.ISettingsProviderService">
            <summary>
            The IPersistComponentSettings interface enables components hosted in an application to persist their
            settings in a manner transparent to the application. However, in some cases, the application may want to
            override the provider(s) specified by a component. For example, at design time, we may want to persist
            settings differently. This service enables this scenario. The ApplicationSettingsBase class queries this
            service from the owner component's site.
            </summary>
        </member>
        <member name="M:System.Configuration.ISettingsProviderService.GetSettingsProvider(System.Configuration.SettingsProperty)">
            <summary>
            Queries the service whether it wants to override the provider for the given SettingsProperty. If it
            doesn't want to, it should return null, in which the provider will remain unchanged.
            </summary>
        </member>
        <member name="T:System.Configuration.LocalFileSettingsProvider">
            <summary>
            This is a provider used to store configuration settings locally for client applications.
            </summary>
        </member>
        <member name="P:System.Configuration.LocalFileSettingsProvider.ApplicationName">
            <summary>
            Abstract SettingsProvider property.
            </summary>
        </member>
        <member name="P:System.Configuration.LocalFileSettingsProvider.Store">
            <summary>
            We maintain a single instance of the ClientSettingsStore per instance of provider.
            </summary>
        </member>
        <member name="M:System.Configuration.LocalFileSettingsProvider.Initialize(System.String,System.Collections.Specialized.NameValueCollection)">
            <summary>
            Abstract ProviderBase method.
            </summary>
        </member>
        <member name="M:System.Configuration.Local