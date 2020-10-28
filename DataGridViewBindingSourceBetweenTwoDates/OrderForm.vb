Imports WindowsAppFilterDate.Classes

Public Class OrderForm

    Private ReadOnly _orderBindingSource As New BindingSource
    Private _startDate As Date
    Private _endDate As Date

    Private Sub OrderForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        _orderBindingSource.DataSource = Operations.Read()
        OrderDataGridView.DataSource = _orderBindingSource
        OrdersBindingNavigator.BindingSource = _orderBindingSource
    End Sub
    ''' <summary>
    ''' Invoke date between on OrderDate column
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        FilterOrderDate()
    End Sub
    Private Sub FilterOrderDateToolStripButton_Click(sender As Object, e As EventArgs) Handles FilterOrderDateToolStripButton.Click
        FilterOrderDate()
    End Sub
    ''' <summary>
    ''' Filter by OrderDate
    '''    if one or both TextBox control are empty remove a filter
    '''    else check we have dates for start and end date, apply filter
    ''' </summary>
    Private Sub FilterOrderDate()
        If OrderDateFilterGroupBox.Controls.OfType(Of TextBox).Any(Function(tb) String.IsNullOrWhiteSpace(tb.Text)) Then
            _orderBindingSource.Filter = Nothing
        Else
            If Date.TryParse(StartDateTextBox.Text, _startDate) AndAlso Date.TryParse(EndDateTextBox.Text, _endDate) Then
                _orderBindingSource.Filter = $"OrderDate >= #{_startDate:MM/dd/yyyy}# AND OrderDate <= #{_endDate:MM/dd/yyyy}#"
            End If
        End If
    End Sub

    Private Sub FilterOrderDateClearFilterToolStripButton_Click(sender As Object, e As EventArgs) Handles FilterOrderDateClearFilterToolStripButton.Click
        _orderBindingSource.Filter = Nothing
    End Sub
End Class