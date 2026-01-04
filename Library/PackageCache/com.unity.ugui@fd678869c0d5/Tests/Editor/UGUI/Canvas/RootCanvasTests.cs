<?xml version="1.0"?>
<doc>
    <assembly>
        <name>System.Configuration.ConfigurationManager</name>
    </assembly>
    <members>
        <member name="T:System.Configuration.DictionarySectionHandler">
             <summary>
             Simple dictionary config factory
             config is a dictionary mapping key-&gt;value
            
                 &lt;add key="name" value="text"&gt;  sets key=text
                 &lt;remove key="name"&gt;            removes the definition of key
                 &lt;clear&gt;                        removes all definitions
            
             </summary>
        </member>
        <member name="M:System.Configuration.DictionarySectionHandler.Create(System.Object,System.Object,System.Xml.XmlNode)">
            <summary>
            Given a partially composed config object (possibly null)
            and some input from the config system, return a
            further partially composed config object
            </summary>
        </member>
        <member name="P:System.Configuration.DictionarySectionHandler.KeyAttributeName">
            <summary>
            Make the name of the key attribute configurable by derived classes.
            </summary>
        </member>
        <member name="P:System.Configuration.DictionarySectionHandler.ValueAttributeName">
            <summary>
            Make the name of the value attribute configurable by derived classes.
            </summary>
        </member>
        <member name="T:System.Configuration.Internal.DummyDisposable">
            <summary>
            Used to satisfy legacy interfaces.
            </summary>
        </member>
        <member name="M:System.Configuration.Internal.WriteFileContext.ReplaceFile(System.String,System.String)">
            <summary>
            Replace one file with another, retrying if locked.
            </summary>
        </member>
        <member name="T:System.Configuration.IPersistComponentSettings">
            <summary>
            Components should implement this interface if they want to persist custom settings
            in a hosting application. This interface allows the application author to tell a control
            whether to persist, when to load, save etc.
            </summary>
        </member>
        <member name="P:System.Configuration.IPersistComponentSettings.SaveSettings">
            <summary>
            Indicates to