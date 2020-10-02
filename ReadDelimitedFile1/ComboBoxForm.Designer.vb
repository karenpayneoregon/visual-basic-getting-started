<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboBoxForm
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
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.FindByCompanyNameButton = New System.Windows.Forms.Button()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.ChangeNameButton = New System.Windows.Forms.Button()
        Me.NewNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(38, 40)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(209, 21)
        Me.CustomerComboBox.TabIndex = 0
        '
        'FindByCompanyNameButton
        '
        Me.FindByCompanyNameButton.Location = New System.Drawing.Point(269, 41)
        Me.FindByCompanyNameButton.Name = "FindByCompanyNameButton"
        Me.FindByCompanyNameButton.Size = New System.Drawing.Size(102, 23)
        Me.FindByCompanyNameButton.TabIndex = 1
        Me.FindByCompanyNameButton.Text = "By Company name"
        Me.FindByCompanyNameButton.UseVisualStyleBackColor = True
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(383, 45)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.CompanyNameTextBox.TabIndex = 2
        Me.CompanyNameTextBox.Text = "Ciprobedgover Direct"
        '
        'ChangeNameButton
        '
        Me.ChangeNameButton.Location = New System.Drawing.Point(269, 81)
        Me.ChangeNameButton.Name = "ChangeNameButton"
        Me.ChangeNameButton.Size = New System.Drawing.Size(102, 23)
        Me.ChangeNameButton.TabIndex = 3
        Me.ChangeNameButton.Text = "Change name"
        Me.ChangeNameButton.UseVisualStyleBackColor = True
        '
        'NewNameTextBox
        '
        Me.NewNameTextBox.Location = New System.Drawing.Point(383, 81)
        Me.NewNameTextBox.Name = "NewNameTextBox"
        Me.NewNameTextBox.Size = New System.Drawing.Size(155, 20)
        Me.NewNameTextBox.TabIndex = 4
        Me.NewNameTextBox.Text = "Karen Inc"
        '
        'ComboBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 201)
        Me.Controls.Add(Me.NewNameTextBox)
        Me.Controls.Add(Me.ChangeNameButton)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Controls.Add(Me.FindByCompanyNameButton)
        Me.Controls.Add(Me.CustomerComboBox)
        Me.Name = "ComboBoxForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ComboBox Example"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents FindByCompanyNameButton As Button
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents ChangeNameButton As Button
    Friend WithEvents NewNameTextBox As TextBox
End Class
