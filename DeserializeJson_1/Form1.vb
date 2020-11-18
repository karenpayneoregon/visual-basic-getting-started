Imports System.IO
'
' NuGet package below
'
Imports System.Text.Json

Public Class Form1
    Private Sub DeserializeButton_Click(sender As Object, e As EventArgs) Handles DeserializeButton.Click
        Dim fileName = "json.json"
        Dim json = File.ReadAllText(fileName)
        Dim results As RecordRoot = JsonSerializer.Deserialize(Of RecordRoot)(json)
    End Sub
End Class
'
' Classes below to be in their own class files.
'
Public Class RecordRoot
    Public Property records As Records
End Class

Public Class Records
    Public Property record() As Record()
End Class

Public Class Record
    Public Property _date As String
    Public Property summary As String
    Public Property issuetype As String
    Public Property team As String
    Public Property priority As String
    Public Property path As String
    Public Property caller As String
    Public Property CIPFA_priority As String
    Public Property person As String
    Public Property details As String
    Public Property allmessages As Allmessages
    Public Property id As String
    Public Property status As String
End Class

Public Class Allmessages
    Public Property messages As Messages
End Class

Public Class Messages
    Public Property message As Message
End Class

Public Class Message
    Public Property msgSubject As String
    Public Property msgTo As String
    Public Property msgFrom As String
    Public Property msgBody As String
    Public Property msgDate As String
End Class

