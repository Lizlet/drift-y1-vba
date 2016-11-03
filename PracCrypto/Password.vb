Namespace PracCrypto
    Public Class Password
        Private ReadOnly hash As String
        Private ReadOnly salt As String

        Public Sub New(hash As String, salt As String)
            Me.hash = hash
            Me.salt = salt
            MsgBox(Me.hash)
        End Sub

        Public Function CheckPassword(password As String) As Boolean
            Dim passwordHash = PracCrypto.checkPassword(password, salt)
            Return passwordHash.Equals(Me.hash)
        End Function
    End Class
End Namespace