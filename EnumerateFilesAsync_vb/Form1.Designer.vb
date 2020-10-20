Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Xml.Linq


Partial Public Class Form1
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
        Me.StartButton = New System.Windows.Forms.Button()
        Me.CurrentFileLabel = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FolderNameListBox = New System.Windows.Forms.ListBox()
        Me.ErrorListBox = New System.Windows.Forms.ListBox()
        Me.FolderNameTextBox = New System.Windows.Forms.TextBox()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(19, 19)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'CurrentFileLabel
        '
        Me.CurrentFileLabel.AutoSize = True
        Me.CurrentFileLabel.Location = New System.Drawing.Point(28, 187)
        Me.CurrentFileLabel.Name = "CurrentFileLabel"
        Me.CurrentFileLabel.Size = New System.Drawing.Size(57, 13)
        Me.CurrentFileLabel.TabIndex = 2
        Me.CurrentFileLabel.Text = "Current file"
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(109, 19)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CancelButton)
        Me.GroupBox1.Controls.Add(Me.StartButton)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'FolderNameListBox
        '
        Me.FolderNameListBox.FormattingEnabled = True
        Me.FolderNameListBox.Location = New System.Drawing.Point(31, 203)
        Me.FolderNameListBox.Name = "FolderNameListBox"
        Me.FolderNameListBox.Size = New System.Drawing.Size(819, 82)
        Me.FolderNameListBox.TabIndex = 6
        '
        'ErrorListBox
        '
        Me.ErrorListBox.FormattingEnabled = True
        Me.ErrorListBox.Location = New System.Drawing.Point(31, 311)
        Me.ErrorListBox.Name = "ErrorListBox"
        Me.ErrorListBox.Size = New System.Drawing.Size(819, 82)
        Me.ErrorListBox.TabIndex = 7
        '
        'FolderNameTextBox
        '
        Me.FolderNameTextBox.Location = New System.Drawing.Point(31, 91)
        Me.FolderNameTextBox.Name = "FolderNameTextBox"
        Me.FolderNameTextBox.Size = New System.Drawing.Size(778, 20)
        Me.FolderNameTextBox.TabIndex = 8
        Me.FolderNameTextBox.Text = "C:\OED\Dotnetland\vbGettingStarted"
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Image = Global.My.Resources.Resources.Folder_16x
        Me.SelectFolderButton.Location = New System.Drawing.Point(815, 91)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(26, 23)
        Me.SelectFolderButton.TabIndex = 9
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'FindTextBox
        '
        Me.FindTextBox.Location = New System.Drawing.Point(31, 153)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(184, 20)
        Me.FindTextBox.TabIndex = 10
        Me.FindTextBox.Text = "dim"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Text to seach for"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(277, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Code to find text in .vb files"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 401)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FindTextBox)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.FolderNameTextBox)
        Me.Controls.Add(Me.ErrorListBox)
        Me.Controls.Add(Me.FolderNameListBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CurrentFileLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iterate folders"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As Button
    Friend CurrentFileLabel As Label
    Friend WithEvents CancelButton As Button
    Friend GroupBox1 As GroupBox
    Friend FolderNameListBox As ListBox
    Friend ErrorListBox As ListBox
    Friend WithEvents FolderNameTextBox As TextBox
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents FindTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class