
Imports System.IO
Imports System.Text
Imports System.Windows.Forms

Namespace Classes
    Public Class ControlWriter
        Inherits TextWriter

        Private ReadOnly _textbox As Control
        Public Sub New(textbox As Control)
            _textbox = textbox
        End Sub
        Public Overrides Sub Write(value As Char)
            _textbox.Text &= value.ToString()
        End Sub
        Public Overrides Sub Write(value As String)
            _textbox.Text &= value
        End Sub
        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return Encoding.ASCII
            End Get
        End Property
    End Class
End Namespace