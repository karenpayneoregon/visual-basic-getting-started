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
        Me.GetStringButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GetBooleanButton = New System.Windows.Forms.Button()
        Me.GetTimeSpanButton = New System.Windows.Forms.Button()
        Me.GetDateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GetStringButton
        '
        Me.GetStringButton.Location = New System.Drawing.Point(12, 12)
        Me.GetStringButton.Name = "GetStringButton"
        Me.GetStringButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GetStringButton.Size = New System.Drawing.Size(95, 23)
        Me.GetStringButton.TabIndex = 0
        Me.GetStringButton.Text = "Get String"
        Me.GetStringButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetStringButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(113, 14)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(412, 283)
        Me.TextBox1.TabIndex = 4
        '
        'GetBooleanButton
        '
        Me.GetBooleanButton.Location = New System.Drawing.Point(12, 59)
        Me.GetBooleanButton.Name = "GetBooleanButton"
        Me.GetBooleanButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GetBooleanButton.Size = New System.Drawing.Size(95, 23)
        Me.GetBooleanButton.TabIndex = 1
        Me.GetBooleanButton.Text = "Get Boolean"
        Me.GetBooleanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetBooleanButton.UseVisualStyleBackColor = True
        '
        'GetTimeSpanButton
        '
        Me.GetTimeSpanButton.Location = New System.Drawing.Point(12, 106)
        Me.GetTimeSpanButton.Name = "GetTimeSpanButton"
        Me.GetTimeSpanButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GetTimeSpanButton.Size = New System.Drawing.Size(95, 23)
        Me.GetTimeSpanButton.TabIndex = 2
        Me.GetTimeSpanButton.Text = "Get TimeSpan"
        Me.GetTimeSpanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetTimeSpanButton.UseVisualStyleBackColor = True
        '
        'GetDateButton
        '
        Me.GetDateButton.Location = New System.Drawing.Point(12, 153)
        Me.GetDateButton.Name = "GetDateButton"
        Me.GetDateButton.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.GetDateButton.Size = New System.Drawing.Size(95, 23)
        Me.GetDateButton.TabIndex = 3
        Me.GetDateButton.Text = "Get Date"
        Me.GetDateButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetDateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 309)
        Me.Controls.Add(Me.GetDateButton)
        Me.Controls.Add(Me.GetTimeSpanButton)
        Me.Controls.Add(Me.GetBooleanButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GetStringButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generic app settings demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetStringButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GetBooleanButton As Button
    Friend WithEvents GetTimeSpanButton As Button
    Friend WithEvents GetDateButton As Button
End Class
