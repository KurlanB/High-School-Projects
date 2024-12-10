Public Class frmDistance
    Private Sub btnConvertirL_Click(sender As Object, e As EventArgs) Handles btnConvertirkm.Click
        'Créer les variables
        Dim dblkm As Double
        Dim dblkmTomile As Double

        dblkm = Val(txtkm.Text)

        dblkmTomile = dblkm * 0.62
        'Affiche la réponse
        MsgBox(dblkm.ToString + " km devient " + Format(dblkmTomile, "0.00") + " miles", MsgBoxStyle.OkOnly, "km à miles")
        'Efface le textbox
        If MsgBoxResult.Ok Then
            txtkm.Text = ""
        End If
    End Sub

    Private Sub btnConvertirG_Click(sender As Object, e As EventArgs) Handles btnConvertirmile.Click
        Dim dblmile As Double
        Dim dblTokm As Double

        dblmile = Val(txtmile.Text)

        dblTokm = dblmile * 1.6

        MsgBox(dblmile.ToString + " miles devient " + Format(dblTokm, "0.00") + " km", MsgBoxStyle.OkOnly, "miles à km")

        If MsgBoxResult.Ok Then
            txtmile.Text = ""
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
End Class