'
' There are several classes here.
' They work as is but each class should be
' in their own file
'
' Requires Json.net NuGet package
' https://www.nuget.org/packages/Newtonsoft.Json/
' From Visual Studio package manage console.
' Install-Package Newtonsoft.Json -Version 12.0.3
'
Imports Newtonsoft.Json

Namespace Classes
    ''' <summary>
    ''' Strongly typed container for assets read from json
    ''' </summary>
    Public Class Asset
        Public Property Category() As String
        Public Property Installed() As Boolean
        <JsonIgnore>
        Public ReadOnly Property IsInstalled() As String
            Get
                Return If(Installed, "Yes", "No")
            End Get
        End Property
        Public Property Name() As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class
End Namespace