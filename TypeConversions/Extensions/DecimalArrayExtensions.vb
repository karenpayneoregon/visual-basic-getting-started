Imports System.Runtime.CompilerServices

Public Module DecimalArrayExtensions
    ''' <summary>
    ''' Validate all elements in a string array can be converted to a Decimal array
    ''' </summary>
    ''' <param name="sender">String Array with at lease one element</param>
    ''' <returns>
    ''' True if all elements are valid Integers, False is at least one element is not a valid Decimal
    ''' </returns>
    <Extension>
    Public Function CanConvertToDecimalArray(sender() As String) As Boolean
        Dim testValue As Decimal
        Return sender.All(Function(input) Decimal.TryParse(input, testValue))
    End Function
    ''' <summary>
    ''' Convert a Decimal array to a String array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function DecimalArrayToStringArray(sender() As Decimal) As String()
        Return Array.ConvertAll(sender,
            Function(input)
                Return input.ToString()
            End Function)
    End Function
    ''' <summary>
    ''' Given a string array assumed to be all Decimals return
    ''' only those elements which are Decimals. If the string
    ''' array had five elements and only two elements could be
    ''' converted the length of the returning array will be a
    ''' length of 2.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToDecimalArray(sender() As String) As Decimal()
        Dim resultArray = Array.ConvertAll(sender,
               Function(input)
                   Dim value As Decimal
                   Return New With
                  {
                  .IsDecimal = Decimal.TryParse(input, value),
                  .Value = value
                  }
               End Function).
               Where(Function(result) result.IsDecimal).
               Select(Function(result) result.Value).
               ToArray()

        Return resultArray

    End Function
    ''' <summary>
    ''' Transform a decimal array to a double array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    Public Function ToDoubleArray(sender() As Decimal) As Double()
        Return Array.ConvertAll(sender, Function(input) CDbl(input))
    End Function

    ''' <summary>
    ''' Given a string array assumed to be all integers return
    ''' all elements no matter if they can be converted. Non integer
    ''' values are returned as 0.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <returns></returns>
    <Extension>
    Public Function ToDecimalPreserveArray(sender() As String) As Decimal()
        Return Array.ConvertAll(sender,
                                Function(input)
                                    Dim value As Decimal
                                    Decimal.TryParse(input, value)
                                    Return value
                                End Function)
    End Function
    ''' <summary>
    ''' Given a string array to be converted to a Decimal array
    ''' see if there are elements that are not convertible to Decimal
    ''' and return their index in the string array.
    ''' </summary>
    ''' <param name="sender">String array</param>
    ''' <returns>If non integer elements found return their index in the string array</returns>
    <Extension>
    Public Function GetNonDecimalIndexes(sender() As String) As Integer()

        Return sender.Select(
            Function(item, index)
                Dim integerValue As Decimal
                Return If(Decimal.TryParse(item, integerValue),
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