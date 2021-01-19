Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Person
    Implements INotifyPropertyChanged

    Private _firstName As String
    Private _lastName As String
    Private _personId As Integer

    Public Property PersonId() As Integer
        Get
            Return _personId
        End Get
        Set
            _personId = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Set
            _firstName = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Set
            _lastName = Value
            OnPropertyChanged()
        End Set
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler _
        Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(
        <CallerMemberName> Optional memberName As String = Nothing)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

    End Sub

    Public Overrides Function ToString() As String
        Return $"{PersonId} {FirstName} {LastName}"
    End Function
End Class