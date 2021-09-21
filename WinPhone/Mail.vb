Public Class Mail

    Private Sub Mail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Now.Hour & ":" & Now.Minute
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Phone.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Apps.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Process.Start("mailto:wpconceptemu@outlook.com")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        WebView21.GoBack()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        WebView21.GoForward()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("mailto:wpconceptemu@outlook.com")
    End Sub
End Class