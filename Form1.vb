Public Class Form1

    Public Sub New()
        InitializeComponent()

        With Me
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .AutoSize = True

            With .contentPanel
                .AutoSizeMode = AutoSizeMode.GrowAndShrink
                .AutoSize = True
            End With
        End With
    End Sub

    Private Sub SubmitTSMI_Click(sender As Object, e As EventArgs) Handles SubmitTSMI.Click

    End Sub
End Class
