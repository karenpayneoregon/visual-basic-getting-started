Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If My.Application.HasCommandLineArguments Then
            ListBox1.Items.AddRange(My.Application.CommandLineArguments)
        End If

        If My.Application.AdminMode Then
            Label1.Text = "Admin mode!!!"
        End If
    End Sub
End Class
