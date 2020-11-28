Imports System.ComponentModel
Imports BindingWithoutRefreshing.Classes

Public Class Form1

    Public SettingsBindingSource As New BindingSource
    Public SettingsBindingList As New BindingList(Of Setting)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView2.AutoGenerateColumns = False

        SettingsBindingList = New BindingList(Of Setting)(New List(Of Setting))
        SettingsBindingSource.DataSource = New BindingSource(SettingsBindingList, Nothing)

        DataGridView2.DataSource = SettingsBindingSource

        LanguagesComboBox.DataSource = New List(Of String) From {"English", "French", "Spanish"}

    End Sub

    Private Sub AddNewSettingButton_Click(sender As Object, e As EventArgs) _
        Handles AddNewSettingButton.Click

        SettingsBindingSource.Add(New Setting(LanguagesComboBox.Text))
        SettingsBindingSource.MoveLast()

    End Sub

    Private Sub ChangeLanguageButton_Click(sender As Object, e As EventArgs) _
        Handles ChangeLanguageButton.Click

        If SettingsBindingSource.Current IsNot Nothing Then
            CType(SettingsBindingSource.Current, Setting).Language = LanguagesComboBox.Text
        End If

    End Sub

    Private Sub DataGridView2_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) _
        Handles DataGridView2.DefaultValuesNeeded

        e.Row.Cells(0).Value = LanguagesComboBox.Text

    End Sub
End Class


