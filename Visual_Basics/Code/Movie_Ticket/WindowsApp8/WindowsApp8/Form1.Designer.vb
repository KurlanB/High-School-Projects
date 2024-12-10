<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlBarre = New System.Windows.Forms.Panel()
        Me.btnPaiement = New System.Windows.Forms.Button()
        Me.btnChoix = New System.Windows.Forms.Button()
        Me.btnAccueil = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.pnlAffiche = New System.Windows.Forms.Panel()
        Me.pnlBarre.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlBarre
        '
        Me.pnlBarre.BackColor = System.Drawing.Color.Black
        Me.pnlBarre.Controls.Add(Me.btnPaiement)
        Me.pnlBarre.Controls.Add(Me.btnChoix)
        Me.pnlBarre.Controls.Add(Me.btnAccueil)
        Me.pnlBarre.Controls.Add(Me.lblLogo)
        Me.pnlBarre.Location = New System.Drawing.Point(-1, -1)
        Me.pnlBarre.Name = "pnlBarre"
        Me.pnlBarre.Size = New System.Drawing.Size(888, 97)
        Me.pnlBarre.TabIndex = 1
        '
        'btnPaiement
        '
        Me.btnPaiement.BackColor = System.Drawing.Color.Black
        Me.btnPaiement.FlatAppearance.BorderSize = 0
        Me.btnPaiement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaiement.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaiement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPaiement.Location = New System.Drawing.Point(690, 35)
        Me.btnPaiement.Name = "btnPaiement"
        Me.btnPaiement.Size = New System.Drawing.Size(108, 34)
        Me.btnPaiement.TabIndex = 4
        Me.btnPaiement.Text = "Paiement"
        Me.btnPaiement.UseVisualStyleBackColor = False
        '
        'btnChoix
        '
        Me.btnChoix.BackColor = System.Drawing.Color.Black
        Me.btnChoix.FlatAppearance.BorderSize = 0
        Me.btnChoix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoix.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChoix.Location = New System.Drawing.Point(452, 35)
        Me.btnChoix.Name = "btnChoix"
        Me.btnChoix.Size = New System.Drawing.Size(194, 34)
        Me.btnChoix.TabIndex = 3
        Me.btnChoix.Text = "Choix de film et d'heure"
        Me.btnChoix.UseVisualStyleBackColor = False
        '
        'btnAccueil
        '
        Me.btnAccueil.BackColor = System.Drawing.Color.Black
        Me.btnAccueil.FlatAppearance.BorderSize = 0
        Me.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccueil.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccueil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAccueil.Location = New System.Drawing.Point(321, 35)
        Me.btnAccueil.Name = "btnAccueil"
        Me.btnAccueil.Size = New System.Drawing.Size(75, 34)
        Me.btnAccueil.TabIndex = 2
        Me.btnAccueil.Text = "Accueil"
        Me.btnAccueil.UseVisualStyleBackColor = False
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Black
        Me.lblLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLogo.Font = New System.Drawing.Font("Showcard Gothic", 30.0!)
        Me.lblLogo.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogo.Location = New System.Drawing.Point(8, -3)
        Me.lblLogo.MinimumSize = New System.Drawing.Size(0, 100)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Padding = New System.Windows.Forms.Padding(8)
        Me.lblLogo.Size = New System.Drawing.Size(235, 100)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "CinéWOW"
        Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAffiche
        '
        Me.pnlAffiche.Location = New System.Drawing.Point(0, 96)
        Me.pnlAffiche.Name = "pnlAffiche"
        Me.pnlAffiche.Size = New System.Drawing.Size(886, 580)
        Me.pnlAffiche.TabIndex = 2
        '
        'frmBienvenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 678)
        Me.Controls.Add(Me.pnlAffiche)
        Me.Controls.Add(Me.pnlBarre)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmBienvenue"
        Me.Text = "Bienvenue !"
        Me.pnlBarre.ResumeLayout(False)
        Me.pnlBarre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlBarre As Panel
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnPaiement As Button
    Friend WithEvents btnChoix As Button
    Friend WithEvents btnAccueil As Button
    Friend WithEvents pnlAffiche As Panel
End Class
