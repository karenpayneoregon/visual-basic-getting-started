
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Runtime.CompilerServices

Namespace Models
    ''' <summary>
    ''' 
    ''' </summary>
    Partial Public Class Contacts
        Implements INotifyPropertyChanged
        Private _firstName As String
        Private _lastName As String

        Public Sub New()
            Customers = New HashSet(Of Customers)()
        End Sub

        <Key>
        Public Property ContactId() As Integer

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

        ''' <summary>
        ''' Displays first and last name
        ''' </summary>
        ''' <returns>Contact's full name</returns>
        ''' <remarks>Not updateable</remarks>
        <NotMapped()>
        Public ReadOnly Property FullName() As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return $"{FirstName} {LastName}"
        End Function

        <InverseProperty("Contact")>
        Public Overridable Property Customers() As ICollection(Of Customers)

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName>
        Optional memberName As String = Nothing)

            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace