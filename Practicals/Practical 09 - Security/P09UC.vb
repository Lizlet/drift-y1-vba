Namespace Practicals.Practical09
    Public Class P09UC
        Implements drift_y1_vba.Practicals.Task
        Private ReadOnly Property Owner As Form1
        Public ReadOnly Property title As String = "Practical 09: Security" Implements Task.title
        Private Property currentForm As Forms.P09Form
        Private Property userList As Users.UserList = New Users.UserList

        Public Sub New(Owner As Form)
            InitializeComponent()
            Me.Owner = Owner
            Me.currentForm = New Forms.P09Default(Me)
            Me.Controls.Add(currentForm)
        End Sub

        Public Sub Submitted() Implements Task.Submitted
            currentForm.Submitted()
        End Sub

        Public Sub changeForm(newForm As Forms.P09Form)
            Me.Controls.Clear()
            currentForm = newForm
            Me.Controls.Add(newForm)
        End Sub

        Public Sub addNewUser(username As String, password As String)
            userList.AddUser(username, PracCrypto.hashAndSalt(password))
        End Sub
    End Class
End Namespace
