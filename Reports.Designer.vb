<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Elipse_Reports = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.GD_BillRecords = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.LblBillRecords = New System.Windows.Forms.Label()
        Me.DB_BillRecords = New Hotel_Billing_System.DB_BillRecords()
        Me.TBBillRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_Bill_RecordsTableAdapter = New Hotel_Billing_System.DB_BillRecordsTableAdapters.TB_Bill_RecordsTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GD_BillRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_BillRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBBillRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Elipse_Reports
        '
        Me.Elipse_Reports.TargetControl = Me
        '
        'GD_BillRecords
        '
        Me.GD_BillRecords.AllowUserToDeleteRows = False
        Me.GD_BillRecords.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GD_BillRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GD_BillRecords.AutoGenerateColumns = False
        Me.GD_BillRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GD_BillRecords.BackgroundColor = System.Drawing.Color.White
        Me.GD_BillRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GD_BillRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GD_BillRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GD_BillRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GD_BillRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GD_BillRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TimeDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.TableNoDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.PaymentTypeDataGridViewTextBoxColumn})
        Me.GD_BillRecords.DataSource = Me.TBBillRecordsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GD_BillRecords.DefaultCellStyle = DataGridViewCellStyle3
        Me.GD_BillRecords.EnableHeadersVisualStyles = False
        Me.GD_BillRecords.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GD_BillRecords.Location = New System.Drawing.Point(29, 63)
        Me.GD_BillRecords.Name = "GD_BillRecords"
        Me.GD_BillRecords.ReadOnly = True
        Me.GD_BillRecords.RowHeadersVisible = False
        Me.GD_BillRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GD_BillRecords.Size = New System.Drawing.Size(692, 396)
        Me.GD_BillRecords.TabIndex = 0
        Me.GD_BillRecords.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.GD_BillRecords.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GD_BillRecords.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GD_BillRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GD_BillRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GD_BillRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GD_BillRecords.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GD_BillRecords.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GD_BillRecords.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GD_BillRecords.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GD_BillRecords.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GD_BillRecords.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GD_BillRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GD_BillRecords.ThemeStyle.HeaderStyle.Height = 40
        Me.GD_BillRecords.ThemeStyle.ReadOnly = True
        Me.GD_BillRecords.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GD_BillRecords.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GD_BillRecords.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GD_BillRecords.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GD_BillRecords.ThemeStyle.RowsStyle.Height = 22
        Me.GD_BillRecords.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GD_BillRecords.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'LblBillRecords
        '
        Me.LblBillRecords.AutoSize = True
        Me.LblBillRecords.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBillRecords.Location = New System.Drawing.Point(26, 20)
        Me.LblBillRecords.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblBillRecords.Name = "LblBillRecords"
        Me.LblBillRecords.Size = New System.Drawing.Size(117, 18)
        Me.LblBillRecords.TabIndex = 1
        Me.LblBillRecords.Text = "Bill Records :"
        '
        'DB_BillRecords
        '
        Me.DB_BillRecords.DataSetName = "DB_BillRecords"
        Me.DB_BillRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBBillRecordsBindingSource
        '
        Me.TBBillRecordsBindingSource.DataMember = "TB_Bill_Records"
        Me.TBBillRecordsBindingSource.DataSource = Me.DB_BillRecords
        '
        'TB_Bill_RecordsTableAdapter
        '
        Me.TB_Bill_RecordsTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        Me.TimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableNoDataGridViewTextBoxColumn
        '
        Me.TableNoDataGridViewTextBoxColumn.DataPropertyName = "Table_No"
        Me.TableNoDataGridViewTextBoxColumn.HeaderText = "Table No"
        Me.TableNoDataGridViewTextBoxColumn.Name = "TableNoDataGridViewTextBoxColumn"
        Me.TableNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentTypeDataGridViewTextBoxColumn
        '
        Me.PaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "Payment_Type"
        Me.PaymentTypeDataGridViewTextBoxColumn.HeaderText = "Payment Type"
        Me.PaymentTypeDataGridViewTextBoxColumn.Name = "PaymentTypeDataGridViewTextBoxColumn"
        Me.PaymentTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 696)
        Me.Controls.Add(Me.LblBillRecords)
        Me.Controls.Add(Me.GD_BillRecords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reports"
        Me.Text = "Reports"
        CType(Me.GD_BillRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_BillRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBBillRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Elipse_Reports As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents GD_BillRecords As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents LblBillRecords As Label
    Friend WithEvents DB_BillRecords As DB_BillRecords
    Friend WithEvents TBBillRecordsBindingSource As BindingSource
    Friend WithEvents TB_Bill_RecordsTableAdapter As DB_BillRecordsTableAdapters.TB_Bill_RecordsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
