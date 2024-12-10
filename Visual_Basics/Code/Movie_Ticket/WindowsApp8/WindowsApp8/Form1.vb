'Nom : Kurlan Beeharry
'Nom du projet : Guichet Cinéma
'Date : 5/6/2021
'Date des derniers modifications : 9/6/2021


Public Class frmBienvenue
    'Creer une variable pour confirmer si paiement est debloque
    Public boolPaiement As Boolean = False

    'Quand on appuie sur chaque boutons le Panel affiche le bon form
    Private Sub btnAccueil_Click(sender As Object, e As EventArgs) Handles btnAccueil.Click
        pnlAffiche.Controls.Clear()
        frmAccueil.TopLevel = False
        Me.pnlAffiche.Controls.Add(frmAccueil)
        frmAccueil.Show()
    End Sub

    Private Sub btnChoix_Click(sender As Object, e As EventArgs) Handles btnChoix.Click
        pnlAffiche.Controls.Clear()
        frmChoix.TopLevel = False
        Me.pnlAffiche.Controls.Add(frmChoix)
        frmChoix.Show()
    End Sub


    Private Sub btnPaiement_Click(sender As Object, e As EventArgs) Handles btnPaiement.Click
        'Si paiement n'est pas debloque on ne peut pas y acceder
        If boolPaiement = True Then
            pnlAffiche.Controls.Clear()
            frmPay.TopLevel = False
            Me.pnlAffiche.Controls.Add(frmPay)
            frmPay.Show()
        Else
            MsgBox("Vous n'avez pas encore terminer la sélection de film, d'heure ou de billets", MsgBoxStyle.OkOnly, "Paiement")
        End If

    End Sub
    'Faire que le frmaAccueil s'affiche toujours quand on lance le programme 
    Private Sub frmBienvenue_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlAffiche.Controls.Clear()
        frmAccueil.TopLevel = False
        Me.pnlAffiche.Controls.Add(frmAccueil)
        frmAccueil.Show()
    End Sub


End Class
