modelNamespace))
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

    Public Function EnumIsFlags(enumType As 