Imports System.ComponentModel
Imports MySettingsAlternate.Classes
Imports MySettingsAlternate.Modules

Public Class ProductsByCategoryForm
    Private ReadOnly productsBindingSource As New BindingSource

    Private Sub ProductsByCategoryForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataOperations.GetConnectionString()

        ProductsDataGridView.AutoGenerateColumns = False

    End Sub
    Private Async Sub ProductsByCategoryForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        CategoryComboBox.DataSource = DataOperations.GetCategories()

        AddHandler CategoryComboBox.SelectedIndexChanged, AddressOf CategoryComboBox_SelectedIndexChanged

        Dim lastCategoryIdentifier = ApplicationSettings.LastCategoryIdentifier()

        Await Task.Delay(100)

        ' -1 is the default, if -1 use the first category else change to the last category viewed
        If lastCategoryIdentifier > -1 Then
            Dim categoryToFind = CategoryComboBox.GetCurrentCategory(lastCategoryIdentifier)
            Dim index = CategoryComboBox.FindString(categoryToFind.CategoryName)
            CategoryComboBox.SelectedIndex = index

        Else
            CategoryComboBox.SelectedIndex = 0
            Await Populate()
        End If

        ProductsDataGridView.AllowUserToAddRows = False

    End Sub
    ''' <summary>
    ''' Each time the ComboBox selected index changes populate the DataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Await Populate()
    End Sub
    ''' <summary>
    ''' Populate DataGridView with selected category
    ''' </summary>
    ''' <returns></returns>
    Private Async Function Populate() As Task

        Dim currentCategoryIdentifier = CType(CategoryComboBox.SelectedItem, Category).CategoryID

        productsBindingSource.DataSource = Await DataOperations.ProductsByCategoryIdentifier(currentCategoryIdentifier)
        ProductsDataGridView.DataSource = productsBindingSource
        ProductsDataGridView.ExpandColumns()

        CategoryIdentifierLabel.Text = $"Category id: {currentCategoryIdentifier}"

    End Function

    ''' <summary>
    ''' Remember last category viewed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ProductsByCategoryForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ApplicationSettings.SetLastCategoryIdentifier(CType(CategoryComboBox.SelectedItem, Category).CategoryID)
    End Sub
End Class