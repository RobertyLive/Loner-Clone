 Set{6}" & _
                "    End Property",  _
                name, _
                type, _
                defaultValue, _
                accessibility, _
                getterAccessibility, _
                setterAccessibility, _
                Environment.NewLine)
        End If
    End Function

    Public Function PropertyAccessibilityAndVirtual(ByVal member As EdmMember) As String
        Dim propertyAccess As String = Accessibility.ForProperty(member)
        Dim setAccess as String = Accessibility.ForSetter(member)
        Dim getAccess as String = Accessibility.ForGetter(member)
        If propertyAccess <> "Private" AndAlso setAccess <> "Private" AndAlso getAccess <> "Private" Then
            Return propertyAccess & " Overridable"
        End If

        Return propertyAccess
    End Function

    Public Function EntityClassOpening(entity As EntityType) As String
        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "Partial {0} {1}Class {2}{3}", _
            Accessibility.ForType(entity), _
            _code.SpaceAfter(_code.MustInheritOption(entity)), _
            _code.Escape(entity), _
            _code.StringBefore(Environment.NewLine & "         Inherits ", _typeMapper.GetTypeName(entity.BaseType)))
    End Function

    Public Function EnumOpening(enumType As SimpleType) As String
        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "{0} Enum {1} As {2}", _
            Accessibility.ForType(enumType),
            _code.Escape(enumType),
            _code.Escape(_typeMapper.UnderlyingClrType(enumType)))
    End Function

    Public Sub WriteFunctionParameters(edmFunction As EdmFunction, writeParameter As Action(Of String, String, String, String))
        Dim parameters as IEnumerable(Of FunctionImportParameter) = FunctionImportParameter.Create(edmFunction.Parameters, _code, _ef)
        For Each parameter As FunctionImportParameter In parameters.Where(Function(p) p.NeedsLocalVariable)
            Dim isNotNull as String = If(parameter.IsNullableOfT, parameter.FunctionParameterName & ".HasValue", parameter.FunctionParameterName & " IsNot Nothing")
            Dim notNullInit as String = "New ObjectParameter(""" & parameter.EsqlParameterName & """, " & parameter.FunctionParameterName & ")"
            Dim nullInit as String = "New ObjectParameter(""" & parameter.EsqlParameterName & """, GetType(" & TypeMapper.FixNamespaces(parameter.RawClrTypeName) & "))"
            writeParameter(parameter.LocalVariableName, isNotNull, notNullInit, nullInit)
        Next
    End Sub

    Public Function ComposableFunctionMethod(edmFunction As EdmFunction, modelNamespace As String) As String
        Dim parameters as IEnumerable(Of FunctionImportParameter) = _typeMapper.GetParameters(edmFunction)

        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "{0} Function {1}({2}) As IQueryable(Of {3})", _
            AccessibilityAndVirtual(Accessibility.ForMethod(edmFunction)), _
            _code.Escape(edmFunction), _
            String.Join(", ", parameters.Select(Function(p) p.FunctionParameterName & " As " & TypeMapper.FixNamespaces(p.FunctionParameterType)).ToArray()), _
            _typeMapper.GetTypeName(_typeMapper.GetReturnType(edmFunction), modelNamespace))
    End Function

    Public Function ComposableCreateQuery(edmFunction As EdmFunction, modelNamespace As String) As String
        Dim parameters as IEnumerable(Of FunctionImportParameter) = _typeMapper.GetParameters(edmFunction)

        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "Return DirectCast(Me, IObjectContextAdapter).ObjectContext.CreateQuery(Of {0})(""[{1}].[{2}]({3})""{4})", _
            _typeMapper.GetTypeName(_typeMapper.GetReturnType(edmFunction), modelNamespace), _
            edmFunction.NamespaceName, _
            edmFunction.Name, _
            String.Join(", ", parameters.Select(Function(p) "@" & Convert.ToString(p.EsqlParameterName)).ToArray()), _
            _code.StringBefore(", ", String.Join(", ", parameters.Select(Function(p) p.ExecuteParameterName).ToArray())))
    End Function

    Public Function FunctionMethod(edmFunction As EdmFunction, modelNamespace As String, includeMergeOption As Boolean) As String
        Dim parameters as IEnumerable(Of FunctionImportParameter) = _typeMapper.GetParameters(edmFunction)
        Dim returnType as TypeUsage = _typeMapper.GetReturnType(edmFunction)

        Dim paramList as String = String.Join(", ", parameters.Select(Function(p) p.FunctionParameterName & " As " & TypeMapper.FixNamespaces(p.FunctionParameterType)).ToArray())
        If includeMergeOption Then
            paramList = _code.StringAfter(paramList, ", ") & "mergeOption As MergeOption"
        End If

        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "{0} Function {1}({2}) As {3}", _
            AccessibilityAndVirtual(Accessibility.ForMethod(edmFunction)), _
            _code.Escape(edmFunction), _
            paramList, _
            If(returnType Is Nothing, "Integer", "ObjectResult(Of " & _typeMapper.GetTypeName(returnType, modelNamespace) & ")"))
    End Function

    Public Function ExecuteFunction(edmFunction As EdmFunction, modelNamespace As String, includeMergeOption As Boolean) As String
        Dim parameters as IEnumerable(Of FunctionImportParameter) = _typeMapper.GetParameters(edmFunction)
        Dim returnType as TypeUsage = _typeMapper.GetReturnType(edmFunction)

        Dim callParams as String = _code.StringBefore(", ", String.Join(", ", parameters.Select(Function(p) p.ExecuteParameterName).ToArray()))
        If includeMergeOption Then
            callParams = ", mergeOption" & callParams
        End If

        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction{0}(""{1}""{2})", _
            If(returnType Is Nothing, "", "(Of " & _typeMapper.GetTypeName(returnType, ModelNamespace) & ")"), _
            edmFunction.Name, _
            callParams)
    End Function

    Public Function DbSet(entitySet As EntitySet) As String
        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "{0} Overridable Property {1}() As DbSet(Of {2})", _
            Accessibility.ForReadOnlyProperty(entitySet), _
            _code.Escape(entitySet), _
            _typeMapper.GetTypeName(entitySet.ElementType))
    End Function

    Public Function DbSetInitializer(entitySet As EntitySet) As String
        Return String.Format( _
            CultureInfo.InvariantCulture, _
            "{0} = Me.Set(Of {1})()", _
            _code.Escape(entitySet), _
            _typeMapper.GetTypeName(entitySet.ElementType))
    End Function
End Class

Public Class TypeMapper
    Private Const ExternalTypeNameAttributeName As String = "http://schemas.microsoft.com/ado/2006/04/codegeneration:ExternalTypeName"

    Private ReadOnly _errors As System.Collections.IList
    Private ReadOnly _code As CodeGenerationTools
    Private ReadOnly _ef As MetadataTools

    Public Sub New(code As CodeGenerationTools, ef As MetadataTools, errors As System.Collections.IList)
        ArgumentNotNull(code, "code")
        ArgumentNotNull(ef, "ef")
        ArgumentNotNull(errors, "errors")

        _code = code
        _ef = ef
        _errors = errors
    End Sub

    Public Shared Function FixNamespaces(typeName As String) As String
        Return typeName.Replace("System.Data.Spatial.", "System.Data.Entity.Spatial.")
    End Function

    Public Function GetTypeName(typeUsage As TypeUsage) As String
        Return If(typeUsage Is Nothing, Nothing, GetTypeName(typeUsage.EdmType, _ef.IsNullable(typeUsage), modelNamespace := Nothing))
    End Function

    Public Function GetTypeName(edmType As EdmType) As String
        Return GetTypeName(edmType, isNullable := Nothing, modelNamespace := Nothing)
    End Function

    Public Function GetTypeName(typeUsage As TypeUsage, modelNamespace As String) As String
        Return If(typeUsage Is Nothing, Nothing, GetTypeName(typeUsage.EdmType, _ef.IsNullable(typeUsage), modelNamespace))
    End Function

    Public Function GetTypeName(edmType As EdmType, modelNamespace As String) As String
        Return GetTypeName(edmType, isNullable := Nothing, modelNamespace := modelNamespace)
    End Function

    Public Function GetTypeName(edmType As EdmType, isNullable As System.Nullable(Of Boolean), modelNamespace As String) As String
        If edmType Is Nothing Then
            Return Nothing
        End If

        Dim collectionType = TryCast(edmType, CollectionType)
        If collectionType IsNot Nothing Then
            Return String.Format(CultureInfo.InvariantCulture, "ICollection( Of {0})", GetTypeName(collectionType.TypeUsage, modelNamespace))
        End If

        Dim typeName = If(_code.Escape(edmType.MetadataProperties.Where(Function(p) p.Name = ExternalTypeNameAttributeName).Select(Function(p) DirectCast(p.Value, String)).FirstOrDefault()), (If(modelNamespace IsNot Nothing AndAlso edmType.NamespaceName <> modelNamespace, _code.CreateFullName(_code.EscapeNamespace(edmType.NamespaceName), _code.Escape(edmType)), _code.Escape(edmType))))

        If TypeOf edmType Is StructuralType Then
            Return typeName
        End If

        If TypeOf edmType Is SimpleType Then
            Dim clrType = UnderlyingClrType(edmType)
            If Not (IsEnumType(edmType)) Then
                typeName = _code.Escape(clrType)
            End If

            typeName = FixNamespaces(typeName)

            Return If(clrType.IsValueType AndAlso isNullable = True, String.Format(CultureInfo.InvariantCulture, "Nullable(Of {0})", typeName), typeName)
        End If

        Throw New ArgumentException("edmType")
    End Function

    Public Function UnderlyingClrType(edmType As EdmType) As Type
        ArgumentNotNull(edmType, "edmType")

        Dim primitiveType as PrimitiveType = TryCast(edmType, PrimitiveType)
        If primitiveType IsNot Nothing Then
            Return primitiveType.ClrEquivalentType
        End If

        If IsEnumType(edmType) Then
            Return GetEnumUnderlyingType(edmType).ClrEquivalentType
        End If

        Return GetType(Object)
    End Function

    Public Function GetEnumMemberValue(enumMember As MetadataItem) As Object
        ArgumentNotNull(enumMember, "enumMember")

        Dim valueProperty As PropertyInfo = enumMember.GetType().GetProperty("Value")
        Return If(valueProperty Is Nothing, Nothing, valueProperty.GetValue(enumMember, Nothing))
    End Function

    Public Function GetEnumMemberName(enumMember As MetadataItem) As String
        ArgumentNotNull(enumMember, "enumMember")

        Dim nameProperty As PropertyInfo = enumMember.GetType().GetProperty("Name")
        Return If(nameProperty Is Nothing, Nothing, DirectCast(nameProperty.GetValue(enumMember, Nothing), String))
    End Function

    Public Function GetEnumMembers(enumType As EdmType) As System.Collections.IEnumerable
        ArgumentNotNull(enumType, "enumType")

        Dim membersProperty As PropertyInfo = enumType.GetType().GetProperty("Members")
        Return If(membersProperty IsNot Nothing, DirectCast(membersProperty.GetValue(enumType, Nothing), System.Collections.IEnumerable), Enumerable.Empty(Of MetadataItem)())
    End Function

    Public Function EnumIsFlags(enumType As EdmType) As Boolean
        ArgumentNotNull(enumType, "enumType")

        Dim isFlagsProperty As PropertyInfo = enumType.GetType().GetProperty("IsFlags")
        Return isFlagsProperty IsNot Nothing AndAlso CBool(isFlagsProperty.GetValue(enumType, Nothing))
    End Function

    Public Function IsEnumType(edmType As GlobalItem) As Boolean
        ArgumentNotNull(edmType, "edmType")

        Return edmType.GetType().Name = "EnumType"
    End Function

    Public Function GetEnumUnderlyingType(enumType As EdmType) As PrimitiveType
        ArgumentNotNull(enumType, "enumType")

        Return DirectCast(enumType.GetType().GetProperty("UnderlyingType").GetValue(enumType, Nothing), PrimitiveType)
    End Function

    Public Function CreateLiteral(value As Object) As String
        If value Is Nothing OrElse value.GetType() IsNot GetType(TimeSpan) Then
            Return _code.CreateLiteral(value)
        End If

        Return String.Format(CultureInfo.InvariantCulture, "new TimeSpan({0})", DirectCast(value, TimeSpan).Ticks)
    End Function

    Public Function VerifyCaseInsensitiveTypeUniqueness(types As IEnumerable(Of String), sourceFile As String) As Boolean
        ArgumentNotNull(types, "types")
        ArgumentNotNull(sourceFile, "sourceFile")

        Dim hash As HashSet(Of String) = New HashSet(Of String)(StringComparer.InvariantCultureIgnoreCase)
        If types.Any(Function(item) Not hash.Add(item)) Then
            _errors.Add(New CompilerError(sourceFile, -1, -1, "6023", String.Format(CultureInfo.CurrentCulture, CodeGenerationTools.GetResourceString("Template_CaseInsensitiveTypeConflict"))))
            Return False
        End If
        Return True
    End Function

    Public Function GetEnumItemsToGenerate(itemCollection As IEnumerable(Of GlobalItem)) As IEnumerable(Of SimpleType)
        Return GetItemsToGenerate(Of SimpleType)(itemCollection).Where(Function(e) IsEnumType(e))
    End Function

    Public Function GetItemsToGenerate(Of T As EdmType)(itemCollection As IEnumerable(Of GlobalItem)) As IEnumerable(Of T)
        Return itemCollection.OfType(Of T)().Where(Function(i) Not i.MetadataProperties.Any(Function(p) p.Name = ExternalTypeNameAttributeName)).OrderBy(Function(i) i.Name)
    End Function

    Public Function GetAllGlobalItems(itemCollection As IEnumerable(Of GlobalItem)) As IEnumerable(Of String)
        Return itemCollection.Where(Function(i) TypeOf i Is EntityType OrElse TypeOf i Is ComplexType OrElse TypeOf i Is EntityContainer OrElse IsEnumType(i)).Select(Function(g) GetGlobalItemName(g))
    End Function

    Public Function GetGlobalItemName(item As GlobalItem) As String
        If TypeOf item Is EdmType Then
            Return DirectCast(item, EdmType).Name
        Else
            Return DirectCast(item, EntityContainer).Name
        End If
    End Function

    Public Function GetSimpleProperties(type As EntityType) As IEnumerable(Of EdmProperty)
        Return type.Properties.Where(Function(p) TypeOf p.TypeUsage.EdmType Is SimpleType AndAlso p.DeclaringType.Equals(type))
    End Function

    Public Function GetSimpleProperties(type As ComplexType) As IEnumerable(Of EdmProperty)
        Return type.Properties.Where(Function(p) TypeOf p.TypeUsage.EdmType Is SimpleType AndAlso p.DeclaringType.Equals(type))
    End Function

    Public Function GetComplexProperties(type As EntityType) As IEnumerable(Of EdmProperty)
        Return type.Properties.Where(Function(p) TypeOf p.TypeUsage.EdmType Is ComplexType AndAlso p.DeclaringType.Equals(type))
    End Function

    Public Function GetComplexProperties(type As ComplexType) As IEnumerable(Of EdmProperty)
        Return type.Properties.Where(Function(p) TypeOf p.TypeUsage.EdmType Is ComplexType AndAlso p.DeclaringType.Equals(type))
    End Function

    Public Function GetPropertiesWithDefaultValues(type As EntityType) As IEnumerable(Of EdmProperty)
        Return type.Properties.Where(Function(p) TypeOf p.TypeUsage.EdmType Is SimpleType AndAlso p.DeclaringType.Equals(type) AndAlso p.DefaultValue IsNot Nothing)
    End Function

    Public Function GetPropertiesWithDefaultValues(type As ComplexType) As IEnumerable(Of EdmProperty)
        Return type.Properties.Where(Function(p) TypeOf p.TypeUsage.EdmType Is SimpleType AndAlso p.DeclaringType.Equals(type) AndAlso p.DefaultValue IsNot Nothing)
    End Function

    Public Function GetNavigationProperties(type As EntityType) As IEnumerable(Of NavigationProperty)
        Return type.NavigationProperties.Where(Function(np) np.DeclaringType.Equals(type))
    End Function

    Public Function GetCollectionNavigationProperties(type As EntityType) As IEnumerable(Of NavigationProperty)
        Return type.NavigationProperties.Where(Function(np) np.DeclaringType.Equals(type) AndAlso np.ToEndMember.RelationshipMultiplicity = RelationshipMultiplicity.Many)
    End Function

    Public Function GetReturnParameter(edmFunction As EdmFunction) As FunctionParameter
        ArgumentNotNull(edmFunction, "edmFunction")

        Dim returnParamsProperty As PropertyInfo = edmFunction.GetType().GetProperty("ReturnParameters")
        Return If(returnParamsProperty Is Nothing, edmFunction.ReturnParameter, DirectCast(returnParamsProperty.GetValue(edmFunction, Nothing), IEnumerable(Of FunctionParameter)).FirstOrDefault())
    End Function

    Public Function IsComposable(edmFunction As EdmFunction) As Boolean
        ArgumentNotNull(edmFunction, "edmFunction")

        Dim isComposableProperty As PropertyInfo = edmFunction.GetType().GetProperty("IsComposableAttribute")
        Return isComposableProperty IsNot Nothing AndAlso CBool(isComposableProperty.GetValue(edmFunction, Nothing))
    End Function

    Public Function GetParameters(edmFunction As EdmFunction) As IEnumerable(Of FunctionImportParameter)
        Return FunctionImportParameter.Create(edmFunction.Parameters, _code, _ef)
    End Function

    Public Function GetReturnType(edmFunction As EdmFunction) As TypeUsage
        Dim returnParam As FunctionParameter = GetReturnParameter(edmFunction)
        Return If(returnParam Is Nothing, Nothing, _ef.GetElementType(returnParam.TypeUsage))
    End Function

    Public Function GenerateMergeOptionFunction(edmFunction As EdmFunction, includeMergeOption As Boolean) As Boolean
        Dim returnType As TypeUsage = GetReturnType(edmFunction)
        Return Not includeMergeOption AndAlso returnType IsNot Nothing AndAlso returnType.EdmType.BuiltInTypeKind = BuiltInTypeKind.EntityType
    End Function
End Class

Public Shared Sub ArgumentNotNull(Of T As Class)(arg As T, name As String)
    If arg Is Nothing Then
        Throw New ArgumentNullException(name)
    End If
End Sub

#>                                                                                                   