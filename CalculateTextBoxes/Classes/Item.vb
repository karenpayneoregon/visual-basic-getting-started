Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Item
    Implements INotifyPropertyChanged
    Private _value1 As Integer
    Private _value2 As Integer
    Private _value3 As Integer
    Private _value4 As Integer

    Public Property Value1() As Integer
        Get
            Return _value1
        End Get
        Set
            _value1 = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Value2() As Integer
        Get
            Return _value2
        End Get
        Set
            _value2 = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Value3() As Integer
        Get
            Return _value3
        End Get
        Set
            _value3 = Value
            OnPropertyChanged()
        End Set
    End Property

    Public Property Value4() As Integer
        Get
            Return _value4
        End Get
        Set
            _value4 = Value
            OnPropertyChanged()
        End Set
    End Property

    Public ReadOnly Property Total() As Integer
        Get
            Return Value1 + Value2 + Value3 + Value4
        End Get
    End Property
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))
    End Sub
End Class