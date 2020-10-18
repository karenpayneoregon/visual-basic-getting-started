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
        ''' <summary>
        ''' We need to be a bit yucky here for demonstrating the inability to properly add a new
        ''' customer record in the DataGridView as we have only first and last name of contacts. Now
        ''' this could be resolved by having yet another DataGridView ComboBox solely to select a contact
        ''' but then we have issues like wanting to add a brand new contact. So this is kind of wide
        ''' open to how each coder wants to deal with adding a new contact or selecting an existing contact.
        ''' </summary>
        ''' <param name="sender"></param>
        Public Sub New(sender As DataRow)

            CustomerIdentifier = sender.Field(Of Integer)("CustomerIdentifier")
            CompanyName = sender.Field(Of String)("CompanyName")

            ContactId = If(sender.Item("ContactId") Is DBNull.Value, -1, sender.Field(Of Integer)("ContactId"))
            Street = sender.Field(Of String)("Street")
            City = sender.Field(Of String)("City")
            Region = If(String.IsNullOrWhiteSpace(sender.Field(Of String)("Region")), "", sender.Field(Of String)("Region"))
            PostalCode = sender.Field(Of String)("PostalCode")
            CountryIdentifier = If(sender.Item("CountryIdentifier") Is DBNull.Value, -1, sender.Field(Of Integer)("CountryIdentifier"))
            Phone = sender.Field(Of String)("Phone")
            Fax = sender.Field(Of String)("Fax")
            ContactTypeIdentifier = If(sender.Item("ContactTypeIdentifier") Is DBNull.Value, -1, sender.Field(Of Integer)("ContactTypeIdentifier"))
            ModifiedDate = If(sender.Field(Of DateTime?)("ModifiedDate").HasValue, sender.Field(Of DateTime?)("ModifiedDate").Value, New DateTime())

        End Sub

        Public Overrides Function ToString() As String

            Return $"ID: {CustomerIdentifier}{Environment.NewLine}" &
                   $"Company: {CompanyName}" &
                   $"{Environment.NewLine}Contact Id: {ContactId}{Environment.NewLine}" &
                   $"Country id: {CountryIdentifier}" &
                   $"{Environment.NewLine}Street: {Street}{Environment.NewLine}" &
                   $"Contact type: {ContactTypeIdentifier}{Environment.NewLine}" &
                   $"Modified: {ModifiedDate}"

        End Function
    End Class
End Namespace