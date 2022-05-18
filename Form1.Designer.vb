<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Elipse_OrderForm = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Combo_TableNo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Lbl_TableNo = New System.Windows.Forms.Label()
        Me.GDMenu = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Check = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBItemMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Menu = New Hotel_Billing_System.DS_Menu()
        Me.Btn_AddItems = New System.Windows.Forms.Button()
        Me.BtnDeleteAll = New System.Windows.Forms.Button()
        Me.OrderGD = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.GDQT = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.TB_Item_MasterTableAdapter = New Hotel_Billing_System.DS_MenuTableAdapters.TB_Item_MasterTableAdapter()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Combo_TableAlpha = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GDMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBItemMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderGD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GDQT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Elipse_OrderForm
        '
        Me.Elipse_OrderForm.TargetControl = Me
        '
        'Combo_TableNo
        '
        Me.Combo_TableNo.BackColor = System.Drawing.Color.Transparent
        Me.Combo_TableNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo_TableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_TableNo.FocusedColor = System.Drawing.Color.Empty
        Me.Combo_TableNo.FocusedState.Parent = Me.Combo_TableNo
        Me.Combo_TableNo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combo_TableNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Combo_TableNo.FormattingEnabled = True
        Me.Combo_TableNo.HoverState.Parent = Me.Combo_TableNo
        Me.Combo_TableNo.ItemHeight = 15
        Me.Combo_TableNo.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.Combo_TableNo.ItemsAppearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_TableNo.ItemsAppearance.Parent = Me.Combo_TableNo
        Me.Combo_TableNo.ItemsAppearance.SelectedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_TableNo.Location = New System.Drawing.Point(142, 257)
        Me.Combo_TableNo.Name = "Combo_TableNo"
        Me.Combo_TableNo.ShadowDecoration.Parent = Me.Combo_TableNo
        Me.Combo_TableNo.Size = New System.Drawing.Size(57, 21)
        Me.Combo_TableNo.TabIndex = 1
        '
        'Lbl_TableNo
        '
        Me.Lbl_TableNo.AutoSize = True
        Me.Lbl_TableNo.Location = New System.Drawing.Point(27, 260)
        Me.Lbl_TableNo.Name = "Lbl_TableNo"
        Me.Lbl_TableNo.Size = New System.Drawing.Size(60, 13)
        Me.Lbl_TableNo.TabIndex = 0
        Me.Lbl_TableNo.Text = "Table No : "
        '
        'GDMenu
        '
        Me.GDMenu.AllowUserToAddRows = False
        Me.GDMenu.AllowUserToDeleteRows = False
        Me.GDMenu.AllowUserToOrderColumns = True
        Me.GDMenu.AllowUserToResizeColumns = False
        Me.GDMenu.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.GDMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GDMenu.AutoGenerateColumns = False
        Me.GDMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GDMenu.BackgroundColor = System.Drawing.Color.White
        Me.GDMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GDMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GDMenu.ColumnHeadersHeight = 21
        Me.GDMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.Check})
        Me.GDMenu.DataSource = Me.TBItemMasterBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDMenu.DefaultCellStyle = DataGridViewCellStyle9
        Me.GDMenu.EnableHeadersVisualStyles = False
        Me.GDMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDMenu.Location = New System.Drawing.Point(10, 34)
        Me.GDMenu.Name = "GDMenu"
        Me.GDMenu.RowHeadersVisible = False
        Me.GDMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GDMenu.Size = New System.Drawing.Size(427, 213)
        Me.GDMenu.TabIndex = 1
        Me.GDMenu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.GDMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDMenu.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDMenu.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GDMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDMenu.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDMenu.ThemeStyle.HeaderStyle.Height = 21
        Me.GDMenu.ThemeStyle.ReadOnly = False
        Me.GDMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDMenu.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDMenu.ThemeStyle.RowsStyle.Height = 22
        Me.GDMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'Check
        '
        Me.Check.HeaderText = "Check"
        Me.Check.Name = "Check"
        '
        'TBItemMasterBindingSource
        '
        Me.TBItemMasterBindingSource.DataMember = "TB_Item_Master"
        Me.TBItemMasterBindingSource.DataSource = Me.DS_Menu
        '
        'DS_Menu
        '
        Me.DS_Menu.DataSetName = "DS_Menu"
        Me.DS_Menu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Btn_AddItems
        '
        Me.Btn_AddItems.Location = New System.Drawing.Point(384, 250)
        Me.Btn_AddItems.Name = "Btn_AddItems"
        Me.Btn_AddItems.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AddItems.TabIndex = 3
        Me.Btn_AddItems.Text = "Add Items"
        Me.Btn_AddItems.UseVisualStyleBackColor = True
        '
        'BtnDeleteAll
        '
        Me.BtnDeleteAll.Location = New System.Drawing.Point(7, 669)
        Me.BtnDeleteAll.Name = "BtnDeleteAll"
        Me.BtnDeleteAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteAll.TabIndex = 4
        Me.BtnDeleteAll.Text = "Delete All"
        Me.BtnDeleteAll.UseVisualStyleBackColor = True
        '
        'OrderGD
        '
        Me.OrderGD.AllowUserToAddRows = False
        Me.OrderGD.AllowUserToResizeColumns = False
        Me.OrderGD.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.OrderGD.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.OrderGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrderGD.BackgroundColor = System.Drawing.Color.White
        Me.OrderGD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OrderGD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrderGD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrderGD.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.OrderGD.ColumnHeadersHeight = 21
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrderGD.DefaultCellStyle = DataGridViewCellStyle6
        Me.OrderGD.EnableHeadersVisualStyles = False
        Me.OrderGD.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderGD.Location = New System.Drawing.Point(14, 286)
        Me.OrderGD.Name = "OrderGD"
        Me.OrderGD.ReadOnly = True
        Me.OrderGD.RowHeadersVisible = False
        Me.OrderGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OrderGD.Size = New System.Drawing.Size(427, 223)
        Me.OrderGD.TabIndex = 6
        Me.OrderGD.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.OrderGD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.OrderGD.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.OrderGD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.OrderGD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.OrderGD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.OrderGD.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.OrderGD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderGD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderGD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.OrderGD.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.OrderGD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.OrderGD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.OrderGD.ThemeStyle.HeaderStyle.Height = 21
        Me.OrderGD.ThemeStyle.ReadOnly = True
        Me.OrderGD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.OrderGD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OrderGD.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.OrderGD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.OrderGD.ThemeStyle.RowsStyle.Height = 22
        Me.OrderGD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OrderGD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(518, 538)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "&Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'GDQT
        '
        Me.GDQT.AllowUserToAddRows = False
        Me.GDQT.AllowUserToResizeColumns = False
        Me.GDQT.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.GDQT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GDQT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GDQT.BackgroundColor = System.Drawing.Color.White
        Me.GDQT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GDQT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDQT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GDQT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GDQT.ColumnHeadersHeight = 21
        Me.GDQT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GDQT.DefaultCellStyle = DataGridViewCellStyle3
        Me.GDQT.EnableHeadersVisualStyles = False
        Me.GDQT.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDQT.Location = New System.Drawing.Point(441, 286)
        Me.GDQT.Name = "GDQT"
        Me.GDQT.RowHeadersVisible = False
        Me.GDQT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GDQT.Size = New System.Drawing.Size(135, 223)
        Me.GDQT.TabIndex = 8
        Me.GDQT.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.GDQT.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GDQT.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GDQT.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GDQT.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GDQT.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GDQT.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GDQT.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDQT.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDQT.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GDQT.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDQT.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GDQT.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.GDQT.ThemeStyle.HeaderStyle.Height = 21
        Me.GDQT.ThemeStyle.ReadOnly = False
        Me.GDQT.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GDQT.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GDQT.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GDQT.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GDQT.ThemeStyle.RowsStyle.Height = 22
        Me.GDQT.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GDQT.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'TB_Item_MasterTableAdapter
        '
        Me.TB_Item_MasterTableAdapter.ClearBeforeFill = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(395, 514)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(0, 21)
        Me.LblTotal.TabIndex = 9
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(517, 250)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 10
        Me.BtnClear.Text = "&Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Combo_TableAlpha
        '
        Me.Combo_TableAlpha.BackColor = System.Drawing.Color.Transparent
        Me.Combo_TableAlpha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo_TableAlpha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_TableAlpha.FocusedColor = System.Drawing.Color.Empty
        Me.Combo_TableAlpha.FocusedState.Parent = Me.Combo_TableAlpha
        Me.Combo_TableAlpha.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Combo_TableAlpha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Combo_TableAlpha.FormattingEnabled = True
        Me.Combo_TableAlpha.HoverState.Parent = Me.Combo_TableAlpha
        Me.Combo_TableAlpha.ItemHeight = 15
        Me.Combo_TableAlpha.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.Combo_TableAlpha.ItemsAppearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_TableAlpha.ItemsAppearance.Parent = Me.Combo_TableAlpha
        Me.Combo_TableAlpha.ItemsAppearance.SelectedFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_TableAlpha.Location = New System.Drawing.Point(83, 257)
        Me.Combo_TableAlpha.Name = "Combo_TableAlpha"
        Me.Combo_TableAlpha.ShadowDecoration.Parent = Me.Combo_TableAlpha
        Me.Combo_TableAlpha.Size = New System.Drawing.Size(59, 21)
        Me.Combo_TableAlpha.TabIndex = 11
        '
        'Column2
        '
        Me.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "20", "30", "40", "50", "D"})
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Total"
        Me.Column3.Name = "Column3"
        '
        'Form_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 696)
        Me.Controls.Add(Me.Combo_TableAlpha)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.GDQT)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.OrderGD)
        Me.Controls.Add(Me.BtnDeleteAll)
        Me.Controls.Add(Me.Btn_AddItems)
        Me.Controls.Add(Me.Combo_TableNo)
        Me.Controls.Add(Me.Lbl_TableNo)
        Me.Controls.Add(Me.GDMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Order"
        Me.Text = "Form_Order"
        CType(Me.GDMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBItemMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderGD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GDQT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Elipse_OrderForm As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Combo_TableNo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Lbl_TableNo As Label
    Friend WithEvents GDMenu As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Btn_AddItems As Button
    Friend WithEvents BtnDeleteAll As Button
    Friend WithEvents OrderGD As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents GDQT As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DS_Menu As DS_Menu
    Friend WithEvents TBItemMasterBindingSource As BindingSource
    Friend WithEvents TB_Item_MasterTableAdapter As DS_MenuTableAdapters.TB_Item_MasterTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Check As DataGridViewCheckBoxColumn
    Friend WithEvents LblTotal As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents Combo_TableAlpha As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
