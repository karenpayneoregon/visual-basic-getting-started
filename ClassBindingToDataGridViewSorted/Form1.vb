Public Class Form1
    Private peopleBindingList As SortableBindingList(Of Person)
    Private peopleBindingSource As New BindingSource()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        peopleBindingList = New SortableBindingList(Of Person)(Mocked.PeopleList)
        peopleBindingSource.DataSource = peopleBindingList

        dataGridView1.DataSource = peopleBindingSource
        dataGridView1.Columns("id").Visible = False
    End Sub

    Private Sub CurrentPersonButton_Click(sender As Object, e As EventArgs) Handles CurrentPersonButton.Click
        If peopleBindingSource.Current Is Nothing Then
            Return
        End If

        Dim currentPerson = peopleBindingList(peopleBindingSource.Position)
        MessageBox.Show($"{currentPerson.Id}, {currentPerson.FirstName}, {currentPerson.LastName}")
    End Sub

    Private Sub NewPersonButton_Click(sender As Object, e As EventArgs) Handles NewPersonButton.Click

        peopleBindingList.Add(New Person() With
            {
                .Id = peopleBindingList.Select(Function(p) p.Id).Max() + 1,
                .FirstName = "Jude",
                .LastName = "Lennon"
            })

    End Sub
End Class
