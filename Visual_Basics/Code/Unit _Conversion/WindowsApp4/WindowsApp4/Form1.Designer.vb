<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPageAcceuil
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
        Me.btnQuantite = New System.Windows.Forms.Button()
        Me.btnPoids = New System.Windows.Forms.Button()
        Me.btnLongueur = New System.Windows.Forms.Button()
        Me.btnTemperature = New System.Windows.Forms.Button()
        Me.btnDistance = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblConsigne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuantite
        '
        Me.btnQuantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuantite.Location = New System.Drawing.Point(115, 162)
        Me.btnQuantite.Name = "btnQuantite"
        Me.btnQuantite.Size = New System.Drawing.Size(113, 30)
        Me.btnQuantite.TabIndex = 0
        Me.btnQuantite.Text = "Quantité"
        Me.btnQuantite.UseVisualStyleBackColor = True
        '
        'btnPoids
        '
        Me.btnPoids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoids.Location = New System.Drawing.Point(115, 222)
        Me.btnPoids.Name = "btnPoids"
        Me.btnPoids.Size = New System.Drawing.Size(113, 30)
        Me.btnPoids.TabIndex = 1
        Me.btnPoids.Text = "Poids"
        Me.btnPoids.UseVisualStyleBackColor = True
        '
        'btnLongueur
        '
        Me.btnLongueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLongueur.Location = New System.Drawing.Point(193, 285)
        Me.btnLongueur.Name = "btnLongueur"
        Me.btnLongueur.Size = New System.Drawing.Size(113, 30)
        Me.btnLongueur.TabIndex = 2
        Me.btnLongueur.Text = "Longueur"
        Me.btnLongueur.UseVisualStyleBackColor = True
        '
        'btnTemperature
        '
        Me.btnTemperature.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.6!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTemperature.Location = New System.Drawing.Point(276, 162)
        Me.btnTemperature.Name = "btnTemperature"
        Me.btnTemperature.Size = New System.Drawing.Size(113, 30)
        Me.btnTemperature.TabIndex = 3
        Me.btnTemperature.Text = "Température"
        Me.btnTemperature.UseVisualStyleBackColor = True
        '
        'btnDistance
        '
        Me.btnDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistance.Location = New System.Drawing.Point(276, 222)
        Me.btnDistance.Name = "btnDistance"
        Me.btnDistance.Size = New System.Drawing.Size(113, 30)
        Me.btnDistance.TabIndex = 4
        Me.btnDistance.Text = "Distance"
        Me.btnDistance.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.Location = New System.Drawing.Point(193, 406)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(113, 30)
        Me.btnQuitter.TabIndex = 5
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(120, 36)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(255, 20)
        Me.lblTitre.TabIndex = 6
        Me.lblTitre.Text = "Conversion d'unité de mesures"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(12, 98)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(275, 17)
        Me.lblConsigne.TabIndex = 7
        Me.lblConsigne.Text = "Choisissez un type de mesures à convertir"
        '
        'frmPageAcceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(497, 448)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnDistance)
        Me.Controls.Add(Me.btnTemperature)
        Me.Controls.Add(Me.btnLongueur)
        Me.Controls.Add(Me.btnPoids)
        Me.Controls.Add(Me.btnQuantite)
        Me.Name = "frmPageAcceuil"
        Me.Text = "Page d'Acceuil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuantite As Button
    Friend WithEvents btnPoids As Button
    Friend WithEvents btnLongueur As Button
    Friend WithEvents btnTemperature As Button
    Friend WithEvents btnDistance As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
End Class
