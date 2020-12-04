Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = GetData()

        AddHandler dt.RowDeleted, AddressOf RowDeleted
        DataGridView1.DataSource = dt

    End Sub
    ''' <summary>
    ''' Reorder rows on deletion of a row
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RowDeleted(sender As Object, e As DataRowChangeEventArgs)

        Dim dt = CType(sender, DataTable)

        If dt.Rows.Count > 0 Then

            dt.Columns(0).ReadOnly = False

            For index As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(index).SetField(Of Integer)("Id", index + 1)
            Next

            dt.Columns(0).ReadOnly = True

        End If

    End Sub
End Class
''' <summary>
''' For mocking up data
''' </summary>
Public Module Mocked
    Public Function GetData() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn() With {.ColumnName = "Id", .DataType = GetType(Integer),
                          .AutoIncrement = True, .AutoIncrementSeed = 1})

        dt.Columns.Add(New DataColumn() With {.ColumnName = "Name", .DataType = GetType(String)})

        dt.Rows.Add(New Object() {Nothing, "Karen"})
        dt.Rows.Add(New Object() {Nothing, "Jim"})
        dt.Rows.Add(New Object() {Nothing, "Joe"})
        dt.Rows.Add(New Object() {Nothing, "Bob"})
        dt.Rows.Add(New Object() {Nothing, "Mary"})

        Return dt

    End Function
End Module