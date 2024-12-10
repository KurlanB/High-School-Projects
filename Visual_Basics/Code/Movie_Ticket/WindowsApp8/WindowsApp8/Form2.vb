Public Class frmAccueil
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnChoisir.Click
        'Quand on clique sur le bouton ça affiche le prochain form
        frmBienvenue.pnlAffiche.Controls.Clear()
        frmChoix.TopLevel = False
        frmBienvenue.pnlAffiche.Controls.Add(frmChoix)
        frmChoix.Show()
    End Sub

    Private Sub pnlAccueil_Paint(sender As Object, e As PaintEventArgs) Handles pnlAccueil.Paint

    End Sub
End Class