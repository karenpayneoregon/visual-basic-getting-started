Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes

    Public Class Customer
        Implements INotifyPropertyChanged

        Private _countryName As String
        Private _companyName As String
        Private _countryIdentifier1 As Integer

        Public Property CompanyName() As String
            Get
                Return _companyName
            End Get
            Set
                _companyName = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property CountryIdentifier() As Integer
            Get
                Return _countryIdentifier1
            End Get
            Set
                _countryIdentifier1 = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property CountryName() As String
            Get
                Return _countryName
            End Get
            Set
                _countryName = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)

            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace