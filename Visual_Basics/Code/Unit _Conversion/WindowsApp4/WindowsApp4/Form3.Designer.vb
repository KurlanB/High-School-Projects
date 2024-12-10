<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemperature
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
        Me.btnConvertirC = New System.Windows.Forms.Button()
        Me.txtCelsius = New System.Windows.Forms.TextBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblSoustitre2 = New System.Windows.Forms.Label()
        Me.txtFah = New System.Windows.Forms.TextBox()
        Me.lblF = New System.Windows.Forms.Label()
        Me.btnConvertirF = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(93, 42)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(288, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Convertir les températures (C° / F°)"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(12, 98)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(281, 17)
        Me.lblConsigne.TabIndex = 1
        Me.lblConsigne.Text = "Entrez la mesure que vous voulez convertir"
        '
        'lblSoustitre1
        '
        Me.lblSoustitre1.AutoSize = True
        Me.lblSoustitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre1.Location = New System.Drawing.Point(175, 159)
        Me.lblSoustitre1.Name = "lblSoustitre1"
        Me.lblSoustitre1.Size = New System.Drawing.Size(114, 17)
        Me.lblSoustitre1.TabIndex = 2
        Me.lblSoustitre1.Text = "Convertir C° à F°"
        '
        'btnConvertirC
        '
        Me.btnConvertirC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirC.Location = New System.Drawing.Point(272, 192)
        Me.btnConvertirC.Name = "btnConvertirC"
        Me.btnConvertirC.Size = New System.Drawing.Size(80, 39)
        Me.btnConvertirC.TabIndex = 3
        Me.btnConvertirC.Text = "Convertir"
        Me.btnConvertirC.UseVisualStyleBackColor = True
        '
        'txtCelsius
        '
        Me.txtCelsius.Location = New System.Drawing.Point(151, 203)
        Me.txtCelsius.Name = "txtCelsius"
        Me.txtCelsius.Size = New System.Drawing.Size(71, 20)
        Me.txtCelsius.TabIndex = 4
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(227, 204)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(20, 15)
        Me.lblC.TabIndex = 5
        Me.lblC.Text = "C°"
        '
        'lblSoustitre2
        '
        Me.lblSoustitre2.AutoSize = True
        Me.lblSoustitre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre2.Location = New System.Drawing.Point(175, 272)
        Me.lblSoustitre2.Name = "lblSoustitre2"
        Me.lblSoustitre2.Size = New System.Drawing.Size(114, 17)
        Me.lblSoustitre2.TabIndex = 6
        Me.lblSoustitre2.Text = "Convertir F° à C°"
        '
        'txtFah
        '
        Me.txtFah.Location = New System.Drawing.Point(151, 315)
        Me.txtFah.Name = "txtFah"
        Me.txtFah.Size = New System.Drawing.Size(71, 20)
        Me.txtFah.TabIndex = 7
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.Location = New System.Drawing.Point(228, 316)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(19, 15)
        Me.lblF.TabIndex = 8
        Me.lblF.Text = "F°"
        '
        'btnConvertirF
        '
        Me.btnConvertirF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirF.Location = New System.Drawing.Point(272, 304)
        Me.btnConvertirF.Name = "btnConvertirF"
        Me.btnConvertirF.Size = New System.Drawing.Size(80, 39)
        Me.btnConvertirF.TabIndex = 9
        Me.btnConvertirF.Text = "Convertir"
        Me.btnConvertirF.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(15, 376)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(94, 46)
        Me.btnRetour.TabIndex = 10
        Me.btnRetour.Text = "Retour à la page d'acceuil"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'frmTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.ClientSize = New System.Drawing.Size(499, 434)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnConvertirF)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.txtFah)
        Me.Controls.Add(Me.lblSoustitre2)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.txtCelsius)
        Me.Controls.Add(Me.btnConvertirC)
        Me.Controls.Add(Me.lblSoustitre1)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmTemperature"
        Me.Text = "Température"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
    Friend WithEvents lblSoustitre1 As Label
    Friend WithEvents btnConvertirC As Button
    Friend WithEvents txtCelsius As TextBox
    Friend WithEvents lblC As Label
    Friend WithEvents lblSoustitre2 As Label
    Friend WithEvents txtFah As TextBox
    Friend WithEvents lblF As Label
    Friend WithEvents btnConvertirF As Button
    Friend WithEvents btnRetour As Button
End Class
