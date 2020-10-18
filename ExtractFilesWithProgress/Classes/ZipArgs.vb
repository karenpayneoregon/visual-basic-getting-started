Namespace Classes
    ''' <summary>
    ''' For ZipEventHandler delegate args
    ''' </summary>
    Public Class ZipArgs
        Inherits EventArgs

        Private _fileName As String
        Private _percentDone As Integer
        Private _fileLength As Long
        Private _extracted As Boolean

        Public Sub New(
           fileName As String,
           fileLength As Long,
           percentDone As Integer,
           extracted As Boolean)

            _fileName = fileName
            _fileLength = fileLength
            _percentDone = percentDone
            _extracted = extracted
        End Sub
        Public ReadOnly Property FileName As String
            Get
                Return _fileName
            End Get
        End Property
        Public ReadOnly Property FileLength() As Long
            Get
                Return _fileLength
            End Get
        End Property
        Public ReadOnly Property PercentDone As Integer
            Get
                Return _percentDone
            End Get
        End Property
        Public ReadOnly Property Extracted() As Boolean
            Get
                Return _extracted
            End Get
        End Property
    End Class
End Namespace