<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsByCategoryForm
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
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.ProductNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitsInStockColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryIdentifierLabel = New System.Windows.Forms.Label()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(18, 19)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(183, 21)
        Me.CategoryComboBox.TabIndex = 0
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameColumn, Me.UnitPriceColumn, Me.UnitsInStockColumn, Me.SupplierNameColumn})
        Me.ProductsDataGridView.Location = New System.Drawing.Point(18, 58)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(599, 150)
        Me.ProductsDataGridView.TabIndex = 1
        '
        'ProductNameColumn
        '
        Me.ProductNameColumn.DataPropertyName = "ProductName"
        Me.ProductNameColumn.HeaderText = "Name"
        Me.ProductNameColumn.Name = "ProductNameColumn"
        '
        'UnitPriceColumn
        '
        Me.UnitPriceColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceColumn.HeaderText = "Unit price"
        Me.UnitPriceColumn.Name = "UnitPriceColumn"
        '
        'UnitsInStockColumn
        '
        Me.UnitsInStockColumn.DataPropertyName = "UnitsInStock"
        Me.UnitsInStockColumn.HeaderText = "In stock"
        Me.UnitsInStockColumn.Name = "UnitsInStockColumn"
        '
        'SupplierNameColumn
        '
        Me.SupplierNameColumn.DataPropertyName = "SupplierName"
        Me.SupplierNameColumn.HeaderText = "Supplier"
        Me.SupplierNameColumn.Name = "SupplierNameColumn"
        '
        'CategoryIdentifierLabel
        '
        Me.CategoryIdentifierLabel.AutoSize = True
        Me.CategoryIdentifierLabel.Location = New System.Drawing.Point(219, 22)
        Me.CategoryIdentifierLabel.Name = "CategoryIdentifierLabel"
        Me.CategoryIdentifierLabel.Size = New System.Drawing.Size(60, 13)
        Me.CategoryIdentifierLabel.TabIndex = 2
        Me.CategoryIdentifierLabel.Text = "Category id"
        '
        'ProductsByCategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 229)
        Me.Controls.Add(Me.CategoryIdentifierLabel)
        Me.Controls.Add(Me.ProductsDataGridView)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Name = "ProductsByCategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products By Category - remember category"
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents ProductNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitsInStockColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryIdentifierLabel As Label
End Class
