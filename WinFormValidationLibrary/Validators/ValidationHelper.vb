Namespace Validators
    Public Class ValidationHelper
        ''' <summary>
        ''' Validate entity against validation rules
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="entity"></param>
        ''' <returns></returns>
        Public Shared Function ValidateEntity(Of T As Class)(entity As T) As EntityValidationResult
            Return (New EntityValidator(Of T)()).Validate(entity)
        End Function
    End Class
End Namespace