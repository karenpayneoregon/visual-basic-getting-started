Public Class frmLeech
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub
    Private Sub frmLeech_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If DataGridView1.DataSource Is Nothing Then
            CType(Owner, frmMainForm).ShowDetailsForCurrentMaster()
        End If
    End Sub
End Class