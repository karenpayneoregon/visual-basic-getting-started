Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports CalculateTextBoxes.Classes

Public Class Form1
    Private BindingList As New BindingList(Of Item)

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        BindingList = New BindingList(Of Item) From {New Item() With
            {.Value1 = 0, .Value2 = 0, .Value3 = 0, .Value4 = 0}}

        For Each numericTextBox As NumericTextBox In NumericTextBoxList
            Dim index = Integer.Parse(Regex.Replace(numericTextBox.Name, "[^\d]", ""))
            numericTextBox.DataBindings.Add("Text", BindingList, $"Value{index}")
        Next

        TotalLabel.DataBindings.Add("Text", BindingList, "Total")
    End Sub
End Class