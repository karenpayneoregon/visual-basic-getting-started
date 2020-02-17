Imports System.Runtime.CompilerServices

''' <summary>
''' Various language extension methods to extend numeric types
''' </summary>
Public Module NumericExtensions
    ''' <summary>
    ''' Calculates a value's percentage of another value.
    ''' </summary>
    ''' <param name="sender">Value to compare.</param>
    ''' <param name="pTotalValue">Total value to compare original to.</param>
    ''' <returns>Integer percentage value.</returns>
    <Extension>
    Public Function PercentageOf(sender As Double, pTotalValue As Double) As Integer
        Return CInt(sender * 100 / pTotalValue)
    End Function
    ''' <summary>
    ''' Calculates a value's percentage of another value.
    ''' </summary>
    ''' <param name="sender">Value to compare.</param>
    ''' <param name="pTotalValue">Integer percentage value.</param>
    ''' <returns>Percent of total</returns>
    <Extension>
    Public Function PercentageOf(sender As Decimal, pTotalValue As Decimal) As Integer
        Return CInt(Math.Truncate(Convert.ToDecimal(sender * 100 / pTotalValue)))
    End Function
    ''' <summary>
    ''' Calculates a value's percentage of another value.
    ''' </summary>
    ''' <param name="sender">Value to compare.</param>
    ''' <param name="pTotalValue">Total value to compare original to.</param>
    ''' <returns>Integer percentage value.</returns>
    <Extension>
    Public Function PercentageOf(sender As Long, pTotalValue As Long) As Integer
        Return CInt(sender * 100 \ pTotalValue)
    End Function
    ''' <summary>
    ''' Determine if sender is event
    ''' </summary>
    ''' <param name="sender">Int to work against</param>
    ''' <returns>True if even, false if odd</returns>
    <Extension>
    Public Function IsEven(sender As Integer) As Boolean
        Return sender Mod 2 = 0
    End Function
End Module

