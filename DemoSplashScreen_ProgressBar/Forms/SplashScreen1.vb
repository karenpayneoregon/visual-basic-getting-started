Namespace Forms
    Public Class SplashScreen1
        Public Delegate Sub SetProgressBarDelegate(max As Integer)
        Public Delegate Sub UpdateProgressBarDelegate(value As Integer)
        ''' <summary>
        ''' Set 100% value
        ''' </summary>
        ''' <param name="maxValue"></param>
        ''' <remarks></remarks>
        Public Sub SetMax(maxValue As Integer)
            If InvokeRequired Then
                Invoke(New SetProgressBarDelegate(AddressOf SetMax), maxValue)
            Else
                ProgressBar1.Maximum = maxValue
            End If
        End Sub
        Public Sub UpdateProgressBar(currentProgress As Integer)

            If InvokeRequired Then
                Invoke(New UpdateProgressBarDelegate(AddressOf UpdateProgressBar), currentProgress)
            Else
                ProgressBar1.Value = currentProgress
                Label1.Text = currentProgress.ToString & "% complete"
            End If
        End Sub
        Private Const CP_NOCLOSE_BUTTON As Integer = &H200
        Protected Overrides ReadOnly Property CreateParams() As CreateParams
            Get
                Dim myCp As CreateParams = MyBase.CreateParams
                myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
                Return myCp
            End Get
        End Property
    End Class
End Namespace