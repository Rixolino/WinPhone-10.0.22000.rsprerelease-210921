Public Class Shutdown
    Dim n As Integer
    Private Sub Shutdown_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        n += 1
        Select Case n
            Case 1
                Label1.Visible = True
                Label1.Text = "The system is shutting down"
            Case 2
                Label1.Visible = True
                Label1.Text = "The system is shutting down"
            Case 3
                Label1.Visible = True
                Label1.Text = "The system is shutting down."
            Case 4
                Label1.Visible = True
                Label1.Text = "The system is shutting down.."
            Case 5
                Label1.Visible = True
                Label1.Text = "The system is shutting down..."
            Case 6
                Application.Exit()
        End Select
    End Sub
End Class