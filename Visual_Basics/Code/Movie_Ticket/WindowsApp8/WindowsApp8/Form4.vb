Public Class frmPay
    'Creation des variables
    Dim intTwix As Integer
    Dim intSour As Integer
    Dim intSkittles As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNonFriandise.Click
        'Quand on clique sur le bouton aucune friandise n'est choisi
        intTwix = 0
        intSour = 0
        intSkittles = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnContinuer.Click
        'Les valeurs des num sont sauvegarder dans des varibles
        intTwix = numTwix.Value
        intSour = numSour.Value
        intSkittles = numSkittles.Value

        'Les choix de l'utilisateur sont affichés
        If frmChoix.intFilm = 1 Then
            lblF.Text = "Demon Slayer Mugen Train"
        ElseIf frmChoix.intFilm = 2 Then
            lblF.Text = "Fast And Furious 9"
        ElseIf frmChoix.intFilm = 3 Then
            lblF.Text = "Black Widow"
        ElseIf frmChoix.intFilm = 4 Then
            lblF.Text = "Godzilla vs Kong"
        End If

        If frmChoix.intHeure = 1 Then
            lblH.Text = "13:00"
        ElseIf frmChoix.intHeure = 2 Then
            lblH.Text = "15:15"
        ElseIf frmChoix.intHeure = 3 Then
            lblH.Text = "17:30"
        ElseIf frmChoix.intHeure = 4 Then
            lblH.Text = "19:45"
        End If

        lblAd.Text = frmChoix.intAdultes
        lblE.Text = frmChoix.intEnfants
        lblA.Text = frmChoix.intAine

        lblTwixN.Text = intTwix
        lblSourN.Text = intSour
        lblSkittlesN.Text = intSkittles

        'Des variables sont creer pour le calcul du prix
        Dim dblSous As Double
        Dim dblTaxe As Double
        Dim dblTotal As Double
        Const intT As Integer = 3
        Const intS As Integer = 1
        Const intSk As Integer = 2
        Const dblPrixAd As Double = 11.95
        Const dblPrixE As Double = 7.45
        Const dblPrixA As Double = 8.95

        'Calcul du sous-total
        dblSous = (dblPrixAd * frmChoix.intAdultes) + (dblPrixE * frmChoix.intEnfants) + (dblPrixA * frmChoix.intAine) + (intT * intTwix) + (intS * intSour) + (intSk * intSkittles)

        lblSous.Text = Format(dblSous, "0.00")

        'si l'heure est avant 17h il y a un rabais de 12%
        If frmChoix.intHeure <= 2 Then
            dblSous = dblSous - (dblSous * 0.12)
        End If

        'Calcul et affichage des taxes
        dblTaxe = dblSous * 0.13

        lblT.Text = Format(dblTaxe, "0.00")

        'Calcul et affichage du total
        dblTotal = dblSous + dblTaxe

        lblTot.Text = Format(dblTotal, "0.00")
    End Sub

    'Bouton pour confirmer l'achat
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If MsgBox("Voulez-vous confirmer ce paiement ?", MsgBoxStyle.YesNo, "Paiement Final") = MsgBoxResult.No Then
            MsgBox("Vous pouvez modifier vos données", MsgBoxStyle.OkOnly, "Paiement Final")
        Else
            End
        End If
    End Sub

    Private Sub frmPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class