Imports System.IO
Imports ReadDelimitedFile1.Classes

Public Class ComboBoxForm
    Private CustomersBindingSource As New BindingSource
    Private Sub ComboBoxForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim results As (List As List(Of Customer), Exception As Exception) =
                FileOperations.ReadAllLinesWithFileReadLines(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWithPrimaryKey.csv"))

        If results.Exception Is Nothing Then
            CustomersBindingSource.DataSource = results.List.OrderBy(Function(c) c.CompanyName).ToList()
        Else
            MessageBox.Show($"Encounter errors reading customer data{Environment.NewLine}{results.Exception.Message}")
            Exit Sub
        End If

        CustomerComboBox.DataSource = CustomersBindingSource

    End Sub
    ''' <summary>
    ''' Find by company name, can be done also by other properties but
    ''' note that if there are more than one item that match only the
    ''' first will be used.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FindByCompanyNameButton_Click(sender As Object, e As EventArgs) Handles FindByCompanyNameButton.Click

        Dim customerItem = CustomersBindingSource.List.OfType(Of Customer).
                ToList().Find(Function(customer) customer.CompanyName = CompanyNameTextBox.Text)

        Dim pos = CustomersBindingSource.IndexOf(customerItem)

        If pos > -1 Then
            CustomersBindingSource.Position = pos
        Else
            MessageBox.Show($"Company '{CompanyNameTextBox.Text}' not found")

        End If

    End Sub
    ''' <summary>
    ''' Change current company name
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChangeNameButton_Click(sender As Object, e As EventArgs) Handles ChangeNameButton.Click
        If Not String.IsNullOrWhiteSpace(NewNameTextBox.Text) Then
            CType(CustomersBindingSource.Current, Customer).CompanyName = NewNameTextBox.Text
        End If
    End Sub
End Class