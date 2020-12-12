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
        Me.NumericTextbox1 = New WinFormControls.NumericTextbox()
        Me.NumericTextbox2 = New WinFormControls.NumericTextbox()
        Me.NumericTextbox3 = New WinFormControls.NumericTextbox()
        Me.NumericTextbox4 = New WinFormControls.NumericTextbox()
        Me.NumericTextbox5 = New WinFormControls.NumericTextbox()
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
        'NumericTextbox5
        '
        Me.NumericTextbox5.Location = New System.Drawing.Point(24, 157)
        Me.NumericTextbox5.Name = "NumericTextbox5"
        Me.NumericTextbox5.Size = New System.Drawing.Size(100, 20)
        Me.NumericTextbox5.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 198)
        Me.Controls.Add(Me.NumericTextbox5)
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

    Friend WithEvents NumericTextbox1 As WinFormControls.NumericTextbox
    Friend WithEvents NumericTextbox2 As WinFormControls.NumericTextbox
    Friend WithEvents NumericTextbox3 As WinFormControls.NumericTextbox
    Friend WithEvents NumericTextbox4 As WinFormControls.NumericTextbox
    Friend WithEvents NumericTextbox5 As WinFormControls.NumericTextbox
End Class
