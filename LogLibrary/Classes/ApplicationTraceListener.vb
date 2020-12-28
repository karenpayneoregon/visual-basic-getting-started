Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.IO
Imports System.Linq
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks

Namespace LogLibrary
	Public NotInheritable Class ApplicationTraceListener
		Private Shared ReadOnly Lazy As New Lazy(Of ApplicationTraceListener)(Function() New ApplicationTraceListener())

		Public Shared ReadOnly Property Instance() As ApplicationTraceListener
			Get
				Return Lazy.Value
			End Get
		End Property
		Private Shared _textWriterTraceListener As TextWriterTraceListener

		Public Sub CreateLog()
			_textWriterTraceListener = New TextWriterTraceListener("applicationLog.txt", "PayneListener")
			Trace.Listeners.Add(_textWriterTraceListener)
		End Sub
		''' <summary>
		''' Create new instance of trace listener
		''' </summary>
		''' <param name="fileName">From startup project app.config file to write too</param>
		''' <param name="listenerName">From startup project app.config unique name of listener</param>
		Public Sub CreateLog(ByVal fileName As String, ByVal listenerName As String)
			_textWriterTraceListener = New TextWriterTraceListener(fileName, listenerName)
			Trace.Listeners.Add(_textWriterTraceListener)
		End Sub
		''' <summary>
		''' Get file name and full path to log file
		''' </summary>
		Public Function ListenerLogFileName() As String

			If _textWriterTraceListener Is Nothing Then
				Return ""
			End If

			Dim writer = CType(_textWriterTraceListener.Writer, StreamWriter)
			Dim stream = CType(writer.BaseStream, FileStream)

			Return stream.Name

		End Function

		Public Function ListenerName() As String
			If _textWriterTraceListener Is Nothing Then
				Return ""
			End If

			Return _textWriterTraceListener.Name
		End Function

		Public Sub Flush()
			If _textWriterTraceListener Is Nothing Then
				Return
			End If

			_textWriterTraceListener.Flush()

		End Sub

		''' <summary>
		''' Write trace information to disk
		''' </summary>
		Public Sub Close()
			If _textWriterTraceListener Is Nothing Then
				Return
			End If

			_textWriterTraceListener.Flush()
			_textWriterTraceListener.Close()

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
		Public Property WriteToTraceFile() As Boolean
		Private Sub WriteEntry(ByVal message As String, ByVal type As String, ByVal callerName As String)
			If _textWriterTraceListener Is Nothing Then
				Return
			End If
			If Not WriteToTraceFile Then
				Return
			End If

			_textWriterTraceListener.Flush()
			_textWriterTraceListener.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss},{type},{callerName},{message}")
		End Sub
	End Class
End Namespace
