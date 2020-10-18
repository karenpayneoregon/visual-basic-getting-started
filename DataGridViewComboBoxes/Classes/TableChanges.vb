Namespace Classes
    ''' <summary> 
    ''' Used for the language extension method AllChanges above 
    ''' </summary> 
    Public Class TableChanges
        ''' <summary> 
        ''' Indicates the DataTable has one or more deleted rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property HasDeleted() As Boolean
        ''' <summary> 
        ''' DataTable contains all deleted rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property Deleted() As DataTable
        Private _deletedPrimaryKeys As New List(Of Integer)()
        Public Property DeletedPrimaryKeys() As List(Of Integer)
            Get
                Return _deletedPrimaryKeys
            End Get
            Set(ByVal value As List(Of Integer))
                _deletedPrimaryKeys = value
            End Set
        End Property
        ''' <summary> 
        ''' Indicates the DataTable has one ore more modified rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property HasModified() As Boolean
        ''' <summary> 
        ''' DataTable contains all modified rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property Modified() As DataTable
        ''' <summary> 
        ''' Indicates the DataTable has one or more new rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property HasNew() As Boolean
        ''' <summary> 
        ''' DataTable containing new rows 
        ''' </summary> 
        ''' <returns></returns> 
        ''' <remarks>Will not have the new primary key</remarks> 
        Public Property Added() As DataTable
        ''' <summary> 
        ''' Indicates if there are any unchanged rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property HasUnchanged() As Boolean
        ''' <summary> 
        ''' DataTable containing unchanged rows 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property UnChanged() As DataTable
        ''' <summary> 
        ''' Indicates there were one or more changes to the DataTable excluding unchanged 
        ''' </summary> 
        ''' <returns></returns> 
        Public Property Any() As Boolean
    End Class
End Namespace