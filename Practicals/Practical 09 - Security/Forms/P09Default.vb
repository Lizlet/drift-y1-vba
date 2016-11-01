Namespace Practicals.Practical09.Forms
    Public Class P09Default
        Implements Forms.P09Form
        Public ReadOnly Property owner As P09UC Implements P09Form.owner

        Public Sub New(Owner As Practicals.Practical09.P09UC)
            InitializeComponent()
            Me.owner = Owner
        End Sub

        Public Sub Submitted() Implements P09Form.Submitted
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace