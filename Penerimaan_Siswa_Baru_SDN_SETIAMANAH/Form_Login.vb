Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class Form_Login

    Dim tblLogin As DataTable
    Dim Proses As New Koneksi
    Sub bersih()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub
    Sub Login()
        If txtUsername.Text = "" Then MsgBox("Anda Belum Memasukan Username!")
        If txtPassword.Text = "" Then MsgBox("Nama Belum Memasukan Password!")
        If txtUsername.Text = "" Then txtUsername.Focus() : Exit Sub
        If txtPassword.Text = "" Then txtPassword.Focus() : Exit Sub
        tblLogin = Proses.ExecuteQuery("Select * From Tlogin Where username = '" & txtUsername.Text & "' and password ='" & txtPassword.Text & "'")
        If tblLogin.Rows.Count = 0 Then
            MessageBox.Show("Login tidak berhasil..!! cek kembali atau hubungi operator!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
            bersih()
        Else
            MsgBox(" Anda Berhasil Login dengan User (" & txtUsername.Text & ")", MsgBoxStyle.Information, "Login Sukses..")
            mdi_Utama.Terbuka()
            Me.Hide()
        End If
    End Sub


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call Login()
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
    End Sub
End Class
