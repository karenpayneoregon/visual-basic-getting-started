Imports DataGridViewDataBindingToList.Classes
''' <summary>
''' Basic edit customer with no validating
''' </summary>
Public Class EditorForm
    Private currentCustomer As Customer
    Public ReadOnly Property Customer() As Customer
        Get
            Return currentCustomer
        End Get
    End Property
    ''' <summary>
    ''' Setup data binding to current customer in parent DataGridView
    ''' </summary>
    ''' <param name="customer"></param>
    ''' <param name="countryList"></param>
    Public Sub New(customer As Customer, countryList As List(Of Country))
        InitializeComponent()

        currentCustomer = customer

        CompanyNameTextBox.DataBindings.Add("Text", currentCustomer, "CompanyName")
        CityTextBox.DataBindings.Add("Text", currentCustomer, "City")

        CountryComboBox.DataSource = countryList
        CountryComboBox.SelectedIndex = CountryComboBox.FindString(currentCustomer.CountryName)

        TitleTextBox.DataBindings.Add("Text", currentCustomer, "ContactTitle")
        ContactNameTextBox.DataBindings.Add("Text", currentCustomer, "ContactName")

    End Sub

    Private Sub EditorForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        CompanyNameTextBox.SelectionLength = 0
    End Sub
    ''' <summary>
    ''' Update customer country information
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        currentCustomer.CountryIdentifier = CType(CountryComboBox.SelectedItem, Country).CountryIdentifier
        currentCustomer.CountryName = CType(CountryComboBox.SelectedItem, Country).Name
    End Sub
End Class