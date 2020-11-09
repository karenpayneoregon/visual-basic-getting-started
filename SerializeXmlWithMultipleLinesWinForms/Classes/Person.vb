Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Person
    Implements INotifyPropertyChanged

    Private _firstName As String
    Private _lastname As String
    Private _comments As String

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set
            _firstName = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Lastname() As String
        Get
            Return _lastname
        End Get
        Set
            _lastname = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Comments() As String
        Get
            Return _comments
        End Get
        Set
            _comments = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

    End Sub

End Class