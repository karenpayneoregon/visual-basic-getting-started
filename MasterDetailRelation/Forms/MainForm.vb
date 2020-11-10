Imports MasterDetailRelation.Extensions
Imports MasterDetailsDataLibrary
Imports MasterDetailsDataLibrary.LanguageExtensions

Public Class frmMainForm
    WithEvents bsMaster As New BindingSource()
    WithEvents bsDetails As New BindingSource()

    Private mLeechChildForm As frmLeech
    Private mFirstTimeForLeechForm As Boolean = True

    Private Sub frmMainForm_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        If Not mFirstTimeForLeechForm Then
            mLeechChildForm.Location = New Point(Me.Left + Me.Width, Top)
        End If
    End Sub
    Private Sub frmMainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not mFirstTimeForLeechForm Then
            mLeechChildForm.Location = New Point(Me.Left + Me.Width, Top)
        End If
    End Sub

    Private Sub frmMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFromDatabase()
        cmdLeech.PerformClick()
        ShowDetailsForCurrentMaster()

        ' Just conserving on screen space :-)
        MasterGrid.Columns("PostalCode").Visible = False
        MasterGrid.Columns("Phone").Visible = False

    End Sub
    Public Sub LoadFromDatabase()

        Dim errorMessage As String = ""
        Dim dataAccess As New CustomerOrdersSetup

        If dataAccess.Load(errorMessage) Then
            bsMaster = dataAccess.MasterBindingSource
            bsDetails = dataAccess.DetailsBindingSource

            MasterGrid.DataSource = bsMaster
            ChildGrid.DataSource = bsDetails

            MasterGrid.Columns("Freight").DefaultCellStyle.Format = "C2"
            MasterGrid.Columns("Freight").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            MasterGrid.Columns("Freight").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            MasterGrid.Columns("Freight").DefaultCellStyle.NullValue = "0"
            MasterGrid.Columns("PostalCode").HeaderText = "Postal"

            BindingNavigator1.BindingSource = bsMaster

            MasterGrid.Columns.Item(CustomerIdentifier).Visible = False
            MasterGrid.Columns("CompanyName").HeaderText = "Company Name"

            ChildGrid.AutoGenerateColumns = False

            MasterGrid.AutoResizeColumns()

            Dim hideColumns() As String = {"Column1", "ShipName", "ShipRegion", "ShipPostalCode"}

            For Each col In hideColumns
                ChildGrid.Columns(col).Visible = False
            Next

            ChildGrid.AutoResizeColumns()

            AddHandler ChildGrid.CellFormatting, AddressOf ChildGridEvents.ChildGrid_CellFormatting
            AddHandler ChildGrid.CellEnter, AddressOf DGV_CellEnter
        Else
            MessageBox.Show(errorMessage)
        End If

        bsMaster.Filter = "City='London'"

    End Sub
    Private Sub bsMaster_PositionChanged(sender As Object, e As EventArgs) Handles bsMaster.PositionChanged
        If bsMaster.Current IsNot Nothing Then
            ShowDetailsForCurrentMaster()
        End If
    End Sub
    ''' <summary>
    ''' A slimmed down version taken from ToolStripButton1_Click below
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ShowDetailsForCurrentMaster()

        Dim view As DataTable = New DataView(
                   CType(bsMaster.DataSource, DataSet).Tables("Orders").Copy,
                   "Identifier = '" & bsMaster.CurrentCustomerIdentifier & "'",
                   "Identifier",
                   DataViewRowState.CurrentRows).ToTable


        Try
            mLeechChildForm.DataGridView1.DataSource = view
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Simple example of creating a DataView of Orders for the currently
    ''' selected customer and show in a child form for demoing.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) _
        Handles _
            ToolStripButton1.Click,
            cmdShowChildDetails.Click

        Dim custView As DataView = New DataView(DirectCast(bsMaster.DataSource, DataSet).Tables("Orders").Copy,
                                                <T>
                                                    <%= CustomerIdentifier() %> = 
                                                    '<%= bsMaster.CurrentCustomerIdentifier %>'
                                                </T>.Value,
                                                CustomerIdentifier,
                                                DataViewRowState.CurrentRows
        )

        Dim sb As New System.Text.StringBuilder

        sb.AppendLine(String.Format("Order count [{1}] for [{0}]", bsMaster.CurrentRow("CompanyName"), custView.Count))

        sb.AppendLine()
        sb.AppendLine(String.Format("Ship date                 Freight"))

        sb.AppendLine(String.Format("----------------------    -------"))

        For row As Integer = 0 To custView.Count - 1
            If IsDBNull(custView(row)("ShippedDate")) Then
                sb.AppendLine($"{"Not shipped",-25} [{custView(row)("Freight")}]")
            Else
                sb.AppendLine($"{custView(row)("ShippedDate"),-25} [{custView(row)("Freight") }]")
            End If
        Next

        Dim f As New frmShowDetails

        Try

            f.Text = String.Concat("Company: ", bsMaster.CurrentRow("CompanyName"))
            f.TextBox1.Text = sb.ToString
            f.ShowDialog()

        Finally
            f.Dispose()
        End Try

    End Sub
    Private Sub cmdShowDataGridViewColumns_Click(sender As Object, e As EventArgs) Handles cmdShowDataGridViewColumns.Click
        Dim f As New frmDisplayColumns(MasterGrid)
        Try
            f.ShowDialog()
        Finally
            f.Dispose()
        End Try
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Public Sub DGV_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
        If ChildGrid(e.ColumnIndex, e.RowIndex).EditType IsNot Nothing Then
            If ChildGrid.IsCalendarCell(e) Then
                SendKeys.Send("{F2}")
            End If
        End If
    End Sub
    Private Sub MasterGrid_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles MasterGrid.CellFormatting

        If MasterGrid.CurrentRow IsNot Nothing Then

            If MasterGrid.CurrentRow.IsNewRow Then
                Exit Sub
            End If

            If e.ColumnIndex = MasterGrid.Columns("Freight").Index Then
                If Not IsDBNull(e.Value) Then
                    If CDbl(e.Value) < 100.0 Then
                        e.CellStyle.ForeColor = Color.CadetBlue
                    End If
                Else
                    e.CellStyle.BackColor = Color.LightSteelBlue
                End If

            End If
        End If
    End Sub
    ''' <summary>
    ''' Demo showing how to gain access to child rows of the current parent customer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcess.Click

        Dim dataRows =
            (
                From T In DirectCast(bsMaster.DataSource, DataSet).Tables("Orders").AsEnumerable
                Where T.Field(Of Boolean)("Process") = True
            ).ToList

        If dataRows.Count > 0 Then
            My.Dialogs.InformationDialog("You marked " & dataRows.Count.ToString & " items")
        Else
            My.Dialogs.InformationDialog("Nothing marked to process.")
        End If

    End Sub
    ''' <summary>
    ''' Code used to display the Leech form. The leech form provides
    ''' access to underlying fields for development purposes, not for production.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdLeech_Click(sender As Object, e As EventArgs) Handles cmdLeech.Click

        If Not My.Application.IsFormOpen("ChildForm") Then
            mLeechChildForm = New frmLeech
            mLeechChildForm.Owner = Me
            mLeechChildForm.BindingNavigator1.BindingSource = bsMaster
            mLeechChildForm.Owner = Me
            mFirstTimeForLeechForm = True
        End If

        mLeechChildForm.Show()
        If mFirstTimeForLeechForm Then
            mLeechChildForm.Location = New Point(Me.Left + Me.Width, Top)
            mFirstTimeForLeechForm = False
        End If

    End Sub
    Private Sub cmdLocateEmployeeInDetails_Click(sender As Object, e As EventArgs) Handles cmdLocateEmployeeInDetails.Click

        If Not String.IsNullOrWhiteSpace(txtOrder.Text) Then
            If Integer.TryParse(txtOrder.Text, Nothing) Then
                Dim index As Integer = bsDetails.Find("OrderID", txtOrder.Text)
                If index <> -1 Then
                    bsDetails.Position = index
                Else
                    MessageBox.Show("Failed to locate employee")
                End If
            Else
                MessageBox.Show("Order number must be numeric.")
            End If
        Else
            MessageBox.Show("Please enter a Order number")
        End If
    End Sub

    Private Sub MasterGrid_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MasterGrid.CellMouseDoubleClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            '
            ' Create an instance of your order detail form
            ' then set the BindingSource for it's data to the
            ' DataGridView on the details form.
            '
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles getChildRows.Click
        Dim parentRow As DataRow = CType(bsMaster.Current, DataRowView).Row
        Dim childRows As DataRow() = parentRow.GetChildRows("CustomersOrders")

        For Each childRow As DataRow In childRows
            Console.WriteLine(String.Join(",", childRow.ItemArray))
        Next

        Console.WriteLine(bsDetails.ParentRow("CustomersOrders").Field(Of String)("CompanyName"))

        MessageBox.Show("See IDE Output window for results.")
    End Sub

    '28
    '510
End Class
