Imports System.ComponentModel
Imports System.IO
Imports BindingList_ListChanged_1

Public Class Form1
    Private personBindList As New BindingList(Of Person)
    WithEvents personBindingSource As New BindingSource

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PeopleDataGridView.AutoGenerateColumns = False

        Dim peopleList = DataOperations.LoadPeople()

        personBindList = New BindingList(Of Person)(peopleList)

        personBindingSource.DataSource = personBindList
        PeopleDataGridView.DataSource = personBindingSource

    End Sub

    Private Sub personBindingSource_DataSourceChanged(sender As Object, e As EventArgs) _
        Handles personBindingSource.DataSourceChanged

        For index As Integer = 0 To personBindList.Count - 1
            If personBindList(index).FirstName = "Karen" Then
                personBindList(index).FirstName = "Karen 1"
            End If
        Next
        AddHandler FileDirectoryOperations.OnErrorEvent, AddressOf OnCopyError
        FileDirectoryOperations.CopyFolder("C:\myData", "D:\Backup")
    End Sub

    Private Sub OnCopyError(exception As Exception)

    End Sub
End Class
