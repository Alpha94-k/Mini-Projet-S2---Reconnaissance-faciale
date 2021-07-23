Imports System.Threading
Public Class Form3
    'cette forme sert d'entrée dans l'application
#Region "Entrée de l'application"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Label2.Visible = True

        'Ce code sert à coder une petite animation, label1 va monter de feçon continue 
        For x As Integer = 1 To 150

            Label1.Location = New Point(Label1.Location.X, Label1.Location.Y - 1)
            Thread.Sleep(5)
            Application.DoEvents()

        Next
        Form1.Show()
        Label1.Location = New Point(Label1.Location.X, Label1.Location.Y + 250)
        Button1.Visible = True
        Label2.Visible = False
        Me.Close()
    End Sub
#End Region

End Class