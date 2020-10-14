Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Address
    Implements INotifyPropertyChanged

    Private _street As String
    Private _addressId As Integer
    Private _personId As Integer

    Public Property AddressId() As Integer
        Get
            Return _addressId
        End Get
        Set
            _addressId = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property PersonId() As Integer
        Get
            Return _personId
        End Get
        Set
            _personId = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Street() As String
        Get
            Return _street
        End Get
        Set
            _street = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

    End Sub
End Class