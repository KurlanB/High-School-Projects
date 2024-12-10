<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProgramme))
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnEyes = New System.Windows.Forms.Button()
        Me.btnHair = New System.Windows.Forms.Button()
        Me.btnPhoto = New System.Windows.Forms.Button()
        Me.btnEffacer = New System.Windows.Forms.Button()
        Me.lblHair = New System.Windows.Forms.Label()
        Me.lblEyes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(117, 33)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(376, 25)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Cliquez sur les boutons pour me découvrir"
        '
        'btnEyes
        '
        Me.btnEyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEyes.Location = New System.Drawing.Point(230, 176)
        Me.btnEyes.Name = "btnEyes"
        Me.btnEyes.Size = New System.Drawing.Size(143, 61)
        Me.btnEyes.TabIndex = 1
        Me.btnEyes.Text = "La couleur de mes yeux"
        Me.btnEyes.UseVisualStyleBackColor = True
        '
        'btnHair
        '
        Me.btnHair.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHair.Location = New System.Drawing.Point(54, 176)
        Me.btnHair.Name = "btnHair"
        Me.btnHair.Size = New System.Drawing.Size(143, 61)
        Me.btnHair.TabIndex = 2
        Me.btnHair.Text = "La couleur de mes cheveux"
        Me.btnHair.UseVisualStyleBackColor = True
        '
        'btnPhoto
        '
        Me.btnPhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhoto.Location = New System.Drawing.Point(407, 176)
        Me.btnPhoto.Name = "btnPhoto"
        Me.btnPhoto.Size = New System.Drawing.Size(143, 61)
        Me.btnPhoto.TabIndex = 3
        Me.btnPhoto.Text = "Ma photo"
        Me.btnPhoto.UseVisualStyleBackColor = True
        '
        'btnEffacer
        '
        Me.btnEffacer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEffacer.Location = New System.Drawing.Point(242, 255)
        Me.btnEffacer.Name = "btnEffacer"
        Me.btnEffacer.Size = New System.Drawing.Size(122, 27)
        Me.btnEffacer.TabIndex = 4
        Me.btnEffacer.Text = "Effacer"
        Me.btnEffacer.UseVisualStyleBackColor = True
        '
        'lblHair
        '
        Me.lblHair.AutoSize = True
        Me.lblHair.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHair.Location = New System.Drawing.Point(103, 115)
        Me.lblHair.Name = "lblHair"
        Me.lblHair.Size = New System.Drawing.Size(47, 25)
        Me.lblHair.TabIndex = 5
        Me.lblHair.Text = "Noir"
        Me.lblHair.Visible = False
        '
        'lblEyes
        '
        Me.lblEyes.AutoSize = True
        Me.lblEyes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEyes.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblEyes.Location = New System.Drawing.Point(268, 115)
        Me.lblEyes.Name = "lblEyes"
        Me.lblEyes.Size = New System.Drawing.Size(63, 25)
        Me.lblEyes.TabIndex = 6
        Me.lblEyes.Text = "Bruns"
        Me.lblEyes.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(543, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kurlan B."
        '
        'picPhoto
        '
        Me.picPhoto.Image = CType(resources.GetObject("picPhoto.Image"), System.Drawing.Image)
        Me.picPhoto.Location = New System.Drawing.Point(428, 72)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(100, 98)
        Me.picPhoto.TabIndex = 8
        Me.picPhoto.TabStop = False
        Me.picPhoto.Visible = False
        '
        'frmProgramme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 294)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEyes)
        Me.Controls.Add(Me.lblHair)
        Me.Controls.Add(Me.btnEffacer)
        Me.Controls.Add(Me.btnPhoto)
        Me.Controls.Add(Me.btnHair)
        Me.Controls.Add(Me.btnEyes)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "frmProgramme"
        Me.Text = "Je me présente"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnEyes As Button
    Friend WithEvents btnHair As Button
    Friend WithEvents btnPhoto As Button
    Friend WithEvents btnEffacer As Button
    Friend WithEvents lblHair As Label
    Friend WithEvents lblEyes As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picPhoto As PictureBox
End Class
