or without a concept of "owner" component.
            </summary>
        </member>
        <member name="M:System.Configuration.ApplicationSettingsBase.#ctor(System.ComponentModel.IComponent)">
            <summary>
            Constructor that takes an IComponent. The IComponent acts as the "owner" of this settings class. One
            of the things we do is query the component's site to see if it has a SettingsProvider service. If it
            does, we allow it to override the providers specified in the metadata.
            </summary>
        </member>
        <member name="M:System.Configuration.ApplicationSettingsBase.#ctor(System.String)">
            <summary>
            Convenience overload that takes the settings key
            </summary>
        </member>
        <member name="M:System.Configuration.ApplicationSettingsBase.#ctor(System.ComponentModel.IComponent,System.String)">
            <summary>
            Convenience overload that takes the owner component and settings key.
            </summary>
        </member>
        <member name="P:System.Configuration.ApplicationSettingsBase.Context">
            <summary>
            The Context to pass on to the provider. Currently, this will just contain the settings group name.
            </summary>
        </member>
        <member name="P:System.Configuration.ApplicationSettingsBase.Properties">
            <summary>
            The SettingsBase class queries this to get the collection of SettingsProperty objects. We reflect over
            the properties defined on the current object's type and use the metadata on those properties to form
            this collection.
            </summary>
        </member>
        <member name="P:System.Configuration.ApplicationSettingsBase.PropertyValues">
            <summary>
            Just overriding to add attributes.
            </summary>
        </member>
        <member name="P:System.Configuration.ApplicationSettingsBase.Providers">
            <summary>
            Provider collection
            </summa