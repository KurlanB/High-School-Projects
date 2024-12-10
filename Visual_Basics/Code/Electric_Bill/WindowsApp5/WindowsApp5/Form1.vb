Public Class frmInformations
    Public strNom As String
    Public strAdresse As String
    Public strVille As String
    Public strCodeP As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        strNom = txtNom.Text
        strAdresse = txtAdresse.Text
        strVille = txtVille.Text
        strCodeP = txtCodeP1.Text + "-" + txtCodeP2.Text

        If txtNom.Text = "" Or txtAdresse.Text = "" Or txtVille.Text = "" Or txtCodeP1.Text = "" Or txtCodeP2.Text = "" Then
            MsgBox("Veuillez entrer vos informations", MsgBoxStyle.Exclamation, "Information manquante")
            Exit Sub
        End If

        If MsgBox("Voulez-vous confirmer ces informations ? ", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            MsgBox("Les données n'ont pas été entrés", MsgBoxStyle.OkOnly, "Confirmation")
        Else
            Me.Hide()
            frmCalcul.Show()
        End If


    End Sub
End Class
