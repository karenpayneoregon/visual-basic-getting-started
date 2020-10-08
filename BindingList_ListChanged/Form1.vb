Imports System.ComponentModel
Imports BindingList_ListChanged_Lib

Public Class Form1
    WithEvents personBindList As RemoveAndBind(Of Person)
    WithEvents personBindingSource As New BindingSource
    WithEvents AddressBindingSource As New BindingSource

    Private ReadOnly operations As New Operations
    Private currentlyLoading As Boolean = True


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        PeopleDataGridView.AutoGenerateColumns = False

        '
        ' Populate a few people
        '
        Dim peopleList = New List(Of Person) From {
                New Person() With {.PersonId = 1, .FirstName = "Karen", .LastName = "Payne",
                .AddressList = New List(Of Address)() From {New Address() With {.PersonId = 1, .AddressId = 1, .Street = "ABC Street"}}},
                New Person() With {.PersonId = 2, .FirstName = "Bill", .LastName = "Smith",
                .AddressList = New List(Of Address)() From {New Address() With {.PersonId = 2, .AddressId = 1, .Street = "111 Street"},
                New Address() With {.PersonId = 2, .AddressId = 2, .Street = "222 Street"}}},
                New Person() With {.PersonId = 3, .FirstName = "Anne", .LastName = "Jones"}}



        personBindList = New RemoveAndBind(Of Person) '(peopleList)
        For Each person As Person In peopleList
            personBindList.Add(person)
        Next


        personBindingSource.DataSource = personBindList
        PeopleDataGridView.DataSource = personBindingSource
        PersonBindingNavigator.BindingSource = personBindingSource

        AddressBindingSource.DataSource = personBindingSource
        AddressBindingSource.DataMember = "AddressList"

        AddressDataGridView.DataSource = AddressBindingSource

    End Sub
    ''' <summary>
    ''' Here we look to see if a new person was added, if
    ''' so pass the person to Operations class via NewPersonAdded procedure
    ''' which could be a function if something needs to come back
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub personBindList_ListChanged(sender As Object, e As ListChangedEventArgs) Handles personBindList.ListChanged

        If Not currentlyLoading Then
            If e.ListChangedType = ListChangedType.ItemAdded Then

                Dim newPerson = personBindList.Item(e.NewIndex)
                operations.NewPersonAdded(newPerson)
            End If
        Else
            currentlyLoading = False
        End If

    End Sub

    Private Sub AddPersonButton_Click(sender As Object, e As EventArgs) Handles AddPersonButton.Click

        Dim LastPersonIdentifier = personBindList.Max(Function(person) person.PersonId)

        If LastPersonIdentifier = 0 Then
            LastPersonIdentifier = 1
        Else
            LastPersonIdentifier += 1
        End If

        personBindList.Add(New Person() With {.PersonId = LastPersonIdentifier, .FirstName = FirstNameTextBox.Text, .LastName = LastNameTextBox.Text})
        personBindingSource.MoveLast()

    End Sub

    Private Sub RemoveCurrentPersonButton_Click(sender As Object, e As EventArgs) Handles RemoveCurrentPersonButton.Click

        If personBindList.Count > 0 Then
            personBindList.Remove(personBindList.Item(PeopleDataGridView.CurrentCell.RowIndex))
        End If

    End Sub

    Private Sub personBindList_FireBeforeRemove(sender As Object, e As ListChangedEventArgs) Handles personBindList.FireBeforeRemove

        operations.RemovedPersonAdded(personBindList.Item(PeopleDataGridView.CurrentCell.RowIndex))

    End Sub

    Private addressesMocked As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String) From {{1, "First"}, {2, "Second"}, {3, "Third"}, {4, "Fourth"}}

    Private Sub CurrentButton_Click(sender As Object, e As EventArgs) Handles CurrentButton.Click

        Dim currentPerson = personBindList.Item(PeopleDataGridView.CurrentCell.RowIndex)
        Dim addressId = 1

        If currentPerson.AddressList.Count > 0 Then
            addressId = currentPerson.AddressList.Max(Function(item) item.AddressId) + 1
        End If

        Dim street = "New address"
        If addressesMocked.ContainsKey(addressId) Then
            street = addressesMocked.Item(addressId)
        End If

        Dim personAddress = New Address With {
                .PersonId = currentPerson.PersonId,
                .Street = street,
                .AddressId = addressId}

        personBindList.Item(PeopleDataGridView.CurrentCell.RowIndex).AddressList.Add(personAddress)
        personBindList.ResetItem(PeopleDataGridView.CurrentCell.RowIndex)

    End Sub


End Class