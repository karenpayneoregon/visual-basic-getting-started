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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DetailsTabPage = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPageComboBoxNames = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToggleSelectedTabVisibleButton = New System.Windows.Forms.Button()
        Me.HideAllTabsButton = New System.Windows.Forms.Button()
        Me.ShowAllTabsButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.DetailsTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.DetailsTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(5, 7)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(367, 274)
        Me.TabControl1.TabIndex = 0
        '
        'DetailsTabPage
        '
        Me.DetailsTabPage.Controls.Add(Me.LastNameTextBox)
        Me.DetailsTabPage.Controls.Add(Me.Label2)
        Me.DetailsTabPage.Controls.Add(Me.FirstNameTextBox)
        Me.DetailsTabPage.Controls.Add(Me.Label1)
        Me.DetailsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DetailsTabPage.Name = "DetailsTabPage"
        Me.DetailsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DetailsTabPage.Size = New System.Drawing.Size(359, 248)
        Me.DetailsTabPage.TabIndex = 0
        Me.DetailsTabPage.Text = "First"
        Me.DetailsTabPage.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(359, 248)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nothing tab 1"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(359, 248)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Another nothing"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(359, 248)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Next to last"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(359, 248)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Last tab"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPageComboBoxNames
        '
        Me.TabPageComboBoxNames.FormattingEnabled = True
        Me.TabPageComboBoxNames.Location = New System.Drawing.Point(378, 25)
        Me.TabPageComboBoxNames.Name = "TabPageComboBoxNames"
        Me.TabPageComboBoxNames.Size = New System.Drawing.Size(217, 108)
        Me.TabPageComboBoxNames.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(16, 43)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(16, 94)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last name"
        '
        'ToggleSelectedTabVisibleButton
        '
        Me.ToggleSelectedTabVisibleButton.Image = Global.TabHelperFrontEnd.My.Resources.Resources.Toggle_16x
        Me.ToggleSelectedTabVisibleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToggleSelectedTabVisibleButton.Location = New System.Drawing.Point(378, 199)
        Me.ToggleSelectedTabVisibleButton.Name = "ToggleSelectedTabVisibleButton"
        Me.ToggleSelectedTabVisibleButton.Size = New System.Drawing.Size(217, 23)
        Me.ToggleSelectedTabVisibleButton.TabIndex = 5
        Me.ToggleSelectedTabVisibleButton.Text = "Toggle selected"
        Me.ToggleSelectedTabVisibleButton.UseVisualStyleBackColor = True
        '
        'HideAllTabsButton
        '
        Me.HideAllTabsButton.Image = Global.TabHelperFrontEnd.My.Resources.Resources.HideMember_16x
        Me.HideAllTabsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HideAllTabsButton.Location = New System.Drawing.Point(378, 170)
        Me.HideAllTabsButton.Name = "HideAllTabsButton"
        Me.HideAllTabsButton.Size = New System.Drawing.Size(217, 23)
        Me.HideAllTabsButton.TabIndex = 4
        Me.HideAllTabsButton.Text = "Hide all tabs"
        Me.HideAllTabsButton.UseVisualStyleBackColor = True
        '
        'ShowAllTabsButton
        '
        Me.ShowAllTabsButton.Image = Global.TabHelperFrontEnd.My.Resources.Resources.ShowBuiltIn_16x
        Me.ShowAllTabsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ShowAllTabsButton.Location = New System.Drawing.Point(378, 141)
        Me.ShowAllTabsButton.Name = "ShowAllTabsButton"
        Me.ShowAllTabsButton.Size = New System.Drawing.Size(217, 23)
        Me.ShowAllTabsButton.TabIndex = 3
        Me.ShowAllTabsButton.Text = "Show all tabs"
        Me.ShowAllTabsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 287)
        Me.Controls.Add(Me.ToggleSelectedTabVisibleButton)
        Me.Controls.Add(Me.HideAllTabsButton)
        Me.Controls.Add(Me.ShowAllTabsButton)
        Me.Controls.Add(Me.TabPageComboBoxNames)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TabControl show/hide TabPages"
        Me.TabControl1.ResumeLayout(False)
        Me.DetailsTabPage.ResumeLayout(False)
        Me.DetailsTabPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DetailsTabPage As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPageComboBoxNames As ListBox
    Friend WithEvents ShowAllTabsButton As Button
    Friend WithEvents HideAllTabsButton As Button
    Friend WithEvents ToggleSelectedTabVisibleButton As Button
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label1 As Label
End Class
