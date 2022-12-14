Public Class FormHapusKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Lbl_ID_Koleksi.Text = Form_Perpustakaan.selectedTableKoleksi.ToString()
        Lbl_Nama_Koleksi.Text = Form_Perpustakaan.dataperpustakaan.GSdelete

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Private Sub FormHapusKoleksi_Load(sender As Object, e As EventArgs) Handles Me.Load
    '    Dim hapus_item = Form_Perpustakaan.ListBoxKoleksi.SelectedItem()
    '    Form_Perpustakaan.ListBoxKoleksi.Items.Remove(hapus_item)
    '    Me.Close()
    'End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Form_Perpustakaan.dataperpustakaan.DeleteDataKoleksiByIDDatabase(Form_Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class