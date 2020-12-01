Imports System.Globalization

Public Module GeneralExtensions

    ''' <summary>
    ''' Convert number to letter
    ''' </summary>
    ''' <param name="pIndex">value 1 or greater</param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Function ExcelColumnNameFromNumber(ByVal pIndex As Integer) As String
        Dim chars = Enumerable.Range(0, 26).Select(
            Function(i)
                Return ChrW(Convert.ToInt32("A"c) + i).ToString()
            End Function).ToArray()

        pIndex -= 1

        Dim columnName As String = Nothing
        Dim quotient = pIndex \ 26

        If quotient > 0 Then
            columnName = ExcelColumnNameFromNumber(quotient) + chars(pIndex Mod 26)
        Else
            columnName = chars(pIndex Mod 26).ToString()
        End If

        Return columnName

    End Function
    ''' <summary>
    ''' Convert string to title case e.g. mary m jones to Mary M Jones
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="cultureIdentifier"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Function ToTitleCase(sender As String, Optional cultureIdentifier As String = "en-US") As String
        Dim textInfo As TextInfo = (New CultureInfo(cultureIdentifier, False)).TextInfo
        Return textInfo.ToTitleCase(sender)

    End Function
End Module
