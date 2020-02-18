Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Customer
    Implements INotifyPropertyChanged

    Private _firstName1 As String
    Private _lastName1 As String

    Public Property FirstName() As String
        Get
            Return _firstName1
        End Get
        Set
            _firstName1 = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return _lastName1
        End Get
        Set
            _lastName1 = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property FullName() As String
        Get
            Return $"{FirstName} {LastName}"
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return $"{FirstName} {LastName}"
    End Function

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
        PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

End Class
