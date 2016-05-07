Imports System.Data.SqlClient

Public Class Tampil_nopendaftar

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        Form_Datates_siswa.txtnopendaftaran.Text = DataGridView1(0, i).Value
        Form_Datates_siswa.txtNama.Text = DataGridView1.Item(1, i).Value
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Tampil_nopendaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatatesDataSet.Tdata_siswa' table. You can move, or remove it, as needed.
        Me.Tdata_siswaTableAdapter1.Fill(Me.DatatesDataSet.Tdata_siswa)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Module_koneksiSQL.setconnection()
        da = New SqlDataAdapter("Select * FROM [Tdata_siswa] where [nama_siswa] like '%" & TextBox1.Text & "%'", sqlConn)

        Dim ds As DataSet = New DataSet
        da.Fill(ds, "[Tdata_siswa]")
        DataGridView1.DataSource = ds.Tables("[Tdata_siswa]")
        DataGridView1.Refresh()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class