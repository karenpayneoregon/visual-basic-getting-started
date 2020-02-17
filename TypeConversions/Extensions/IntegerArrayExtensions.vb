Imports System.Runtime.CompilerServices

Public Module IntegerArrayExtensions
    ''' <summary>
    ''' Validate all elements in a string array can be converted to a Integer array
    ''' </summary>
    ''' <param name="sender">String Array with at lease one element</param>
    ''' <returns>
    ''' True if all elements are valid Integers, False is at least one element is not a valid Integer
    ''' </returns>
    <Extension>
    Public Function CanConvertToIntArray(sender() As String) As Boolean
        Dim testValue As Integer
        Return sender.All(Function(input) Integer.TryParse(input, testValue))
    End Function
    ''' <summary>
    ''' Convert a Integer array to a String array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function IntegerArrayToStringArray(sender() As Integer) As String()
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
    Public Function ToIntegerArray(sender() As String) As Integer()
        Return Array.ConvertAll(sender,
            Function(input)
                Dim value As Integer
                Return New With
               {
                   .IsInteger = Integer.TryParse(input, value),
                   .Value = value
               }
            End Function).
            Where(Function(result) result.IsInteger).
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
    Public Function ToIntegerPreserveArray(sender() As String) As Integer()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Dim integerValue As Integer
                                    Integer.TryParse(input, integerValue)
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
    ''' <remarks>
    ''' Indices are zero based
    ''' </remarks>
    <Extension>
    Public Function GetNonIntegerIndexes(sender() As String) As Integer()
        Return sender.Select(
            Function(item, index)

                Dim integerValue As Integer
                Return If(Integer.TryParse(item, integerValue),
                          New With
                             {
                                 .IsInteger = True,
                                 .Index = index
                             },
                          New With
                             {
                                 .IsInteger = False,
                                 .Index = index
                             }
                          )
            End Function).
            ToArray().
            Where(Function(item) item.IsInteger = False).
            Select(Function(item) item.Index).
            ToArray()

    End Function
End Module