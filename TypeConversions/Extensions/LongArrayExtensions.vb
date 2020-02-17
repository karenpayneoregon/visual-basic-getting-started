Imports System.Runtime.CompilerServices

Public Module LongArrayExtensions
    ''' <summary>
    ''' Validate all elements in a string array can be converted to a Integer array
    ''' </summary>
    ''' <param name="sender">String Array with at lease one element</param>
    ''' <returns>
    ''' True if all elements are valid Integers, False is at least one element is not a valid Integer
    ''' </returns>
    <Extension>
    Public Function CanConvertToLongArray(sender() As String) As Boolean
        Dim testValue As Long
        Return sender.All(Function(input) Long.TryParse(input, testValue))
    End Function
    ''' <summary>
    ''' Convert a Integer array to a String array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function LongArrayToStringArray(sender() As Long) As String()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Return input.ToString()
                                End Function)
    End Function
    ''' <summary>
    ''' Given a string array assumed to be all integers return
    ''' only those elements which are integers. If the string
    ''' array had five elements and only two elements could be
    ''' converted the length of the returning array will be a
    ''' length of 2.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToLongArray(sender() As String) As Long()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Dim value As Long
                                    Return New With
                                   {
                                       .IsLong = Long.TryParse(input, value),
                                       .Value = value
                                   }
                                End Function).
            Where(Function(result) result.IsLong).
            Select(Function(result) result.Value).
            ToArray()
    End Function
    ''' <summary>
    ''' Given a string array assumed to be all integers return
    ''' all elements no matter if they can be converted. Non integer
    ''' values are returned as 0.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToLongPreserveArray(sender() As String) As Long()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Dim integerValue As Long
                                    Long.TryParse(input, integerValue)
                                    Return integerValue
                                End Function)
    End Function
    ''' <summary>
    ''' Given a string array to be converted to a integer array
    ''' see if there are elements that are not convertible to integer
    ''' and return their index in the string array.
    ''' </summary>
    ''' <param name="sender">String array</param>
    ''' <returns>If non integer elements found return their index in the string array</returns>
    <Extension>
    Public Function GetNonLongIndexes(sender() As String) As Integer()
        Return sender.Select(
            Function(item, index)

                Dim integerValue As Long
                Return If(Long.TryParse(item, integerValue),
                          New With
                             {
                                 .IsLong = True,
                                 .Index = index
                             },
                          New With
                             {
                                 .IsLong = False,
                                 .Index = index
                             }
                          )
            End Function).
            ToArray().
            Where(Function(item) item.IsLong = False).
            Select(Function(item) item.Index).
            ToArray()

    End Function
End Module