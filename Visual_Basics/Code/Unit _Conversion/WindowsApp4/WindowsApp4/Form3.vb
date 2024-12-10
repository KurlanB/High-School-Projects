Public Class frmTemperature
    Private Sub btnConvertirL_Click(sender As Object, e As EventArgs) Handles btnConvertirC.Click
        'Créer les variables
        Dim dblC As Double
        Dim dblToF As Double

        dblC = Val(txtCelsius.Text)

        dblToF = (dblC * (9 / 5)) + 32
        'Affiche la réponse
        MsgBox(dblC.ToString + " C° devient " + Format(dblToF, "0.00") + " Fahrenheit", MsgBoxStyle.OkOnly, "Celsius à Fahrenheit")
        'Efface le textbox
        If MsgBoxResult.Ok Then
            txtCelsius.Text = ""
        End If
    End Sub

    Private Sub btnConvertirG_Click(sender As Object, e As EventArgs) Handles btnConvertirF.Click
        Dim dblF As Double
        Dim dblToC As Double

        dblF = Val(txtFah.Text)

        dblToC = (dblF - 32) * (5 / 9)

        MsgBox(dblF.ToString + " F° devient " + Format(dblToC, "0.00") + " Celsius", MsgBoxStyle.OkOnly, "Fahrenheit à Celsius")

        If MsgBoxResult.Ok Then
            txtFah.Text = ""
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

    Private Sub frmTemperature_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
