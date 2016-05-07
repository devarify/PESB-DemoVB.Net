Public Class Form_Laporan_Data_Calon_Siswa

    Private Sub Form_Laporan_Data_Calon_Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_PSB_SetiamanahDataSettes.Tdata_siswa' table. You can move, or remove it, as needed.
        Me.Tdata_siswaTableAdapter.Fill(Me.Db_PSB_SetiamanahDataSettes.Tdata_siswa)

    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        form_laporancalonsiswa.Show()
    End Sub
End Class