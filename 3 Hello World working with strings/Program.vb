Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module
Public Class StringExamples
    Public Shared Sub InterpolationExamples()

    End Sub
    Public Shared Sub ContainsExamples()

    End Sub
    Public Shared Sub IterationExamples()

    End Sub
    Public Shared Sub SplitExamples()
        Dim sentence As String = "this--is--a--complete--sentence"
        Dim tokens() As String = sentence.Split({"--"}, StringSplitOptions.None)

    End Sub
    Public Shared Sub ExtractExamples()

    End Sub
    Public Shared Sub CompareExamples()

    End Sub
    Public Shared Sub CharToString()

    End Sub
    Public Shared Sub TestForEmptyExample()

    End Sub
    Public Shared Sub CountOccurrencesExamples()

    End Sub
    Public Shared Sub InsertIntoExamples()

    End Sub
    Public Shared Sub ReplaceExamples()
        Dim token = "Hello France"
        token = token.Replace("France", "USA")
    End Sub
    Public Shared Sub DateTimeToStringExamples()

    End Sub
    Public Shared Sub ConvertStringToIntegerExamples()

    End Sub
    Public Shared Sub TrimExamples()

    End Sub
    Public Shared Sub PadExamples()

    End Sub
    Public Shared Sub CreateDelimitedStringFromArrayExamples()

    End Sub
    Public Shared Sub ConcatenationExamples()

    End Sub
    Public Shared Sub LikeConditionExamples()

    End Sub
End Class