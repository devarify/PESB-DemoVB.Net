<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Siswa_Baru
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Siswa_Baru))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtagama = New System.Windows.Forms.TextBox()
        Me.txtjeniskelamin = New System.Windows.Forms.TextBox()
        Me.Tampil = New System.Windows.Forms.Button()
        Me.txtNo_pendaftaran = New System.Windows.Forms.TextBox()
        Me.txtkelas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpTanggalDiterima = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNoInduk = New System.Windows.Forms.TextBox()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.txtNamaSiswa = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtTempatLahir = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_SiswaBaru = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.txtCarinoinduk = New System.Windows.Forms.TextBox()
        Me.btnPerbaikan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnMasukanData = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DatasiswabaruDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSet()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSetTableAdapters.Tdata_siswaTableAdapter()
        Me.DatasiswabaruBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Datasiswabaru = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaru()
        Me.btnbaru = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtcarikelas = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcaritanggal = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_SiswaBaru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DatasiswabaruDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasiswabaruBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datasiswabaru, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtagama)
        Me.GroupBox1.Controls.Add(Me.txtjeniskelamin)
        Me.GroupBox1.Controls.Add(Me.Tampil)
        Me.GroupBox1.Controls.Add(Me.txtNo_pendaftaran)
        Me.GroupBox1.Controls.Add(Me.txtkelas)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalDiterima)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtNoInduk)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalLahir)
        Me.GroupBox1.Controls.Add(Me.txtNamaSiswa)
        Me.GroupBox1.Controls.Add(Me.txtAlamat)
        Me.GroupBox1.Controls.Add(Me.txtUmur)
        Me.GroupBox1.Controls.Add(Me.txtTempatLahir)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 306)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Siswa Baru"
        '
        'txtagama
        '
        Me.txtagama.Location = New System.Drawing.Point(218, 196)
        Me.txtagama.Name = "txtagama"
        Me.txtagama.Size = New System.Drawing.Size(100, 22)
        Me.txtagama.TabIndex = 24
        '
        'txtjeniskelamin
        '
        Me.txtjeniskelamin.Location = New System.Drawing.Point(218, 169)
        Me.txtjeniskelamin.Name = "txtjeniskelamin"
        Me.txtjeniskelamin.Size = New System.Drawing.Size(100, 22)
        Me.txtjeniskelamin.TabIndex = 23
        '
        'Tampil
        '
        Me.Tampil.Location = New System.Drawing.Point(337, 13)
        Me.Tampil.Name = "Tampil"
        Me.Tampil.Size = New System.Drawing.Size(75, 23)
        Me.Tampil.TabIndex = 21
        Me.Tampil.Text = "Tampil"
        Me.Tampil.UseVisualStyleBackColor = True
        '
        'txtNo_pendaftaran
        '
        Me.txtNo_pendaftaran.Location = New System.Drawing.Point(218, 13)
        Me.txtNo_pendaftaran.Name = "txtNo_pendaftaran"
        Me.txtNo_pendaftaran.Size = New System.Drawing.Size(112, 22)
        Me.txtNo_pendaftaran.TabIndex = 20
        '
        'txtkelas
        '
        Me.txtkelas.Location = New System.Drawing.Point(218, 274)
        Me.txtkelas.Name = "txtkelas"
        Me.txtkelas.Size = New System.Drawing.Size(200, 22)
        Me.txtkelas.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Kelas"
        '
        'dtpTanggalDiterima
        '
        Me.dtpTanggalDiterima.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalDiterima.Location = New System.Drawing.Point(218, 248)
        Me.dtpTanggalDiterima.Name = "dtpTanggalDiterima"
        Me.dtpTanggalDiterima.Size = New System.Drawing.Size(112, 22)
        Me.dtpTanggalDiterima.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "No Induk Siswa"
        '
        'txtNoInduk
        '
        Me.txtNoInduk.Location = New System.Drawing.Point(218, 39)
        Me.txtNoInduk.Name = "txtNoInduk"
        Me.txtNoInduk.Size = New System.Drawing.Size(112, 22)
        Me.txtNoInduk.TabIndex = 16
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(218, 117)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(112, 22)
        Me.dtpTanggalLahir.TabIndex = 5
        '
        'txtNamaSiswa
        '
        Me.txtNamaSiswa.Location = New System.Drawing.Point(218, 65)
        Me.txtNamaSiswa.Name = "txtNamaSiswa"
        Me.txtNamaSiswa.Size = New System.Drawing.Size(200, 22)
        Me.txtNamaSiswa.TabIndex = 14
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(218, 222)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 22)
        Me.txtAlamat.TabIndex = 12
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(218, 143)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(112, 22)
        Me.txtUmur.TabIndex = 10
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.Location = New System.Drawing.Point(218, 91)
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(200, 22)
        Me.txtTempatLahir.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tanggal Diterima"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Alamat Tinggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Umur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Siswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Pendaftaran"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_SiswaBaru)
        Me.GroupBox2.Location = New System.Drawing.Point(448, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 207)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tampilan Siswa Baru"
        '
        'DataGridView_SiswaBaru
        '
        Me.DataGridView_SiswaBaru.AllowUserToAddRows = False
        Me.DataGridView_SiswaBaru.AllowUserToDeleteRows = False
        Me.DataGridView_SiswaBaru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_SiswaBaru.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_SiswaBaru.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView_SiswaBaru.Name = "DataGridView_SiswaBaru"
        Me.DataGridView_SiswaBaru.ReadOnly = True
        Me.DataGridView_SiswaBaru.Size = New System.Drawing.Size(343, 186)
        Me.DataGridView_SiswaBaru.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.txtcaritanggal)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtcarikelas)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btncari)
        Me.GroupBox3.Controls.Add(Me.txtCarinoinduk)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 50)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 120)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pencarian Data"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(220, 16)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(123, 100)
        Me.btncari.TabIndex = 27
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'txtCarinoinduk
        '
        Me.txtCarinoinduk.Location = New System.Drawing.Point(106, 19)
        Me.txtCarinoinduk.Name = "txtCarinoinduk"
        Me.txtCarinoinduk.Size = New System.Drawing.Size(108, 22)
        Me.txtCarinoinduk.TabIndex = 24
        '
        'btnPerbaikan
        '
        Me.btnPerbaikan.Location = New System.Drawing.Point(230, 364)
        Me.btnPerbaikan.Name = "btnPerbaikan"
        Me.btnPerbaikan.Size = New System.Drawing.Size(173, 40)
        Me.btnPerbaikan.TabIndex = 23
        Me.btnPerbaikan.Text = "Ubah"
        Me.btnPerbaikan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(230, 410)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(173, 40)
        Me.btnHapus.TabIndex = 25
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnMasukanData
        '
        Me.btnMasukanData.Location = New System.Drawing.Point(12, 410)
        Me.btnMasukanData.Name = "btnMasukanData"
        Me.btnMasukanData.Size = New System.Drawing.Size(211, 40)
        Me.btnMasukanData.TabIndex = 26
        Me.btnMasukanData.Text = "Simpan"
        Me.btnMasukanData.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(469, 414)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(150, 36)
        Me.btnKembali.TabIndex = 27
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(650, 414)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(147, 36)
        Me.btnKeluar.TabIndex = 28
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, -1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(814, 48)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Data Siswa Baru"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DatasiswabaruDataSet
        '
        Me.DatasiswabaruDataSet.DataSetName = "datasiswabaruDataSet"
        Me.DatasiswabaruDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TdatasiswaBindingSource
        '
        Me.TdatasiswaBindingSource.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource.DataSource = Me.DatasiswabaruDataSet
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
        '
        'DatasiswabaruBindingSource
        '
        Me.DatasiswabaruBindingSource.DataSource = Me.Datasiswabaru
        Me.DatasiswabaruBindingSource.Position = 0
        '
        'Datasiswabaru
        '
        Me.Datasiswabaru.DataSetName = "datasiswabaru"
        Me.Datasiswabaru.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnbaru
        '
        Me.btnbaru.Location = New System.Drawing.Point(12, 362)
        Me.btnbaru.Name = "btnbaru"
        Me.btnbaru.Size = New System.Drawing.Size(211, 42)
        Me.btnbaru.TabIndex = 30
        Me.btnbaru.Text = "Baru"
        Me.btnbaru.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "No Induk Siswa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Tanggal Diterima"
        '
        'txtcarikelas
        '
        Me.txtcarikelas.Location = New System.Drawing.Point(106, 94)
        Me.txtcarikelas.Name = "txtcarikelas"
        Me.txtcarikelas.Size = New System.Drawing.Size(108, 22)
        Me.txtcarikelas.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Kelas"
        '
        'txtcaritanggal
        '
        Me.txtcaritanggal.Location = New System.Drawing.Point(106, 70)
        Me.txtcaritanggal.Name = "txtcaritanggal"
        Me.txtcaritanggal.Size = New System.Drawing.Size(108, 22)
        Me.txtcaritanggal.TabIndex = 32
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(106, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(108, 22)
        Me.TextBox1.TabIndex = 33
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "No Formulir"
        '
        'Form_Siswa_Baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 462)
        Me.Controls.Add(Me.btnbaru)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnMasukanData)
        Me.Controls.Add(Me.btnPerbaikan)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_Siswa_Baru"
        Me.Text = "Menu Siswa Baru"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_SiswaBaru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DatasiswabaruDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasiswabaruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datasiswabaru, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNoInduk As System.Windows.Forms.TextBox
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNamaSiswa As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents txtTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkelas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalDiterima As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView_SiswaBaru As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCarinoinduk As System.Windows.Forms.TextBox
    Friend WithEvents btnPerbaikan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnMasukanData As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Tampil As System.Windows.Forms.Button
    Friend WithEvents txtNo_pendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents DatasiswabaruDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSet
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswalulusDataSetTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents DatasiswabaruBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Datasiswabaru As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasiswabaru
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents btnbaru As System.Windows.Forms.Button
    Friend WithEvents txtagama As System.Windows.Forms.TextBox
    Friend WithEvents txtjeniskelamin As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcarikelas As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcaritanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
