Option Infer On

Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports System.Windows.Interop
Imports Microsoft.Win32.SafeHandles

Public Class CursorHelper
    Private NotInheritable Class NativeMethods
        Public Structure IconInfo
            Public fIcon As Boolean
            Public xHotspot As Integer
            Public yHotspot As Integer
            Public hbmMask As IntPtr
            Public hbmColor As IntPtr
        End Structure

        Private Sub New()
        End Sub


        <DllImport("user32.dll")>
        Public Shared Function CreateIconIndirect(ByRef icon As IconInfo) As SafeIconHandle
        End Function

        <DllImport("user32.dll")>
        Public Shared Function DestroyIcon(hIcon As IntPtr) As Boolean
        End Function

        <DllImport("user32.dll")>
        Public Shared Function GetIconInfo(hIcon As IntPtr, ByRef pIconInfo As IconInfo) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function
    End Class

    <SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode:=True)>
    Private Class SafeIconHandle
        Inherits SafeHandleZeroOrMinusOneIsInvalid

        Public Sub New()
            MyBase.New(True)
        End Sub

        Protected Overrides Function ReleaseHandle() As Boolean
            Return NativeMethods.DestroyIcon(handle)
        End Function

    End Class

    Private Shared Function InternalCreateCursor(bmp As Bitmap) As Cursor

        Dim iconInfo = New NativeMethods.IconInfo()
        NativeMethods.GetIconInfo(bmp.GetHicon(), iconInfo)

        iconInfo.xHotspot = 0
        iconInfo.yHotspot = 0
        iconInfo.fIcon = False

        Dim cursorHandle As SafeIconHandle = NativeMethods.CreateIconIndirect(iconInfo)

        Return CursorInteropHelper.Create(cursorHandle)

    End Function
    Public Shared Function CreateCursorFromImage(
         bmpName As String,
         Optional xHotSpot As Integer = 0,
         Optional yHotSpot As Integer = 0) As Cursor

        Dim bitmapImage = New BitmapImage()

        Using stream = New FileStream(bmpName, FileMode.Open)
            bitmapImage.BeginInit()
            bitmapImage.CacheOption = BitmapCacheOption.OnLoad
            bitmapImage.StreamSource = stream
            bitmapImage.EndInit()
            bitmapImage.Freeze()
        End Using

        Dim bitMap = BitmapImage2Bitmap(bitmapImage)

        Dim iconInfo As New NativeMethods.IconInfo()
        NativeMethods.GetIconInfo(bitMap.GetHicon(), iconInfo)

        iconInfo.xHotspot = 0
        iconInfo.yHotspot = 0
        iconInfo.fIcon = False

        Dim cursorHandle As SafeIconHandle = NativeMethods.CreateIconIndirect(iconInfo)

        Return CursorInteropHelper.Create(cursorHandle)


    End Function
    ''' <summary>
    ''' Convert a BitmapImage to BitMap
    ''' </summary>
    ''' <param name="bitmapImage"></param>
    ''' <returns></returns>
    Private Shared Function BitmapImage2Bitmap(bitmapImage As BitmapImage) As Bitmap

        Using outStream As New MemoryStream()
            Dim enc As BitmapEncoder = New BmpBitmapEncoder()
            enc.Frames.Add(BitmapFrame.Create(bitmapImage))
            enc.Save(outStream)
            Dim bitmap As New Bitmap(outStream)

            Return New Bitmap(bitmap)

        End Using
    End Function
    ''' <summary>
    ''' Create cursor with text when over destination conntrol
    ''' </summary>
    ''' <param name="cursorText"></param>
    ''' <returns></returns>
    Public Shared Function CreateCursor(cursorText As String) As Cursor

        ' Text to render
        Dim formattedText As New FormattedText(
            cursorText,
            New CultureInfo("en-us"), FlowDirection.LeftToRight,
            New Typeface(New Media.FontFamily("Arial"), FontStyles.Normal,
                         FontWeights.Normal,
                         New FontStretch()), 12.0, Media.Brushes.Black)


        Dim drawingVisual As New DrawingVisual()
        Dim drawingContext As DrawingContext = drawingVisual.RenderOpen()
        drawingContext.DrawText(formattedText, New Windows.Point())
        drawingContext.Close()


        Dim rtb As New RenderTargetBitmap(
            CInt(drawingVisual.ContentBounds.Width),
            CInt(drawingVisual.ContentBounds.Height), 96, 96, PixelFormats.Pbgra32)

        rtb.Render(drawingVisual)

        Dim encoder As New PngBitmapEncoder()
        encoder.Frames.Add(BitmapFrame.Create(rtb))

        Using ms = New MemoryStream()

            encoder.Save(ms)

            Using bmp = New Bitmap(ms)
                Return InternalCreateCursor(bmp)
            End Using

        End Using
    End Function

End Class
