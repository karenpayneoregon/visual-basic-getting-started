Imports System.ComponentModel
Imports BindingList_ListChanged_Lib

Public Class Form1
    WithEvents personBindList As RemoveAndBind(Of Person)
    Private operations As New Operations
    Private currentlyLoading As Boolean = True
    ''' <summary>
    ''' Focus on ListBox1 and BindingList personBindList.New List
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        '
        ' Add people to BindingList DataSource
        '

        personBindList = New RemoveAndBind(Of Person) '(peopleList)
        For Each person As Person In operations.MockedPeople()
            personBindList.Add(person)
        Next

        '
        ' Display people in ListBox
        '
        ListBox1.DataSource = personBindList

    End Sub
    ''' <summary>
    ''' Here we look to see if a new person was added, if
    ''' so pass the person to Operations class via NewPersonAdded procedure
    ''' which could be a function if something needs to come back
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub personBindList_ListChanged(sender As Object, e As ListChangedEventArgs) _
        Handles personBindList.ListChanged

        If Not currentlyLoading Then
            If e.ListChangedType = ListChangedType.ItemAdded Then
                Dim newPerson = personBindList.Item(e.NewIndex)

                operations.NewPersonAdded(newPerson)
            ElseIf e.ListChangedType = ListChangedType.ItemDeleted Then
                If personBindList.Count = 0 Then
                    RemoveCurrentPersonButton.Enabled = False
                End If
            End If
        Else
            currentlyLoading = False
        End If
    End Sub

    Private Sub AddPersonButton_Click(sender As Object, e As EventArgs) _
        Handles AddPersonButton.Click

        personBindList.Add(New Person() With {
                              .FirstName = FirstNameTextBox.Text,
                              .LastName = LastNameTextBox.Text})

        If RemoveCurrentPersonButton.Enabled = False Then
            RemoveCurrentPersonButton.Enabled = True
        End If

    End Sub

    Private Sub RemoveCurrentPersonButton_Click(sender As Object, e As EventArgs) _
        Handles RemoveCurrentPersonButton.Click

        If personBindList.Count > 0 Then
            If My.Dialogs.Question($"Remove {ListBox1.Text}") Then
                personBindList.Remove(personBindList.Item(ListBox1.SelectedIndex))
            End If
        End If

    End Sub

    Private Sub personBindList_FireBeforeRemove(sender As Object, e As ListChangedEventArgs) _
        Handles personBindList.FireBeforeRemove

        operations.RemovedPersonAdded(personBindList.Item(ListBox1.SelectedIndex))

    End Sub
End Class