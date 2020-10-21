Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ChildForm
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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ColumnNameLabel = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ValueTextBox = New System.Windows.Forms.TextBox()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(14, 22)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(42, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Column"
            '
            'ColumnNameLabel
            '
            Me.ColumnNameLabel.AutoSize = True
            Me.ColumnNameLabel.Location = New System.Drawing.Point(62, 22)
            Me.ColumnNameLabel.Name = "ColumnNameLabel"
            Me.ColumnNameLabel.Size = New System.Drawing.Size(65, 13)
            Me.ColumnNameLabel.TabIndex = 1
            Me.ColumnNameLabel.Text = "place holder"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(17, 51)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Value"
            '
            'ValueTextBox
            '
            Me.ValueTextBox.Location = New System.Drawing.Point(62, 48)
            Me.ValueTextBox.Name = "ValueTextBox"
            Me.ValueTextBox.Size = New System.Drawing.Size(177, 20)
            Me.ValueTextBox.TabIndex = 3
            '
            'ChildForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(252, 88)
            Me.Controls.Add(Me.ValueTextBox)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.ColumnNameLabel)
            Me.Controls.Add(Me.Label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "ChildForm"
            Me.Text = "Information"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label1 As Label
        Friend WithEvents ColumnNameLabel As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents ValueTextBox As TextBox
    End Class
End Namespace