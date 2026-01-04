_typeMapper.GetTypeName(returnType, modelNamespace) + ">",
            _code.Escape(edmFunction),
            paramList);
    }
    
    public string ExecuteFunction(EdmFunction edmFunction, string modelNamespace, bool includeMergeOption)
    {
        var parameters = _typeMapper.GetParameters(edmFunction);
        var returnType = _typeMapper.GetReturnType(edmFunction);

        var callParams = _code.StringBefore(", ", String.Join(", ", parameters.Select(p => p.ExecuteParameterName).ToArray()));
        if (includeMergeOption)
        {
            callParams = ", mergeOption" + callParams;
        }
        
        return string.Format(
            CultureInfo.InvariantCulture,
            "return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction{0}(\"{1}\"{2});",
            returnType == null ? "" : "<" + _typeMapper.GetTypeName(returnType, modelNamespace) + ">",
            edmFunction.Name,
            callParams);
    }
    
    public string DbSet(EntitySet entitySet)
    {
        return string.Format(
            CultureInfo.InvariantCulture,
            "{0} DbSet<{1}> {2} {{ get; set; }}",
            Accessibility.ForReadOnlyProperty(entitySet),
            _typeMapper.GetTypeName(entitySet.ElementType),
            _code.Escape(entitySet));
    }

    public string UsingDirectives(bool inHeader, bool includeCollections = true)
    {
        return inHeader == string.IsNullOrEmpty(_code.VsNamespaceSuggestion())
            ? string.Format(
                CultureInfo.InvariantCulture,
                "{0}using System;{1}" +
                "{2}",
                inHeader ? Environment.NewLine : "",
                includeCollections ? (Environment.NewLine + "using System.Collections.Generic;") : "",
                inHeader ? "" : Environment.NewLine)
            : "";
    }
}

public class TypeMapper
{
    private const string ExternalTypeNameAttributeName = @"http://schemas.microsoft.com/ado/2006/04/codegeneration:ExternalTypeName";

    private readonly System.Collections.IList _errors;
    private readonly CodeGenerationTools _code;
    private readonly MetadataTools _ef;

    public TypeMapper(CodeGenerationTools code, MetadataTools ef, System.Collections.IList errors)
    {
        ArgumentNotNull(code, "code");
        ArgumentNotNull(ef, "ef");
        ArgumentNotNull(errors, "errors");

        _code = code;
        _ef = ef;
        _errors = errors;
    }

    public string GetTypeName(TypeUsage typeUsage)
    {
        return typeUsage == null ? null : GetTypeName(typeUsage.EdmType, _ef.IsNullable(typeUsage), modelNamespace: null);
    }

    public string GetTypeName(EdmType edmType)
    {
        return GetTypeName(edmType, isNullable: null, modelNamespace: null);
    }

    public string GetTypeName(TypeUsage typeUsage, string modelNamespace)
    {
        return typeUsage == null ? null : GetTypeName(typeUsage.EdmType, _ef.IsNullable(typeUsage), modelNamespace);
    }

    public string GetTypeName(EdmType edmType, string modelNamespace)
    {
        return GetTypeName(edmType, isNullable: null, modelNamespace: modelNamespace);
    }

    public string GetTypeName(EdmType edmType, bool? isNullable, string modelNamespace)
    {
        if (edmType == null)
        {
            return null;
        }

        var collectionType = edmType as CollectionType;
        if (collectionType != null)
        {
            return String.Format(CultureInfo.InvariantCulture, "ICollection<{0}>", GetTypeName(collectionType.TypeUsage, modelNamespace));
        }

        var typeName = _code.Escape(edmType.MetadataProperties
                                .Where(p => p.Name == ExternalTypeNameAttributeName)
                                .Select(p => (string)p.Value)
                                .FirstOrDefault())
            ?? (modelNamespace != null && edmType.NamespaceName != modelNamespace ?
                _c