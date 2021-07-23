Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports System.Text.RegularExpressions

'permet de mettre dans PictureBox1 ce que filme la webcam
Public Class Form4

#Region "Declarations"
    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap
#End Region
#Region "Procédures évenementielles"
    'button1 va permettre d'accéder à la webcam de l'ordinateur
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Camera = Cameras.VideoDevice
            AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            Camera.Start()
        End If
    End Sub


    'cette fonction permet de faire une capture de vidéo de la vidéo 
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    'la capture de vidéo est mise dans PictureBox2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub

    'button3 permet de sauvegarder la capture de vidéo comme une image, l'utilisateur choisit son nom et son chemin
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox2.Image.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    'permet d'arrêter la caméra lorsque l'utilisateur ferme la form4
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Camera.Stop()
    End Sub
#End Region

End Class