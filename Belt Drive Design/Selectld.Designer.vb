<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selectld
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LdmmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EklDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDKLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vbelt1DataSet1 = New Belt_Drive_Design.Vbelt1DataSet1()
        Me.LDKLTableAdapter = New Belt_Drive_Design.Vbelt1DataSet1TableAdapters.LDKLTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LDKLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vbelt1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.LdmmDataGridViewTextBoxColumn, Me.YklDataGridViewTextBoxColumn, Me.ZklDataGridViewTextBoxColumn, Me.AklDataGridViewTextBoxColumn, Me.BklDataGridViewTextBoxColumn, Me.CklDataGridViewTextBoxColumn, Me.DklDataGridViewTextBoxColumn, Me.EklDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.LDKLBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1082, 741)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LdmmDataGridViewTextBoxColumn
        '
        Me.LdmmDataGridViewTextBoxColumn.DataPropertyName = "Ld/mm"
        Me.LdmmDataGridViewTextBoxColumn.HeaderText = "Ld/mm"
        Me.LdmmDataGridViewTextBoxColumn.Name = "LdmmDataGridViewTextBoxColumn"
        Me.LdmmDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YklDataGridViewTextBoxColumn
        '
        Me.YklDataGridViewTextBoxColumn.DataPropertyName = "Y-kl"
        Me.YklDataGridViewTextBoxColumn.HeaderText = "Y-kl"
        Me.YklDataGridViewTextBoxColumn.Name = "YklDataGridViewTextBoxColumn"
        Me.YklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZklDataGridViewTextBoxColumn
        '
        Me.ZklDataGridViewTextBoxColumn.DataPropertyName = "Z-kl"
        Me.ZklDataGridViewTextBoxColumn.HeaderText = "Z-kl"
        Me.ZklDataGridViewTextBoxColumn.Name = "ZklDataGridViewTextBoxColumn"
        Me.ZklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AklDataGridViewTextBoxColumn
        '
        Me.AklDataGridViewTextBoxColumn.DataPropertyName = "A-kl"
        Me.AklDataGridViewTextBoxColumn.HeaderText = "A-kl"
        Me.AklDataGridViewTextBoxColumn.Name = "AklDataGridViewTextBoxColumn"
        Me.AklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BklDataGridViewTextBoxColumn
        '
        Me.BklDataGridViewTextBoxColumn.DataPropertyName = "B-kl"
        Me.BklDataGridViewTextBoxColumn.HeaderText = "B-kl"
        Me.BklDataGridViewTextBoxColumn.Name = "BklDataGridViewTextBoxColumn"
        Me.BklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CklDataGridViewTextBoxColumn
        '
        Me.CklDataGridViewTextBoxColumn.DataPropertyName = "C-kl"
        Me.CklDataGridViewTextBoxColumn.HeaderText = "C-kl"
        Me.CklDataGridViewTextBoxColumn.Name = "CklDataGridViewTextBoxColumn"
        Me.CklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DklDataGridViewTextBoxColumn
        '
        Me.DklDataGridViewTextBoxColumn.DataPropertyName = "D-kl"
        Me.DklDataGridViewTextBoxColumn.HeaderText = "D-kl"
        Me.DklDataGridViewTextBoxColumn.Name = "DklDataGridViewTextBoxColumn"
        Me.DklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EklDataGridViewTextBoxColumn
        '
        Me.EklDataGridViewTextBoxColumn.DataPropertyName = "E-kl"
        Me.EklDataGridViewTextBoxColumn.HeaderText = "E-kl"
        Me.EklDataGridViewTextBoxColumn.Name = "EklDataGridViewTextBoxColumn"
        Me.EklDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LDKLBindingSource
        '
        Me.LDKLBindingSource.DataMember = "LDKL"
        Me.LDKLBindingSource.DataSource = Me.Vbelt1DataSet1
        '
        'Vbelt1DataSet1
        '
        Me.Vbelt1DataSet1.DataSetName = "Vbelt1DataSet1"
        Me.Vbelt1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LDKLTableAdapter
        '
        Me.LDKLTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Selectld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 741)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Selectld"
        Me.Text = "Selectld"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LDKLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vbelt1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Vbelt1DataSet1 As Vbelt1DataSet1
    Friend WithEvents LDKLBindingSource As BindingSource
    Friend WithEvents LDKLTableAdapter As Vbelt1DataSet1TableAdapters.LDKLTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LdmmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EklDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
