Imports System.Windows.Forms

Namespace LanguageExtensions
    Public Module BindingSourceExtensions
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function DataTable(sender As BindingSource) As DataTable
            Return DirectCast(sender.DataSource, DataTable)
        End Function
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function DataView(sender As BindingSource) As DataView
            Return DirectCast(sender.List, DataView)
        End Function
        ''' <summary>
        ''' Return a column value as a string
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="column"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function CurrentRow(sender As BindingSource, column As String) As String
            Return DirectCast(sender.Current, DataRowView).Row(column).ToString
        End Function
        ''' <summary>
        ''' Accepts changes to the current row
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <remarks></remarks>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Sub SaveCurrentRow(sender As BindingSource)
            DirectCast(sender.Current, DataRowView).Row.AcceptChanges()
        End Sub
        ''' <summary>
        ''' Primary key for Customers
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function CurrentCustomerIdentifier(sender As BindingSource) As String
            Return sender.CurrentRow(CustomerIdentifier)
        End Function
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function CurrentCustomerName(sender As BindingSource) As String
            Return sender.CurrentRow("CompanyName")
        End Function
        ''' <summary>
        ''' Primary key for Orders
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function CurrentOrderIdentifier(sender As BindingSource) As String
            Return sender.CurrentRow(OrderIdentifier)
        End Function
        ''' <summary>
        ''' An example of going out of one's way because they do not take
        ''' time to understand their data.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="Identifier"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Absolutely no reason for this, see comments in it's usage
        ''' in MainformLoadData.vb
        ''' </remarks>
        <DebuggerStepThrough()>
        <Runtime.CompilerServices.Extension()>
        Public Function OrderDetailsTotalRows(sender As BindingSource, Identifier As String) As Int32
            Return _
                (
                    From row In
                        DirectCast(DirectCast(sender.DataSource, BindingSource).DataSource, DataSet).Tables("Orders").AsEnumerable
                    Where row.Field(Of String)(CustomerIdentifier) = Identifier
                    ).Count
        End Function
    End Module
End Namespace