Public Class frmTrapeze
    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click
        'Créer les variables
        Dim dbGrandeB As Double
        Dim dbPetiteB As Double
        Dim dbHauteur As Double
        Dim dbReponse As Double

        dbGrandeB = Val(txtGrandeB.Text)
        dbPetiteB = Val(txtPetiteb.Text)
        dbHauteur = Val(txtHauteur.Text)

        dbReponse = ((dbGrandeB + dbPetiteB) / 2) * dbHauteur

        'Affiche la réponse
        lblPhrase.Text = "L'aire du trapèze est de " + Format(dbReponse, "0.00") + " cm2"

    End Sub

    'Réinitialise la calculatrice
    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        txtGrandeB.Text = ""
        txtPetiteb.Text = ""
        txtHauteur.Text = ""
        lblPhrase.Text = ""
    End Sub

    'Retour au menu principal
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        txtGrandeB.Text = ""
        txtPetiteb.Text = ""
        txtHauteur.Text = ""
        lblPhrase.Text = ""
        Me.Hide()
        frmMenuPrincipal.Show()
    End Sub

    'Si on ferme la fenetre le menu principal apparait
    Private Sub frmTrapeze_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenuPrincipal.Show()
    End Sub
End Class