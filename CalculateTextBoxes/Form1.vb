Imports System.ComponentModel

Public Class Form1
    Private BindingList As New BindingList(Of Item)

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BindingList = New BindingList(Of Item) From {New Item() With
            {.Value1 = 0, .Value2 = 0, .Value3 = 0, .Value4 = 0}}

        NumericTextbox1.DataBindings.Add("Text", BindingList, "Value1")
        NumericTextbox2.DataBindings.Add("Text", BindingList, "Value2")
        NumericTextbox3.DataBindings.Add("Text", BindingList, "Value3")
        NumericTextbox4.DataBindings.Add("Text", BindingList, "Value4")
        NumericTextbox5.DataBindings.Add("Text", BindingList, "Total")
    End Sub
End Class