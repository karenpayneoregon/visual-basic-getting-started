Imports System.Runtime.CompilerServices
Imports System.Text

Module StringExtensions
    <Extension>
    Public Function ReduceWhitespace(ByVal value As String) As String
        Dim newString = New StringBuilder()
        Dim previousIsWhitespace As Boolean = False
        For index As Integer = 0 To value.Length - 1
            If Char.IsWhiteSpace(value.Chars(index)) Then
                If previousIsWhitespace Then
                    Continue For
                End If

                previousIsWhitespace = True
            Else
                previousIsWhitespace = False
            End If

            newString.Append(value.Chars(index))
        Next

        Return newString.ToString()
    End Function

End Module
