﻿Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
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

    Public Property AddressList() As New ObservableCollection(Of Address)()
    Public Sub AddAddress(address As Address)
        AddressList.Add(address)
        OnPropertyChanged("AddressList")
    End Sub
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)

        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

    End Sub

    Public Overrides Function ToString() As String
        Return $"{FirstName} {LastName}"
    End Function
End Class
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