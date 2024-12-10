'/ Titre du projet : Tables de multiplication
'/ Nom : Kurlan Beeharry
'/ Date : 19 mai 2021
'/ Date des dernières modifications : 21 mai 2021

Public Class frmTables
    Private Sub btnAfficher_Click(sender As Object, e As EventArgs) Handles btnAfficher.Click
        '/Creation des variables
        Dim intTable As Integer
        Dim i As Integer = 1
        Dim intNombre As Integer = 0
        Dim intReponse As Integer

        intTable = numTable.Value

        lstReponse.Items.Clear()

        '/Boucle pour afficher la table de multiplication du nombre choisi jusqu'à 12  
        Do While i < 14
            intReponse = intTable * intNombre
            lstReponse.Items.Add(intTable.ToString + " x " + intNombre.ToString + " = " + intReponse.ToString)
            i = i + 1
            intNombre = intNombre + 1
        Loop
    End Sub

    '/ Fermer l'application
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        End
    End Sub
End Class

