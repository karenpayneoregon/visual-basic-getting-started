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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.IncomingFolderTextBox = New System.Windows.Forms.TextBox()
        Me.IncomingFolderButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CrashButton = New System.Windows.Forms.Button()
        Me.OpenErrorLogButton = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IncomingFolder"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'IncomingFolderTextBox
        '
        Me.IncomingFolderTextBox.Location = New System.Drawing.Point(97, 28)
        Me.IncomingFolderTextBox.Name = "IncomingFolderTextBox"
        Me.IncomingFolderTextBox.Size = New System.Drawing.Size(181, 20)
        Me.IncomingFolderTextBox.TabIndex = 1
        '
        'IncomingFolderButton
        '
        Me.IncomingFolderButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Execute_16x
        Me.IncomingFolderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IncomingFolderButton.Location = New System.Drawing.Point(284, 26)
        Me.IncomingFolderButton.Name = "IncomingFolderButton"
        Me.IncomingFolderButton.Size = New System.Drawing.Size(92, 23)
        Me.IncomingFolderButton.TabIndex = 2
        Me.IncomingFolderButton.Text = "Update"
        Me.IncomingFolderButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Crash"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(97, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 20)
        Me.TextBox1.TabIndex = 4
        '
        'CrashButton
        '
        Me.CrashButton.Image = Global.MySettingsAlternate.My.Resources.Resources.Execute_16x
        Me.CrashButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CrashButton.Location = New System.Drawing.Point(284, 55)
        Me.CrashButton.Name = "CrashButton"
        Me.CrashButton.Size = New System.Drawing.Size(92, 23)
        Me.CrashButton.TabIndex = 5
        Me.CrashButton.Text = "Update"
        Me.CrashButton.UseVisualStyleBackColor = True
        '
        'OpenErrorLogButton
        '
        Me.OpenErrorLogButton.Image = Global.MySettingsAlternate.My.Resources.Resources.View_16x
        Me.OpenErrorLogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OpenErrorLogButton.Location = New System.Drawing.Point(284, 104)
        Me.OpenErrorLogButton.Name = "OpenErrorLogButton"
        Me.OpenErrorLogButton.Size = New System.Drawing.Size(92, 23)
        Me.OpenErrorLogButton.TabIndex = 6
        Me.OpenErrorLogButton.Text = "Open log"
        Me.OpenErrorLogButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 167)
        Me.Controls.Add(Me.OpenErrorLogButton)
        Me.Controls.Add(Me.CrashButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IncomingFolderButton)
        Me.Controls.Add(Me.IncomingFolderTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AppSetting code sample"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents IncomingFolderTextBox As TextBox
    Friend WithEvents IncomingFolderButton As Button
    Friend WithEvents CrashButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents OpenErrorLogButton As Button
End Class
