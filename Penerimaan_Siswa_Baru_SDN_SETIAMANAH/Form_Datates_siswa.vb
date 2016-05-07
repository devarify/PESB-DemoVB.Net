Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.Sql
Public Class Form_Datates_siswa
    Private Sub TampilData()
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("SELECT * FROM Tdatates", sqlConn)
        ds = New DataSet
        da.Fill(ds, "Tdatates")
        DataGridView2.DataSource = ds.Tables("Tdatates")
        sqlcmd = New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandText = "SELECT * FROM Tdatates"
        rd = sqlcmd.ExecuteReader

        ListView1.Items.Clear()
        Dim item As ListViewItem
        Do While rd.Read
            item = ListView1.Items.Add(rd!no_formulir.ToString)
            item.SubItems.Add(rd!nama_siswa.ToString())
            item.SubItems.Add(rd!tgl_tes.ToString())
            item.SubItems.Add(rd!tes_baca.ToString())
            item.SubItems.Add(rd!tes_tulis.ToString())
            item.SubItems.Add(rd!tes_hitung.ToString())
            item.SubItems.Add(rd!ratates.ToString())
            item.SubItems.Add(rd!keterangan.ToString())
        Loop
        rd.Close()

    End Sub
    Sub aktif()
        Module_koneksiSQL.setconnection()
        txtnopendaftaran.Enabled = True
        txtNama.Enabled = True
        dtpTanggalTes.Enabled = True
        txtTesbaca.Enabled = True
        txtTestulis.Enabled = True
        txtTeshitung.Enabled = True
        txtRatates.Enabled = True
        txtKeterangan.Enabled = True
    End Sub
    Sub off()
        Module_koneksiSQL.setconnection()
        txtnopendaftaran.Enabled = False
        txtNama.Enabled = False
        dtpTanggalTes.Enabled = False
        txtTesbaca.Enabled = False
        txtTestulis.Enabled = False
        txtTeshitung.Enabled = False
        txtRatates.Enabled = False
        txtKeterangan.Enabled = False
    End Sub
    Sub clear()
        Module_koneksiSQL.setconnection()
        txtTesbaca.Clear()
        txtTestulis.Clear()
        txtTeshitung.Clear()
        txtRatates.Clear()
        txtKeterangan.Clear()
    End Sub
    Private Sub InputData()
        Module_koneksiSQL.setconnection()
        If txtnopendaftaran.Text = "" Then
            MsgBox("Nomor Pendaftaran Belum di isi")
        ElseIf dtpTanggalTes.Value = Date.Now.Date Then
            MsgBox("Tanggal Tes Belum di isi")
        ElseIf txtTesbaca.Text = "" Then
            MsgBox("Nilai Tes Baca Belum di isi")
        ElseIf txtTestulis.Text = "" Then
            MsgBox("Nilai Tes Tulis Belum di isi")
        ElseIf txtTeshitung.Text = "" Then
            MsgBox("Nilai Tes Hitung Belum di isi")


        Else
            Dim pesan = MessageBox.Show("Apakah anda yakin akan menambahkan data siswa bernama " & txtnopendaftaran.Text & " ?", "Konfirmasi Tambahkan Data Siswa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If pesan = DialogResult.OK Then

                Try
                    Module_koneksiSQL.setconnection()
                    sqlcmd = New SqlCommand()
                    sqlcmd.CommandText = String.Format("INSERT INTO Tdatates (no_formulir, nama_siswa, tgl_tes, tes_baca, tes_tulis, tes_hitung, ratates, keterangan) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", _
                                                txtnopendaftaran.Text, txtNama.Text, dtpTanggalTes.Value.Date.ToString("MM/dd/yyyy"), _
                                                                            txtTesbaca.Text, txtTestulis.Text, txtTeshitung.Text, txtRatates.Text, txtKeterangan.Text, sqlConn)

                    sqlcmd.Connection = sqlConn
                    sqlcmd.ExecuteNonQuery()
                    MsgBox(" Data siswa yang bernama " & txtNama.Text & " Berhasil Disimpan")
                Catch ex As Exception
                    MsgBox(" No Pendaftar Sudah Ada Dalam Tabel! ")
                End Try

            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub HapusData()
        Module_koneksiSQL.setconnection()
        sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("DELETE FROM Tdatates where [no_formulir]='" & txtnopendaftaran.Text & "'", sqlConn)
        sqlcmd.Connection = sqlConn
        sqlcmd.ExecuteNonQuery()


    End Sub
    Private Sub EditData()
        Module_koneksiSQL.setconnection()
        sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("UPDATE Tdatates set [nama_siswa]='" & txtNama.Text & _
                                                                        "',tgl_tes ='" & dtpTanggalTes.Value.Date & _
                                                                        "',tes_baca ='" & txtTesbaca.Text & _
                                                                        "',tes_tulis ='" & txtTestulis.Text & _
                                                                        "',tes_hitung ='" & txtTeshitung.Text & _
                                                                        "',ratates ='" & txtRatates.Text & _
                                                                        "',keterangan ='" & txtKeterangan.Text & _
                                                                        "'where no_formulir = '" & txtnopendaftaran.Text & "'", sqlConn)
        sqlcmd.Connection = sqlConn
        sqlcmd.ExecuteNonQuery()
        MsgBox(" Data " & txtnopendaftaran.Text & " Berhasil Telah diubah")
        clear()
        TampilData() 'untuk merefresh kembali data yang diinputkan
    End Sub
    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub Form_Datates_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatatesDataSet.Tdatates' table. You can move, or remove it, as needed.
        Me.TdatatesTableAdapter1.Fill(Me.DatatesDataSet.Tdatates)

        'menghilangkan row header
        DataGridView2.RowHeadersVisible = False
        'agar ketika baris di datagrid diklik 1x melalui mouse atau kursor, satu baris penuh yang pilih, bukan per kolom
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'agar ketika baris di datagrid diklik 1x melalui mouse atau kursor, warna tulisan yang berubah
        DataGridView2.DefaultCellStyle.SelectionForeColor = Color.White
        'Membuat Header per kolom


        'TODO: This line of code loads data into the 'DatatesDataSet1.Tdata_siswa' table. You can move, or remove it, as needed.
        Me.Tdata_siswaTableAdapter.Fill(Me.DatatesDataSet1.Tdata_siswa)
        TampilData()
        txtNama.Enabled = False
        txtnopendaftaran.Enabled = False
       
    End Sub

    Private Sub btnMasukan_Click(sender As Object, e As EventArgs) Handles btnMasukan.Click
        InputData()
        TampilData() 'untuk merefresh kembali data yang diinputkan
        clear()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim grid As Integer
        grid = DataGridView2.CurrentRow.Index

        txtnopendaftaran.Text = DataGridView2.Item(0, grid).Value
        txtNama.Text = DataGridView2.Item(1, grid).Value
        dtpTanggalTes.Value = Convert.ToDateTime(DataGridView2.Item(2, grid).Value).Date
        txtTesbaca.Text = DataGridView2.Item(3, grid).Value
        txtTestulis.Text = DataGridView2.Item(4, grid).Value
        txtTeshitung.Text = DataGridView2.Item(5, grid).Value
        txtRatates.Text = DataGridView2.Item(6, grid).Value
        txtKeterangan.Text = DataGridView2.Item(7, grid).Value
        btnHapus.Enabled = True
        btnUbah.Enabled = True
        btnMasukan.Enabled = True
        aktif()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Module_koneksiSQL.setconnection()
        Dim pesanhapus = MessageBox.Show("Apakah anda yakin akan menghapus data siswa bernama " & txtnopendaftaran.Text & " ?", "Konfirmasi Hapus Siswa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If pesanhapus = DialogResult.Yes Then
            HapusData()
            MsgBox(" Siswa " & txtnopendaftaran.Text & " Berhasil Dihapus")
            clear()
            TampilData() 'untuk merefresh kembali data yang diinputkan
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        EditData()
    End Sub

    Private Sub txtRatates_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRatates.KeyPress
       
    End Sub
    Private Sub txtRatates_MouseMove(sender As Object, e As MouseEventArgs) Handles txtRatates.MouseMove
        Dim a, b, c As Integer
        a = Val(txtTesbaca.Text)
        b = Val(txtTestulis.Text)
        c = Val(txtTeshitung.Text)
        txtRatates.Text = (a + b + c) / 3
    End Sub
    Private Sub txtRatates_TextChanged(sender As Object, e As EventArgs) Handles txtRatates.TextChanged
    End Sub

    Private Sub txtTesbaca_TextChanged(sender As Object, e As EventArgs) Handles txtTesbaca.TextChanged

    End Sub

    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Tampil_nopendaftar.Show()
    End Sub

    Private Sub txtKeterangan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeterangan.KeyPress

    End Sub
    Private Sub txtKeterangan_MouseMove(sender As Object, e As MouseEventArgs) Handles txtKeterangan.MouseMove
        Dim a, ratates As Integer
        a = 70
        ratates = Val(txtRatates.Text)
        If a <= ratates Then
            txtKeterangan.Text = "LULUS"
        Else
            txtKeterangan.Text = "TIDAK LULUS"
        End If
    End Sub

    Private Sub txtKeterangan_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module_koneksiSQL.setconnection()
        Dim strTemp = ""
        If txtcarinoform.Text <> "" Then
            strTemp = " AND [no_formulir] LIKE '%" & txtcarinoform.Text & "%'"


        End If
        If txtcarinama.Text <> "" Then
            strTemp += " AND [nama_siswa] LIKE '%" & txtcarinama.Text & "%'"

        End If
        da = New SqlDataAdapter("Select * FROM [Tdatates] where (1=1)" & strTemp, sqlConn)
        Dim ds As DataSet = New DataSet
        da.Fill(ds, "[Tdatates]")

        DataGridView2.DataSource = ds.Tables("[Tdatates]")
        Me.DataGridView2.Refresh()
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        Cetaktessiswa.Show()
    End Sub
End Class