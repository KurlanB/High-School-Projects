Public Class frmQuantite

    Private Sub btnConvertirL_Click(sender As Object, e As EventArgs) Handles btnConvertirL.Click
        'Créer les variables
        Dim dblLitres As Double
        Dim dblToGallons As Double

        Const dblLaG As Double = 0.22

        dblLitres = Val(txtLitres.Text)

        dblToGallons = dblLitres * dblLaG
        'Affiche la réponse
        MsgBox(dblLitres.ToString + " Litres devient " + Format(dblToGallons, "0.00") + " Gallons", MsgBoxStyle.OkOnly, "Litres à gallons")
        'Efface le textbox
        If MsgBoxResult.Ok Then
            txtLitres.Text = ""
        End If
    End Sub

    Private Sub btnConvertirG_Click(sender As Object, e As EventArgs) Handles btnConvertirG.Click
        'Créer les variables
        Dim dblGallons As Double
        Dim dblToLitres As Double

        Const dblGaL As Double = 4.54

        dblGallons = Val(txtGallons.Text)

        dblToLitres = dblGallons * dblGaL
        'Affiche la réponse
        MsgBox(dblGallons.ToString + " Gallons devient " + Format(dblToLitres, "0.00") + " Litres", MsgBoxStyle.OkOnly, "Gallons à Litres")
        'Efface le textbox
        If MsgBoxResult.Ok Then
            txtGallons.Text = ""
        End If
    End Sub
    'Retour au menu principal
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
        frmPageAcceuil.Show()
    End Sub
    'Si on ferme la fenetre le menu principal apparait
    Private Sub frmQuantite_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmPageAcceuil.Show()
    End Sub

    Private Sub frmQuantite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class