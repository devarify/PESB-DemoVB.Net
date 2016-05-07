Imports System.Windows.Forms

Public Class mdi_Utama
    Sub session()
        Module_koneksiSQL.setconnection()
        sqlConn.Open()
        da = New SqlClient.SqlDataAdapter("select username from Tlogin where username='" & Form_admin.txtUser.Text & "' and password=HASHBYTES('MD5','" & Form_admin.txtPass.Text & "')", sqlConn)
        Dim tbuser As New DataTable
        tbuser.Clear()
        da.Fill(tbuser)
        Dim username As String
        username = tbuser.Rows(0).Item("username")
        sqlConn.Close()
    End Sub

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Sub Terkunci()
        EditToolStripMenuItem.Enabled = False
        FileToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        TentangToolStripMenuItem.Enabled = True
        ToolStripButton_login.Enabled = True
        BantuanToolStripMenuItem.Enabled = True
        LogooutToolStripMenuItem.Enabled = False
        AkunBaruToolStripMenuItem.Enabled = False

    End Sub
    Sub Terbuka()
        EditToolStripMenuItem.Enabled = True
        FileToolStripMenuItem.Enabled = True
        LaporanToolStripMenuItem.Enabled = True
        TentangToolStripMenuItem.Enabled = True
        ToolStripButton_login.Enabled = False
        BantuanToolStripMenuItem.Enabled = True
        LogooutToolStripMenuItem.Enabled = True
        AkunBaruToolStripMenuItem.Enabled = True
    End Sub
    Private Sub mdi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub FormCalonSiswaBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormCalonSiswaBaruToolStripMenuItem.Click
        Form_Calon_Data_Siswa.Show()
    End Sub

    Private Sub FormDataSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormDataSiswaToolStripMenuItem.Click
        Form_Datates_siswa.Show()
    End Sub

    Private Sub FormSiswaBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormSiswaBaruToolStripMenuItem.Click
        Form_Siswa_Baru.Show()
    End Sub

    Private Sub DataCalonSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataCalonSiswaToolStripMenuItem.Click
        Form_Laporan_Data_Calon_Siswa.Show()
    End Sub

    Private Sub DataTesSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataTesSiswaToolStripMenuItem.Click
        Form_Laporan_Data_Tes_Siswa.Show()
    End Sub

    Private Sub DataSiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSiswaToolStripMenuItem.Click
        Form_Laporan_Data_Siswa_Baru.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pesanutama = MessageBox.Show("Apakah anda yakin akan ke Keluar", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesanutama = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub FileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem1.Click

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click

    End Sub

    Private Sub LogooutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogooutToolStripMenuItem.Click
        Dim pesanhapus = MessageBox.Show("Apakah anda yakin akan Logout   ?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If pesanhapus = DialogResult.Yes Then
            Call Terkunci()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub BantuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BantuanToolStripMenuItem.Click
        Form_bantuan.Show()
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TentangToolStripMenuItem.Click
        Form_tentang.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        If MessageBox.Show("Yakin akan keluar dari Aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahToolStripMenuItem.Click
        Form_Identitas_Sekolah.Show()
    End Sub

    Private Sub TahunAjaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TahunAjaranToolStripMenuItem.Click
        Form_Tahun_Ajaran.Show()
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton_login.Click
        Form_Login.Show()
    End Sub

    Private Sub AkunBaruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkunBaruToolStripMenuItem.Click
        Form_admin.Show()
    End Sub

    Private Sub ToolStripButton_keluar_Click(sender As Object, e As EventArgs) Handles ToolStripButton_keluar.Click
        If MessageBox.Show("Yakin akan keluar dari Aplikasi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub ToolStripButton_tentang_Click(sender As Object, e As EventArgs) Handles ToolStripButton_tentang.Click
        Form_tentang.MdiParent = Me
        Form_tentang.Show()
    End Sub

    Private Sub ToolStripButton_bantuan_Click(sender As Object, e As EventArgs) Handles ToolStripButton_bantuan.Click
        Form_bantuan.MdiParent = Me
        Form_bantuan.Show()
    End Sub

    Private Sub CetakFormulirPendaftaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CetakFormulirPendaftaranToolStripMenuItem.Click
        Form_Cetak_Pendaftaran.MdiParent = Me
        Form_Cetak_Pendaftaran.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripStatusLabel_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel.Click
        ToolStripStatusLabel.Text = Form_Login.txtUsername.Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
