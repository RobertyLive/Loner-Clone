ty),
            _code.SpaceAfter(Accessibility.ForGetter(navigationProperty)),
            _code.SpaceAfter(Accessibility.ForSetter(navigationProperty)));
    }
    
    public string AccessibilityAndVirtual(string accessibility)
    {
        return accessibility + (accessibility != "private" ? " virtual" : "");
    }
    
    public string EntityClassOpening(EntityType entity)
    {
        return string.Format(
            CultureInfo.InvariantCulture,
            "{0} {1}partial class {2}{3}",
            Accessibility.ForType(entity),
            _code.SpaceAfter(_code.AbstractOption(entity)),
            _code.Escape(entity),
            _code.StringBefore(" : ", _typeMapper.GetTypeName(entity.BaseType)));
    }
    
    public string EnumOpening(SimpleType enumType)
    {
        return string.Format(
            CultureInfo.InvariantCulture,
            "{0} enum {1} : {2}",
            Accessibility.ForType(enumType),
            _code.Escape(enumType),
            _code.Escape(_typeMapper.UnderlyingClrType(enumType)));
        }
    
    public void WriteFunctionParameters(EdmFunction edmFunction, Action<string, string, string, string> writeParameter)
    {
        var parameters = FunctionImportParameter.Create(edmFunction.Parameters, _code, _ef);
        foreach (var parameter in parameters.Where(p => p.NeedsLocalVariable))
        {
            var isNotNull = parameter.IsNullableOfT ? parameter.FunctionParameterName + ".HasValue" : parameter.FunctionParameterName + " != null";
            var notNullInit = "new ObjectParameter(\"" + parameter.EsqlParameterName + "\", " + parameter.FunctionParameterName + ")";
            var nullInit = "new ObjectParameter(\"" + parameter.EsqlParameterName + "\", typeof(" + parameter.RawClrTypeName + "))";
            writeParameter(parameter.LocalVariableName, isNotNull, notNullInit, nullInit);
        }
    }
    
    public string ComposableFunctionMethod(EdmFunction edmFunction, string modelNamespace)
    {
        var parameters = _typeMapper.GetParameters(edmFunction);
        
        return string.Format(