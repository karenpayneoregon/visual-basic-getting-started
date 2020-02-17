Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Module GenericExtensions
    ''' <summary>
    ''' Converts a string to a Nullable type as per T
    ''' </summary>
    ''' <typeparam name="T">Type to convert too</typeparam>
    ''' <param name="sender">String to work from</param>
    ''' <returns>Nullable of T</returns>
    ''' <example>
    ''' <code>
    ''' Dim value = "12".ToNullable(Of Integer)
    ''' If value.HasValue Then
    '''   - use value
    ''' Else
    '''   - do not use value
    ''' </code>
    ''' </example>
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
