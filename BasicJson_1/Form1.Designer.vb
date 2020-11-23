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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SaveAllButton = New System.Windows.Forms.Button()
        Me.CurrentButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(18, 35)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(164, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(15, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Value"
        '
        'ValueTextBox
        '
        Me.ValueTextBox.Location = New System.Drawing.Point(18, 90)
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(164, 20)
        Me.ValueTextBox.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = true
        Me.ListBox1.Location = New System.Drawing.Point(213, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(167, 69)
        Me.ListBox1.TabIndex = 4
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(18, 131)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(164, 23)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = true
        '
        'SaveAllButton
        '
        Me.SaveAllButton.Location = New System.Drawing.Point(18, 170)
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(164, 23)
        Me.SaveAllButton.TabIndex = 6
        Me.SaveAllButton.Text = "Save all"
        Me.SaveAllButton.UseVisualStyleBackColor = true
        '
        'CurrentButton
        '
        Me.CurrentButton.Location = New System.Drawing.Point(216, 131)
        Me.CurrentButton.Name = "CurrentButton"
        Me.CurrentButton.Size = New System.Drawing.Size(164, 23)
        Me.CurrentButton.TabIndex = 7
        Me.CurrentButton.Text = "Get current item"
        Me.CurrentButton.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 204)
        Me.Controls.Add(Me.CurrentButton)
        Me.Controls.Add(Me.SaveAllButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ValueTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Json code sample"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ValueTextBox As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents SaveAllButton As Button
    Friend WithEvents CurrentButton As Button
End Class
