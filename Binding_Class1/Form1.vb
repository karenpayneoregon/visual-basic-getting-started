Imports System.ComponentModel
Imports Binding_Class1.Classes

Public Class Form1
    Private _itemBindingList As New BindingList(Of Item)
    Private ReadOnly _itemBindingSource As New BindingSource
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        _itemBindingList = New BindingList(Of Item)(MockUpItems.ItemsList())
        _itemBindingSource.DataSource = _itemBindingList

        BindingNavigator1.BindingSource = _itemBindingSource

        Dim binding As Binding = New Binding("Text", _itemBindingSource, "Value1")
        AddHandler binding.Format, AddressOf FormatDouble
        Value1TextBox.DataBindings.Add(binding)

        binding = New Binding("Text", _itemBindingSource, "Value2")
        AddHandler binding.Format, AddressOf FormatDouble
        Value2TextBox.DataBindings.Add(binding)

    End Sub
    ''' <summary>
    ''' Format Doubles
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FormatDouble(sender As Object, e As ConvertEventArgs)

        If e.DesiredType IsNot GetType(String) Then
            Exit Sub
        End If

        e.Value = CType(e.Value, Double).ToString("N2")

    End Sub
End Class