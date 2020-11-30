Imports System.ComponentModel

Public Class Form1
    Private _peopleBindingSource As New BindingSource()
    Private _peopleBindingList As BindingList(Of Person)
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim people = New List(Of Person) From {
                New Person() With {
                    .FirstName = "Karen",
                    .LastName = "Payne",
                    .Sex = "F"
                },
                New Person() With {
                    .FirstName = "Bill",
                    .LastName = "Smith",
                    .Sex = "M"
                },
                New Person() With {
                    .FirstName = "Mary",
                    .LastName = "Jones",
                    .Sex = "F"
                },
                New Person() With {
                    .FirstName = "Kim",
                    .LastName = "Adams",
                    .Sex = "F"
                }
        }

        _peopleBindingList = New BindingList(Of Person)(people)
        _peopleBindingSource.DataSource = _peopleBindingList

        FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "FirstName")
        LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, "LastName")

        Dim maleBinding = New Binding("Checked", _peopleBindingSource, "Sex")
        AddHandler maleBinding.Format, AddressOf MaleBinding_Format
        AddHandler maleBinding.Parse, AddressOf MaleBinding_Parse

        AddHandler maleRadioButton.CheckedChanged, AddressOf Male_CheckedChanged
        maleRadioButton.DataBindings.Add(maleBinding)

        PeopleNavigator.BindingSource = _peopleBindingSource

    End Sub
    Private Sub Male_CheckedChanged(sender As Object, args As EventArgs)
        femaleRadioButton.Checked = Not maleRadioButton.Checked
    End Sub

    Private Sub MaleBinding_Parse(sender As Object, args As ConvertEventArgs)
        args.Value = If(DirectCast(args.Value, Boolean), "M", "F")
    End Sub

    Private Sub MaleBinding_Format(sender As Object, args As ConvertEventArgs)
        args.Value = (DirectCast(args.Value, String)) = "M"
    End Sub
    ''' <summary>
    ''' Validation that we have the right sex/gender
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentButton_Click(sender As Object, e As EventArgs) Handles CurrentButton.Click
        If _peopleBindingSource.Current IsNot Nothing Then
            Dim person = _peopleBindingList.Item(_peopleBindingSource.Position)
            MessageBox.Show($"{person.FirstName}, {person.LastName} is a {person.Sex}")
        End If
    End Sub
End Class