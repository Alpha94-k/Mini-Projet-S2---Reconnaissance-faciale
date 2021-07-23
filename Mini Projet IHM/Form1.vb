
Imports Microsoft.Office.Interop
Imports xls = Microsoft.Office.Interop.Excel


Public Class Form1
#Region "Declarations"
    Dim cheminRepImage As String
    Public Test2 As String
    Public image As Image
    Dim newimage As Bitmap
    Dim cheminRepFichier As String
    Dim pcbImage2 As PictureBox
    Public nomImage As String
    Dim verifImage As Boolean = False
    'variables pour excel
    Dim appXls As xls.Application
    Dim sheetXls As xls.Worksheet
    Public Y1, Y2, BVG, BVD, BN, BNG, BND, BM, HL, BL, LG, LD As Point
#End Region
#Region "Procédures évenementielles des contrôles"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnImporterFichier.Visible = False
        btnComparer.Visible = False
    End Sub
    'btnImporterImage va importer une image
    Public Sub btnImporterImage_Click(sender As Object, e As EventArgs) Handles btnImporterImage.Click
        'Objet OpenFileDialog qui ouvre une image
        Dim OFD As New OpenFileDialog
        lblFichier.Visible = False
        With OFD
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
            .Filter =
                "JPeg Files (*.jpg,*.jpeg)|*.jpg;*.jpeg|Bitmap Files (*.bmp)|*.bmp|Tif Files (*.tif)|*.tif|Png Files (*.png)|*.png"
            .FilterIndex = 1
            .Title = "Sélectionnez l'image que vous souhaitez importer!"
            DialogResult = .ShowDialog
            If DialogResult = DialogResult.OK Then
                image = image.FromFile(.FileName)
                cheminRepImage = .FileName
                pcbImage.Image = image
                verifImage = True
                newimage = New Bitmap(.FileName)
                lblRepImage.Text = cheminRepImage
                pcbImage.Image = newimage
                pcbImage.Cursor = Cursors.No
                Test2 = .SafeFileName
                btnAnnoterImage.Visible = True
                btnImporterFichier.Visible = True
                nomImage = .SafeFileName
                MessageBox.Show("Importation de l'image avec succès")
            Else
                Exit Sub
            End If
            .Dispose()
        End With
    End Sub

    'btnImporterFichier va importer un fichier excel
    Private Sub btnImporterFichier_Click(sender As Object, e As EventArgs) Handles btnImporterFichier.Click
        'Objet OpenFileDialog qui ouvre un fichier csv
        Dim OFD1 As New OpenFileDialog
        lblFichier.Visible = False
        With OFD1
            .InitialDirectory = Form2.cheminSauveFichier
            .Filter = "Fichier Excel|*.xlsx"
            .Title = "Sélectionnez le fichier que vous souhaitez importer!"
            DialogResult = .ShowDialog
            If DialogResult = DialogResult.OK Then
                lblFichier.Visible = True
                cheminRepFichier = .FileName
                lblRepFichier.Text = cheminRepFichier
                If verifImage = False Then
                    Exit Sub
                Else
                    appXls = New xls.Application   'ouverture d'excel
                    appXls.Visible = True 'on masque la fenetre d'excel
                    appXls.Workbooks.Open(cheminRepFichier) 'ouverture du fichier excel
                    sheetXls = CType(appXls.ActiveWorkbook.Worksheets("Feuil1"), xls.Worksheet) 'on selectionne la page "Feuil1"

                    'lecture des differentes cellules
                    Y1 = New Point((sheetXls.Range("B2").Value), (sheetXls.Range("B3").Value))
                    Y2 = New Point((sheetXls.Range("B24").Value), (sheetXls.Range("B25").Value))
                    BVG = New Point((sheetXls.Range("B4").Value), (sheetXls.Range("B5").Value))
                    BVD = New Point((sheetXls.Range("B6").Value), (sheetXls.Range("B7").Value))
                    BN = New Point((sheetXls.Range("B8").Value), (sheetXls.Range("B9").Value))
                    BNG = New Point((sheetXls.Range("B10").Value), (sheetXls.Range("B11").Value))
                    BND = New Point((sheetXls.Range("B12").Value), (sheetXls.Range("B13").Value))
                    BM = New Point((sheetXls.Range("B14").Value), (sheetXls.Range("B15").Value))
                    HL = New Point((sheetXls.Range("B16").Value), (sheetXls.Range("B17").Value))
                    BL = New Point((sheetXls.Range("B18").Value), (sheetXls.Range("B19").Value))
                    LG = New Point((sheetXls.Range("B20").Value), (sheetXls.Range("B21").Value))
                    LD = New Point((sheetXls.Range("B22").Value), (sheetXls.Range("B23").Value))
                    appXls.Workbooks.Open(cheminRepFichier).Close()
                    MessageBox.Show("Importation du fichier avec succès!")
                    Form2.AfficherImportationFichier()
                    Form2.ShowDialog()
                    btnComparer.Visible = True
                End If
            End If
        End With

    End Sub

    'btnPrendrePhoto nous reconduit vers la forme 4 pour prendre une photo
    Public Sub btnPrendrePhoto_Click(sender As Object, e As EventArgs) Handles btnPrendrePhoto.Click
        If (MessageBox.Show("Voulez-vous accéder à la caméra ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Form4.ShowDialog()
        End If
    End Sub

    'le bouton btnAnnoterImage nous renvoie vers la forme 2 
    Private Sub btnAnnoterImage_Click(sender As Object, e As EventArgs) Handles btnAnnoterImage.Click
        Form2.Initialisation()
        Form2.AfficherAnnoterImage()
        If (MessageBox.Show("Vous allez quittez cette fenêtre, voulez-vous vraiment continuer ?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes) Then
            Form2.ShowDialog()
        End If


    End Sub

    'ce bouton nous conduit vers la forme 2 pour faire la comparaison
    Private Sub btnComparer_Click(sender As Object, e As EventArgs) Handles btnComparer.Click
        Form2.AfficherComparerVisage()
        Form2.ShowDialog()
    End Sub
#End Region

End Class

