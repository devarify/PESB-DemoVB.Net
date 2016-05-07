Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data.Sql
Public Class Form_Identitas_Sekolah
    Dim tabel As OleDb.OleDbDataAdapter
    Dim data As DataSet
    Dim record As New BindingSource

    Private Sub TampilData()
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("SELECT * FROM Tsekolah", sqlConn)
        ds = New DataSet
        da.Fill(ds, "Tsekolah")
        DataGridView1.DataSource = ds.Tables("Tsekolah")
        sqlcmd = New SqlCommand
        sqlcmd.Connection = sqlConn
        sqlcmd.CommandText = "SELECT * FROM Tsekolah"
        rd = sqlcmd.ExecuteReader


    End Sub
    Sub bersih()
        txtNamaSekolah.Clear()
        txtNamaKepsek.Clear()
        txtNIPKepSek.Clear()
        txtNoRegSek.Clear()
        txtTelpSekolah.Clear()
        txtAlamatSek.Clear()
        txtKecSek.Clear()
        txtKotaSek.Clear()
        txtKodePosSek.Clear()
        txtFaxSek.Clear()
        txtEmailSek.Clear()
    End Sub
    Sub off()
        Module_koneksiSQL.setconnection()
        txtNamaSekolah.Enabled = False
        txtNamaKepsek.Enabled = False
        txtNIPKepSek.Enabled = False
        txtNoRegSek.Enabled = False
        txtTelpSekolah.Enabled = False
        txtAlamatSek.Enabled = False
        txtKecSek.Enabled = False
        txtKotaSek.Enabled = False
        txtKodePosSek.Enabled = False
        txtFaxSek.Enabled = False
        txtEmailSek.Enabled = False
        btnSimpan.Enabled = False
        btnBatal.Enabled = False
    End Sub
    Private Sub InputData()
        Module_koneksiSQL.setconnection()
        If txtNamaSekolah.Text = "" Then
            MsgBox("Nama Sekolah di isi")
            'ElseIf txtNamaKepsek.Text = "" Then
            '    MsgBox("Nama kepala sekolah wajib di isi")
            'ElseIf txtNIPKepSek.Text = "" Then
            '    MsgBox("NIP Kepala Sekolah Belum di isi")
            'ElseIf txtAlamatSek.Text = "" Then
            '    MsgBox("Alamat Sekolah Belum di isi")

        Else
            Dim pesan = MessageBox.Show("Apakah anda yakin akan menyimpaan Nama Sekolah (" & txtNamaSekolah.Text & ") ?", "Konfirmasi Menyimpan Sekolah", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If pesan = DialogResult.OK Then


                Module_koneksiSQL.setconnection()
                sqlcmd = New SqlCommand()
                sqlcmd.CommandText = String.Format("INSERT INTO Tsekolah (nama_sekolah, nama_kepsek, nip_kepsek, noreg_sekolah, telp_sekolah, alamat_sekolah, kec_sekolah, kota_sekolah, kodepos_sekolah, fax_sekolah, email_sekolah) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", _
                                            txtNamaSekolah.Text, txtNamaKepsek.Text, txtNIPKepSek.Text, txtNoRegSek.Text, _
                                            txtTelpSekolah.Text, txtAlamatSek.Text, txtKecSek.Text, txtKotaSek.Text, txtKodePosSek.Text, _
                                            txtFaxSek.Text, txtEmailSek.Text, sqlConn)

                sqlcmd.Connection = sqlConn
                sqlcmd.ExecuteNonQuery()
                MsgBox(" Data siswa yang bernama " & txtNamaSekolah.Text & " Berhasil Disimpan")

                Exit Sub
            End If
        End If

    End Sub
    'Private Function getDataGambar(ByVal oPic As PictureBox) As Byte()
    '    'Dim ms As New MemoryStream()
    '    'oPic.Image.Save(ms, oPic.Image.RawFormat)
    '    'Dim dataGbr As Byte() = ms.GetBuffer()
    '    'Return dataGbr
    'End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        InputData()
        bersih()
        TampilData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "picture Files (*.jpg)|*.jpg|picture Files (*.png)|*.png|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            pictgambarkiri.Load(FileName)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "picture Files (*.jpg)|*.jpg|picture Files (*.png)|*.png|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            pictgambarkanan.Load(FileName)
        End If
    End Sub

    Private Sub pictgambarkiri_Click(sender As Object, e As EventArgs) Handles pictgambarkiri.Click

    End Sub

    Private Sub Form_Identitas_Sekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatasekolahDataSet.Tsekolah' table. You can move, or remove it, as needed.
        'Me.TsekolahTableAdapter.Fill(Me.DatasekolahDataSet.Tsekolah)
        TampilData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        txtNamaSekolah.Text = DataGridView1(0, i).Value
        txtNamaKepsek.Text = DataGridView1.Item(1, i).Value
        txtNIPKepSek.Text = DataGridView1.Item(2, i).Value
        txtNoRegSek.Text = DataGridView1.Item(3, i).Value
        txtTelpSekolah.Text = DataGridView1.Item(4, i).Value
        txtAlamatSek.Text = DataGridView1.Item(5, i).Value
        txtKecSek.Text = DataGridView1.Item(6, i).Value
        txtKotaSek.Text = DataGridView1.Item(7, i).Value
        txtKodePosSek.Text = DataGridView1.Item(8, i).Value
        txtFaxSek.Text = DataGridView1.Item(9, i).Value
        txtEmailSek.Text = DataGridView1.Item(10, i).Value
        TampilData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class