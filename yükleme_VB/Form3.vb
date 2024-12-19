Imports System.IO


Public Class Form3
    Dim veri As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim yaz As StreamReader = File.OpenText("bilgiler.txt")

        While yaz.EndOfStream = False
            veri = yaz.ReadLine()
            ListBox1.Items.Add(veri)
        End While



        yaz.Close()


    End Sub
End Class