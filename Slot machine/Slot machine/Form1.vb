Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Int(9 * Rnd() + 1)
        Label2.Text = Int(9 * Rnd() + 1)
        Label3.Text = Int(9 * Rnd() + 1)

        Label5.Text = Label5.Text - 1

        If Label1.Text = Label2.Text And Label3.Text Then
            MsgBox("ma, je wint een muntje")
            Label5.Text = Label5.Text + 1
        End If

        If Label5.Text = -10 Then
            MsgBox("out of coins")
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Form1_load(Sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Label5.Text = 10
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Button1.Enabled = True
        Label5.Text = 10
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub
End Class
