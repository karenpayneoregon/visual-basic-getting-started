Imports BlogBackendLibrary
Imports BlogBackendLibrary.Classes
Imports BlogBackendLibrary.Models

Public Class Form1
    Private ReadOnly _context As BloggingContext = New BloggingContext()
    ''' <summary>
    '''Keep track of selected ListView index
    ''' </summary>
    Private _blogListViewSelectedIndex As Integer = 0

    ''' <summary>
    ''' Populate ListView with a blogs in groups
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        PopulateAllBlogsTab()
    End Sub
    ''' <summary>
    ''' Load blogs and post into ListView
    ''' </summary>
    Private Sub PopulateAllBlogsTab()

        BlogListView.BeginUpdate()

        Try
            '
            ' Clear to refresh rather than appending
            ' which may result in duplicates.
            '
            BlogListView.Items.Clear()

            Dim index As Integer = 0
            Dim groupName As String = ""

            Dim blogs = _context.Blogs.ToList()
            For Each blog As Blog In blogs

                index += 1
                groupName = $"Group{index}"

                Dim currentGroup = New ListViewGroup(blog.BlogId.ToString(),
                    HorizontalAlignment.Left) With {
                        .Header = blog.Url,
                        .Name = groupName
                    }


                For Each post As Post In blog.Posts

                    Dim listViewBlogItem = New ListViewItem(
                    {
                        post.Title,
                        post.Content
                    }, -1)

                    listViewBlogItem.Group = currentGroup

                    listViewBlogItem.Tag = New PostTag With {
                            .BlogId = blog.BlogId,
                            .PostId = post.PostId
                        }

                    BlogListView.Items.Add(listViewBlogItem)

                Next

                BlogListView.Groups.Add(currentGroup)

            Next



            BlogListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Finally
            BlogListView.EndUpdate()
        End Try

        If BlogListView.Items.Count > 0 Then

            BlogListView.FocusedItem = BlogListView.Items(0)
            BlogListView.Items(0).Selected = True
            ActiveControl = BlogListView

        End If

    End Sub
    ''' <summary>
    ''' Provides a refresh which can assist if data has
    ''' been added outside of this project at runtime.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub PopulateFirstTabButton_Click(sender As Object, e As EventArgs) _
        Handles PopulateFirstTabButton.Click

        PopulateAllBlogsTab()

    End Sub
    ''' <summary>
    ''' Using the strong typed Tag get primary keys for blog and post
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CurrentPostButton_Click(sender As Object, e As EventArgs) _
        Handles CurrentPostButton.Click

        If BlogListView.SelectedItems.Count > 0 Then

            Dim postTag = CType(BlogListView.SelectedItems(0).Tag, PostTag)
            MessageBox.Show($"Blog id: {postTag.BlogId}, Post id: {postTag.PostId}")

        Else
            MessageBox.Show("Select a post")
        End If

        ActiveControl = BlogListView

    End Sub
    ''' <summary>
    ''' Setup TextBox for editing current blog url
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BlogListView_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles BlogListView.SelectedIndexChanged

        If BlogListView.SelectedItems.Count > 0 Then

            _blogListViewSelectedIndex = BlogListView.Items.IndexOf(BlogListView.SelectedItems(0))

            Dim postTag = CType(BlogListView.SelectedItems(0).Tag, PostTag)
            Dim blog As Blog = _context.Blogs.Find(postTag.BlogId)

            CurrentUrlTextBox.Tag = postTag
            CurrentUrlTextBox.Text = blog.Url

            Dim post = _context.Posts.Find(postTag.PostId)

            CurrentPostTitleTextBox.Tag = postTag
            CurrentPostTitleTextBox.Text = post.Title
            CurrentPostContentTextBox.Text = post.Content

        End If

    End Sub
    ''' <summary>
    ''' Update current blog url
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdateUrlButton_Click(sender As Object, e As EventArgs) _
        Handles UpdateUrlButton.Click

        Dim blog As Blog = _context.Blogs.Find(CType(CurrentUrlTextBox.Tag, PostTag).BlogId)
        blog.Url = CurrentUrlTextBox.Text

        '
        ' Update database - note there is no assertion of empty value
        '
        _context.SaveChanges()

        '
        ' Update ListView
        '
        BlogListView.SelectedItems(0).Group.Header = CurrentUrlTextBox.Text

    End Sub
    ''' <summary>
    ''' Update current selected post in ListView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub UpdatePostButton_Click(sender As Object, e As EventArgs) _
        Handles UpdatePostButton.Click

        Dim postTag As PostTag = CType(CurrentPostTitleTextBox.Tag, PostTag)
        Dim post As Post = _context.Posts.Find(postTag.PostId)

        post.Title = CurrentPostTitleTextBox.Text
        post.Content = CurrentPostContentTextBox.Text

        _context.SaveChanges()

        Dim listViewItem As ListViewItem = BlogListView.Items(_blogListViewSelectedIndex)

        listViewItem.SubItems(0).Text = CurrentPostTitleTextBox.Text
        listViewItem.SubItems(1).Text = CurrentPostContentTextBox.Text

    End Sub
    ''' <summary>
    ''' Add a new blog with one post. Note the assertion on
    ''' TextBox controls can also be done with data annotations markup
    ''' on properties of the Blog and Post properties coupled with
    ''' validators found in the following GitHub repo
    ''' https://github.com/karenpayneoregon/ef-track-added-modified-vb/tree/master/Validators
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddNewBlogSinglePostButton_Click(sender As Object, e As EventArgs) _
        Handles AddNewBlogSinglePostButton.Click

        If String.IsNullOrWhiteSpace(NewBlogUrlTextBox.Text) Then

            MessageBox.Show("Requires a Url")
            Exit Sub

        End If

        If String.IsNullOrWhiteSpace(FirstPostTitleTextBox.Text) OrElse
           String.IsNullOrWhiteSpace(FirstPostContentTextBox.Text) Then

            MessageBox.Show("Requires title and content")

            Exit Sub

        End If


        Dim blog As New Blog With {
                    .Url = NewBlogUrlTextBox.Text
                }

        Dim post As New Post With {
                    .Title = FirstPostTitleTextBox.Text,
                    .Content = FirstPostContentTextBox.Text
                }

        blog.Posts.Add(post)
        _context.Blogs.Add(blog)

        _context.SaveChanges()

        '
        ' Read all blogs back into ListView
        ' (another approach is to add a new group and post)
        '
        PopulateAllBlogsTab()

    End Sub
    ''' <summary>
    ''' Remove current blog and all post for the current
    ''' blog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RemoveCurrentButton_Click(sender As Object, e As EventArgs) _
        Handles RemoveCurrentButton.Click

        If BlogListView.SelectedItems.Count > 0 Then
            If Not My.Dialogs.Question("Remove current blog and all post?") Then
                Exit Sub
            End If

            _blogListViewSelectedIndex = BlogListView.Items.IndexOf(BlogListView.SelectedItems(0))

            Dim postTag = CType(BlogListView.SelectedItems(0).Tag, PostTag)
            Dim blog As Blog = _context.Blogs.Find(postTag.BlogId)

            '
            ' Get all post for current blog
            '
            Dim postList = _context.Posts.
                    Where(Function(post) post.BlogId.Value = postTag.BlogId).ToList()

            '
            ' Mark for hard delete
            '
            _context.Blogs.Remove(blog)
            '
            ' Mark all post for hard delete
            '
            _context.Posts.RemoveRange(postList)

            _context.SaveChanges()

            '
            ' Read all blogs back into ListView
            ' (another approach is to add a new group and post)
            '
            PopulateAllBlogsTab()

        End If

    End Sub
    ''' <summary>
    ''' Change from main tab to edit table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditCurrentButton_Click(sender As Object, e As EventArgs) Handles EditCurrentButton.Click
        TabControl1.SelectedTab = EditCurrentTabPage
    End Sub
End Class
