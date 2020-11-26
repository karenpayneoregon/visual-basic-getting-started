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
        Me.FileDoesNotExistsButton = New System.Windows.Forms.Button()
        Me.WriteSomeTextAsInformationButton = New System.Windows.Forms.Button()
        Me.WriteSomeTextAsWarningButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FileDoesNotExistsButton
        '
        Me.FileDoesNotExistsButton.Location = New System.Drawing.Point(16, 19)
        Me.FileDoesNotExistsButton.Name = "FileDoesNotExistsButton"
        Me.FileDoesNotExistsButton.Size = New System.Drawing.Size(281, 23)
        Me.FileDoesNotExistsButton.TabIndex = 0
        Me.FileDoesNotExistsButton.Text = "File does not exists"
        Me.FileDoesNotExistsButton.UseVisualStyleBackColor = True
        '
        'WriteSomeTextAsInformationButton
        '
        Me.WriteSomeTextAsInformationButton.Location = New System.Drawing.Point(19, 61)
        Me.WriteSomeTextAsInformationButton.Name = "WriteSomeTextAsInformationButton"
        Me.WriteSomeTextAsInformationButton.Size = New System.Drawing.Size(281, 23)
        Me.WriteSomeTextAsInformationButton.TabIndex = 1
        Me.WriteSomeTextAsInformationButton.Text = "Write some text as Information"
        Me.WriteSomeTextAsInformationButton.UseVisualStyleBackColor = True
        '
        'WriteSomeTextAsWarningButton
        '
        Me.WriteSomeTextAsWarningButton.Location = New System.Drawing.Point(19, 99)
        Me.WriteSomeTextAsWarningButton.Name = "WriteSomeTextAsWarningButton"
        Me.WriteSomeTextAsWarningButton.Size = New System.Drawing.Size(281, 23)
        Me.WriteSomeTextAsWarningButton.TabIndex = 2
        Me.WriteSomeTextAsWarningButton.Text = "Write some text as Warning"
        Me.WriteSomeTextAsWarningButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 145)
        Me.Controls.Add(Me.WriteSomeTextAsWarningButton)
        Me.Controls.Add(Me.WriteSomeTextAsInformationButton)
        Me.Controls.Add(Me.FileDoesNotExistsButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trace Listener basic"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FileDoesNotExistsButton As Button
    Friend WithEvents WriteSomeTextAsInformationButton As Button
    Friend WithEvents WriteSomeTextAsWarningButton As Button
End Class
