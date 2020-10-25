Imports CheckOneRow.Extensions

Public Class frmMainForm
    WithEvents bsRooms As New BindingSource
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.AutoGenerateColumns = False
        bsRooms.DataSource = GetMockedData()
        DataGridView1.DataSource = bsRooms

        AddHandler CType(bsRooms.DataSource, DataTable).ColumnChanged, AddressOf dt_ColumnChanged

    End Sub
    Private Function GetMockedData() As DataTable

        Dim dt As New DataTable()

        dt.Columns.Add("Identifier", GetType(Integer))
        dt.Columns.Add("Room", GetType(String))
        dt.Columns.Add("RoomType", GetType(String))
        dt.Columns.Add("Rate", GetType(Decimal))
        dt.Columns.Add("Available", GetType(Boolean))
        'dt.Columns.Add("Status", GetType(Boolean))

        dt.Rows.Add(10, "201A", "Suite", 98.99, False)
        dt.Rows.Add(20, "101A", "Suite", 120.99, False)
        dt.Rows.Add(30, "201B", "Suite", 99.99, False)

        dt.AcceptChanges()

        Return dt

    End Function
    Private Sub dt_ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)

        If e.Column.ColumnName = "Available" Then

            Dim CurrentRow As Integer = DataGridView1.CurrentCell.RowIndex
            Dim CurrentCol As Integer = DataGridView1.CurrentCell.ColumnIndex

            Dim Checker As Boolean = False

            If Boolean.TryParse(e.ProposedValue.ToString, Checker) Then

                If Checker Then

                    Dim id As String = bsRooms.CurrentRow("Identifier")
                    Dim dt As DataTable = CType(bsRooms.DataSource, DataTable)

                    For Each row As DataRow In dt.Rows

                        Dim thisId As String = row("Identifier").ToString

                        If Not row("Identifier").ToString = id Then
                            row.SetField("Available", False)
                        End If

                    Next

                    dt.AcceptChanges()

                End If

                bsRooms.ResetCurrentItem()

                DataGridView1.CurrentCell = DataGridView1(CurrentCol, CurrentRow)
            End If
        End If

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Console.WriteLine($"CellClick: {CType(DataGridView1.CurrentRow.Cells("AvailableColumn").Value, Boolean)}")
    End Sub
    Private Sub DataGridView1SelectAll_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
        If TypeOf DataGridView1.CurrentCell Is DataGridViewCheckBoxCell Then
            If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).Name = "AvailableColumn" Then
                DataGridView1.EndEdit()
                Dim checked As Boolean = CType(DataGridView1.CurrentCell.Value, Boolean)
                Console.WriteLine($"CurrentCellDirtyStateChanged: {checked}")
            End If
        End If
    End Sub
    ''' <summary>
    ''' Handle user pressing spacebar in CheckBox column
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGridView1_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyUp
        If e.KeyCode = Keys.Space Then

            If DataGridView1.Columns("AvailableColumn").Index = DataGridView1.CurrentCell.ColumnIndex Then
                Dim CurrentIdentifier As Int32 = CType(bsRooms.Current, DataRowView).Row.Field(Of Int32)("Identifier")
                Dim Checked As Boolean = Not CType(bsRooms.Current, DataRowView).Row.Field(Of Boolean)("Available")

                DataGridView1.CurrentRow.Cells("AvailableColumn").Value = Checked

                If Checked Then

                    Dim dt As DataTable = CType(bsRooms.DataSource, DataTable)
                    For Each row As DataRow In dt.Rows
                        If Not row.Field(Of Int32)("Identifier") = CurrentIdentifier Then
                            row.SetField(Of Boolean)("Available", False)
                            row.SetField(Of Boolean)("Status", False) ' Added
                        Else
                            row.SetField(Of Boolean)("Status", True) ' Added
                        End If
                    Next

                End If

                e.Handled = True

            End If
        End If
    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class