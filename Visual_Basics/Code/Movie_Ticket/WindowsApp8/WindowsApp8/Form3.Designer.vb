<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoix))
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.picF9 = New System.Windows.Forms.PictureBox()
        Me.picDemonSlayer = New System.Windows.Forms.PictureBox()
        Me.picGodvKong = New System.Windows.Forms.PictureBox()
        Me.picWidow = New System.Windows.Forms.PictureBox()
        Me.lblHeure = New System.Windows.Forms.Label()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn1730 = New System.Windows.Forms.Button()
        Me.btn1515 = New System.Windows.Forms.Button()
        Me.btn1945 = New System.Windows.Forms.Button()
        Me.numAdulte = New System.Windows.Forms.NumericUpDown()
        Me.lblPersonnes = New System.Windows.Forms.Label()
        Me.lblAdulte = New System.Windows.Forms.Label()
        Me.lblEnfants = New System.Windows.Forms.Label()
        Me.numEnfant = New System.Windows.Forms.NumericUpDown()
        Me.lblAine = New System.Windows.Forms.Label()
        Me.numAines = New System.Windows.Forms.NumericUpDown()
        Me.btnContinuer = New System.Windows.Forms.Button()
        CType(Me.picF9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDemonSlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGodvKong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWidow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAdulte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numEnfant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numAines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilm
        '
        Me.lblFilm.AutoSize = True
        Me.lblFilm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFilm.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblFilm.Location = New System.Drawing.Point(41, 50)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Size = New System.Drawing.Size(427, 28)
        Me.lblFilm.TabIndex = 29
        Me.lblFilm.Text = "Choisissez le film que vous voulez visionner"
        '
        'picF9
        '
        Me.picF9.BackgroundImage = CType(resources.GetObject("picF9.BackgroundImage"), System.Drawing.Image)
        Me.picF9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picF9.Location = New System.Drawing.Point(265, 112)
        Me.picF9.Name = "picF9"
        Me.picF9.Size = New System.Drawing.Size(130, 192)
        Me.picF9.TabIndex = 33
        Me.picF9.TabStop = False
        '
        'picDemonSlayer
        '
        Me.picDemonSlayer.BackColor = System.Drawing.Color.White
        Me.picDemonSlayer.BackgroundImage = CType(resources.GetObject("picDemonSlayer.BackgroundImage"), System.Drawing.Image)
        Me.picDemonSlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDemonSlayer.Location = New System.Drawing.Point(106, 112)
        Me.picDemonSlayer.Name = "picDemonSlayer"
        Me.picDemonSlayer.Size = New System.Drawing.Size(130, 192)
        Me.picDemonSlayer.TabIndex = 32
        Me.picDemonSlayer.TabStop = False
        '
        'picGodvKong
        '
        Me.picGodvKong.BackgroundImage = CType(resources.GetObject("picGodvKong.BackgroundImage"), System.Drawing.Image)
        Me.picGodvKong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGodvKong.Location = New System.Drawing.Point(265, 334)
        Me.picGodvKong.Name = "picGodvKong"
        Me.picGodvKong.Size = New System.Drawing.Size(130, 196)
        Me.picGodvKong.TabIndex = 31
        Me.picGodvKong.TabStop = False
        '
        'picWidow
        '
        Me.picWidow.BackgroundImage = CType(resources.GetObject("picWidow.BackgroundImage"), System.Drawing.Image)
        Me.picWidow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWidow.Location = New System.Drawing.Point(106, 334)
        Me.picWidow.Name = "picWidow"
        Me.picWidow.Size = New System.Drawing.Size(130, 196)
        Me.picWidow.TabIndex = 30
        Me.picWidow.TabStop = False
        '
        'lblHeure
        '
        Me.lblHeure.AutoSize = True
        Me.lblHeure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeure.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblHeure.Location = New System.Drawing.Point(500, 50)
        Me.lblHeure.Name = "lblHeure"
        Me.lblHeure.Size = New System.Drawing.Size(317, 28)
        Me.lblHeure.TabIndex = 34
        Me.lblHeure.Text = "Choisissez l'heure de visionnage"
        '
        'btn13
        '
        Me.btn13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn13.FlatAppearance.BorderSize = 0
        Me.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn13.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn13.ForeColor = System.Drawing.Color.White
        Me.btn13.Location = New System.Drawing.Point(505, 124)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(136, 62)
        Me.btn13.TabIndex = 35
        Me.btn13.Text = "13:00"
        Me.btn13.UseVisualStyleBackColor = False
        '
        'btn1730
        '
        Me.btn1730.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn1730.FlatAppearance.BorderSize = 0
        Me.btn1730.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1730.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1730.ForeColor = System.Drawing.Color.White
        Me.btn1730.Location = New System.Drawing.Point(505, 224)
        Me.btn1730.Name = "btn1730"
        Me.btn1730.Size = New System.Drawing.Size(136, 62)
        Me.btn1730.TabIndex = 36
        Me.btn1730.Text = "17:30"
        Me.btn1730.UseVisualStyleBackColor = False
        '
        'btn1515
        '
        Me.btn1515.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn1515.FlatAppearance.BorderSize = 0
        Me.btn1515.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1515.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1515.ForeColor = System.Drawing.Color.White
        Me.btn1515.Location = New System.Drawing.Point(681, 124)
        Me.btn1515.Name = "btn1515"
        Me.btn1515.Size = New System.Drawing.Size(136, 62)
        Me.btn1515.TabIndex = 37
        Me.btn1515.Text = "15:15"
        Me.btn1515.UseVisualStyleBackColor = False
        '
        'btn1945
        '
        Me.btn1945.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btn1945.FlatAppearance.BorderSize = 0
        Me.btn1945.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1945.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1945.ForeColor = System.Drawing.Color.White
        Me.btn1945.Location = New System.Drawing.Point(681, 224)
        Me.btn1945.Name = "btn1945"
        Me.btn1945.Size = New System.Drawing.Size(136, 62)
        Me.btn1945.TabIndex = 38
        Me.btn1945.Text = "19:45"
        Me.btn1945.UseVisualStyleBackColor = False
        '
        'numAdulte
        '
        Me.numAdulte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAdulte.Location = New System.Drawing.Point(588, 374)
        Me.numAdulte.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numAdulte.Name = "numAdulte"
        Me.numAdulte.ReadOnly = True
        Me.numAdulte.Size = New System.Drawing.Size(50, 23)
        Me.numAdulte.TabIndex = 39
        '
        'lblPersonnes
        '
        Me.lblPersonnes.AutoSize = True
        Me.lblPersonnes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPersonnes.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonnes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblPersonnes.Location = New System.Drawing.Point(487, 317)
        Me.lblPersonnes.Name = "lblPersonnes"
        Me.lblPersonnes.Size = New System.Drawing.Size(341, 28)
        Me.lblPersonnes.TabIndex = 40
        Me.lblPersonnes.Text = "Choisissez le nombre de personnes"
        '
        'lblAdulte
        '
        Me.lblAdulte.AutoSize = True
        Me.lblAdulte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAdulte.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdulte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblAdulte.Location = New System.Drawing.Point(487, 368)
        Me.lblAdulte.Name = "lblAdulte"
        Me.lblAdulte.Size = New System.Drawing.Size(95, 28)
        Me.lblAdulte.TabIndex = 41
        Me.lblAdulte.Text = "Adultes :"
        '
        'lblEnfants
        '
        Me.lblEnfants.AutoSize = True
        Me.lblEnfants.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEnfants.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfants.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblEnfants.Location = New System.Drawing.Point(487, 417)
        Me.lblEnfants.Name = "lblEnfants"
        Me.lblEnfants.Size = New System.Drawing.Size(94, 28)
        Me.lblEnfants.TabIndex = 42
        Me.lblEnfants.Text = "Enfants :"
        '
        'numEnfant
        '
        Me.numEnfant.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEnfant.Location = New System.Drawing.Point(588, 423)
        Me.numEnfant.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numEnfant.Name = "numEnfant"
        Me.numEnfant.ReadOnly = True
        Me.numEnfant.Size = New System.Drawing.Size(50, 23)
        Me.numEnfant.TabIndex = 43
        '
        'lblAine
        '
        Me.lblAine.AutoSize = True
        Me.lblAine.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAine.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblAine.Location = New System.Drawing.Point(487, 463)
        Me.lblAine.Name = "lblAine"
        Me.lblAine.Size = New System.Drawing.Size(75, 28)
        Me.lblAine.TabIndex = 44
        Me.lblAine.Text = "Ainés :"
        '
        'numAines
        '
        Me.numAines.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numAines.Location = New System.Drawing.Point(568, 469)
        Me.numAines.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numAines.Name = "numAines"
        Me.numAines.ReadOnly = True
        Me.numAines.Size = New System.Drawing.Size(50, 23)
        Me.numAines.TabIndex = 45
        '
        'btnContinuer
        '
        Me.btnContinuer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnContinuer.FlatAppearance.BorderSize = 0
        Me.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuer.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuer.ForeColor = System.Drawing.Color.White
        Me.btnContinuer.Location = New System.Drawing.Point(712, 513)
        Me.btnContinuer.Name = "btnContinuer"
        Me.btnContinuer.Size = New System.Drawing.Size(145, 53)
        Me.btnContinuer.TabIndex = 46
        Me.btnContinuer.Text = "Continuer"
        Me.btnContinuer.UseVisualStyleBackColor = False
        '
        'frmChoix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(883, 587)
        Me.Controls.Add(Me.btnContinuer)
        Me.Controls.Add(Me.numAines)
        Me.Controls.Add(Me.lblAine)
        Me.Controls.Add(Me.numEnfant)
        Me.Controls.Add(Me.lblEnfants)
        Me.Controls.Add(Me.lblAdulte)
        Me.Controls.Add(Me.lblPersonnes)
        Me.Controls.Add(Me.numAdulte)
        Me.Controls.Add(Me.btn1945)
        Me.Controls.Add(Me.btn1515)
        Me.Controls.Add(Me.btn1730)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.lblHeure)
        Me.Controls.Add(Me.picF9)
        Me.Controls.Add(Me.picDemonSlayer)
        Me.Controls.Add(Me.picGodvKong)
        Me.Controls.Add(Me.picWidow)
        Me.Controls.Add(Me.lblFilm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChoix"
        CType(Me.picF9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDemonSlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGodvKong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWidow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAdulte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numEnfant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numAines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFilm As Label
    Friend WithEvents picF9 As PictureBox
    Friend WithEvents picDemonSlayer As PictureBox
    Friend WithEvents picGodvKong As PictureBox
    Friend WithEvents picWidow As PictureBox
    Friend WithEvents lblHeure As Label
    Friend WithEvents btn13 As Button
    Friend WithEvents btn1730 As Button
    Friend WithEvents btn1515 As Button
    Friend WithEvents btn1945 As Button
    Friend WithEvents numAdulte As NumericUpDown
    Friend WithEvents lblPersonnes As Label
    Friend WithEvents lblAdulte As Label
    Friend WithEvents lblEnfants As Label
    Friend WithEvents numEnfant As NumericUpDown
    Friend WithEvents lblAine As Label
    Friend WithEvents numAines As NumericUpDown
    Friend WithEvents btnContinuer As Button
End Class
