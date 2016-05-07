<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan_Data_Tes_Siswa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Laporan_Data_Tes_Siswa))
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DatatesDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet()
        Me.TdatatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TdatatesTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TdatatesTableAdapter()
        Me.IdtesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoformulirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamasiswaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TgltesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TesbacaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestulisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeshitungDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(403, 308)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(126, 47)
        Me.btnKembali.TabIndex = 7
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(21, 308)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(126, 47)
        Me.btnCetak.TabIndex = 6
        Me.btnCetak.Text = "Cetak"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 242)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tampilan Data Tes Siswa"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdtesDataGridViewTextBoxColumn, Me.NoformulirDataGridViewTextBoxColumn, Me.NamasiswaDataGridViewTextBoxColumn, Me.TgltesDataGridViewTextBoxColumn, Me.TesbacaDataGridViewTextBoxColumn, Me.TestulisDataGridViewTextBoxColumn, Me.TeshitungDataGridViewTextBoxColumn, Me.RatatesDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TdatatesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(497, 220)
        Me.DataGridView1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(513, 48)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Hasil Tes"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DatatesDataSet
        '
        Me.DatatesDataSet.DataSetName = "DatatesDataSet"
        Me.DatatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TdatatesBindingSource
        '
        Me.TdatatesBindingSource.DataMember = "Tdatates"
        Me.TdatatesBindingSource.DataSource = Me.DatatesDataSet
        '
        'TdatatesTableAdapter
        '
        Me.TdatatesTableAdapter.ClearBeforeFill = True
        '
        'IdtesDataGridViewTextBoxColumn
        '
        Me.IdtesDataGridViewTextBoxColumn.DataPropertyName = "idtes"
        Me.IdtesDataGridViewTextBoxColumn.HeaderText = "idtes"
        Me.IdtesDataGridViewTextBoxColumn.Name = "IdtesDataGridViewTextBoxColumn"
        Me.IdtesDataGridViewTextBoxColumn.ReadOnly = True
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
        'Form_Laporan_Data_Tes_Siswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(562, 374)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "Form_Laporan_Data_Tes_Siswa"
        Me.Text = "Form_Laporan_Data_Tes_Siswa"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DatatesDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet
    Friend WithEvents TdatatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TdatatesTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.TdatatesTableAdapter
    Friend WithEvents IdtesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoformulirDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamasiswaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TgltesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TesbacaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TestulisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeshitungDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RatatesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
