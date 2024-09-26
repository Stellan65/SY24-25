Imports System.DirectoryServices

Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles MovementTimer.Tick
        follow(Enemy2, Avatar, 3, 3)
        follow(Enemy3, Avatar, 4, 4)
        PaceX(Enemy, Platform, 5)

    End Sub
    Sub PaceX(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, dir * speed, 0)

        If e.Location.X > p.Location.X + p.Width - 30 Then
            e.Tag = dir * -1
        End If
        If e.Location.X < p.Location.X Then
            e.Tag = dir * -1
        End If
    End Sub

    Sub PaceY(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag

        move(e, 0, dir * speed)

        If e.Location.Y < p.Location.Y Then
            e.Tag = dir * -1
        End If
        If e.Location.Y > p.Location.Y + p.Height Then
            e.Tag = dir * -1
        End If
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
            move(Avatar, 20, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(Avatar, -20, 0)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(Avatar, 0, -20)
        End If
        If e.KeyCode = Keys.Space Then
            Avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(Avatar, 0, 20)
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

    Private Sub Avatar_Click(sender As Object, e As EventArgs) Handles Avatar.Click

    End Sub

    Private Sub Score_Click(sender As Object, e As EventArgs) Handles ScoreLabel.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles ScoreTimer.Tick

    End Sub
End Class


