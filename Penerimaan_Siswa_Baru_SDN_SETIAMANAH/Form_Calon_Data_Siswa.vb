Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.Sql
Public Class Form_Calon_Data_Siswa
    Dim tabel As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

  

    Private Sub TampilData()
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("SELECT * FROM Tdata_siswa", sqlConn)
        ds = New DataSet
        da.Fill(ds, "Tdata_siswa")
        DataGridView1.DataSource = ds.Tables("Tdata_siswa")
        sqlcmd = New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandText = "SELECT * FROM Tdata_siswa"
        rd = sqlcmd.ExecuteReader


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpTanggalLahir.ValueChanged
        Call testt()
    End Sub

    Private Sub txtUmur_TextChanged(sender As Object, e As EventArgs) Handles txtUmur.TextChanged
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs)
    End Sub
    Sub aktif()
        Module_koneksiSQL.setconnection()

        txtNoPendaftaran.Enabled = True
        txtNama.Enabled = True
        txtTempatLahir.Enabled = True
        dtpTanggalLahir.Enabled = True
        txtUmur.Enabled = True
        cbxJenisKelamin.Enabled = True
        txtAgama.Enabled = True
        txtNoTelp.Enabled = True
        rtbAlamatsiswa.Enabled = True
        txtNamaAyah.Enabled = True
        txtNamaIbu.Enabled = True
        txtPekerjaanAyah.Enabled = True
        txtPekerjaanIbu.Enabled = True
        txtAlamatTinggal.Enabled = True
        txtNoTelp2.Enabled = True
        txtNamaAsalSekolah.Enabled = True
        rtbAlamatSekolah.Enabled = True

        btnInputData.Enabled = True
        btnHapus.Enabled = True


    End Sub
    Sub off()
        Module_koneksiSQL.setconnection()
        txtNoPendaftaran.Enabled = False
        txtNama.Enabled = False
        txtTempatLahir.Enabled = False
        dtpTanggalLahir.Enabled = False
        txtUmur.Enabled = False
        cbxJenisKelamin.Enabled = False
        txtAgama.Enabled = False
        txtNoTelp.Enabled = False
        rtbAlamatsiswa.Enabled = False
        txtNamaAyah.Enabled = False
        txtNamaIbu.Enabled = False
        txtPekerjaanAyah.Enabled = False
        txtPekerjaanIbu.Enabled = False
        txtAlamatTinggal.Enabled = False
        txtNoTelp2.Enabled = False
        txtNamaAsalSekolah.Enabled = False
        rtbAlamatSekolah.Enabled = False

        btnInputData.Enabled = False
        btnHapus.Enabled = False
        DataGridView1.Enabled = True
    End Sub
    Sub clear()
        Module_koneksiSQL.setconnection()

        txtNoPendaftaran.Clear()
        txtNama.Clear()
        txtTempatLahir.Clear()
        txtUmur.Clear()
        txtNoTelp.Clear()
        rtbAlamatsiswa.Clear()
        txtNamaAyah.Clear()
        txtNamaIbu.Clear()
        txtPekerjaanAyah.Clear()
        txtPekerjaanIbu.Clear()
        txtAlamatTinggal.Clear()
        txtNoTelp2.Clear()
        txtNamaAsalSekolah.Clear()
        rtbAlamatSekolah.Clear()
    End Sub
    Private Sub btnInputData_Click(sender As Object, e As EventArgs) Handles btnInputData.Click
        InputData()
        TampilData() 'untuk merefresh kembali data yang diinputkan
        off()
        btnUbah.Enabled = True
        btnHapus.Enabled = True
        clear()
    End Sub
    Private Sub InputData()
        
        Module_koneksiSQL.setconnection()
        If txtNoPendaftaran.Text = "" Then
            MsgBox("Nomor Pendaftaran Belum di isi")
        ElseIf txtNama.Text = "" Then
            MsgBox("Nama Belum di isi")
        ElseIf txtTempatLahir.Text = "" Then
            MsgBox("Tempat Lahir Belum di isi")
        ElseIf dtpTanggalLahir.Value = Date.Now.Date Then
            MsgBox("Tanggal lahir Belum di isi")
        ElseIf cbxJenisKelamin.Text = "" Then
            MsgBox("Jenis Kelamin Belum di isi")
        ElseIf txtAgama.Text = "" Then
            MsgBox("Agama Belum di isi")
        ElseIf txtNoTelp.Text = "" Then
            MsgBox("Nomor Telepon Belum di isi")
        ElseIf rtbAlamatsiswa.Text = "" Then
            MsgBox("Alamat Tinggal Belum di isi")
        ElseIf txtNamaAyah.Text = "" Then
            MsgBox("Nama Ayah Belum di isi")
        ElseIf txtNamaIbu.Text = "" Then
            MsgBox("Nama Ibu Belum di isi")
        ElseIf txtPekerjaanAyah.Text = "" Then
            MsgBox("Pekerjaan Ayah Belum di isi")
        ElseIf txtPekerjaanIbu.Text = "" Then
            MsgBox("Pekerjaan Ibu Belum di isi")
        ElseIf txtAlamatTinggal.Text = "" Then
            MsgBox("Alamat Tinggal Orang tua Belum di isi")
        ElseIf txtNoTelp2.Text = "" Then
            MsgBox("Nomor Telp. Orang Tua Belum di isi")
        ElseIf txtNamaAsalSekolah.Text = "" Then
            MsgBox("Asal Sekolah Belum di isi")
        ElseIf rtbAlamatSekolah.Text = "" Then
            MsgBox("Alamat Asal Sekolah Belum di isi")
        Else
            Dim pesan = MessageBox.Show("Apakah anda yakin akan menambahkan data siswa bernama " & txtNama.Text & " ?", "Konfirmasi Tambahkan Data Siswa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If pesan = DialogResult.OK Then

                Try
                Module_koneksiSQL.setconnection()
                sqlcmd = New SqlCommand()
                sqlcmd.CommandText = String.Format("INSERT INTO Tdata_siswa (no_formulir, nama_siswa, tempat_lahir, tanggal_lahir, umur, jenis_kelamin, agama, notelp_siswa, alamat_siswa, nama_ayah, nama_ibu, pekerjaan_ayah, pekerjaan_ibu, notelp_ortu, alamat_ortu, asal_sekolah, alamat_salsek) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')", _
                                            txtNoPendaftaran.Text, txtNama.Text, txtTempatLahir.Text, dtpTanggalLahir.Value.Date.ToString("MM/dd/yyyy"), _
                                                                        txtUmur.Text, cbxJenisKelamin.Text, txtAgama.Text, txtNoTelp.Text, rtbAlamatsiswa.Text, _
                                                                        txtNamaAyah.Text, txtNamaIbu.Text, _
                                                                        txtPekerjaanAyah.Text, txtPekerjaanIbu.Text, txtNoTelp2.Text, _
                                                                        txtAlamatTinggal.Text, txtNamaAsalSekolah.Text, rtbAlamatSekolah.Text, sqlConn)

                sqlcmd.Connection = sqlConn

                    sqlcmd.ExecuteNonQuery()
                    MsgBox(" Data siswa yang bernama " & txtNama.Text & " Berhasil Disimpan")
                Catch ex As Exception
                    MsgBox(" No Pendaftar Sudah Ada Dalam Tabel! ")
                End Try

            Else

            End If
        End If
    End Sub
    Sub testt()
        Dim a, b, c As String
        a = Year(Now)
        b = Year(dtpTanggalLahir.Value)
        c = a - b
        txtUmur.Text = c + " Tahun"
    End Sub
    Sub pengurangantahun()
        Dim age As Long
        age = Val(txtUmur.Text)
        age = Date.Now.Year - dtpTanggalLahir.Value.Year

    End Sub
    Private Sub Form_Calon_Data_Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pengurangantahun()
        off()
        TampilData()
        labeltanggal.Text = Now.Day & "/" & Now.Month & "/" & Now.Year
    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim pesanutama = MessageBox.Show("Apakah anda yakin akan ke menu utama? ", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If pesanutama = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        mdi_Utama.Close()
    End Sub
    Private Sub HapusData()
        Try
        Module_koneksiSQL.setconnection()
        sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("DELETE FROM Tdata_siswa where [nama_siswa]='" & txtNama.Text & "'", sqlConn)
        sqlcmd.Connection = sqlConn

            sqlcmd.ExecuteNonQuery()
            MsgBox(" Siswa " & txtNama.Text & " Berhasil Dihapus")
        Catch ex As Exception
            MsgBox("data dengan nama (" & txtNama.Text & ") telah digunakan di tabel lain'")
            MsgBox(" Siswa " & txtNama.Text & " Tidak Berhasil Dihapus")
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Module_koneksiSQL.setconnection()
        Dim pesanhapus = MessageBox.Show("Apakah anda yakin akan menghapus data siswa bernama " & txtNama.Text & " ?", "Konfirmasi Hapus Siswa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If pesanhapus = DialogResult.Yes Then
            HapusData()

            clear()
            TampilData() 'untuk merefresh kembali data yang diinputkan
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtNoPendaftaran.Text = DataGridView1(0, i).Value
        txtNama.Text = DataGridView1.Item(1, i).Value
        txtTempatLahir.Text = DataGridView1.Item(2, i).Value
        dtpTanggalLahir.Value = Convert.ToDateTime(DataGridView1.Item(3, i).Value).Date
        txtUmur.Text = DataGridView1.Item(4, i).Value
        cbxJenisKelamin.Text = DataGridView1.Item(5, i).Value
        txtAgama.Text = DataGridView1.Item(6, i).Value
        txtNoTelp.Text = DataGridView1.Item(7, i).Value
        rtbAlamatsiswa.Text = DataGridView1.Item(8, i).Value
        txtNamaAyah.Text = DataGridView1.Item(9, i).Value
        txtNamaIbu.Text = DataGridView1.Item(10, i).Value
        txtPekerjaanAyah.Text = DataGridView1.Item(11, i).Value
        txtPekerjaanIbu.Text = DataGridView1.Item(12, i).Value
        txtNoTelp2.Text = DataGridView1.Item(13, i).Value
        txtAlamatTinggal.Text = DataGridView1.Item(14, i).Value
        txtNamaAsalSekolah.Text = DataGridView1.Item(15, i).Value
        rtbAlamatSekolah.Text = DataGridView1.Item(16, i).Value

        btnHapus.Enabled = True
        btnUbah.Enabled = True
        btnInputData.Enabled = True
        aktif()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub labeltanggal_Click(sender As Object, e As EventArgs) Handles labeltanggal.Click
    End Sub
    Private Sub Edit()
            Module_koneksiSQL.setconnection()
            sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("Update Tdata_siswa set [nama_siswa] = '" & txtNama.Text & _
                                                            "',tempat_lahir = '" & txtTempatLahir.Text & _
                                                            "',tanggal_lahir = '" & dtpTanggalLahir.Value.Date.ToString & _
                                                            "',umur = '" & txtUmur.Text & _
                                                            "',jenis_kelamin = '" & cbxJenisKelamin.Text & _
                                                            "',agama = '" & txtAgama.Text & _
                                                            "',notelp_siswa = '" & txtNoTelp.Text & _
                                                            "',alamat_siswa = '" & rtbAlamatsiswa.Text & _
                                                            "',nama_ayah = '" & txtNamaAyah.Text & _
                                                            "',nama_ibu = '" & txtNamaIbu.Text & _
                                                            "',pekerjaan_ayah = '" & txtPekerjaanAyah.Text & _
                                                            "',pekerjaan_ibu = '" & txtPekerjaanIbu.Text & _
                                                            "',notelp_ortu = '" & txtNoTelp2.Text & _
                                                            "',alamat_ortu = '" & txtAlamatTinggal.Text & _
                                                            "',asal_sekolah = '" & txtNamaAsalSekolah.Text & _
                                                            "',alamat_salsek = '" & rtbAlamatSekolah.Text & _
                                                            "'where no_formulir = '" & txtNoPendaftaran.Text & "'", sqlConn)

            sqlcmd.Connection = sqlConn
            sqlcmd.ExecuteNonQuery()
            MsgBox(" Data " & txtNama.Text & " Berhasil Telah diubah")

    End Sub
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Call Edit()
        Call clear()
        off()
        TampilData() 'untuk merefresh kembali data yang diinputkan
    End Sub

    Private Sub rtbAlamatsiswa_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtNoTelp_TextChanged(sender As Object, e As EventArgs) Handles txtNoTelp.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles labell_tanggal.Click
        labell_tanggal.Text = Now.Day & "/" & Now.Month & "/" & Now.Year
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        aktif()
        clear()
        btnUbah.Enabled = False
        btnHapus.Enabled = False
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub CariData_Click(sender As Object, e As EventArgs) Handles CariData.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Module_koneksiSQL.setconnection()
        Dim strTemp = ""
        If txtcarinopend.Text <> "" Then
            strTemp = " AND [no_formulir] LIKE '%" & txtcarinopend.Text & "%'"


        End If
        If txtcarinama.Text <> "" Then
            strTemp += " AND [nama_siswa] LIKE '%" & txtcarinama.Text & "%'"

        End If
        If txtcarialamat.Text <> "" Then
            strTemp += " AND [alamat] LIKE '%" & txtcarialamat.Text & "%'"

        End If
        If txtcariumur.Text <> "" Then
            strTemp += " AND [umur] LIKE '%" & txtcariumur.Text & "%'"

        End If
        da = New SqlDataAdapter("Select * FROM [Tdata_siswa] where (1=1)" & strTemp, sqlConn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "[Tdata_siswa]")

        DataGridView1.DataSource = ds.Tables("[Tdata_siswa]")
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtcarinama.TextChanged

    End Sub
End Class