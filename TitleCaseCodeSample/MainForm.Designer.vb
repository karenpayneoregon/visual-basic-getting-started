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
        Me.UseTitleCaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.OverrideCasingCheckBox = New System.Windows.Forms.CheckBox()
        Me.NameTextBox2 = New TitleCaseCodeSample.Controls.NoBeepTitleCaseTextBox()
        Me.NameTextBox1 = New TitleCaseCodeSample.Controls.NoBeepTitleCaseTextBox()
        Me.SuspendLayout()
        '
        'UseTitleCaseCheckBox
        '
        Me.UseTitleCaseCheckBox.AutoSize = True
        Me.UseTitleCaseCheckBox.Location = New System.Drawing.Point(198, 15)
        Me.UseTitleCaseCheckBox.Name = "UseTitleCaseCheckBox"
        Me.UseTitleCaseCheckBox.Size = New System.Drawing.Size(90, 17)
        Me.UseTitleCaseCheckBox.TabIndex = 3
        Me.UseTitleCaseCheckBox.Text = "Use title case"
        Me.UseTitleCaseCheckBox.UseVisualStyleBackColor = True
        '
        'OverrideCasingCheckBox
        '
        Me.OverrideCasingCheckBox.AutoSize = True
        Me.OverrideCasingCheckBox.Location = New System.Drawing.Point(198, 38)
        Me.OverrideCasingCheckBox.Name = "OverrideCasingCheckBox"
        Me.OverrideCasingCheckBox.Size = New System.Drawing.Size(130, 17)
        Me.OverrideCasingCheckBox.TabIndex = 5
        Me.OverrideCasingCheckBox.Text = "Override upper casing"
        Me.OverrideCasingCheckBox.UseVisualStyleBackColor = True
        '
        'NameTextBox2
        '
        Me.NameTextBox2.Location = New System.Drawing.Point(33, 38)
        Me.NameTextBox2.Name = "NameTextBox2"
        Me.NameTextBox2.OverrideUpperCased = True
        Me.NameTextBox2.Size = New System.Drawing.Size(146, 20)
        Me.NameTextBox2.TabIndex = 4
        Me.NameTextBox2.Text = "KAREN P PAYNE"
        Me.NameTextBox2.ToTitleCase = True
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Location = New System.Drawing.Point(33, 12)
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.OverrideUpperCased = False
        Me.NameTextBox1.Size = New System.Drawing.Size(146, 20)
        Me.NameTextBox1.TabIndex = 2
        Me.NameTextBox1.Text = "karen p payne"
        Me.NameTextBox1.ToTitleCase = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 80)
        Me.Controls.Add(Me.OverrideCasingCheckBox)
        Me.Controls.Add(Me.NameTextBox2)
        Me.Controls.Add(Me.UseTitleCaseCheckBox)
        Me.Controls.Add(Me.NameTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "To title case code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox1 As Controls.NoBeepTitleCaseTextBox
    Friend WithEvents UseTitleCaseCheckBox As CheckBox
    Friend WithEvents NameTextBox2 As Controls.NoBeepTitleCaseTextBox
    Friend WithEvents OverrideCasingCheckBox As CheckBox
End Class
