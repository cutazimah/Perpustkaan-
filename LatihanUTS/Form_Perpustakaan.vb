Imports System.IO

Public Class Form_Perpustakaan
    Public Shared dataperpustakaan As FungsiPerpus
    Public Shared listkoleksi As New List(Of String)
    Public Shared koleksiterpilih As String
    Dim selecteddatatable
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Public Sub updateDataTableArrayList()
        DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In dataperpustakaan.getkoleksiDataTable()
            Dim dataTable As String() = {rowKoleksi(1),
                                         rowKoleksi(2),
                                         rowKoleksi(3),
                                         rowKoleksi(4),
                                         rowKoleksi(5),
                                         rowKoleksi(6),
                                         rowKoleksi(7),
                                         rowKoleksi(8),
                                         rowKoleksi(9),
                                         rowKoleksi(10)
            }
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dataperpustakaan = New FungsiPerpus()

        ReloadDataTableDatabase()

    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        If ListBoxKoleksi.SelectedIndex = -1 Then
            MessageBox.Show("Pilih salah satu item")
        Else
            Dim hapus_koleksi = New Form_Hapus_Koleksi
            hapus_koleksi.Show()
        End If

    End Sub

    Private Sub Form_Perpustakaan_Activated(sender As Object, e As EventArgs)

        ReloadDataTableDatabase()
        ListBoxKoleksi.Items.Clear()

        For Each kel In listkoleksi
            ListBoxKoleksi.Items.Add(kel)
        Next
    End Sub

    Private Sub KoleksiList_Click(sender As Object, e As EventArgs) Handles ListBoxKoleksi.Click
        koleksiterpilih = ListBoxKoleksi.SelectedItem()
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        Dim formTambahKoleksi = New Form_Tambah_Koleksi
        formTambahKoleksi.Show()
    End Sub

    Private Sub Perpus_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'updateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Public Sub procHapus(item As String)
        dataperpustakaan.RemovekoleksiDataTable(item)
        ListBoxKoleksi.Items.Remove(item)
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = dataperpustakaan.GetDataKoleksiDatabase()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim dataselected As List(Of String) = dataperpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        dataperpustakaan.GSfoto_koleksi = dataselected(2)
        dataperpustakaan.GSKoleksi = dataselected(1)
        dataperpustakaan.GSJenis = dataselected(5)
        dataperpustakaan.GSpenerbit = dataselected(4)
        dataperpustakaan.GSTahun = dataselected(6)
        dataperpustakaan.GSDekskripsi = dataselected(3)
        dataperpustakaan.GSLokasi = dataselected(7)
        dataperpustakaan.GSTanggal = dataselected(8)
        dataperpustakaan.GSStock = dataselected(9)
        dataperpustakaan.GSBahasa = dataselected(10)

        'Message Box.Show (dataselected(10).ToSTring)
        dataperpustakaan.GSkategori = dataperpustakaan.ConvertStringToKoleksi(dataselected(11))

        Dim info_tambah = New Form_Info_Tambah_Koleksi()
        info_tambah.Show()


    End Sub

    Private Sub DataGridKoleksi_CellCLick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        'selectedTable Koleski = DataGridKoleski.CurrentRow.Index
        Dim index As Integer = e.RowIndex
        Dim SelectedRow As DataGridViewRow
        SelectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = SelectedRow.Cells(0).Value
        selectedTableKoleksiNama = SelectedRow.Cells(1).Value

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim selectedKoleksi As List(Of String) = dataperpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

            dataperpustakaan.GSfoto_koleksi = selectedKoleksi(2)
            dataperpustakaan.GSKoleksi = selectedKoleksi(1)
            dataperpustakaan.GSJenis = selectedKoleksi(5)
            dataperpustakaan.GSpenerbit = selectedKoleksi(4)
            dataperpustakaan.GSTahun = selectedKoleksi(6)
            dataperpustakaan.GSDekskripsi = selectedKoleksi(3)
            dataperpustakaan.GSLokasi = selectedKoleksi(7)
            dataperpustakaan.GSTanggal = selectedKoleksi(8)
            dataperpustakaan.GSStock = selectedKoleksi(9)
            dataperpustakaan.GSBahasa = selectedKoleksi(10)

            'Message Box.Show (dataselected(10).ToSTring)
            dataperpustakaan.GSkategori = dataperpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

            'For Each info_kategori In data_kategori
            '    dataperpustakaan.AddKategori(info_kategori)
            'Next

            Dim formUpdate = New Update_Koleksi()
            formUpdate.Show()
        Catch ex As Exception
            MessageBox.Show(".....")

        End Try


    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        Dim Hapus = New FormHapusKoleksi()
        Hapus.Show()


        ' Try

        'Dim selectedKoleksi As List(Of String) = dataperpustakaan.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        'dataperpustakaan.GSfoto_koleksi = selectedKoleksi(2)
        'dataperpustakaan.GSKoleksi = selectedKoleksi(1)
        'dataperpustakaan.GSJenis = selectedKoleksi(5)
        'dataperpustakaan.GSpenerbit = selectedKoleksi(4)
        'dataperpustakaan.GSTahun = selectedKoleksi(6)
        'dataperpustakaan.GSDekskripsi = selectedKoleksi(3)
        'dataperpustakaan.GSLokasi = selectedKoleksi(7)
        'dataperpustakaan.GSTanggal = selectedKoleksi(8)
        'dataperpustakaan.GSStock = selectedKoleksi(9)
        'dataperpustakaan.GSBahasa = selectedKoleksi(10)

        'Message Box.Show (dataselected(10).ToSTring)
        'dataperpustakaan.GSkategori = dataperpustakaan.ConvertStringToKoleksi(selectedKoleksi(11))

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString())

        'End Try
    End Sub

    Private Sub BtnRMV_Click(sender As Object, e As EventArgs) Handles BtnRMV.Click
        Dim HapusKoleksi = New Form_Info_Tambah_Koleksi()
        HapusKoleksi.Show()
    End Sub
End Class