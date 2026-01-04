 Object) As String
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
            _errors.Add(New CompilerError(sourceFile, -1, -1, "6023", String.Format(CultureInfo.CurrentCulture, GetResourceString("Template_CaseInsensitiveTypeConflict"))))
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

    Public Function GetAllGlobalItems(itemCollection As IEnumerable(Of GlobalItem)) As IEnumerable(Of 