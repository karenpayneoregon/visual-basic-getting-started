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
        Me.CurrentFileLabel.Location = New System.Drawing.Point(28, 107)
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
        Me.FolderNameListBox.Location = New System.Drawing.Point(31, 137)
        Me.FolderNameListBox.Name = "FolderNameListBox"
        Me.FolderNameListBox.Size = New System.Drawing.Size(819, 82)
        Me.FolderNameListBox.TabIndex = 6
        '
        'ErrorListBox
        '
        Me.ErrorListBox.FormattingEnabled = True
        Me.ErrorListBox.Location = New System.Drawing.Point(31, 245)
        Me.ErrorListBox.Name = "ErrorListBox"
        Me.ErrorListBox.Size = New System.Drawing.Size(819, 82)
        Me.ErrorListBox.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 339)
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
End Class