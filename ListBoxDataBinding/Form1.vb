Imports System.ComponentModel

Public Class Form1
    Private ReadOnly _customersBindingList As New BindingList(Of Customer)()

    Public Sub New()

        InitializeComponent()

        CustomerListBox.DataSource = _customersBindingList
        CustomerListBox.DisplayMember = "FullName"

        UpdateCurrentCustomerButton.Enabled = False

        EditFirstNameTextBox.DataBindings.Add("Text", _customersBindingList, "FirstName")
        EditLastNameTextBox.DataBindings.Add("Text", _customersBindingList, "LastName")

    End Sub
    Private Sub AddNewCustomerButton_Click(sender As Object, e As EventArgs) Handles AddNewCustomerButton.Click

        If String.IsNullOrWhiteSpace(AddFirstNameTextBox.Text) OrElse String.IsNullOrWhiteSpace(AddLastNameTextBox.Text) Then
            Return
        End If

        Dim customer = New Customer() With {.FirstName = AddFirstNameTextBox.Text, .LastName = AddLastNameTextBox.Text}

        _customersBindingList.Add(customer)

        CustomerListBox.SelectedIndex = _customersBindingList.Count - 1
        UpdateCurrentCustomerButton.Enabled = True

        ListCountLabel.Text = $"ListBox count: {CustomerListBox.Items.Count}  " & $"" & $"Customer List count: {_customersBindingList.Count}"

    End Sub

    Private Sub UpdateCurrentCustomerButton_Click(sender As Object, e As EventArgs) Handles UpdateCurrentCustomerButton.Click

        If String.IsNullOrWhiteSpace(EditFirstNameTextBox.Text) OrElse String.IsNullOrWhiteSpace(EditLastNameTextBox.Text) Then
            Return
        End If

        If CustomerListBox.SelectedIndex <= -1 Then
            Return
        End If

        _customersBindingList(CustomerListBox.SelectedIndex).FirstName = EditFirstNameTextBox.Text

        _customersBindingList(CustomerListBox.SelectedIndex).LastName = EditLastNameTextBox.Text

    End Sub

    Private Sub CustomerListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomerListBox.SelectedIndexChanged

    End Sub
End Class
