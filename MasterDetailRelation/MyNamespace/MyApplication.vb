Namespace My
    Partial Friend Class MyApplication
        ''' <summary>
        ''' Determines if the a form is open
        ''' </summary>
        ''' <param name="sender">Name of form</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsFormOpen(ByVal sender As String) As Boolean
            Return ((From f In My.Application.OpenForms.Cast(Of Form)() _
                     Where f.Name.Equals(sender) Select f.Name).ToList.Count > 0)
        End Function
    End Class
End Namespace
