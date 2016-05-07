Public Class Form_Laporan_Data_Siswa_Baru

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        form_laporansiswabaru.Show()
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form_Laporan_Data_Siswa_Baru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Datasiswabaru.Tdata_siswa' table. You can move, or remove it, as needed.
        Me.Tdata_siswaTableAdapter.Fill(Me.Datasiswabaru.Tdata_siswa)
        'TODO: This line of code loads data into the 'Datasiswabaru.Tsiswabaru' table. You can move, or remove it, as needed.
        Me.TsiswabaruTableAdapter.Fill(Me.Datasiswabaru.Tsiswabaru)

    End Sub
End Class