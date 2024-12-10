Public Class frmLongueur
    Private Sub btnConvertirL_Click(sender As Object, e As EventArgs) Handles btnConvertircm.Click
        'Créer les variables
        Dim dblcm As Double
        Dim dblcmTopouces As Double

        dblcm = Val(txtcm.Text)

        dblcmTopouces = dblcm * 0.39
        'Affiche la réponse
        MsgBox(dblcm.ToString + " cm devient " + Format(dblcmTopouces, "0.00") + " pouces", MsgBoxStyle.OkOnly, "cm à pouces")
        'Efface le textbox
        If MsgBoxResult.Ok Then
            txtcm.Text = ""
        End If
    End Sub

    Private Sub btnConvertirG_Click(sender As Object, e As EventArgs) Handles btnConvertirpouces.Click
        Dim dblpouces As Double
        Dim dblTocm As Double

        dblpouces = Val(txtpouces.Text)

        dblTocm = dblpouces * 2.54

        MsgBox(dblpouces.ToString + " pouces devient " + Format(dblTocm, "0.00") + " cm", MsgBoxStyle.OkOnly, "pouces à cm")

        If MsgBoxResult.Ok Then
            txtpouces.Text = ""
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