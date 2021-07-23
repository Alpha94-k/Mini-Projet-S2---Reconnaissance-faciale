<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnComparer = New System.Windows.Forms.Button()
        Me.btnAnnoterImage = New System.Windows.Forms.Button()
        Me.btnPrendrePhoto = New System.Windows.Forms.Button()
        Me.btnImporterFichier = New System.Windows.Forms.Button()
        Me.btnImporterImage = New System.Windows.Forms.Button()
        Me.gpbImage = New System.Windows.Forms.GroupBox()
        Me.lblRepFichier = New System.Windows.Forms.Label()
        Me.lblRepertoireFichier = New System.Windows.Forms.Label()
        Me.lblFichier = New System.Windows.Forms.Label()
        Me.lblRepImage = New System.Windows.Forms.Label()
        Me.lblRepertoireImage = New System.Windows.Forms.Label()
        Me.pcbImage = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.gpbImage.SuspendLayout()
        CType(Me.pcbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnComparer)
        Me.Panel1.Controls.Add(Me.btnAnnoterImage)
        Me.Panel1.Controls.Add(Me.btnPrendrePhoto)
        Me.Panel1.Controls.Add(Me.btnImporterFichier)
        Me.Panel1.Controls.Add(Me.btnImporterImage)
        Me.Panel1.Location = New System.Drawing.Point(12, 550)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 127)
        Me.Panel1.TabIndex = 0
        '
        'btnComparer
        '
        Me.btnComparer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComparer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComparer.ForeColor = System.Drawing.Color.Navy
        Me.btnComparer.Location = New System.Drawing.Point(710, 18)
        Me.btnComparer.Name = "btnComparer"
        Me.btnComparer.Size = New System.Drawing.Size(220, 88)
        Me.btnComparer.TabIndex = 4
        Me.btnComparer.Text = "Comparer le visage dans la base de données"
        Me.btnComparer.UseVisualStyleBackColor = False
        '
        'btnAnnoterImage
        '
        Me.btnAnnoterImage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnnoterImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnoterImage.ForeColor = System.Drawing.Color.Navy
        Me.btnAnnoterImage.Location = New System.Drawing.Point(374, 71)
        Me.btnAnnoterImage.Name = "btnAnnoterImage"
        Me.btnAnnoterImage.Size = New System.Drawing.Size(315, 35)
        Me.btnAnnoterImage.TabIndex = 3
        Me.btnAnnoterImage.Text = "Annoter l'image"
        Me.btnAnnoterImage.UseVisualStyleBackColor = False
        Me.btnAnnoterImage.Visible = False
        '
        'btnPrendrePhoto
        '
        Me.btnPrendrePhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPrendrePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrendrePhoto.ForeColor = System.Drawing.Color.Navy
        Me.btnPrendrePhoto.Location = New System.Drawing.Point(374, 18)
        Me.btnPrendrePhoto.Name = "btnPrendrePhoto"
        Me.btnPrendrePhoto.Size = New System.Drawing.Size(315, 36)
        Me.btnPrendrePhoto.TabIndex = 2
        Me.btnPrendrePhoto.Text = "Prendre une photo"
        Me.btnPrendrePhoto.UseVisualStyleBackColor = False
        '
        'btnImporterFichier
        '
        Me.btnImporterFichier.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImporterFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImporterFichier.ForeColor = System.Drawing.Color.Navy
        Me.btnImporterFichier.Location = New System.Drawing.Point(18, 70)
        Me.btnImporterFichier.Name = "btnImporterFichier"
        Me.btnImporterFichier.Size = New System.Drawing.Size(315, 36)
        Me.btnImporterFichier.TabIndex = 1
        Me.btnImporterFichier.Text = "Importer un fichier"
        Me.btnImporterFichier.UseVisualStyleBackColor = False
        '
        'btnImporterImage
        '
        Me.btnImporterImage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnImporterImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImporterImage.ForeColor = System.Drawing.Color.Navy
        Me.btnImporterImage.Location = New System.Drawing.Point(18, 18)
        Me.btnImporterImage.Name = "btnImporterImage"
        Me.btnImporterImage.Size = New System.Drawing.Size(315, 36)
        Me.btnImporterImage.TabIndex = 0
        Me.btnImporterImage.Text = "Importer une image"
        Me.btnImporterImage.UseVisualStyleBackColor = False
        '
        'gpbImage
        '
        Me.gpbImage.Controls.Add(Me.lblRepFichier)
        Me.gpbImage.Controls.Add(Me.lblRepertoireFichier)
        Me.gpbImage.Controls.Add(Me.lblFichier)
        Me.gpbImage.Controls.Add(Me.lblRepImage)
        Me.gpbImage.Controls.Add(Me.lblRepertoireImage)
        Me.gpbImage.Controls.Add(Me.pcbImage)
        Me.gpbImage.Location = New System.Drawing.Point(15, 12)
        Me.gpbImage.Name = "gpbImage"
        Me.gpbImage.Size = New System.Drawing.Size(950, 532)
        Me.gpbImage.TabIndex = 3
        Me.gpbImage.TabStop = False
        '
        'lblRepFichier
        '
        Me.lblRepFichier.AutoSize = True
        Me.lblRepFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepFichier.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblRepFichier.Location = New System.Drawing.Point(197, 492)
        Me.lblRepFichier.Name = "lblRepFichier"
        Me.lblRepFichier.Size = New System.Drawing.Size(0, 18)
        Me.lblRepFichier.TabIndex = 6
        '
        'lblRepertoireFichier
        '
        Me.lblRepertoireFichier.AutoSize = True
        Me.lblRepertoireFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepertoireFichier.ForeColor = System.Drawing.Color.Navy
        Me.lblRepertoireFichier.Location = New System.Drawing.Point(3, 492)
        Me.lblRepertoireFichier.Name = "lblRepertoireFichier"
        Me.lblRepertoireFichier.Size = New System.Drawing.Size(194, 20)
        Me.lblRepertoireFichier.TabIndex = 5
        Me.lblRepertoireFichier.Text = "Répertoire du fichier :"
        '
        'lblFichier
        '
        Me.lblFichier.AutoSize = True
        Me.lblFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFichier.ForeColor = System.Drawing.Color.Black
        Me.lblFichier.Location = New System.Drawing.Point(2, 510)
        Me.lblFichier.Name = "lblFichier"
        Me.lblFichier.Size = New System.Drawing.Size(352, 25)
        Me.lblFichier.TabIndex = 4
        Me.lblFichier.Text = "Importation du fichier avec succès !"
        Me.lblFichier.Visible = False
        '
        'lblRepImage
        '
        Me.lblRepImage.AutoSize = True
        Me.lblRepImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepImage.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblRepImage.Location = New System.Drawing.Point(213, 9)
        Me.lblRepImage.Name = "lblRepImage"
        Me.lblRepImage.Size = New System.Drawing.Size(0, 18)
        Me.lblRepImage.TabIndex = 3
        '
        'lblRepertoireImage
        '
        Me.lblRepertoireImage.AutoSize = True
        Me.lblRepertoireImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepertoireImage.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblRepertoireImage.Location = New System.Drawing.Point(6, 7)
        Me.lblRepertoireImage.Name = "lblRepertoireImage"
        Me.lblRepertoireImage.Size = New System.Drawing.Size(201, 20)
        Me.lblRepertoireImage.TabIndex = 2
        Me.lblRepertoireImage.Text = "Répertoire de l'image :"
        '
        'pcbImage
        '
        Me.pcbImage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pcbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.pcbImage.Location = New System.Drawing.Point(15, 42)
        Me.pcbImage.Name = "pcbImage"
        Me.pcbImage.Size = New System.Drawing.Size(929, 447)
        Me.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbImage.TabIndex = 1
        Me.pcbImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(978, 689)
        Me.Controls.Add(Me.gpbImage)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Search Face"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.ResumeLayout(False)
        Me.gpbImage.ResumeLayout(False)
        Me.gpbImage.PerformLayout()
        CType(Me.pcbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnImporterImage As System.Windows.Forms.Button
    Friend WithEvents pcbImage As System.Windows.Forms.PictureBox
    Friend WithEvents gpbImage As System.Windows.Forms.GroupBox
    Friend WithEvents lblRepertoireImage As System.Windows.Forms.Label
    Friend WithEvents btnImporterFichier As System.Windows.Forms.Button
    Friend WithEvents lblRepImage As System.Windows.Forms.Label
    Friend WithEvents lblFichier As System.Windows.Forms.Label
    Friend WithEvents lblRepertoireFichier As System.Windows.Forms.Label
    Friend WithEvents lblRepFichier As System.Windows.Forms.Label
    Friend WithEvents btnPrendrePhoto As System.Windows.Forms.Button
    Friend WithEvents btnAnnoterImage As System.Windows.Forms.Button
    Friend WithEvents btnComparer As System.Windows.Forms.Button
End Class
