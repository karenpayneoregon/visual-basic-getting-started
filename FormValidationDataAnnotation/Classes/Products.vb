Imports System.ComponentModel.DataAnnotations

Public Class Products
    Public Property ProductID As Integer
    <Required(ErrorMessage:="{0} Required")>
    <StringLength(30, MinimumLength:=3, ErrorMessage:="Invalid {0}")>
    Public Property ProductName As String
    <Required(ErrorMessage:="{0} Required")>
    <Range(1, Decimal.MaxValue, ErrorMessage:="Please enter a value bigger than {1} for {0}")>
    Public Property UnitPrice As Decimal
End Class