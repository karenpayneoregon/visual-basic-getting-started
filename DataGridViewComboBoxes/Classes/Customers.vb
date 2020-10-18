Namespace Classes
    ''' <summary>
    ''' Used to show a DataRow easy to read e.g. when debugging code not
    ''' working correctly and some columns are hidden.
    ''' </summary>
    Public Class Customers
        Public Property CustomerIdentifier As Integer
        Public Property CompanyName As String
        Public Property ContactId As Integer?
        Public Property Street As String
        Public Property City As String
        Public Property Region As String
        Public Property PostalCode As String
        Public Property CountryIdentifier As Integer?
        Public Property Phone As String
        Public Property Fax As String
        Public Property ContactTypeIdentifier As Integer?
        Public Property ModifiedDate As DateTime?

        Public Sub New(sender As DataRow)

            CustomerIdentifier = sender.Field(Of Integer)("CustomerIdentifier")
            CompanyName = sender.Field(Of String)("CompanyName")
            ContactId = sender.Field(Of Integer)("ContactId")
            Street = sender.Field(Of String)("Street")
            City = sender.Field(Of String)("City")
            Region = If(String.IsNullOrWhiteSpace(sender.Field(Of String)("Region")), "", sender.Field(Of String)("Region"))
            PostalCode = sender.Field(Of String)("PostalCode")
            CountryIdentifier = sender.Field(Of Integer)("CountryIdentifier")
            Phone = sender.Field(Of String)("Phone")
            Fax = sender.Field(Of String)("Fax")
            ContactTypeIdentifier = sender.Field(Of Integer)("ContactTypeIdentifier")
            ModifiedDate = CType(sender.Field(Of DateTime)("ModifiedDate").ToShortDateString(), Date?)

        End Sub

        Public Overrides Function ToString() As String

            Return $"ID: {CustomerIdentifier}{Environment.NewLine}" &
                   $"Company: {CompanyName}" &
                   $"{Environment.NewLine}Contact Id: {ContactId}{Environment.NewLine}" &
                   $"Country id: {CountryIdentifier}" &
                   $"{Environment.NewLine}Street: {Street}{Environment.NewLine}" &
                   $"Contact type: {ContactTypeIdentifier}"

        End Function
    End Class
End Namespace