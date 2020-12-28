Public Module CommonDialogs
    Public Function Question(text As String) As Boolean
        Return (MessageBox.Show(text, "Question",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) = DialogResult.Yes)
    End Function
    Public Function Question(text As String, title As String) As Boolean
        Return (MessageBox.Show(text, title,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) = DialogResult.Yes)
    End Function
End Module
