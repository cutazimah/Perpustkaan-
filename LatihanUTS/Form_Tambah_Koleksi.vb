Public Class Form_Tambah_Koleksi

    Dim bahasa As String
    Dim kategori_list As New List(Of String)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DateTanggalKoleksi.Format = DateTimePickerFormat.Custom
        DateTanggalKoleksi.CustomFormat = "yyy/MM/dd"


    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Gambar Koleksi" 'Title Dialog Open File
        OpenFileDialog1.Filter = "Image File (*.JPG)|*jpg| All Format(*.*)| *.*"
        OpenFileDialog1.ShowDialog() 'Show Open Dialog

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictFoto.Load(OpenFileDialog1.FileName) 'Tampilkan Image Berdasarkan Lokasi File yang DIpilih 
        PictFoto.SizeMode = PictureBoxSizeMode.StretchImage 'Layout Image Stretch agar image tampil full
        Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi = picKoleksiDir.ToString()
        Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi = Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi.Replace("\", "/")
    End Sub

    Private Sub TxtKoleksi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtKoleksi.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub TxtPenerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPenerbit.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    'Private Sub txtTahun_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTahun.KeyPress
    '    If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
    '        e.Handled = True
    '        MessageBox.Show("Please Insert Number Only")
    '    End If
    'End Sub

    Private Sub TxtKoleksi_Leave(sender As Object, e As EventArgs) Handles TxtKoleksi.Leave
        If TxtKoleksi.Text.Length < 1 Then
            TxtKoleksi.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub TxtLokassi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLokassi.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    'Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
    '    If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
    '        e.Handled = True
    '        MessageBox.Show("Please Insert Number Only")
    '    End If
    'End Sub

    Private Sub RdInd_CheckedChanged(sender As Object, e As EventArgs) Handles RdInd.CheckedChanged
        Form_Perpustakaan.dataperpustakaan.GSBahasa = "Bahasa Indonesia"
    End Sub

    Private Sub RdIng_CheckedChanged(sender As Object, e As EventArgs) Handles RdIng.CheckedChanged
        Form_Perpustakaan.dataperpustakaan.GSBahasa = "Bahasa Inggris"
    End Sub

    Private Sub BtnTambahkoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahkoleksi.Click

        Form_Perpustakaan.dataperpustakaan.GSKoleksi = TxtKoleksi.Text
        Form_Perpustakaan.dataperpustakaan.GSJenis = CBJenisKoleksi.SelectedItem()
        Form_Perpustakaan.dataperpustakaan.GSDekskripsi = RTbxDesc.Text
        Form_Perpustakaan.dataperpustakaan.GSpenerbit = TxtPenerbit.Text

        Form_Perpustakaan.dataperpustakaan.GSTahun = txtTahun.Text.ToString()

        Form_Perpustakaan.dataperpustakaan.GSLokasi = TxtLokassi.Text
        Form_Perpustakaan.dataperpustakaan.GSTanggal = DateTanggalKoleksi.Value.ToString()
        Form_Perpustakaan.dataperpustakaan.GSStock = TxtStock.Text
        Form_Perpustakaan.dataperpustakaan.GSkategori = kategori_list

        ' Check Checkbox Value
        ' ======================
        If ChkKel_Sains.Checked() Then
            kategori_list.Add("Sains")
        End If

        If ChkKel_Sosial.Checked() Then
            kategori_list.Add("Sosial")
        End If

        If ChkKel_teknologi.Checked() Then
            kategori_list.Add("teknologi")
        End If

        If ChkKel_Budaya.Checked() Then
            kategori_list.Add("Budaya")
        End If

        'Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi = OpenFileDialog1.FileName.ToString()

        Dim tambahkoleksi = New Form_Info_Tambah_Koleksi()
        tambahkoleksi.Show()

        Dim add_item = Form_Perpustakaan.dataperpustakaan.GSKoleksi
        Form_Perpustakaan.listkoleksi.Add(add_item)
        Form_Perpustakaan.ListBoxKoleksi.Items.Add(add_item)

        Dim convertedKoleksi = Form_Perpustakaan.dataperpustakaan.ConvertKoleksiToString(Form_Perpustakaan.dataperpustakaan.GSkategori)
        Form_Perpustakaan.dataperpustakaan.AddDataKoleksiDatabase(Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi,
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

    Private Sub Form_Tambah_Koleksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RdInd_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles RdInd.ChangeUICues

    End Sub
End Class