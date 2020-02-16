Imports System.Text.RegularExpressions
Imports ConsoleHelperLibrary
Module Program
    Sub Main(args As String())
        Dim personList As New List(Of Person)()

        Console.WriteLine("enter done to exit")

        Dim firstNameRow As Integer = 1
        Dim lastNameRow As Integer = 2

        Dim firstName As String = ""
        Dim lastName As String = ""
        Dim enteringPeople As Boolean = True

        Do While enteringPeople

            Console.Clear()

            Dim originalForegroundColor = Console.ForegroundColor

            Console.ForegroundColor = ConsoleColor.Yellow

            Console.ForegroundColor = originalForegroundColor
            WriteText("Press ENTER after each input", 0, 5, False)
            WriteText("Leave inputs empty and press ENTER to exit", 0, 6, False)

            WriteText("Last name", 0, lastNameRow, False)
            WriteText("First name", 0, firstNameRow, False)

            Console.SetCursorPosition(12, firstNameRow)
            firstName = Console.ReadLine().ToString()

            Console.SetCursorPosition(12, lastNameRow)
            lastName = Console.ReadLine().ToString()

            If Not String.IsNullOrWhiteSpace(firstName) AndAlso Not String.IsNullOrWhiteSpace(lastName) Then

                Dim regex As New Regex("[ ]{2,}", RegexOptions.None)

                personList.Add(New Person() With {
                                  .FirstName = Regex.Replace(firstName, "\s+", " "),
                                  .LastName = lastName.Replace(vbTab, " ")})
            Else
                enteringPeople = False
            End If
        Loop

        If personList.Count > 0 Then

            Console.Clear()

            Console.WriteLine("People entered:")
            Console.WriteLine()

            Console.WriteLine("First      Last")

            For Each person As Person In personList
                Console.WriteLine($"{person.FirstName,-10} {person.LastName}")
            Next

            Console.WriteLine()

        Else
            Console.WriteLine("No names have been added")
        End If

        Console.WriteLine("Press any key to exit")
        Console.ReadLine()

    End Sub

End Module