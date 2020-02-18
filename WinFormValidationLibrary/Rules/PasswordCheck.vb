Imports System.ComponentModel.DataAnnotations
Imports System.Text.RegularExpressions

Namespace Rules
    ''' <summary>
    ''' Specialized class to validate a password
    ''' </summary>
    Public Class PasswordCheck
        Inherits ValidationAttribute

        Public Overrides Function IsValid(value As Object) As Boolean

            Dim validPassword = False
            Dim reason = String.Empty

            Dim password As String = If(value Is Nothing, String.Empty, value.ToString())

            If String.IsNullOrWhiteSpace(password) OrElse password.Length < 6 Then
                reason = "new password must be at least 6 characters long. "
            Else
                Dim pattern As New Regex("((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")
                If Not pattern.IsMatch(password) Then
                    reason &= "Your new password must contain at least 1 symbol character and number."
                Else
                    validPassword = True
                End If
            End If

            If validPassword Then
                Return True
            Else
                Return False
            End If

        End Function

    End Class
    '-------------------------------------------------------------------------------
    ' Pattern used above
    '-------------------------------------------------------------------------------
    ' (			        # Start of group
    '   (?=.*\d)	    #   must contains one digit from 0-9
    '   (?=.*[a-z])		#   must contains one lowercase characters
    '   (?=.*[A-Z])		#   must contains one uppercase characters
    '   (?=.*[@#$%])	#   must contains one special symbols in the list "@#$%"
    '              .	#     match anything with previous condition checking
    '           {6,20}	#        length at least 6 characters and maximum of 20	
    ')			        # End of group
    '-------------------------------------------------------------------------------




End Namespace