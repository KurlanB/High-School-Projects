Public Class frmChoix
    'Creation des variables publiques
    Public intFilm As Integer
    Public intHeure As Integer
    Public intAdultes As Integer
    Public intEnfants As Integer
    Public intAine As Integer

    'Chaque boutons sauvegarde une differente donnees pour le film choisi
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picDemonSlayer.Click
        intFilm = 1
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles picF9.Click
        intFilm = 2
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picWidow.Click
        intFilm = 3
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picGodvKong.Click
        intFilm = 4
    End Sub

    'Choix de l'heure
    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        intHeure = 1
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn1515.Click
        intHeure = 2
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn1730.Click
        intHeure = 3
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn1945.Click
        intHeure = 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnContinuer.Click
        'Les valeurs des num sont sauvegardes dans des variables
        intAdultes = numAdulte.Value
        intEnfants = numEnfant.Value
        intAine = numAines.Value

        'Si le film, l'heure ou les billets n'ont pas etes choisis afficher un message d'erreur sinon on continue
        If intFilm = 0 Then
            MsgBox("Choisissez un film à regarder", MsgBoxStyle.OkOnly, "Film")
        ElseIf intHeure = 0 Then
            MsgBox("Choisissez une heure de visionnement", MsgBoxStyle.OkOnly, "Heure")
        ElseIf intAdultes = 0 And intEnfants = 0 And intAine = 0 Then
            MsgBox("Choisissez le nombre de personnes avant de continuer", MsgBoxStyle.OkOnly, "Nombre de personnes")
        Else
            frmBienvenue.boolPaiement = True
            frmBienvenue.pnlAffiche.Controls.Clear()
            frmPay.TopLevel = False
            frmBienvenue.pnlAffiche.Controls.Add(frmPay)
            frmPay.Show()
        End If

    End Sub

    Private Sub frmChoix_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class