'/ Titre du programme : Calculatrice
'/ Nom : Kurlan Beeharry
'/ Date : 12 / 05 / 2021
'/ Date des dernieres modifcations : 17 / 05 / 2021

Public Class frmCalculatrice

    Dim dblNombre1 As Double
    Dim dblNombre2 As Double
    Dim intOperation As Integer
    Dim boolSelection As Boolean
    Dim dblRFinale As Double

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "0"
            End If
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "1"
            Else
                txtReponse.Text = "1"
            End If
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "2"
            Else
                txtReponse.Text = "2"
            End If
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "3"
            Else
                txtReponse.Text = "3"
            End If
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "4"
            Else
                txtReponse.Text = "4"
            End If
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "5"
            Else
                txtReponse.Text = "5"
            End If
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "6"
            Else
                txtReponse.Text = "6"
            End If
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "7"
            Else
                txtReponse.Text = "7"
            End If
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "8"
            Else
                txtReponse.Text = "8"
            End If
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtReponse.Text.Length <= 10 Then
            If txtReponse.Text <> "0" Then
                txtReponse.Text += "9"
            Else
                txtReponse.Text = "9"
            End If
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If Not (txtReponse.Text = "") Then
            If Not (txtReponse.Text.Contains(".")) Then
                txtReponse.Text += "."
            End If
        End If
    End Sub

    Private Sub btnNegatif_Click(sender As Object, e As EventArgs) Handles btnNegatif.Click
        If (txtReponse.Text.Contains("-")) Then
            txtReponse.Text = txtReponse.Text.Remove(0, 1)
        Else
            txtReponse.Text = "-" + txtReponse.Text
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtReponse.Text = ""
    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        dblNombre1 = Val(txtReponse.Text)
        txtReponse.Text = ""
        boolSelection = True
        intOperation = 1
    End Sub

    Private Sub btnSoustraction_Click(sender As Object, e As EventArgs) Handles btnSoustraction.Click
        dblNombre1 = Val(txtReponse.Text)
        txtReponse.Text = ""
        boolSelection = True
        intOperation = 2
    End Sub

    Private Sub btnMultiplier_Click(sender As Object, e As EventArgs) Handles btnMultiplier.Click
        dblNombre1 = Val(txtReponse.Text)
        txtReponse.Text = ""
        boolSelection = True
        intOperation = 3
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        dblNombre1 = Val(txtReponse.Text)
        txtReponse.Text = ""
        boolSelection = True
        intOperation = 4
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dblNombre1 = Val(txtReponse.Text)
        txtReponse.Text = ""
        boolSelection = True
        intOperation = 5
    End Sub

    Private Sub btnEgale_Click(sender As Object, e As EventArgs) Handles btnEgale.Click
        If Not (txtReponse.Text = "") Then
            If boolSelection = True Then
                dblNombre2 = txtReponse.Text
                If intOperation = 1 Then
                    dblRFinale = dblNombre1 + dblNombre2
                ElseIf intOperation = 2 Then
                    dblRFinale = dblNombre1 - dblNombre2
                ElseIf intOperation = 3 Then
                    dblRFinale = dblNombre1 * dblNombre2
                ElseIf intOperation = 4 Then
                    If dblNombre2 = 0 Then
                        MsgBox("La division par 0 est impossible", MsgBoxStyle.Exclamation, "Erreur 3")
                    Else
                        dblRFinale = dblNombre1 / dblNombre2
                    End If
                ElseIf intOperation = 5 Then
                    dblRFinale = dblNombre1 Mod dblNombre2
                End If
            Else
                MsgBox("Il n'y a pas d'opérateurs sélectionner", MsgBoxStyle.Exclamation, "Erreur 2")
            End If
        Else
            MsgBox("Il n'y a pas de deuxième nombre", MsgBoxStyle.Exclamation, "Erreur 1")
        End If
        txtReponse.Text = Format(dblRFinale, "0.#####")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtReponse.Text.Length >= 1 Then
            txtReponse.Text = txtReponse.Text.Substring(0, txtReponse.Text.Length - 1)
        End If
    End Sub
End Class
