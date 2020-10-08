Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Person
    Implements INotifyPropertyChanged

    Private _firstName As String
    Private _lastName As String
    Private _personId As Integer
    Private _addressList As List(Of Address)


    Public Sub New()
        AddressList = New List(Of Address)
    End Sub

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

    Public Property AddressList() As List(Of Address)
        Get
            Return _addressList
        End Get
        Set
            _addressList = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

    End Sub

    Public Overrides Function ToString() As String
        Return $"{FirstName} {LastName}"
    End Function


End Class
Public Class Address

    Public Property AddressId() As Integer
    Public Property PersonId() As Integer
    Public Property Street() As String

End Class