<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAireduCarre
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblDimension = New System.Windows.Forms.Label()
        Me.txtDimension = New System.Windows.Forms.TextBox()
        Me.lblReponse = New System.Windows.Forms.Label()
        Me.lblReponseN = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(206, 43)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(238, 20)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Aire d'un carré = c * c ou c^2"
        '
        'lblDimension
        '
        Me.lblDimension.AutoSize = True
        Me.lblDimension.Location = New System.Drawing.Point(76, 119)
        Me.lblDimension.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDimension.Name = "lblDimension"
        Me.lblDimension.Size = New System.Drawing.Size(171, 17)
        Me.lblDimension.TabIndex = 1
        Me.lblDimension.Text = "Dimension du carré (cm) :"
        '
        'txtDimension
        '
        Me.txtDimension.Location = New System.Drawing.Point(253, 116)
        Me.txtDimension.Name = "txtDimension"
        Me.txtDimension.Size = New System.Drawing.Size(141, 23)
        Me.txtDimension.TabIndex = 2
        '
        'lblReponse
        '
        Me.lblReponse.AutoSize = True
        Me.lblReponse.Location = New System.Drawing.Point(99, 177)
        Me.lblReponse.Name = "lblReponse"
        Me.lblReponse.Size = New System.Drawing.Size(73, 17)
        Me.lblReponse.TabIndex = 3
        Me.lblReponse.Text = "Réponse :"
        '
        'lblReponseN
        '
        Me.lblReponseN.AutoSize = True
        Me.lblReponseN.BackColor = System.Drawing.Color.White
        Me.lblReponseN.Location = New System.Drawing.Point(178, 177)
        Me.lblReponseN.Name = "lblReponseN"
        Me.lblReponseN.Size = New System.Drawing.Size(0, 17)
        Me.lblReponseN.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(575, 307)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(66, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Kurlan B."
        '
        'btnCalculer
        '
        Me.btnCalculer.BackColor = System.Drawing.Color.MistyRose
        Me.btnCalculer.Location = New System.Drawing.Point(413, 116)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(126, 25)
        Me.btnCalculer.TabIndex = 6
        Me.btnCalculer.Text = "Calculer"
        Me.btnCalculer.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(253, 241)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(131, 28)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Effacer"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnRetour
        '
        Me.btnRetour.Location = New System.Drawing.Point(269, 284)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(98, 28)
        Me.btnRetour.TabIndex = 8
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = True
        '
        'frmAireduCarre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(653, 333)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblReponseN)
        Me.Controls.Add(Me.lblReponse)
        Me.Controls.Add(Me.txtDimension)
        Me.Controls.Add(Me.lblDimension)
        Me.Controls.Add(Me.lblMessage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAireduCarre"
        Me.Text = "Aire du carré "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents lblDimension As Label
    Friend WithEvents txtDimension As TextBox
    Friend WithEvents lblReponse As Label
    Friend WithEvents lblReponseN As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnCalculer As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnRetour As Button
End Class
