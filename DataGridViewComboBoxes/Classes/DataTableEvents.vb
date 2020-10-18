Namespace Classes
    ''' <summary>
    ''' Add DataTable events for Customers DataTable, there
    ''' are no DataTable events in other classes.
    '''
    ''' Events are subscribed too in Operations Customers function called
    ''' by the main form.
    ''' </summary>
    Public Class DataTableEvents

        ''' <summary>
        ''' Notification a customer record has been deleted
        ''' </summary>
        ''' <param name="sender">Customer id</param>
        Public Delegate Sub CustomerDeleted(sender As Integer)
        Public Shared Event CustomerDeletedHandler As CustomerDeleted

        ''' <summary>
        ''' Notification for a Customer row being partially or fully updated
        ''' which in turn broadcast and picked up by Operations class.
        ''' </summary>
        ''' <param name="sender">Customer DataRow</param>
        Public Delegate Sub CustomerUpdate(sender As DataRow)
        Public Shared Event CustomerUpdateHandler As CustomerUpdate
        ''' <summary>
        ''' Provide access to changes for the current DataRow after in this
        ''' case leaving a cell in a DataGridView.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Public Shared Sub ColumnChanged(sender As Object, e As DataColumnChangeEventArgs)

            If e.Row.RowState = DataRowState.Deleted OrElse e.Row.RowState = DataRowState.Detached Then
                Return
            End If

            If e.Row.Table.Columns.Contains("CustomerIdentifier") Then
                Console.WriteLine($"                Id {e.Row.Field(Of Integer)("CustomerIdentifier")}")
            End If

            Console.WriteLine($"       Column name {e.Column.ColumnName}")
            Console.WriteLine($"    Original value [{e.Row(e.Column.ColumnName, DataRowVersion.Original)}]")
            Console.WriteLine($"    Propose value [{e.ProposedValue}]")
            Console.WriteLine($"        Row state [{e.Row.RowState}]")

            Console.WriteLine(New String("-"c, 20))

            RaiseEvent CustomerUpdateHandler(e.Row)

        End Sub
        ''' <summary>
        ''' Provides access to process a just deleted record, in this case
        ''' CustomerDeleted in Operations class
        ''' </summary>
        ''' <param name="sender">Current DataTable</param>
        ''' <param name="args">DataRowChangeEventArgs</param>
        Public Shared Sub Deleted(sender As Object, args As DataRowChangeEventArgs)
            RaiseEvent CustomerDeletedHandler(CInt(args.Row("CustomerIdentifier", DataRowVersion.Original)))
        End Sub
    End Class
End Namespace