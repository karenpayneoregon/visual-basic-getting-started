Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Runtime.CompilerServices

Namespace Models
    Partial Public Class ContactType
        Implements INotifyPropertyChanged
        Private _contactTitle As String

        Public Sub New()
            Customers = New HashSet(Of Customers)()
        End Sub

        <Key>
        Public Property ContactTypeIdentifier() As Integer

        Public Property ContactTitle() As String
            Get
                Return _contactTitle
            End Get
            Set
                _contactTitle = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return ContactTitle
        End Function

        <InverseProperty("ContactTypeNavigation")>
        Public Overridable Property Customers() As ICollection(Of Customers)
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName>
        Optional memberName As String = Nothing)

            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace