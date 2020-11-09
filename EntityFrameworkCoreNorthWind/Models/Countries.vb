
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Runtime.CompilerServices

Namespace Models
    Partial Public Class Countries
        Implements INotifyPropertyChanged
        Private _name As String

        Public Sub New()
            Customers = New HashSet(Of Customers)()
        End Sub

        <Key>
        Public Property CountryIdentifier() As Integer

        Public Property Name() As String
            Get
                Return _name
            End Get
            Set
                _name = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return Name
        End Function

        <InverseProperty("CountryIdentifierNavigation")>
        Public Overridable Property Customers() As ICollection(Of Customers)
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName>
        Optional memberName As String = Nothing)

            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace