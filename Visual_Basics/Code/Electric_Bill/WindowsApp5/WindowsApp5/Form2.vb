Imports System.ComponentModel

Public Class frmCalcul

    Private Sub frmCalcul_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNom.Text = frmInformations.txtNom.Text
        lblAdresse.Text = frmInformations.txtAdresse.Text
        lblVille.Text = frmInformations.txtAdresse.Text
        lblCodeP.Text = frmInformations.txtCodeP1.Text + " - " + frmInformations.txtCodeP2.Text
    End Sub

    Private Sub btnAffiche_Click(sender As Object, e As EventArgs) Handles btnAffiche.Click
        Dim dblMois As Double = 1
        Dim dblkWh As Double
        Dim dblSousT As Double
        Dim dblTotal As Double
        Dim dblSousTkWh As Double
        Dim dblTaxes As Double

        Const dblfraiskWh As Double = 0.065
        Const dblTaxe As Double = 0.13
        Const dblNMois As Double = 16.19
        Const dblAdmin As Double = 0.25
        Const dblConnexion As Double = 0.00456
        Const dblkWhAdd As Double = 0.075

        dblMois = Val(txtNMois.Text)
        dblkWh = Val(txtNkWh.Text)

        If txtNkWh.Text = "" Or txtNMois.Text = "" Or txtNCompteur.Text = "" Then
            MsgBox("Veuillez entrer vos informations", MsgBoxStyle.Exclamation, "Information manquante")
            Exit Sub
        End If

        If dblkWh <= 600 Then
            dblSousTkWh = (dblkWh * dblfraiskWh) + (dblkWh * dblConnexion)
        ElseIf dblkWh > 600 Then
            Dim dblExtra As Double

            dblExtra = Val(txtNkWh.Text) - 600
            dblSousTkWh = (600 * dblfraiskWh) + (dblExtra * dblkWhAdd) + (dblkWh * dblConnexion)
        End If

        dblSousT = (dblAdmin * dblMois) + (dblMois * dblNMois) + dblSousTkWh
        dblTaxes = (dblSousT * dblTaxe)
        dblTotal = dblSousT + dblTaxes

        lblkWh.Text = Format(dblSousTkWh, "0.00")
        lblSoustotal.Text = Format(dblSousT, "0.00")
        lblNTaxes.Text = Format(dblTaxes, "0.00")
        lblNTotal.Text = Format(dblTotal, "0.00")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Sauvegarder les données ?", MsgBoxStyle.YesNo, "Sauvegarde de données") = MsgBoxResult.No Then
            MsgBox("Vous pouvez faire des changements aux données", MsgBoxStyle.OkOnly, "Sauvegarde de données")
        ElseIf txtNkWh.Text = "" Or txtNMois.Text = "" Or txtNCompteur.Text = "" Then
            MsgBox("Veuillez entrer vos informations", MsgBoxStyle.Exclamation, "Information manquante")
            Exit Sub
        Else
            End
        End If
    End Sub

    Private Sub frmCalcul_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MsgBox("Voulez-vous sauvegarder vos données avant de fermer ?", MsgBoxStyle.YesNo, "Fermeture de l'application") = MsgBoxResult.Yes Then
            MsgBox("Sauvegarder vos données avant de fermer", MsgBoxStyle.OkOnly, "Fermeture de l'application")
        Else
            End
        End If
    End Sub
End Class