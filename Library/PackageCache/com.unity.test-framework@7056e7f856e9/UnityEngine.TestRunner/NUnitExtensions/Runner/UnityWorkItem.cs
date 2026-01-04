dmType")

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
    End Func