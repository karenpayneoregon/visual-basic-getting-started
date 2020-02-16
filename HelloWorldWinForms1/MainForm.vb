Public Class MainForm
    ''' <summary>
    ''' Display a child form for x amount of seconds
    ''' using a NumericUpDown control to get seconds from user
    ''' then use Task.Delay to pause for x seconds followed
    ''' by disposing of the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub ShowHelloFormButton_Click(sender As Object, e As EventArgs) _
        Handles ShowHelloFormButton.Click

        Dim childForm As New HelloForm With {.Opacity = 0}
        childForm.Show()

        '
        ' Since Value property of the NumericUpDown is Delay must
        ' be an Integer Cint is used to convert the Decimal to an Integer
        '
        Await Task.Delay(CInt(NumericUpDown1.Value) * 1000)

        '
        ' Dispose the child form, no need to use the Close method.
        '
        childForm.Dispose()

    End Sub
End Class
