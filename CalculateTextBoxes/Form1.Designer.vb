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
        Me.NumericTextbox1 = New CalculateTextBoxes.NumericTextBox()
        Me.NumericTextbox2 = New CalculateTextBoxes.NumericTextBox()
        Me.NumericTextbox3 = New CalculateTextBoxes.NumericTextBox()
        Me.NumericTextbox4 = New CalculateTextBoxes.NumericTextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NumericTextbox1
        '
        Me.NumericTextbox1.Location = New System.Drawing.Point(26, 23)
        Me.NumericTextbox1.Name = "NumericTextbox1"
        Me.NumericTextbox1.Size = New System.Drawing.Size(100, 20)
        Me.NumericTextbox1.TabIndex = 0
        '
        'NumericTextbox2
        '
        Me.NumericTextbox2.Location = New System.Drawing.Point(26, 54)
        Me.NumericTextbox2.Name = "NumericTextbox2"
        Me.NumericTextbox2.Size = New System.Drawing.Size(100, 20)
        Me.NumericTextbox2.TabIndex = 1
        '
        'NumericTextbox3
        '
        Me.NumericTextbox3.Location = New System.Drawing.Point(26, 88)
        Me.NumericTextbox3.Name = "NumericTextbox3"
        Me.NumericTextbox3.Size = New System.Drawing.Size(100, 20)
        Me.NumericTextbox3.TabIndex = 2
        '
        'NumericTextbox4
        '
        Me.NumericTextbox4.Location = New System.Drawing.Point(25, 122)
        Me.NumericTextbox4.Name = "NumericTextbox4"
        Me.NumericTextbox4.Size = New System.Drawing.Size(100, 20)
        Me.NumericTextbox4.TabIndex = 3
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(27, 159)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(39, 13)
        Me.TotalLabel.TabIndex = 4
        Me.TotalLabel.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 198)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.NumericTextbox4)
        Me.Controls.Add(Me.NumericTextbox3)
        Me.Controls.Add(Me.NumericTextbox2)
        Me.Controls.Add(Me.NumericTextbox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sum code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericTextbox1 As NumericTextBox
    Friend WithEvents NumericTextbox2 As NumericTextBox
    Friend WithEvents NumericTextbox3 As NumericTextBox
    Friend WithEvents NumericTextbox4 As NumericTextBox
    Friend WithEvents TotalLabel As Label
End Class
