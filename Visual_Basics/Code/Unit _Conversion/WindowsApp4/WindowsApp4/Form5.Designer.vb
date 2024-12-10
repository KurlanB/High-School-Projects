<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistance
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
        Me.txtkm = New System.Windows.Forms.TextBox()
        Me.lblkm = New System.Windows.Forms.Label()
        Me.btnConvertirkm = New System.Windows.Forms.Button()
        Me.lblSoustitre2 = New System.Windows.Forms.Label()
        Me.txtmile = New System.Windows.Forms.TextBox()
        Me.lblmile = New System.Windows.Forms.Label()
        Me.btnConvertirmile = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(93, 39)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(304, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Conversion des Distances (km / mile)"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(12, 92)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(333, 17)
        Me.lblConsigne.TabIndex = 1
        Me.lblConsigne.Text = "Veuillez entrez la mesure que vous voulez convertir"
        '
        'lblSoustitre1
        '
        Me.lblSoustitre1.AutoSize = True
        Me.lblSoustitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre1.Location = New System.Drawing.Point(165, 151)
        Me.lblSoustitre1.Name = "lblSoustitre1"
        Me.lblSoustitre1.Size = New System.Drawing.Size(135, 17)
        Me.lblSoustitre1.TabIndex = 2
        Me.lblSoustitre1.Text = "Convertir km à miles"
        '
        'txtkm
        '
        Me.txtkm.Location = New System.Drawing.Point(145, 188)
        Me.txtkm.Name = "txtkm"
        Me.txtkm.Size = New System.Drawing.Size(63, 20)
        Me.txtkm.TabIndex = 3
        '
        'lblkm
        '
        Me.lblkm.AutoSize = True
        Me.lblkm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkm.Location = New System.Drawing.Point(214, 189)
        Me.lblkm.Name = "lblkm"
        Me.lblkm.Size = New System.Drawing.Size(24, 15)
        Me.lblkm.TabIndex = 4
        Me.lblkm.Text = "km"
        '
        'btnConvertirkm
        '
        Me.btnConvertirkm.Location = New System.Drawing.Point(279, 181)
        Me.btnConvertirkm.Name = "btnConvertirkm"
        Me.btnConvertirkm.Size = New System.Drawing.Size(80, 33)
        Me.btnConvertirkm.TabIndex = 5
        Me.btnConvertirkm.Text = "Convertir"
        Me.btnConvertirkm.UseVisualStyleBackColor = True
        '
        'lblSoustitre2
        '
        Me.lblSoustitre2.AutoSize = True
        Me.lblSoustitre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre2.Location = New System.Drawing.Point(165, 240)
        Me.lblSoustitre2.Name = "lblSoustitre2"
        Me.lblSoustitre2.Size = New System.Drawing.Size(135, 17)
        Me.lblSoustitre2.TabIndex = 6
        Me.lblSoustitre2.Text = "Convertir miles à km"
        '
        'txtmile
        '
        Me.txtmile.Location = New System.Drawing.Point(145, 277)
        Me.txtmile.Name = "txtmile"
        Me.txtmile.Size = New System.Drawing.Size(63, 20)
        Me.txtmile.TabIndex = 7
        '
        'lblmile
        '
        Me.lblmile.AutoSize = True
        Me.lblmile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmile.Location = New System.Drawing.Point(214, 278)
        Me.lblmile.Name = "lblmile"
        Me.lblmile.Size = New System.Drawing.Size(37, 15)
        Me.lblmile.TabIndex = 8
        Me.lblmile.Text = "miles"
        '
        'btnConvertirmile
        '
        Me.btnConvertirmile.Location = New System.Drawing.Point(279, 270)
        Me.btnConvertirmile.Name = "btnConvertirmile"
        Me.btnConvertirmile.Size = New System.Drawing.Size(80, 33)
        Me.btnConvertirmile.TabIndex = 9
        Me.btnConvertirmile.Text = "Convertir"
        Me.btnConvertirmile.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(15, 359)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(108, 48)
        Me.btnRetour.TabIndex = 10
        Me.btnRetour.Text = "Retour à la page d'acceuil"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'frmDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(496, 419)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnConvertirmile)
        Me.Controls.Add(Me.lblmile)
        Me.Controls.Add(Me.txtmile)
        Me.Controls.Add(Me.lblSoustitre2)
        Me.Controls.Add(Me.btnConvertirkm)
        Me.Controls.Add(Me.lblkm)
        Me.Controls.Add(Me.txtkm)
        Me.Controls.Add(Me.lblSoustitre1)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmDistance"
        Me.Text = "Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
    Friend WithEvents lblSoustitre1 As Label
    Friend WithEvents txtkm As TextBox
    Friend WithEvents lblkm As Label
    Friend WithEvents btnConvertirkm As Button
    Friend WithEvents lblSoustitre2 As Label
    Friend WithEvents txtmile As TextBox
    Friend WithEvents lblmile As Label
    Friend WithEvents btnConvertirmile As Button
    Friend WithEvents btnRetour As Button
End Class
