Imports System.ComponentModel
Imports System.IO
Imports ComponentLibrary
Imports ReadDelimitedFile1.Classes

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
        CustomersBindingSource.DataSource = New BindingList(Of Customer)(FileOperations.ConventionalRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWithPrimaryKey.csv")))
        'CustomersBindingSource.DataSource = New SortableBindingList(Of Customer)(FileOperations.ConventionalRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CustomersWithPrimaryKey.csv")))
        CustomersDataGridView.DataSource = CustomersBindingSource
    End Sub
    ''' <summary>
    ''' Customer implements INotifyPropertyChanged which allows edits without the need for
    ''' CustomersBindingSource.ResetCurrentItem()
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentCustomerButton_Click(sender As Object, e As EventArgs) Handles CurrentCustomerButton.Click

        If CustomersBindingSource.Current IsNot Nothing Then
            CType(CustomersBindingSource.Current, Customer).Country = "sss"
        End If

    End Sub
End Class
