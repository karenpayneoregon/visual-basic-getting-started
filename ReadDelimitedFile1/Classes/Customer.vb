Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports JetBrains.Annotations

Namespace Classes
    Public Class Customer
        Implements INotifyPropertyChanged

        ''' <summary>
        ''' Backing fields for implementation of INotifyPropertyChanged
        ''' </summary>
        Private _companyName As String
        Private _contactName As String
        Private _contactTitle As String
        Private _city As String
        Private _country As String

        ''' <summary>
        ''' Primary key
        ''' </summary>
        ''' <returns></returns>
        Public Property CustomerIdentifier() As Integer
        ''' <summary>
        ''' Name of company - can not be null
        ''' </summary>
        ''' <returns></returns>
        Public Property CompanyName() As String
            Get
                Return _companyName
            End Get
            Set

                If Value = _companyName Then
                    Return
                End If

                _companyName = Value
                OnPropertyChanged()

            End Set
        End Property
        ''' <summary>
        ''' Contact full name
        ''' </summary>
        ''' <returns></returns>
        Public Property ContactName() As String
            Get
                Return _contactName
            End Get
            Set

                If Value = _contactName Then
                    Return
                End If

                _contactName = Value
                OnPropertyChanged()

            End Set
        End Property
        ''' <summary>
        ''' Contact title
        ''' </summary>
        ''' <returns></returns>
        Public Property ContactTitle() As String
            Get
                Return _contactTitle
            End Get
            Set
                If Value = _contactTitle Then
                    Return
                End If

                _contactTitle = Value
                OnPropertyChanged()

            End Set

        End Property
        ''' <summary>
        ''' City name
        ''' </summary>
        ''' <returns></returns>
        Public Property City() As String
            Get
                Return _city
            End Get
            Set
                If Value = _city Then
                    Return
                End If

                _city = Value
                OnPropertyChanged()

            End Set

        End Property
        ''' <summary>
        ''' Country name
        ''' </summary>
        ''' <returns></returns>
        Public Property Country() As String
            Get
                Return _country
            End Get
            Set
                If Value = _country Then
                    Return
                End If

                _country = Value
                OnPropertyChanged()

            End Set
        End Property

        Public Overrides Function ToString() As String
            Return CompanyName
        End Function
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        <NotifyPropertyChangedInvocator>
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
            PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
        End Sub

    End Class

End Namespace