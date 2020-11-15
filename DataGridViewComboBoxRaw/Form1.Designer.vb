<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.CurrentButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AllowUserToAddRows = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameColumn, Me.CountryColumn})
        Me.CustomersDataGridView.Location = New System.Drawing.Point(14, 15)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.Size = New System.Drawing.Size(471, 175)
        Me.CustomersDataGridView.TabIndex = 0
        '
        'NameColumn
        '
        Me.NameColumn.DataPropertyName = "CompanyName"
        Me.NameColumn.HeaderText = "Company"
        Me.NameColumn.Name = "NameColumn"
        '
        'CountryColumn
        '
        Me.CountryColumn.DataPropertyName = "CountryName"
        Me.CountryColumn.HeaderText = "Country"
        Me.CountryColumn.Name = "CountryColumn"
        Me.CountryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CountryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(14, 222)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CompanyNameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Company name"
        '
        'CountryComboBox
        '
        Me.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Location = New System.Drawing.Point(193, 221)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(170, 21)
        Me.CountryComboBox.TabIndex = 3
        '
        'CurrentButton
        '
        Me.CurrentButton.Image = Global.DataGridViewComboBoxRaw.My.Resources.Resources.User_16x
        Me.CurrentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CurrentButton.Location = New System.Drawing.Point(382, 249)
        Me.CurrentButton.Name = "CurrentButton"
        Me.CurrentButton.Size = New System.Drawing.Size(89, 23)
        Me.CurrentButton.TabIndex = 5
        Me.CurrentButton.Text = "Current"
        Me.CurrentButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Image = Global.DataGridViewComboBoxRaw.My.Resources.Resources.Add_16x
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(382, 220)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(89, 23)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 293)
        Me.Controls.Add(Me.CurrentButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CountryComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomersDataGridView As DataGridView
    Friend WithEvents NameColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryColumn As DataGridViewComboBoxColumn
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CountryComboBox As ComboBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CurrentButton As Button
End Class
