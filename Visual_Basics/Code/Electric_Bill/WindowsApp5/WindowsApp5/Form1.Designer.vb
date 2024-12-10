<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblCodeP = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtCodeP1 = New System.Windows.Forms.TextBox()
        Me.txtCodeP2 = New System.Windows.Forms.TextBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(18, 24)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(218, 18)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Entrez les informations du client"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(12, 72)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(92, 15)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nom du client : "
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresse.Location = New System.Drawing.Point(12, 104)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(57, 15)
        Me.lblAdresse.TabIndex = 2
        Me.lblAdresse.Text = "Adresse :"
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVille.Location = New System.Drawing.Point(12, 139)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(39, 15)
        Me.lblVille.TabIndex = 3
        Me.lblVille.Text = "Ville : "
        '
        'lblCodeP
        '
        Me.lblCodeP.AutoSize = True
        Me.lblCodeP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeP.Location = New System.Drawing.Point(12, 171)
        Me.lblCodeP.Name = "lblCodeP"
        Me.lblCodeP.Size = New System.Drawing.Size(81, 15)
        Me.lblCodeP.TabIndex = 4
        Me.lblCodeP.Text = "Code postal : "
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(257, 151)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(128, 51)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Entrer les données du compteur"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(110, 71)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(126, 20)
        Me.txtNom.TabIndex = 6
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(75, 103)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(161, 20)
        Me.txtAdresse.TabIndex = 7
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(76, 139)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(128, 20)
        Me.txtVille.TabIndex = 8
        '
        'txtCodeP1
        '
        Me.txtCodeP1.Location = New System.Drawing.Point(99, 170)
        Me.txtCodeP1.Name = "txtCodeP1"
        Me.txtCodeP1.Size = New System.Drawing.Size(43, 20)
        Me.txtCodeP1.TabIndex = 9
        '
        'txtCodeP2
        '
        Me.txtCodeP2.Location = New System.Drawing.Point(160, 170)
        Me.txtCodeP2.Name = "txtCodeP2"
        Me.txtCodeP2.Size = New System.Drawing.Size(43, 20)
        Me.txtCodeP2.TabIndex = 10
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(145, 171)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(13, 17)
        Me.lblT.TabIndex = 11
        Me.lblT.Text = "-"
        '
        'frmInformations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 214)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.txtCodeP2)
        Me.Controls.Add(Me.txtCodeP1)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblCodeP)
        Me.Controls.Add(Me.lblVille)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmInformations"
        Me.Text = "Informations personnelles"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblCodeP As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtCodeP1 As TextBox
    Friend WithEvents txtCodeP2 As TextBox
    Friend WithEvents lblT As Label
End Class
