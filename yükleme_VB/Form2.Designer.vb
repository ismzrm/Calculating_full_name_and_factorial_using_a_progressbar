<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Dock = DockStyle.Right
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(404, 0)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(403, 460)
        ListBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 205)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 89)
        Button1.TabIndex = 1
        Button1.Text = "Kaydet"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(12, 300)
        Button2.Name = "Button2"
        Button2.Size = New Size(190, 89)
        Button2.TabIndex = 2
        Button2.Text = "Yazdır"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(807, 460)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
