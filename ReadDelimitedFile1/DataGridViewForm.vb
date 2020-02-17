Imports System.ComponentModel
Imports System.IO
Imports ComponentLibrary
Imports ReadDelimitedFile1.Classes
Imports WinFormExtensions

Public Class DataGridViewForm
    Private CustomersBindingSource As New BindingSource
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

        'CustomersBindingSource.DataSource = New BindingList(Of Customer)(FileOperations.ReadAllLinesWithFileReadLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWithPrimaryKey.csv")))
        'CustomersBindingSource.DataSource = New SortableBindingList(Of Customer)(FileOperations.ReadAllLinesWithFileStream(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWithPrimaryKey.csv")))

        Dim results As (List As List(Of Customer), Exception As Exception) =
                FileOperations.ReadAllLinesWithFileReadLines(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWithPrimaryKey.csv"))

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

            'CType(CustomersBindingSource.Current, Customer).Country = ""

            MessageBox.Show(CType(CustomersBindingSource.Current, Customer).Information)
        End If

    End Sub
End Class
