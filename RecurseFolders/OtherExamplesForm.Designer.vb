﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OtherExamplesForm
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
        Me.DeniedAccessCoveredButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ResultsListBox = New System.Windows.Forms.ListBox()
        Me.ExceptionsListBox = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeniedAccessCoveredButton
        '
        Me.DeniedAccessCoveredButton.Location = New System.Drawing.Point(12, 17)
        Me.DeniedAccessCoveredButton.Name = "DeniedAccessCoveredButton"
        Me.DeniedAccessCoveredButton.Size = New System.Drawing.Size(161, 23)
        Me.DeniedAccessCoveredButton.TabIndex = 0
        Me.DeniedAccessCoveredButton.Text = "Denied access covered"
        Me.DeniedAccessCoveredButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(195, 17)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(161, 23)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DeniedAccessCoveredButton)
        Me.Panel1.Controls.Add(Me.CancelButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 61)
        Me.Panel1.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ResultsListBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ExceptionsListBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(608, 307)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 3
        '
        'ResultsListBox
        '
        Me.ResultsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultsListBox.FormattingEnabled = True
        Me.ResultsListBox.Location = New System.Drawing.Point(0, 0)
        Me.ResultsListBox.Name = "ResultsListBox"
        Me.ResultsListBox.Size = New System.Drawing.Size(608, 152)
        Me.ResultsListBox.TabIndex = 0
        '
        'ExceptionsListBox
        '
        Me.ExceptionsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExceptionsListBox.FormattingEnabled = True
        Me.ExceptionsListBox.Location = New System.Drawing.Point(0, 0)
        Me.ExceptionsListBox.Name = "ExceptionsListBox"
        Me.ExceptionsListBox.Size = New System.Drawing.Size(608, 151)
        Me.ExceptionsListBox.TabIndex = 0
        '
        'OtherExamplesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 368)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "OtherExamplesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Examples"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DeniedAccessCoveredButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ResultsListBox As ListBox
    Friend WithEvents ExceptionsListBox As ListBox
End Class