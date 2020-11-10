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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BlogListView = New System.Windows.Forms.ListView()
        Me.TitleColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContentsColum = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RemoveCurrentButton = New System.Windows.Forms.Button()
        Me.CurrentPostButton = New System.Windows.Forms.Button()
        Me.PopulateFirstTabButton = New System.Windows.Forms.Button()
        Me.EditCurrentTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UpdatePostButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentPostContentTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentPostTitleTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UpdateUrlButton = New System.Windows.Forms.Button()
        Me.CurrentUrlTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.AddNewBlogSinglePostButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FirstPostContentTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FirstPostTitleTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewBlogUrlTextBox = New System.Windows.Forms.TextBox()
        Me.EditCurrentButton = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.EditCurrentTabPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 358)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 29)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.EditCurrentTabPage)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(891, 358)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BlogListView)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(883, 332)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "All Blogs/Post"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BlogListView
        '
        Me.BlogListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TitleColumn, Me.ContentsColum})
        Me.BlogListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BlogListView.FullRowSelect = True
        Me.BlogListView.Location = New System.Drawing.Point(3, 3)
        Me.BlogListView.MultiSelect = False
        Me.BlogListView.Name = "BlogListView"
        Me.BlogListView.Size = New System.Drawing.Size(877, 282)
        Me.BlogListView.TabIndex = 2
        Me.BlogListView.UseCompatibleStateImageBehavior = False
        Me.BlogListView.View = System.Windows.Forms.View.Details
        '
        'TitleColumn
        '
        Me.TitleColumn.Text = "Title"
        '
        'ContentsColum
        '
        Me.ContentsColum.Text = "Content"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.EditCurrentButton)
        Me.Panel2.Controls.Add(Me.RemoveCurrentButton)
        Me.Panel2.Controls.Add(Me.CurrentPostButton)
        Me.Panel2.Controls.Add(Me.PopulateFirstTabButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 285)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(877, 44)
        Me.Panel2.TabIndex = 1
        '
        'RemoveCurrentButton
        '
        Me.RemoveCurrentButton.Location = New System.Drawing.Point(261, 9)
        Me.RemoveCurrentButton.Name = "RemoveCurrentButton"
        Me.RemoveCurrentButton.Size = New System.Drawing.Size(98, 23)
        Me.RemoveCurrentButton.TabIndex = 4
        Me.RemoveCurrentButton.Text = "Delete Current"
        Me.RemoveCurrentButton.UseVisualStyleBackColor = True
        '
        'CurrentPostButton
        '
        Me.CurrentPostButton.Location = New System.Drawing.Point(5, 9)
        Me.CurrentPostButton.Name = "CurrentPostButton"
        Me.CurrentPostButton.Size = New System.Drawing.Size(98, 23)
        Me.CurrentPostButton.TabIndex = 3
        Me.CurrentPostButton.Text = "Get Current"
        Me.CurrentPostButton.UseVisualStyleBackColor = True
        '
        'PopulateFirstTabButton
        '
        Me.PopulateFirstTabButton.Location = New System.Drawing.Point(389, 9)
        Me.PopulateFirstTabButton.Name = "PopulateFirstTabButton"
        Me.PopulateFirstTabButton.Size = New System.Drawing.Size(98, 23)
        Me.PopulateFirstTabButton.TabIndex = 0
        Me.PopulateFirstTabButton.Text = "Refresh"
        Me.PopulateFirstTabButton.UseVisualStyleBackColor = True
        '
        'EditCurrentTabPage
        '
        Me.EditCurrentTabPage.Controls.Add(Me.GroupBox2)
        Me.EditCurrentTabPage.Controls.Add(Me.GroupBox1)
        Me.EditCurrentTabPage.Location = New System.Drawing.Point(4, 22)
        Me.EditCurrentTabPage.Name = "EditCurrentTabPage"
        Me.EditCurrentTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.EditCurrentTabPage.Size = New System.Drawing.Size(883, 332)
        Me.EditCurrentTabPage.TabIndex = 1
        Me.EditCurrentTabPage.Text = "Edit current blog"
        Me.EditCurrentTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UpdatePostButton)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CurrentPostContentTextBox)
        Me.GroupBox2.Controls.Add(Me.CurrentPostTitleTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 142)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Current post"
        '
        'UpdatePostButton
        '
        Me.UpdatePostButton.Location = New System.Drawing.Point(776, 44)
        Me.UpdatePostButton.Name = "UpdatePostButton"
        Me.UpdatePostButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdatePostButton.TabIndex = 3
        Me.UpdatePostButton.Text = "Update"
        Me.UpdatePostButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Contents"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Title"
        '
        'CurrentPostContentTextBox
        '
        Me.CurrentPostContentTextBox.Location = New System.Drawing.Point(32, 103)
        Me.CurrentPostContentTextBox.Name = "CurrentPostContentTextBox"
        Me.CurrentPostContentTextBox.Size = New System.Drawing.Size(739, 20)
        Me.CurrentPostContentTextBox.TabIndex = 5
        '
        'CurrentPostTitleTextBox
        '
        Me.CurrentPostTitleTextBox.Location = New System.Drawing.Point(32, 47)
        Me.CurrentPostTitleTextBox.Name = "CurrentPostTitleTextBox"
        Me.CurrentPostTitleTextBox.Size = New System.Drawing.Size(739, 20)
        Me.CurrentPostTitleTextBox.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UpdateUrlButton)
        Me.GroupBox1.Controls.Add(Me.CurrentUrlTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(858, 64)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Url"
        '
        'UpdateUrlButton
        '
        Me.UpdateUrlButton.Location = New System.Drawing.Point(777, 17)
        Me.UpdateUrlButton.Name = "UpdateUrlButton"
        Me.UpdateUrlButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateUrlButton.TabIndex = 2
        Me.UpdateUrlButton.Text = "Update"
        Me.UpdateUrlButton.UseVisualStyleBackColor = True
        '
        'CurrentUrlTextBox
        '
        Me.CurrentUrlTextBox.Location = New System.Drawing.Point(28, 20)
        Me.CurrentUrlTextBox.Name = "CurrentUrlTextBox"
        Me.CurrentUrlTextBox.Size = New System.Drawing.Size(743, 20)
        Me.CurrentUrlTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.AddNewBlogSinglePostButton)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.FirstPostContentTextBox)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.FirstPostTitleTextBox)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.NewBlogUrlTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(883, 298)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Add new blog and post"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'AddNewBlogSinglePostButton
        '
        Me.AddNewBlogSinglePostButton.Location = New System.Drawing.Point(25, 191)
        Me.AddNewBlogSinglePostButton.Name = "AddNewBlogSinglePostButton"
        Me.AddNewBlogSinglePostButton.Size = New System.Drawing.Size(75, 23)
        Me.AddNewBlogSinglePostButton.TabIndex = 8
        Me.AddNewBlogSinglePostButton.Text = "Add"
        Me.AddNewBlogSinglePostButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "First post content"
        '
        'FirstPostContentTextBox
        '
        Me.FirstPostContentTextBox.Location = New System.Drawing.Point(25, 150)
        Me.FirstPostContentTextBox.Name = "FirstPostContentTextBox"
        Me.FirstPostContentTextBox.Size = New System.Drawing.Size(743, 20)
        Me.FirstPostContentTextBox.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "First post Title"
        '
        'FirstPostTitleTextBox
        '
        Me.FirstPostTitleTextBox.Location = New System.Drawing.Point(25, 95)
        Me.FirstPostTitleTextBox.Name = "FirstPostTitleTextBox"
        Me.FirstPostTitleTextBox.Size = New System.Drawing.Size(743, 20)
        Me.FirstPostTitleTextBox.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Url"
        '
        'NewBlogUrlTextBox
        '
        Me.NewBlogUrlTextBox.Location = New System.Drawing.Point(25, 40)
        Me.NewBlogUrlTextBox.Name = "NewBlogUrlTextBox"
        Me.NewBlogUrlTextBox.Size = New System.Drawing.Size(743, 20)
        Me.NewBlogUrlTextBox.TabIndex = 2
        '
        'EditCurrentButton
        '
        Me.EditCurrentButton.Location = New System.Drawing.Point(133, 9)
        Me.EditCurrentButton.Name = "EditCurrentButton"
        Me.EditCurrentButton.Size = New System.Drawing.Size(98, 23)
        Me.EditCurrentButton.TabIndex = 5
        Me.EditCurrentButton.Text = "Edit Current"
        Me.EditCurrentButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 387)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bloging Entity Framework code samples"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.EditCurrentTabPage.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents EditCurrentTabPage As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PopulateFirstTabButton As Button
    Friend WithEvents BlogListView As ListView
    Friend WithEvents TitleColumn As ColumnHeader
    Friend WithEvents ContentsColum As ColumnHeader
    Friend WithEvents CurrentPostButton As Button
    Friend WithEvents CurrentUrlTextBox As TextBox
    Friend WithEvents UpdateUrlButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CurrentPostTitleTextBox As TextBox
    Friend WithEvents CurrentPostContentTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents UpdatePostButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents AddNewBlogSinglePostButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents FirstPostContentTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FirstPostTitleTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NewBlogUrlTextBox As TextBox
    Friend WithEvents RemoveCurrentButton As Button
    Friend WithEvents EditCurrentButton As Button
End Class
