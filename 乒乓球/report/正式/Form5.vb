Public Class Form5
    Dim dx = -20, dy = -20, dz = 20, dw = 20
    Dim reply As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = True
        PictureBox1.Left += dx
        PictureBox1.Top += dy
        PictureBox3.Left += dz
        PictureBox3.Top += dw
        If PictureBox1.Left < 0 Then
            dx = -1 * dx
        End If
        If PictureBox3.Left < 0 Then
            dz = -1 * dz
        End If
        If PictureBox1.Top < 0 Then
            dy = -1 * dy
        End If
        If PictureBox3.Top < 0 Then
            dw = -1 * dw
        End If
            If PictureBox1.Left + PictureBox1.Width > Me.Width - PictureBox1.Width Then
                dx = -1 * dx
            End If
            If PictureBox3.Left + PictureBox3.Width > Me.Width - PictureBox3.Width Then
            dz = -1 * dz
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
        If PictureBox3.Left >= PictureBox2.Left And PictureBox3.Left <= PictureBox2.Left + PictureBox2.Width And PictureBox3.Top + PictureBox3.Height > PictureBox2.Top Then
            dw = -1 * dw
            Label2.Text += 10
                If Label2.Text = 100 Then
                dz = 0 * dz
                dw = 0 * dw
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
        If PictureBox3.Top + PictureBox3.Height > Me.Height - PictureBox3.Height Then
            PictureBox3.Visible = False
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
    Private Sub Form5_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left Then
            PictureBox2.Left -= 20
        End If
        If e.KeyCode = Keys.Right Then
            PictureBox2.Left += 20
        End If
        If PictureBox2.Left < 0 - PictureBox2.Width Then
            PictureBox2.Left = Me.Width - 20
        End If
        If PictureBox2.Left > Me.Width - 20 Then
            PictureBox2.Left = 0 - PictureBox2.Width
        End If
    End Sub
End Class