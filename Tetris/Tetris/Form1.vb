Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(Enemy, Avatar, 5, 5)
        follow(Enemy2, Avatar, 7, 7)
        follow(Enemy3, Avatar, 9, 9)
    End Sub
    Sub follow(e As PictureBox, a As PictureBox, xspeed As Integer, yspeed As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, yspeed)
        Else
            move(e, 0, -yspeed)
        End If

        If e.Location.X < a.Location.X Then
            move(e, xspeed, 0)
        Else
            move(e, -xspeed, 0)
        End If
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(Avatar, 50, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -50, 0)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -50)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 50)
        End If
        Avatar.Refresh()
        If Avatar.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            PictureBox2.Visible = False
        End If
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles Enemy.Click

    End Sub
End Class


