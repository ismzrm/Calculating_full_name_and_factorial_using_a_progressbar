Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        Label1.Text = "Yükleniyor Lütfen Bekleyiniz : %" & ProgressBar1.Value

        If ProgressBar1.Value >= 100 Then
            Me.Hide()
            Timer1.Enabled = False
            'Form2.ShowDialog()
            Me.Close()

        End If


    End Sub
End Class
