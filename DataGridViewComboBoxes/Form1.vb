﻿Imports DataGridViewComboBoxes.Classes
Imports DataGridViewComboBoxes.LanguageExtensions

''' <summary>
''' Rough but functional code sample to work with DataGridViewComboBox columns
''' 
''' What is missing
''' * Assertions to ensure there is data loaded in various events
''' * Update, Add and methods to save to the database.
'''   A starter is done for the update process.
'''
''' Alternate is to use a DataAdapter to make saving changes easier but
''' if you want fully control the code here is a starter
''' </summary>
Public Class Form1
    ''' <summary>
    ''' For DataGridView DataSource
    ''' </summary>
    Private ReadOnly _customersBindingSource As New BindingSource
    ''' <summary>
    ''' For ContactType ComboBox in DataGridView
    ''' </summary>
    Private ReadOnly _titleComboBoxBindingSource As New BindingSource
    ''' <summary>
    ''' For Country ComboBox in DataGridView
    ''' </summary>
    Private ReadOnly _countryComboBoxBindingSource As New BindingSource

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        AddHandler Operations.OnErrorHandler, AddressOf WhenDataOperationError

        '
        ' Columns and their DataProperty has been set in the DataGridView designer
        '
        CustomersDataGridView.AutoGenerateColumns = False

        CountryColumn.DisplayMember = "Name"
        CountryColumn.ValueMember = "CountryIdentifier"
        CountryColumn.DataPropertyName = "CountryIdentifier"

        _countryComboBoxBindingSource.DataSource = Operations.CountryDataTable()

        CountryColumn.DataSource = _countryComboBoxBindingSource
        CountryColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

        ContactTitleColumn.DisplayMember = "ContactTitle"
        ContactTitleColumn.ValueMember = "ContactTypeIdentifier"
        ContactTitleColumn.DataPropertyName = "ContactTypeIdentifier"

        _titleComboBoxBindingSource.DataSource = Operations.ContactTypeDataTable()

        ContactTitleColumn.DataSource = _titleComboBoxBindingSource
        ContactTitleColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

        _customersBindingSource.DataSource = Operations.Customers(True)

        CustomersDataGridView.DataSource = _customersBindingSource

        CustomersNavigator.BindingSource = _customersBindingSource

    End Sub

    Private Sub WhenDataOperationError(sender As Exception)
        MessageBox.Show(sender.Message)
    End Sub

    ''' <summary>
    ''' 
    ''' Access to the current row data. Once having the variable Row you
    ''' can access columns e.g.
    '''
    ''' Row.Field(Of String)("CompanyName")
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentButton_Click(sender As Object, e As EventArgs) Handles CurrentButton.Click
        Dim customer As New Customers(_customersBindingSource.DataRow())
        MessageBox.Show(customer.ToString())
    End Sub
    ''' <summary>
    ''' Watch and react to changes for DataGridViewComboBox cell changes
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomersDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles CustomersDataGridView.EditingControlShowing

        '
        ' Using a language extension method assert the DataGridViewCell EditType is DataGridViewComboBoxEditingControl
        '
        If CustomersDataGridView.CurrentCell.IsComboBoxCell Then

            '
            ' As per the IsComboBoxCell check cast e.Control to a ComboBox
            '
            Dim currentComboBox = CType(e.Control, ComboBox)

            '
            ' Use column name to determine the procedure to use to set the primary key of the customer table current row
            '
            Dim columnName = CustomersDataGridView.Columns(CustomersDataGridView.CurrentCell.ColumnIndex).Name

            '
            ' Remove both event handlers as it's easier than keeping track of which of any have
            ' been subscribed too
            '
            RemoveHandler currentComboBox.SelectionChangeCommitted,
                AddressOf _ContactTypeSelectionChangeCommittedColumn

            RemoveHandler currentComboBox.SelectionChangeCommitted,
                AddressOf _CountrySelectionChangeCommittedColumn


            If columnName = "ContactTitleColumn" Then

                AddHandler currentComboBox.SelectionChangeCommitted,
                    AddressOf _ContactTypeSelectionChangeCommittedColumn

            End If

            If columnName = "CountryColumn" Then

                AddHandler currentComboBox.SelectionChangeCommitted,
                    AddressOf _CountrySelectionChangeCommittedColumn

            End If

        End If
    End Sub
    ''' <summary>
    ''' Update customer DataTable, does not update the database table.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _ContactTypeSelectionChangeCommittedColumn(sender As Object, e As EventArgs)

        Dim identifier = CType(CType(sender, DataGridViewComboBoxEditingControl).SelectedItem, DataRowView).
                Row.Field(Of Integer)("ContactTypeIdentifier")

        Dim row = CType(_customersBindingSource.Current, DataRowView).Row
        row.SetField("ContactTypeIdentifier", identifier)

    End Sub
    ''' <summary>
    ''' Update customer DataTable, does not update the database table.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _CountrySelectionChangeCommittedColumn(sender As Object, e As EventArgs)

        Dim identifier As Integer = CType(CType(sender, DataGridViewComboBoxEditingControl).SelectedItem, DataRowView).
                Row.Field(Of Integer)("CountryIdentifier")

        Dim row = CType(_customersBindingSource.Current, DataRowView).Row
        row.SetField("CountryIdentifier", identifier)

    End Sub
    ''' <summary>
    ''' Starter for issues such as adding a new row without
    ''' a company name.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) _
        Handles CustomersDataGridView.DataError

        MessageBox.Show(e.Exception.Message)
        e.Cancel = True

    End Sub
    ''' <summary>
    ''' Remove current customer, there are two ways to handle this, shown below the
    ''' customer is removed assuming we can which is fine in most cases. The other way
    ''' is prior to executing _customersBindingSource.RemoveCurrent() check if the customer
    ''' actually exists in the table while this also is not foolproof as it's possible
    ''' for another user to remove the customer in a split second before this can delete
    ''' the customer. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) _
        Handles BindingNavigatorDeleteItem.Click

        Dim companyName As String = _customersBindingSource.DataRow().Field(Of String)("CompanyName")

        If My.Dialogs.Question($"Remove {companyName}") Then

            _customersBindingSource.RemoveCurrent()

            If Not Operations.IsSuccessFul Then
                MessageBox.Show($"Failed to remove customer{Environment.NewLine}{Operations.LastExceptionMessage}")
            End If

        End If
    End Sub
    ''' <summary>
    ''' Place holder for adding a new customer. Most developers tend to add directly in the DataGridView
    ''' while another way is to present a modal form to add the record which in many cases requires a decent
    ''' amount of code that the average coder does not care for so if inclined feel free to change this behavior
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        MessageBox.Show("Add new record not implemented")
    End Sub
End Class

