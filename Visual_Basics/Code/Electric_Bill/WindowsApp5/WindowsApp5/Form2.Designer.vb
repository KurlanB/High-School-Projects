<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalcul
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
        Me.lblTitre2 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNCompteur = New System.Windows.Forms.Label()
        Me.lblMois = New System.Windows.Forms.Label()
        Me.lblNkWh = New System.Windows.Forms.Label()
        Me.btnAffiche = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtNCompteur = New System.Windows.Forms.TextBox()
        Me.txtNMois = New System.Windows.Forms.TextBox()
        Me.txtNkWh = New System.Windows.Forms.TextBox()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblMensuels = New System.Windows.Forms.Label()
        Me.lblkWh = New System.Windows.Forms.Label()
        Me.lblSoustotal = New System.Windows.Forms.Label()
        Me.lblNTaxes = New System.Windows.Forms.Label()
        Me.lblNTotal = New System.Windows.Forms.Label()
        Me.lblFraisadmin = New System.Windows.Forms.Label()
        Me.lblfraisMensuels = New System.Windows.Forms.Label()
        Me.lblfraisdukWh = New System.Windows.Forms.Label()
        Me.lblSousT = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblTitre1 = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblAdresse = New System.Windows.Forms.Label()
        Me.lblVille = New System.Windows.Forms.Label()
        Me.lblCodeP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitre2
        '
        Me.lblTitre2.AutoSize = True
        Me.lblTitre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre2.Location = New System.Drawing.Point(12, 174)
        Me.lblTitre2.Name = "lblTitre2"
        Me.lblTitre2.Size = New System.Drawing.Size(264, 20)
        Me.lblTitre2.TabIndex = 0
        Me.lblTitre2.Text = "Entrez les informations du compteur"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(362, 174)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(44, 20)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total"
        '
        'lblNCompteur
        '
        Me.lblNCompteur.AutoSize = True
        Me.lblNCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNCompteur.Location = New System.Drawing.Point(13, 219)
        Me.lblNCompteur.Name = "lblNCompteur"
        Me.lblNCompteur.Size = New System.Drawing.Size(153, 17)
        Me.lblNCompteur.TabIndex = 2
        Me.lblNCompteur.Text = "Numéro du compteur : "
        '
        'lblMois
        '
        Me.lblMois.AutoSize = True
        Me.lblMois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMois.Location = New System.Drawing.Point(13, 260)
        Me.lblMois.Name = "lblMois"
        Me.lblMois.Size = New System.Drawing.Size(123, 17)
        Me.lblMois.TabIndex = 3
        Me.lblMois.Text = "Nombre de mois : "
        '
        'lblNkWh
        '
        Me.lblNkWh.AutoSize = True
        Me.lblNkWh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNkWh.Location = New System.Drawing.Point(13, 306)
        Me.lblNkWh.Name = "lblNkWh"
        Me.lblNkWh.Size = New System.Drawing.Size(231, 17)
        Me.lblNkWh.TabIndex = 4
        Me.lblNkWh.Text = "Nombre de kilowattheures utilisés : "
        '
        'btnAffiche
        '
        Me.btnAffiche.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAffiche.Location = New System.Drawing.Point(107, 358)
        Me.btnAffiche.Name = "btnAffiche"
        Me.btnAffiche.Size = New System.Drawing.Size(137, 51)
        Me.btnAffiche.TabIndex = 5
        Me.btnAffiche.Text = "Afficher le total de la facture"
        Me.btnAffiche.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(107, 426)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(137, 51)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Sauvegarder les données"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtNCompteur
        '
        Me.txtNCompteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNCompteur.Location = New System.Drawing.Point(172, 218)
        Me.txtNCompteur.Name = "txtNCompteur"
        Me.txtNCompteur.Size = New System.Drawing.Size(152, 23)
        Me.txtNCompteur.TabIndex = 7
        '
        'txtNMois
        '
        Me.txtNMois.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNMois.Location = New System.Drawing.Point(142, 259)
        Me.txtNMois.Name = "txtNMois"
        Me.txtNMois.Size = New System.Drawing.Size(125, 23)
        Me.txtNMois.TabIndex = 8
        '
        'txtNkWh
        '
        Me.txtNkWh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNkWh.Location = New System.Drawing.Point(240, 305)
        Me.txtNkWh.Name = "txtNkWh"
        Me.txtNkWh.Size = New System.Drawing.Size(84, 23)
        Me.txtNkWh.TabIndex = 9
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.Location = New System.Drawing.Point(371, 219)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(48, 17)
        Me.lblAdmin.TabIndex = 10
        Me.lblAdmin.Text = "0,25 $"
        '
        'lblMensuels
        '
        Me.lblMensuels.AutoSize = True
        Me.lblMensuels.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensuels.Location = New System.Drawing.Point(369, 260)
        Me.lblMensuels.Name = "lblMensuels"
        Me.lblMensuels.Size = New System.Drawing.Size(56, 17)
        Me.lblMensuels.TabIndex = 11
        Me.lblMensuels.Text = "16,19 $"
        '
        'lblkWh
        '
        Me.lblkWh.AutoSize = True
        Me.lblkWh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkWh.Location = New System.Drawing.Point(371, 306)
        Me.lblkWh.Name = "lblkWh"
        Me.lblkWh.Size = New System.Drawing.Size(48, 17)
        Me.lblkWh.TabIndex = 12
        Me.lblkWh.Text = "0,00 $"
        '
        'lblSoustotal
        '
        Me.lblSoustotal.AutoSize = True
        Me.lblSoustotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustotal.Location = New System.Drawing.Point(371, 358)
        Me.lblSoustotal.Name = "lblSoustotal"
        Me.lblSoustotal.Size = New System.Drawing.Size(48, 17)
        Me.lblSoustotal.TabIndex = 13
        Me.lblSoustotal.Text = "0,00 $"
        '
        'lblNTaxes
        '
        Me.lblNTaxes.AutoSize = True
        Me.lblNTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNTaxes.Location = New System.Drawing.Point(371, 383)
        Me.lblNTaxes.Name = "lblNTaxes"
        Me.lblNTaxes.Size = New System.Drawing.Size(48, 17)
        Me.lblNTaxes.TabIndex = 14
        Me.lblNTaxes.Text = "0,00 $"
        '
        'lblNTotal
        '
        Me.lblNTotal.AutoSize = True
        Me.lblNTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNTotal.Location = New System.Drawing.Point(368, 407)
        Me.lblNTotal.Name = "lblNTotal"
        Me.lblNTotal.Size = New System.Drawing.Size(54, 17)
        Me.lblNTotal.TabIndex = 15
        Me.lblNTotal.Text = "0,00 $"
        '
        'lblFraisadmin
        '
        Me.lblFraisadmin.AutoSize = True
        Me.lblFraisadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraisadmin.Location = New System.Drawing.Point(425, 219)
        Me.lblFraisadmin.Name = "lblFraisadmin"
        Me.lblFraisadmin.Size = New System.Drawing.Size(132, 17)
        Me.lblFraisadmin.TabIndex = 16
        Me.lblFraisadmin.Text = "(frais administratifs)"
        '
        'lblfraisMensuels
        '
        Me.lblfraisMensuels.AutoSize = True
        Me.lblfraisMensuels.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfraisMensuels.Location = New System.Drawing.Point(431, 260)
        Me.lblfraisMensuels.Name = "lblfraisMensuels"
        Me.lblfraisMensuels.Size = New System.Drawing.Size(109, 17)
        Me.lblfraisMensuels.TabIndex = 17
        Me.lblfraisMensuels.Text = "(frais mensuels)"
        '
        'lblfraisdukWh
        '
        Me.lblfraisdukWh.AutoSize = True
        Me.lblfraisdukWh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfraisdukWh.Location = New System.Drawing.Point(425, 306)
        Me.lblfraisdukWh.Name = "lblfraisdukWh"
        Me.lblfraisdukWh.Size = New System.Drawing.Size(97, 17)
        Me.lblfraisdukWh.TabIndex = 18
        Me.lblfraisdukWh.Text = "(frais du kWh)"
        '
        'lblSousT
        '
        Me.lblSousT.AutoSize = True
        Me.lblSousT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousT.Location = New System.Drawing.Point(425, 358)
        Me.lblSousT.Name = "lblSousT"
        Me.lblSousT.Size = New System.Drawing.Size(82, 17)
        Me.lblSousT.TabIndex = 19
        Me.lblSousT.Text = "(Sous-total)"
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.Location = New System.Drawing.Point(425, 383)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(56, 17)
        Me.lblTaxes.TabIndex = 20
        Me.lblTaxes.Text = "(Taxes)"
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(426, 407)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(50, 17)
        Me.lblT.TabIndex = 21
        Me.lblT.Text = "(Total)"
        '
        'lblTitre1
        '
        Me.lblTitre1.AutoSize = True
        Me.lblTitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre1.Location = New System.Drawing.Point(12, 20)
        Me.lblTitre1.Name = "lblTitre1"
        Me.lblTitre1.Size = New System.Drawing.Size(161, 20)
        Me.lblTitre1.TabIndex = 22
        Me.lblTitre1.Text = "Informations du client"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblN.Location = New System.Drawing.Point(13, 51)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(49, 17)
        Me.lblN.TabIndex = 23
        Me.lblN.Text = "Nom : "
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(13, 80)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(72, 17)
        Me.lblA.TabIndex = 24
        Me.lblA.Text = "Adresse : "
        '
        'lblV
        '
        Me.lblV.AutoSize = True
        Me.lblV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblV.Location = New System.Drawing.Point(13, 108)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(46, 17)
        Me.lblV.TabIndex = 25
        Me.lblV.Text = "Ville : "
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(13, 137)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(95, 17)
        Me.lblCP.TabIndex = 26
        Me.lblCP.Text = "Code postal : "
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(58, 53)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(0, 17)
        Me.lblNom.TabIndex = 27
        '
        'lblAdresse
        '
        Me.lblAdresse.AutoSize = True
        Me.lblAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdresse.Location = New System.Drawing.Point(80, 82)
        Me.lblAdresse.Name = "lblAdresse"
        Me.lblAdresse.Size = New System.Drawing.Size(0, 17)
        Me.lblAdresse.TabIndex = 28
        '
        'lblVille
        '
        Me.lblVille.AutoSize = True
        Me.lblVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVille.Location = New System.Drawing.Point(53, 110)
        Me.lblVille.Name = "lblVille"
        Me.lblVille.Size = New System.Drawing.Size(0, 17)
        Me.lblVille.TabIndex = 29
        '
        'lblCodeP
        '
        Me.lblCodeP.AutoSize = True
        Me.lblCodeP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeP.Location = New System.Drawing.Point(104, 138)
        Me.lblCodeP.Name = "lblCodeP"
        Me.lblCodeP.Size = New System.Drawing.Size(0, 17)
        Me.lblCodeP.TabIndex = 30
        '
        'frmCalcul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 497)
        Me.Controls.Add(Me.lblCodeP)
        Me.Controls.Add(Me.lblVille)
        Me.Controls.Add(Me.lblAdresse)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblV)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lblTitre1)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.lblSousT)
        Me.Controls.Add(Me.lblfraisdukWh)
        Me.Controls.Add(Me.lblfraisMensuels)
        Me.Controls.Add(Me.lblFraisadmin)
        Me.Controls.Add(Me.lblNTotal)
        Me.Controls.Add(Me.lblNTaxes)
        Me.Controls.Add(Me.lblSoustotal)
        Me.Controls.Add(Me.lblkWh)
        Me.Controls.Add(Me.lblMensuels)
        Me.Controls.Add(Me.lblAdmin)
        Me.Controls.Add(Me.txtNkWh)
        Me.Controls.Add(Me.txtNMois)
        Me.Controls.Add(Me.txtNCompteur)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAffiche)
        Me.Controls.Add(Me.lblNkWh)
        Me.Controls.Add(Me.lblMois)
        Me.Controls.Add(Me.lblNCompteur)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTitre2)
        Me.Name = "frmCalcul"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblNCompteur As Label
    Friend WithEvents lblMois As Label
    Friend WithEvents lblNkWh As Label
    Friend WithEvents btnAffiche As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtNCompteur As TextBox
    Friend WithEvents txtNMois As TextBox
    Friend WithEvents txtNkWh As TextBox
    Friend WithEvents lblAdmin As Label
    Friend WithEvents lblMensuels As Label
    Friend WithEvents lblkWh As Label
    Friend WithEvents lblSoustotal As Label
    Friend WithEvents lblNTaxes As Label
    Friend WithEvents lblNTotal As Label
    Friend WithEvents lblFraisadmin As Label
    Friend WithEvents lblfraisMensuels As Label
    Friend WithEvents lblfraisdukWh As Label
    Friend WithEvents lblSousT As Label
    Friend WithEvents lblTaxes As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblTitre1 As Label
    Friend WithEvents lblN As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblV As Label
    Friend WithEvents lblCP As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblAdresse As Label
    Friend WithEvents lblVille As Label
    Friend WithEvents lblCodeP As Label
End Class
