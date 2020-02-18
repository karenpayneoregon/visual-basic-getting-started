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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EditLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EditFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UpdateCurrentCustomerButton = New System.Windows.Forms.Button()
        Me.AddNewCustomerButton = New System.Windows.Forms.Button()
        Me.ListCountLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last"
        '
        'AddFirstNameTextBox
        '
        Me.AddFirstNameTextBox.Location = New System.Drawing.Point(66, 29)
        Me.AddFirstNameTextBox.Name = "AddFirstNameTextBox"
        Me.AddFirstNameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.AddFirstNameTextBox.TabIndex = 2
        Me.AddFirstNameTextBox.Text = "Mary"
        '
        'AddLastNameTextBox
        '
        Me.AddLastNameTextBox.Location = New System.Drawing.Point(66, 60)
        Me.AddLastNameTextBox.Name = "AddLastNameTextBox"
        Me.AddLastNameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.AddLastNameTextBox.TabIndex = 3
        Me.AddLastNameTextBox.Text = "Adams"
        '
        'CustomerListBox
        '
        Me.CustomerListBox.FormattingEnabled = True
        Me.CustomerListBox.Location = New System.Drawing.Point(318, 26)
        Me.CustomerListBox.Name = "CustomerListBox"
        Me.CustomerListBox.Size = New System.Drawing.Size(217, 95)
        Me.CustomerListBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddNewCustomerButton)
        Me.GroupBox1.Controls.Add(Me.AddLastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.AddFirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 116)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add new"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdateCurrentCustomerButton)
        Me.GroupBox2.Controls.Add(Me.EditLastNameTextBox)
        Me.GroupBox2.Controls.Add(Me.EditFirstNameTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 116)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edit current"
        '
        'EditLastNameTextBox
        '
        Me.EditLastNameTextBox.Location = New System.Drawing.Point(66, 60)
        Me.EditLastNameTextBox.Name = "EditLastNameTextBox"
        Me.EditLastNameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EditLastNameTextBox.TabIndex = 3
        Me.EditLastNameTextBox.Text = "Murphy"
        '
        'EditFirstNameTextBox
        '
        Me.EditFirstNameTextBox.Location = New System.Drawing.Point(66, 29)
        Me.EditFirstNameTextBox.Name = "EditFirstNameTextBox"
        Me.EditFirstNameTextBox.Size = New System.Drawing.Size(124, 20)
        Me.EditFirstNameTextBox.TabIndex = 2
        Me.EditFirstNameTextBox.Text = "Joe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "First"
        '
        'UpdateCurrentCustomerButton
        '
        Me.UpdateCurrentCustomerButton.Location = New System.Drawing.Point(115, 86)
        Me.UpdateCurrentCustomerButton.Name = "UpdateCurrentCustomerButton"
        Me.UpdateCurrentCustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateCurrentCustomerButton.TabIndex = 7
        Me.UpdateCurrentCustomerButton.Text = "Update"
        Me.UpdateCurrentCustomerButton.UseVisualStyleBackColor = True
        '
        'AddNewCustomerButton
        '
        Me.AddNewCustomerButton.Location = New System.Drawing.Point(115, 86)
        Me.AddNewCustomerButton.Name = "AddNewCustomerButton"
        Me.AddNewCustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.AddNewCustomerButton.TabIndex = 8
        Me.AddNewCustomerButton.Text = "Add"
        Me.AddNewCustomerButton.UseVisualStyleBackColor = True
        '
        'ListCountLabel
        '
        Me.ListCountLabel.AutoSize = True
        Me.ListCountLabel.Location = New System.Drawing.Point(315, 10)
        Me.ListCountLabel.Name = "ListCountLabel"
        Me.ListCountLabel.Size = New System.Drawing.Size(39, 13)
        Me.ListCountLabel.TabIndex = 7
        Me.ListCountLabel.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 289)
        Me.Controls.Add(Me.ListCountLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CustomerListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListBox Binding"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddFirstNameTextBox As TextBox
    Friend WithEvents AddLastNameTextBox As TextBox
    Friend WithEvents CustomerListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AddNewCustomerButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UpdateCurrentCustomerButton As Button
    Friend WithEvents EditLastNameTextBox As TextBox
    Friend WithEvents EditFirstNameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ListCountLabel As Label
End Class
