Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Namespace Models

    <Table("Blog")>
    Partial Public Class Blog
        Public Sub New()
            Posts = New HashSet(Of Post)()
        End Sub

        Public Property BlogId As Integer

        Public Property Url As String

        Public Overridable Property Posts As ICollection(Of Post)
    End Class
End Namespace