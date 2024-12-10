<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrapeze
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
        Me.lblAireTrapeze = New System.Windows.Forms.Label()
        Me.lblDimensionT = New System.Windows.Forms.Label()
        Me.txtGrandeB = New System.Windows.Forms.TextBox()
        Me.txtPetiteb = New System.Windows.Forms.TextBox()
        Me.txtHauteur = New System.Windows.Forms.TextBox()
        Me.lblGrandeB = New System.Windows.Forms.Label()
        Me.lblPetiteB = New System.Windows.Forms.Label()
        Me.lblHauteur = New System.Windows.Forms.Label()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.lblReponse = New System.Windows.Forms.Label()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAireTrapeze
        '
        Me.lblAireTrapeze.AutoSize = True
        Me.lblAireTrapeze.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAireTrapeze.Location = New System.Drawing.Point(165, 43)
        Me.lblAireTrapeze.Name = "lblAireTrapeze"
        Me.lblAireTrapeze.Size = New System.Drawing.Size(284, 20)
        Me.lblAireTrapeze.TabIndex = 0
        Me.lblAireTrapeze.Text = "Aire d'un trapèze = ((B + b) / 2) * h"
        '
        'lblDimensionT
        '
        Me.lblDimensionT.AutoSize = True
        Me.lblDimensionT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimensionT.Location = New System.Drawing.Point(39, 109)
        Me.lblDimensionT.Name = "lblDimensionT"
        Me.lblDimensionT.Size = New System.Drawing.Size(161, 17)
        Me.lblDimensionT.TabIndex = 1
        Me.lblDimensionT.Text = "Dimensions du trapèze :"
        '
        'txtGrandeB
        '
        Me.txtGrandeB.Location = New System.Drawing.Point(297, 111)
        Me.txtGrandeB.Name = "txtGrandeB"
        Me.txtGrandeB.Size = New System.Drawing.Size(61, 20)
        Me.txtGrandeB.TabIndex = 2
        '
        'txtPetiteb
        '
        Me.txtPetiteb.Location = New System.Drawing.Point(297, 145)
        Me.txtPetiteb.Name = "txtPetiteb"
        Me.txtPetiteb.Size = New System.Drawing.Size(61, 20)
        Me.txtPetiteb.TabIndex = 3
        '
        'txtHauteur
        '
        Me.txtHauteur.Location = New System.Drawing.Point(297, 178)
        Me.txtHauteur.Name = "txtHauteur"
        Me.txtHauteur.Size = New System.Drawing.Size(61, 20)
        Me.txtHauteur.TabIndex = 4
        '
        'lblGrandeB
        '
        Me.lblGrandeB.AutoSize = True
        Me.lblGrandeB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandeB.Location = New System.Drawing.Point(206, 109)
        Me.lblGrandeB.Name = "lblGrandeB"
        Me.lblGrandeB.Size = New System.Drawing.Size(85, 15)
        Me.lblGrandeB.TabIndex = 5
        Me.lblGrandeB.Text = "Grande Base :"
        '
        'lblPetiteB
        '
        Me.lblPetiteB.AutoSize = True
        Me.lblPetiteB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPetiteB.Location = New System.Drawing.Point(206, 145)
        Me.lblPetiteB.Name = "lblPetiteB"
        Me.lblPetiteB.Size = New System.Drawing.Size(84, 15)
        Me.lblPetiteB.TabIndex = 6
        Me.lblPetiteB.Text = "Petite Base    :"
        '
        'lblHauteur
        '
        Me.lblHauteur.AutoSize = True
        Me.lblHauteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHauteur.Location = New System.Drawing.Point(224, 178)
        Me.lblHauteur.Name = "lblHauteur"
        Me.lblHauteur.Size = New System.Drawing.Size(66, 15)
        Me.lblHauteur.TabIndex = 7
        Me.lblHauteur.Text = "Hauteur    :"
        '
        'btnCalculer
        '
        Me.btnCalculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculer.Location = New System.Drawing.Point(396, 106)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(135, 27)
        Me.btnCalculer.TabIndex = 8
        Me.btnCalculer.Text = "Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'lblReponse
        '
        Me.lblReponse.AutoSize = True
        Me.lblReponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReponse.Location = New System.Drawing.Point(66, 228)
        Me.lblReponse.Name = "lblReponse"
        Me.lblReponse.Size = New System.Drawing.Size(73, 17)
        Me.lblReponse.TabIndex = 9
        Me.lblReponse.Text = "Réponse :"
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.BackColor = System.Drawing.Color.White
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(145, 230)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(0, 17)
        Me.lblPhrase.TabIndex = 10
        '
        'btnEffacer
        '
        Me.btnEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEffacer.Location = New System.Drawing.Point(396, 145)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(135, 27)
        Me.btnEffacer.TabIndex = 11
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(396, 188)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(135, 27)
        Me.btnRetour.TabIndex = 12
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(520, 291)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(66, 17)
        Me.lblNom.TabIndex = 13
        Me.lblNom.Text = "Kurlan B."
        '
        'frmTrapeze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(611, 327)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblReponse)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.lblHauteur)
        Me.Controls.Add(Me.lblPetiteB)
        Me.Controls.Add(Me.lblGrandeB)
        Me.Controls.Add(Me.txtHauteur)
        Me.Controls.Add(Me.txtPetiteb)
        Me.Controls.Add(Me.txtGrandeB)
        Me.Controls.Add(Me.lblDimensionT)
        Me.Controls.Add(Me.lblAireTrapeze)
        Me.Name = "frmTrapeze"
        Me.Text = "Aire du Trapèze"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAireTrapeze As Label
    Friend WithEvents lblDimensionT As Label
    Friend WithEvents txtGrandeB As TextBox
    Friend WithEvents txtPetiteb As TextBox
    Friend WithEvents txtHauteur As TextBox
    Friend WithEvents lblGrandeB As Label
    Friend WithEvents lblPetiteB As Label
    Friend WithEvents lblHauteur As Label
    Friend WithEvents btnCalculer As Button
    Friend WithEvents lblReponse As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents lblNom As Label
End Class
