﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sta15_Form
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
        Me.ToolingNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Station15ToolingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NCLRecipeDataSet = New MfgControl.AdvancedHMI.NCLRecipeDataSet()
        Me.ToolingName_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_Button = New System.Windows.Forms.Button()
        Me.Insert_Button = New System.Windows.Forms.Button()
        Me.Update_Button = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Station_15_ToolingTableAdapter = New MfgControl.AdvancedHMI.NCLRecipeDataSetTableAdapters.Station_15_ToolingTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Station15ToolingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ToolingNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Station15ToolingBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 35)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(359, 143)
        Me.DataGridView1.TabIndex = 344
        '
        'ToolingNameDataGridViewTextBoxColumn
        '
        Me.ToolingNameDataGridViewTextBoxColumn.DataPropertyName = "Tooling Name"
        Me.ToolingNameDataGridViewTextBoxColumn.HeaderText = "Tooling Name"
        Me.ToolingNameDataGridViewTextBoxColumn.Name = "ToolingNameDataGridViewTextBoxColumn"
        Me.ToolingNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ToolingNameDataGridViewTextBoxColumn.Width = 98
        '
        'Station15ToolingBindingSource
        '
        Me.Station15ToolingBindingSource.DataMember = "Station 15 Tooling"
        Me.Station15ToolingBindingSource.DataSource = Me.NCLRecipeDataSet
        '
        'NCLRecipeDataSet
        '
        Me.NCLRecipeDataSet.DataSetName = "NCLRecipeDataSet"
        Me.NCLRecipeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolingName_ComboBox
        '
        Me.ToolingName_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Station15ToolingBindingSource, "Tooling Name", True))
        Me.ToolingName_ComboBox.FormattingEnabled = True
        Me.ToolingName_ComboBox.Location = New System.Drawing.Point(135, 208)
        Me.ToolingName_ComboBox.Name = "ToolingName_ComboBox"
        Me.ToolingName_ComboBox.Size = New System.Drawing.Size(230, 21)
        Me.ToolingName_ComboBox.TabIndex = 343
        '
        'Delete_Button
        '
        Me.Delete_Button.Location = New System.Drawing.Point(178, 327)
        Me.Delete_Button.Name = "Delete_Button"
        Me.Delete_Button.Size = New System.Drawing.Size(75, 23)
        Me.Delete_Button.TabIndex = 342
        Me.Delete_Button.Text = "Delete"
        Me.Delete_Button.UseVisualStyleBackColor = True
        Me.Delete_Button.Visible = False
        '
        'Insert_Button
        '
        Me.Insert_Button.Location = New System.Drawing.Point(97, 327)
        Me.Insert_Button.Name = "Insert_Button"
        Me.Insert_Button.Size = New System.Drawing.Size(75, 23)
        Me.Insert_Button.TabIndex = 341
        Me.Insert_Button.Text = "Insert"
        Me.Insert_Button.UseVisualStyleBackColor = True
        Me.Insert_Button.Visible = False
        '
        'Update_Button
        '
        Me.Update_Button.Location = New System.Drawing.Point(16, 326)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(75, 23)
        Me.Update_Button.TabIndex = 340
        Me.Update_Button.Text = "Update"
        Me.Update_Button.UseVisualStyleBackColor = True
        Me.Update_Button.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(13, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 13)
        Me.Label9.TabIndex = 337
        Me.Label9.Tag = ""
        Me.Label9.Text = "Tooling Name"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Station_15_ToolingTableAdapter
        '
        Me.Station_15_ToolingTableAdapter.ClearBeforeFill = True
        '
        'Sta15_Form
        '
        Me.AccessibleDescription = "Station 15"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 364)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolingName_ComboBox)
        Me.Controls.Add(Me.Delete_Button)
        Me.Controls.Add(Me.Insert_Button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Label9)
        Me.Name = "Sta15_Form"
        Me.Tag = "Station"
        Me.Text = "Station 15"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Station15ToolingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NCLRecipeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolingName_ComboBox As ComboBox
    Friend WithEvents Delete_Button As Button
    Friend WithEvents Insert_Button As Button
    Friend WithEvents Update_Button As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents NCLRecipeDataSet As NCLRecipeDataSet
    Friend WithEvents Station15ToolingBindingSource As BindingSource
    Friend WithEvents Station_15_ToolingTableAdapter As NCLRecipeDataSetTableAdapters.Station_15_ToolingTableAdapter
    Friend WithEvents ToolingNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
