<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPay))
        Me.lblPaiement = New System.Windows.Forms.Label()
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.lblHeure = New System.Windows.Forms.Label()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlBande = New System.Windows.Forms.Panel()
        Me.picSkittle = New System.Windows.Forms.PictureBox()
        Me.picTwixs = New System.Windows.Forms.PictureBox()
        Me.picSourP = New System.Windows.Forms.PictureBox()
        Me.btnNonFriandise = New System.Windows.Forms.Button()
        Me.lblTwix = New System.Windows.Forms.Label()
        Me.lblSour = New System.Windows.Forms.Label()
        Me.lblSkittles = New System.Windows.Forms.Label()
        Me.numTwix = New System.Windows.Forms.NumericUpDown()
        Me.numSour = New System.Windows.Forms.NumericUpDown()
        Me.numSkittles = New System.Windows.Forms.NumericUpDown()
        Me.lblAdultes = New System.Windows.Forms.Label()
        Me.lblEnfants = New System.Windows.Forms.Label()
        Me.lblAines = New System.Windows.Forms.Label()
        Me.lblBillets = New System.Windows.Forms.Label()
        Me.lblFriandises = New System.Windows.Forms.Label()
        Me.lblCandy = New System.Windows.Forms.Label()
        Me.lblSoustotal = New System.Windows.Forms.Label()
        Me.lblTaxes = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnContinuer = New System.Windows.Forms.Button()
        Me.lblF = New System.Windows.Forms.Label()
        Me.lblH = New System.Windows.Forms.Label()
        Me.lblAd = New System.Windows.Forms.Label()
        Me.lblE = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblTwixN = New System.Windows.Forms.Label()
        Me.lblSourN = New System.Windows.Forms.Label()
        Me.lblSkittlesN = New System.Windows.Forms.Label()
        Me.lblSous = New System.Windows.Forms.Label()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblTot = New System.Windows.Forms.Label()
        CType(Me.picSkittle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwixs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSourP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTwix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSkittles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPaiement
        '
        Me.lblPaiement.AutoSize = True
        Me.lblPaiement.BackColor = System.Drawing.Color.White
        Me.lblPaiement.Font = New System.Drawing.Font("Nirmala UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaiement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblPaiement.Location = New System.Drawing.Point(457, 31)
        Me.lblPaiement.Name = "lblPaiement"
        Me.lblPaiement.Size = New System.Drawing.Size(138, 37)
        Me.lblPaiement.TabIndex = 0
        Me.lblPaiement.Text = "Paiement"
        '
        'lblFilm
        '
        Me.lblFilm.AutoSize = True
        Me.lblFilm.BackColor = System.Drawing.Color.White
        Me.lblFilm.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblFilm.Location = New System.Drawing.Point(457, 86)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Size = New System.Drawing.Size(93, 37)
        Me.lblFilm.TabIndex = 1
        Me.lblFilm.Text = "Film : "
        '
        'lblHeure
        '
        Me.lblHeure.AutoSize = True
        Me.lblHeure.BackColor = System.Drawing.Color.White
        Me.lblHeure.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeure.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblHeure.Location = New System.Drawing.Point(457, 130)
        Me.lblHeure.Name = "lblHeure"
        Me.lblHeure.Size = New System.Drawing.Size(116, 37)
        Me.lblHeure.TabIndex = 2
        Me.lblHeure.Text = "Heure : "
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.White
        Me.lblMenu.Font = New System.Drawing.Font("Nirmala UI", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(149, 31)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(90, 37)
        Me.lblMenu.TabIndex = 3
        Me.lblMenu.Text = "Menu"
        '
        'pnlBande
        '
        Me.pnlBande.BackColor = System.Drawing.Color.Black
        Me.pnlBande.Location = New System.Drawing.Point(401, 0)
        Me.pnlBande.Name = "pnlBande"
        Me.pnlBande.Size = New System.Drawing.Size(25, 588)
        Me.pnlBande.TabIndex = 4
        '
        'picSkittle
        '
        Me.picSkittle.BackgroundImage = CType(resources.GetObject("picSkittle.BackgroundImage"), System.Drawing.Image)
        Me.picSkittle.Location = New System.Drawing.Point(40, 346)
        Me.picSkittle.Name = "picSkittle"
        Me.picSkittle.Size = New System.Drawing.Size(149, 81)
        Me.picSkittle.TabIndex = 31
        Me.picSkittle.TabStop = False
        '
        'picTwixs
        '
        Me.picTwixs.BackgroundImage = CType(resources.GetObject("picTwixs.BackgroundImage"), System.Drawing.Image)
        Me.picTwixs.Location = New System.Drawing.Point(12, 99)
        Me.picTwixs.Name = "picTwixs"
        Me.picTwixs.Size = New System.Drawing.Size(211, 81)
        Me.picTwixs.TabIndex = 29
        Me.picTwixs.TabStop = False
        '
        'picSourP
        '
        Me.picSourP.BackgroundImage = CType(resources.GetObject("picSourP.BackgroundImage"), System.Drawing.Image)
        Me.picSourP.Location = New System.Drawing.Point(27, 212)
        Me.picSourP.Name = "picSourP"
        Me.picSourP.Size = New System.Drawing.Size(177, 106)
        Me.picSourP.TabIndex = 30
        Me.picSourP.TabStop = False
        '
        'btnNonFriandise
        '
        Me.btnNonFriandise.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnNonFriandise.FlatAppearance.BorderSize = 0
        Me.btnNonFriandise.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNonFriandise.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNonFriandise.ForeColor = System.Drawing.Color.White
        Me.btnNonFriandise.Location = New System.Drawing.Point(70, 450)
        Me.btnNonFriandise.Name = "btnNonFriandise"
        Me.btnNonFriandise.Size = New System.Drawing.Size(268, 49)
        Me.btnNonFriandise.TabIndex = 32
        Me.btnNonFriandise.Text = "JE NE VEUX PAS DE FRIANDISE"
        Me.btnNonFriandise.UseVisualStyleBackColor = False
        '
        'lblTwix
        '
        Me.lblTwix.AutoSize = True
        Me.lblTwix.BackColor = System.Drawing.Color.White
        Me.lblTwix.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblTwix.Location = New System.Drawing.Point(229, 121)
        Me.lblTwix.Name = "lblTwix"
        Me.lblTwix.Size = New System.Drawing.Size(49, 37)
        Me.lblTwix.TabIndex = 33
        Me.lblTwix.Text = "3$"
        '
        'lblSour
        '
        Me.lblSour.AutoSize = True
        Me.lblSour.BackColor = System.Drawing.Color.White
        Me.lblSour.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSour.Location = New System.Drawing.Point(229, 248)
        Me.lblSour.Name = "lblSour"
        Me.lblSour.Size = New System.Drawing.Size(49, 37)
        Me.lblSour.TabIndex = 34
        Me.lblSour.Text = "1$"
        '
        'lblSkittles
        '
        Me.lblSkittles.AutoSize = True
        Me.lblSkittles.BackColor = System.Drawing.Color.White
        Me.lblSkittles.Font = New System.Drawing.Font("Nirmala UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkittles.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSkittles.Location = New System.Drawing.Point(229, 371)
        Me.lblSkittles.Name = "lblSkittles"
        Me.lblSkittles.Size = New System.Drawing.Size(49, 37)
        Me.lblSkittles.TabIndex = 35
        Me.lblSkittles.Text = "2$"
        '
        'numTwix
        '
        Me.numTwix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTwix.Location = New System.Drawing.Point(287, 129)
        Me.numTwix.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numTwix.Name = "numTwix"
        Me.numTwix.ReadOnly = True
        Me.numTwix.Size = New System.Drawing.Size(51, 26)
        Me.numTwix.TabIndex = 36
        '
        'numSour
        '
        Me.numSour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSour.Location = New System.Drawing.Point(287, 256)
        Me.numSour.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numSour.Name = "numSour"
        Me.numSour.ReadOnly = True
        Me.numSour.Size = New System.Drawing.Size(51, 26)
        Me.numSour.TabIndex = 37
        '
        'numSkittles
        '
        Me.numSkittles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSkittles.Location = New System.Drawing.Point(287, 379)
        Me.numSkittles.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numSkittles.Name = "numSkittles"
        Me.numSkittles.ReadOnly = True
        Me.numSkittles.Size = New System.Drawing.Size(51, 26)
        Me.numSkittles.TabIndex = 38
        '
        'lblAdultes
        '
        Me.lblAdultes.AutoSize = True
        Me.lblAdultes.BackColor = System.Drawing.Color.White
        Me.lblAdultes.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdultes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblAdultes.Location = New System.Drawing.Point(457, 218)
        Me.lblAdultes.Name = "lblAdultes"
        Me.lblAdultes.Size = New System.Drawing.Size(199, 28)
        Me.lblAdultes.TabIndex = 39
        Me.lblAdultes.Text = "Nombre d'adultes : "
        '
        'lblEnfants
        '
        Me.lblEnfants.AutoSize = True
        Me.lblEnfants.BackColor = System.Drawing.Color.White
        Me.lblEnfants.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfants.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblEnfants.Location = New System.Drawing.Point(457, 260)
        Me.lblEnfants.Name = "lblEnfants"
        Me.lblEnfants.Size = New System.Drawing.Size(201, 28)
        Me.lblEnfants.TabIndex = 40
        Me.lblEnfants.Text = "Nombre d'enfants : "
        '
        'lblAines
        '
        Me.lblAines.AutoSize = True
        Me.lblAines.BackColor = System.Drawing.Color.White
        Me.lblAines.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAines.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblAines.Location = New System.Drawing.Point(457, 302)
        Me.lblAines.Name = "lblAines"
        Me.lblAines.Size = New System.Drawing.Size(170, 28)
        Me.lblAines.TabIndex = 41
        Me.lblAines.Text = "Nombre d'ainé : "
        '
        'lblBillets
        '
        Me.lblBillets.AutoSize = True
        Me.lblBillets.BackColor = System.Drawing.Color.White
        Me.lblBillets.Font = New System.Drawing.Font("Nirmala UI", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblBillets.Location = New System.Drawing.Point(456, 180)
        Me.lblBillets.Name = "lblBillets"
        Me.lblBillets.Size = New System.Drawing.Size(81, 31)
        Me.lblBillets.TabIndex = 42
        Me.lblBillets.Text = "Billets"
        '
        'lblFriandises
        '
        Me.lblFriandises.AutoSize = True
        Me.lblFriandises.BackColor = System.Drawing.Color.White
        Me.lblFriandises.Font = New System.Drawing.Font("Nirmala UI", 17.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriandises.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblFriandises.Location = New System.Drawing.Point(456, 341)
        Me.lblFriandises.Name = "lblFriandises"
        Me.lblFriandises.Size = New System.Drawing.Size(121, 31)
        Me.lblFriandises.TabIndex = 43
        Me.lblFriandises.Text = "Friandises"
        '
        'lblCandy
        '
        Me.lblCandy.AutoSize = True
        Me.lblCandy.BackColor = System.Drawing.Color.White
        Me.lblCandy.Font = New System.Drawing.Font("Nirmala UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblCandy.Location = New System.Drawing.Point(456, 381)
        Me.lblCandy.Name = "lblCandy"
        Me.lblCandy.Size = New System.Drawing.Size(367, 31)
        Me.lblCandy.TabIndex = 44
        Me.lblCandy.Text = "Twix :      Sour Patch :      Skittles :"
        '
        'lblSoustotal
        '
        Me.lblSoustotal.AutoSize = True
        Me.lblSoustotal.BackColor = System.Drawing.Color.White
        Me.lblSoustotal.Font = New System.Drawing.Font("Nirmala UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoustotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSoustotal.Location = New System.Drawing.Point(456, 423)
        Me.lblSoustotal.Name = "lblSoustotal"
        Me.lblSoustotal.Size = New System.Drawing.Size(137, 31)
        Me.lblSoustotal.TabIndex = 45
        Me.lblSoustotal.Text = "Sous-total :"
        '
        'lblTaxes
        '
        Me.lblTaxes.AutoSize = True
        Me.lblTaxes.BackColor = System.Drawing.Color.White
        Me.lblTaxes.Font = New System.Drawing.Font("Nirmala UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblTaxes.Location = New System.Drawing.Point(456, 460)
        Me.lblTaxes.Name = "lblTaxes"
        Me.lblTaxes.Size = New System.Drawing.Size(84, 31)
        Me.lblTaxes.TabIndex = 46
        Me.lblTaxes.Text = "Taxes :"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Nirmala UI", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(456, 498)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(79, 31)
        Me.lblTotal.TabIndex = 47
        Me.lblTotal.Text = "Total :"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Nirmala UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(712, 517)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(147, 58)
        Me.btnConfirm.TabIndex = 48
        Me.btnConfirm.Text = "Confirmer"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnContinuer
        '
        Me.btnContinuer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnContinuer.FlatAppearance.BorderSize = 0
        Me.btnContinuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContinuer.Font = New System.Drawing.Font("Nirmala UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinuer.ForeColor = System.Drawing.Color.White
        Me.btnContinuer.Location = New System.Drawing.Point(138, 519)
        Me.btnContinuer.Name = "btnContinuer"
        Me.btnContinuer.Size = New System.Drawing.Size(125, 45)
        Me.btnContinuer.TabIndex = 49
        Me.btnContinuer.Text = "Calculer"
        Me.btnContinuer.UseVisualStyleBackColor = False
        '
        'lblF
        '
        Me.lblF.AutoSize = True
        Me.lblF.BackColor = System.Drawing.Color.White
        Me.lblF.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblF.Location = New System.Drawing.Point(548, 93)
        Me.lblF.Name = "lblF"
        Me.lblF.Size = New System.Drawing.Size(0, 28)
        Me.lblF.TabIndex = 50
        '
        'lblH
        '
        Me.lblH.AutoSize = True
        Me.lblH.BackColor = System.Drawing.Color.White
        Me.lblH.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblH.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblH.Location = New System.Drawing.Point(571, 137)
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(0, 28)
        Me.lblH.TabIndex = 51
        '
        'lblAd
        '
        Me.lblAd.AutoSize = True
        Me.lblAd.BackColor = System.Drawing.Color.White
        Me.lblAd.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblAd.Location = New System.Drawing.Point(656, 218)
        Me.lblAd.Name = "lblAd"
        Me.lblAd.Size = New System.Drawing.Size(0, 28)
        Me.lblAd.TabIndex = 52
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.BackColor = System.Drawing.Color.White
        Me.lblE.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblE.Location = New System.Drawing.Point(656, 260)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(0, 28)
        Me.lblE.TabIndex = 53
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.BackColor = System.Drawing.Color.White
        Me.lblA.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblA.Location = New System.Drawing.Point(630, 302)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(0, 28)
        Me.lblA.TabIndex = 54
        '
        'lblTwixN
        '
        Me.lblTwixN.AutoSize = True
        Me.lblTwixN.BackColor = System.Drawing.Color.White
        Me.lblTwixN.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwixN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblTwixN.Location = New System.Drawing.Point(526, 383)
        Me.lblTwixN.Name = "lblTwixN"
        Me.lblTwixN.Size = New System.Drawing.Size(0, 28)
        Me.lblTwixN.TabIndex = 55
        '
        'lblSourN
        '
        Me.lblSourN.AutoSize = True
        Me.lblSourN.BackColor = System.Drawing.Color.White
        Me.lblSourN.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSourN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSourN.Location = New System.Drawing.Point(690, 383)
        Me.lblSourN.Name = "lblSourN"
        Me.lblSourN.Size = New System.Drawing.Size(0, 28)
        Me.lblSourN.TabIndex = 56
        '
        'lblSkittlesN
        '
        Me.lblSkittlesN.AutoSize = True
        Me.lblSkittlesN.BackColor = System.Drawing.Color.White
        Me.lblSkittlesN.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkittlesN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSkittlesN.Location = New System.Drawing.Point(823, 383)
        Me.lblSkittlesN.Name = "lblSkittlesN"
        Me.lblSkittlesN.Size = New System.Drawing.Size(0, 28)
        Me.lblSkittlesN.TabIndex = 57
        '
        'lblSous
        '
        Me.lblSous.AutoSize = True
        Me.lblSous.BackColor = System.Drawing.Color.White
        Me.lblSous.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblSous.Location = New System.Drawing.Point(595, 425)
        Me.lblSous.Name = "lblSous"
        Me.lblSous.Size = New System.Drawing.Size(0, 28)
        Me.lblSous.TabIndex = 58
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.BackColor = System.Drawing.Color.White
        Me.lblT.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblT.Location = New System.Drawing.Point(540, 462)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(0, 28)
        Me.lblT.TabIndex = 59
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.Color.White
        Me.lblTot.Font = New System.Drawing.Font("Nirmala UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.lblTot.Location = New System.Drawing.Point(535, 500)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(0, 28)
        Me.lblTot.TabIndex = 60
        '
        'frmPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(883, 587)
        Me.Controls.Add(Me.lblTot)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.lblSous)
        Me.Controls.Add(Me.lblSkittlesN)
        Me.Controls.Add(Me.lblSourN)
        Me.Controls.Add(Me.lblTwixN)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.lblAd)
        Me.Controls.Add(Me.lblH)
        Me.Controls.Add(Me.lblF)
        Me.Controls.Add(Me.btnContinuer)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTaxes)
        Me.Controls.Add(Me.lblSoustotal)
        Me.Controls.Add(Me.lblCandy)
        Me.Controls.Add(Me.lblFriandises)
        Me.Controls.Add(Me.lblBillets)
        Me.Controls.Add(Me.lblAines)
        Me.Controls.Add(Me.lblEnfants)
        Me.Controls.Add(Me.lblAdultes)
        Me.Controls.Add(Me.numSkittles)
        Me.Controls.Add(Me.numSour)
        Me.Controls.Add(Me.numTwix)
        Me.Controls.Add(Me.lblSkittles)
        Me.Controls.Add(Me.lblSour)
        Me.Controls.Add(Me.lblTwix)
        Me.Controls.Add(Me.btnNonFriandise)
        Me.Controls.Add(Me.picSkittle)
        Me.Controls.Add(Me.picTwixs)
        Me.Controls.Add(Me.picSourP)
        Me.Controls.Add(Me.pnlBande)
        Me.Controls.Add(Me.lblMenu)
        Me.Controls.Add(Me.lblHeure)
        Me.Controls.Add(Me.lblFilm)
        Me.Controls.Add(Me.lblPaiement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPay"
        Me.Text = "Form4"
        CType(Me.picSkittle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwixs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSourP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTwix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSkittles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPaiement As Label
    Friend WithEvents lblFilm As Label
    Friend WithEvents lblHeure As Label
    Friend WithEvents lblMenu As Label
    Friend WithEvents pnlBande As Panel
    Friend WithEvents picSkittle As PictureBox
    Friend WithEvents picTwixs As PictureBox
    Friend WithEvents picSourP As PictureBox
    Friend WithEvents btnNonFriandise As Button
    Friend WithEvents lblTwix As Label
    Friend WithEvents lblSour As Label
    Friend WithEvents lblSkittles As Label
    Friend WithEvents numTwix As NumericUpDown
    Friend WithEvents numSour As NumericUpDown
    Friend WithEvents numSkittles As NumericUpDown
    Friend WithEvents lblAdultes As Label
    Friend WithEvents lblEnfants As Label
    Friend WithEvents lblAines As Label
    Friend WithEvents lblBillets As Label
    Friend WithEvents lblFriandises As Label
    Friend WithEvents lblCandy As Label
    Friend WithEvents lblSoustotal As Label
    Friend WithEvents lblTaxes As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnContinuer As Button
    Friend WithEvents lblF As Label
    Friend WithEvents lblH As Label
    Friend WithEvents lblAd As Label
    Friend WithEvents lblE As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblTwixN As Label
    Friend WithEvents lblSourN As Label
    Friend WithEvents lblSkittlesN As Label
    Friend WithEvents lblSous As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblTot As Label
End Class
