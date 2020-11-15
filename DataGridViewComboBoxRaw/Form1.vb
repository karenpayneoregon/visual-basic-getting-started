Imports DataGridViewComboBoxRaw.Classes

Public Class Form1
    Private ReadOnly _countryComboBoxBindingSource As New BindingSource
    Private _customersBindingSource As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim countries = MockedCountries.Load().Take(20).ToList()

        _customersBindingSource.DataSource = New List(Of Customer)
        CustomersDataGridView.AutoGenerateColumns = False

        CountryColumn.DisplayMember = "CountryName"
        CountryColumn.ValueMember = "CountryIdentifier"
        CountryColumn.DataPropertyName = "CountryIdentifier"

        _countryComboBoxBindingSource.DataSource = countries

        CountryColumn.DataSource = _countryComboBoxBindingSource
        CountryColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

        CustomersDataGridView.DataSource = _customersBindingSource

        CountryComboBox.DataSource = countries

    End Sub
    Private Sub CustomersDataGridView_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) _
        Handles CustomersDataGridView.DefaultValuesNeeded

        With e.Row
            .Cells("CountryColumn").Value = 1
        End With

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If String.IsNullOrWhiteSpace(CompanyNameTextBox.Text) Then
            Exit Sub
        End If

        _customersBindingSource.Add(New Customer With {
                                       .CompanyName = CompanyNameTextBox.Text,
                                       .CountryIdentifier = CType(CountryComboBox.SelectedItem, Country).CountryIdentifier,
                                       .CountryName = CountryComboBox.Text})

        _customersBindingSource.MoveLast()

    End Sub
    ''' <summary>
    ''' Update Customer via SelectionChangeCommitted event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomersDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles CustomersDataGridView.EditingControlShowing

        If CustomersDataGridView.CurrentCell.IsComboBoxCell Then
            RemoveHandler CType(e.Control, ComboBox).SelectionChangeCommitted, AddressOf _CountrySelectionChangeCommittedColumn
            Dim currentComboBox = CType(e.Control, ComboBox)
            AddHandler currentComboBox.SelectionChangeCommitted, AddressOf _CountrySelectionChangeCommittedColumn
        End If

    End Sub
    ''' <summary>
    ''' Set country id and name on current customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _CountrySelectionChangeCommittedColumn(sender As Object, e As EventArgs)

        Dim selectedCountry = CType(CType(sender, DataGridViewComboBoxEditingControl).SelectedItem, Country)
        Dim selectedCustomer = CType(_customersBindingSource.Current, Customer)

        selectedCustomer.CountryIdentifier = selectedCountry.CountryIdentifier
        selectedCustomer.CountryName = selectedCountry.CountryName

    End Sub
    ''' <summary>
    ''' Get current customer properties
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentButton_Click(sender As Object, e As EventArgs) Handles CurrentButton.Click

        If _customersBindingSource.Current IsNot Nothing Then
            Dim current = CType(_customersBindingSource.Current, Customer)
            MessageBox.Show($"Customer: {current.CompanyName}, Country name: {current.CountryName}: {current.CountryIdentifier}")
        End If

    End Sub
End Class