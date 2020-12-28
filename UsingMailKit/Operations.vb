Imports System.IO
Imports MailKit
Imports MailKit.Security
Imports MimeKit
Imports MimeKit.Utils

Public Class Operations
    Public Shared Async Sub Example1()
        Dim message = New MimeMessage()

        message.From.Add(New MailboxAddress("Joey", "joey@friends.com"))
        message.To.Add(New MailboxAddress("Alice", "alice@wonderland.com"))

        message.Subject = "Hello friend"

        Dim builder = New BodyBuilder()
        Dim image = builder.LinkedResources.Add("C:\Users\Joey\Documents\Selfies\selfie.jpg")

        image.ContentId = MimeUtils.GenerateMessageId()
        Dim files = Directory.GetFiles("c:\SomeFolder").ToList()
        For Each file As String In files
            builder.Attachments.Add(file)
        Next


        builder.HtmlBody =
            $"<p>Hey Alice,<br>
<p>What are you up to this weekend? Monica is throwing one of her parties on
Saturday and I was hoping you could make it.<br>
<p>Will you be my +1?<br>
<p>-- Joey<br>
<center><img src=""cid:{image.ContentId}""></center>"
        builder.Attachments.Add("C:\Users\Joey\Documents\party.ics")

        message.Body = builder.ToMessageBody()

        Using smtp = New Net.Smtp.SmtpClient()

            AddHandler smtp.MessageSent, AddressOf MessageSent

            Await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.SslOnConnect)

            Await smtp.AuthenticateAsync("Username", "Password")
            Await smtp.SendAsync(message)
            Await smtp.DisconnectAsync(True)

        End Using

    End Sub

    Private Shared Sub MessageSent(sender As Object, e As MessageSentEventArgs)
        Console.WriteLine(e.Response)
    End Sub
End Class
Public Class EmailAddress
    Public Property Name() As String
    Public Property Address() As String
End Class
Public Class EmailMessage
    Public Sub New()
        ToAddresses = New List(Of EmailAddress)()
        FromAddresses = New List(Of EmailAddress)()
    End Sub

    Public Property ToAddresses() As List(Of EmailAddress)
    Public Property FromAddresses() As List(Of EmailAddress)
    Public Property Subject() As String
    Public Property Content() As String
    Public Property Attachments() As AttachmentCollection
End Class


