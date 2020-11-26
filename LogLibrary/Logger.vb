Imports System
Imports System.Diagnostics
Imports System.Runtime.CompilerServices

Namespace LogLibrary
	Public Module Logger
		Private _textWriterTraceListener As TextWriterTraceListener

		''' <summary>
		''' Initialize trace for logging.
		''' </summary>
		Public Sub CreateLog()
			_textWriterTraceListener = New TextWriterTraceListener("applicationLog.txt", "PayneListener")
			Trace.Listeners.Add(_textWriterTraceListener)
		End Sub
		''' <summary>
		''' Write trace information to disk
		''' </summary>
		Public Sub Close()
			_textWriterTraceListener.Flush()
		End Sub
		Public Sub Exception(ByVal message As String, <CallerMemberName> Optional ByVal callerName As String = Nothing)
			WriteEntry(message, "error", callerName)
		End Sub
		Public Sub Exception(ByVal ex As Exception, <CallerMemberName> Optional ByVal callerName As String = Nothing)
			WriteEntry(ex.Message, "error", callerName)
		End Sub
		Public Sub Warning(ByVal message As String, <CallerMemberName> Optional ByVal callerName As String = Nothing)
			WriteEntry(message, "warning", callerName)
		End Sub
		Public Sub Info(ByVal message As String, <CallerMemberName> Optional ByVal callerName As String = Nothing)
			WriteEntry(message, "info", callerName)
		End Sub
		Public Sub EmptyLine()
			_textWriterTraceListener.WriteLine("")
		End Sub

		Private Sub WriteEntry(ByVal message As String, ByVal type As String, ByVal callerName As String)
			_textWriterTraceListener.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")},{type},{callerName},{message}")

		End Sub
	End Module
End Namespace
