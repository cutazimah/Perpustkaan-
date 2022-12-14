Public Class Form_Hapus_Koleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LblKoleksi.Text = Form_Perpustakaan.selectedTableKoleksi
    End Sub

    Private Sub Form_Hapus_Koleksi_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim hapus_item = Form_Perpustakaan.ListBoxKoleksi.SelectedItem()
        'Form_Perpustakaan.ListBoxKoleksi.Items.Remove(hapus_item)
        Me.Close()
    End Sub


End Class