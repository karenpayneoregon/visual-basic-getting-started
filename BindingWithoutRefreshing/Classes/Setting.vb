Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
    Public Class Setting
        Implements INotifyPropertyChanged

        Public Sub New(Optional language As String = "English")
            languageValue = language
        End Sub
        ''' <summary>
        ''' Shared modifier means all instances are affected,
        ''' remove Shared if that is not what you want.
        ''' </summary>
        Public languageValue As String = ""
        Public Property Language() As String
            Get
                Return languageValue
            End Get
            Set
                languageValue = Value
                '
                ' Make sure to implement the line below
                '
                OnPropertyChanged()
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(
                                                    <CallerMemberName> Optional memberName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace