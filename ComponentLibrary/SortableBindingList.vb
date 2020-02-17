Imports System.ComponentModel
Imports System.Reflection
Public Class SortableBindingList(Of T)
    Inherits BindingList(Of T)
    Private Property IsSorted As Boolean
    Private Property SortDirection As ListSortDirection
    Private Property SortProperty As PropertyDescriptor
    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property
    Protected Overrides ReadOnly Property SortDirectionCore() As ListSortDirection
        Get
            Return _SortDirection
        End Get
    End Property
    Protected Overloads Overrides ReadOnly Property SortPropertyCore() As PropertyDescriptor
        Get
            Return _SortProperty
        End Get
    End Property
    Protected Overloads Overrides Sub ApplySortCore(Descriptor As PropertyDescriptor, Direction As ListSortDirection)

        Dim items = TryCast(Me.Items, List(Of T))

        If items Is Nothing Then
            IsSorted = False
        Else
            Dim pCom As New PCompare(Of T)(Descriptor.Name, Direction)
            items.Sort(pCom)
            IsSorted = True
            SortDirection = Direction
            SortProperty = Descriptor
        End If

        OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))

    End Sub
    Protected Overloads Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return _IsSorted
        End Get
    End Property
    Protected Overrides Sub RemoveSortCore()
        _IsSorted = False
    End Sub
#Region " Constructors "
    Sub New(ByVal list As ICollection(Of T))
        MyBase.New(CType(list, IList(Of T)))
    End Sub
    Sub New()
        MyBase.New()
    End Sub
#End Region
#Region " Property comparer "
    Private Class PCompare(Of T)
        Implements IComparer(Of T)
        Private Property PropInfo As PropertyInfo
        Private Property SortDir As ListSortDirection
        Friend Sub New(sortProperty As String, sortDirection As ListSortDirection)
            PropInfo = GetType(T).GetProperty(sortProperty)
            SortDir = sortDirection
        End Sub
        Friend Function Compare(value1 As T, value2 As T) As Integer Implements IComparer(Of T).Compare

            Return If(SortDir = ListSortDirection.Ascending,
                      Comparer.[Default].Compare(PropInfo.GetValue(value1, Nothing),
                                                 PropInfo.GetValue(value2, Nothing)),
                      Comparer.[Default].Compare(PropInfo.GetValue(value2, Nothing),
                                                 PropInfo.GetValue(value1, Nothing)))

        End Function
    End Class
#End Region

End Class
