Namespace Practicals.Practical09.Forms
    Public Class P09SignIn
        Implements Forms.P09Form
        Public ReadOnly Property owner As P09UC Implements P09Form.owner

        Public Sub New(Owner As Practicals.Practical09.P09UC)
            InitializeComponent()
            Me.owner = Owner
        End Sub

        Public Sub Submitted() Implements P09Form.Submitted
            owner.login(TextBox1.Text, TextBox2.Text)
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            owner.changeForm(New P09Default(owner))
        End Sub

        Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles _
                TextBox1.KeyDown, TextBox2.KeyDown
            If e.KeyCode = Keys.Enter Then
                Me.Submitted()
            End If
        End Sub

        Private Sub P09SignIn_Load(sender As Object, e As EventArgs) Handles Me.Load
            TextBox1.Focus()
        End Sub
    End Class
End Namespace