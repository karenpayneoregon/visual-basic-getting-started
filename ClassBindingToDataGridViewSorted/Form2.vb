Imports System.Reflection
Public Class Form2
    Private peopleBindingSource As New BindingSource()
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim person = New Person() With {.Id = 1, .FirstName = "Karen", .LastName = "Payne"}

        peopleBindingSource.DataSource = New List(Of Person) From {person}

        Dim properties = GetType(Person).
                GetProperties().
                Where(
                    Function(propertyInfo)
                        Return propertyInfo.PropertyType IsNot GetType(Integer)
                    End Function)

        For Each propertyInfo As PropertyInfo In properties
            DataGridView1.Rows.Add(propertyInfo.Name,
                                   propertyInfo.GetValue(person),
                                   propertyInfo.Name)
        Next

        AddHandler DataGridView1.CellValueChanged, AddressOf CellChanged
    End Sub
    Private Sub CellChanged(sender As Object, e As DataGridViewCellEventArgs)
        Dim item = CType(peopleBindingSource.Current, Person)

        If e.RowIndex Mod 2 = 0 Then
            item.FirstName = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        Else
            item.LastName = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If

    End Sub
    Private Sub PersonValues_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim person = CType(peopleBindingSource.Current, Person)

        MessageBox.Show($"{person.FirstName} {person.LastName}")

    End Sub
End Class