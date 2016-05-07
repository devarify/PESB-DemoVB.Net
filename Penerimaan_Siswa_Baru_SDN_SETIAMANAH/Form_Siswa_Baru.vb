Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.Sql
Public Class Form_Siswa_Baru
    Dim KodeAuto As String
    Sub aktif()
        Module_koneksiSQL.setconnection()

        dtpTanggalDiterima.Enabled = True
        txtkelas.Enabled = True
        btnMasukanData.Enabled = True
        btnPerbaikan.Enabled = True
        btnHapus.Enabled = True
    End Sub
    Sub off()
        Module_koneksiSQL.setconnection()
        txtNo_pendaftaran.Enabled = False
        txtNoInduk.Enabled = False
        txtNamaSiswa.Enabled = False
        txtTempatLahir.Enabled = False
        dtpTanggalLahir.Enabled = False
        txtUmur.Enabled = False
        txtjeniskelamin.Enabled = False
        txtagama.Enabled = False
        txtAlamat.Enabled = False
        dtpTanggalDiterima.Enabled = False
        txtkelas.Enabled = False
    End Sub
    Sub clear()
        txtNo_pendaftaran.Clear()
        txtNoInduk.Clear()
        txtNamaSiswa.Clear()
        txtTempatLahir.Clear()
        txtUmur.Clear()
        txtjeniskelamin.Clear()
        txtagama.Clear()
        txtAlamat.Clear()
        txtkelas.Clear()
    End Sub
    Private Sub TampilData()
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("SELECT * FROM Tsiswabaru", sqlConn)
        ds = New DataSet
        da.Fill(ds, "Tsiswabaru")
        DataGridView_SiswaBaru.DataSource = ds.Tables("Tsiswabaru")
        sqlcmd = New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandText = "SELECT * FROM Tsiswabaru"
        rd = sqlcmd.ExecuteReader
        off()
    End Sub
    Private Sub HapusData()
        Try
            Module_koneksiSQL.setconnection()
            sqlcmd = New SqlCommand()
            sqlcmd.CommandText = String.Format("DELETE FROM Tsiswabaru where [no_induk_siswa]='" & txtNoInduk.Text & "'", sqlConn)
            sqlcmd.Connection = sqlConn

            sqlcmd.ExecuteNonQuery()
            MsgBox(" Siswa " & txtNamaSiswa.Text & " Berhasil Dihapus")
        Catch ex As Exception
            MsgBox("data dengan nama (" & txtNamaSiswa.Text & ") telah digunakan di tabel lain'")
            MsgBox(" Siswa " & txtNamaSiswa.Text & " Tidak Berhasil Dihapus")
        End Try
    End Sub

    Private Sub InputData()

        Module_koneksiSQL.setconnection()
        btnbaru.Text = "Baru"
        If txtNo_pendaftaran.Text = "" Then
            MsgBox("Nomor Pendaftaran Belum di isi")
        ElseIf txtNoInduk.Text = "" Then
            MsgBox("Nomor Induk Belum di isi")
        Else
            Dim pesan = MessageBox.Show("Apakah anda yakin akan menambahkan data siswa bernama " & txtNamaSiswa.Text & " ?", "Konfirmasi Tambahkan Data Siswa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If pesan = DialogResult.OK Then

                Try
                    Module_koneksiSQL.setconnection()
                    sqlcmd = New SqlCommand()
                    sqlcmd.CommandText = String.Format("INSERT INTO Tsiswabaru (no_formulir, no_induk_siswa, tanggal_diterima, kelas) values ('{0}','{1}','{2}','{3}')", _
                                                txtNo_pendaftaran.Text, txtNoInduk.Text, dtpTanggalDiterima.Value.Date.ToString("MM/dd/yyyy"), txtkelas.Text, sqlConn)

                    sqlcmd.Connection = sqlConn

                    sqlcmd.ExecuteNonQuery()
                    MsgBox(" Data siswa yang bernama " & txtNamaSiswa.Text & " Berhasil Disimpan")
                Catch ex As Exception
                    MsgBox(" No Pendaftar Sudah Ada Dalam Tabel! ")
                End Try

            Else
                If btnbaru.Text = "Baru" Then
                    btnbaru.Text = "Batal"
                ElseIf btnbaru.Text = "Batal" Then
                    btnbaru.Text = "Baru"
                End If

            End If
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tampil_Click(sender As Object, e As EventArgs) Handles Tampil.Click
        tampil_data_siswa.Show()
    End Sub

    Private Sub Form_Siswa_Baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        'TODO: This line of code loads data into the 'DatasiswabaruDataSet.Tdata_siswa' table. You can move, or remove it, as needed.
        Me.Tdata_siswaTableAdapter.Fill(Me.DatasiswabaruDataSet.Tdata_siswa)

    End Sub

    Private Sub DataGridView_SiswaBaru_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_SiswaBaru.CellClick
        Dim grid As Integer
        grid = DataGridView_SiswaBaru.CurrentRow.Index

        txtNoInduk.Text = DataGridView_SiswaBaru.Item(0, grid).Value
        txtNo_pendaftaran.Text = DataGridView_SiswaBaru.Item(1, grid).Value
        dtpTanggalDiterima.Value = Convert.ToDateTime(DataGridView_SiswaBaru.Item(2, grid).Value).Date
        txtkelas.Text = DataGridView_SiswaBaru.Item(3, grid).Value
        btnHapus.Enabled = True
        btnPerbaikan.Enabled = True
        btnMasukanData.Enabled = False
        aktif()
    End Sub

    Private Sub DataGridView_SiswaBaru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_SiswaBaru.CellContentClick

    End Sub

    Private Sub btnMasukanData_Click(sender As Object, e As EventArgs) Handles btnMasukanData.Click
        InputData()
        TampilData()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        HapusData()
        TampilData()
    End Sub


    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        aktif()
        txtNoInduk.Enabled = True
        clear()
        Module_koneksiSQL.setconnection()
        If btnbaru.Text = "Baru" Then
            btnMasukanData.Enabled = True
            txtNoInduk.Focus()
            Dim maxString As String = " "
            Dim maxInteger As Integer = 0
            sqlcmd = New SqlCommand("Select Max(no_induk_siswa) As Maximum, Count(no_induk_siswa) As Jumlah from Tsiswabaru", sqlConn)
            rd = sqlcmd.ExecuteReader

            If rd.Read Then
                If rd.Item("Jumlah") = 0 Then
                    maxString = 0
                Else
                    maxString = rd.Item("Maximum")
                End If
            End If
            maxInteger = CInt(Microsoft.VisualBasic.Right(maxString, 3))
            maxInteger = maxInteger + 1
            maxString = maxInteger

            If maxString.Length = 1 Then
                KodeAuto = "01400" & maxString
            ElseIf maxString.Length = 2 Then
                KodeAuto = "014" & maxString
            ElseIf maxString.Length = 3 Then
                KodeAuto = "014" & maxString
            End If
            txtNoInduk.Text = KodeAuto
            btnbaru.Text = "Batal"
        ElseIf btnbaru.Text = "Batal" Then
            Call off()
            Call clear()
            btnbaru.Text = "Baru"
        End If
    End Sub

    Private Sub btnPerbaikan_Click(sender As Object, e As EventArgs) Handles btnPerbaikan.Click
        EditData()
    End Sub
    Private Sub EditData()
        Module_koneksiSQL.setconnection()
        sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("UPDATE Tsiswabaru set [no_formulir]='" & txtNo_pendaftaran.Text & _
                                                                        "',tanggal_diterima ='" & dtpTanggalDiterima.Value.Date & _
                                                                        "',kelas ='" & txtkelas.Text & _
                                                                        "'where no_induk_siswa = '" & txtNoInduk.Text & "'", sqlConn)
        sqlcmd.Connection = sqlConn
        sqlcmd.ExecuteNonQuery()
        MsgBox(" Data " & txtNoInduk.Text & " Berhasil Telah diubah")
        clear()
        TampilData() 'untuk merefresh kembali data yang diinputkan
    End Sub

    Private Sub btncari_Click_1(sender As Object, e As EventArgs) Handles btncari.Click
        Module_koneksiSQL.setconnection()
        Dim strTemp = ""
        If txtCarinoinduk.Text <> "" Then
            strTemp = " AND [no_induk_siswa] LIKE '%" & txtCarinoinduk.Text & "%'"
        End If
        If txtcaritanggal.Text <> "" Then
            strTemp = " AND [tanggal_diterima] LIKE '%" & txtcaritanggal.Text & "%'"
        End If
        If txtcaritanggal.Text <> "" Then
            strTemp = " AND [tanggal_diterima] LIKE '%" & txtcaritanggal.Text & "%'"
        End If
        If txtNo_pendaftaran.Text <> "" Then
            strTemp += " AND [kelas] LIKE '%" & txtNo_pendaftaran.Text & "%'"

        End If
        da = New SqlDataAdapter("Select * FROM [Tsiswabaru] where (1=1)" & strTemp, sqlConn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "[Tsiswabaru]")

        DataGridView_SiswaBaru.DataSource = ds.Tables("[Tsiswabaru]")
        Me.DataGridView_SiswaBaru.Refresh()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
End Class