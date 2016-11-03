Namespace Practicals.Practical09.Forms
    Public Class P09SignUp
        Implements Forms.P09Form
        Public ReadOnly Property owner As P09UC Implements P09Form.owner

        Public Sub New(Owner As Practicals.Practical09.P09UC)
            InitializeComponent()
            Me.owner = Owner
        End Sub

        Public Sub Submitted() Implements P09Form.Submitted
            If TextBox2.Text = TextBox3.Text Then
                owner.addNewUser(TextBox1.Text, TextBox2.Text)
                owner.changeForm(New P09Default(owner))
            Else
                MsgBox("passwords do not match")
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            owner.changeForm(New P09Default(owner))
        End Sub
    End Class
End Namespace