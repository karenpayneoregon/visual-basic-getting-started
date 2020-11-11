Imports System.Windows.Forms

Public Class GroupByGrid
    Inherits DataGridView

    Protected Overrides Sub OnCellFormatting(ByVal args As DataGridViewCellFormattingEventArgs)
        MyBase.OnCellFormatting(args)

        ' First row always displays
        If args.RowIndex = 0 Then
            Return
        End If

        If IsRepeatedCellValue(args.RowIndex, args.ColumnIndex) Then
            args.Value = String.Empty
            args.FormattingApplied = True
        End If
    End Sub
    Private Function IsRepeatedCellValue(rowIndex As Integer, colIndex As Integer) As Boolean
        Dim currCell As DataGridViewCell = Rows(rowIndex).Cells(colIndex)
        Dim prevCell As DataGridViewCell = Rows(rowIndex - 1).Cells(colIndex)

        If (currCell.Value Is prevCell.Value) OrElse (currCell.Value IsNot Nothing AndAlso prevCell.Value IsNot Nothing AndAlso currCell.Value.ToString() = prevCell.Value.ToString()) Then
            Return True
        Else
            Return False
        End If

    End Function
    Protected Overrides Sub OnCellPainting(args As DataGridViewCellPaintingEventArgs)

        MyBase.OnCellPainting(args)

        args.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None

        ' Ignore column and row headers and first row
        If args.RowIndex < 1 OrElse args.ColumnIndex < 0 Then
            Return
        End If

        If IsRepeatedCellValue(args.RowIndex, args.ColumnIndex) Then
            args.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        Else
            args.AdvancedBorderStyle.Top = AdvancedCellBorderStyle.Top
        End If

    End Sub
End Class