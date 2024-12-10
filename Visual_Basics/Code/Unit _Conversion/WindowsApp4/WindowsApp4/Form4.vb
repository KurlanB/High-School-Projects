Public Class frmPoids
    Private Sub btnConvertirL_Click(sender As Object, e As EventArgs) Handles btnConvertirkg.Click
        'Créer les variables
        Dim dblkg As Double
        Dim dblkgTolb As Double

        dblkg = Val(txtkg.Text)

        dblkgTolb = dblkg * 2.2
        'Affiche la réponse
        MsgBox(dblkg.ToString + " kg devient " + Format(dblkgTolb, "0.00") + " lb", MsgBoxStyle.OkOnly, "kg à lb")
        'Efface le textbox
        If MsgBoxResult.Ok Then
            txtkg.Text = ""
        End If
    End Sub

    Private Sub btnConvertirG_Click(sender As Object, e As EventArgs) Handles btnConvertirlb.Click
        Dim dbllb As Double
        Dim dbllbTokg As Double

        dbllb = Val(txtlb.Text)

        dbllbTokg = dbllb * 0.454

        MsgBox(dbllb.ToString + " lb devient " + Format(dbllbTokg, "0.00") + " kg", MsgBoxStyle.OkOnly, "lb à kg")

        If MsgBoxResult.Ok Then
            txtlb.Text = ""
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