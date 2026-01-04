 LoadOptions.SetLineInfo)
        Return If(root.Elements().Where(Function(e) e.Name.LocalName = "Runtime").Elements().Where(Function(e) e.Name.LocalName = "ConceptualModels").Elements().Where(Function(e) e.Name.LocalName = "Schema").FirstOrDefault(), root)
    End Function

    Private Sub ProcessErrors(errors As IEnumerable(Of EdmSchemaError), sourceFilePath As String)
        For Each errorItem As EdmSchemaError In errors
            _errors.Add(New CompilerError(If(errorItem.SchemaLocation, sourceFilePath), errorItem.Line, errorItem.Column, errorItem.ErrorCode.ToString(CultureInfo.InvariantCulture), errorItem.Message) With { _
                .IsWarning = errorItem.Severity = EdmSchemaErrorSeverity.Warning _
            })
      