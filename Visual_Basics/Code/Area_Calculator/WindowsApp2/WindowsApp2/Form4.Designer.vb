<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCercle
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
        Me.lblDimension = New System.Windows.Forms.Label()
        Me.txtDimension = New System.Windows.Forms.TextBox()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.lblReponse = New System.Windows.Forms.Label()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(216, 39)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(193, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Aire du Cercle : π * r^2 "
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimension.Location = New System.Drawing.Point(73, 100)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(150, 17)
        Me.lblDimension.TabIndex = 1
        Me.lblDimension.Text = "Dimension du Cercle : "
        '
        'txtDimension
        '
        Me.txtDimension.Location = New System.Drawing.Point(229, 99)
        Me.txtDimension.Name = "txtDimension"
        Me.txtDimension.Size = New System.Drawing.Size(78, 20)
        Me.txtDimension.TabIndex = 2
        '
        'btnCalculer
        '
        Me.btnCalculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculer.Location = New System.Drawing.Point(348, 94)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(132, 26)
        Me.btnCalculer.TabIndex = 3
        Me.btnCalculer.Text = "Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'lblReponse
        '
        Me.lblReponse.AutoSize = True
        Me.lblReponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReponse.Location = New System.Drawing.Point(91, 160)
        Me.lblReponse.Name = "lblReponse"
        Me.lblReponse.Size = New System.Drawing.Size(73, 17)
        Me.lblReponse.TabIndex = 4
        Me.lblReponse.Text = "Réponse :"
        '
        'btnEffacer
        '
        Me.btnEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEffacer.Location = New System.Drawing.Point(256, 226)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(132, 26)
        Me.btnEffacer.TabIndex = 5
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.Location = New System.Drawing.Point(256, 268)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(132, 26)
        Me.btnRetour.TabIndex = 6
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.BackColor = System.Drawing.Color.White
        Me.lblPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(170, 164)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(0, 17)
        Me.lblPhrase.TabIndex = 7
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(521, 291)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(66, 17)
        Me.lblNom.TabIndex = 8
        Me.lblNom.Text = "Kurlan B."
        '
        'frmCercle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 327)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.lblReponse)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.txtDimension)
        Me.Controls.Add(Me.lblDimension)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmCercle"
        Me.Text = "Aire du Cercle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblDimension As Label
    Friend WithEvents txtDimension As TextBox
    Friend WithEvents btnCalculer As Button
    Friend WithEvents lblReponse As Label
    Friend WithEvents btnEffacer As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblNom As Label
End Class
