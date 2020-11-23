Imports System.ComponentModel
Imports System.IO
Imports BasicJson_1.Classes

Public Class Form1
    ''' <summary>
    ''' Storage container for ApplicationStorage data.
    ''' Using a BindingList and implementing INotifyPropertyChanged interface
    ''' permits real time updates to ListBox.
    ''' </summary>
    Private bindingList as new BindingList(Of ApplicationStorage)
    ''' <summary>
    ''' Load from file if exists
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If File.Exists(FileOperations.FileName) Then

            Try
                bindingList = New BindingList(Of ApplicationStorage)(FileOperations.Load())
            Catch ex As Exception
                MessageBox.Show($"Failed to load json{Environment.NewLine}{ex.Message}")
            End Try
        End If

        ListBox1.DataSource = bindingList

    End Sub

    ''' <summary>
    ''' Add new item if name is value and a valid decimal was entered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim value as Decimal = 0

        if Decimal.TryParse(ValueTextBox.Text, value) AndAlso Not string.IsNullOrWhiteSpace(NameTextBox.Text)
            bindingList.Add(new ApplicationStorage() With{.Name = NameTextBox.Text, .Value = value})
        End If

    End Sub
    ''' <summary>
    ''' Save items to json
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SaveAllButton_Click(sender As Object, e As EventArgs) Handles SaveAllButton.Click
        if bindingList.Count >0
            FileOperations.Save(bindingList.ToList())
        End If
    End Sub
    ''' <summary>
    ''' Get current item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentButtonButton_Click(sender As Object, e As EventArgs) Handles CurrentButton.Click
        if bindingList.Count >0
            if ListBox1.SelectedIndex > -1
                Dim currentItem = bindingList.Item(ListBox1.SelectedIndex)
                MessageBox.Show($"Name: {currentItem.Name} Value: {currentItem.Value}")
            End If
        End If

    End Sub
End Class
