Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Threading
Imports System.Threading.Tasks
Imports Classes.Classes


Namespace Classes
        Public Class Operations
            Public Event OnIterate_Conflict As DelegatesModule.OnIterate
            Private _folderFound As Boolean
            Public ReadOnly Property FolderExists() As Boolean
                Get
                    Return _folderFound
                End Get
            End Property

            Public Async Function IterateFolders(folderName As String, searchString As String, token As CancellationToken) As Task(Of List(Of String))

                Dim foundList = New List(Of String)()

                If Not Directory.Exists(folderName) Then

                    OnIterate_ConflictEvent?.Invoke(New MonitorProgressArgs("Folder does not exists!"))
                    _folderFound = False

                    Return foundList

                End If

                _folderFound = True

                Dim currentFileName = ""

                Try
                    For Each fileName In Directory.EnumerateFiles(folderName, "*.txt", SearchOption.AllDirectories)
                        currentFileName = fileName
                        OnIterate_ConflictEvent?.Invoke(New MonitorProgressArgs(fileName))

                        Dim contents = File.ReadAllText(fileName)

                        Await Task.Delay(1, token)

                        If contents.Contains(searchString) Then
                            foundList.Add(fileName)
                        End If

                        If token.IsCancellationRequested Then
                            token.ThrowIfCancellationRequested()
                        End If

                    Next fileName
                Catch ex As Exception
                    OnIterate_ConflictEvent?.Invoke(New MonitorProgressArgs($"Access denied {currentFileName}"))
                End Try

                Return foundList

            End Function
        End Class
    End Namespace

