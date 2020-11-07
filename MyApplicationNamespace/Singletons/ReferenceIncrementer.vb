Option Infer On
Namespace Singletons
    ''' <summary>
    ''' Thread safe singleton responsible for creating
    ''' unique sequence for email subject.
    ''' </summary>
    Public NotInheritable Class ReferenceIncrementer
        Private Shared ReadOnly Lazy As New Lazy(Of ReferenceIncrementer)(Function() New ReferenceIncrementer())

        Public Shared ReadOnly Property Instance() As ReferenceIncrementer
            Get
                Return Lazy.Value
            End Get
        End Property

        Private _baseList As New List(Of Integer)()

        ''' <summary>
        ''' Populate HashSet with random numbers.
        ''' HastSet items are unique.
        ''' </summary>
        Private Sub CreateList()
            _baseList = New List(Of Integer)()

            For index = 1 To 8999
                _baseList.Add(index)
            Next

        End Sub
        Private _lastSequenceValue As Integer
        Public ReadOnly Property LastSequenceValue() As Integer
            Get
                Return _lastSequenceValue
            End Get
        End Property
        ''' <summary>
        ''' Return a left padded number prefix with REF: 0001
        ''' .Any ask if there are any values when called.
        ''' </summary>
        ''' <returns></returns>
        Public Function GetReferenceValue() As String

            If Not _baseList.Any() Then
                CreateList()
            End If

            Dim number = _baseList.FirstOrDefault()
            _baseList.Remove(number)
            _lastSequenceValue = number
            Return $" REF: {number:D4}"

        End Function

        ''' <summary>
        ''' Instantiate List
        ''' </summary>
        Private Sub New()
            CreateList()
        End Sub
        ''' <summary>
        ''' Used to reset at a given time e.g. right before midnight,
        ''' perhaps by a scheduled job.
        ''' </summary>
        Public Sub Reset()
            CreateList()
        End Sub
    End Class
End Namespace
