le<{1}> {2}({3})",
            AccessibilityAndVirtual(Accessibility.ForMethod(edmFunction)),
            _typeMapper.GetTypeName(_typeMapper.GetReturnType(edmFunction), modelNamespace),
            _code.Escape(edmFunction),
            string.Join(", ", parameters.Select(p => TypeMapper.FixNamespaces(p.FunctionParameterType) + " " + p.FunctionParameterName).ToArray()));
    }
    
    public string ComposableCreateQuery(EdmFunction edmFunction, string modelNamespace)
    {
        var parameters = _typeMapper.GetParameters(edmFunction);
        
        return string.Format(
            CultureInfo.InvariantCulture,
            "return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<{0}>(\"[{1}].[{2}]({3})\"{4});",
            _typeMapper.GetTypeName(_typeMapper.GetReturnType(edmFunction), modelNamespace),
            edmFunction.NamespaceName,
            edmFunction.Name,
            string.Join(", ", parameters.Select(p => "@" + p.EsqlParameterName).ToArray()),
            _code.StringBefore(", ", string.Join(", ", parameters.Select(p => p.ExecuteParameterName).ToArray())));
    }
    
    public string FunctionMethod(EdmFunction edmFunction, string modelNamespace, bool includeMergeOption)
    {
        var parameters = _typeMapper.GetParameters(edmFunction);
        var returnType = _typeMapper.GetReturnType(edmFunction);

        var paramList = String.Join(", ", parameters.Select(p => TypeMapper.FixNamespaces(p.FunctionParameterType) + " " + p.FunctionParameterName).ToArray());
        if (includeMergeOption)
        {
            paramList = _code.StringAfter(paramList, ", ") + "MergeOption mergeOption";
        }

        return string.Format(
            CultureInfo.InvariantCulture,
            "{0} {1} {2}({3})",
            AccessibilityAndVirtual(Acc