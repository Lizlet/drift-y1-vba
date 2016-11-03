Namespace Practicals.Practical09.Users
    Public Class User
        Public ReadOnly username As String
        Private ReadOnly password As PracCrypto.Password

        Public Sub New(username As String, password As PracCrypto.Password)
            Me.username = username
            Me.password = password
        End Sub

        Public Function authenticate(username As String, password As String)
            Return (username = Me.username) And Me.password.CheckPassword(password)
        End Function
    End Class
End Namespace