      <member name="M:System.Configuration.XmlUtil.VerifyIgnorableNodeType(System.Configuration.ExceptionAction)">
            <summary>
            Add an error if the node type is not permitted by the configuration schema.
            </summary>
        </member>
        <member name="M:System.Configuration.XmlUtil.VerifyNoUnrecognizedAttributes(System.Configuration.ExceptionAction)">
            <summary>
            Add an error if there are attributes that have not been examined, and are therefore unrecognized.
            </summary>
        </member>
        <member name="M:System.Configuration.XmlUtil.VerifyRequiredAttribute(System.Object,System.String,System.Configuration.ExceptionAction)">
            <summary>
            Add an error if the retrieved attribute is null, and therefore not present.
            </summary>
        </member>
        <member name="M:System.Configuration.XmlUtil.VerifyAndGetBooleanAttribute(System.Configuration.ExceptionAction,System.Boolean,System.Boolean@)">
            <summary>
            Verify and Retrieve the Boolean Attribute.  If it is not
            a valid value then log an error and set the