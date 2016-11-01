Namespace Practicals
    Public Class Constructor
        Public Shared Function InstantiateTask(owner As Form1, sender As ToolStripMenuItem) As Practicals.Task
            Dim newTask As Practicals.Task = nothing

            Select Case sender.Text
                Case "09 - Password handling"
                    newTask = New Practicals.Practical09.P09UC(owner)
                Case Else
                    Throw New ArgumentOutOfRangeException("Sender.Text is not among the allowed values")
            End Select
            Return newTask
        End Function
    End Class

End Namespace