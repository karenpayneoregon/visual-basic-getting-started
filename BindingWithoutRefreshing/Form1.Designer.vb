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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LanguageColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddNewSettingButton = New System.Windows.Forms.Button()
        Me.ChangeLanguageButton = New System.Windows.Forms.Button()
        Me.LanguagesComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LanguageColumn})
        Me.DataGridView2.Location = New System.Drawing.Point(25, 20)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(223, 177)
        Me.DataGridView2.TabIndex = 0
        '
        'LanguageColumn
        '
        Me.LanguageColumn.DataPropertyName = "Language"
        Me.LanguageColumn.HeaderText = "Language"
        Me.LanguageColumn.Name = "LanguageColumn"
        '
        'AddNewSettingButton
        '
        Me.AddNewSettingButton.Location = New System.Drawing.Point(25, 251)
        Me.AddNewSettingButton.Name = "AddNewSettingButton"
        Me.AddNewSettingButton.Size = New System.Drawing.Size(106, 23)
        Me.AddNewSettingButton.TabIndex = 1
        Me.AddNewSettingButton.Text = "Add new Setting"
        Me.AddNewSettingButton.UseVisualStyleBackColor = True
        '
        'ChangeLanguageButton
        '
        Me.ChangeLanguageButton.Location = New System.Drawing.Point(142, 251)
        Me.ChangeLanguageButton.Name = "ChangeLanguageButton"
        Me.ChangeLanguageButton.Size = New System.Drawing.Size(106, 23)
        Me.ChangeLanguageButton.TabIndex = 2
        Me.ChangeLanguageButton.Text = "Change language"
        Me.ChangeLanguageButton.UseVisualStyleBackColor = True
        '
        'LanguagesComboBox
        '
        Me.LanguagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LanguagesComboBox.FormattingEnabled = True
        Me.LanguagesComboBox.Location = New System.Drawing.Point(25, 213)
        Me.LanguagesComboBox.Name = "LanguagesComboBox"
        Me.LanguagesComboBox.Size = New System.Drawing.Size(223, 21)
        Me.LanguagesComboBox.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 283)
        Me.Controls.Add(Me.LanguagesComboBox)
        Me.Controls.Add(Me.ChangeLanguageButton)
        Me.Controls.Add(Me.AddNewSettingButton)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents AddNewSettingButton As Button
    Friend WithEvents ChangeLanguageButton As Button
    Friend WithEvents LanguageColumn As DataGridViewTextBoxColumn
    Friend WithEvents LanguagesComboBox As ComboBox
End Class
