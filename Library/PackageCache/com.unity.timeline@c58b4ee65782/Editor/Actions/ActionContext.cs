ads to receive notice of cancellation. <see cref="T:System.Threading.CancellationToken"/>.</param>
        </member>
        <member name="T:Microsoft.IdentityModel.Protocols.IConfigurationValidator`1">
            <summary>
            Interface that defines a policy for validating configuration data.
            </summary>
            <typeparam name="T">The type of the configuration metadata.</typeparam>
        </member>
        <member name="M:Microsoft.IdentityModel.Protocols.IConfigurationValidator`1.Validate(`0)">
            <summary>
            Validate the retrieved configuration.
            </summary>
            <param name="configuration">Configuration of type T.</param>
            <returns><see cref="T:Microsoft.IdentityModel.Protocols.ConfigurationValidationResult"/>.</returns>
        </member>
        <member name="T:Microsoft.IdentityModel.Protocols.IDocumentRetriever">
            <summary>
            Interface that defines a document retriever that returns the document as a string.
            </summary>
        </member>
        <member name="M:Microsoft.IdentityModel.Protocols.IDocumentRetriever.GetDocumentAsync(System.String,System.Threading.CancellationToken)">
            <summary>
            Obtains a document from an address.
            </summary>
            <param name="address">location of document.</param>
            <param name="cancel"><see cref="T:System.Threading.CancellationToken"/>.</param>
            <returns>document as a string.</returns>
        </member>
        <member name="T:Microsoft.IdentityModel.Protocols.Configuration.InvalidConfigurationException">
            <summary>
            This exception is thrown when retrieved configuration is not valid.
            </summary>
        </member>
        <member name="M:Microsoft.IdentityModel.Protocols.Configuration.Inva