<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuantite
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
        Me.txtLitres = New System.Windows.Forms.TextBox()
        Me.lblLitres = New System.Windows.Forms.Label()
        Me.btnConvertirL = New System.Windows.Forms.Button()
        Me.btnConvertirG = New System.Windows.Forms.Button()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.lblGallons = New System.Windows.Forms.Label()
        Me.lblSoustitre2 = New System.Windows.Forms.Label()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(103, 34)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(341, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Conversion des quantité (Litres / Gallons)"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(19, 98)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(331, 17)
        Me.lblConsigne.TabIndex = 1
        Me.lblConsigne.Text = "Veuillez entrer la mesure que vous voulez convertir"
        '
        'lblSoustitre1
        '
        Me.lblSoustitre1.AutoSize = True
        Me.lblSoustitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre1.Location = New System.Drawing.Point(180, 161)
        Me.lblSoustitre1.Name = "lblSoustitre1"
        Me.lblSoustitre1.Size = New System.Drawing.Size(146, 17)
        Me.lblSoustitre1.TabIndex = 2
        Me.lblSoustitre1.Text = "Convertir litre à gallon"
        '
        'txtLitres
        '
        Me.txtLitres.Location = New System.Drawing.Point(145, 201)
        Me.txtLitres.Name = "txtLitres"
        Me.txtLitres.Size = New System.Drawing.Size(70, 20)
        Me.txtLitres.TabIndex = 3
        '
        'lblLitres
        '
        Me.lblLitres.AutoSize = True
        Me.lblLitres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitres.Location = New System.Drawing.Point(221, 202)
        Me.lblLitres.Name = "lblLitres"
        Me.lblLitres.Size = New System.Drawing.Size(37, 15)
        Me.lblLitres.TabIndex = 4
        Me.lblLitres.Text = "Litres"
        '
        'btnConvertirL
        '
        Me.btnConvertirL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvertirL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirL.Location = New System.Drawing.Point(292, 190)
        Me.btnConvertirL.Name = "btnConvertirL"
        Me.btnConvertirL.Size = New System.Drawing.Size(79, 38)
        Me.btnConvertirL.TabIndex = 5
        Me.btnConvertirL.Text = "Convertir"
        Me.btnConvertirL.UseVisualStyleBackColor = True
        '
        'btnConvertirG
        '
        Me.btnConvertirG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConvertirG.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirG.Location = New System.Drawing.Point(292, 302)
        Me.btnConvertirG.Name = "btnConvertirG"
        Me.btnConvertirG.Size = New System.Drawing.Size(79, 38)
        Me.btnConvertirG.TabIndex = 6
        Me.btnConvertirG.Text = "Convertir"
        Me.btnConvertirG.UseVisualStyleBackColor = True
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(145, 313)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(70, 20)
        Me.txtGallons.TabIndex = 7
        '
        'lblGallons
        '
        Me.lblGallons.AutoSize = True
        Me.lblGallons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGallons.Location = New System.Drawing.Point(221, 314)
        Me.lblGallons.Name = "lblGallons"
        Me.lblGallons.Size = New System.Drawing.Size(49, 15)
        Me.lblGallons.TabIndex = 8
        Me.lblGallons.Text = "Gallons"
        '
        'lblSoustitre2
        '
        Me.lblSoustitre2.AutoSize = True
        Me.lblSoustitre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre2.Location = New System.Drawing.Point(180, 259)
        Me.lblSoustitre2.Name = "lblSoustitre2"
        Me.lblSoustitre2.Size = New System.Drawing.Size(153, 17)
        Me.lblSoustitre2.TabIndex = 2
        Me.lblSoustitre2.Text = "Convertir gallon à litres"
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(21, 376)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(95, 46)
        Me.btnRetour.TabIndex = 9
        Me.btnRetour.Text = "Retour à la page d'accueil"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'frmQuantite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(516, 434)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.lblGallons)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.btnConvertirG)
        Me.Controls.Add(Me.btnConvertirL)
        Me.Controls.Add(Me.lblLitres)
        Me.Controls.Add(Me.txtLitres)
        Me.Controls.Add(Me.lblSoustitre2)
        Me.Controls.Add(Me.lblSoustitre1)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmQuantite"
        Me.Text = "Quantité"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
    Friend WithEvents lblSoustitre1 As Label
    Friend WithEvents txtLitres As TextBox
    Friend WithEvents lblLitres As Label
    Friend WithEvents btnConvertirL As Button
    Friend WithEvents btnConvertirG As Button
    Friend WithEvents txtGallons As TextBox
    Friend WithEvents lblGallons As Label
    Friend WithEvents lblSoustitre2 As Label
    Friend WithEvents btnRetour As Button
End Class
