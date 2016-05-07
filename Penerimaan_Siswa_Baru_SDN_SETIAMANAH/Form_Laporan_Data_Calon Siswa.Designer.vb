<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan_Data_Calon_Siswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Laporan_Data_Calon_Siswa))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Db_PSB_SetiamanahDataSettes = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettes()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettesTableAdapters.Tdata_siswaTableAdapter()
        Me.NoformulirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TempatlahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggallahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JeniskelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotelpsiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatsiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaayahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaibuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PekerjaanayahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PekerjaanibuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotelportuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatortuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AsalsekolahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatsalsekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_PSB_SetiamanahDataSettes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(29, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tampilan Data Calon Siswa"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoformulirDataGridViewTextBoxColumn, Me.NamasiswaDataGridViewTextBoxColumn, Me.TempatlahirDataGridViewTextBoxColumn, Me.TanggallahirDataGridViewTextBoxColumn, Me.UmurDataGridViewTextBoxColumn, Me.JeniskelaminDataGridViewTextBoxColumn, Me.AgamaDataGridViewTextBoxColumn, Me.NotelpsiswaDataGridViewTextBoxColumn, Me.AlamatsiswaDataGridViewTextBoxColumn, Me.NamaayahDataGridViewTextBoxColumn, Me.NamaibuDataGridViewTextBoxColumn, Me.PekerjaanayahDataGridViewTextBoxColumn, Me.PekerjaanibuDataGridViewTextBoxColumn, Me.NotelportuDataGridViewTextBoxColumn, Me.AlamatortuDataGridViewTextBoxColumn, Me.AsalsekolahDataGridViewTextBoxColumn, Me.AlamatsalsekDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TdatasiswaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(35, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(494, 217)
        Me.DataGridView1.TabIndex = 0
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(37, 304)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(126, 47)
        Me.btnCetak.TabIndex = 2
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(411, 304)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(126, 47)
        Me.btnKembali.TabIndex = 3
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(502, 48)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Siswa Pendaftar"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Db_PSB_SetiamanahDataSettes
        '
        Me.Db_PSB_SetiamanahDataSettes.DataSetName = "db_PSB_SetiamanahDataSettes"
        Me.Db_PSB_SetiamanahDataSettes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TdatasiswaBindingSource
        '
        Me.TdatasiswaBindingSource.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource.DataSource = Me.Db_PSB_SetiamanahDataSettes
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
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
        'TempatlahirDataGridViewTextBoxColumn
        '
        Me.TempatlahirDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.HeaderText = "tempat_lahir"
        Me.TempatlahirDataGridViewTextBoxColumn.Name = "TempatlahirDataGridViewTextBoxColumn"
        Me.TempatlahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TanggallahirDataGridViewTextBoxColumn
        '
        Me.TanggallahirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.HeaderText = "tanggal_lahir"
        Me.TanggallahirDataGridViewTextBoxColumn.Name = "TanggallahirDataGridViewTextBoxColumn"
        Me.TanggallahirDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UmurDataGridViewTextBoxColumn
        '
        Me.UmurDataGridViewTextBoxColumn.DataPropertyName = "umur"
        Me.UmurDataGridViewTextBoxColumn.HeaderText = "umur"
        Me.UmurDataGridViewTextBoxColumn.Name = "UmurDataGridViewTextBoxColumn"
        Me.UmurDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JeniskelaminDataGridViewTextBoxColumn
        '
        Me.JeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin"
        Me.JeniskelaminDataGridViewTextBoxColumn.Name = "JeniskelaminDataGridViewTextBoxColumn"
        Me.JeniskelaminDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgamaDataGridViewTextBoxColumn
        '
        Me.AgamaDataGridViewTextBoxColumn.DataPropertyName = "agama"
        Me.AgamaDataGridViewTextBoxColumn.HeaderText = "agama"
        Me.AgamaDataGridViewTextBoxColumn.Name = "AgamaDataGridViewTextBoxColumn"
        Me.AgamaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotelpsiswaDataGridViewTextBoxColumn
        '
        Me.NotelpsiswaDataGridViewTextBoxColumn.DataPropertyName = "notelp_siswa"
        Me.NotelpsiswaDataGridViewTextBoxColumn.HeaderText = "notelp_siswa"
        Me.NotelpsiswaDataGridViewTextBoxColumn.Name = "NotelpsiswaDataGridViewTextBoxColumn"
        Me.NotelpsiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatsiswaDataGridViewTextBoxColumn
        '
        Me.AlamatsiswaDataGridViewTextBoxColumn.DataPropertyName = "alamat_siswa"
        Me.AlamatsiswaDataGridViewTextBoxColumn.HeaderText = "alamat_siswa"
        Me.AlamatsiswaDataGridViewTextBoxColumn.Name = "AlamatsiswaDataGridViewTextBoxColumn"
        Me.AlamatsiswaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaayahDataGridViewTextBoxColumn
        '
        Me.NamaayahDataGridViewTextBoxColumn.DataPropertyName = "nama_ayah"
        Me.NamaayahDataGridViewTextBoxColumn.HeaderText = "nama_ayah"
        Me.NamaayahDataGridViewTextBoxColumn.Name = "NamaayahDataGridViewTextBoxColumn"
        Me.NamaayahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamaibuDataGridViewTextBoxColumn
        '
        Me.NamaibuDataGridViewTextBoxColumn.DataPropertyName = "nama_ibu"
        Me.NamaibuDataGridViewTextBoxColumn.HeaderText = "nama_ibu"
        Me.NamaibuDataGridViewTextBoxColumn.Name = "NamaibuDataGridViewTextBoxColumn"
        Me.NamaibuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PekerjaanayahDataGridViewTextBoxColumn
        '
        Me.PekerjaanayahDataGridViewTextBoxColumn.DataPropertyName = "pekerjaan_ayah"
        Me.PekerjaanayahDataGridViewTextBoxColumn.HeaderText = "pekerjaan_ayah"
        Me.PekerjaanayahDataGridViewTextBoxColumn.Name = "PekerjaanayahDataGridViewTextBoxColumn"
        Me.PekerjaanayahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PekerjaanibuDataGridViewTextBoxColumn
        '
        Me.PekerjaanibuDataGridViewTextBoxColumn.DataPropertyName = "pekerjaan_ibu"
        Me.PekerjaanibuDataGridViewTextBoxColumn.HeaderText = "pekerjaan_ibu"
        Me.PekerjaanibuDataGridViewTextBoxColumn.Name = "PekerjaanibuDataGridViewTextBoxColumn"
        Me.PekerjaanibuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NotelportuDataGridViewTextBoxColumn
        '
        Me.NotelportuDataGridViewTextBoxColumn.DataPropertyName = "notelp_ortu"
        Me.NotelportuDataGridViewTextBoxColumn.HeaderText = "notelp_ortu"
        Me.NotelportuDataGridViewTextBoxColumn.Name = "NotelportuDataGridViewTextBoxColumn"
        Me.NotelportuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatortuDataGridViewTextBoxColumn
        '
        Me.AlamatortuDataGridViewTextBoxColumn.DataPropertyName = "alamat_ortu"
        Me.AlamatortuDataGridViewTextBoxColumn.HeaderText = "alamat_ortu"
        Me.AlamatortuDataGridViewTextBoxColumn.Name = "AlamatortuDataGridViewTextBoxColumn"
        Me.AlamatortuDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AsalsekolahDataGridViewTextBoxColumn
        '
        Me.AsalsekolahDataGridViewTextBoxColumn.DataPropertyName = "asal_sekolah"
        Me.AsalsekolahDataGridViewTextBoxColumn.HeaderText = "asal_sekolah"
        Me.AsalsekolahDataGridViewTextBoxColumn.Name = "AsalsekolahDataGridViewTextBoxColumn"
        Me.AsalsekolahDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlamatsalsekDataGridViewTextBoxColumn
        '
        Me.AlamatsalsekDataGridViewTextBoxColumn.DataPropertyName = "alamat_salsek"
        Me.AlamatsalsekDataGridViewTextBoxColumn.HeaderText = "alamat_salsek"
        Me.AlamatsalsekDataGridViewTextBoxColumn.Name = "AlamatsalsekDataGridViewTextBoxColumn"
        Me.AlamatsalsekDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Form_Laporan_Data_Calon_Siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(559, 363)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Laporan_Data_Calon_Siswa"
        Me.Text = "Form_Laporan_Data_Calon_Siswa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_PSB_SetiamanahDataSettes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Db_PSB_SetiamanahDataSettes As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettes
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettesTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents NoformulirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamasiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempatlahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggallahirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JeniskelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotelpsiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatsiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaayahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaibuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PekerjaanayahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PekerjaanibuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NotelportuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatortuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AsalsekolahDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatsalsekDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
