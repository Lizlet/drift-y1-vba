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

        Public Sub login(username As String, password As String)
            If users.ContainsKey(username) Then
                If users.Item(username).authenticate(username, password) Then
                    MsgBox("lets say you logged in now as " & users.Item(username).username)
                Else
                    MsgBox("username or password do not match")
                End If
            Else
                MsgBox("username or password do not match")
            End If
        End Sub
    End Class
End Namespace