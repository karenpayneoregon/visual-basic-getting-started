Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

'
' Comments:
' * Content is a reserve word for SQL-Server so it's aliased 
'
Namespace Models

    <Table("Post")>
    Partial Public Class Post
        Public Property PostId As Integer

        Public Property BlogId As Integer?

        Public Property Title As String
        <Column("Contents")>
        Public Property Content As String

        Public Overridable Property Blog As Blog
    End Class
End Namespace