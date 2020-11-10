Imports System.Data.OleDb
''' <summary>
''' Singleton class for maintaining a single data connection. This is usually not the way to go yet many developers seem to want this.
''' </summary>
Public Class MS_AccessConnection
    Private Shared _Instance As MS_AccessConnection
    Private _Connections As New Hashtable
    Public Sub Reset(ByVal connectionString As String)
        Dim connection As OleDbConnection = Nothing
        Try
            connection = CType(_Connections(connectionString), OleDbConnection)
            connection.Dispose()
            connection = Nothing
        Catch ex As Exception
            'Do Nothing
        End Try
    End Sub
    Public Sub ResetAll()
        For Each Item As Object In _Connections
            Dim connection As OleDbConnection = Nothing

            Try
                connection = CType(Item, OleDbConnection)
                connection.Dispose()
                connection = Nothing
            Catch ex As Exception
                'Do Nothing
            End Try
        Next

    End Sub
    Public Function GetConnection(ByVal connectionString As String) As OleDb.OleDbConnection
        Dim connection As OleDbConnection = Nothing
        Dim bNeedAdd As Boolean = False
        Try
            connection = CType(_Connections(connectionString), OleDbConnection)
        Catch ex As Exception
            'Do Nothing
        End Try

        If connection Is Nothing Then
            bNeedAdd = True
        End If

        If connection Is Nothing OrElse connection.State = ConnectionState.Broken OrElse connection.State = ConnectionState.Closed Then
            Try
                If connection IsNot Nothing Then
                    connection.Dispose()
                    connection = Nothing
                End If

            Catch ex As Exception
                'Do Nothing
            End Try

            connection = New OleDbConnection
        End If

        'Always return an open connection
        If connection.State = ConnectionState.Closed Then
            DataSourceExists(connectionString)
            connection.ConnectionString = connectionString
            connection.Open()
        End If

        If bNeedAdd Then
            _Connections.Add(connectionString, connection)
        End If

        Return connection
    End Function
    Private Sub DataSourceExists(ConnectionString As String)
        Dim builder As New OleDbConnectionStringBuilder With {.ConnectionString = ConnectionString}
        If Not IO.File.Exists(builder.DataSource) Then
            Throw New Exception(
                "Failed to locate '" & builder.DataSource & "'." & Environment.NewLine &
                "Please check your configuration file connection string.")
        End If
    End Sub
    'Singleton Instance Provider
    Public Shared Function GetInstance() As MS_AccessConnection

        If _Instance Is Nothing Then
            _Instance = New MS_AccessConnection
        End If

        Return _Instance

    End Function
    'Protected means you can only call from inside this class
    'Protecting the constructor Force Singleton construction via GetInstance()
    Protected Sub New()
    End Sub
End Class
