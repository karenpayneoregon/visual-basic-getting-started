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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AddPersonButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveCurrentPersonButton = New System.Windows.Forms.Button()
        Me.CurrentButton = New System.Windows.Forms.Button()
        Me.PeopleDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddressDataGridView = New System.Windows.Forms.DataGridView()
        Me.FirstNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personIdColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddPersonButton
        '
        Me.AddPersonButton.Location = New System.Drawing.Point(4, 94)
        Me.AddPersonButton.Name = "AddPersonButton"
        Me.AddPersonButton.Size = New System.Drawing.Size(263, 23)
        Me.AddPersonButton.TabIndex = 1
        Me.AddPersonButton.Text = "Add person"
        Me.AddPersonButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(45, 33)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.FirstNameTextBox.TabIndex = 2
        Me.FirstNameTextBox.Text = "Mary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(45, 60)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(222, 20)
        Me.LastNameTextBox.TabIndex = 5
        Me.LastNameTextBox.Text = "Smith"
        '
        'RemoveCurrentPersonButton
        '
        Me.RemoveCurrentPersonButton.Location = New System.Drawing.Point(4, 125)
        Me.RemoveCurrentPersonButton.Name = "RemoveCurrentPersonButton"
        Me.RemoveCurrentPersonButton.Size = New System.Drawing.Size(263, 23)
        Me.RemoveCurrentPersonButton.TabIndex = 6
        Me.RemoveCurrentPersonButton.Text = "Remove current person"
        Me.RemoveCurrentPersonButton.UseVisualStyleBackColor = True
        '
        'CurrentButton
        '
        Me.CurrentButton.Location = New System.Drawing.Point(6, 157)
        Me.CurrentButton.Name = "CurrentButton"
        Me.CurrentButton.Size = New System.Drawing.Size(263, 23)
        Me.CurrentButton.TabIndex = 7
        Me.CurrentButton.Text = "Current person"
        Me.CurrentButton.UseVisualStyleBackColor = True
        '
        'PeopleDataGridView
        '
        Me.PeopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PeopleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameColumn, Me.LastNameColumn, Me.personIdColumn})
        Me.PeopleDataGridView.Location = New System.Drawing.Point(284, 33)
        Me.PeopleDataGridView.Name = "PeopleDataGridView"
        Me.PeopleDataGridView.Size = New System.Drawing.Size(353, 170)
        Me.PeopleDataGridView.TabIndex = 8
        '
        'AddressDataGridView
        '
        Me.AddressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddressDataGridView.Location = New System.Drawing.Point(283, 212)
        Me.AddressDataGridView.Name = "AddressDataGridView"
        Me.AddressDataGridView.Size = New System.Drawing.Size(354, 154)
        Me.AddressDataGridView.TabIndex = 9
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.DataPropertyName = "FirstName"
        Me.FirstNameColumn.HeaderText = "First"
        Me.FirstNameColumn.Name = "FirstNameColumn"
        '
        'LastNameColumn
        '
        Me.LastNameColumn.DataPropertyName = "LastName"
        Me.LastNameColumn.HeaderText = "Last"
        Me.LastNameColumn.Name = "LastNameColumn"
        '
        'personIdColumn
        '
        Me.personIdColumn.DataPropertyName = "PersonId"
        Me.personIdColumn.HeaderText = "Id"
        Me.personIdColumn.Name = "personIdColumn"
        '
        'PersonBindingNavigator
        '
        Me.PersonBindingNavigator.AddNewItem = Nothing
        Me.PersonBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonBindingNavigator.DeleteItem = Nothing
        Me.PersonBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.PersonBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonBindingNavigator.Name = "PersonBindingNavigator"
        Me.PersonBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonBindingNavigator.Size = New System.Drawing.Size(659, 25)
        Me.PersonBindingNavigator.TabIndex = 10
        Me.PersonBindingNavigator.Text = "PersonBindingNavigator"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 376)
        Me.Controls.Add(Me.PersonBindingNavigator)
        Me.Controls.Add(Me.AddressDataGridView)
        Me.Controls.Add(Me.PeopleDataGridView)
        Me.Controls.Add(Me.CurrentButton)
        Me.Controls.Add(Me.RemoveCurrentPersonButton)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.AddPersonButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BindingList ListChanged"
        CType(Me.PeopleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddressDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonBindingNavigator.ResumeLayout(False)
        Me.PersonBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddPersonButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents RemoveCurrentPersonButton As Button
    Friend WithEvents CurrentButton As Button
    Friend WithEvents PeopleDataGridView As DataGridView
    Friend WithEvents AddressDataGridView As DataGridView
    Friend WithEvents FirstNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameColumn As DataGridViewTextBoxColumn
    Friend WithEvents personIdColumn As DataGridViewTextBoxColumn
    Friend WithEvents PersonBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
