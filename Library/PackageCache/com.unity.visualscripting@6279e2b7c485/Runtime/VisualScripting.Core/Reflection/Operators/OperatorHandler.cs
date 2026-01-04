name and optional version.
             Multiple attributes can be applied to indicate guard for multiple supported platforms.
             </summary>
             <remarks>
             Callers can apply a <see cref="T:System.Runtime.Versioning.SupportedOSPlatformGuardAttribute" /> to a field, property or method
             and use that field, property or method in a conditional or assert statements in order to safely call platform specific APIs.
            
             The type of the field or property should be boolean, the method return type should be boolean in order to be used as platform guard.
             </remarks>
        </member>
        <member name="T