Imports MySettingsAlternate.Classes
Imports WinFormHelpers
''' <summary>
''' Please note the lack of assertion on checking if TextBox controls
''' have or don't have values this can be added but detracts from what
''' is being presented.
'''
''' Cancel button has DialogResult set to Cancel which closes the form
''' when clicked.
''' </summary>
Public Class UserDetailsForm
    Private Sub UserDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(FirstTextBox, "Enter first name")
        SetCueText(LastNameTextBox, "Enter last name")
        SetCueText(EmailTextBox, "Enter email address")
    End Sub

    Private Sub UserDetailsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim userDetails = ApplicationSettings.DeserializeUserDetails()

        FirstTextBox.Text = userDetails.FirstName
        LastNameTextBox.Text = userDetails.LastName
        EmailTextBox.Text = userDetails.EmailAddress
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

        Dim userDetails = New UserDetails With {
                .FirstName = FirstTextBox.Text,
                .LastName = LastNameTextBox.Text,
                .EmailAddress = EmailTextBox.Text}

        ApplicationSettings.SerializeUserDetails(userDetails)

        Close()

    End Sub

End Class