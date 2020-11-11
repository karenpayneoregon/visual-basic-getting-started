Imports WindowsAppFilterDate.Classes

Public Class OrderFormGrouped
    Private ReadOnly _orderBindingSource As New BindingSource
    Private Sub OrderForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _orderBindingSource.DataSource = Operations.Read(True)
        OrderDataGridView.AutoGenerateColumns = False
        OrderDataGridView.DataSource = _orderBindingSource
    End Sub
End Class