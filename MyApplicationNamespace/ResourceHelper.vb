Imports System.Reflection

Public Class ResourceHelper

    Private Shared _instance As ResourceHelper

    Public Shared Function GetInstance() As ResourceHelper

        If _instance Is Nothing Then
            _instance = New ResourceHelper
        End If

        Return _instance

    End Function
    ''' <summary>
    ''' Get a single bitmap by name
    ''' </summary>
    ''' <param name="resourceName">Existing resource</param>
    ''' <returns>BitMap specified by name</returns>
    Public Function GetSingleBitMap(resourceName As String) As Bitmap

        Return DirectCast(My.Resources.ResourceManager.GetObject(GetMyProperties().
            FirstOrDefault(Function(pi) pi.PropertyType Is GetType(Bitmap) AndAlso
                                         pi.Name = resourceName).Name), Bitmap)

    End Function
    ''' <summary>
    ''' Get a single icon by name
    ''' </summary>
    ''' <param name="resourceName"></param>
    ''' <returns></returns>
    Public Function GetSingleIcon(resourceName As String) As Icon

        Return DirectCast(My.Resources.ResourceManager.GetObject(GetMyProperties().
            FirstOrDefault(Function(pi) pi.PropertyType Is GetType(Icon) AndAlso
                                        pi.Name = resourceName).Name), Icon)

    End Function
    ''' <summary>
    ''' Get a icon and convert to BitMap for displaying in a PictureBox
    ''' </summary>
    ''' <param name="resourceName"></param>
    ''' <returns></returns>
    Public Function IconToBitMap(resourceName As String) As Bitmap

        Dim icon = DirectCast(My.Resources.ResourceManager.GetObject(GetMyProperties().
            FirstOrDefault(Function(pi) pi.PropertyType Is GetType(Icon) AndAlso
                                        pi.Name = resourceName).Name), Icon)

        Return icon.ToBitmap()

    End Function
    ''' <summary>
    ''' Example for obtaining a byte array from resources
    ''' </summary>
    ''' <param name="resourceName"></param>
    ''' <returns></returns>
    Public Function GetItemAsByteArray(resourceName As String) As Byte()

        Return DirectCast(My.Resources.ResourceManager.GetObject(GetMyProperties().
            FirstOrDefault(Function(pi) pi.PropertyType Is GetType(Byte()) AndAlso
                                         pi.Name = resourceName).Name), Byte())

    End Function
    ''' <summary>
    ''' Get bitmap names in project resources
    ''' </summary>
    ''' <returns></returns>
    Public Function BitMapNames() As List(Of String)

        Return GetMyProperties().Where(Function(pi) pi.PropertyType Is GetType(Bitmap)).
            Select(Function(pi) pi.Name).OrderBy(Function(item) item).ToList()

    End Function
    Public Function IconNames() As List(Of String)

        Return GetMyProperties().Where(Function(pi) pi.PropertyType Is GetType(Icon)).
            Select(Function(pi) pi.Name).OrderBy(Function(item) item).ToList()

    End Function
    Private Function GetMyProperties() As IEnumerable(Of PropertyInfo)

        Return GetType(My.Resources.Resources).GetProperties(
            BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.Static)

    End Function

End Class
