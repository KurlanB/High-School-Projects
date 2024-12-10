
'Nom : Kurlan Beeharry
'Nom du programme : Les Figures Planes
'Date : 27 Avril 2021
'Date des dernières modifications : 30 Avril 2021

Public Class frmMenuPrincipal

    'Affiche chaque forme quand on clique sur les boutons
    Private Sub btnCarre_Click(sender As Object, e As EventArgs) Handles btnCarre.Click
        Me.Hide()
        frmAireduCarre.Show()
    End Sub

    Private Sub btnTrapeze_Click(sender As Object, e As EventArgs) Handles btnTrapeze.Click
        Me.Hide()
        frmTrapeze.Show()
    End Sub

    Private Sub btnCercle_Click(sender As Object, e As EventArgs) Handles btnCercle.Click
        Me.Hide()
        frmCercle.Show()
    End Sub

    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        Me.Hide()
        frmTriangle.Show()
    End Sub

    'Quand on appuit sur le bouton "Quitter" le programme s'arrète
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        End
    End Sub
End Class