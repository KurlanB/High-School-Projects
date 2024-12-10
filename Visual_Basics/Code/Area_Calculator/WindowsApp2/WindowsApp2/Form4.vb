Public Class frmCercle
    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click
        'Créer les variables
        Dim dbDimension As Double
        Dim dbReponse As Double

        dbDimension = Val(txtDimension.Text)

        dbReponse = dbDimension ^ 2 * 3.1416

        'Affiche la réponse
        lblPhrase.Text = "L'aire du cercle est de " + Format(dbReponse, "0.00") + " cm2"

    End Sub

    'Réinitialise la calculatrice
    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        txtDimension.Text = ""
        lblPhrase.Text = ""
    End Sub

    'Retour au menu principal
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        txtDimension.Text = ""
        lblPhrase.Text = ""
        Me.Hide()
        frmMenuPrincipal.Show()

    End Sub

    'Si on ferme la fenetre le menu principal apparait
    Private Sub frmCercle_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenuPrincipal.Show()
    End Sub
End Class