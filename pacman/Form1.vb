
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pacmanImage.Top = pacman.Top - 15
        pacmanImage.Left = pacman.Left - 15
        pacmanImage.BringToFront()
        Timer.Interval = 10
        Timer.Start()
        direction = "Right"
        paths = {path1, path2, path3}
        onPath = False
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Is = Keys.Right
                direction = "Right"
                Timer.Start()
            Case Is = Keys.Left
                direction = "Left"
                Timer.Start()
            Case Is = Keys.Up
                direction = "Up"
                Timer.Start()
                checkIntersec
            Case Is = Keys.Down
                direction = "Down"
                Timer.Start()
        End Select

    End Sub

    Sub TimerEventProcessor(myObject As Object, ByVal myEventArgs As EventArgs) Handles Timer.Tick
        If direction = "Right" Then
            moveRight()
        ElseIf direction = "Left" Then
            moveLeft()
        ElseIf direction = "Up" Then
            moveUp()
        ElseIf direction = "Down" Then
            moveDown()
        End If
    End Sub

    Sub moveRight()
        pacman.Left += 1
        For Each path In paths
            If pacman.Bounds.IntersectsWith(path.Bounds) = True Then
                onPath = True
            End If
        Next
        If onPath = False Then
            pacman.Left -= 1
            Timer.Stop()
        End If
        pacmanImage.Top = pacman.Top - 15
        pacmanImage.Left = pacman.Left - 15
        onPath = False
    End Sub

    Sub moveLeft()
        pacman.Left -= 1
        For Each path In paths
            If pacman.Bounds.IntersectsWith(path.Bounds) = True Then
                onPath = True
            End If
        Next
        If onPath = False Then
            pacman.Left += 1
            Timer.Stop()
        End If
        pacmanImage.Top = pacman.Top - 15
        pacmanImage.Left = pacman.Left - 15
        onPath = False
    End Sub

    Sub moveUp()
        pacman.Top -= 1
        For Each path In paths
            If pacman.Bounds.IntersectsWith(path.Bounds) = True Then
                onPath = True
            End If
        Next
        If onPath = False Then
            pacman.Top += 1
            Timer.Stop()
        End If
        pacmanImage.Top = pacman.Top - 15
        pacmanImage.Left = pacman.Left - 15
        onPath = False
    End Sub

    Sub moveDown()
        pacman.Top += 1
        For Each path In paths
            If pacman.Bounds.IntersectsWith(path.Bounds) = True Then
                onPath = True
            End If
        Next
        If onPath = False Then
            pacman.Top -= 1
            Timer.Stop()
        End If
        pacmanImage.Top = pacman.Top - 15
        pacmanImage.Left = pacman.Left - 15
        onPath = False
    End Sub


    Sub checkIntersec()
        If pacman.Bounds.IntersectsWith(intersec1.Bounds) Then

        End If
    End Sub
End Class