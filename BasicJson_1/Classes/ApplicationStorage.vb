Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
    Public Class ApplicationStorage
        Implements INotifyPropertyChanged
        Private _name As String
        Private _value As Decimal

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set
                _name = value
                OnPropertyChanged()
            End Set
        End Property

        Property Value() As Decimal
            Get
                Return _value
            End Get
            Set
                _value = value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return Name
        End Function
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))
        End Sub
    End Class
End Namespace