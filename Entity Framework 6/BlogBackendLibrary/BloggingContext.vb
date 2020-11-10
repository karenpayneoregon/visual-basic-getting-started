Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports BlogBackendLibrary.Models

Partial Public Class BloggingContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=BloggingConnectionString")
    End Sub

    Public Overridable Property Blogs As DbSet(Of Blog)
    Public Overridable Property Posts As DbSet(Of Post)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
    End Sub
End Class
