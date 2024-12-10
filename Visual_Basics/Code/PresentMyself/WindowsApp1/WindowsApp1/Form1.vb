Public Class frmProgramme
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnEyes_Click(sender As Object, e As EventArgs) Handles btnEyes.Click
        lblEyes.Visible = True
    End Sub

    Private Sub btnPhoto_Click(sender As Object, e As EventArgs) Handles btnPhoto.Click
        picPhoto.Visible = True
    End Sub

    Private Sub btnHair_Click(sender As Object, e As EventArgs) Handles btnHair.Click
        lblHair.Visible = True
    End Sub

    Private Sub btnEffacer_Click(sender As Object, e As EventArgs) Handles btnEffacer.Click
        lblEyes.Visible = False
        lblHair.Visible = False
        picPhoto.Visible = False
    End Sub

End Class
