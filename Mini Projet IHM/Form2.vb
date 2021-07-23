Imports Excel = Microsoft.Office.Interop.Excel
Imports xlsx = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Imports System.IO
Public Class Form2

#Region "Déclarations de variable"
    Dim image2 As Image = Form1.image
    Dim verif As Boolean = False
    Dim compteur As Integer = 0
    Dim Y1, Y2, Y3, BVG, BVD, BN, BNG, BND, BM, HL, BL, LG, LD As Point

    Dim str As String
    Dim ratioL, ratioN, ratioV, ratioY As Double
    Dim HauteurLèvre, LargeurLèvre, HauteurNez, LargeurNez, HauteurVisage, LargeurVisage, LargeurYeux As Double
    Dim appxlsx As xlsx.Application
    Dim sheetxlsx As xlsx.Worksheet
    Dim c1 As String = Application.StartupPath()

    Dim x As Integer = c1.Length - 9
    Public cheminSauveFichier As String = c1.Remove(x, 9) + "sauvegardeAnnotations"



    Public cheminSauveRatio As String = c1.Remove(x, 9) + "sauvegardeAnnotations\SauvegardeDesRatios.xlsx"
    Public nb As Integer = 1
    Public celluleVide As String = ""
    Dim ratioTemporaireL, ratioTemporaireN, ratioTemporaireV, ratioTemporaireY As Double

#End Region
#Region "Fonction pour les calculs"
    'fonction qui permet de calculer la distance entre 2 points, elle prend 4 arguments: d'abord les coordonnées x des 2 points et ensuite les coordonnées y des 2 points
    Function obtenirdistance(ByVal a1 As Double, ByVal a2 As Double, ByVal b1 As Double, ByVal b2 As Double) As Double
        Return Math.Sqrt(Sqr(a1 - a2) + Sqr(b1 - b2))
    End Function

    'fonction qui permet de calculer le carré d'une valeur
    Function Sqr(ByVal a As Double) As Double
        Return a * a
    End Function


    'fonction permettant de calculer les coordonnées du milieu entre 2 points
    Function obtenirMilieu(ByVal a1 As Double, ByVal a2 As Double, ByVal b1 As Double, ByVal b2 As Double) As Point
        Dim Y3 As New Point
        Y3.X = (a1 + b1) / 2
        Y3.Y = (a2 + b2) / 2
        Return Y3
    End Function
#End Region
#Region "Procédures à effectuer selon les traitements à effectués par l'utilisateur"
    Public Sub Initialisation()
        pcbImage2.Image = image2
        pcbAnnotation1.Hide()
    End Sub
    Public Sub AfficherImportationFichier()
        btnAnnoterImage.Hide()
        btnValider.Hide()
        lblNatureAnnotation.Hide()
        labelseuil.Hide()
        TextBoxseuil.Hide()
        btnOKseuil.Hide()
        btnAnnuler.Hide()
        btn_Sauvegarder.Visible = False
        btnComparerVisage.Visible = False

        'On ajoute pour chaque cellule du fichier importer dans la form1, son annotation
        Dim anoY1 As New PictureBox
        anoY1.Image = pcbAnnotation1.Image
        anoY1.BackColor = Color.Transparent
        anoY1.Size = New Point(15, 15)
        anoY1.Location = Form1.Y1
        anoY1.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoY1)
        Y1 = anoY1.Location

        Dim anoY2 As New PictureBox
        anoY2.Image = pcbAnnotation1.Image
        anoY2.BackColor = Color.Transparent
        anoY2.Size = New Point(15, 15)
        anoY2.Location = Form1.Y2
        anoY2.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoY2)
        Y2 = anoY2.Location

        Dim anoBVG As New PictureBox
        anoBVG.Image = pcbAnnotation1.Image
        anoBVG.BackColor = Color.Transparent
        anoBVG.Size = New Point(15, 15)
        anoBVG.Location = Form1.BVG
        anoBVG.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBVG)
        BVG = anoBVG.Location

        Dim anoBVD As New PictureBox
        anoBVD.Image = pcbAnnotation1.Image
        anoBVD.BackColor = Color.Transparent
        anoBVD.Size = New Point(15, 15)
        anoBVD.Location = Form1.BVD
        anoBVD.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBVD)
        BVG = anoBVD.Location

        Dim anoBN As New PictureBox
        anoBVD.Image = pcbAnnotation1.Image
        anoBVD.BackColor = Color.Transparent
        anoBVD.Size = New Point(15, 15)
        anoBVD.Location = Form1.BN
        anoBVD.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBN)
        BN = anoBN.Location

        Dim anoBNG As New PictureBox
        anoBNG.Image = pcbAnnotation1.Image
        anoBNG.BackColor = Color.Transparent
        anoBNG.Size = New Point(15, 15)
        anoBNG.Location = Form1.BNG
        anoBNG.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBNG)
        BNG = anoBNG.Location

        Dim anoBND As New PictureBox
        anoBND.Image = pcbAnnotation1.Image
        anoBND.BackColor = Color.Transparent
        anoBND.Size = New Point(15, 15)
        anoBND.Location = Form1.BND
        anoBND.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBND)
        BND = anoBND.Location

        Dim anoBM As New PictureBox
        anoBM.Image = pcbAnnotation1.Image
        anoBM.BackColor = Color.Transparent
        anoBM.Size = New Point(15, 15)
        anoBM.Location = Form1.BM
        anoBM.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBM)
        BM = anoBM.Location

        Dim anoHL As New PictureBox
        anoHL.Image = pcbAnnotation1.Image
        anoHL.BackColor = Color.Transparent
        anoHL.Size = New Point(15, 15)
        anoHL.Location = Form1.HL
        anoHL.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoHL)
        HL = anoHL.Location

        Dim anoBL As New PictureBox
        anoBL.Image = pcbAnnotation1.Image
        anoBL.BackColor = Color.Transparent
        anoBL.Size = New Point(15, 15)
        anoBL.Location = Form1.BL
        anoBL.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoBL)
        BL = anoBL.Location

        Dim anoLG As New PictureBox
        anoLG.Image = pcbAnnotation1.Image
        anoLG.BackColor = Color.Transparent
        anoLG.Size = New Point(15, 15)
        anoLG.Location = Form1.LG
        anoLG.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoLG)
        LG = anoLG.Location

        Dim anoLD As New PictureBox
        anoLD.Image = pcbAnnotation1.Image
        anoLD.BackColor = Color.Transparent
        anoLD.Size = New Point(15, 15)
        anoLD.Location = Form1.LD
        anoLD.SizeMode = PictureBoxSizeMode.Zoom
        pcbImage2.Controls.Add(anoLD)
        LD = anoLD.Location
    End Sub
    Public Sub AfficherComparerVisage()
        btnAnnoterImage.Hide()
        btnValider.Hide()
        lblNatureAnnotation.Hide()
        btn_Sauvegarder.Hide()
        btnComparerVisage.Hide()
        labelseuil.Show()
        TextBoxseuil.Show()
        btnOKseuil.Show()
        btnAnnuler.Show()
    End Sub
    Public Sub AfficherAnnoterImage()
        btnAnnoterImage.Show()
        btnValider.Show()
        lblNatureAnnotation.Show()
        btnComparerVisage.Hide()
        labelseuil.Hide()
        TextBoxseuil.Hide()
        btnOKseuil.Hide()
        btnAnnuler.Hide()
    End Sub
#End Region
#Region "Procédures évenementielles"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_Sauvegarder.Visible = False
        Initialisation()
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAnnoterImage.Click
        pcbImage2.Cursor = Cursors.Cross
        verif = True
        MessageBox.Show("ATTENTION! À chaque annotation, il faut valider celle-ci sinon elle ne sera pas prise en compte!")
        lblNatureAnnotation.Text = "Centre oeil gauche"
        btnAnnoterImage.Hide()
    End Sub

    Private Sub pcbImage2_MouseClick(sender As Object, e As MouseEventArgs) Handles pcbImage2.MouseClick

        'on ajoute des annotation à chaque clic sur pcbImage2
        If verif = True Then
            Dim annotation As New PictureBox
            annotation.Image = pcbAnnotation1.Image
            annotation.BackColor = Color.Transparent
            annotation.Size = New Point(15, 15)
            annotation.Location = New Point(e.X - 8, e.Y - 8)
            annotation.SizeMode = PictureBoxSizeMode.Zoom
            pcbImage2.Controls.Add(annotation)

            'Initialise les points des annotations sur les variables d'annotations déclarer avec un compteur
            If compteur = 0 Then
                Y1 = annotation.Location
            End If
            If compteur = 1 Then
                Y2 = annotation.Location
            End If
            If compteur = 2 Then
                BVG = annotation.Location
            End If
            If compteur = 3 Then
                BVD = annotation.Location
            End If
            If compteur = 4 Then
                BN = annotation.Location
            End If
            If compteur = 5 Then
                BNG = annotation.Location
            End If
            If compteur = 6 Then
                BND = annotation.Location
            End If
            If compteur = 7 Then
                BM = annotation.Location
            End If
            If compteur = 8 Then
                HL = annotation.Location
            End If
            If compteur = 9 Then
                BL = annotation.Location
            End If
            If compteur = 10 Then
                LG = annotation.Location
            End If
            If compteur = 11 Then
                LD = annotation.Location
            End If
            If compteur = 12 Then
                MessageBox.Show("Vous ne pouvez plus annoter l'image!")
            End If

            compteur = compteur + 1
        End If
    End Sub

    'on affiche ce que l'utilisateur doit faire après chaque clic sur le bouton btnvalider
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If compteur = 1 Then
            lblNatureAnnotation.Text = "Centre oeil droit"
        ElseIf compteur = 2 Then
            lblNatureAnnotation.Text = "Bord du visage le plus à gauche alignès avec les yeux"
        ElseIf compteur = 3 Then
            lblNatureAnnotation.Text = "Bord du visage le plus à droite alignès avec les yeux"
        ElseIf compteur = 4 Then
            lblNatureAnnotation.Text = "Bas du nez"
        ElseIf compteur = 5 Then
            lblNatureAnnotation.Text = "Bord du nez le plus à gauche"
        ElseIf compteur = 6 Then
            lblNatureAnnotation.Text = "Bord du nez le plus à droite"
        ElseIf compteur = 7 Then
            lblNatureAnnotation.Text = "Bas du menton"
        ElseIf compteur = 8 Then
            lblNatureAnnotation.Text = "Haut des lèvres"
        ElseIf compteur = 9 Then
            lblNatureAnnotation.Text = "Bas des lèvres"
        ElseIf compteur = 10 Then
            lblNatureAnnotation.Text = "Bord des lèvres le plus à gauche"
        ElseIf compteur = 11 Then
            lblNatureAnnotation.Text = "Bord des lèvres le plus à droite"
        ElseIf compteur = 12 Then
            MessageBox.Show("Les annotations sont fini!")
            btn_Sauvegarder.Visible = True
            lblNatureAnnotation.Hide()
            btnValider.Hide()
            pcbImage2.Cursor = Cursors.No
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Sauvegarder.Click

        'on crée et enregistre le fichier excel contenant les annotations
        SaveFileDialog1.Filter = "Fichier Excel|*.xlsx"
        SaveFileDialog1.InitialDirectory = cheminSauveFichier
        If SaveFileDialog1.ShowDialog = 1 Then
            SaveFileDialog1.DefaultExt = "xlsx"


            Dim oExcel As Object
            oExcel = CreateObject("Excel.Application")
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet

            oBook = oExcel.workbooks.add
            oSheet = oExcel.worksheets(1)

            'les noms des parties du visages annotées ainsi que la position des points sont enregistrés dans des cellules d'excel
            oSheet.Name = "Feuil1"
            oSheet.Range("A1").Value = Form1.nomImage
            oSheet.Range("B1").Value = "coordonées"
            oSheet.Range("A2").Value = "Y1.x"
            oSheet.Range("B2").Value = Y1.X
            oSheet.Range("A3").Value = "Y1.y"
            oSheet.Range("B3").Value = Y1.Y
            oSheet.Range("A4").Value = "BVG.x"
            oSheet.Range("B4").Value = BVG.X
            oSheet.Range("A5").Value = "BVG.y"
            oSheet.Range("B5").Value = BVG.Y
            oSheet.Range("A6").Value = "BVD.x"
            oSheet.Range("B6").Value = BVD.X
            oSheet.Range("A7").Value = "BVD.y"
            oSheet.Range("B7").Value = BVD.Y
            oSheet.Range("A8").Value = "BN.x"
            oSheet.Range("B8").Value = BN.X
            oSheet.Range("A9").Value = "BN.y"
            oSheet.Range("B9").Value = BN.Y
            oSheet.Range("A10").Value = "BNG.x"
            oSheet.Range("B10").Value = BNG.X
            oSheet.Range("A11").Value = "BNG.y"
            oSheet.Range("B11").Value = BNG.Y
            oSheet.Range("A12").Value = "BND.x"
            oSheet.Range("B12").Value = BND.X
            oSheet.Range("A13").Value = "BND.y"
            oSheet.Range("B13").Value = BND.Y
            oSheet.Range("A14").Value = "BM.x"
            oSheet.Range("B14").Value = BM.X
            oSheet.Range("A15").Value = "BM.y"
            oSheet.Range("B15").Value = BM.Y
            oSheet.Range("A16").Value = "HL.x"
            oSheet.Range("B16").Value = HL.X
            oSheet.Range("A17").Value = "HL.y"
            oSheet.Range("B17").Value = HL.Y
            oSheet.Range("A18").Value = "BL.x"
            oSheet.Range("B18").Value = BL.X
            oSheet.Range("A19").Value = "BL.y"
            oSheet.Range("B19").Value = BL.Y
            oSheet.Range("A20").Value = "LG.x"
            oSheet.Range("B20").Value = LG.X
            oSheet.Range("A21").Value = "LG.y"
            oSheet.Range("B21").Value = LG.Y
            oSheet.Range("A22").Value = "LD.x"
            oSheet.Range("B22").Value = LD.X
            oSheet.Range("A23").Value = "LD.y"
            oSheet.Range("B23").Value = LD.Y
            oSheet.Range("A24").Value = "Y2.x"
            oSheet.Range("B24").Value = Y2.X
            oSheet.Range("A25").Value = "Y2.y"
            oSheet.Range("B25").Value = Y2.Y
            oBook.SaveAs(SaveFileDialog1.FileName)
            oBook.Close()
            oBook = Nothing
            oExcel.Quit()
            oExcel = Nothing
            Me.Dispose()
        End If

        'on calcule les ratios
        Y3 = obtenirMilieu(Y1.X, Y2.X, Y1.Y, Y2.Y)
        HauteurLèvre = obtenirdistance(HL.X, BL.X, LG.Y, LD.Y)
        HauteurNez = obtenirdistance(Y3.X, BN.X, Y3.Y, BN.Y)
        HauteurVisage = obtenirdistance(Y3.X, BN.X, Y3.Y, BN.Y)
        LargeurLèvre = obtenirdistance(LG.X, LD.Y, LG.Y, LD.Y)
        LargeurNez = obtenirdistance(BNG.X, BND.X, BNG.Y, BND.Y)
        LargeurVisage = obtenirdistance(BVG.X, BVD.X, BVG.Y, BVD.Y)
        LargeurYeux = obtenirdistance(Y1.X, Y2.X, Y1.Y, Y2.Y)
        ratioL = HauteurLèvre / LargeurLèvre
        ratioN = HauteurNez / LargeurNez
        ratioV = HauteurVisage / LargeurVisage
        ratioY = LargeurVisage / LargeurYeux

        appxlsx = New xlsx.Application   'ouverture d'excel
        appxlsx.Visible = True 'on affiche la fenetre d'excel
        appxlsx.Workbooks.Open(cheminSauveRatio) 'ouverture du fichier excel
        sheetxlsx = CType(appxlsx.ActiveWorkbook.Worksheets("Feuil1"), xlsx.Worksheet) 'on selectionne la page "Feuil1" 

        'on cherche à tomber sur une case vide dans la colonne "A" du fichier excel pour enregistrer une nouvelle ligne avec les ratios
        While sheetxlsx.Range("A" & CStr(nb)).Value <> celluleVide
            nb = nb + 1
        End While
        sheetxlsx.Range("A" & CStr(nb)).Value = Form1.Test2
        sheetxlsx.Range("B" & CStr(nb)).Value = ratioL
        sheetxlsx.Range("C" & CStr(nb)).Value = ratioN
        sheetxlsx.Range("D" & CStr(nb)).Value = ratioV
        sheetxlsx.Range("E" & CStr(nb)).Value = ratioY

        appxlsx.Workbooks.Open(cheminSauveRatio).Close()
        nb = 1

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnComparerVisage.Click
        Dim Distance, resultatL, resultatN, resultatV, resultatY As Double

        'on ouvre le fichier SauvegardeDesRatios
        appxlsx = New xlsx.Application   'ouverture d'excel
        appxlsx.Visible = True 'on affiche la fenetre d'excel
        appxlsx.Workbooks.Open(cheminSauveRatio) 'ouverture du fichier excel
        sheetxlsx = CType(appxlsx.ActiveWorkbook.Worksheets("Feuil1"), xlsx.Worksheet) 'on selectionne la page "Feuil1"

        'boucle qui tourne tant que la ligne où sont enregistrées les ratios de l'image n'est pas trouvée
        While sheetxlsx.Range("A" & CStr(nb)).Value <> Form1.Test2
            nb = nb + 1
        End While

        'on enregistre les ratios de l'image dans des valeurs
        ratioTemporaireL = sheetxlsx.Range("B" & CStr(nb)).Value
        ratioTemporaireN = sheetxlsx.Range("C" & CStr(nb)).Value
        ratioTemporaireV = sheetxlsx.Range("C" & CStr(nb)).Value
        ratioTemporaireY = sheetxlsx.Range("E" & CStr(nb)).Value
        nb = 1

        'on compare toutes les lignes (les ratios qu'elles contiennent) avec les ratios enregistrées précédemment
        While sheetxlsx.Range("A" & CStr(nb)).Value <> celluleVide
            'on évite la comparaison avec la même image car les ratios seront forcément similaire
            If Form1.Test2 = CStr(sheetxlsx.Range("A" & CStr(nb)).Value) Then
                nb = nb + 1
            End If
            'on stocke le résultat de la soustraction entre les ratios(lèvre, nez, visage et yeux) de la première image avec celle de la ligne en cours, dans des variables
            resultatL = ratioTemporaireL - sheetxlsx.Range("B" & CStr(nb)).Value
            resultatN = ratioTemporaireN - sheetxlsx.Range("C" & CStr(nb)).Value
            resultatV = ratioTemporaireV - sheetxlsx.Range("D" & CStr(nb)).Value
            resultatY = ratioTemporaireY - sheetxlsx.Range("E" & CStr(nb)).Value
            'on calcule la distance finale entre les ratios des 2 images grâce aux valeurs resultatL, resultatN, resultatV, resultatY
            Distance = Sqr(resultatL) + Sqr(resultatN) + Sqr(resultatV) + Sqr(resultatY)

            'si la distance est inférieure au seuil donné par l'utilisateur, alors une phrase indique que l'image sélectionnée est similaire à la première image, en donnant le nom de l'image sélectionnée
            If Distance <= seuil Then

                MessageBox.Show(vbCrLf & "L'image " & CStr(sheetxlsx.Range("A" & CStr(nb)).Value) & " est similaire avec une distance de = " & CStr(Distance))
            Else
                MessageBox.Show("Il n'y a pas d'image similaire à votre image!")
            End If
            nb = nb + 1
        End While

        'on ferme la page excel
        appxlsx.Workbooks.Open(cheminSauveRatio).Close()


    End Sub

    Dim seuil As Double
    Dim desNumeros() As Char = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    'on vérifie que les valeurs rentrées dans TextBoxseuil soient bien des chiffres, dans le cas contraire la valeur n'est pas retenue
    Private Sub TextBoxseuil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxseuil.KeyPress
        If Not desNumeros.Contains(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    'le bouton annuler permet de supprimer le contenu de TextBoxseuil étant donné que l'utilisateur ne pourra pas supprimer avec la touche correspondante
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        TextBoxseuil.Text = ""
    End Sub

    'le bouton btnOKseuil permet de retenir la valeur rentrée par l'utilisateur et ne continuer vers la comparaison
    Private Sub btnOKseuil_Click(sender As Object, e As EventArgs) Handles btnOKseuil.Click
        seuil = TextBoxseuil.Text
        TextBoxseuil.Visible = False
        btnAnnuler.Visible = False
        labelseuil.Visible = False
        btnOKseuil.Visible = False
        btnComparerVisage.Show()
    End Sub
#End Region

End Class

