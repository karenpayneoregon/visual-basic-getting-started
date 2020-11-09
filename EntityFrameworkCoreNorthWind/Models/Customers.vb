
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Runtime.CompilerServices

Namespace Models
    ''' <summary>
    ''' INotifyPropertyChanged is optional, if not needed each
    ''' property can be an auto-property.
    '''
    ''' String properties are marked with StringLength which
    ''' indicates the max length the database will accept.
    '''
    ''' Integer? and Date? indicate a nullable property as
    ''' per the column definition in the database table.
    ''' </summary>
    Partial Public Class Customers
        Implements INotifyPropertyChanged

        Private _companyName As String
        Private _customerIdentifier As Integer
        Private _contactIdentifier As Integer?
        Private _countryIdentifierNavigation As Countries
        Private _contactTypeNavigation As ContactType
        Private _contact1 As Contacts
        Private _contactTypeIdentifier As Integer?
        Private _phone As String
        Private _postalCode As String
        Private _city As String
        Private _address As String
        Private _countryIdentifier As Integer?

        <Key>
        Public Property CustomerIdentifier() As Integer
            Get
                Return _customerIdentifier
            End Get
            Set
                _customerIdentifier = Value
                OnPropertyChanged()
            End Set
        End Property
        <Required, StringLength(40)>
        Public Property CompanyName() As String
            Get
                Return _companyName
            End Get
            Set
                _companyName = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property ContactId() As Integer?
            Get
                Return _contactIdentifier
            End Get
            Set
                _contactIdentifier = Value
                OnPropertyChanged()
            End Set
        End Property

        <StringLength(60)>
        Public Property Address() As String
            Get
                Return _address
            End Get
            Set
                _address = Value
                OnPropertyChanged()
            End Set
        End Property

        <StringLength(15)>
        Public Property City() As String
            Get
                Return _city
            End Get
            Set
                _city = Value
                OnPropertyChanged()
            End Set
        End Property

        <StringLength(10)>
        Public Property PostalCode() As String
            Get
                Return _postalCode
            End Get
            Set
                _postalCode = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property CountryIdentifier() As Integer?
            Get
                Return _countryIdentifier
            End Get
            Set
                _countryIdentifier = Value
                OnPropertyChanged()
            End Set
        End Property

        <StringLength(24)>
        Public Property Phone() As String
            Get
                Return _phone
            End Get
            Set
                _phone = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property ContactTypeIdentifier() As Integer?
            Get
                Return _contactTypeIdentifier
            End Get
            Set
                _contactTypeIdentifier = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property ModifiedDate() As Date?

        <ForeignKey(NameOf(ContactId)), InverseProperty(NameOf(Contacts.Customers))>
        Public Overridable Property Contact() As Contacts
            Get
                Return _contact1
            End Get
            Set
                _contact1 = Value
                OnPropertyChanged()
            End Set
        End Property

        <ForeignKey(NameOf(ContactTypeIdentifier)), InverseProperty(NameOf(ContactType.Customers))>
        Public Overridable Property ContactTypeNavigation() As ContactType
            Get
                Return _contactTypeNavigation
            End Get
            Set
                _contactTypeNavigation = Value
                OnPropertyChanged()
            End Set
        End Property

        <ForeignKey(NameOf(CountryIdentifier)), InverseProperty(NameOf(Countries.Customers))>
        Public Overridable Property CountryIdentifierNavigation() As Countries
            Get
                Return _countryIdentifierNavigation
            End Get
            Set
                _countryIdentifierNavigation = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return CompanyName
        End Function
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub OnPropertyChanged(<CallerMemberName>
        Optional memberName As String = Nothing)

            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))

        End Sub
    End Class
End Namespace