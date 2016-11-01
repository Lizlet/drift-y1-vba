Namespace Practicals.Practical09
    Public Class P09UC
        Implements drift_y1_vba.Practicals.Task
        Private ReadOnly Property Owner As Form1
        Public ReadOnly Property title As String = "Practical 09: Security" Implements Task.title

        Public Sub New(Owner As Form)
            InitializeComponent()
            Me.Owner = Owner
        End Sub

        Public Sub Submitted() Implements Task.Submitted
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
