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
        Me.FindMissingButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FindMissingButton
        '
        Me.FindMissingButton.Location = New System.Drawing.Point(28, 31)
        Me.FindMissingButton.Name = "FindMissingButton"
        Me.FindMissingButton.Size = New System.Drawing.Size(125, 23)
        Me.FindMissingButton.TabIndex = 0
        Me.FindMissingButton.Text = "Find missing"
        Me.FindMissingButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 107)
        Me.Controls.Add(Me.FindMissingButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FindMissingButton As Button
End Class
