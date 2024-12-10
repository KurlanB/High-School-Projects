<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoids
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
        Me.txtkg = New System.Windows.Forms.TextBox()
        Me.lblkg = New System.Windows.Forms.Label()
        Me.btnConvertirkg = New System.Windows.Forms.Button()
        Me.lblSoustitre2 = New System.Windows.Forms.Label()
        Me.txtlb = New System.Windows.Forms.TextBox()
        Me.lbllb = New System.Windows.Forms.Label()
        Me.btnConvertirlb = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(120, 39)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(223, 20)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "Convertir les Poids (kg / lb)"
        '
        'lblConsigne
        '
        Me.lblConsigne.AutoSize = True
        Me.lblConsigne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsigne.Location = New System.Drawing.Point(12, 96)
        Me.lblConsigne.Name = "lblConsigne"
        Me.lblConsigne.Size = New System.Drawing.Size(281, 17)
        Me.lblConsigne.TabIndex = 1
        Me.lblConsigne.Text = "Entrez la mesure que vous voulez convertir"
        '
        'lblSoustitre1
        '
        Me.lblSoustitre1.AutoSize = True
        Me.lblSoustitre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre1.Location = New System.Drawing.Point(191, 162)
        Me.lblSoustitre1.Name = "lblSoustitre1"
        Me.lblSoustitre1.Size = New System.Drawing.Size(111, 17)
        Me.lblSoustitre1.TabIndex = 2
        Me.lblSoustitre1.Text = "Convertir kg à lb"
        '
        'txtkg
        '
        Me.txtkg.Location = New System.Drawing.Point(163, 198)
        Me.txtkg.Name = "txtkg"
        Me.txtkg.Size = New System.Drawing.Size(58, 20)
        Me.txtkg.TabIndex = 3
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkg.Location = New System.Drawing.Point(227, 199)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(20, 15)
        Me.lblkg.TabIndex = 4
        Me.lblkg.Text = "kg"
        '
        'btnConvertirkg
        '
        Me.btnConvertirkg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirkg.Location = New System.Drawing.Point(286, 189)
        Me.btnConvertirkg.Name = "btnConvertirkg"
        Me.btnConvertirkg.Size = New System.Drawing.Size(79, 34)
        Me.btnConvertirkg.TabIndex = 5
        Me.btnConvertirkg.Text = "Convertir"
        Me.btnConvertirkg.UseVisualStyleBackColor = True
        '
        'lblSoustitre2
        '
        Me.lblSoustitre2.AutoSize = True
        Me.lblSoustitre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustitre2.Location = New System.Drawing.Point(191, 248)
        Me.lblSoustitre2.Name = "lblSoustitre2"
        Me.lblSoustitre2.Size = New System.Drawing.Size(111, 17)
        Me.lblSoustitre2.TabIndex = 6
        Me.lblSoustitre2.Text = "Convertir lb à kg"
        '
        'txtlb
        '
        Me.txtlb.Location = New System.Drawing.Point(163, 283)
        Me.txtlb.Name = "txtlb"
        Me.txtlb.Size = New System.Drawing.Size(58, 20)
        Me.txtlb.TabIndex = 7
        '
        'lbllb
        '
        Me.lbllb.AutoSize = True
        Me.lbllb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllb.Location = New System.Drawing.Point(227, 284)
        Me.lbllb.Name = "lbllb"
        Me.lbllb.Size = New System.Drawing.Size(17, 15)
        Me.lbllb.TabIndex = 8
        Me.lbllb.Text = "lb"
        '
        'btnConvertirlb
        '
        Me.btnConvertirlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertirlb.Location = New System.Drawing.Point(286, 274)
        Me.btnConvertirlb.Name = "btnConvertirlb"
        Me.btnConvertirlb.Size = New System.Drawing.Size(79, 34)
        Me.btnConvertirlb.TabIndex = 9
        Me.btnConvertirlb.Text = "Convertir"
        Me.btnConvertirlb.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(28, 362)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(92, 48)
        Me.btnRetour.TabIndex = 10
        Me.btnRetour.Text = "Retour à la page d'acceuil"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'frmPoids
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(501, 431)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnConvertirlb)
        Me.Controls.Add(Me.lbllb)
        Me.Controls.Add(Me.txtlb)
        Me.Controls.Add(Me.lblSoustitre2)
        Me.Controls.Add(Me.btnConvertirkg)
        Me.Controls.Add(Me.lblkg)
        Me.Controls.Add(Me.txtkg)
        Me.Controls.Add(Me.lblSoustitre1)
        Me.Controls.Add(Me.lblConsigne)
        Me.Controls.Add(Me.lblTitre)
        Me.Name = "frmPoids"
        Me.Text = "Poids"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblConsigne As Label
    Friend WithEvents lblSoustitre1 As Label
    Friend WithEvents txtkg As TextBox
    Friend WithEvents lblkg As Label
    Friend WithEvents btnConvertirkg As Button
    Friend WithEvents lblSoustitre2 As Label
    Friend WithEvents txtlb As TextBox
    Friend WithEvents lbllb As Label
    Friend WithEvents btnConvertirlb As Button
    Friend WithEvents btnRetour As Button
End Class
