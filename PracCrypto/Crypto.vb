Imports System.Security.Cryptography
Imports System.Text

Namespace PracCrypto
    Public Module Crypto
        Public Function randomSalt() As String
            Dim salt As String = ""
            Dim allowedDigits As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" &
                                          "abcdefghijklmnopqrstuvwxyz" &
                                          "0123456789"
            Dim rand As New Random()
            For i As Integer = 0 To 50
                salt &= allowedDigits.Substring(rand.Next(allowedDigits.Length), 1)
            Next
            Return salt
        End Function

        Public Function hashAndSalt(password As String) As PracCrypto.Password
            Dim salt As String = PracCrypto.randomSalt
            Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
            Dim hashType As HashAlgorithm = New SHA256Managed()
            Dim hashBytes As Byte() = hashType.ComputeHash(passwordBytes)

            Return New PracCrypto.Password(Convert.ToBase64String(hashBytes), salt)
        End Function

        Public Function checkPassword(password As String, salt As String) As String
            Dim passwordBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
            Dim hashType As HashAlgorithm = New SHA256Managed()
            Dim hashBytes As Byte() = hashType.ComputeHash(passwordBytes)

            Return Convert.ToBase64String(hashBytes)
        End Function
    End Module
End Namespace