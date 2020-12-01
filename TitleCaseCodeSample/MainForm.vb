Public Class MainForm
    Private Sub UseTitleCaseCheckBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles UseTitleCaseCheckBox.CheckedChanged

        NameTextBox1.ToTitleCase = UseTitleCaseCheckBox.Checked
        NameTextBox2.ToTitleCase = UseTitleCaseCheckBox.Checked

    End Sub

    Private Sub OverrideCasingCheckBox_CheckedChanged(sender As Object, e As EventArgs) _
        Handles OverrideCasingCheckBox.CheckedChanged

        NameTextBox1.OverrideUpperCased = OverrideCasingCheckBox.Checked
        NameTextBox2.OverrideUpperCased = OverrideCasingCheckBox.Checked

    End Sub
End Class
