Public Class Menu_Form

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Form_Space_Attack.Show() 'will show the main game
    End Sub

    Private Sub btnInstructions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstructions.Click
        Instructions.Show() 'show the instructions
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Close() 'close the program
    End Sub

    Private Sub Menu_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        Me.Close() 'close the program
        Settings.Show() 'show settings
    End Sub

    Private Sub btnNarrative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNarrative.Click
        Narrative.Show()
    End Sub
End Class