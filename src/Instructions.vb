Public Class Instructions

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        Me.Close() 'to close the following menu form before displaying the instructions form
        Menu_Form.Show() 'to proceed to the menu form
    End Sub

    Private Sub btnquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnquit.Click
        Close() 'to close the instructions form
    End Sub
End Class