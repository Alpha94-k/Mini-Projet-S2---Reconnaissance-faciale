<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOKseuil = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.TextBoxseuil = New System.Windows.Forms.TextBox()
        Me.labelseuil = New System.Windows.Forms.Label()
        Me.pcbImage2 = New System.Windows.Forms.PictureBox()
        Me.lblNatureAnnotation = New System.Windows.Forms.Label()
        Me.btnAnnoterImage = New System.Windows.Forms.Button()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.btn_Sauvegarder = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pcbAnnotation1 = New System.Windows.Forms.PictureBox()
        Me.btnComparerVisage = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pcbImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbAnnotation1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOKseuil)
        Me.GroupBox1.Controls.Add(Me.btnAnnuler)
        Me.GroupBox1.Controls.Add(Me.TextBoxseuil)
        Me.GroupBox1.Controls.Add(Me.labelseuil)
        Me.GroupBox1.Controls.Add(Me.pcbImage2)
        Me.GroupBox1.Location = New System.Drawing.Point(255, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(903, 639)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnOKseuil
        '
        Me.btnOKseuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKseuil.Location = New System.Drawing.Point(439, 304)
        Me.btnOKseuil.Name = "btnOKseuil"
        Me.btnOKseuil.Size = New System.Drawing.Size(75, 26)
        Me.btnOKseuil.TabIndex = 9
        Me.btnOKseuil.Text = "OK"
        Me.btnOKseuil.UseVisualStyleBackColor = True
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.Location = New System.Drawing.Point(531, 304)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(110, 26)
        Me.btnAnnuler.TabIndex = 8
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = True
        '
        'TextBoxseuil
        '
        Me.TextBoxseuil.Location = New System.Drawing.Point(233, 304)
        Me.TextBoxseuil.Multiline = True
        Me.TextBoxseuil.Name = "TextBoxseuil"
        Me.TextBoxseuil.Size = New System.Drawing.Size(185, 26)
        Me.TextBoxseuil.TabIndex = 7
        '
        'labelseuil
        '
        Me.labelseuil.AutoSize = True
        Me.labelseuil.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelseuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelseuil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelseuil.Location = New System.Drawing.Point(174, 259)
        Me.labelseuil.Name = "labelseuil"
        Me.labelseuil.Size = New System.Drawing.Size(493, 25)
        Me.labelseuil.TabIndex = 6
        Me.labelseuil.Text = "Veuillez rentrer le seuil pour la comparaison des images"
        '
        'pcbImage2
        '
        Me.pcbImage2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pcbImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbImage2.Location = New System.Drawing.Point(0, 18)
        Me.pcbImage2.Name = "pcbImage2"
        Me.pcbImage2.Size = New System.Drawing.Size(891, 609)
        Me.pcbImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbImage2.TabIndex = 0
        Me.pcbImage2.TabStop = False
        '
        'lblNatureAnnotation
        '
        Me.lblNatureAnnotation.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblNatureAnnotation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNatureAnnotation.ForeColor = System.Drawing.Color.Red
        Me.lblNatureAnnotation.Location = New System.Drawing.Point(252, 18)
        Me.lblNatureAnnotation.Name = "lblNatureAnnotation"
        Me.lblNatureAnnotation.Size = New System.Drawing.Size(900, 23)
        Me.lblNatureAnnotation.TabIndex = 1
        Me.lblNatureAnnotation.Text = "Nature annotation "
        Me.lblNatureAnnotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnnoterImage
        '
        Me.btnAnnoterImage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnnoterImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnoterImage.ForeColor = System.Drawing.Color.Navy
        Me.btnAnnoterImage.Location = New System.Drawing.Point(12, 106)
        Me.btnAnnoterImage.Name = "btnAnnoterImage"
        Me.btnAnnoterImage.Size = New System.Drawing.Size(237, 83)
        Me.btnAnnoterImage.TabIndex = 1
        Me.btnAnnoterImage.Text = "Ajouter une annotation"
        Me.btnAnnoterImage.UseVisualStyleBackColor = False
        '
        'btnValider
        '
        Me.btnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnValider.Location = New System.Drawing.Point(12, 195)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(237, 31)
        Me.btnValider.TabIndex = 3
        Me.btnValider.Text = "Valider l'annotation"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'btn_Sauvegarder
        '
        Me.btn_Sauvegarder.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Sauvegarder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sauvegarder.ForeColor = System.Drawing.Color.Navy
        Me.btn_Sauvegarder.Location = New System.Drawing.Point(12, 252)
        Me.btn_Sauvegarder.Name = "btn_Sauvegarder"
        Me.btn_Sauvegarder.Size = New System.Drawing.Size(237, 93)
        Me.btn_Sauvegarder.TabIndex = 1
        Me.btn_Sauvegarder.Text = "Sauvegarder"
        Me.btn_Sauvegarder.UseVisualStyleBackColor = False
        '
        'pcbAnnotation1
        '
        Me.pcbAnnotation1.BackColor = System.Drawing.Color.Transparent
        Me.pcbAnnotation1.Image = Global.Mini_Projet_IHM.My.Resources.Resources.croixRouge
        Me.pcbAnnotation1.Location = New System.Drawing.Point(12, 12)
        Me.pcbAnnotation1.Name = "pcbAnnotation1"
        Me.pcbAnnotation1.Size = New System.Drawing.Size(20, 20)
        Me.pcbAnnotation1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pcbAnnotation1.TabIndex = 2
        Me.pcbAnnotation1.TabStop = False
        '
        'btnComparerVisage
        '
        Me.btnComparerVisage.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnComparerVisage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComparerVisage.ForeColor = System.Drawing.Color.Navy
        Me.btnComparerVisage.Location = New System.Drawing.Point(12, 351)
        Me.btnComparerVisage.Name = "btnComparerVisage"
        Me.btnComparerVisage.Size = New System.Drawing.Size(237, 99)
        Me.btnComparerVisage.TabIndex = 4
        Me.btnComparerVisage.Text = "Comparer le visage"
        Me.btnComparerVisage.UseVisualStyleBackColor = False
        Me.btnComparerVisage.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1170, 689)
        Me.Controls.Add(Me.btnComparerVisage)
        Me.Controls.Add(Me.lblNatureAnnotation)
        Me.Controls.Add(Me.btn_Sauvegarder)
        Me.Controls.Add(Me.btnValider)
        Me.Controls.Add(Me.pcbAnnotation1)
        Me.Controls.Add(Me.btnAnnoterImage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Search Face"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pcbImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbAnnotation1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pcbImage2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAnnoterImage As System.Windows.Forms.Button
    Friend WithEvents pcbAnnotation1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents btn_Sauvegarder As Button
    Friend WithEvents lblNatureAnnotation As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnComparerVisage As System.Windows.Forms.Button
    Friend WithEvents TextBoxseuil As TextBox
    Friend WithEvents labelseuil As Label
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnOKseuil As Button
End Class
