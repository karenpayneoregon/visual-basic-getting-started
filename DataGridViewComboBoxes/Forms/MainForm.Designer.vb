<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InformationButton = New System.Windows.Forms.Button()
        Me.CurrentButton = New System.Windows.Forms.Button()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.CompanyNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactTitleColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PostalCodeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CustomersNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.InformationButton)
        Me.Panel1.Controls.Add(Me.CurrentButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 400)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 50)
        Me.Panel1.TabIndex = 0
        '
        'InformationButton
        '
        Me.InformationButton.Location = New System.Drawing.Point(144, 15)
        Me.InformationButton.Name = "InformationButton"
        Me.InformationButton.Size = New System.Drawing.Size(115, 23)
        Me.InformationButton.TabIndex = 1
        Me.InformationButton.Text = "Show child form"
        Me.InformationButton.UseVisualStyleBackColor = True
        '
        'CurrentButton
        '
        Me.CurrentButton.Location = New System.Drawing.Point(12, 15)
        Me.CurrentButton.Name = "CurrentButton"
        Me.CurrentButton.Size = New System.Drawing.Size(115, 23)
        Me.CurrentButton.TabIndex = 0
        Me.CurrentButton.Text = "Current"
        Me.CurrentButton.UseVisualStyleBackColor = True
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CompanyNameColumn, Me.ContactTitleColumn, Me.FirstNameColumn, Me.LastColumn, Me.StreetColumn, Me.CityColumn, Me.RegionColumn, Me.PostalCodeColumn, Me.CountryColumn})
        Me.CustomersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomersDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.Size = New System.Drawing.Size(991, 375)
        Me.CustomersDataGridView.TabIndex = 1
        '
        'CompanyNameColumn
        '
        Me.CompanyNameColumn.DataPropertyName = "CompanyName"
        Me.CompanyNameColumn.HeaderText = "Name"
        Me.CompanyNameColumn.Name = "CompanyNameColumn"
        '
        'ContactTitleColumn
        '
        Me.ContactTitleColumn.DataPropertyName = "ContactTitle"
        Me.ContactTitleColumn.HeaderText = "Title"
        Me.ContactTitleColumn.Name = "ContactTitleColumn"
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.DataPropertyName = "FirstName"
        Me.FirstNameColumn.HeaderText = "First"
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'LastColumn
        '
        Me.LastColumn.DataPropertyName = "LastName"
        Me.LastColumn.HeaderText = "Last"
        Me.LastColumn.Name = "LastColumn"
        '
        'StreetColumn
        '
        Me.StreetColumn.DataPropertyName = "Street"
        Me.StreetColumn.HeaderText = "Street"
        Me.StreetColumn.Name = "StreetColumn"
        '
        'CityColumn
        '
        Me.CityColumn.DataPropertyName = "City"
        Me.CityColumn.HeaderText = "City"
        Me.CityColumn.Name = "CityColumn"
        '
        'RegionColumn
        '
        Me.RegionColumn.DataPropertyName = "Region"
        Me.RegionColumn.HeaderText = "Region"
        Me.RegionColumn.Name = "RegionColumn"
        '
        'PostalCodeColumn
        '
        Me.PostalCodeColumn.DataPropertyName = "PostalCode"
        Me.PostalCodeColumn.HeaderText = "Zip"
        Me.PostalCodeColumn.Name = "PostalCodeColumn"
        '
        'CountryColumn
        '
        Me.CountryColumn.DataPropertyName = "CountryName"
        Me.CountryColumn.HeaderText = "Country"
        Me.CountryColumn.Name = "CountryColumn"
        Me.CountryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CountryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CustomersNavigator
        '
        Me.CustomersNavigator.AddNewItem = Nothing
        Me.CustomersNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersNavigator.DeleteItem = Nothing
        Me.CustomersNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.CustomersNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersNavigator.Name = "CustomersNavigator"
        Me.CustomersNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersNavigator.Size = New System.Drawing.Size(991, 25)
        Me.CustomersNavigator.TabIndex = 2
        Me.CustomersNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 450)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(Me.CustomersNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        Me.Panel1.ResumeLayout(False)
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersNavigator.ResumeLayout(False)
        Me.CustomersNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CustomersDataGridView As DataGridView
    Friend WithEvents CompanyNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactTitleColumn As DataGridViewComboBoxColumn
    Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegionColumn As DataGridViewTextBoxColumn
    Friend WithEvents PostalCodeColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryColumn As DataGridViewComboBoxColumn
    Friend WithEvents CurrentButton As Button
    Friend WithEvents CustomersNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents InformationButton As Button
End Class
