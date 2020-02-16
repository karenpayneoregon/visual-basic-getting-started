Imports System.Drawing.Drawing2D

Public Class HelloForm
    Private Sub HelloForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '
        ' Show current time with "Hello World" text using custom date format
        '
        Label1.Text = $"Hello World at {Now:hh:mm tt}"

        '
        ' Center this form on it's parent, the calling form
        '
        CenterToParent()

        '
        ' Prevents flicking from form being shown
        '
        Opacity = 100

    End Sub
    ''' <summary>
    ''' Paint a gradient Background
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        Using brush As New LinearGradientBrush(ClientRectangle, Color.White, Color.Cornsilk, 70.0F)
            e.Graphics.FillRectangle(brush, ClientRectangle)
        End Using
    End Sub
End Class