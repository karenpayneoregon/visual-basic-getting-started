Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Public Class TabControlHelper
    Private _tabControl As TabControl
    Private _pagesIndexed As List(Of KeyValuePair(Of TabPage, Integer))

    Public Sub New()

    End Sub
    Public Sub New(tabControl As TabControl)
        _tabControl = tabControl
        _pagesIndexed = New List(Of KeyValuePair(Of TabPage, Integer))()

        For index As Integer = 0 To tabControl.TabPages.Count - 1
            _pagesIndexed.Add(New KeyValuePair(Of TabPage, Integer)(tabControl.TabPages(index), index))
        Next
    End Sub

    Public ReadOnly Property TabControl() As TabControl
        Get
            Return _tabControl
        End Get
    End Property
    Public Function HasPage(tabPage As TabPage) As Boolean
        Return TabControl.TabPages.Contains(tabPage)
    End Function
    Public Sub HideAllPages()
        For index As Integer = 0 To _pagesIndexed.Count - 1
            _tabControl.TabPages.Remove(_pagesIndexed(index).Key)
        Next index
    End Sub

    Public Sub ShowAllPages()
        For index As Integer = 0 To _pagesIndexed.Count - 1
            _tabControl.TabPages.Add(_pagesIndexed(index).Key)
        Next index
    End Sub

    Public Sub HidePage(ByVal tabPage As TabPage)
        If Not _tabControl.TabPages.Contains(tabPage) Then
            Return
        End If

        _tabControl.TabPages.Remove(tabPage)
    End Sub
    ''' <summary>
    ''' Show specified tab page
    ''' </summary>
    ''' <param name="tabPage"></param>
    Public Sub ShowPage(tabPage As TabPage)
        If _tabControl.TabPages.Contains(tabPage) Then
            Return
        End If

        InsertTabPage(GetTabPage(tabPage).Key, GetTabPage(tabPage).Value)
    End Sub
    ''' <summary>
    ''' Insert tab page at index
    ''' </summary>
    ''' <param name="tabPage">TabPage to insert</param>
    ''' <param name="index">At index in TabControl</param>
    Private Sub InsertTabPage(tabPage As TabPage, index As Integer)
        If _tabControl.TabCount = 0 Then
            Exit Sub
        End If

        If index < 0 OrElse index > _tabControl.TabCount Then
            Throw New ArgumentException("Index out of Range.")
        End If

        _tabControl.TabPages.Add(tabPage)

        If index < _tabControl.TabCount - 1 Then
            Do
                SwapTabPages(tabPage, (_tabControl.TabPages(_tabControl.TabPages.IndexOf(tabPage) - 1)))
            Loop While _tabControl.TabPages.IndexOf(tabPage) <> index
        End If

        _tabControl.SelectedTab = tabPage

    End Sub
    ''' <summary>
    ''' Swap position of two TabPages
    ''' </summary>
    ''' <param name="tabPage1">First TabPage</param>
    ''' <param name="tabPage2">Second TabPage</param>
    Private Sub SwapTabPages(tabPage1 As TabPage, tabPage2 As TabPage)

        If _tabControl.TabPages.Contains(tabPage1) = False OrElse _tabControl.TabPages.Contains(tabPage2) = False Then
            Throw New ArgumentException("TabPages must be in the TabControls TabPageCollection.")
        End If

        Dim index1 As Integer = _tabControl.TabPages.IndexOf(tabPage1)
        Dim index2 As Integer = _tabControl.TabPages.IndexOf(tabPage2)

        _tabControl.TabPages(index1) = tabPage2
        _tabControl.TabPages(index2) = tabPage1
    End Sub
    ''' <summary>
    ''' Get TabPage
    ''' </summary>
    ''' <param name="tabPage">Specific TabPage</param>
    ''' <returns></returns>
    Private Function GetTabPage(tabPage As TabPage) As KeyValuePair(Of TabPage, Integer)
        Return _pagesIndexed.First(Function(kvp) kvp.Key Is tabPage)
    End Function
End Class