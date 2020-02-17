Imports System.Runtime.CompilerServices

Public Module DoubleArrayExtensions
    ''' <summary>
    ''' Validate all elements in a string array can be converted to a Double array
    ''' </summary>
    ''' <param name="sender">String Array with at lease one element</param>
    ''' <returns>
    ''' True if all elements are valid Doubles, False is at least one element is not a valid Double
    ''' </returns>
    <Extension>
    Public Function CanConvertToDoubleArray(sender() As String) As Boolean
        Dim testValue As Double
        Return sender.All(Function(input) Double.TryParse(input, testValue))
    End Function
    ''' <summary>
    ''' Convert a Double array to a String array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function DoubleArrayToStringArray(sender() As Double) As String()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Return input.ToString()
                                End Function)
    End Function
    ''' <summary>
    ''' Given a string array assumed to be all Doubles return
    ''' only those elements which are Doubles. If the string
    ''' array had five elements and only two elements could be
    ''' converted the length of the returning array will be a
    ''' length of 2.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToDoubleArray(sender() As String) As Double()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Dim value As Double
                                    Return New With
                                   {
                                       .IsDDouble = Double.TryParse(input, value),
                                       .Value = value
                                   }
                                End Function).
            Where(Function(result) result.IsDDouble).
            Select(Function(result) result.Value).
            ToArray()
    End Function
    ''' <summary>
    ''' Transform a Double array to a Decimal array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    Public Function ToDecimalArray(sender() As Double) As Decimal()
        Return Array.ConvertAll(sender, Function(input) CDec(input))
    End Function
    ''' <summary>
    ''' Given a String array assumed to be all Doubles return
    ''' all elements no matter if they can be converted. Non Double
    ''' values are returned as 0.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToDoublePreserveArray(sender() As String) As Double()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Dim value As Double
                                    Double.TryParse(input, value)
                                    Return value
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
    Public Function GetNonDoubleIndexes(sender() As String) As Integer()
        Return sender.Select(
            Function(item, index)
                Dim integerValue As Double
                Return If(Double.TryParse(item, integerValue),
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