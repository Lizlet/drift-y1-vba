Namespace Practicals.Practical09.Forms
    Public Class P09SignUp
        Implements Forms.P09Form
        Public ReadOnly Property owner As P09UC Implements P09Form.owner

        Public Sub New(Owner As Practicals.Practical09.P09UC)
            InitializeComponent()
            Me.owner = Owner
        End Sub

        Public Sub Submitted() Implements P09Form.Submitted
            If TextBox1.TextLength <= 4 Then
                MsgBox("username too short")
            ElseIf TextBox2.TextLength <= 4 Then
                MsgBox("Password too short")
            ElseIf TextBox2.Text = TextBox3.Text Then
                owner.addNewUser(TextBox1.Text, TextBox2.Text)
                owner.changeForm(New P09Default(owner))
            Else
                MsgBox("passwords do not match")
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            owner.changeForm(New P09Default(owner))
        End Sub

        Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
            If TextBox2.TextLength <= 4 Then
                TextBox2.BackColor = Color.Red
            Else
                TextBox2.BackColor = Color.White
            End If
        End Sub

        Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
            If TextBox3.TextLength <= 4 Or TextBox3.TextLength < TextBox2.TextLength Then
                TextBox3.BackColor = Color.Red
            Else
                TextBox3.BackColor = Color.White
            End If
        End Sub
    End Class
End Namespace