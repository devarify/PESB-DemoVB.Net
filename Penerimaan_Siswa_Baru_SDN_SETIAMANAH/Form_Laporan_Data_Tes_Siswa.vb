Public Class Form_Laporan_Data_Tes_Siswa

    Private Sub Form_Laporan_Data_Tes_Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatatesDataSet.Tdatates' table. You can move, or remove it, as needed.
        'Me.TdatatesTableAdapter.Fill(Me.DatatesDataSet.Tdatates)

    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        form_laporantessiswa.Show()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
End Class