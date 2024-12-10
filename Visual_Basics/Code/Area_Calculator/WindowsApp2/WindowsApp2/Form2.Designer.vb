<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.btnCarre = New System.Windows.Forms.Button()
        Me.btnTriangle = New System.Windows.Forms.Button()
        Me.btnCercle = New System.Windows.Forms.Button()
        Me.btnTrapeze = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblConsigne = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCarre
        '
        Me.btnCarre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarre.Location = New System.Drawing.Point(105, 147)
        Me.btnCarre.Name = "btnCarre"
        Me.btnCarre.Size = New System.Drawing.Size(117, 30)
        Me.btnCarre.TabIndex = 0
        Me.btnCarre.Text = "Carré"
        Me.btnCarre.UseVisualStyleBackColor = True
        '
        'btnTriangle
        '
        Me.btnTriangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTriangle.Location = New System.Drawing.Point(267, 214)
        Me.btnTriangle.Name = "btnTriangle"
        Me.btnTriangle.Size = New System.Drawing.Size(117, 30)
        Me.btnTriangle.TabIndex = 1
        Me.btnTriangle.Text = "Triangle"
        Me.btnTriangle.UseVisualStyleBackColor = True
        '
        'btnCercle
        '
        Me.btnCercle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCercle.Location = New System.Drawing.Point(105, 214)
        Me.btnCercle.Name = "btnCercle"
        Me.btnCercle.Size = New System.Drawing.Size(117, 30)
        Me.btnCercle.TabIndex = 2
        Me.btnCercle.Text = "Cercle"
        Me.btnCercle.UseVisualStyleBackColor = True
        '
        'btnTrapeze
        '
        Me.btnTrapeze.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrapeze.Location = New System.Drawing.Point(267, 147)
        Me.btnTrapeze.Name = "btnTrapeze"
        Me.btnTrapeze.Size = New System.Drawing.Size(117, 30)
        Me.btnTrapeze.TabIndex = 3
        Me.btnTrapeze.Text = "Trapèze"
        Me.btnTrapeze.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.Location = New System.Drawing.Point(185, 298)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(120, 29)
        Me.btnQuitter.TabIndex = 4
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(116, 22)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(247, 25)
        Me.lblTitre.TabIndex = 5
        Me.lblTitre.Text = "Programme du calcul d'aire"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(12, 84)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(234, 17)
        Me.lblConsigne.TabIndex = 6
        Me.lblConsigne.Text = "Choisissez la figure plane à calculer"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(411, 358)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(57, 15)
        Me.lblNom.TabIndex = 7
        Me.lblNom.Text = "Kurlan B."
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(493, 394)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnTrapeze)
        Me.Controls.Add(Me.btnCercle)
        Me.Controls.Add(Me.btnTriangle)
        Me.Controls.Add(Me.btnCarre)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCarre As Button
    Friend WithEvents btnTriangle As Button
    Friend WithEvents btnCercle As Button
    Friend WithEvents btnTrapeze As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
    Friend WithEvents lblNom As Label
End Class
