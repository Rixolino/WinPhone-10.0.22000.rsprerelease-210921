Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Boot.Show()
        Me.Hide()
        Help.Close()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Help.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Website.Click
        Process.Start("https://windowsphoneconceptemu.wordpress.com/")
    End Sub
End Class
