Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Module DataGridViewExtensions
    <Extension()>
    Public Sub ExpandColumns(sender As DataGridView)
        For Each col As DataGridViewColumn In sender.Columns
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next
    End Sub
End Module
