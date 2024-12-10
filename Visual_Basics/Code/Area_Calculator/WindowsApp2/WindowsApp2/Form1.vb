Public Class frmAireduCarre
    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click
        'Créer les variables
        Dim decDimension As Decimal
        Dim decReponse As Decimal

        decDimension = Val(txtDimension.Text)
        decReponse = decDimension ^ 2

        'Affiche la réponse
        lblReponseN.Text = "L'aire du carré est de " + decReponse.ToString + " cm2"
    End Sub

    'Réinitialise la calculatrice
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblReponseN.Text = ""
        txtDimension.Text = ""
    End Sub

    'Si on ferme la fenetre le menu principal apparait
    Private Sub frmAireduCarre_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenuPrincipal.Show()

    End Sub

    'Retour au menu principal
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        lblReponseN.Text = ""
        txtDimension.Text = ""
        Me.Hide()
        frmMenuPrincipal.Show()

    End Sub

End Class
