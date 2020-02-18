Imports System.ComponentModel.DataAnnotations

Namespace Validators
    Public Class EntityValidator(Of T As Class)
        Public Function Validate(entity As T) As EntityValidationResult
            Dim validationResults = New List(Of ValidationResult)()
            Dim vc = New ValidationContext(entity, Nothing, Nothing)
            Dim isValid = Validator.TryValidateObject(entity, vc, validationResults, True)

            Return New EntityValidationResult(validationResults)

        End Function
    End Class
End Namespace