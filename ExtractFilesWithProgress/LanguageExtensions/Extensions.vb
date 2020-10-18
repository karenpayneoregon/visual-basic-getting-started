Namespace LanguageExtensions
    Public Module Extensions
        ''' <summary>
        ''' Return current percent from currentValue of
        ''' totalValue
        ''' </summary>
        ''' <param name="currentValue"></param>
        ''' <param name="totalValue"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function PercentageOf(currentValue As Integer, totalValue As Integer) As Integer
            Return currentValue * 100 \ totalValue
        End Function
        ''' <summary>
        ''' Provides byte abbreviations 
        ''' </summary>
        ''' <param name="bytes"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' array elements in suffix could be changed to uppercase 
        ''' </remarks>
        <Runtime.CompilerServices.Extension>
        Public Function ToEnglishKb(bytes As Long) As String

            Dim suffix() As String = {"b", "kb", "mb", "gb", "tb"}
            Dim byteNumber As Single = bytes

            For index As Integer = 0 To suffix.Length - 1

                If byteNumber < 1000 Then
                    If index = 0 Then
                        Return $"{byteNumber } {suffix(index) }"
                    Else
                        Return $"{byteNumber:0.#0} {suffix(index) }"
                    End If
                Else
                    byteNumber /= 1024
                End If

            Next

            Return $"{byteNumber:N} {suffix(suffix.Length - 1)}"

        End Function

    End Module
End Namespace