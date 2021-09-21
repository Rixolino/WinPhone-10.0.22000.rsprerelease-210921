Public Class WinBooting
    Dim n As Integer
    Private Sub WinBooting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        n += 1
        Select Case n
            Case 1
                Label1.Visible = True
                Label1.Text = "Windows is booting up"
            Case 2
                Label1.Visible = True
                Label1.Text = "Windows is booting up"
            Case 3
                Label1.Visible = True
                Label1.Text = "Windows is booting up."
            Case 4
                Label1.Visible = True
                Label1.Text = "Windows is booting up.."
            Case 5
                Label1.Visible = True
                Label1.Text = "Windows is booting up..."
            Case 6
                Me.Close()
                Lock.Show()
        End Select
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class