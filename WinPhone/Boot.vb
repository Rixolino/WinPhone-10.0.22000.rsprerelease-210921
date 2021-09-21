Public Class Boot
    Dim n As Integer
    Private Sub Boot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        n += 1
        Select Case n
            Case 1
                Label1.Visible = True
                Label1.Text = "Windows Phone X is booting"
            Case 2
                Label1.Visible = True
                Label1.Text = "Windows Phone X is booting"
            Case 3
                Label1.Visible = True
                Label1.Text = "Windows Phone X is booting."
            Case 4
                Label1.Visible = True
                Label1.Text = "Windows Phone X is booting.."
            Case 5
                Label1.Visible = True
                Label1.Text = "Windows Phone X is booting..."
            Case 6
                Me.Close()
                WinBooting.Show()
        End Select
    End Sub
End Class