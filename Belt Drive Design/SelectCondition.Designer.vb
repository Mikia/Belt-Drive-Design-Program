<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCondition
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
        Me.StableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinorChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LargeChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExquisiteChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrivenMachineLoadingConditionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vbelt1DataSet = New Belt_Drive_Design.Vbelt1DataSet()
        Me.Driven_Machine_Loading_ConditionTableAdapter = New Belt_Drive_Design.Vbelt1DataSetTableAdapters.Driven_Machine_Loading_ConditionTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrivenMachineLoadingConditionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vbelt1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StableDataGridViewTextBoxColumn, Me.MinorChangeDataGridViewTextBoxColumn, Me.LargeChangeDataGridViewTextBoxColumn, Me.ExquisiteChangeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DrivenMachineLoadingConditionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1030, 288)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'StableDataGridViewTextBoxColumn
        '
        Me.StableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StableDataGridViewTextBoxColumn.DataPropertyName = "Stable"
        Me.StableDataGridViewTextBoxColumn.HeaderText = "Stable"
        Me.StableDataGridViewTextBoxColumn.Name = "StableDataGridViewTextBoxColumn"
        Me.StableDataGridViewTextBoxColumn.Width = 77
        '
        'MinorChangeDataGridViewTextBoxColumn
        '
        Me.MinorChangeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.MinorChangeDataGridViewTextBoxColumn.DataPropertyName = "Minor Change"
        Me.MinorChangeDataGridViewTextBoxColumn.HeaderText = "Minor Change"
        Me.MinorChangeDataGridViewTextBoxColumn.Name = "MinorChangeDataGridViewTextBoxColumn"
        Me.MinorChangeDataGridViewTextBoxColumn.Width = 115
        '
        'LargeChangeDataGridViewTextBoxColumn
        '
        Me.LargeChangeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.LargeChangeDataGridViewTextBoxColumn.DataPropertyName = "Large Change"
        Me.LargeChangeDataGridViewTextBoxColumn.HeaderText = "Large Change"
        Me.LargeChangeDataGridViewTextBoxColumn.Name = "LargeChangeDataGridViewTextBoxColumn"
        Me.LargeChangeDataGridViewTextBoxColumn.Width = 117
        '
        'ExquisiteChangeDataGridViewTextBoxColumn
        '
        Me.ExquisiteChangeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ExquisiteChangeDataGridViewTextBoxColumn.DataPropertyName = "Exquisite Change"
        Me.ExquisiteChangeDataGridViewTextBoxColumn.HeaderText = "Exquisite Change"
        Me.ExquisiteChangeDataGridViewTextBoxColumn.Name = "ExquisiteChangeDataGridViewTextBoxColumn"
        Me.ExquisiteChangeDataGridViewTextBoxColumn.Width = 134
        '
        'DrivenMachineLoadingConditionBindingSource
        '
        Me.DrivenMachineLoadingConditionBindingSource.DataMember = "Driven Machine Loading Condition"
        Me.DrivenMachineLoadingConditionBindingSource.DataSource = Me.Vbelt1DataSet
        '
        'Vbelt1DataSet
        '
        Me.Vbelt1DataSet.DataSetName = "Vbelt1DataSet"
        Me.Vbelt1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Driven_Machine_Loading_ConditionTableAdapter
        '
        Me.Driven_Machine_Loading_ConditionTableAdapter.ClearBeforeFill = True
        '
        'SelectCondition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1030, 288)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SelectCondition"
        Me.Text = "SelectCondition"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrivenMachineLoadingConditionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vbelt1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Vbelt1DataSet As Vbelt1DataSet
    Friend WithEvents DrivenMachineLoadingConditionBindingSource As BindingSource
    Friend WithEvents Driven_Machine_Loading_ConditionTableAdapter As Vbelt1DataSetTableAdapters.Driven_Machine_Loading_ConditionTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinorChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LargeChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExquisiteChangeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
