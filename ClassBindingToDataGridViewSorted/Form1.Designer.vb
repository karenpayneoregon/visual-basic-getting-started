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
        Me.CurrentPersonButton = New System.Windows.Forms.Button()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NewPersonButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CurrentPersonButton
        '
        Me.CurrentPersonButton.Location = New System.Drawing.Point(12, 243)
        Me.CurrentPersonButton.Name = "CurrentPersonButton"
        Me.CurrentPersonButton.Size = New System.Drawing.Size(75, 23)
        Me.CurrentPersonButton.TabIndex = 4
        Me.CurrentPersonButton.Text = "Current"
        Me.CurrentPersonButton.UseVisualStyleBackColor = True
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(425, 209)
        Me.dataGridView1.TabIndex = 3
        '
        'NewPersonButton
        '
        Me.NewPersonButton.Location = New System.Drawing.Point(93, 243)
        Me.NewPersonButton.Name = "NewPersonButton"
        Me.NewPersonButton.Size = New System.Drawing.Size(75, 23)
        Me.NewPersonButton.TabIndex = 5
        Me.NewPersonButton.Text = "New"
        Me.NewPersonButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(190, 243)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(75, 23)
        Me.ExportButton.TabIndex = 6
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 286)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.NewPersonButton)
        Me.Controls.Add(Me.CurrentPersonButton)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code sample"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents CurrentPersonButton As Button
    Private WithEvents dataGridView1 As DataGridView
    Friend WithEvents NewPersonButton As Button
    Friend WithEvents ExportButton As Button
End Class
