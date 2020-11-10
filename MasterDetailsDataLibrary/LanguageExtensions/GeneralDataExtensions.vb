Imports System.Windows.Forms

Public Module GeneralDataExtensions
    <Runtime.CompilerServices.Extension>
    Public Function ParentRow(pSender As Object, pRelationshipName As String) As DataRow 'where pSender : BindingSource
        If TypeOf pSender Is BindingSource Then

            Dim bs = CType(pSender, BindingSource)

            If bs.Current Is Nothing Then
                Return Nothing
            Else
                Return CType(bs.Current, DataRowView).Row.GetParentRow(pRelationshipName)
            End If
        Else
            Throw New Exception("Must be a BindingSource")
        End If

    End Function
End Module
