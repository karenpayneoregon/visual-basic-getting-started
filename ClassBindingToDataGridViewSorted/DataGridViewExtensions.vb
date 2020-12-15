Imports System.IO
Public Module DataGridViewExtensions
    <Runtime.CompilerServices.Extension>
    Public Sub ExportRows(sender As DataGridView, pFileName As String, Optional defaultNullValue As String = "(empty)")
        File.WriteAllLines(pFileName, (sender.Rows.Cast(Of DataGridViewRow)().
                              Where(Function(row) Not row.IsNewRow).Select(Function(row) New With {
                                                                              Key row,
                                                                              Key .rowItem = String.Join(",", Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell)().ToArray(),
                                                                                                                               Function(c) (If(c.Value Is Nothing, defaultNullValue, c.Value.ToString()))))
                                                                              }).Select(Function(row) row.rowItem)))
    End Sub
End Module