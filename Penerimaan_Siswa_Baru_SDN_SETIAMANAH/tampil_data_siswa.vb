Imports System.Data.SqlClient
Public Class tampil_data_siswa

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Form_Siswa_Baru.txtNo_pendaftaran.Text = DataGridView1(0, i).Value
        Form_Siswa_Baru.txtNamaSiswa.Text = DataGridView1.Item(1, i).Value
        Form_Siswa_Baru.txtTempatLahir.Text = DataGridView1.Item(2, i).Value
        Form_Siswa_Baru.dtpTanggalLahir.Value = Convert.ToDateTime(DataGridView1.Item(3, i).Value).Date
        Form_Siswa_Baru.txtUmur.Text = DataGridView1.Item(4, i).Value
        Form_Siswa_Baru.txtjeniskelamin.Text = DataGridView1.Item(5, i).Value
        Form_Siswa_Baru.txtagama.Text = DataGridView1.Item(6, i).Value
        Form_Siswa_Baru.txtAlamat.Text = DataGridView1.Item(7, i).Value
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("Select * FROM [Tdata_siswa] where [nama_siswa] like '%" & TextBox1.Text & "%'", sqlConn)

        Dim ds As DataSet = New DataSet
        da.Fill(ds, "[Tdata_siswa]")
        DataGridView1.DataSource = ds.Tables("[Tdata_siswa]")
        DataGridView1.Refresh()
    End Sub

    Private Sub tampil_data_siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatasiswalulusDataSet.Tdata_siswa' table. You can move, or remove it, as needed.
        Me.Tdata_siswaTableAdapter.Fill(Me.DatasiswalulusDataSet.Tdata_siswa)

    End Sub

    Private Sub FillBylulusToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBylulusToolStripButton.Click
        Try
            Me.Tdata_siswaTableAdapter.FillBylulus(Me.DatasiswalulusDataSet.Tdata_siswa)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class