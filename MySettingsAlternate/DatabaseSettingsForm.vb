Imports MySettingsAlternate.Classes

Public Class DatabaseSettingsForm
    Private Sub DatabaseSettingsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ServerTextBox.Text = ApplicationSettings.GetSettingAsString("DatabaseServer")
        CatalogTextBox.Text = ApplicationSettings.GetSettingAsString("Catalog")
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ApplicationSettings.SetValue("DatabaseServer", ServerTextBox.Text)
        ApplicationSettings.SetValue("Catalog", CatalogTextBox.Text)
        Close()
    End Sub
End Class