﻿Module Module1

    Sub Main()

        Dim list = New List(Of String) From {"Cat", "Dog", "Giraffe", "Dog", "Dog", "Gazelle", "Cat"}

        Dim grouped = list.GroupBy(Function(s) s).Select(Function(g) New With {
                                                            Key .Annimal = g.Key,
                                                            Key .Count = g.Count()
                                                            })
        For Each item In grouped
            Console.WriteLine($"{item.Annimal} {item.Count}")
        Next item

        Console.ReadLine()

    End Sub

End Module
