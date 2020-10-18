Imports System.Data.SqlClient
Imports System.Xml
Imports DataGridViewComboBoxes.LanguageExtensions
Imports DataProviderCommandHelpers

Namespace Classes
    ''' <summary>
    ''' Responsible for all data operations in tangent with DataTable
    ''' events in DataTableEvents class
    ''' </summary>
    Public Class Operations
        Inherits BaseExceptionProperties

        Public Delegate Sub OnError(sender As Exception)
        ''' <summary>
        ''' Used for alerting the user interface there is a runtime exception
        ''' </summary>
        Public Shared Event OnErrorHandler As OnError

        Private Shared ConnectionString As String =
                           "Data Source=.\SQLEXPRESS;" &
                           "Initial Catalog=NorthWindAzureForInserts;" &
                           "Integrated Security=True"

        ''' <summary>
        ''' Read all customers
        ''' </summary>
        ''' <param name="setupEvents">True to subscribe to several DataTable events</param>
        ''' <returns>All Customers</returns>
        Public Shared Function Customers(Optional setupEvents As Boolean = False) As DataTable

            AddHandler DataTableEvents.CustomerDeletedHandler, AddressOf CustomerDeleted
            AddHandler DataTableEvents.CustomerUpdateHandler, AddressOf CustomerUpdated
            AddHandler DataTableEvents.CustomerNewRowHandler, AddressOf CustomerNew
            Dim customerDataTable As New DataTable

            Using connection As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(CustomersSelectStatement, connection)

                    connection.Open()

                    customerDataTable.Load(cmd.ExecuteReader())
                    customerDataTable.Columns("CustomerIdentifier").AutoIncrement = False
                    customerDataTable.Columns("CustomerIdentifier").ReadOnly = False
                End Using
            End Using

            '
            ' Here we have a class, DataTableEvents which handles data table events where
            ' normally a coder would place them in this class or the calling form, this
            ' is simply a form of separation of responsibility.
            '
            If setupEvents Then
                AddHandler customerDataTable.ColumnChanged, AddressOf DataTableEvents.ColumnChanged
                AddHandler customerDataTable.RowDeleted, AddressOf DataTableEvents.Deleted
                AddHandler customerDataTable.RowChanging, AddressOf DataTableEvents.RowChanging
                AddHandler customerDataTable.RowChanged, AddressOf DataTableEvents.RowChanged
            End If

            Return customerDataTable

        End Function
        ''' <summary>
        ''' Called from DataTableEvents.RowChanged
        ''' </summary>
        ''' <param name="sender"></param>
        Public Shared Sub CustomerNew(sender As DataRow)
            ' 
        End Sub
        ''' <summary>
        ''' TODO
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        Public Shared Function AddCustomerRow(sender As DataRow) As Integer
            Return 233
        End Function

        ''' <summary>
        ''' Update Customers table followed by updating contact table. If there
        ''' is a failure all updates are rolled back.
        ''' </summary>
        ''' <param name="sender">Current DataRow</param>
        Private Shared Sub CustomerUpdated(sender As DataRow)

            mHasException = False

            Using connection As New SqlConnection(ConnectionString)

                Dim transaction As SqlTransaction = Nothing

                Using cmd As New SqlCommand(UpdateCustomerRecordStatement(), connection)

                    cmd.Parameters.AddWithValue("@CompanyName", sender.Field(Of String)("CompanyName"))
                    cmd.Parameters.AddWithValue("@ContactId", sender.Field(Of Integer)("ContactId"))
                    cmd.Parameters.AddWithValue("@Address", sender.Field(Of String)("Street"))
                    cmd.Parameters.AddWithValue("@City", sender.Field(Of String)("City"))
                    cmd.Parameters.AddWithValue("@Region", If(String.IsNullOrWhiteSpace(sender.Field(Of String)("Region")), "", sender.Field(Of String)("Region")))
                    cmd.Parameters.AddWithValue("@PostalCode", sender.Field(Of String)("PostalCode"))
                    cmd.Parameters.AddWithValue("@Phone", sender.Field(Of String)("Phone"))
                    cmd.Parameters.AddWithValue("@CountryIdentifier", sender.Field(Of Integer)("CountryIdentifier"))
                    cmd.Parameters.AddWithValue("@Fax", sender.Field(Of String)("Fax"))
                    cmd.Parameters.AddWithValue("@ContactTypeIdentifier", sender.Field(Of Integer)("ContactTypeIdentifier"))
                    cmd.Parameters.AddWithValue("@CustomerIdentifier", sender.Field(Of Integer)("CustomerIdentifier"))

                    Try
                        connection.Open()

                        transaction = connection.BeginTransaction()
                        cmd.Transaction = transaction

                        '
                        ' Update Customer
                        '
                        cmd.ExecuteNonQuery()

                        cmd.Parameters.Clear()

                        cmd.CommandText = UpdateConact()

                        cmd.Parameters.AddWithValue("@FirstName", sender.Field(Of String)("FirstName"))
                        cmd.Parameters.AddWithValue("@LastName", sender.Field(Of String)("LastName"))
                        cmd.Parameters.AddWithValue("@ContactId", sender.Field(Of Integer)("ContactId"))

                        '
                        ' Update Contact for Customer
                        '
                        cmd.ExecuteNonQuery()

                        transaction.Commit()

                    Catch ex As Exception

                        transaction.Rollback()

                        mLastException = ex

                        RaiseEvent OnErrorHandler(ex)

                    End Try

                End Using
            End Using
        End Sub

        ''' <summary>
        ''' Handles deleting a customer called from an event in DataTableEvents event
        ''' CustomerDeletedHandler
        ''' </summary>
        ''' <param name="customerIdentifier">Existing customer identifier</param>
        Private Shared Sub CustomerDeleted(customerIdentifier As Integer)

            mHasException = False

            Using connection As New SqlConnection(ConnectionString)

                Using cmd As New SqlCommand("DELETE FROM dbo.Customers WHERE CustomerIdentifier = @Identifier;", connection)

                    cmd.Parameters.AddWithValue("@Identifier", customerIdentifier)

                    Try

                        connection.Open()

                        Dim affected = cmd.ExecuteNonQuery()

                        If affected = 0 Then
                            Throw New Exception("Customer does not exist anymore")
                        End If
                    Catch ex As Exception

                        mHasException = True
                        mLastException = ex

                        RaiseEvent OnErrorHandler(ex)
                    End Try

                End Using
            End Using
        End Sub
        Public Shared Function CountryDataTable() As DataTable
            Dim dt As New DataTable

            Using connection As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(CountrySelectStatement, connection)
                    connection.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            Return dt

        End Function
        Public Shared Function CountryNames() As List(Of String)
            Dim nameList As New List(Of String)

            Dim selectStatement = "SELECT Name FROM dbo.Countries;"

            Using connection As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(selectStatement, connection)
                    connection.Open()

                    Dim reader = cmd.ExecuteReader()
                    While reader.Read()
                        nameList.Add(reader.GetString(0))
                    End While
                End Using
            End Using

            Return nameList

        End Function
        Public Shared Function ContactTypeDataTable() As DataTable
            Dim dt As New DataTable

            Using connection As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(ContactTypeStatement, connection)
                    connection.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            Return dt

        End Function
        ''' <summary>
        ''' Iterate the DataTable and perform updates for
        ''' each DataRow
        ''' </summary>
        ''' <param name="updatesTable"></param>
        Public Shared Sub Update(updatesTable As DataTable)

            Dim test = updatesTable.AllChanges("CustomerIdentifier")

            Dim modified = updatesTable.GetChanges(DataRowState.Modified)
            If modified IsNot Nothing Then
                Console.WriteLine($"Rows modified {modified.Rows.Count}")
            End If
        End Sub
        Public Shared Function Countries() As List(Of CountryItem)
            Dim nameList As New List(Of CountryItem)

            Dim selectStatement = "SELECT CountryIdentifier,Name FROM dbo.Countries;"

            Using connection As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand(selectStatement, connection)

                    connection.Open()

                    Dim reader = cmd.ExecuteReader()

                    While reader.Read()
                        nameList.Add(New CountryItem() With {
                                        .ContactTypeIdentifier = reader.GetInt32(0),
                                        .ContactTitle = reader.GetString(1)
                                        })
                    End While
                End Using
            End Using

            Return nameList

        End Function

#Region "SQL Statements"
        Public Shared Function ContactTypeStatement() As String
            Return "SELECT ContactTypeIdentifier, ContactTitle FROM dbo.ContactType;"
        End Function
        Public Shared Function CountrySelectStatement() As String
            Return "SELECT CountryIdentifier, Name FROM dbo.Countries;"
        End Function
        Public Shared Function CustomersSelectStatement() As String
            Return <SQL>
SELECT Cust.CustomerIdentifier, 
       Cust.CompanyName, 
       Cust.ContactId, 
       CT.ContactTitle, 
       C.FirstName, 
       C.LastName, 
       Cust.Address as Street, 
       Cust.City, 
       Cust.Region, 
       Cust.PostalCode, 
       Countries.[Name] AS CountryName, 
       Cust.CountryIdentifier, 
       Cust.Phone, 
       Cust.Fax, 
       Cust.ContactTypeIdentifier, 
       Cust.ModifiedDate
FROM Customers AS Cust
     INNER JOIN Contacts AS C ON Cust.ContactId = C.ContactId
     INNER JOIN ContactType AS CT ON Cust.ContactTypeIdentifier = CT.ContactTypeIdentifier
     INNER JOIN Countries ON Cust.CountryIdentifier = Countries.CountryIdentifier;
               </SQL>.Value
        End Function
        Public Shared Function UpdateCustomerRecordStatement() As String
            Return <SQL>
                UPDATE dbo.Customers
                  SET 
                      CompanyName = @CompanyName, 
                      ContactId = @ContactId, 
                      [Address] = @Address, 
                      City = @City, 
                      Region = @Region, 
                      PostalCode = @PostalCode, 
                      CountryIdentifier = @CountryIdentifier, 
                      Phone = @Phone, 
                      Fax = @Fax, 
                      ContactTypeIdentifier = @ContactTypeIdentifier
                WHERE CustomerIdentifier = @CustomerIdentifier;
                   </SQL>.Value
        End Function
        Public Shared Function UpdateConact() As String
            Return <SQL>
                UPDATE dbo.Contacts
                  SET 
                      FirstName = @FirstName, 
                      LastName = @LastName
                WHERE ContactId = @ContactId;
                </SQL>.Value
        End Function
#End Region
    End Class

End Namespace