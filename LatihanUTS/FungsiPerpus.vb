Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FungsiPerpus
    Private Koleksi As String
    Private Jenis As String
    Private Deskripsi As String
    Private penerbit
    Private Tahun As String
    Private Lokasi
    Private Tanggal
    Private Stock As String
    Private Bahasa
    Private kategori As New List(Of String)
    Private foto_koleksi
    Private deleteItem
    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaann"


    Public Property GSKoleksi() As String
        Get
            Return Koleksi
        End Get
        Set(ByVal value As String)
            Koleksi = value
        End Set
    End Property

    Public Property GSJenis() As String
        Get
            Return Jenis
        End Get
        Set(ByVal value As String)
            Jenis = value
        End Set
    End Property

    Public Property GSDekskripsi() As String
        Get
            Return Deskripsi
        End Get
        Set(ByVal value As String)
            Deskripsi = value
        End Set
    End Property

    Public Property GSpenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahun() As String
        Get
            Return Tahun
        End Get
        Set(ByVal value As String)
            Tahun = value
        End Set
    End Property

    Public Property GSLokasi() As String
        Get
            Return Lokasi
        End Get
        Set(ByVal value As String)
            Lokasi = value
        End Set
    End Property

    Public Property GSTanggal() As String
        Get
            Return Tanggal
        End Get
        Set(ByVal value As String)
            Tanggal = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return Stock
        End Get
        Set(ByVal value As String)
            Stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return Bahasa
        End Get
        Set(ByVal value As String)
            Bahasa = value
        End Set
    End Property

    Public Property GSkategori() As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Function AddKategori(value As String)
        kategori.Add(value)
        Return ""
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return kategori
        End Get
    End Property
    Public Function ResetKategori()
        kategori.Clear()
    End Function


    Public Property GSfoto_koleksi() As String
        Get
            Return foto_koleksi
        End Get
        Set(ByVal value As String)
            foto_koleksi = value
        End Set
    End Property

    Public Property GSdelete() As String
        Get
            Return deleteItem
        End Get
        Set(value As String)
            deleteItem = value
        End Set
    End Property


    Public Sub AddkoleksiDataTable(dir_gambar As String,
                                        nama_koleksi As String,
                                        Jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        koleksiDataTable.Add({dir_gambar,
                             nama_koleksi,
                             Jenis_koleksi,
                             penerbit_koleksi,
                             deskripsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi,
                             kategori_koleksi})

    End Sub

    Public Function RemovekoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getkoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'convert to list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataKoleksiDatabase() As DataTable
        Try
            Dim result As New DataTable

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = " SELECT id_koleksi AS 'ID',
                                   nama_koleksi as 'Nama Koleksi',
                                   jenis_koleksi As 'Jenis Koleksi', 
                                   penerbit As 'Penerbit', 
                                   tahun_terbit As 'Tahun Terbit',
                                   tanggal_masuk_koleksi As 'Tanggal Masuk', 
                                   lokasi As 'Lokasi Rak',
                                   stock As  'Stock',
                                   bahasa As ' Bahasa'
                                   FROM  koleksi"

            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function AddDataKoleksiDatabase(dir_gambar As String,
                                            nama_koleksi As String,
                                            jenis_koleksi As String,
                                            penerbit_koleksi As String,
                                            deskripsi_koleksi As String,
                                            tahun_terbit As String,
                                            lokasi_rak As String,
                                            tanggal_masuk As Date,
                                            stock_koleksi As Integer,
                                            bahasa_koleksi As String,
                                            kategori_koleksi As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        MessageBox.Show(tahun_terbit)

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI (nama_koleksi, dir_gambar, 
                        deskripsi, penerbit, jenis_koleksi,
                        tahun_terbit, lokasi, tanggal_masuk_koleksi, 
                        stock, bahasa, kategori) VALUE ('" _
                        & nama_koleksi & "', '" _
                        & dir_gambar & "', '" _
                        & deskripsi_koleksi & "', '" _
                        & penerbit_koleksi & "', '" _
                        & jenis_koleksi & "', '" _
                        & tahun_terbit & "', '" _
                        & lokasi_rak & "', '" _
                        & tanggal_masuk.ToString("yyyy/MM/dd") & "', '" _
                        & stock_koleksi & "', '" _
                        & bahasa_koleksi & "', '" _
                        & kategori_koleksi & "')"



            Debug.Print(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Tambah Database")
            dbConn.Close()

            'Peprus.sqldt.Load(SqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
      + "password=" + password + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = " SELECT id_koleksi, 
                                   nama_koleksi, 
                                   dir_gambar, 
                                   deskripsi, 
                                   penerbit, 
                                   jenis_koleksi, 
                                   tahun_terbit, 
                                   lokasi, 
                                   tanggal_masuk_koleksi, 
                                   stock, 
                                   bahasa, 
                                   kategori 
                                   FROM koleksi
                                   WHERE id_koleksi= '" & ID & " ' "
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
                result.Add(sqlRead.GetString(4).ToString())
                result.Add(sqlRead.GetString(5).ToString())
                result.Add(sqlRead.GetString(6).ToString())
                result.Add(sqlRead.GetString(7).ToString())
                result.Add(sqlRead.GetString(8).ToString())
                result.Add(sqlRead.GetString(9).ToString())
                result.Add(sqlRead.GetString(10).ToString())
                result.Add(sqlRead.GetString(11).ToString())
            End While

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function UpdateDataKoleksiByIDDatabase(ID As Integer,
                                                 dir_gambar As String,
                                                nama_koleksi As String,
                                                jenis_koleksi As String,
                                                penerbit_koleksi As String,
                                                deskripsi_koleksi As String,
                                                tahun_terbit As String,
                                                lokasi_rak As String,
                                                tanggal_masuk As String,
                                                stock_koleksi As Integer,
                                                bahasa_koleksi As String,
                                                kategori_koleksi As String)
        tahun_terbit = tahun_terbit.ToString()
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " UPDATE koleksi SET nama_koleksi='" & nama_koleksi & "', " &
                        "dir_gambar='" & dir_gambar & "', " &
                        "deskripsi='" & deskripsi_koleksi & "', " &
                        "penerbit='" & penerbit_koleksi & "', " &
                        "jenis_koleksi='" & jenis_koleksi & "', " &
                        "tahun_terbit ='" & tahun_terbit & "', " &
                        "lokasi='" & lokasi_rak & "', " &
                        "tanggal_masuk_koleksi='" & tanggal_masuk & "', " &
                        "stock='" & stock_koleksi & "', " &
                        "bahasa='" & bahasa_koleksi & "', " &
                        "kategori='" & kategori_koleksi & "' " &
                        " WHERE id_koleksi='" & ID & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            MessageBox.Show("Data sudah diperbarui")
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " DELETE FROM koleksi " &
                       " WHERE id_koleksi ='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            ' Form_Perpustakaan.sqlDR.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try


    End Function


End Class
