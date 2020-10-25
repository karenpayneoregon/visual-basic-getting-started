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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BitMapNamesComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BitMapPictureBox = New System.Windows.Forms.PictureBox()
        Me.IconNamesComboBox = New System.Windows.Forms.ComboBox()
        Me.IconPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BitMapPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(95, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(260, 69)
        Me.ListBox1.TabIndex = 1
        '
        'BitMapNamesComboBox
        '
        Me.BitMapNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitMapNamesComboBox.FormattingEnabled = True
        Me.BitMapNamesComboBox.Location = New System.Drawing.Point(87, 35)
        Me.BitMapNamesComboBox.Name = "BitMapNamesComboBox"
        Me.BitMapNamesComboBox.Size = New System.Drawing.Size(256, 21)
        Me.BitMapNamesComboBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 136)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command line"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BitMapNamesComboBox)
        Me.GroupBox2.Controls.Add(Me.BitMapPictureBox)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(423, 93)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bitmap from resource via string name"
        '
        'BitMapPictureBox
        '
        Me.BitMapPictureBox.Location = New System.Drawing.Point(349, 35)
        Me.BitMapPictureBox.Name = "BitMapPictureBox"
        Me.BitMapPictureBox.Size = New System.Drawing.Size(41, 33)
        Me.BitMapPictureBox.TabIndex = 3
        Me.BitMapPictureBox.TabStop = False
        '
        'IconNamesComboBox
        '
        Me.IconNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IconNamesComboBox.FormattingEnabled = True
        Me.IconNamesComboBox.Location = New System.Drawing.Point(84, 31)
        Me.IconNamesComboBox.Name = "IconNamesComboBox"
        Me.IconNamesComboBox.Size = New System.Drawing.Size(256, 21)
        Me.IconNamesComboBox.TabIndex = 5
        '
        'IconPictureBox
        '
        Me.IconPictureBox.Location = New System.Drawing.Point(346, 31)
        Me.IconPictureBox.Name = "IconPictureBox"
        Me.IconPictureBox.Size = New System.Drawing.Size(41, 33)
        Me.IconPictureBox.TabIndex = 5
        Me.IconPictureBox.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.IconPictureBox)
        Me.GroupBox3.Controls.Add(Me.IconNamesComboBox)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 287)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 98)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Icon from resource via string name to BitMap"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 418)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My.Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.BitMapPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents BitMapPictureBox As PictureBox
    Friend WithEvents BitMapNamesComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IconNamesComboBox As ComboBox
    Friend WithEvents IconPictureBox As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
