Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes.Json
    <Serializable()>
    Public Class MyApplicationJson
        Implements INotifyPropertyChanged

        Private _mainWindowTitle As String
        Private _incomingFolder As String
        Private _importMinutesToPause As Integer
        Private _testMode As Boolean
        Private _lastRan As Date
        Private _databaseServer As String
        Private _catalog As String
        Private _lastCategoryIdentifier As Integer


        Public Property MainWindowTitle() As String
            Get
                Return _mainWindowTitle
            End Get
            Set
                _mainWindowTitle = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property IncomingFolder() As String
            Get
                Return _incomingFolder
            End Get
            Set
                _incomingFolder = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property ImportMinutesToPause() As Integer
            Get
                Return _importMinutesToPause
            End Get
            Set
                _importMinutesToPause = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property TestMode() As Boolean
            Get
                Return _testMode
            End Get
            Set
                _testMode = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property LastRan() As DateTime
            Get
                Return _lastRan
            End Get
            Set
                _lastRan = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property LastCategoryIdentifier() As Integer
            Get
                Return _lastCategoryIdentifier
            End Get
            Set
                _lastCategoryIdentifier = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property DatabaseServer() As String
            Get
                Return _databaseServer
            End Get
            Set
                _databaseServer = Value
                OnPropertyChanged()
            End Set
        End Property

        Public Property Catalog() As String
            Get
                Return _catalog
            End Get
            Set
                _catalog = Value
                OnPropertyChanged()
            End Set
        End Property

        Public ReadOnly Property ConnectionString() As String
            Get
                Return $"Data Source= {DatabaseServer};Initial Catalog={Catalog};Integrated Security=True"
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return $"Last ran {LastRan}"
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional memberName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(memberName))
        End Sub
        ''' <summary>
        ''' Prevent serializing ConnectionString property
        ''' </summary>
        ''' <returns></returns>
        Public Function ShouldSerializeConnectionString() As Boolean
            Return False
        End Function
    End Class

End Namespace