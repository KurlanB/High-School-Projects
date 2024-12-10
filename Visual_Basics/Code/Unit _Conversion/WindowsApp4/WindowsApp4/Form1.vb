'Nom : Kurlan Beeharry
'Nom du programme : Conversion des mesures
'Date : 5 mai 2021
'Date des dernières modifications : 5 mai 2021

Public Class frmPageAcceuil
    'Affiche les fenetres quand un bouton est cliquer
    Private Sub btnQuantite_Click(sender As Object, e As EventArgs) Handles btnQuantite.Click
        Me.Hide()
        frmQuantite.Show()
    End Sub

    Private Sub btnTemperature_Click(sender As Object, e As EventArgs) Handles btnTemperature.Click
        Me.Hide()
        frmTemperature.Show()
    End Sub

    Private Sub btnPoids_Click(sender As Object, e As EventArgs) Handles btnPoids.Click
        Me.Hide()
        frmPoids.Show()
    End Sub

    Private Sub btnDistance_Click(sender As Object, e As EventArgs) Handles btnDistance.Click
        Me.Hide()
        frmDistance.Show()
    End Sub

    Private Sub btnLongueur_Click(sender As Object, e As EventArgs) Handles btnLongueur.Click
        Me.Hide()
        frmLongueur.Show()
    End Sub
    'Termine le programme quand on appuie sur "Quitter"
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        End
    End Sub

End Class
