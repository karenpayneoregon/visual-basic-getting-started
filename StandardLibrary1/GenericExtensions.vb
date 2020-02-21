Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices

Public Module GenericExtensions
    ''' <summary>
    ''' Specifies the sort direction against a property
    ''' </summary>
    Public Enum SortDirection
        ''' <summary>
        ''' Sort ascending.
        ''' </summary>
        Ascending
        ''' <summary>
        ''' Sort descending.
        ''' </summary>
        Descending
    End Enum
    ''' <summary>
    ''' Generic dynamic sort using string property name
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="propertyName"></param>
    ''' <param name="sortDirection"></param>
    ''' <returns></returns>
    <Extension>
    Public Function Sort(Of T)(list As List(Of T), propertyName As String, sortDirection As SortDirection) As List(Of T)

        Dim param As ParameterExpression = Expression.Parameter(GetType(T), "item")

        Dim sortExpression As Expression(Of Func(Of T, Object)) = Expression.Lambda(Of Func(Of T, Object))(
            Expression.Convert(
                Expression.Property(param, propertyName), GetType(Object)), param)

        Select Case sortDirection
            Case SortDirection.Ascending
                list = list.AsQueryable().OrderBy(sortExpression).ToList()
            Case Else
                list = list.AsQueryable().OrderByDescending(sortExpression).ToList()
        End Select

        Return list

    End Function
    ''' <summary>
    ''' Determine if T is between lower and upper
    ''' </summary>
    ''' <typeparam name="T">Data type</typeparam>
    ''' <param name="actual">Value to determine if between lower and upper</param>
    ''' <param name="lower">Lower of range</param>
    ''' <param name="upper">Upper of range</param>
    ''' <returns>True if in range, false if not in range</returns>
    ''' <example>
    ''' <code>
    ''' var startDate = new DateTime(2018, 12, 2, 1, 12, 0);
    ''' var endDate = new DateTime(2018, 12, 15, 1, 12, 0);
    ''' var theDate = new DateTime(2018, 12, 13, 1, 12, 0);
    ''' Assert.IsTrue(theDate.Between(startDate,endDate));
    ''' </code>
    ''' </example>
    ''' <remarks>
    ''' To have upper inclusive use <= else <
    ''' </remarks>
    <Extension>
    Public Function Between(Of T As IComparable(Of T))(actual As T, lower As T, upper As T) As Boolean
        Return actual.CompareTo(lower) >= 0 AndAlso actual.CompareTo(upper) <= 0
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="source"></param>
    ''' <param name="chunkSize"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ChunkBy(Of T)(source As List(Of T), chunkSize As Integer) As List(Of List(Of T))
        Return source.Select(
            Function(value, index)
                Return New With {
                        Key .Index = index,
                        Key .Value = value}
            End Function).
            GroupBy(Function(item) item.Index \ chunkSize).
            Select(Function(grp) grp.Select(Function(v) v.Value).ToList()).
            ToList()
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToNullable(Of T As Structure)(sender As String) As T?

        Dim result As New T?()

        Try
            If Not String.IsNullOrWhiteSpace(sender) Then
                Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(T))
                result = CType(converter.ConvertFrom(sender), T)

            End If
        Catch
            ' don't care, caller should use HasValue before accessing the value.
        End Try

        Return result

    End Function
End Module

