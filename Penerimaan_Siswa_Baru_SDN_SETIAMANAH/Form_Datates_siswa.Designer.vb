<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Datates_siswa
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("DATA SISWA", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("DATA NILAI TES", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Datates_siswa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnopendaftaran = New System.Windows.Forms.TextBox()
        Me.btnTampil = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpTanggalTes = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtTesbaca = New System.Windows.Forms.TextBox()
        Me.txtTestulis = New System.Windows.Forms.TextBox()
        Me.txtTeshitung = New System.Windows.Forms.TextBox()
        Me.txtRatates = New System.Windows.Forms.TextBox()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatatesDataSet1 = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcarinama = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NoformulirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgltesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TesbacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeshitungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TdatatesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnMasukan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.no_formulir = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nama_siswa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tgl_tes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tes_baca = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tes_tulis = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tes_hitung = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ratates = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.keterangan = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TdatatesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatatesDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.TdatatesTableAdapter1 = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TdatatesTableAdapter()
        Me.TableAdapterManager1 = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TableAdapterManager()
        Me.TdatatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.Tdata_siswaTableAdapter()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TdatatesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtcarinoform = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatatesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatatesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TdatatesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatatesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnopendaftaran)
        Me.GroupBox1.Controls.Add(Me.btnTampil)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtpTanggalTes)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKeterangan)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.txtTesbaca)
        Me.GroupBox1.Controls.Add(Me.txtTestulis)
        Me.GroupBox1.Controls.Add(Me.txtTeshitung)
        Me.GroupBox1.Controls.Add(Me.txtRatates)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Tes"
        '
        'txtnopendaftaran
        '
        Me.txtnopendaftaran.Location = New System.Drawing.Point(155, 35)
        Me.txtnopendaftaran.Name = "txtnopendaftaran"
        Me.txtnopendaftaran.ReadOnly = True
        Me.txtnopendaftaran.Size = New System.Drawing.Size(100, 22)
        Me.txtnopendaftaran.TabIndex = 18
        '
        'btnTampil
        '
        Me.btnTampil.Location = New System.Drawing.Point(261, 35)
        Me.btnTampil.Name = "btnTampil"
        Me.btnTampil.Size = New System.Drawing.Size(75, 23)
        Me.btnTampil.TabIndex = 17
        Me.btnTampil.Text = "Tampil"
        Me.btnTampil.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Nama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "No Formulir Pendaftaran"
        '
        'dtpTanggalTes
        '
        Me.dtpTanggalTes.AllowDrop = True
        Me.dtpTanggalTes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTanggalTes.Location = New System.Drawing.Point(155, 88)
        Me.dtpTanggalTes.Name = "dtpTanggalTes"
        Me.dtpTanggalTes.Size = New System.Drawing.Size(121, 22)
        Me.dtpTanggalTes.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Keterangan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Nilai Rata - rata"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nilai Tes Hitung"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nilai Tes Tulis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nilai Tes Baca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tanggal Tes"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(155, 218)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ReadOnly = True
        Me.txtKeterangan.Size = New System.Drawing.Size(100, 22)
        Me.txtKeterangan.TabIndex = 8
        Me.txtKeterangan.WordWrap = False
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(155, 62)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.ReadOnly = True
        Me.txtNama.Size = New System.Drawing.Size(100, 22)
        Me.txtNama.TabIndex = 2
        Me.txtNama.WordWrap = False
        '
        'txtTesbaca
        '
        Me.txtTesbaca.Location = New System.Drawing.Point(155, 114)
        Me.txtTesbaca.Name = "txtTesbaca"
        Me.txtTesbaca.Size = New System.Drawing.Size(100, 22)
        Me.txtTesbaca.TabIndex = 4
        '
        'txtTestulis
        '
        Me.txtTestulis.Location = New System.Drawing.Point(155, 140)
        Me.txtTestulis.Name = "txtTestulis"
        Me.txtTestulis.Size = New System.Drawing.Size(100, 22)
        Me.txtTestulis.TabIndex = 5
        '
        'txtTeshitung
        '
        Me.txtTeshitung.Location = New System.Drawing.Point(155, 166)
        Me.txtTeshitung.Name = "txtTeshitung"
        Me.txtTeshitung.Size = New System.Drawing.Size(100, 22)
        Me.txtTeshitung.TabIndex = 6
        '
        'txtRatates
        '
        Me.txtRatates.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtRatates.Location = New System.Drawing.Point(155, 192)
        Me.txtRatates.Name = "txtRatates"
        Me.txtRatates.ReadOnly = True
        Me.txtRatates.Size = New System.Drawing.Size(100, 22)
        Me.txtRatates.TabIndex = 7
        Me.txtRatates.WordWrap = False
        '
        'TdatasiswaBindingSource
        '
        Me.TdatasiswaBindingSource.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource.DataSource = Me.DatatesDataSet1
        '
        'DatatesDataSet1
        '
        Me.DatatesDataSet1.DataSetName = "DatatesDataSet"
        Me.DatatesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(818, 337)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtcarinoform)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.txtcarinama)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btnMasukan)
        Me.TabPage1.Controls.Add(Me.btnUbah)
        Me.TabPage1.Controls.Add(Me.btnHapus)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(810, 311)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Tes Siswa"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 47)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(389, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Cari Data"
        '
        'txtcarinama
        '
        Me.txtcarinama.Location = New System.Drawing.Point(477, 218)
        Me.txtcarinama.Name = "txtcarinama"
        Me.txtcarinama.Size = New System.Drawing.Size(134, 22)
        Me.txtcarinama.TabIndex = 20
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(389, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 156)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Tes"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoformulirDataGridViewTextBoxColumn, Me.NamasiswaDataGridViewTextBoxColumn, Me.TgltesDataGridViewTextBoxColumn, Me.TesbacaDataGridViewTextBoxColumn, Me.TestulisDataGridViewTextBoxColumn, Me.TeshitungDataGridViewTextBoxColumn, Me.RatatesDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.TdatatesBindingSource3
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(409, 135)
        Me.DataGridView2.TabIndex = 0
        '
        'NoformulirDataGridViewTextBoxColumn
        '
        Me.NoformulirDataGridViewTextBoxColumn.DataPropertyName = "no_formulir"
        Me.NoformulirDataGridViewTextBoxColumn.HeaderText = "no_formulir"
        Me.NoformulirDataGridViewTextBoxColumn.Name = "NoformulirDataGridViewTextBoxColumn"
        Me.NoformulirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamasiswaDataGridViewTextBoxColumn
        '
        Me.NamasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.HeaderText = "nama_siswa"
        Me.NamasiswaDataGridViewTextBoxColumn.Name = "NamasiswaDataGridViewTextBoxColumn"
        Me.NamasiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TgltesDataGridViewTextBoxColumn
        '
        Me.TgltesDataGridViewTextBoxColumn.DataPropertyName = "tgl_tes"
        Me.TgltesDataGridViewTextBoxColumn.HeaderText = "tgl_tes"
        Me.TgltesDataGridViewTextBoxColumn.Name = "TgltesDataGridViewTextBoxColumn"
        Me.TgltesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TesbacaDataGridViewTextBoxColumn
        '
        Me.TesbacaDataGridViewTextBoxColumn.DataPropertyName = "tes_baca"
        Me.TesbacaDataGridViewTextBoxColumn.HeaderText = "tes_baca"
        Me.TesbacaDataGridViewTextBoxColumn.Name = "TesbacaDataGridViewTextBoxColumn"
        Me.TesbacaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TestulisDataGridViewTextBoxColumn
        '
        Me.TestulisDataGridViewTextBoxColumn.DataPropertyName = "tes_tulis"
        Me.TestulisDataGridViewTextBoxColumn.HeaderText = "tes_tulis"
        Me.TestulisDataGridViewTextBoxColumn.Name = "TestulisDataGridViewTextBoxColumn"
        Me.TestulisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeshitungDataGridViewTextBoxColumn
        '
        Me.TeshitungDataGridViewTextBoxColumn.DataPropertyName = "tes_hitung"
        Me.TeshitungDataGridViewTextBoxColumn.HeaderText = "tes_hitung"
        Me.TeshitungDataGridViewTextBoxColumn.Name = "TeshitungDataGridViewTextBoxColumn"
        Me.TeshitungDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RatatesDataGridViewTextBoxColumn
        '
        Me.RatatesDataGridViewTextBoxColumn.DataPropertyName = "ratates"
        Me.RatatesDataGridViewTextBoxColumn.HeaderText = "ratates"
        Me.RatatesDataGridViewTextBoxColumn.Name = "RatatesDataGridViewTextBoxColumn"
        Me.RatatesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        Me.KeteranganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TdatatesBindingSource3
        '
        Me.TdatatesBindingSource3.DataMember = "Tdatates"
        Me.TdatatesBindingSource3.DataSource = Me.DatatesDataSet1
        '
        'btnMasukan
        '
        Me.btnMasukan.Location = New System.Drawing.Point(617, 169)
        Me.btnMasukan.Name = "btnMasukan"
        Me.btnMasukan.Size = New System.Drawing.Size(184, 45)
        Me.btnMasukan.TabIndex = 3
        Me.btnMasukan.Text = "Masukan"
        Me.btnMasukan.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(713, 220)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(88, 73)
        Me.btnUbah.TabIndex = 2
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(617, 220)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(88, 73)
        Me.btnHapus.TabIndex = 1
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(810, 311)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Daftar Tes Siswa"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.no_formulir, Me.nama_siswa, Me.tgl_tes, Me.tes_baca, Me.tes_tulis, Me.tes_hitung, Me.ratates, Me.keterangan})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.GridLines = True
        ListViewGroup1.Header = "DATA SISWA"
        ListViewGroup1.Name = "DATA SISWA"
        ListViewGroup2.Header = "DATA NILAI TES"
        ListViewGroup2.Name = "DATA NILAI TES"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(3, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(804, 305)
        Me.ListView1.TabIndex = 0
        Me.ListView1.TabStop = False
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'no_formulir
        '
        Me.no_formulir.Text = "No Formulir"
        Me.no_formulir.Width = 91
        '
        'nama_siswa
        '
        Me.nama_siswa.Text = "Nama Siswa"
        Me.nama_siswa.Width = 94
        '
        'tgl_tes
        '
        Me.tgl_tes.Text = "Tanggal Tes"
        Me.tgl_tes.Width = 87
        '
        'tes_baca
        '
        Me.tes_baca.Text = "Nilai Tes Baca"
        Me.tes_baca.Width = 81
        '
        'tes_tulis
        '
        Me.tes_tulis.Text = "Nilai Tes Tulis"
        Me.tes_tulis.Width = 79
        '
        'tes_hitung
        '
        Me.tes_hitung.Text = "Nilai Tes Berhitung"
        Me.tes_hitung.Width = 103
        '
        'ratates
        '
        Me.ratates.Text = "Nilai Rata-Rata"
        Me.ratates.Width = 85
        '
        'keterangan
        '
        Me.keterangan.Text = "Keterangan"
        Me.keterangan.Width = 139
        '
        'TdatatesBindingSource1
        '
        Me.TdatatesBindingSource1.DataMember = "Tdatates"
        Me.TdatatesBindingSource1.DataSource = Me.DatatesDataSet
        '
        'DatatesDataSet
        '
        Me.DatatesDataSet.DataSetName = "DatatesDataSet"
        Me.DatatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(720, 387)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(106, 37)
        Me.btnkembali.TabIndex = 0
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(615, 387)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(95, 37)
        Me.btncetak.TabIndex = 1
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'TdatatesTableAdapter1
        '
        Me.TdatatesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Tdata_siswaTableAdapter = Nothing
        Me.TableAdapterManager1.TdatatesTableAdapter = Me.TdatatesTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TdatatesBindingSource
        '
        Me.TdatatesBindingSource.DataMember = "Tdatates"
        Me.TdatatesBindingSource.DataSource = Me.DatatesDataSet1
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(4, -7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(838, 45)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Data Tes Siswa"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TdatatesBindingSource2
        '
        Me.TdatatesBindingSource2.DataMember = "Tdatates"
        Me.TdatatesBindingSource2.DataSource = Me.DatatesDataSet1
        '
        'txtcarinoform
        '
        Me.txtcarinoform.Location = New System.Drawing.Point(477, 192)
        Me.txtcarinoform.Name = "txtcarinoform"
        Me.txtcarinoform.Size = New System.Drawing.Size(134, 22)
        Me.txtcarinoform.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(386, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "No Formuir"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(386, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nama Siswa"
        '
        'Form_Datates_siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 429)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_Datates_siswa"
        Me.Text = "Menu Data Tes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatatesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatatesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TdatatesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatatesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpTanggalTes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtTesbaca As System.Windows.Forms.TextBox
    Friend WithEvents txtTestulis As System.Windows.Forms.TextBox
    Friend WithEvents txtTeshitung As System.Windows.Forms.TextBox
    Friend WithEvents txtRatates As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnMasukan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnkembali As System.Windows.Forms.Button
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TdatatesTableAdapter1 As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TdatatesTableAdapter
    Friend WithEvents TableAdapterManager1 As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DatatesDataSet1 As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet
    Friend WithEvents TdatatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents no_formulir As System.Windows.Forms.ColumnHeader
    Friend WithEvents nama_siswa As System.Windows.Forms.ColumnHeader
    Friend WithEvents tgl_tes As System.Windows.Forms.ColumnHeader
    Friend WithEvents tes_baca As System.Windows.Forms.ColumnHeader
    Friend WithEvents tes_tulis As System.Windows.Forms.ColumnHeader
    Friend WithEvents tes_hitung As System.Windows.Forms.ColumnHeader
    Friend WithEvents ratates As System.Windows.Forms.ColumnHeader
    Friend WithEvents keterangan As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtcarinama As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnTampil As System.Windows.Forms.Button
    Friend WithEvents txtnopendaftaran As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DatatesDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet
    Friend WithEvents TdatatesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NoformulirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamasiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TgltesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TesbacaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestulisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeshitungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RatatesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdatatesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TdatatesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcarinoform As System.Windows.Forms.TextBox
End Class
