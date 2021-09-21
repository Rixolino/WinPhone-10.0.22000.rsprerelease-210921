Public Class Help
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Label5.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        How.Show()
    End Sub
End Class