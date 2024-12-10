Public Class frmTriangle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click

        'Créer les variables
        Dim dbBase As Double
        Dim dbHauteur As Double
        Dim dbReponse As Double

        dbBase = Val(txtBase.Text)
        dbHauteur = Val(txtHauteur.Text)

        dbReponse = (dbBase * dbHauteur) / 2

        'Affiche la réponse
        lblPhrase.Text = "L'aire du triangle est de " + Format(dbReponse, "0.00") + " cm2"
    End Sub

    'Réinitialise la calculatrice 
    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        lblPhrase.Text = ""
        txtBase.Text = ""
        txtHauteur.Text = ""
    End Sub

    'Retour au menu principal
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        lblPhrase.Text = ""
        txtBase.Text = ""
        txtHauteur.Text = ""
        Me.Hide()
        frmMenuPrincipal.Show()
    End Sub

    'Si on ferme la fenetre le menu principal apparait
    Private Sub frmTriangle_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenuPrincipal.Show()
    End Sub

End Class