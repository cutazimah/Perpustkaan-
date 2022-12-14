Public Class Form_Info_Tambah_Koleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' If Not String.IsNullOrEmpty(Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi) Then
        PictFoto.Load(Form_Perpustakaan.dataperpustakaan.GSfoto_koleksi)
            PictFoto.SizeMode = PictureBoxSizeMode.StretchImage
        'End If

        LblKoleksiValue.Text = Form_Perpustakaan.dataperpustakaan.GSKoleksi
        LblJenisValue.Text = Form_Perpustakaan.dataperpustakaan.GSJenis
        LblDescValue.Text = Form_Perpustakaan.dataperpustakaan.GSDekskripsi
        LblTahunValue.Text = Form_Perpustakaan.dataperpustakaan.GSTahun
        LblLokasiValue.Text = Form_Perpustakaan.dataperpustakaan.GSLokasi
        LblTanggalValue.Text = Form_Perpustakaan.dataperpustakaan.GSTanggal
        LblStockValue.Text = Form_Perpustakaan.dataperpustakaan.GSStock
        LblBahasaValue.Text = Form_Perpustakaan.dataperpustakaan.GSBahasa
        LblPenerbitValue.Text = Form_Perpustakaan.dataperpustakaan.GSpenerbit


        ListBoxKategori.Items.Clear()

        For Each koll In Form_Perpustakaan.dataperpustakaan.GSkategori
            ListBoxKategori.Items.Add(koll)
        Next

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class