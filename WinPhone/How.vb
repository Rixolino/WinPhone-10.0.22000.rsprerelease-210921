Public Class How
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Help.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        IEg.Show()
        Mailg.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Mailg.Show()
        IEg.Hide()
    End Sub

    Private Sub CloseT_Click(sender As Object, e As EventArgs) Handles CloseT.Click
        Mailg.Hide()
        IEg.Hide()
    End Sub
End Class