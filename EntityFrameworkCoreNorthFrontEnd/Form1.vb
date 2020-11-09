Imports EntityFrameworkCoreNorthFrontEnd.Classes
Imports EntityFrameworkCoreNorthWind.Models
Imports EntityFrameworkCoreNorthWind.Projections

Public Class Form1
    Private Async Sub ListCustomersButton_Click(sender As Object, e As EventArgs) Handles ListCustomersButton.Click

        Dim customers As List(Of Customers) = Await Operations.ReadCustomers()

        CustomersComboBox.DataSource = customers

    End Sub
    Private Async Sub SingleCustomerButton_Click(sender As Object, e As EventArgs) Handles SingleCustomerButton.Click

        Dim singleCustomer As Customers =
                Await Operations.ReadCustomer(4)

        ContactNameTextBox.Text = singleCustomer.Contact.FullName

    End Sub
    Private Async Sub ListCustomerItemsButton_Click(sender As Object, e As EventArgs) Handles ListCustomerItemsButton.Click

        Dim customerItem As List(Of CustomerItem) = Await Operations.ReadCustomersProjected()

        CustomerItemComboBox.DataSource = customerItem

    End Sub
    ''' <summary>
    ''' This allows switching to Visual Studio and viewing the output window
    ''' or to clear the output window
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        TopMost = True

    End Sub
End Class
