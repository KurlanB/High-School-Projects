<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLongueur
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
        Me.lblConsigne = New System.Windows.Forms.Label()
        Me.lblSoustitre1 = New System.Windows.Forms.Label()
        Me.txtcm = New System.Windows.Forms.TextBox()
        Me.lblcm = New System.Windows.Forms.Label()
        Me.btnConvertircm = New System.Windows.Forms.Button()
        Me.btnConvertirpouces = New System.Windows.Forms.Button()
        Me.lblSoustitre2 = New System.Windows.Forms.Label()
        Me.txtpouces = New System.Windows.Forms.TextBox()
        Me.lblpouces = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(91, 39)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(335, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Conversion des Longueurs (cm / pouces)"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(12, 89)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(333, 17)
        Me.lblConsigne.TabIndex = 1
        Me.lblConsigne.Text = "Veuillez entrez la mesure que vous voulez convertir"
        '
        'lblSoustitre1
        '
        Me.lblSoustitre1.AutoSize = True
        Me.lblSoustitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre1.Location = New System.Drawing.Point(172, 143)
        Me.lblSoustitre1.Name = "lblSoustitre1"
        Me.lblSoustitre1.Size = New System.Drawing.Size(149, 17)
        Me.lblSoustitre1.TabIndex = 2
        Me.lblSoustitre1.Text = "Convertir cm à pouces"
        '
        'txtcm
        '
        Me.txtcm.Location = New System.Drawing.Point(149, 181)
        Me.txtcm.Name = "txtcm"
        Me.txtcm.Size = New System.Drawing.Size(71, 20)
        Me.txtcm.TabIndex = 3
        '
        'lblcm
        '
        Me.lblcm.AutoSize = True
        Me.lblcm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcm.Location = New System.Drawing.Point(225, 182)
        Me.lblcm.Name = "lblcm"
        Me.lblcm.Size = New System.Drawing.Size(24, 15)
        Me.lblcm.TabIndex = 4
        Me.lblcm.Text = "cm"
        '
        'btnConvertircm
        '
        Me.btnConvertircm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertircm.Location = New System.Drawing.Point(293, 173)
        Me.btnConvertircm.Name = "btnConvertircm"
        Me.btnConvertircm.Size = New System.Drawing.Size(85, 37)
        Me.btnConvertircm.TabIndex = 5
        Me.btnConvertircm.Text = "Convertir"
        Me.btnConvertircm.UseVisualStyleBackColor = True
        '
        'btnConvertirpouces
        '
        Me.btnConvertirpouces.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirpouces.Location = New System.Drawing.Point(293, 278)
        Me.btnConvertirpouces.Name = "btnConvertirpouces"
        Me.btnConvertirpouces.Size = New System.Drawing.Size(85, 37)
        Me.btnConvertirpouces.TabIndex = 6
        Me.btnConvertirpouces.Text = "Convertir"
        Me.btnConvertirpouces.UseVisualStyleBackColor = True
        '
        'lblSoustitre2
        '
        Me.lblSoustitre2.AutoSize = True
        Me.lblSoustitre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre2.Location = New System.Drawing.Point(172, 236)
        Me.lblSoustitre2.Name = "lblSoustitre2"
        Me.lblSoustitre2.Size = New System.Drawing.Size(149, 17)
        Me.lblSoustitre2.TabIndex = 7
        Me.lblSoustitre2.Text = "Convertir pouces à cm"
        '
        'txtpouces
        '
        Me.txtpouces.Location = New System.Drawing.Point(149, 286)
        Me.txtpouces.Name = "txtpouces"
        Me.txtpouces.Size = New System.Drawing.Size(71, 20)
        Me.txtpouces.TabIndex = 8
        '
        'lblpouces
        '
        Me.lblpouces.AutoSize = True
        Me.lblpouces.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpouces.Location = New System.Drawing.Point(225, 287)
        Me.lblpouces.Name = "lblpouces"
        Me.lblpouces.Size = New System.Drawing.Size(47, 15)
        Me.lblpouces.TabIndex = 9
        Me.lblpouces.Text = "pouces"
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(15, 347)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(103, 53)
        Me.btnRetour.TabIndex = 10
        Me.btnRetour.Text = "Retour à la page d'acceuil"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'frmLongueur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(506, 420)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblpouces)
        Me.Controls.Add(Me.txtpouces)
        Me.Controls.Add(Me.lblSoustitre2)
        Me.Controls.Add(Me.btnConvertirpouces)
        Me.Controls.Add(Me.btnConvertircm)
        Me.Controls.Add(Me.lblcm)
        Me.Controls.Add(Me.txtcm)
        Me.Controls.Add(Me.lblSoustitre1)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmLongueur"
        Me.Text = "Longueur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
    Friend WithEvents lblSoustitre1 As Label
    Friend WithEvents txtcm As TextBox
    Friend WithEvents lblcm As Label
    Friend WithEvents btnConvertircm As Button
    Friend WithEvents btnConvertirpouces As Button
    Friend WithEvents lblSoustitre2 As Label
    Friend WithEvents txtpouces As TextBox
    Friend WithEvents lblpouces As Label
    Friend WithEvents btnRetour As Button
End Class
