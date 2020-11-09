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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListCustomersButton = New System.Windows.Forms.Button()
        Me.SingleCustomerButton = New System.Windows.Forms.Button()
        Me.ListCustomerItemsButton = New System.Windows.Forms.Button()
        Me.CustomersComboBox = New System.Windows.Forms.ComboBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerItemComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListCustomersButton
        '
        Me.ListCustomersButton.Location = New System.Drawing.Point(12, 12)
        Me.ListCustomersButton.Name = "ListCustomersButton"
        Me.ListCustomersButton.Size = New System.Drawing.Size(157, 23)
        Me.ListCustomersButton.TabIndex = 0
        Me.ListCustomersButton.Text = "List of customers"
        Me.ListCustomersButton.UseVisualStyleBackColor = True
        '
        'SingleCustomerButton
        '
        Me.SingleCustomerButton.Location = New System.Drawing.Point(12, 45)
        Me.SingleCustomerButton.Name = "SingleCustomerButton"
        Me.SingleCustomerButton.Size = New System.Drawing.Size(157, 23)
        Me.SingleCustomerButton.TabIndex = 1
        Me.SingleCustomerButton.Text = "Single customer"
        Me.SingleCustomerButton.UseVisualStyleBackColor = True
        '
        'ListCustomerItemsButton
        '
        Me.ListCustomerItemsButton.Location = New System.Drawing.Point(12, 78)
        Me.ListCustomerItemsButton.Name = "ListCustomerItemsButton"
        Me.ListCustomerItemsButton.Size = New System.Drawing.Size(157, 23)
        Me.ListCustomerItemsButton.TabIndex = 2
        Me.ListCustomerItemsButton.Text = "List of CustomerItem"
        Me.ListCustomerItemsButton.UseVisualStyleBackColor = True
        '
        'CustomersComboBox
        '
        Me.CustomersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustomersComboBox.FormattingEnabled = True
        Me.CustomersComboBox.Location = New System.Drawing.Point(184, 14)
        Me.CustomersComboBox.Name = "CustomersComboBox"
        Me.CustomersComboBox.Size = New System.Drawing.Size(210, 21)
        Me.CustomersComboBox.TabIndex = 3
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.Location = New System.Drawing.Point(184, 47)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(210, 20)
        Me.ContactNameTextBox.TabIndex = 4
        '
        'CustomerItemComboBox
        '
        Me.CustomerItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustomerItemComboBox.FormattingEnabled = True
        Me.CustomerItemComboBox.Location = New System.Drawing.Point(184, 78)
        Me.CustomerItemComboBox.Name = "CustomerItemComboBox"
        Me.CustomerItemComboBox.Size = New System.Drawing.Size(210, 21)
        Me.CustomerItemComboBox.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 119)
        Me.Controls.Add(Me.CustomerItemComboBox)
        Me.Controls.Add(Me.ContactNameTextBox)
        Me.Controls.Add(Me.CustomersComboBox)
        Me.Controls.Add(Me.ListCustomerItemsButton)
        Me.Controls.Add(Me.SingleCustomerButton)
        Me.Controls.Add(Me.ListCustomersButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EF Core code sample"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListCustomersButton As Button
    Friend WithEvents SingleCustomerButton As Button
    Friend WithEvents ListCustomerItemsButton As Button
    Friend WithEvents CustomersComboBox As ComboBox
    Friend WithEvents ContactNameTextBox As TextBox
    Friend WithEvents CustomerItemComboBox As ComboBox
End Class
