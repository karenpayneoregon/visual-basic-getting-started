Imports System.Reflection

Namespace Classes
    Public Module ConverterHelpers
        Public Function ConvertDataTable(Of T)(dt As DataTable) As List(Of T)
            Dim data As New List(Of T)()
            For Each row As DataRow In dt.Rows
                Dim item As T = GetItem(Of T)(row)
                data.Add(item)
            Next

            Return data

        End Function
        Public Function GetItem(Of T)(dr As DataRow) As T
            Dim tempType As Type = GetType(T)
            Dim obj As T = Activator.CreateInstance(Of T)()

            For Each dataColumn As DataColumn In dr.Table.Columns
                For Each pro As PropertyInfo In tempType.GetProperties()
                    If pro.Name = dataColumn.ColumnName Then
                        pro.SetValue(obj, dr(dataColumn.ColumnName), Nothing)
                    Else
                        Continue For
                    End If
                Next pro
            Next

            Return obj

        End Function

    End Module
End Namespace