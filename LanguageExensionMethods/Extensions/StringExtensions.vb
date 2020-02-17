Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Public Module StringExtensions
    ''' <summary>
    ''' Determine if string is empty
    ''' </summary>
    ''' <param name="sender">String to test if null or whitespace</param>
    ''' <returns>true if empty or false if not empty</returns>
    <Extension>
    Public Function IsNullOrWhiteSpace(sender As String) As Boolean
        Return String.IsNullOrWhiteSpace(sender)
    End Function

    ''' <summary>
    ''' Join string array with " and " as the last delimiter.
    ''' </summary>
    ''' <param name="sender">String array to convert to delimited string</param>
    ''' <returns>Delimited string</returns>
    <Extension>
    Public Function JoinWithLastSeparator(sender() As String) As String
        Return String.Join(", ", sender.Take(sender.Length - 1)) + (((If(sender.Length <= 1, "", " and "))) + sender.LastOrDefault())
    End Function
    ''' <summary>
    ''' Given a string with upper and lower cased letters separate them before each upper cased characters
    ''' </summary>
    ''' <param name="sender">String to work against</param>
    ''' <returns>String with spaces between upper-case letters</returns>
    <Extension>
    Public Function SplitCamelCase(sender As String) As String
        Return Regex.Replace(Regex.Replace(sender, "(\P{Ll})(\P{Ll}\p{Ll})", "$1 $2"), "(\p{Ll})(\P{Ll})", "$1 $2")
    End Function

End Module
