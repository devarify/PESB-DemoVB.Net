Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.Sql
Public Class Form_Tahun_Ajaran
    Private Sub tampil()
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("SELECT * FROM Ttahunajaran", sqlConn)
        ds = New DataSet
        da.Fill(ds, "Ttahunajaran")
        DataGridView1.DataSource = ds.Tables("Ttahunajaran")
        sqlcmd = New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandText = "SELECT * FROM Ttahunajaran"
        rd = sqlcmd.ExecuteReader
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        txtTahunAjaran.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        Module_koneksiSQL.setconnection()
        If txtTahunAjaran.Text = "" Then
            MsgBox("Tahun Ajaran Belum di isi")

        Else
            Dim pesan = MessageBox.Show("Apakah anda yakin akan menambahkan data tahun " & txtTahunAjaran.Text & " ?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If pesan = DialogResult.OK Then


                Module_koneksiSQL.setconnection()
                sqlcmd = New SqlCommand()
                sqlcmd.CommandText = String.Format("INSERT INTO Ttahunajaran (tahun_ajaran) values('{0}')", txtTahunAjaran.Text, sqlConn)

                sqlcmd.Connection = sqlConn
                sqlcmd.ExecuteNonQuery()
                MsgBox(" Data tahun " & txtTahunAjaran.Text & " Berhasil Disimpan")

            Else
                Exit Sub
            End If
            tampil()
            txtTahunAjaran.Clear()
            off()
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim grid As Integer
        grid = DataGridView1.CurrentRow.Index

        txtTahunAjaran.Text = DataGridView1.Item(1, grid).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        aktif()
    End Sub
    Sub aktif()
        txtTahunAjaran.Enabled = True
        btnubah.Enabled = True
        btnsimpan.Enabled = True
    End Sub
    Sub off()
        txtTahunAjaran.Enabled = False
        btnubah.Enabled = False
        btnsimpan.Enabled = False
    End Sub
    Private Sub Form_Tahun_Ajaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call off()
        tampil()
    End Sub
    Private Sub HapusData()
        Module_koneksiSQL.setconnection()
        sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("DELETE FROM Ttahunajaran where [tahun_ajaran]='" & txtTahunAjaran.Text & "'", sqlConn)
        sqlcmd.Connection = sqlConn
        sqlcmd.ExecuteNonQuery()


    End Sub
    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Module_koneksiSQL.setconnection()
        Dim pesanhapus = MessageBox.Show("Apakah anda yakin akan menghapus data tahun " & txtTahunAjaran.Text & " ?", "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If pesanhapus = DialogResult.Yes Then
            HapusData()
            MsgBox(" Siswa " & txtTahunAjaran.Text & " Berhasil Dihapus")
            txtTahunAjaran.Clear()
            tampil() 'untuk merefresh kembali data yang diinputkan
        Else
            Exit Sub
        End If
    End Sub
    Private Sub edit()
        Module_koneksiSQL.setconnection()
        sqlcmd = New SqlCommand()
        sqlcmd.CommandText = String.Format("UPDATE Ttahunajaran set [tahun_ajaran]='" & txtTahunAjaran.Text, sqlConn)
        sqlcmd.Connection = sqlConn
        sqlcmd.ExecuteNonQuery()
        MsgBox(" Data " & txtTahunAjaran.Text & " Berhasil Telah diubah")
        txtTahunAjaran.Clear()
        off()
        tampil() 'untuk merefresh kembali data yang diinputkan
    End Sub
    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        edit()
    End Sub
End Class