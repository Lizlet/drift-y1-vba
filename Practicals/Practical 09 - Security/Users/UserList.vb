Namespace Practicals.Practical09.Users
    Public Class UserList
        Private users As New Dictionary(Of String, User)

        Public Sub AddUser(username As String, password As PracCrypto.Password)
            If users.ContainsKey(username) Then
                MsgBox("that username is already taken")
            Else
                users.Add(username, New User(username, password))
            End If
        End Sub
    End Class
End Namespace