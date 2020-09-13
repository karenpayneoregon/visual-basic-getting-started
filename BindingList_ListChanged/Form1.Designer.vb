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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AddPersonButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveCurrentPersonButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(14, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(261, 173)
        Me.ListBox1.TabIndex = 0
        '
        'AddPersonButton
        '
        Me.AddPersonButton.Location = New System.Drawing.Point(12, 257)
        Me.AddPersonButton.Name = "AddPersonButton"
        Me.AddPersonButton.Size = New System.Drawing.Size(263, 23)
        Me.AddPersonButton.TabIndex = 1
        Me.AddPersonButton.Text = "Add person"
        Me.AddPersonButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(53, 196)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.FirstNameTextBox.TabIndex = 2
        Me.FirstNameTextBox.Text = "Mary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(53, 223)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.LastNameTextBox.TabIndex = 5
        Me.LastNameTextBox.Text = "Smith"
        '
        'RemoveCurrentPersonButton
        '
        Me.RemoveCurrentPersonButton.Location = New System.Drawing.Point(12, 288)
        Me.RemoveCurrentPersonButton.Name = "RemoveCurrentPersonButton"
        Me.RemoveCurrentPersonButton.Size = New System.Drawing.Size(263, 23)
        Me.RemoveCurrentPersonButton.TabIndex = 6
        Me.RemoveCurrentPersonButton.Text = "Remove current person"
        Me.RemoveCurrentPersonButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 323)
        Me.Controls.Add(Me.RemoveCurrentPersonButton)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.AddPersonButton)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BindingList ListChanged"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents AddPersonButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents RemoveCurrentPersonButton As Button
End Class
