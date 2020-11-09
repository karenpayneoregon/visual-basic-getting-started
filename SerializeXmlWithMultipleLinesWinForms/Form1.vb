Imports System.ComponentModel
Imports System.IO
Imports System.Xml.Serialization
Imports SerializeXmlWithMultipleLinesWinForms.Classes

Public Class Form1
    Private _personBindingList As New BindingList(Of Person)
    Private _personBindingSource As New BindingSource

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _personBindingList = New BindingList(Of Person)(MockedData.People())

        _personBindingSource.DataSource = _personBindingList

        FirstNameTextBox.DataBindings.Add("Text", _personBindingSource, "FirstName")
        LastNameTextBox.DataBindings.Add("Text", _personBindingSource, "LastName")
        CommentsTextBox.DataBindings.Add("Text", _personBindingSource, "Comments")

        BindingNavigator1.BindingSource = _personBindingSource

    End Sub
    Private Sub SerializeCurrentPersonButton_Click(sender As Object, e As EventArgs) Handles SerializeCurrentPersonButton.Click
        SerializePerson(CType(_personBindingSource.Current, Person))
    End Sub
    Private Sub SerializeListButton_Click(sender As Object, e As EventArgs) Handles SerializeListButton.Click
        SerializeList(_personBindingList.ToList())
    End Sub
End Class