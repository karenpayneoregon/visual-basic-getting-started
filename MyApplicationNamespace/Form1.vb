Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If My.Application.HasCommandLineArguments Then
            ListBox1.Items.AddRange(My.Application.CommandLineArguments)
        End If

        If My.Application.AdminMode Then
            Label1.Text = "Admin mode!!!"
        End If

        BitMapNamesComboBox.DataSource = ResourceHelper.GetInstance().BitMapNames()
        IconNamesComboBox.DataSource = ResourceHelper.GetInstance().IconNames()

        IconNamesComboBox.SelectedIndex = IconNamesComboBox.FindString("agent2")

        ActiveControl = BitMapNamesComboBox

    End Sub
    Private Sub BitMapNamesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BitMapNamesComboBox.SelectedIndexChanged
        BitMapPictureBox.Image = ResourceHelper.GetInstance().GetSingleBitMap(BitMapNamesComboBox.Text)
    End Sub

    Private Sub IconNamesComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IconNamesComboBox.SelectedIndexChanged
        IconPictureBox.Image = ResourceHelper.GetInstance().IconToBitMap(IconNamesComboBox.Text)
    End Sub
End Class
