Namespace Forms
    Public Class Form1
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            SplashScreen1.SetMax(100)
            Dim currentIndex As Integer = 0
            While currentIndex <= 100
                SplashScreen1.UpdateProgressBar(currentIndex)
                currentIndex += 1
                Threading.Thread.Sleep(50)
            End While
        End Sub
    End Class
End Namespace