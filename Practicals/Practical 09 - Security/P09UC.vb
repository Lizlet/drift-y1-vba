Namespace Practicals
    Public Class P09UC
        Implements drift_y1_vba.Practicals.Task

        Private Class UserList

            Private Class User
                Public Property login As String
                Private Property password As String
                Private Property salt As String

                ''' <summary>
                ''' Creates a new instance of User
                ''' </summary>
                ''' <param name="login">login-name of the user, commonly called username</param>
                ''' <param name="password">password of the user, must be hashed at this point</param>
                ''' <param name="salt">salt, unhashed</param>
                Private Sub New(login As String, password As String, salt As String)
                    Me.login = login
                    Me.password = password
                    Me.salt = salt
                End Sub
            End Class
        End Class

        Public ReadOnly Property title As String Implements Task.title
            Get
                Return "Practical 09: Security"
            End Get
        End Property
        Public ReadOnly Property Owner As Form1

        Public Sub New(Owner As Form1)
            Me.Owner = Owner
            Me.Owner.SubmitTSMI.Enabled = False
        End Sub

        Public Sub Submitted() Implements Task.Submitted
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
