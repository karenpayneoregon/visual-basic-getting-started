Imports Microsoft.Data.SqlClient


Public Class BaseExceptionsHandler

    Protected Shared ThisHasException As Boolean
    ''' <summary>
    ''' Indicate the last operation thrown an 
    ''' exception or not
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property HasException() As Boolean
        Get
            Return ThisHasException
        End Get
    End Property
    Protected Shared TheLastException As Exception
    ''' <summary>
    ''' Provides access to the last exception thrown
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property LastException() As Exception
        Get
            Return TheLastException
        End Get
    End Property
    ''' <summary>
    ''' If you don't need the entire exception as in 
    ''' LastException this provides just the text of the exception
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property LastExceptionMessage As String
        Get
            Return TheLastException.Message
        End Get
    End Property
    ''' <summary>
    ''' Indicate for return of a function if there was an 
    ''' exception thrown or not.
    ''' </summary>
    ''' <returns></returns>
    Public Shared ReadOnly Property IsSuccessFul As Boolean
        Get
            Return Not ThisHasException
        End Get
    End Property
End Class