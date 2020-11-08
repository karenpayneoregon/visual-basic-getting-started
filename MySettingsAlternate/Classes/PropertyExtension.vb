Imports System.Reflection

Namespace Classes
    Public Module PropertyExtension

        <Runtime.CompilerServices.Extension>
        Public Sub SetPropertyValue(pObject As Object, pPropertyName As String, value As Object)
            Dim propertyInfo As PropertyInfo = pObject.GetType().GetProperty(pPropertyName)
            Dim t As Type = If(Nullable.GetUnderlyingType(propertyInfo.PropertyType), propertyInfo.PropertyType)
            Dim safeValue As Object = If(value Is Nothing, Nothing, Convert.ChangeType(value, t))

            propertyInfo.SetValue(pObject, safeValue, Nothing)
        End Sub
    End Module
End NameSpace