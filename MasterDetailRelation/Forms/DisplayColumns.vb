''' <summary>
''' Provides the capability to show/hide columns for a DataGridView
''' </summary>
Public Class frmDisplayColumns
    WithEvents _bsColumns As New BindingSource
    Private _dataTable As New DataTable
    Private _dataGridView As DataGridView

    ''' <summary>
    ''' Pass in the DataGridView to work on column visible property
    ''' </summary>
    ''' <param name="sender">DataGridView to allow changing visible property of each column</param>
    ''' <remarks></remarks>
    Public Sub New(ByRef sender As DataGridView)
        InitializeComponent()

        _dataGridView = sender

        _dataTable.Columns.AddRange(New DataColumn() _
            {
                New DataColumn("Action", GetType(System.Boolean)),
                New DataColumn("ColumnName", GetType(System.String))
            }
        )

    End Sub
    Private Sub DisplayColumns_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        For Each column As DataGridViewColumn In _dataGridView.Columns
            _dataTable.Rows.Add(New Object() {column.Visible, column.Name})
        Next

        _bsColumns.DataSource = _dataTable
        DataGridView1.DataSource = _bsColumns
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub
    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        ' Apply settings to the DataGridView 
        For Each row As DataRow In _dataTable.Rows
            _dataGridView.Columns(row(1).ToString).Visible = CBool(row(0))
        Next

        '---------------------------------------------------------------------------------------
        ' The remaining code is demoing how to save column visibility to a XML file then read it
        ' back for restoring which columns are visible. To implement this is your job in regards
        ' to restoring columns, not a difficult task.
        '---------------------------------------------------------------------------------------

        ' Prep for remembering column visibility to file
        '
        ' Prior to VS2015 using XML literals (as done in contents variable) was extremely simple
        ' but in VS2015 and higher effort is required to use XML literals as done here as the
        ' IDE changes broke how XML literals are created. Still by following this pattern as shown
        ' we can still write XML literals to create a dynamic XML structure coupled with
        ' embedded expressions.
        '
        Dim contents =
        <Columns>
            <%= From row In _dataTable.Rows.Cast(Of DataRow)() Select
                <Column>
                    <ColumnName><%= row.Item("ColumnName") %></ColumnName>
                    <Visible><%= row.Item("Action") %></Visible>
                </Column> %>
        </Columns>

        ' Write column information to file
        IO.File.WriteAllText("Columns.xml", contents.ToString)

        '
        ' DoEvents should generally be avoided, the author may have used DoEvents
        ' less than five time in 20 years.
        '
        Application.DoEvents()

        ' Get column information
        Dim document As New XDocument
        Dim columnsInfo =
        (
            From element In XDocument.Load("Columns.xml")...<Column>
            Select ColumnName = element.<ColumnName>.Value, Visible = Convert.ToBoolean(element.<Visible>.Value)
        ).ToList

        ' Show it
        For Each Column In columnsInfo
            If _dataGridView.Columns.Contains(Column.ColumnName) Then
                _dataGridView.Columns(Column.ColumnName).Visible = Column.Visible
            End If
        Next

    End Sub
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
End Class