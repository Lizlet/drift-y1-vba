Public Class Form1
    Private currentTask As Practicals.Task

    Public Sub New()
        InitializeComponent()
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.AutoSize = True
        Me.contentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.contentPanel.AutoSize = True
        Me.contentPanel.Controls.Add(Practicals.Constructor.InstantiateTask(Me, P09TSMI))
    End Sub

    Private Sub SubmitTSMI_Click(sender As Object, e As EventArgs) Handles SubmitTSMI.Click

    End Sub

    Private Sub TaskTSMI_Click(sender As ToolStripMenuItem, e As EventArgs) Handles _
        P09TSMI.Click

        Dim currentTask As Practicals.Task = Practicals.Constructor.InstantiateTask(Me, sender)
        Me.contentPanel.Controls.Clear()
        Me.contentPanel.Controls.Add(currentTask)
        Me.currentTask = currentTask
    End Sub
End Class
