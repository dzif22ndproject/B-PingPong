Public Class Form6
    Dim dx = 15, dy = -15
    Dim reply As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        PictureBox1.Left += dx
        PictureBox1.Top += dy
        If PictureBox1.Left < 0 Then
            dx = -1 * dx
        End If
        If PictureBox1.Top < 0 Then
            dy = -1 * dy
        End If
        If PictureBox1.Left >= PictureBox2.Left And PictureBox1.Left <= PictureBox2.Left + PictureBox2.Width And PictureBox1.Top + PictureBox1.Height > PictureBox2.Top Then
            dy = -1 * dy
            Label2.Text += 10
            If Label2.Text = 100 Then
                dx = 0 * dx
                dy = 0 * dy
                Timer1.Enabled = False
                reply = MsgBox("你贏了，要繼續挑戰嗎?", 32 + 4, "you win")
                If reply = 6 Then
                    Label2.Text = 0
                    Form1.Visible = True
                    Me.Close()
                Else
                    Me.Close()
                    Form2.Close()
                    Form1.Close()
                End If
            End If
        End If
        If PictureBox1.Top >= PictureBox3.Top And PictureBox1.Top <= PictureBox3.Top + PictureBox3.Height And PictureBox1.Left + PictureBox1.Width > PictureBox3.Left Then
            dx = -1 * dx
            Label2.Text += 10
            If Label2.Text = 100 Then
                dx = 0 * dx
                dy = 0 * dy
                Timer1.Enabled = False
                reply = MsgBox("你贏了，要繼續挑戰嗎?", 32 + 4, "you win")
                If reply = 6 Then
                    Label2.Text = 0
                    Form1.Visible = True
                    Me.Close()
                Else
                    Me.Close()
                    Form2.Close()
                    Form1.Close()
                End If
            End If
        End If
        If PictureBox1.Top + PictureBox1.Height > Me.Height - PictureBox1.Height Then
            PictureBox1.Visible = False
            Timer1.Enabled = False
            reply = MsgBox("你輸了，重玩嗎?", 32 + 4, "gane over")
            If reply = 6 Then
                Form1.Visible = True
                Me.Close()
            Else
                Me.Close()
                Form2.Close()
                Form1.Close()
            End If
        End If
        If PictureBox1.Left + PictureBox1.Width > Me.Left + Me.Width - PictureBox1.Width Then
            PictureBox1.Visible = False
            Timer1.Enabled = False
            reply = MsgBox("你輸了，重玩嗎?", 32 + 4, "gane over")
            If reply = 6 Then
                Form1.Visible = True
                Me.Close()
            Else
                Me.Close()
                Form2.Close()
                Form1.Close()
            End If
        End If
    End Sub
    Private Sub Form6_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            PictureBox2.Left -= 20
        End If
        If e.KeyCode = Keys.Up Then
            PictureBox3.Top -= 20
        End If
        If e.KeyCode = Keys.Right Then
            PictureBox2.Left += 20
        End If
        If e.KeyCode = Keys.Down Then
            PictureBox3.Top += 20
        End If
        If PictureBox2.Left < 0 - PictureBox2.Width Then
            PictureBox2.Left = Me.Width - 20
        End If
        If PictureBox3.Top < 0 - PictureBox3.Height Then
            PictureBox3.Top = Me.Height - 20
        End If
        If PictureBox2.Left > Me.Width - 20 Then
            PictureBox2.Left = 0 - PictureBox2.Width
        End If
        If PictureBox3.Top > Me.Height - 20 Then
            PictureBox3.Top = 0 - PictureBox3.Height
        End If
    End Sub
End Class