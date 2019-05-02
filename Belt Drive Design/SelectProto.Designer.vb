<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectProto
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
        Me.Vbelt1DataSet = New Belt_Drive_Design.Vbelt1DataSet()
        Me.PrototypeSelectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Prototype_SelectionTableAdapter = New Belt_Drive_Design.Vbelt1DataSetTableAdapters.Prototype_SelectionTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrototypeIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrototypeIIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vbelt1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrototypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PrototypeIDataGridViewTextBoxColumn, Me.PrototypeIIDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PrototypeSelectionBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(692, 283)
        Me.DataGridView1.TabIndex = 0
        '
        'Vbelt1DataSet
        '
        Me.Vbelt1DataSet.DataSetName = "Vbelt1DataSet"
        Me.Vbelt1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrototypeSelectionBindingSource
        '
        Me.PrototypeSelectionBindingSource.DataMember = "Prototype Selection"
        Me.PrototypeSelectionBindingSource.DataSource = Me.Vbelt1DataSet
        '
        'Prototype_SelectionTableAdapter
        '
        Me.Prototype_SelectionTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 50
        '
        'PrototypeIDataGridViewTextBoxColumn
        '
        Me.PrototypeIDataGridViewTextBoxColumn.DataPropertyName = "Prototype I"
        Me.PrototypeIDataGridViewTextBoxColumn.HeaderText = "Prototype I"
        Me.PrototypeIDataGridViewTextBoxColumn.Name = "PrototypeIDataGridViewTextBoxColumn"
        Me.PrototypeIDataGridViewTextBoxColumn.Width = 105
        '
        'PrototypeIIDataGridViewTextBoxColumn
        '
        Me.PrototypeIIDataGridViewTextBoxColumn.DataPropertyName = "Prototype II"
        Me.PrototypeIIDataGridViewTextBoxColumn.HeaderText = "Prototype II"
        Me.PrototypeIIDataGridViewTextBoxColumn.Name = "PrototypeIIDataGridViewTextBoxColumn"
        Me.PrototypeIIDataGridViewTextBoxColumn.Width = 108
        '
        'SelectProto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(692, 283)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(710, 330)
        Me.Name = "SelectProto"
        Me.Text = "SelectProto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vbelt1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrototypeSelectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Vbelt1DataSet As Vbelt1DataSet
    Friend WithEvents PrototypeSelectionBindingSource As BindingSource
    Friend WithEvents Prototype_SelectionTableAdapter As Vbelt1DataSetTableAdapters.Prototype_SelectionTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrototypeIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrototypeIIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
