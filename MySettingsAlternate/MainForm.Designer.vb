﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.IncomingFolderTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ConnectionStringTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LastRanTextBox = New System.Windows.Forms.TextBox()
        Me.ApplicationPropertiesGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResultsTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AppSettingsListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WindowTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TestBoxCheckBox = New System.Windows.Forms.CheckBox()
        Me.MailItemsComboBox = New System.Windows.Forms.ComboBox()
        Me.UserDetailsButton = New System.Windows.Forms.Button()
        Me.GetMainWindowTitleJsonButton = New System.Windows.Forms.Button()
        Me.ReadJsonButton = New System.Windows.Forms.Button()
        Me.CurrentMailItemButton = New System.Windows.Forms.Button()
        Me.GetMyApplicationDynamicallyButton = New System.Windows.Forms.Button()
        Me.KeyExistsButton = New System.Windows.Forms.Button()
        Me.ChangeConnectionStringButton = New System.Windows.Forms.Button()
        Me.OpenDatabaseButton = New System.Windows.Forms.Button()
        Me.UpdateWindowTitleButton = New System.Windows.Forms.Button()
        Me.OpenErrorLogButton = New System.Windows.Forms.Button()
        Me.MyApplicationPropertiesButton = New System.Windows.Forms.Button()
        Me.CrashOnSetNonExistingKeyButton = New System.Windows.Forms.Button()
        Me.CrashOnGetNonExistingKeyButton = New System.Windows.Forms.Button()
        Me.IncomingFolderButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ApplicationPropertiesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IncomingFolder"
        '
        'IncomingFolderTextBox
        '
        Me.IncomingFolderTextBox.Location = New System.Drawing.Point(131, 40)
        Me.IncomingFolderTextBox.Name = "IncomingFolderTextBox"
        Me.IncomingFolderTextBox.Size = New System.Drawing.Size(254, 20)
        Me.IncomingFolderTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Crash"
        '
        'TextBox1
        '
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBox1.Location = New System.Drawing.Point(131, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Crash and burn"
        '
        'ConnectionStringTextBox
        '
        Me.ConnectionStringTextBox.Location = New System.Drawing.Point(15, 39)
        Me.ConnectionStringTextBox.Name = "ConnectionStringTextBox"
        Me.ConnectionStringTextBox.ReadOnly = True
        Me.ConnectionStringTextBox.Size = New System.Drawing.Size(492, 20)
        Me.ConnectionStringTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Connection string:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last ran:"
        '
        'LastRanTextBox
        '
        Me.LastRanTextBox.Location = New System.Drawing.Point(15, 82)
        Me.LastRanTextBox.Name = "LastRanTextBox"
        Me.LastRanTextBox.ReadOnly = True
        Me.LastRanTextBox.Size = New System.Drawing.Size(136, 20)
        Me.LastRanTextBox.TabIndex = 10
        '
        'ApplicationPropertiesGroupBox
        '
        Me.ApplicationPropertiesGroupBox.Controls.Add(Me.LastRanTextBox)
        Me.ApplicationPropertiesGroupBox.Controls.Add(Me.Label4)
        Me.ApplicationPropertiesGroupBox.Controls.Add(Me.Label3)
        Me.ApplicationPropertiesGroupBox.Controls.Add(Me.ConnectionStringTextBox)
        Me.ApplicationPropertiesGroupBox.Location = New System.Drawing.Point(17, 264)
        Me.ApplicationPropertiesGroupBox.Name = "ApplicationPropertiesGroupBox"
        Me.ApplicationPropertiesGroupBox.Size = New System.Drawing.Size(584, 115)
        Me.ApplicationPropertiesGroupBox.TabIndex = 11
        Me.ApplicationPropertiesGroupBox.TabStop = False
        Me.ApplicationPropertiesGroupBox.Text = "Application properties"
        '
        'ResultsTextBox
        '
        Me.ResultsTextBox.BackColor = System.Drawing.Color.Black
        Me.ResultsTextBox.ForeColor = System.Drawing.Color.Yellow
        Me.ResultsTextBox.Location = New System.Drawing.Point(17, 411)
        Me.ResultsTextBox.Multiline = True
        Me.ResultsTextBox.Name = "ResultsTextBox"
        Me.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ResultsTextBox.Size = New System.Drawing.Size(584, 96)
        Me.ResultsTextBox.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Raised exceptions/Setting changed"
        '
        'AppSettingsListView
        '
        Me.AppSettingsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.AppSettingsListView.HideSelection = False
        Me.AppSettingsListView.Location = New System.Drawing.Point(17, 528)
        Me.AppSettingsListView.Name = "AppSettingsListView"
        Me.AppSettingsListView.Size = New System.Drawing.Size(584, 106)
        Me.AppSettingsListView.TabIndex = 15
        Me.AppSettingsListView.UseCompatibleStateImageBehavior = False
        Me.AppSettingsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Property"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 200
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 512)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "App settings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Window Title"
        '
        'WindowTitleTextBox
        '
        Me.WindowTitleTextBox.Location = New System.Drawing.Point(131, 11)
        Me.WindowTitleTextBox.Name = "WindowTitleTextBox"
        Me.WindowTitleTextBox.Size = New System.Drawing.Size(254, 20)
        Me.WindowTitleTextBox.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Test mode"
        '
        'TestBoxCheckBox
        '
        Me.TestBoxCheckBox.AutoSize = True
        Me.TestBoxCheckBox.Location = New System.Drawing.Point(131, 114)
        Me.TestBoxCheckBox.Name = "TestBoxCheckBox"
        Me.TestBoxCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.TestBoxCheckBox.TabIndex = 24
        Me.TestBoxCheckBox.UseVisualStyleBackColor = True
        '
        'MailItemsComboBox
        '
        Me.MailItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MailItemsComboBox.FormattingEnabled = True
        Me.MailItemsComboBox.Location = New System.Drawing.Point(131, 152)
        Me.MailItemsComboBox.Name = "MailItemsComboBox"
        Me.MailItemsComboBox.Size = New System.Drawing.Size(254, 21)
        Me.MailItemsComboBox.TabIndex = 28
        '
        'UserDetailsButton
        '
        Me.UserDetailsButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Account_16x
        Me.UserDetailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UserDetailsButton.Location = New System.Drawing.Point(672, 125)
        Me.UserDetailsButton.Name = "UserDetailsButton"
        Me.UserDetailsButton.Size = New System.Drawing.Size(176, 23)
        Me.UserDetailsButton.TabIndex = 32
        Me.UserDetailsButton.Text = "User details"
        Me.UserDetailsButton.UseVisualStyleBackColor = True
        '
        'GetMainWindowTitleJsonButton
        '
        Me.GetMainWindowTitleJsonButton.Image = Global.MySettingsAlternate.My.Resources.Resources.json_file
        Me.GetMainWindowTitleJsonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetMainWindowTitleJsonButton.Location = New System.Drawing.Point(672, 40)
        Me.GetMainWindowTitleJsonButton.Name = "GetMainWindowTitleJsonButton"
        Me.GetMainWindowTitleJsonButton.Size = New System.Drawing.Size(176, 23)
        Me.GetMainWindowTitleJsonButton.TabIndex = 31
        Me.GetMainWindowTitleJsonButton.Text = "Main window title"
        Me.GetMainWindowTitleJsonButton.UseVisualStyleBackColor = True
        '
        'ReadJsonButton
        '
        Me.ReadJsonButton.Image = Global.MySettingsAlternate.My.Resources.Resources.json_file
        Me.ReadJsonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReadJsonButton.Location = New System.Drawing.Point(672, 9)
        Me.ReadJsonButton.Name = "ReadJsonButton"
        Me.ReadJsonButton.Size = New System.Drawing.Size(176, 23)
        Me.ReadJsonButton.TabIndex = 30
        Me.ReadJsonButton.Text = "Read json config"
        Me.ReadJsonButton.UseVisualStyleBackColor = True
        '
        'CurrentMailItemButton
        '
        Me.CurrentMailItemButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Mail_16x
        Me.CurrentMailItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CurrentMailItemButton.Location = New System.Drawing.Point(131, 178)
        Me.CurrentMailItemButton.Name = "CurrentMailItemButton"
        Me.CurrentMailItemButton.Size = New System.Drawing.Size(254, 23)
        Me.CurrentMailItemButton.TabIndex = 29
        Me.CurrentMailItemButton.Text = "Current mail item"
        Me.CurrentMailItemButton.UseVisualStyleBackColor = True
        '
        'GetMyApplicationDynamicallyButton
        '
        Me.GetMyApplicationDynamicallyButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Dynamic_16x
        Me.GetMyApplicationDynamicallyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GetMyApplicationDynamicallyButton.Location = New System.Drawing.Point(425, 207)
        Me.GetMyApplicationDynamicallyButton.Name = "GetMyApplicationDynamicallyButton"
        Me.GetMyApplicationDynamicallyButton.Size = New System.Drawing.Size(176, 23)
        Me.GetMyApplicationDynamicallyButton.TabIndex = 26
        Me.GetMyApplicationDynamicallyButton.Text = "Dynamic MyApplication"
        Me.GetMyApplicationDynamicallyButton.UseVisualStyleBackColor = True
        '
        'KeyExistsButton
        '
        Me.KeyExistsButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Key_16x
        Me.KeyExistsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KeyExistsButton.Location = New System.Drawing.Point(425, 178)
        Me.KeyExistsButton.Name = "KeyExistsButton"
        Me.KeyExistsButton.Size = New System.Drawing.Size(176, 23)
        Me.KeyExistsButton.TabIndex = 25
        Me.KeyExistsButton.Text = "Key exists"
        Me.KeyExistsButton.UseVisualStyleBackColor = True
        '
        'ChangeConnectionStringButton
        '
        Me.ChangeConnectionStringButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Database_16x
        Me.ChangeConnectionStringButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangeConnectionStringButton.Location = New System.Drawing.Point(425, 152)
        Me.ChangeConnectionStringButton.Name = "ChangeConnectionStringButton"
        Me.ChangeConnectionStringButton.Size = New System.Drawing.Size(176, 23)
        Me.ChangeConnectionStringButton.TabIndex = 22
        Me.ChangeConnectionStringButton.Text = "Change Connection string"
        Me.ChangeConnectionStringButton.UseVisualStyleBackColor = True
        '
        'OpenDatabaseButton
        '
        Me.OpenDatabaseButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Database_16x
        Me.OpenDatabaseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OpenDatabaseButton.Location = New System.Drawing.Point(425, 125)
        Me.OpenDatabaseButton.Name = "OpenDatabaseButton"
        Me.OpenDatabaseButton.Size = New System.Drawing.Size(176, 23)
        Me.OpenDatabaseButton.TabIndex = 21
        Me.OpenDatabaseButton.Text = "Open database connection"
        Me.OpenDatabaseButton.UseVisualStyleBackColor = True
        '
        'UpdateWindowTitleButton
        '
        Me.UpdateWindowTitleButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Execute_16x
        Me.UpdateWindowTitleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UpdateWindowTitleButton.Location = New System.Drawing.Point(425, 9)
        Me.UpdateWindowTitleButton.Name = "UpdateWindowTitleButton"
        Me.UpdateWindowTitleButton.Size = New System.Drawing.Size(176, 23)
        Me.UpdateWindowTitleButton.TabIndex = 20
        Me.UpdateWindowTitleButton.Text = "Update windows title"
        Me.UpdateWindowTitleButton.UseVisualStyleBackColor = True
        '
        'OpenErrorLogButton
        '
        Me.OpenErrorLogButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OpenErrorLogButton.Image = Global.MySettingsAlternate.My.Resources.Resources.View_16x
        Me.OpenErrorLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OpenErrorLogButton.Location = New System.Drawing.Point(17, 640)
        Me.OpenErrorLogButton.Name = "OpenErrorLogButton"
        Me.OpenErrorLogButton.Size = New System.Drawing.Size(170, 23)
        Me.OpenErrorLogButton.TabIndex = 6
        Me.OpenErrorLogButton.Text = "Open log file"
        Me.OpenErrorLogButton.UseVisualStyleBackColor = True
        '
        'MyApplicationPropertiesButton
        '
        Me.MyApplicationPropertiesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MyApplicationPropertiesButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Property_16x
        Me.MyApplicationPropertiesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MyApplicationPropertiesButton.Location = New System.Drawing.Point(431, 640)
        Me.MyApplicationPropertiesButton.Name = "MyApplicationPropertiesButton"
        Me.MyApplicationPropertiesButton.Size = New System.Drawing.Size(170, 23)
        Me.MyApplicationPropertiesButton.TabIndex = 16
        Me.MyApplicationPropertiesButton.Text = "Get application properties"
        Me.MyApplicationPropertiesButton.UseVisualStyleBackColor = True
        '
        'CrashOnSetNonExistingKeyButton
        '
        Me.CrashOnSetNonExistingKeyButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Execute_16x
        Me.CrashOnSetNonExistingKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CrashOnSetNonExistingKeyButton.Location = New System.Drawing.Point(425, 98)
        Me.CrashOnSetNonExistingKeyButton.Name = "CrashOnSetNonExistingKeyButton"
        Me.CrashOnSetNonExistingKeyButton.Size = New System.Drawing.Size(176, 23)
        Me.CrashOnSetNonExistingKeyButton.TabIndex = 12
        Me.CrashOnSetNonExistingKeyButton.Text = "Set non-existing key"
        Me.CrashOnSetNonExistingKeyButton.UseVisualStyleBackColor = True
        '
        'CrashOnGetNonExistingKeyButton
        '
        Me.CrashOnGetNonExistingKeyButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Execute_16x
        Me.CrashOnGetNonExistingKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CrashOnGetNonExistingKeyButton.Location = New System.Drawing.Point(425, 68)
        Me.CrashOnGetNonExistingKeyButton.Name = "CrashOnGetNonExistingKeyButton"
        Me.CrashOnGetNonExistingKeyButton.Size = New System.Drawing.Size(176, 23)
        Me.CrashOnGetNonExistingKeyButton.TabIndex = 5
        Me.CrashOnGetNonExistingKeyButton.Text = "Get non-existing key"
        Me.CrashOnGetNonExistingKeyButton.UseVisualStyleBackColor = True
        '
        'IncomingFolderButton
        '
        Me.IncomingFolderButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Execute_16x
        Me.IncomingFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IncomingFolderButton.Location = New System.Drawing.Point(425, 40)
        Me.IncomingFolderButton.Name = "IncomingFolderButton"
        Me.IncomingFolderButton.Size = New System.Drawing.Size(176, 23)
        Me.IncomingFolderButton.TabIndex = 2
        Me.IncomingFolderButton.Text = "Update Incoming folder"
        Me.IncomingFolderButton.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(669, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "User details json"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 669)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UserDetailsButton)
        Me.Controls.Add(Me.GetMainWindowTitleJsonButton)
        Me.Controls.Add(Me.ReadJsonButton)
        Me.Controls.Add(Me.CurrentMailItemButton)
        Me.Controls.Add(Me.MailItemsComboBox)
        Me.Controls.Add(Me.GetMyApplicationDynamicallyButton)
        Me.Controls.Add(Me.KeyExistsButton)
        Me.Controls.Add(Me.TestBoxCheckBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ChangeConnectionStringButton)
        Me.Controls.Add(Me.OpenDatabaseButton)
        Me.Controls.Add(Me.UpdateWindowTitleButton)
        Me.Controls.Add(Me.WindowTitleTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OpenErrorLogButton)
        Me.Controls.Add(Me.MyApplicationPropertiesButton)
        Me.Controls.Add(Me.AppSettingsListView)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ResultsTextBox)
        Me.Controls.Add(Me.CrashOnSetNonExistingKeyButton)
        Me.Controls.Add(Me.ApplicationPropertiesGroupBox)
        Me.Controls.Add(Me.CrashOnGetNonExistingKeyButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IncomingFolderButton)
        Me.Controls.Add(Me.IncomingFolderTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppSetting code sample"
        Me.ApplicationPropertiesGroupBox.ResumeLayout(False)
        Me.ApplicationPropertiesGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IncomingFolderTextBox As TextBox
    Friend WithEvents IncomingFolderButton As Button
    Friend WithEvents CrashOnGetNonExistingKeyButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenErrorLogButton As Button
    Friend WithEvents ConnectionStringTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LastRanTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CrashOnSetNonExistingKeyButton As Button
    Friend WithEvents ApplicationPropertiesGroupBox As GroupBox
    Friend WithEvents ResultsTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents AppSettingsListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents MyApplicationPropertiesButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents UpdateWindowTitleButton As Button
    Friend WithEvents WindowTitleTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents OpenDatabaseButton As Button
    Friend WithEvents ChangeConnectionStringButton As Button
    Friend WithEvents TestBoxCheckBox As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents KeyExistsButton As Button
    Friend WithEvents GetMyApplicationDynamicallyButton As Button
    Friend WithEvents MailItemsComboBox As ComboBox
    Friend WithEvents CurrentMailItemButton As Button
    Friend WithEvents ReadJsonButton As Button
    Friend WithEvents GetMainWindowTitleJsonButton As Button
    Friend WithEvents UserDetailsButton As Button
    Friend WithEvents Label9 As Label
End Class
