Imports System.ComponentModel

Public Class Form2
    Private ReadOnly CustomersList As New List(Of Customer)

    Public Sub New()

        InitializeComponent()

        CustomerListBox.DataSource = CustomersList
        CustomerListBox.DisplayMember = "FullName"

        EditFirstNameTextBox.DataBindings.Add("Text", CustomersList, "FirstName")
        EditLastNameTextBox.DataBindings.Add("Text", CustomersList, "LastName")

    End Sub
    Private Sub AddNewCustomerButton_Click(sender As Object, e As EventArgs) Handles AddNewCustomerButton.Click

        If String.IsNullOrWhiteSpace(AddFirstNameTextBox.Text) OrElse String.IsNullOrWhiteSpace(AddLastNameTextBox.Text) Then
            Return
        End If

        Dim customer = New Customer() With {.FirstName = AddFirstNameTextBox.Text, .LastName = AddLastNameTextBox.Text}

        CustomersList.Add(customer)
    End Sub

    Private Sub UpdateCurrentCustomerButton_Click(sender As Object, e As EventArgs) Handles UpdateCurrentCustomerButton.Click

        If String.IsNullOrWhiteSpace(EditFirstNameTextBox.Text) OrElse String.IsNullOrWhiteSpace(EditLastNameTextBox.Text) Then
            Return
        End If

        If CustomerListBox.SelectedIndex <= -1 Then
            Return
        End If

        Console.WriteLine(CustomerListBox.SelectedIndex)
        CustomersList(CustomerListBox.SelectedIndex).FirstName = EditFirstNameTextBox.Text
        CustomersList(CustomerListBox.SelectedIndex).LastName = EditLastNameTextBox.Text

    End Sub
    Private Sub TransferButton_Click(sender As Object, e As EventArgs) Handles TransferButton.Click
        CustomerListBox1.DataSource = Nothing
        CustomerListBox1.DataSource = New List(Of Customer)(CustomersList)
        'Dim cloned = New List(Of Customer)(CustomersList)
    End Sub
End Class