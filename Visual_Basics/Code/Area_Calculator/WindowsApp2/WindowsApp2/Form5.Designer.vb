<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriangle
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
        Me.lblDimensions = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblHauteur = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtHauteur = New System.Windows.Forms.TextBox()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblReponse = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(203, 32)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(224, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Aire du Triangle : (b * h) / 2"
        '
        'lblDimensions
        '
        Me.lblDimensions.AutoSize = True
        Me.lblDimensions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimensions.Location = New System.Drawing.Point(52, 87)
        Me.lblDimensions.Name = "lblDimensions"
        Me.lblDimensions.Size = New System.Drawing.Size(164, 17)
        Me.lblDimensions.TabIndex = 1
        Me.lblDimensions.Text = "Dimensions du triangle : "
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(222, 87)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(52, 17)
        Me.lblBase.TabIndex = 2
        Me.lblBase.Text = "Base : "
        '
        'lblHauteur
        '
        Me.lblHauteur.AutoSize = True
        Me.lblHauteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHauteur.Location = New System.Drawing.Point(204, 120)
        Me.lblHauteur.Name = "lblHauteur"
        Me.lblHauteur.Size = New System.Drawing.Size(71, 17)
        Me.lblHauteur.TabIndex = 3
        Me.lblHauteur.Text = "Hauteur : "
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(280, 86)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(59, 20)
        Me.txtBase.TabIndex = 4
        '
        'txtHauteur
        '
        Me.txtHauteur.Location = New System.Drawing.Point(280, 119)
        Me.txtHauteur.Name = "txtHauteur"
        Me.txtHauteur.Size = New System.Drawing.Size(59, 20)
        Me.txtHauteur.TabIndex = 5
        '
        'btnCalculer
        '
        Me.btnCalculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculer.Location = New System.Drawing.Point(383, 98)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(125, 27)
        Me.btnCalculer.TabIndex = 6
        Me.btnCalculer.Text = "Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEffacer.Location = New System.Drawing.Point(257, 229)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(125, 27)
        Me.btnEffacer.TabIndex = 7
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(257, 271)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(125, 27)
        Me.btnRetour.TabIndex = 8
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'lblReponse
        '
        Me.lblReponse.AutoSize = True
        Me.lblReponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReponse.Location = New System.Drawing.Point(65, 172)
        Me.lblReponse.Name = "lblReponse"
        Me.lblReponse.Size = New System.Drawing.Size(77, 17)
        Me.lblReponse.TabIndex = 9
        Me.lblReponse.Text = "Réponse : "
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.BackColor = System.Drawing.Color.White
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(142, 172)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(0, 17)
        Me.lblPhrase.TabIndex = 10
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(564, 299)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(66, 17)
        Me.lblNom.TabIndex = 11
        Me.lblNom.Text = "Kurlan B."
        '
        'frmTriangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(642, 325)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblReponse)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.txtHauteur)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblHauteur)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.lblDimensions)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmTriangle"
        Me.Text = "Aire du Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblDimensions As Label
    Friend WithEvents lblBase As Label
    Friend WithEvents lblHauteur As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtHauteur As TextBox
    Friend WithEvents btnCalculer As Button
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents lblReponse As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblNom As Label
End Class
