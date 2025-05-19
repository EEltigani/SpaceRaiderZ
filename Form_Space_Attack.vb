Public Class Form_Space_Attack
    Dim MveR As Boolean 'move right
    Dim MveL As Boolean 'move left
    Dim picshooterspeed As Integer 'shooter speed
    Dim shotspeed1 As Integer 'shot speed
    Dim alienspeed1 As Integer 'aliens speed
    Dim alienDP As Integer 'alien drop
    Dim alienR(NoOfAliens) As Boolean 'number of aliens
    Dim shotdown1 As Integer 'shot down
    Dim picalien(NoOfAliens) As PictureBox 'picture of aliens
    Const NoOfAliens As Integer = 10 'number of aliens altogether
    Dim x As Integer 'x
    Dim Paused As Boolean 'pause screen
    Dim Score1 As Integer 'score
    Dim Level As Integer 'level
    Private Sub Form_Space_Attack_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then 'when the right and left keys are pressed they will be able to move
            MveR = False 'when the right and left keys are pressed they will be able to move

        End If
        If e.KeyValue = Keys.Left Then 'when the right and left keys are pressed they will be able to move
            MveL = False 'when the right and left keys are pressed they will be able to move
        End If
    End Sub
    Private Sub Form_Space_Attack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Menu_Form.Show() 'menu form will be shown
        loadaliens() 'loading aliens
        loadsettings() 'load settings
        levels() 'load of levels
        shotdown1 += 0 'shot down
        lblscore1.Text = "score of:" & shotdown1 'score hit by each alien
    End Sub
    Private Sub moveGstar()
        If MveR = True And picshooter1.Left + picshooter1.Width < Me.ClientRectangle.Width Then 'movement of the shooter
            picshooter1.Left += shotspeed1 'movement of the shooter right and shot speed
        End If
        If MveL = True And picshooter1.Left > Me.ClientRectangle.Left Then 'movement of the shooter left
            picshooter1.Left -= shotspeed1 'movement of the shooter and shot speed
        End If
    End Sub
    Private Sub firebullets()
        If picbullet1.Visible = True Then 'bullets being fired
            picbullet1.Top -= shotspeed1 'bullet being shot moves upwards
        End If
        If picbullet1.Top + picbullet1.Height < Me.ClientRectangle.Top Then 'bullet moving upwards
            picbullet1.Visible = False 'bullets that are visible moving upwards
        End If
    End Sub
    Private Sub loadsettings()
        Paused = False 'pause screen
        shotspeed1 = 6 'shot speed
        picshooterspeed = 3 'the speed of the shooter movement
        picbullet1.Visible = False 'bullet that appears visible
        For Me.x = 1 To NoOfAliens 'number of aliens
            alienR(x) = True 'number of aliens shown
        Next
        shotspeed1 = 20 'shot speed
        alienspeed1 = 7 'alien speed
        alienDP = 50 'alien drop
        shotdown1 = 0 'alien shot down
        MveL = False 'movement left
        MveR = False 'movement right
        TimerGaming.Enabled = True 'timer in game
    End Sub
    Private Sub movealien()
        For Me.x = 1 To NoOfAliens 'number of aliens
            If alienR(x) = True Then 'number of aliens shown
                picalien(x).Left += alienspeed1 'alien speed moving left
            Else
                picalien(x).Left -= alienspeed1 'alien speed moving left
            End If
            If picalien(x).Left + picalien(x).Width > Me.ClientRectangle.Width And alienR(x) = True Then 'number of aliens width
                alienR(x) = False 'number of aliens shown
                picalien(x).Top += alienDP 'number of alien drop
            End If
            If picalien(x).Left < Me.ClientRectangle.Left And alienR(x) = False Then 'picture of aliens moving left
                alienR(x) = True 'number of aliens
                picalien(x).Top += alienDP 'alien drop
            End If
        Next
    End Sub
    Private Sub checkGover()
        For Me.x = 1 To NoOfAliens 'number of aliens
            If picalien1.Top + picalien1.Height >= picshooter1.Top And picalien1.Visible = True Then 'aliens visible
                TimerGaming.Enabled = False 'timer shown
                Me.x = NoOfAliens 'number of aliens when shot
                MsgBox("game over") 'message box when the aliens reach the bottom
                playagain() 'play again box
            End If
        Next
        If shotdown1 = NoOfAliens Then 'shotdown of the aliens when they are all gone
            TimerGaming.Enabled = False 'timer
            MsgBox("Winner Winner Chicken Dinner") 'message box shown once all aliens are shot
            picbullet1.Visible = False 'no bullets must be shown after the game is complete
            playagain() 'play again box
        End If
    End Sub
    Private Sub CheckHit()
        For Me.x = 1 To NoOfAliens 'number of aliens
            If (picbullet1.Top + picbullet1.Height >= picalien(x).Top) And
                (picbullet1.Top <= picalien(x).Top + picalien(x).Height) And
                (picbullet1.Left + picbullet1.Width >= picalien(x).Left) And
                (picbullet1.Left <= picalien(x).Left + picalien(x).Width) And
                picbullet1.Visible = True And
                    picalien(x).Visible = True Then 'bullet encountering the alien
                picalien(x).Visible = False 'after the bullet hits the alien it should disappear
                picbullet1.Visible = False 'the bullet being visible after killing the alien
                shotdown1 += 1 'each alien can be shotdown once
                lblscore1.Text = "score of:" & shotdown1 'the score of each alien is shotdown
            End If
        Next
    End Sub
    Private Sub loadaliens()
        picalien(1) = picalien1 'picture alien 1
        picalien(2) = picalien2 'picture alien 2
        picalien(3) = picalien3 'picture alien 3
        picalien(4) = picalien4 'picture alien 4
        picalien(5) = picalien5 'picture alien 5
        picalien(6) = picalien6 'picture alien 6
        picalien(7) = picalien7 'picture alien 7
        picalien(8) = picalien8 'picture alien 8
        picalien(9) = picalien9 'picture alien 9
        picalien(10) = picalien10 'picture alien 10
        For Me.x = 1 To NoOfAliens 'number of aliens
            alienR(x) = True 'aliens shown
            picalien(x).Left = (-50 * x) - (x * 5) 'aliens moving left
            picalien(x).Top = 0 'aliens appearing in the top
            picalien(x).Visible = True 'picture of the alien being visible
        Next
    End Sub

    Private Sub TimerGaming_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerGaming.Tick
        moveGstar() 'movement
        firebullets() 'firing bullets
        checkGover() 'timer
        movealien() 'movement of the alien
        CheckHit() 'when the alien is hit
    End Sub

    Private Sub Form_Space_Attack_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "p" Or e.KeyChar = "p" Then 'the pause button
            If Paused = True Then 'when the pause button is paused the it will pause the game
                TimerGaming.Enabled = True 'when the pause button is paused the timer will stop
                Paused = False 'when the pause button is paused the it will pause the game
            Else
                TimerGaming.Enabled = False 'when the pause button is paused the it will pause the game
                Paused = True 'when the pause button is paused the timer will start
            End If
        End If
        If e.KeyChar = "e" Or e.KeyChar = "e" Then 'when the E button is pressed
            Me.Close() 'the game will close
        End If
    End Sub
    Private Sub playagain()
        Dim result = MsgBox("playagain", MsgBoxStyle.YesNo) 'message box will appear play again
        If result = MsgBoxResult.Yes Then 'message box appearing
            loadsettings() 'load settings
            levels() 'levels being appeared
        Else
            Me.Close() 'close the application
        End If
    End Sub
    Private Sub levels() 'the levels
        Level = Level + 1 'level 1
        If Level = 1 Then 'when its level 1
            loadaliens() 'aliens will load
            lbllevel1.Text = "level" & Level 'level number will be shown
            shotspeed1 += 10 'the shot speed
            alienspeed1 = alienspeed1 + 2 'alien speed
            alienDP = alienDP + 2 'the alien drop when shot
        End If
        If Level = 2 Then 'level 2
            loadaliens() 'load aliens
            lbllevel1.Text = "level" & Level 'level 2 will be shown
            shotspeed1 += 10 'shot speed
            alienspeed1 = alienspeed1 + 3 'alien speed
            alienDP = alienDP + 3 'alien drop
        End If
        If Level = 3 Then 'level 3
            loadaliens() 'load aliens
            lbllevel1.Text = "level:" & Level 'level 3 will be shown
            shotspeed1 += 11 'the shot speed
            alienspeed1 = alienspeed1 + 4 'the alien speed
            alienDP = alienDP + 4 'the alien drop
        End If
        If Level = 4 Then 'level 4
            loadaliens() 'load aliens
            lbllevel1.Text = "level:" & Level 'level 4 will be shown
            shotspeed1 += 12 'shot speed
            alienspeed1 = alienspeed1 + 5 'alien speed
            alienDP = alienDP + 5 'alien drop
        End If
        If Level = 5 Then 'level 5
            loadaliens() 'load aliens
            lbllevel1.Text = "level:" & Level 'level 5 wil be shown
            shotspeed1 += 13 'shot speed
            alienspeed1 = alienspeed1 + 6 'alien speed
            alienDP = alienDP + 6 'alien drop
        End If
    End Sub

    Private Sub Form_Space_Attack_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            MveR = True 'movement right
            MveL = False 'movement left
        End If

        If e.KeyValue = Keys.Left Then
            MveL = True 'movement left
            MveR = False 'movement right
        End If
        If e.KeyValue = Keys.Space And picbullet1.Visible = False Then 'space to shoot
            picbullet1.Top = picshooter1.Top 'the bullet from the shooter
            picbullet1.Left = picshooter1.Left + (picshooter1.Width / 2) - (picbullet1.Width / 2) 'shooter and the bullet
            picbullet1.Visible = True 'bullet will be visible

        End If
    End Sub
