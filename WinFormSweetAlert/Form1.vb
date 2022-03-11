Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        msgQuestion("ang tanung")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.BackColor = Color.FromArgb(80, Color.White)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("\\172.29.3.142\qa2 data system files\System Installer\QA2 Data System\P2 QA2 Data System.application")
    End Sub
End Class
