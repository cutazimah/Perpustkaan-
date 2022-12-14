<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Tambah_Koleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictFoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahkoleksi = New System.Windows.Forms.Button()
        Me.ChkKel_Budaya = New System.Windows.Forms.CheckBox()
        Me.ChkKel_teknologi = New System.Windows.Forms.CheckBox()
        Me.ChkKel_Sosial = New System.Windows.Forms.CheckBox()
        Me.ChkKel_Sains = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RdIng = New System.Windows.Forms.RadioButton()
        Me.RdInd = New System.Windows.Forms.RadioButton()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTanggalKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.TxtLokassi = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtPenerbit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.TxtKoleksi = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RTbxDesc = New System.Windows.Forms.RichTextBox()
        CType(Me.PictFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(28, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Tambah Koleksi"
        '
        'PictFoto
        '
        Me.PictFoto.Location = New System.Drawing.Point(41, 81)
        Me.PictFoto.Name = "PictFoto"
        Me.PictFoto.Size = New System.Drawing.Size(150, 198)
        Me.PictFoto.TabIndex = 50
        Me.PictFoto.TabStop = False
        '
        'BtnTambahkoleksi
        '
        Me.BtnTambahkoleksi.Location = New System.Drawing.Point(197, 832)
        Me.BtnTambahkoleksi.Name = "BtnTambahkoleksi"
        Me.BtnTambahkoleksi.Size = New System.Drawing.Size(308, 59)
        Me.BtnTambahkoleksi.TabIndex = 49
        Me.BtnTambahkoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahkoleksi.UseVisualStyleBackColor = True
        '
        'ChkKel_Budaya
        '
        Me.ChkKel_Budaya.AutoSize = True
        Me.ChkKel_Budaya.Location = New System.Drawing.Point(570, 847)
        Me.ChkKel_Budaya.Name = "ChkKel_Budaya"
        Me.ChkKel_Budaya.Size = New System.Drawing.Size(96, 29)
        Me.ChkKel_Budaya.TabIndex = 31
        Me.ChkKel_Budaya.Text = "Budaya"
        Me.ChkKel_Budaya.UseVisualStyleBackColor = True
        '
        'ChkKel_teknologi
        '
        Me.ChkKel_teknologi.AutoSize = True
        Me.ChkKel_teknologi.Location = New System.Drawing.Point(12, 97)
        Me.ChkKel_teknologi.Name = "ChkKel_teknologi"
        Me.ChkKel_teknologi.Size = New System.Drawing.Size(114, 29)
        Me.ChkKel_teknologi.TabIndex = 2
        Me.ChkKel_teknologi.Text = "Teknologi"
        Me.ChkKel_teknologi.UseVisualStyleBackColor = True
        '
        'ChkKel_Sosial
        '
        Me.ChkKel_Sosial.AutoSize = True
        Me.ChkKel_Sosial.Location = New System.Drawing.Point(12, 62)
        Me.ChkKel_Sosial.Name = "ChkKel_Sosial"
        Me.ChkKel_Sosial.Size = New System.Drawing.Size(89, 29)
        Me.ChkKel_Sosial.TabIndex = 1
        Me.ChkKel_Sosial.Text = "Sosial "
        Me.ChkKel_Sosial.UseVisualStyleBackColor = True
        '
        'ChkKel_Sains
        '
        Me.ChkKel_Sains.AutoSize = True
        Me.ChkKel_Sains.Location = New System.Drawing.Point(12, 33)
        Me.ChkKel_Sains.Name = "ChkKel_Sains"
        Me.ChkKel_Sains.Size = New System.Drawing.Size(79, 29)
        Me.ChkKel_Sains.TabIndex = 0
        Me.ChkKel_Sains.Text = "Sains"
        Me.ChkKel_Sains.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkKel_teknologi)
        Me.GroupBox2.Controls.Add(Me.ChkKel_Sosial)
        Me.GroupBox2.Controls.Add(Me.ChkKel_Sains)
        Me.GroupBox2.Location = New System.Drawing.Point(558, 715)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 176)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'RdIng
        '
        Me.RdIng.AutoSize = True
        Me.RdIng.Location = New System.Drawing.Point(20, 77)
        Me.RdIng.Name = "RdIng"
        Me.RdIng.Size = New System.Drawing.Size(151, 29)
        Me.RdIng.TabIndex = 0
        Me.RdIng.TabStop = True
        Me.RdIng.Text = "Bahasa inggris"
        Me.RdIng.UseVisualStyleBackColor = True
        '
        'RdInd
        '
        Me.RdInd.AutoSize = True
        Me.RdInd.Location = New System.Drawing.Point(20, 41)
        Me.RdInd.Name = "RdInd"
        Me.RdInd.Size = New System.Drawing.Size(174, 29)
        Me.RdInd.TabIndex = 0
        Me.RdInd.TabStop = True
        Me.RdInd.Text = "Bahasa Indonesia"
        Me.RdInd.UseVisualStyleBackColor = True
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(22, 290)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(183, 34)
        Me.BtnTambahGambar.TabIndex = 51
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdIng)
        Me.GroupBox1.Controls.Add(Me.RdInd)
        Me.GroupBox1.Location = New System.Drawing.Point(556, 564)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(288, 106)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa "
        '
        'DateTanggalKoleksi
        '
        Me.DateTanggalKoleksi.Location = New System.Drawing.Point(561, 477)
        Me.DateTanggalKoleksi.Name = "DateTanggalKoleksi"
        Me.DateTanggalKoleksi.Size = New System.Drawing.Size(309, 31)
        Me.DateTanggalKoleksi.TabIndex = 46
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(556, 384)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(314, 31)
        Me.txtTahun.TabIndex = 45
        '
        'TxtLokassi
        '
        Me.TxtLokassi.Location = New System.Drawing.Point(556, 429)
        Me.TxtLokassi.Name = "TxtLokassi"
        Me.TxtLokassi.Size = New System.Drawing.Size(314, 31)
        Me.TxtLokassi.TabIndex = 44
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(556, 519)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(314, 31)
        Me.TxtStock.TabIndex = 43
        '
        'TxtPenerbit
        '
        Me.TxtPenerbit.Location = New System.Drawing.Point(556, 340)
        Me.TxtPenerbit.Name = "TxtPenerbit"
        Me.TxtPenerbit.Size = New System.Drawing.Size(314, 31)
        Me.TxtPenerbit.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(366, 716)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 25)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "kategori"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(361, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "bahasa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(361, 525)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 25)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(361, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 25)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "tanggal Masuk Koleksi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(361, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 25)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Lokasi rak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(361, 384)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tahun terbit"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(361, 340)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(76, 25)
        Me.Label.TabIndex = 35
        Me.Label.Text = "Penerbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(366, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Deskripsi "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(366, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nama Koleksi"
        '
        'CBJenisKoleksi
        '
        Me.CBJenisKoleksi.FormattingEnabled = True
        Me.CBJenisKoleksi.Items.AddRange(New Object() {"", "Buku ", "Ensiklopedia", "Koran ", "Majalah", "Publikasi Penelitian"})
        Me.CBJenisKoleksi.Location = New System.Drawing.Point(556, 81)
        Me.CBJenisKoleksi.Name = "CBJenisKoleksi"
        Me.CBJenisKoleksi.Size = New System.Drawing.Size(314, 33)
        Me.CBJenisKoleksi.TabIndex = 29
        '
        'TxtKoleksi
        '
        Me.TxtKoleksi.Location = New System.Drawing.Point(556, 30)
        Me.TxtKoleksi.Name = "TxtKoleksi"
        Me.TxtKoleksi.Size = New System.Drawing.Size(314, 31)
        Me.TxtKoleksi.TabIndex = 28
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RTbxDesc
        '
        Me.RTbxDesc.Location = New System.Drawing.Point(558, 153)
        Me.RTbxDesc.Name = "RTbxDesc"
        Me.RTbxDesc.Size = New System.Drawing.Size(312, 144)
        Me.RTbxDesc.TabIndex = 34
        Me.RTbxDesc.Text = ""
        '
        'Form_Tambah_Koleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 1002)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictFoto)
        Me.Controls.Add(Me.BtnTambahkoleksi)
        Me.Controls.Add(Me.ChkKel_Budaya)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTanggalKoleksi)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.TxtLokassi)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtPenerbit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.RTbxDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBJenisKoleksi)
        Me.Controls.Add(Me.TxtKoleksi)
        Me.Name = "Form_Tambah_Koleksi"
        Me.Text = "Form_Tambah_Koleksi"
        CType(Me.PictFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents PictFoto As PictureBox
    Friend WithEvents BtnTambahkoleksi As Button
    Friend WithEvents ChkKel_Budaya As CheckBox
    Friend WithEvents ChkKel_teknologi As CheckBox
    Friend WithEvents ChkKel_Sosial As CheckBox
    Friend WithEvents ChkKel_Sains As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RdIng As RadioButton
    Friend WithEvents RdInd As RadioButton
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTanggalKoleksi As DateTimePicker
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents TxtLokassi As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtPenerbit As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBJenisKoleksi As ComboBox
    Friend WithEvents TxtKoleksi As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RTbxDesc As RichTextBox
End Class
