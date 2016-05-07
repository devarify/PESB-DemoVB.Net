Imports Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Calon_Data_Siswa
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Calon_Data_Siswa))
        Me.btnInputData = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtbAlamatsiswa = New System.Windows.Forms.RichTextBox()
        Me.txtAgama = New System.Windows.Forms.ComboBox()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_PSB_SetiamanahDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSet()
        Me.dtpTanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.cbxJenisKelamin = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNoPendaftaran = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
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
        Me.rtbAlamatSekolah = New System.Windows.Forms.RichTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNamaAsalSekolah = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtPekerjaanAyah = New System.Windows.Forms.TextBox()
        Me.txtPekerjaanIbu = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNoTelp2 = New System.Windows.Forms.TextBox()
        Me.txtAlamatTinggal = New System.Windows.Forms.TextBox()
        Me.txtNamaIbu = New System.Windows.Forms.TextBox()
        Me.txtNamaAyah = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtcarinama = New System.Windows.Forms.TextBox()
        Me.txtcarinopend = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CariData = New System.Windows.Forms.Label()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.labeltanggal = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.labell_tanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.Tdata_siswaTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtcarialamat = New System.Windows.Forms.TextBox()
        Me.txtcariumur = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_PSB_SetiamanahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInputData
        '
        Me.btnInputData.Location = New System.Drawing.Point(12, 475)
        Me.btnInputData.Name = "btnInputData"
        Me.btnInputData.Size = New System.Drawing.Size(137, 39)
        Me.btnInputData.TabIndex = 19
        Me.btnInputData.Text = "Simpan"
        Me.btnInputData.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(713, 490)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(124, 41)
        Me.btnKembali.TabIndex = 25
        Me.btnKembali.Text = "Kembali Menu Utama"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(323, 475)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(162, 39)
        Me.btnHapus.TabIndex = 21
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtbAlamatsiswa)
        Me.GroupBox1.Controls.Add(Me.txtAgama)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalLahir)
        Me.GroupBox1.Controls.Add(Me.cbxJenisKelamin)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtNoPendaftaran)
        Me.GroupBox1.Controls.Add(Me.txtNoTelp)
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 274)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calon Siswa"
        '
        'rtbAlamatsiswa
        '
        Me.rtbAlamatsiswa.Location = New System.Drawing.Point(218, 222)
        Me.rtbAlamatsiswa.Name = "rtbAlamatsiswa"
        Me.rtbAlamatsiswa.Size = New System.Drawing.Size(200, 40)
        Me.rtbAlamatsiswa.TabIndex = 9
        Me.rtbAlamatsiswa.Text = ""
        '
        'txtAgama
        '
        Me.txtAgama.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TdatasiswaBindingSource, "agama", True))
        Me.txtAgama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAgama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtAgama.FormattingEnabled = True
        Me.txtAgama.Items.AddRange(New Object() {"Islam", "Kristen Khatolik", "Kristen Protestan", "Hindu", "Budha"})
        Me.txtAgama.Location = New System.Drawing.Point(218, 169)
        Me.txtAgama.Name = "txtAgama"
        Me.txtAgama.Size = New System.Drawing.Size(121, 21)
        Me.txtAgama.TabIndex = 7
        '
        'TdatasiswaBindingSource
        '
        Me.TdatasiswaBindingSource.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource.DataSource = Me.Db_PSB_SetiamanahDataSet
        '
        'Db_PSB_SetiamanahDataSet
        '
        Me.Db_PSB_SetiamanahDataSet.DataSetName = "db_PSB_SetiamanahDataSet"
        Me.Db_PSB_SetiamanahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpTanggalLahir
        '
        Me.dtpTanggalLahir.CustomFormat = ""
        Me.dtpTanggalLahir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalLahir.Location = New System.Drawing.Point(218, 86)
        Me.dtpTanggalLahir.Name = "dtpTanggalLahir"
        Me.dtpTanggalLahir.Size = New System.Drawing.Size(121, 25)
        Me.dtpTanggalLahir.TabIndex = 4
        '
        'cbxJenisKelamin
        '
        Me.cbxJenisKelamin.BackColor = System.Drawing.SystemColors.Window
        Me.cbxJenisKelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxJenisKelamin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxJenisKelamin.FormattingEnabled = True
        Me.cbxJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbxJenisKelamin.Location = New System.Drawing.Point(218, 142)
        Me.cbxJenisKelamin.Name = "cbxJenisKelamin"
        Me.cbxJenisKelamin.Size = New System.Drawing.Size(121, 21)
        Me.cbxJenisKelamin.Sorted = True
        Me.cbxJenisKelamin.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(218, 37)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 22)
        Me.txtNama.TabIndex = 2
        '
        'txtNoPendaftaran
        '
        Me.txtNoPendaftaran.Location = New System.Drawing.Point(218, 13)
        Me.txtNoPendaftaran.Name = "txtNoPendaftaran"
        Me.txtNoPendaftaran.Size = New System.Drawing.Size(200, 22)
        Me.txtNoPendaftaran.TabIndex = 1
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(218, 196)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(200, 22)
        Me.txtNoTelp.TabIndex = 8
        '
        'txtUmur
        '
        Me.txtUmur.HideSelection = False
        Me.txtUmur.Location = New System.Drawing.Point(218, 117)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.ReadOnly = True
        Me.txtUmur.Size = New System.Drawing.Size(42, 22)
        Me.txtUmur.TabIndex = 5
        Me.txtUmur.WordWrap = False
        '
        'txtTempatLahir
        '
        Me.txtTempatLahir.Location = New System.Drawing.Point(218, 61)
        Me.txtTempatLahir.Name = "txtTempatLahir"
        Me.txtTempatLahir.Size = New System.Drawing.Size(201, 22)
        Me.txtTempatLahir.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "No. Telp"
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
        Me.Label7.Location = New System.Drawing.Point(11, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Agama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Umur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
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
        Me.GroupBox2.Controls.Add(Me.rtbAlamatSekolah)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtNamaAsalSekolah)
        Me.GroupBox2.Location = New System.Drawing.Point(439, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 123)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sekolah Asal"
        '
        'rtbAlamatSekolah
        '
        Me.rtbAlamatSekolah.Location = New System.Drawing.Point(112, 57)
        Me.rtbAlamatSekolah.Name = "rtbAlamatSekolah"
        Me.rtbAlamatSekolah.Size = New System.Drawing.Size(382, 54)
        Me.rtbAlamatSekolah.TabIndex = 18
        Me.rtbAlamatSekolah.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Nama Asal Sekolah"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Alamat Asal Sekolah"
        '
        'txtNamaAsalSekolah
        '
        Me.txtNamaAsalSekolah.Location = New System.Drawing.Point(112, 19)
        Me.txtNamaAsalSekolah.Name = "txtNamaAsalSekolah"
        Me.txtNamaAsalSekolah.Size = New System.Drawing.Size(382, 22)
        Me.txtNamaAsalSekolah.TabIndex = 17
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(933, 295)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tampilan Calon Siswa"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.NullValue = "-"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.Size = New System.Drawing.Size(927, 274)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtPekerjaanAyah)
        Me.GroupBox4.Controls.Add(Me.txtPekerjaanIbu)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtNoTelp2)
        Me.GroupBox4.Controls.Add(Me.txtAlamatTinggal)
        Me.GroupBox4.Controls.Add(Me.txtNamaIbu)
        Me.GroupBox4.Controls.Add(Me.txtNamaAyah)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(439, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(500, 145)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Orang Tua"
        '
        'txtPekerjaanAyah
        '
        Me.txtPekerjaanAyah.Location = New System.Drawing.Point(361, 19)
        Me.txtPekerjaanAyah.Name = "txtPekerjaanAyah"
        Me.txtPekerjaanAyah.Size = New System.Drawing.Size(133, 22)
        Me.txtPekerjaanAyah.TabIndex = 12
        '
        'txtPekerjaanIbu
        '
        Me.txtPekerjaanIbu.Location = New System.Drawing.Point(361, 45)
        Me.txtPekerjaanIbu.Name = "txtPekerjaanIbu"
        Me.txtPekerjaanIbu.Size = New System.Drawing.Size(133, 22)
        Me.txtPekerjaanIbu.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(273, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 13)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Pekerjaan Ibu"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(273, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Pekerjaan Ayah"
        '
        'txtNoTelp2
        '
        Me.txtNoTelp2.Location = New System.Drawing.Point(99, 103)
        Me.txtNoTelp2.Name = "txtNoTelp2"
        Me.txtNoTelp2.Size = New System.Drawing.Size(395, 22)
        Me.txtNoTelp2.TabIndex = 16
        '
        'txtAlamatTinggal
        '
        Me.txtAlamatTinggal.Location = New System.Drawing.Point(99, 73)
        Me.txtAlamatTinggal.Name = "txtAlamatTinggal"
        Me.txtAlamatTinggal.Size = New System.Drawing.Size(395, 22)
        Me.txtAlamatTinggal.TabIndex = 15
        '
        'txtNamaIbu
        '
        Me.txtNamaIbu.Location = New System.Drawing.Point(99, 45)
        Me.txtNamaIbu.Name = "txtNamaIbu"
        Me.txtNamaIbu.Size = New System.Drawing.Size(136, 22)
        Me.txtNamaIbu.TabIndex = 13
        '
        'txtNamaAyah
        '
        Me.txtNamaAyah.Location = New System.Drawing.Point(99, 19)
        Me.txtNamaAyah.Name = "txtNamaAyah"
        Me.txtNamaAyah.Size = New System.Drawing.Size(136, 22)
        Me.txtNamaAyah.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "No Telp"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Alamat Tinggal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Nama Ibu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Nama Ayah"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtcariumur)
        Me.GroupBox5.Controls.Add(Me.txtcarialamat)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.txtcarinama)
        Me.GroupBox5.Controls.Add(Me.txtcarinopend)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.CariData)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 304)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(927, 81)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tools"
        '
        'txtcarinama
        '
        Me.txtcarinama.Location = New System.Drawing.Point(81, 54)
        Me.txtcarinama.Name = "txtcarinama"
        Me.txtcarinama.Size = New System.Drawing.Size(100, 22)
        Me.txtcarinama.TabIndex = 30
        '
        'txtcarinopend
        '
        Me.txtcarinopend.Location = New System.Drawing.Point(81, 26)
        Me.txtcarinopend.Name = "txtcarinopend"
        Me.txtcarinopend.Size = New System.Drawing.Size(100, 22)
        Me.txtcarinopend.TabIndex = 29
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 50)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Cari"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CariData
        '
        Me.CariData.AutoSize = True
        Me.CariData.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariData.Location = New System.Drawing.Point(5, 11)
        Me.CariData.Name = "CariData"
        Me.CariData.Size = New System.Drawing.Size(65, 17)
        Me.CariData.TabIndex = 27
        Me.CariData.Text = "Cari Data"
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(155, 475)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(162, 39)
        Me.btnUbah.TabIndex = 20
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(2, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(944, 91)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Baru"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(843, 490)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(124, 41)
        Me.btnKeluar.TabIndex = 26
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'labeltanggal
        '
        Me.labeltanggal.AutoSize = True
        Me.labeltanggal.Location = New System.Drawing.Point(23, 7)
        Me.labeltanggal.Name = "labeltanggal"
        Me.labeltanggal.Size = New System.Drawing.Size(0, 13)
        Me.labeltanggal.TabIndex = 11
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labell_tanggal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 534)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(977, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'labell_tanggal
        '
        Me.labell_tanggal.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labell_tanggal.Name = "labell_tanggal"
        Me.labell_tanggal.Size = New System.Drawing.Size(0, 17)
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 58)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(955, 411)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(947, 385)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Form Pendaftaran"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(947, 385)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tampilan Data Pendaftaran"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(958, 48)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Data Calon Siswa"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 29)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "No Formulir"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(7, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "Nama Siswa"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(212, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 13)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "Alamat"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(211, 57)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Umur"
        '
        'txtcarialamat
        '
        Me.txtcarialamat.Location = New System.Drawing.Point(260, 26)
        Me.txtcarialamat.Name = "txtcarialamat"
        Me.txtcarialamat.Size = New System.Drawing.Size(100, 22)
        Me.txtcarialamat.TabIndex = 35
        '
        'txtcariumur
        '
        Me.txtcariumur.Location = New System.Drawing.Point(260, 54)
        Me.txtcariumur.Name = "txtcariumur"
        Me.txtcariumur.Size = New System.Drawing.Size(100, 22)
        Me.txtcariumur.TabIndex = 36
        '
        'Form_Calon_Data_Siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 556)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.labeltanggal)
        Me.Controls.Add(Me.btnInputData)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnUbah)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_Calon_Data_Siswa"
        Me.Text = " Menu Data Siswa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_PSB_SetiamanahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInputData As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelp As System.Windows.Forms.TextBox
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpTanggalLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNamaAsalSekolah As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtNoTelp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatTinggal As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaIbu As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaAyah As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents rtbAlamatSekolah As System.Windows.Forms.RichTextBox
    Friend WithEvents txtPekerjaanAyah As System.Windows.Forms.TextBox
    Friend WithEvents txtPekerjaanIbu As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Db_PSB_SetiamanahDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSet
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As DatatesDataSetTableAdapters.Tdata_siswaTableAdapter
    Private WithEvents cbxJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents txtAgama As System.Windows.Forms.ComboBox
    Friend WithEvents labeltanggal As System.Windows.Forms.Label
    Friend WithEvents rtbAlamatsiswa As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents labell_tanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CariData As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtcarinama As System.Windows.Forms.TextBox
    Friend WithEvents txtcarinopend As System.Windows.Forms.TextBox
    Friend WithEvents txtcariumur As System.Windows.Forms.TextBox
    Friend WithEvents txtcarialamat As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
