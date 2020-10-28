<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list. 
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer 
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer 
    'It can be modified using the Windows Form Designer.   
    'Do not modify it using the code editor. 
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Data_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteCurrentRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsDataGridView = New System.Windows.Forms.DataGridView()
        Me.EventColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InformationColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Results_ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDeleted = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RowCountButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Data_ContextMenuStrip.SuspendLayout()
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Results_ContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 473)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(508, 66)
        Me.Panel1.TabIndex = 5
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.Location = New System.Drawing.Point(421, 20)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.Data_ContextMenuStrip
        Me.DataGridView1.Location = New System.Drawing.Point(0, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(508, 206)
        Me.DataGridView1.TabIndex = 2
        '
        'Data_ContextMenuStrip
        '
        Me.Data_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCurrentRowToolStripMenuItem})
        Me.Data_ContextMenuStrip.Name = "Data_ContextMenuStrip"
        Me.Data_ContextMenuStrip.Size = New System.Drawing.Size(172, 26)
        '
        'DeleteCurrentRowToolStripMenuItem
        '
        Me.DeleteCurrentRowToolStripMenuItem.Name = "DeleteCurrentRowToolStripMenuItem"
        Me.DeleteCurrentRowToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DeleteCurrentRowToolStripMenuItem.Text = "Delete current row"
        '
        'ResultsDataGridView
        '
        Me.ResultsDataGridView.AllowUserToAddRows = False
        Me.ResultsDataGridView.AllowUserToDeleteRows = False
        Me.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventColumn, Me.InformationColumn})
        Me.ResultsDataGridView.ContextMenuStrip = Me.Results_ContextMenuStrip
        Me.ResultsDataGridView.Location = New System.Drawing.Point(0, 278)
        Me.ResultsDataGridView.Name = "ResultsDataGridView"
        Me.ResultsDataGridView.ReadOnly = True
        Me.ResultsDataGridView.Size = New System.Drawing.Size(508, 192)
        Me.ResultsDataGridView.TabIndex = 4
        '
        'EventColumn
        '
        Me.EventColumn.HeaderText = "Event"
        Me.EventColumn.Name = "EventColumn"
        Me.EventColumn.ReadOnly = True
        Me.EventColumn.Width = 125
        '
        'InformationColumn
        '
        Me.InformationColumn.HeaderText = "Information"
        Me.InformationColumn.Name = "InformationColumn"
        Me.InformationColumn.ReadOnly = True
        Me.InformationColumn.Width = 310
        '
        'Results_ContextMenuStrip
        '
        Me.Results_ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearRowsToolStripMenuItem})
        Me.Results_ContextMenuStrip.Name = "Results_ContextMenuStrip"
        Me.Results_ContextMenuStrip.Size = New System.Drawing.Size(130, 26)
        '
        'ClearRowsToolStripMenuItem
        '
        Me.ClearRowsToolStripMenuItem.Name = "ClearRowsToolStripMenuItem"
        Me.ClearRowsToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ClearRowsToolStripMenuItem.Text = "Clear rows"
        '
        'cmdDeleted
        '
        Me.cmdDeleted.Location = New System.Drawing.Point(12, 12)
        Me.cmdDeleted.Name = "cmdDeleted"
        Me.cmdDeleted.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleted.TabIndex = 0
        Me.cmdDeleted.Text = "Deleted"
        Me.cmdDeleted.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(456, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Events"
        '
        'RowCountButton
        '
        Me.RowCountButton.Location = New System.Drawing.Point(93, 12)
        Me.RowCountButton.Name = "RowCountButton"
        Me.RowCountButton.Size = New System.Drawing.Size(75, 23)
        Me.RowCountButton.TabIndex = 6
        Me.RowCountButton.Text = "Row count"
        Me.RowCountButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 539)
        Me.Controls.Add(Me.RowCountButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdDeleted)
        Me.Controls.Add(Me.ResultsDataGridView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " DataTable Events demo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Data_ContextMenuStrip.ResumeLayout(False)
        CType(Me.ResultsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Results_ContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ResultsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EventColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InformationColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Results_ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ClearRowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDeleted As System.Windows.Forms.Button
    Friend WithEvents Data_ContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteCurrentRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RowCountButton As Button
End Class
