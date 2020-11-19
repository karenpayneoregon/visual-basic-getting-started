Imports WinFormValidationLibrary.LanguageExtensions
Imports WinFormValidationLibrary.Validators

Public Class Form1
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) _
        Handles ValidateButton.Click

        Dim product As New Products With {
                .ProductName = ProductNameTextBox.Text,
                .UnitPrice = UnitPriceTextBox.AsDecimal}

        Dim validationResult As EntityValidationResult = ValidationHelper.ValidateEntity(product)
        If validationResult.HasError Then
            MessageBox.Show(validationResult.ErrorMessageList())
        End If

    End Sub
End Class
