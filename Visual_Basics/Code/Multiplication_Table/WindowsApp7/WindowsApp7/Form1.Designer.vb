<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTables
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
        Me.numTable = New System.Windows.Forms.NumericUpDown()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lstReponse = New System.Windows.Forms.ListBox()
        Me.lblTables = New System.Windows.Forms.Label()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnAfficher = New System.Windows.Forms.Button()
        CType(Me.numTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numTable
        '
        Me.numTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.numTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTable.Location = New System.Drawing.Point(84, 92)
        Me.numTable.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numTable.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numTable.Name = "numTable"
        Me.numTable.ReadOnly = True
        Me.numTable.Size = New System.Drawing.Size(43, 23)
        Me.numTable.TabIndex = 1
        Me.numTable.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.Location = New System.Drawing.Point(9, 29)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(173, 34)
        Me.lblTitre.TabIndex = 2
        Me.lblTitre.Text = "Cette application affiche " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "les tables de multiplication"
        '
        'lstReponse
        '
        Me.lstReponse.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstReponse.FormattingEnabled = True
        Me.lstReponse.Location = New System.Drawing.Point(185, 66)
        Me.lstReponse.Name = "lstReponse"
        Me.lstReponse.Size = New System.Drawing.Size(165, 212)
        Me.lstReponse.TabIndex = 3
        '
        'lblTables
        '
        Me.lblTables.AutoSize = True
        Me.lblTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTables.Location = New System.Drawing.Point(15, 94)
        Me.lblTables.Name = "lblTables"
        Me.lblTables.Size = New System.Drawing.Size(63, 17)
        Me.lblTables.TabIndex = 4
        Me.lblTables.Text = "Tables : "
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitter.Location = New System.Drawing.Point(35, 224)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(92, 34)
        Me.btnQuitter.TabIndex = 6
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'btnAfficher
        '
        Me.btnAfficher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAfficher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAfficher.Location = New System.Drawing.Point(35, 150)
        Me.btnAfficher.Name = "btnAfficher"
        Me.btnAfficher.Size = New System.Drawing.Size(92, 34)
        Me.btnAfficher.TabIndex = 7
        Me.btnAfficher.Text = "Afficher"
        Me.btnAfficher.UseVisualStyleBackColor = False
        '
        'frmTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(375, 298)
        Me.Controls.Add(Me.btnAfficher)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.lblTables)
        Me.Controls.Add(Me.lstReponse)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.numTable)
        Me.Name = "frmTables"
        Me.Text = "Table de multiplication"
        CType(Me.numTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numTable As NumericUpDown
    Friend WithEvents lblTitre As Label
    Friend WithEvents lstReponse As ListBox
    Friend WithEvents lblTables As Label
    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnAfficher As Button
End Class
