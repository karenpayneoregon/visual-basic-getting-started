Public Class Customer
    Public Property CustomerIdentifier() As Integer
    Public Property CompanyName() As String
    Public Property ContactName() As String
    Public Property ContactId() As Integer?
    Public Property CountryIdentifier() As Integer?
    Public Property CountryName() As String
    Public Property ContactTypeIdentifier() As Integer?
    Public Overrides Function ToString() As String
        Return CompanyName
    End Function
End Class