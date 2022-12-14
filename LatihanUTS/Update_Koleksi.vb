Public Class Update_Koleksi
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictFoto.Load(Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi)
        PictFoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateTanggalKoleksiUpdate.Format = DateTimePickerFormat.Custom
        DateTanggalKoleksiUpdate.CustomFormat = "yyyy/MM/dd"
        TxtKoleksiUpdate.Text = Form_Perpustakaan.dataperpustakaan.GSKoleksi
        CBJenisKoleksiUpdate.SelectedItem() = Form_Perpustakaan.dataperpustakaan.GSJenis
        RTbxDescUpdate.Text = Form_Perpustakaan.dataperpustakaan.GSDekskripsi
        TxtPenerbitUpdate.Text = Form_Perpustakaan.dataperpustakaan.GSpenerbit
        txtTahunUpdate.Text = Form_Perpustakaan.dataperpustakaan.GSTahun
        TxtLokassiUpdate.Text = Form_Perpustakaan.dataperpustakaan.GSLokasi
        DateTanggalKoleksiUpdate.Value = Form_Perpustakaan.dataperpustakaan.GSTanggal
        TxtStockUpdate.Text = Form_Perpustakaan.dataperpustakaan.GSStock

        If String.Compare(Form_Perpustakaan.dataperpustakaan.GSBahasa, "Bahasa Indonesia") = 0 Then
            RdIndUpdate.Checked = True
        ElseIf String.Compare(Form_Perpustakaan.dataperpustakaan.GSBahasa, "Bahasa Inggris") = 0 Then
            RdIngUpdate.Checked = True
        End If

        For Each katItem In Form_Perpustakaan.dataperpustakaan.getKategoriItem
            If String.Compare(katItem, "Sains") = 0 Then
                ChkKel_SainsUpdate.Checked = True
            End If
            If String.Compare(katItem, "Sosial") = 0 Then
                ChkKel_SosialUpdate.Checked = True
            End If
            If String.Compare(katItem, "teknologi") = 0 Then
                ChkKel_SainsUpdate.Checked = True
            End If
            If String.Compare(katItem, "Budaya") = 0 Then
                ChkKel_BudayaUpdate.Checked = True
            End If
        Next

        Form_Perpustakaan.dataperpustakaan.ResetKategori()
    End Sub
    Private Sub BtnUpdateGambat_Click(sender As Object, e As EventArgs) Handles BtnUpdateGambat.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi" 'Title Dialog Open File
        OpenFileDialog1.Filter = "Image File (*.JPG)|*jpg| All Format(*.*)| *.*"
        OpenFileDialog1.ShowDialog() 'Show Open Dialog

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictFoto.Load(OpenFileDialog1.FileName) 'Tampilkan Image Berdasarkan Lokasi File yang DIpilih 
        PictFoto.SizeMode = PictureBoxSizeMode.StretchImage 'Layout Image Stretch agar image tampil full
        Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi = picKoleksiDir.ToString()
        Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi = Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi.Replace("\", "/")
    End Sub
    Private Sub BtnUpdateKoleksi_Click_1(sender As Object, e As EventArgs) Handles BtnUpdateKoleksi.Click

        Form_Perpustakaan.dataperpustakaan.GSKoleksi = TxtKoleksiUpdate.Text.ToString()
        Form_Perpustakaan.dataperpustakaan.GSJenis = CBJenisKoleksiUpdate.SelectedItem().ToString()
        Form_Perpustakaan.dataperpustakaan.GSDekskripsi = RTbxDescUpdate.Text.ToString()
        Form_Perpustakaan.dataperpustakaan.GSpenerbit = TxtPenerbitUpdate.Text.ToString()
        Form_Perpustakaan.dataperpustakaan.GSTahun = Integer.Parse(txtTahunUpdate.Text)
        Form_Perpustakaan.dataperpustakaan.GSLokasi = TxtLokassiUpdate.Text.ToString()
        Form_Perpustakaan.dataperpustakaan.GSTanggal = DateTanggalKoleksiUpdate.Value.ToString("yyyy/MM/dd")
        Form_Perpustakaan.dataperpustakaan.GSStock = Integer.Parse(TxtStockUpdate.Text)

        If RdIndUpdate.Checked Then
            Form_Perpustakaan.dataperpustakaan.GSBahasa = "Bahasa Indonesia"
        ElseIf RdIngUpdate.Checked Then
            Form_Perpustakaan.dataperpustakaan.GSBahasa = "Bahasa Inggris"
        End If

        If ChkKel_SainsUpdate.Checked Then
            Form_Perpustakaan.dataperpustakaan.AddKategori("Sains")
        End If
        If ChkKel_SosialUpdate.Checked Then
            Form_Perpustakaan.dataperpustakaan.AddKategori("Sosial")
        End If
        If ChkKel_BudayaUpdate.Checked Then
            Form_Perpustakaan.dataperpustakaan.AddKategori("Budaya")
        End If
        If ChkKel_teknologiUpdate.Checked Then
            Form_Perpustakaan.dataperpustakaan.AddKategori("Teknologi")
        End If

        Dim convertedKoleksi = Form_Perpustakaan.dataperpustakaan.ConvertKoleksiToString(Form_Perpustakaan.dataperpustakaan.getKategoriItem)

        Form_Perpustakaan.dataperpustakaan.UpdateDataKoleksiByIDDatabase(Form_Perpustakaan.selectedTableKoleksi,
                                                               Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi,
                                                               Form_Perpustakaan.dataperpustakaan.GSKoleksi,
                                                               Form_Perpustakaan.dataperpustakaan.GSJenis,
                                                               Form_Perpustakaan.dataperpustakaan.GSpenerbit,
                                                               Form_Perpustakaan.dataperpustakaan.GSDekskripsi,
                                                               Form_Perpustakaan.dataperpustakaan.GSTahun,
                                                               Form_Perpustakaan.dataperpustakaan.GSLokasi,
                                                               Form_Perpustakaan.dataperpustakaan.GSTanggal,
                                                               Form_Perpustakaan.dataperpustakaan.GSStock,
                                                               Form_Perpustakaan.dataperpustakaan.GSBahasa,
                                                               convertedKoleksi)

        Dim infoTambah = New Form_Info_Tambah_Koleksi()
        infoTambah.Show()
        Me.Close()
    End Sub

End Class