Public Class Narrative

    Private Sub Narrative_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close() 'to close the narrative form
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Close() 'to close the following menu form before displaying the instructions form
        Menu_Form.Show() 'to proceed to the menu form
    End Sub
End Class