Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices

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
Public Enum SortOrderEnum
    ''' <summary>
    ''' The returned list will be ordered in ascending order
    ''' </summary>
    Ascending
    ''' <summary>
    ''' The returned list will lbe ordered in descending order
    ''' </summary>
    Descending
End Enum

Public Module GenericSorterExtension
    <Extension>
    Public Function Sort(Of T)(list As List(Of T), propertyName As String, sortDirection As SortDirection) As List(Of T)

        Dim param = Expression.Parameter(GetType(T), "item")
        Dim sortExpression = Expression.Lambda(Of Func(Of T, Object))(Expression.Convert(Expression.Property(param, propertyName), GetType(Object)), param)

        Select Case sortDirection
            Case SortDirection.Ascending
                list = list.AsQueryable().OrderBy(sortExpression).ToList()
            Case Else
                list = list.AsQueryable().OrderByDescending(sortExpression).ToList()
        End Select

        Return list

    End Function
    <Extension>
    Public Function Order(Of T)(source As IQueryable(Of T), ByVal propertyNames() As String, ByVal sortOrder As SortOrderEnum) As IOrderedQueryable(Of T)

        If propertyNames.Length = 0 Then
            Throw New InvalidOperationException()
        End If

        Dim param = Expression.Parameter(GetType(T), String.Empty)
        Dim memberExpressions As MemberExpression = Expression.PropertyOrField(param, propertyNames(0))
        Dim lambdaSorted As LambdaExpression = Expression.Lambda(memberExpressions, param)

        Dim orderByCall As MethodCallExpression =
                Expression.Call(GetType(Queryable), "OrderBy" & ((If(sortOrder = SortOrderEnum.Descending, "Descending", String.Empty))),
                                {GetType(T), memberExpressions.Type}, source.Expression, Expression.Quote(lambdaSorted))

        If propertyNames.Length > 1 Then
            For index As Integer = 1 To propertyNames.Length - 1

                Dim item = propertyNames(index)

                param = Expression.Parameter(GetType(T), String.Empty)
                memberExpressions = Expression.PropertyOrField(param, item)

                lambdaSorted = Expression.Lambda(memberExpressions, param)

                orderByCall =
                    Expression.Call(GetType(Queryable), "ThenBy" & ((If(sortOrder = SortOrderEnum.Descending, "Descending", String.Empty))),
                                    {GetType(T), memberExpressions.Type}, orderByCall, Expression.Quote(lambdaSorted))

            Next index
        End If


        Return CType(source.Provider.CreateQuery(Of T)(orderByCall), IOrderedQueryable(Of T))

    End Function

    <Extension>
    Public Function Sort1(Of T)(list As List(Of T), sortBySortDirection As String) As List(Of T)
        Dim sortProperties() As String = sortBySortDirection.Split(" "c)

        Dim param = Expression.Parameter(GetType(T), "item")

        Dim sortExpression = Expression.Lambda(Of Func(Of T, Object))(Expression.Convert(Expression.Property(param, sortProperties(0)), GetType(Object)), param)

        Select Case sortProperties(1).ToLower()
            Case "asc"
                list = list.AsQueryable().OrderBy(sortExpression).ToList()
            Case Else
                list = list.AsQueryable().OrderByDescending(sortExpression).ToList()
        End Select

        Return list

    End Function
    ''' <summary>
    ''' Sort by property name
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="propertyName">Property name to sort by</param>
    ''' <param name="ascending">true for ascending, false descending</param>
    ''' <returns></returns>
    <Extension>
    Public Function Sort1(Of T)(list As List(Of T), propertyName As String, ascending As Boolean) As List(Of T)

        Dim param = Expression.Parameter(GetType(T), "item")

        Dim sortExpression = Expression.Lambda(Of Func(Of T, Object))(Expression.Convert(Expression.Property(param, propertyName), GetType(Object)), param)

        list = If(ascending, list.AsQueryable().OrderBy(sortExpression).ToList(), list.AsQueryable().OrderByDescending(sortExpression).ToList())

        Return list

    End Function
End Module