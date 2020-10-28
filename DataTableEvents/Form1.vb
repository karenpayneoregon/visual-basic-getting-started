Imports WindowsApp1.Classes
Imports WindowsApp1.LanguageExtensions

Public Class Form1
    Private bsData As New BindingSource

    Private Sub DataTable_RowChanged(sender As Object, e As DataRowChangeEventArgs)

        ResultsDataGridView.Rows.Add(New Object() {"Row Changed", e.Action})
        ResultsDataGridView.CurrentCell = ResultsDataGridView(0, ResultsDataGridView.Rows.Count - 1)

        If e.Row.RowState <> DataRowState.Detached Then
            Dim Cost As Double = 0
            If Not Double.TryParse(e.Row("Cost").ToString, Cost) Then
                e.Row.RejectChanges()
                Exit Sub
            End If
            If String.IsNullOrEmpty(e.Row("Service").ToString) AndAlso Cost > 0 Then
                e.Row.RejectChanges()
            End If
        End If
    End Sub
    Private Sub DataTable_RowDeleted(sender As Object, e As DataRowChangeEventArgs)
        ResultsDataGridView.Rows.Add(New Object() {"Row Deleted", $"ID:{e.Row("Identifier", DataRowVersion.Original)}"})
        ResultsDataGridView.CurrentCell = ResultsDataGridView(0, ResultsDataGridView.Rows.Count - 1)
        ' 
        ' Uncomment, delete a row, ask for delete count, it will be zero 
        ' 
        'e.Row.AcceptChanges() 
        ' 
        ' 
    End Sub
    Private Sub DataTable_RowDeleting(sender As Object, e As DataRowChangeEventArgs)
        ResultsDataGridView.Rows.Add(New Object() {"Row Deleting", $"ID:{e.Row("Identifier")}"})
        ResultsDataGridView.CurrentCell = ResultsDataGridView(0, ResultsDataGridView.Rows.Count - 1)
    End Sub
    Private Sub DataTable_TableNewRow(sender As Object, e As DataTableNewRowEventArgs)
        ResultsDataGridView.Rows.Add(New Object() {"Table NewRow", e.Row.RowState.ToString})
        ResultsDataGridView.CurrentCell = ResultsDataGridView(0, ResultsDataGridView.Rows.Count - 1)
    End Sub
    Private Sub DataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs)

        ResultsDataGridView.Rows.Add(New Object() {"Col Changed", "RowState:" & e.Row.RowState.ToString})
        ' 
        ' We step out of here if the row is deleted or detached (new row) since these rows do not have 
        ' original value 
        ' 
        If Not e.Row.RowState = DataRowState.Deleted AndAlso Not e.Row.RowState = DataRowState.Detached Then

            ResultsDataGridView.Rows.Add(New Object() {"Col Changed", $"Original value [{e.Row(e.Column.ColumnName, DataRowVersion.Original)}]"})
            ResultsDataGridView.Rows.Add(New Object() {"", $"Propose value [{e.ProposedValue}]"})

        End If

        ResultsDataGridView.CurrentCell = ResultsDataGridView(0, ResultsDataGridView.Rows.Count - 1)

    End Sub
    Private Sub DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs)
        ' 
        ' We step out of here if the row is deleted or detached (new row) since these rows do not have 
        ' original value 
        ' 
        If Not e.Row.RowState = DataRowState.Deleted AndAlso Not e.Row.RowState = DataRowState.Detached Then
            ResultsDataGridView.Rows.Add(New Object() {"Col Changing", $"Original value [{e.Row(e.Column.ColumnName, DataRowVersion.Original)}]"})
            ResultsDataGridView.Rows.Add(New Object() {"", $"Propose value [{e.ProposedValue}]"})
        Else
            ResultsDataGridView.Rows.Add(New Object() {"Col Changing", e.Row(e.Column.ColumnName)})
        End If

        ResultsDataGridView.CurrentCell = ResultsDataGridView(0, ResultsDataGridView.Rows.Count - 1)

    End Sub
    ''' <summary> 
    ''' Reports deleted rows since last AcceptChanges was called. 
    ''' </summary> 
    ''' <param name="sender"></param> 
    ''' <param name="e"></param> 
    ''' <remarks> 
    ''' If you delete one or more rows without accepting changes we get  
    ''' rows where the row state is delete, otherwise if accept changes 
    ''' was executed there will be no deleted rows. 
    ''' </remarks> 
    Private Sub cmdDeleted_Click(sender As Object, e As EventArgs) Handles cmdDeleted.Click
        Dim dt = bsData.DataTable

        Dim dv As New DataView(dt, "", "", DataViewRowState.Deleted)
        If dv.Count > 0 Then
            Dim sb As New Text.StringBuilder
            sb.AppendLine("Deleted rows")
            For Each drv As DataRowView In dv
                sb.AppendLine(String.Format("ID: " & drv.Item("Identifier").ToString & ", Service: " & drv.Item("Service").ToString))
            Next
            My.Dialogs.InformationDialog(sb.ToString)
            If My.Dialogs.Question("Accept changed?") Then
                dt.AcceptChanges()
            End If
        Else
            My.Dialogs.InformationDialog("No deleted rows at this time to report.")
        End If

    End Sub
    Private Sub RowCountButton_Click(sender As Object, e As EventArgs) _
        Handles RowCountButton.Click

        Dim dt = bsData.DataTable
        Dim dv As New DataView(dt, "", "", DataViewRowState.Deleted)

        If dv.Count > 0 Then
            MessageBox.Show($"Row count: {dt.Rows.Count} but with {dv.Count} deleted")
        Else
            MessageBox.Show($"Row count: {dt.Rows.Count}")
        End If
    End Sub
    Private Sub DeleteCurrentRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCurrentRowToolStripMenuItem.Click
        If bsData.Current IsNot Nothing Then
            If My.Dialogs.Question($"Remove '{bsData.CurrentRow.Item("Service").ToString}' ?") Then
                bsData.DataTable.Rows(bsData.Position).Delete()
            End If
        End If
    End Sub
    Private Sub ClearRowsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearRowsToolStripMenuItem.Click
        If My.Dialogs.Question("Clear results?") Then
            ResultsDataGridView.Rows.Clear()
        End If
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bsData.DataSource = DataOperations.LoadMockedServiceItems()
        DataGridView1.DataSource = bsData

        DataGridView1.Columns("Cost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridView1.Columns("Cost").DefaultCellStyle.Format = "C2"

        AddHandler bsData.DataTable.ColumnChanged, AddressOf DataTable_ColumnChanged
        AddHandler bsData.DataTable.ColumnChanging, AddressOf DataTable_ColumnChanging
        AddHandler bsData.DataTable.RowChanged, AddressOf DataTable_RowChanged
        AddHandler bsData.DataTable.RowDeleted, AddressOf DataTable_RowDeleted
        AddHandler bsData.DataTable.RowDeleting, AddressOf DataTable_RowDeleting
        AddHandler bsData.DataTable.TableNewRow, AddressOf DataTable_TableNewRow

        ActiveControl = DataGridView1

    End Sub
#Region " DataGridView Events "
    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Delete Then
            If bsData.Current IsNot Nothing Then
                If My.Dialogs.Question($"Remove '{bsData.CurrentRow.Item("Service").ToString}' ?") Then
                    bsData.DataTable.Rows(bsData.Position).Delete()
                End If
            End If
        End If
    End Sub
    ''' <summary> 
    ''' color fully selected rows to our specs 
    ''' </summary> 
    ''' <param name="sender"></param> 
    ''' <param name="e"></param> 
    ''' <remarks></remarks> 
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim dgv = CType(sender, DataGridView)
        If (dgv.DataSource IsNot Nothing AndAlso e.RowIndex >= 0 AndAlso e.RowIndex <> dgv.NewRowIndex) Then
            If dgv.Rows(e.RowIndex).Selected = True Then
                e.CellStyle.Font = New Font(e.CellStyle.Font.Name, 8, FontStyle.Bold)
                e.CellStyle.SelectionBackColor = Color.Black
                e.CellStyle.SelectionForeColor = Color.Cyan
            End If
        End If
    End Sub
    ''' <summary> 
    ''' Highlight rows signifying a delete row event 
    ''' </summary> 
    ''' <param name="sender"></param> 
    ''' <param name="e"></param> 
    ''' <remarks></remarks> 
    Private Sub ResultsDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResultsDataGridView.CellFormatting
        If e.ColumnIndex = ResultsDataGridView.Columns("EventColumn").Index Then
            If e.Value.ToString = "Row Deleted" OrElse e.Value.ToString = "Row Deleting" Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            End If
        ElseIf e.ColumnIndex = ResultsDataGridView.Columns("InformationColumn").Index Then
            If e.Value.ToString = "Detached" OrElse e.Value.ToString.StartsWith("ID") Then
                e.CellStyle.BackColor = Color.Red
                e.CellStyle.ForeColor = Color.White
            End If
        End If
    End Sub
    ''' <summary> 
    ''' Assume control of data errors instead of the default method. 
    ''' </summary> 
    ''' <param name="sender"></param> 
    ''' <param name="e"></param> 
    ''' <remarks></remarks> 
    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError

        If DataGridView1.Columns(e.ColumnIndex).Name = "Cost" Then
            MessageBox.Show("Cost must be numeric")
            e.Cancel = True
        End If

    End Sub
    Private Sub DataGridView1_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.DefaultValuesNeeded
        e.Row.Cells("Cost").Value = 0.0
    End Sub

#End Region
End Class