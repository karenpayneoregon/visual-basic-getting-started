<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderFormGrouped
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.OrderDataGridView = New WinFormHelpers.GroupByGrid()
        Me.CountryColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderDateColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CountryColumn, Me.EmployeeColumn, Me.OrderDateColumn})
        Me.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.Size = New System.Drawing.Size(353, 235)
        Me.OrderDataGridView.TabIndex = 0
        '
        'CountryColumn
        '
        Me.CountryColumn.DataPropertyName = "ShipCountry"
        Me.CountryColumn.HeaderText = "Country"
        Me.CountryColumn.Name = "CountryColumn"
        '
        'EmployeeColumn
        '
        Me.EmployeeColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeColumn.HeaderText = "Employee"
        Me.EmployeeColumn.Name = "EmployeeColumn"
        '
        'OrderDateColumn
        '
        Me.OrderDateColumn.DataPropertyName = "OrderDate"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.OrderDateColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.OrderDateColumn.HeaderText = "Ordered"
        Me.OrderDateColumn.Name = "OrderDateColumn"
        '
        'OrderFormGrouped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 235)
        Me.Controls.Add(Me.OrderDataGridView)
        Me.Name = "OrderFormGrouped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders Grouped"
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OrderDataGridView As WinFormHelpers.GroupByGrid
    Friend WithEvents CountryColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderDateColumn As DataGridViewTextBoxColumn
End Class
