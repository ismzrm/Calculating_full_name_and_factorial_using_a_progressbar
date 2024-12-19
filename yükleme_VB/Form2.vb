Imports System.IO


Public Class Form2
    Dim ad As String
    Dim sayi As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ad = Interaction.InputBox("Lütfen Adınızı ve Soyadınızı Giriniz!!", "AD ve SOYAD")
        sayi = Convert.ToInt32(Interaction.InputBox("Lütfen Sayı Giriniz", "Sayı"))

        Dim carp As Class1 = New Class1()
        Dim hesapla As Integer = carp.carp(sayi)
        ListBox1.Items.Add(ad)
        ListBox1.Items.Add("Sonuç :" & hesapla)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.ShowDialog()
        'Me.Close()
        Dim kaydet As StreamWriter = File.AppendText("bilgiler.txt")
        Dim carp As Class1 = New Class1()
        Dim hesapla As Integer = carp.carp(sayi)
        kaydet.WriteLine(ad & " " & "Sonuc :" & hesapla)
        kaydet.Close()

        MsgBox("Bilgiler bilgiler.txt dosyasına kaydedildi")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.ShowDialog()
        Me.Close()


    End Sub
End Class