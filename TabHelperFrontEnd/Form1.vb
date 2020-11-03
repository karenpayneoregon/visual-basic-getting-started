Imports WinFormHelpers

Public Class Form1

    Private _tabControlHelper As New TabControlHelper

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        TabPageComboBoxNames.DataSource = TabControl1.
            TabPages.OfType(Of TabPage).
            Select(Function(tabPage) New TabPageItem With {.Name = tabPage.Text, .Tab = tabPage}).
            ToList()

        _tabControlHelper = New TabControlHelper(TabControl1)

    End Sub

    Private Sub ShowAllTabsButton_Click(sender As Object, e As EventArgs) Handles ShowAllTabsButton.Click
        _tabControlHelper.ShowAllPages()
    End Sub

    Private Sub HideAllTabsButton_Click(sender As Object, e As EventArgs) Handles HideAllTabsButton.Click
        _tabControlHelper.HideAllPages()
    End Sub

    Private Sub ToggleSelectedTabVisibleButton_Click(sender As Object, e As EventArgs) Handles ToggleSelectedTabVisibleButton.Click

        Dim currentTab = CType(TabPageComboBoxNames.SelectedItem, TabPageItem).Tab

        If _tabControlHelper.HasPage(currentTab) Then
            _tabControlHelper.HidePage(currentTab)
        Else
            _tabControlHelper.ShowPage(currentTab)
            TabControl1.SelectedTab = currentTab
        End If

    End Sub

    Private Sub TabPageComboBoxNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabPageComboBoxNames.SelectedIndexChanged
        ToggleSelectedTabVisibleButton.Text = $"Toggle {TabPageComboBoxNames.Text}"
    End Sub
End Class

