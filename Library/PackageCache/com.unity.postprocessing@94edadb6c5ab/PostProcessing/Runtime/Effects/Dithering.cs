er).ObjectContext.CreateQuery(Of {0})(""[{1}].[{2}]({3})""{4})", _
            _typeMapper.GetTypeName(_typeMapper.GetReturnType(edmFunction), modelNamespace), _
            edmFunction.NamespaceName, _
            edmFunction.Name, _
            String.Join(", ", parameters.Select(Function(p) "@" & Convert.ToString(p.EsqlParameterName)).ToArray()), _
            _code.StringBefore(", ", String.Join(", ", parameters.Select(Function(p) p.ExecuteParameterName).ToArray())))
    End Function

    Public Function FunctionMethod(edmFunction As EdmFunction, modelNamespace As String, includeMergeOption As Boolean) As String
        Dim parameters as IEnumerable(Of FunctionImportParameter) = _typeMapper.GetParameters(edmFunction)
        Dim returnType as TypeUsage = _typeMapper.GetReturnType(edmFunction)

        Dim paramList as String = String.Join(", ", parameters.Select(Function(p) p.FunctionParameterName & " As " & p.FunctionParameterType).ToArray())
        If includeMergeOption Then
            paramList = _code.StringAfter(paramList, ", ") & "mergeOption As MergeOption"
        End If

        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "{0} Function {1}({2}) As {3}", _
            AccessibilityAndVirtual(Accessibility.ForMethod(edmFunction)), _
            _code.Escape(edmFunction), _
            paramList, _
           