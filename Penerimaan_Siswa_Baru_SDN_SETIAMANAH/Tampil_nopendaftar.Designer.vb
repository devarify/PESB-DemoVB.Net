<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tampil_nopendaftar
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_PSB_SetiamanahDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSet()
        Me.FKTdatatesTdatasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasekolahDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasekolahDataSet()
        Me.TsekolahBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TsekolahTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasekolahDataSetTableAdapters.TsekolahTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tdata_siswaTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSetTableAdapters.Tdata_siswaTableAdapter()
        Me.TdatatesTableAdapter = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSetTableAdapters.TdatatesTableAdapter()
        Me.TableAdapterManager1 = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettesTableAdapters.TableAdapterManager()
        Me.FKTdatatesTdatasiswaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKTdatatesTdatasiswaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKTdatatesTdatasiswaBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatatesDataSet = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet()
        Me.TdatasiswaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tdata_siswaTableAdapter1 = New Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.Tdata_siswaTableAdapter()
        Me.TdatasiswaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.no_formulir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_siswa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_PSB_SetiamanahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasekolahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TsekolahBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TdatasiswaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no_formulir, Me.nama_siswa})
        Me.DataGridView1.DataSource = Me.TdatasiswaBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(11, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
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
        'FKTdatatesTdatasiswaBindingSource
        '
        Me.FKTdatatesTdatasiswaBindingSource.DataMember = "FK_Tdatates_Tdata_siswa"
        Me.FKTdatatesTdatasiswaBindingSource.DataSource = Me.TdatasiswaBindingSource
        '
        'DatasekolahDataSet
        '
        Me.DatasekolahDataSet.DataSetName = "datasekolahDataSet"
        Me.DatasekolahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TsekolahBindingSource
        '
        Me.TsekolahBindingSource.DataMember = "Tsekolah"
        Me.TsekolahBindingSource.DataSource = Me.DatasekolahDataSet
        '
        'TsekolahTableAdapter
        '
        Me.TsekolahTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cari"
        '
        'Tdata_siswaTableAdapter
        '
        Me.Tdata_siswaTableAdapter.ClearBeforeFill = True
        '
        'TdatatesTableAdapter
        '
        Me.TdatatesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.Tdata_siswaTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FKTdatatesTdatasiswaBindingSource1
        '
        Me.FKTdatatesTdatasiswaBindingSource1.DataMember = "FK_Tdatates_Tdata_siswa"
        Me.FKTdatatesTdatasiswaBindingSource1.DataSource = Me.TdatasiswaBindingSource
        '
        'FKTdatatesTdatasiswaBindingSource2
        '
        Me.FKTdatatesTdatasiswaBindingSource2.DataMember = "FK_Tdatates_Tdata_siswa"
        Me.FKTdatatesTdatasiswaBindingSource2.DataSource = Me.TdatasiswaBindingSource
        '
        'FKTdatatesTdatasiswaBindingSource3
        '
        Me.FKTdatatesTdatasiswaBindingSource3.DataMember = "FK_Tdatates_Tdata_siswa"
        Me.FKTdatatesTdatasiswaBindingSource3.DataSource = Me.TdatasiswaBindingSource
        '
        'DatatesDataSet
        '
        Me.DatatesDataSet.DataSetName = "DatatesDataSet"
        Me.DatatesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TdatasiswaBindingSource1
        '
        Me.TdatasiswaBindingSource1.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource1.DataSource = Me.DatatesDataSet
        '
        'Tdata_siswaTableAdapter1
        '
        Me.Tdata_siswaTableAdapter1.ClearBeforeFill = True
        '
        'TdatasiswaBindingSource2
        '
        Me.TdatasiswaBindingSource2.DataMember = "Tdata_siswa"
        Me.TdatasiswaBindingSource2.DataSource = Me.Db_PSB_SetiamanahDataSet
        '
        'no_formulir
        '
        Me.no_formulir.DataPropertyName = "no_formulir"
        Me.no_formulir.HeaderText = "no_formulir"
        Me.no_formulir.Name = "no_formulir"
        Me.no_formulir.ReadOnly = True
        '
        'nama_siswa
        '
        Me.nama_siswa.DataPropertyName = "nama_siswa"
        Me.nama_siswa.HeaderText = "nama_siswa"
        Me.nama_siswa.Name = "nama_siswa"
        Me.nama_siswa.ReadOnly = True
        '
        'Tampil_nopendaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 193)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Tampil_nopendaftar"
        Me.Text = "Tampil_nopendaftar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_PSB_SetiamanahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasekolahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TsekolahBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTdatatesTdatasiswaBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatatesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TdatasiswaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatasekolahDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasekolahDataSet
    Friend WithEvents TsekolahBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TsekolahTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.datasekolahDataSetTableAdapters.TsekolahTableAdapter
    Friend WithEvents Db_PSB_SetiamanahDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSet
    Friend WithEvents TdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSetTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FKTdatatesTdatasiswaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TdatatesTableAdapter As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSetTableAdapters.TdatatesTableAdapter
    Friend WithEvents TableAdapterManager1 As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.db_PSB_SetiamanahDataSettesTableAdapters.TableAdapterManager
    Friend WithEvents FKTdatatesTdatasiswaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FKTdatatesTdatasiswaBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents FKTdatatesTdatasiswaBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents DatatesDataSet As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSet
    Friend WithEvents TdatasiswaBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Tdata_siswaTableAdapter1 As Penerimaan_Siswa_Baru_SDN_SETIAMANAH.DatatesDataSetTableAdapters.Tdata_siswaTableAdapter
    Friend WithEvents no_formulir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nama_siswa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TdatasiswaBindingSource2 As System.Windows.Forms.BindingSource
End Class
