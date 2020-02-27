Imports System.IO
Imports ComponentLibrary
Imports DataGridViewDataBindingToList.Classes
Imports DataGridViewDataBindingToList.Extensions
Imports WinFormExtensions


Public Class DataGridViewForm
    Private ReadOnly CustomersBindingSource As New BindingSource
    Private ReadOnly CountryBindingSource As New BindingSource
    Private CountryList As List(Of Country)

    Public Sub New()
        InitializeComponent()

        CustomersDataGridView.AutoGenerateColumns = False

    End Sub
    ''' <summary>
    ''' * Using a standard BindingList there will be no sort capability
    ''' * Using SortableBindingList provides sorting
    ''' 
    ''' Which to pick can be determine by business rules.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridViewForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim countryFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Countries.csv")

        If File.Exists(countryFileName) Then

            CountryList = FileOperations.
                GetCountryList(Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "Countries.csv"))

            CountryBindingSource.DataSource = CountryList

            CountryColumn.DisplayMember = "Name"
            CountryColumn.ValueMember = "CountryIdentifier"
            CountryColumn.DataPropertyName = "CountryIdentifier"
            CountryColumn.DataSource = CountryBindingSource
            CountryColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing

        Else
            '
            ' Missing text file for country information
            '
            MessageBox.Show("Missing data file for countries")

            Exit Sub
        End If


        Dim customerFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                            "CustomersWithPrimaryAndCountryPrimaryKey.csv")

        Dim results As (List As List(Of Customer), Exception As Exception) =
                FileOperations.ReadAllLinesWithFileReadLines(customerFileName, CountryList)

        If results.Exception Is Nothing Then
            CustomersBindingSource.DataSource = New SortableBindingList(Of Customer)(results.List)
        Else
            MessageBox.Show($"Encounter errors reading customer data{Environment.NewLine}{results.Exception.Message}")
        End If

        CustomersBindingSource.Sort = "CompanyName"
        CustomersDataGridView.DataSource = CustomersBindingSource

        BindingNavigator1.BindingSource = CustomersBindingSource

        '
        ' Expand all columns to view all cell information
        ' May inflect performance for large set of data and 
        ' also if DataGridView events are not properly setup
        '
        CustomersDataGridView.ExpandColumns()


    End Sub
    ''' <summary>
    ''' Customer implements INotifyPropertyChanged which allows edits without the need for
    ''' CustomersBindingSource.ResetCurrentItem()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentCustomerButton_Click(sender As Object, e As EventArgs) Handles CurrentCustomerButton.Click
        ShowCurrentCustomer()
    End Sub

    Private Sub CurrentPersonToolStripButton_Click(sender As Object, e As EventArgs) Handles CurrentPersonToolStripButton.Click
        ShowCurrentCustomer()
    End Sub
    Private Sub ShowCurrentCustomer()

        If CustomersBindingSource.Current IsNot Nothing Then

            Dim customer = CType(CustomersBindingSource.Current, Customer)
            'customer.CountryName = CountryList.FirstOrDefault().Name
            'customer.CountryIdentifier = CountryList.FirstOrDefault().CountryIdentifier

            MessageBox.Show(CType(CustomersBindingSource.Current, Customer).Information)
        End If

    End Sub


    Private Sub CustomersDataGridView_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomersDataGridView.KeyDown
        Console.WriteLine(Now)
        If e.KeyData = Keys.Enter Then
            e.Handled = True
            MessageBox.Show("ss")
        End If
    End Sub
    ''' <summary>
    ''' Used to know when the Country DataGridViewComboBox is the current column,
    ''' subscribe to SelectionChangeCommitted of the cast ComboBox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomersDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles CustomersDataGridView.EditingControlShowing

        If CustomersDataGridView.CurrentCell.IsComboBoxCell Then
            If CustomersDataGridView.Columns(CustomersDataGridView.CurrentCell.ColumnIndex).Name = "CountryColumn" Then
                Dim currentCombobox = TryCast(e.Control, ComboBox)

                RemoveHandler currentCombobox.SelectionChangeCommitted,
                    AddressOf DataGridViewComboBoxSelectionChangeCommittedForColorColumn

                AddHandler currentCombobox.SelectionChangeCommitted,
                    AddressOf DataGridViewComboBoxSelectionChangeCommittedForColorColumn

            End If
        End If

    End Sub
    ''' <summary>
    ''' Since the DataGridView BindingSource knows nothing of the BindingSource for the
    ''' DataGridViewComboBox we retrieve the current country from the DataGridViewComboBox
    ''' and assign the value to the actual Customer.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridViewComboBoxSelectionChangeCommittedForColorColumn(sender As Object, e As EventArgs)
        Dim customerFromBindingSource = CType(CustomersBindingSource.Current, Customer)

        '
        ' Knowing the DataGridViewComboBox is set to a List of Country its safe to cast to a Country
        '
        Dim customerFromComboBox =
                CType(
                    CType(sender, DataGridViewComboBoxEditingControl).SelectedItem, Country)

        '
        ' Update current customer's country data which in turn fires off the proper change because
        ' of Customers uses INotifyPropertyChanged
        '
        customerFromBindingSource.CountryIdentifier = customerFromComboBox.CountryIdentifier
        customerFromBindingSource.CountryName = customerFromComboBox.Name

    End Sub
End Class
