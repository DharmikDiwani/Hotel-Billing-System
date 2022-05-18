<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_Master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_Master))
        Me.Elipse_ItemMaster = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_All_Items = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBItemMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_BillingDataSet1 = New Hotel_Billing_System.DB_BillingDataSet1()
        Me.Pnl_Edit_Item = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.Btn_Delete = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ErrMsgPrice = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.ErrMsgItemName = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.ErrMsgType = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Btn_Add = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Btn_Update = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Txt_ItemPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Txt_ItemName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Lbl_Price = New System.Windows.Forms.Label()
        Me.Lbl_Item_name = New System.Windows.Forms.Label()
        Me.Lbl_Type = New System.Windows.Forms.Label()
        Me.Combo_Type = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.RdoBtn_Delete = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RdoBtn_Edit_Item = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.RdoBtn_Add_Item = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.TB_Item_MasterTableAdapter = New Hotel_Billing_System.DB_BillingDataSet1TableAdapters.TB_Item_MasterTableAdapter()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        CType(Me.DG_All_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBItemMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_BillingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Edit_Item.SuspendLayout()
        CType(Me.ErrMsgPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrMsgItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrMsgType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Elipse_ItemMaster
        '
        Me.Elipse_ItemMaster.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "All items :"
        '
        'DG_All_Items
        '
        Me.DG_All_Items.AllowUserToAddRows = False
        Me.DG_All_Items.AllowUserToDeleteRows = False
        Me.DG_All_Items.AllowUserToResizeColumns = False
        Me.DG_All_Items.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DG_All_Items.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_All_Items.AutoGenerateColumns = False
        Me.DG_All_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_All_Items.BackgroundColor = System.Drawing.Color.White
        Me.DG_All_Items.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_All_Items.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_All_Items.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_All_Items.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_All_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DG_All_Items.DataSource = Me.TBItemMasterBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DG_All_Items.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_All_Items.EnableHeadersVisualStyles = False
        Me.DG_All_Items.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_All_Items.Location = New System.Drawing.Point(11, 10)
        Me.DG_All_Items.Name = "DG_All_Items"
        Me.DG_All_Items.ReadOnly = True
        Me.DG_All_Items.RowHeadersVisible = False
        Me.DG_All_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_All_Items.Size = New System.Drawing.Size(696, 337)
        Me.DG_All_Items.TabIndex = 8
        Me.DG_All_Items.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DG_All_Items.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_All_Items.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DG_All_Items.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DG_All_Items.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DG_All_Items.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DG_All_Items.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DG_All_Items.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_All_Items.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_All_Items.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_All_Items.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_All_Items.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DG_All_Items.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DG_All_Items.ThemeStyle.HeaderStyle.Height = 23
        Me.DG_All_Items.ThemeStyle.ReadOnly = True
        Me.DG_All_Items.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DG_All_Items.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DG_All_Items.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DG_All_Items.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DG_All_Items.ThemeStyle.RowsStyle.Height = 22
        Me.DG_All_Items.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DG_All_Items.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Item Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TBItemMasterBindingSource
        '
        Me.TBItemMasterBindingSource.DataMember = "TB_Item_Master"
        Me.TBItemMasterBindingSource.DataSource = Me.DB_BillingDataSet1
        '
        'DB_BillingDataSet1
        '
        Me.DB_BillingDataSet1.DataSetName = "DB_BillingDataSet1"
        Me.DB_BillingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Pnl_Edit_Item
        '
        Me.Pnl_Edit_Item.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_Edit_Item.Controls.Add(Me.Btn_Delete)
        Me.Pnl_Edit_Item.Controls.Add(Me.ErrMsgPrice)
        Me.Pnl_Edit_Item.Controls.Add(Me.ErrMsgItemName)
        Me.Pnl_Edit_Item.Controls.Add(Me.ErrMsgType)
        Me.Pnl_Edit_Item.Controls.Add(Me.Btn_Add)
        Me.Pnl_Edit_Item.Controls.Add(Me.Btn_Update)
        Me.Pnl_Edit_Item.Controls.Add(Me.Txt_ItemPrice)
        Me.Pnl_Edit_Item.Controls.Add(Me.Txt_ItemName)
        Me.Pnl_Edit_Item.Controls.Add(Me.Lbl_Price)
        Me.Pnl_Edit_Item.Controls.Add(Me.Lbl_Item_name)
        Me.Pnl_Edit_Item.Controls.Add(Me.Lbl_Type)
        Me.Pnl_Edit_Item.Controls.Add(Me.Combo_Type)
        Me.Pnl_Edit_Item.Controls.Add(Me.RdoBtn_Delete)
        Me.Pnl_Edit_Item.Controls.Add(Me.RdoBtn_Edit_Item)
        Me.Pnl_Edit_Item.Controls.Add(Me.RdoBtn_Add_Item)
        Me.Pnl_Edit_Item.FillColor = System.Drawing.Color.White
        Me.Pnl_Edit_Item.Location = New System.Drawing.Point(39, 408)
        Me.Pnl_Edit_Item.Name = "Pnl_Edit_Item"
        Me.Pnl_Edit_Item.ShadowColor = System.Drawing.Color.Black
        Me.Pnl_Edit_Item.Size = New System.Drawing.Size(696, 253)
        Me.Pnl_Edit_Item.TabIndex = 2
        '
        'Btn_Delete
        '
        Me.Btn_Delete.CheckedState.Parent = Me.Btn_Delete
        Me.Btn_Delete.CustomImages.Parent = Me.Btn_Delete
        Me.Btn_Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.HoverState.Parent = Me.Btn_Delete
        Me.Btn_Delete.Location = New System.Drawing.Point(510, 194)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.ShadowDecoration.Parent = Me.Btn_Delete
        Me.Btn_Delete.Size = New System.Drawing.Size(138, 45)
        Me.Btn_Delete.TabIndex = 11
        Me.Btn_Delete.Text = "Delete"
        '
        'ErrMsgPrice
        '
        Me.ErrMsgPrice.ErrorImage = CType(resources.GetObject("ErrMsgPrice.ErrorImage"), System.Drawing.Image)
        Me.ErrMsgPrice.Image = CType(resources.GetObject("ErrMsgPrice.Image"), System.Drawing.Image)
        Me.ErrMsgPrice.Location = New System.Drawing.Point(378, 194)
        Me.ErrMsgPrice.Name = "ErrMsgPrice"
        Me.ErrMsgPrice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ErrMsgPrice.ShadowDecoration.Parent = Me.ErrMsgPrice
        Me.ErrMsgPrice.Size = New System.Drawing.Size(25, 25)
        Me.ErrMsgPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrMsgPrice.TabIndex = 10
        Me.ErrMsgPrice.TabStop = False
        Me.ErrMsgPrice.Visible = False
        '
        'ErrMsgItemName
        '
        Me.ErrMsgItemName.ErrorImage = CType(resources.GetObject("ErrMsgItemName.ErrorImage"), System.Drawing.Image)
        Me.ErrMsgItemName.Image = CType(resources.GetObject("ErrMsgItemName.Image"), System.Drawing.Image)
        Me.ErrMsgItemName.Location = New System.Drawing.Point(377, 140)
        Me.ErrMsgItemName.Name = "ErrMsgItemName"
        Me.ErrMsgItemName.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ErrMsgItemName.ShadowDecoration.Parent = Me.ErrMsgItemName
        Me.ErrMsgItemName.Size = New System.Drawing.Size(25, 25)
        Me.ErrMsgItemName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrMsgItemName.TabIndex = 9
        Me.ErrMsgItemName.TabStop = False
        Me.ErrMsgItemName.Visible = False
        '
        'ErrMsgType
        '
        Me.ErrMsgType.ErrorImage = CType(resources.GetObject("ErrMsgType.ErrorImage"), System.Drawing.Image)
        Me.ErrMsgType.Image = CType(resources.GetObject("ErrMsgType.Image"), System.Drawing.Image)
        Me.ErrMsgType.Location = New System.Drawing.Point(333, 83)
        Me.ErrMsgType.Name = "ErrMsgType"
        Me.ErrMsgType.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ErrMsgType.ShadowDecoration.Parent = Me.ErrMsgType
        Me.ErrMsgType.Size = New System.Drawing.Size(25, 25)
        Me.ErrMsgType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ErrMsgType.TabIndex = 8
        Me.ErrMsgType.TabStop = False
        Me.ErrMsgType.Visible = False
        '
        'Btn_Add
        '
        Me.Btn_Add.CheckedState.Parent = Me.Btn_Add
        Me.Btn_Add.CustomImages.Parent = Me.Btn_Add
        Me.Btn_Add.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.White
        Me.Btn_Add.HoverState.Parent = Me.Btn_Add
        Me.Btn_Add.Location = New System.Drawing.Point(510, 194)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.ShadowDecoration.Parent = Me.Btn_Add
        Me.Btn_Add.Size = New System.Drawing.Size(138, 45)
        Me.Btn_Add.TabIndex = 6
        Me.Btn_Add.Text = "Add "
        '
        'Btn_Update
        '
        Me.Btn_Update.CheckedState.Parent = Me.Btn_Update
        Me.Btn_Update.CustomImages.Parent = Me.Btn_Update
        Me.Btn_Update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update.ForeColor = System.Drawing.Color.White
        Me.Btn_Update.HoverState.Parent = Me.Btn_Update
        Me.Btn_Update.Location = New System.Drawing.Point(510, 194)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.ShadowDecoration.Parent = Me.Btn_Update
        Me.Btn_Update.Size = New System.Drawing.Size(138, 45)
        Me.Btn_Update.TabIndex = 7
        Me.Btn_Update.Text = "Update"
        '
        'Txt_ItemPrice
        '
        Me.Txt_ItemPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ItemPrice.DefaultText = ""
        Me.Txt_ItemPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_ItemPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_ItemPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_ItemPrice.DisabledState.Parent = Me.Txt_ItemPrice
        Me.Txt_ItemPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_ItemPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_ItemPrice.FocusedState.Parent = Me.Txt_ItemPrice
        Me.Txt_ItemPrice.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ItemPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_ItemPrice.HoverState.Parent = Me.Txt_ItemPrice
        Me.Txt_ItemPrice.Location = New System.Drawing.Point(172, 188)
        Me.Txt_ItemPrice.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Txt_ItemPrice.Name = "Txt_ItemPrice"
        Me.Txt_ItemPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ItemPrice.PlaceholderText = ""
        Me.Txt_ItemPrice.SelectedText = ""
        Me.Txt_ItemPrice.ShadowDecoration.Parent = Me.Txt_ItemPrice
        Me.Txt_ItemPrice.Size = New System.Drawing.Size(200, 36)
        Me.Txt_ItemPrice.TabIndex = 5
        '
        'Txt_ItemName
        '
        Me.Txt_ItemName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_ItemName.DefaultText = ""
        Me.Txt_ItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Txt_ItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Txt_ItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_ItemName.DisabledState.Parent = Me.Txt_ItemName
        Me.Txt_ItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Txt_ItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_ItemName.FocusedState.Parent = Me.Txt_ItemName
        Me.Txt_ItemName.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_ItemName.HoverState.Parent = Me.Txt_ItemName
        Me.Txt_ItemName.Location = New System.Drawing.Point(173, 136)
        Me.Txt_ItemName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txt_ItemName.Name = "Txt_ItemName"
        Me.Txt_ItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_ItemName.PlaceholderText = ""
        Me.Txt_ItemName.SelectedText = ""
        Me.Txt_ItemName.ShadowDecoration.Parent = Me.Txt_ItemName
        Me.Txt_ItemName.Size = New System.Drawing.Size(200, 36)
        Me.Txt_ItemName.TabIndex = 4
        '
        'Lbl_Price
        '
        Me.Lbl_Price.AutoSize = True
        Me.Lbl_Price.Location = New System.Drawing.Point(62, 198)
        Me.Lbl_Price.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Price.Name = "Lbl_Price"
        Me.Lbl_Price.Size = New System.Drawing.Size(51, 21)
        Me.Lbl_Price.TabIndex = 5
        Me.Lbl_Price.Text = "Price :"
        '
        'Lbl_Item_name
        '
        Me.Lbl_Item_name.AutoSize = True
        Me.Lbl_Item_name.Location = New System.Drawing.Point(62, 144)
        Me.Lbl_Item_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Item_name.Name = "Lbl_Item_name"
        Me.Lbl_Item_name.Size = New System.Drawing.Size(94, 21)
        Me.Lbl_Item_name.TabIndex = 4
        Me.Lbl_Item_name.Text = "Item Name :"
        '
        'Lbl_Type
        '
        Me.Lbl_Type.AutoSize = True
        Me.Lbl_Type.Location = New System.Drawing.Point(62, 89)
        Me.Lbl_Type.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Type.Name = "Lbl_Type"
        Me.Lbl_Type.Size = New System.Drawing.Size(49, 21)
        Me.Lbl_Type.TabIndex = 3
        Me.Lbl_Type.Text = "Type :"
        '
        'Combo_Type
        '
        Me.Combo_Type.BackColor = System.Drawing.Color.Transparent
        Me.Combo_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Combo_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Type.FocusedColor = System.Drawing.Color.Empty
        Me.Combo_Type.FocusedState.Parent = Me.Combo_Type
        Me.Combo_Type.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Combo_Type.FormattingEnabled = True
        Me.Combo_Type.HoverState.Parent = Me.Combo_Type
        Me.Combo_Type.ItemHeight = 16
        Me.Combo_Type.Items.AddRange(New Object() {"Khatiyavadi", "Punjabi", "Chinese", "Cold-drinks", "Other"})
        Me.Combo_Type.ItemsAppearance.Parent = Me.Combo_Type
        Me.Combo_Type.Location = New System.Drawing.Point(173, 84)
        Me.Combo_Type.Name = "Combo_Type"
        Me.Combo_Type.ShadowDecoration.Parent = Me.Combo_Type
        Me.Combo_Type.Size = New System.Drawing.Size(154, 22)
        Me.Combo_Type.TabIndex = 3
        '
        'RdoBtn_Delete
        '
        Me.RdoBtn_Delete.AutoSize = True
        Me.RdoBtn_Delete.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RdoBtn_Delete.CheckedState.BorderThickness = 0
        Me.RdoBtn_Delete.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RdoBtn_Delete.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdoBtn_Delete.CheckedState.InnerOffset = -4
        Me.RdoBtn_Delete.Location = New System.Drawing.Point(534, 28)
        Me.RdoBtn_Delete.Name = "RdoBtn_Delete"
        Me.RdoBtn_Delete.Size = New System.Drawing.Size(114, 25)
        Me.RdoBtn_Delete.TabIndex = 2
        Me.RdoBtn_Delete.Text = "Delete Item :"
        Me.RdoBtn_Delete.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RdoBtn_Delete.UncheckedState.BorderThickness = 2
        Me.RdoBtn_Delete.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdoBtn_Delete.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdoBtn_Delete.UseVisualStyleBackColor = True
        '
        'RdoBtn_Edit_Item
        '
        Me.RdoBtn_Edit_Item.AutoSize = True
        Me.RdoBtn_Edit_Item.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RdoBtn_Edit_Item.CheckedState.BorderThickness = 0
        Me.RdoBtn_Edit_Item.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RdoBtn_Edit_Item.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdoBtn_Edit_Item.CheckedState.InnerOffset = -4
        Me.RdoBtn_Edit_Item.Location = New System.Drawing.Point(306, 28)
        Me.RdoBtn_Edit_Item.Name = "RdoBtn_Edit_Item"
        Me.RdoBtn_Edit_Item.Size = New System.Drawing.Size(96, 25)
        Me.RdoBtn_Edit_Item.TabIndex = 2
        Me.RdoBtn_Edit_Item.Text = "Edit Item :"
        Me.RdoBtn_Edit_Item.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RdoBtn_Edit_Item.UncheckedState.BorderThickness = 2
        Me.RdoBtn_Edit_Item.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdoBtn_Edit_Item.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdoBtn_Edit_Item.UseVisualStyleBackColor = True
        '
        'RdoBtn_Add_Item
        '
        Me.RdoBtn_Add_Item.AutoSize = True
        Me.RdoBtn_Add_Item.Checked = True
        Me.RdoBtn_Add_Item.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RdoBtn_Add_Item.CheckedState.BorderThickness = 0
        Me.RdoBtn_Add_Item.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RdoBtn_Add_Item.CheckedState.InnerColor = System.Drawing.Color.White
        Me.RdoBtn_Add_Item.CheckedState.InnerOffset = -4
        Me.RdoBtn_Add_Item.Location = New System.Drawing.Point(35, 28)
        Me.RdoBtn_Add_Item.Name = "RdoBtn_Add_Item"
        Me.RdoBtn_Add_Item.Size = New System.Drawing.Size(98, 25)
        Me.RdoBtn_Add_Item.TabIndex = 1
        Me.RdoBtn_Add_Item.TabStop = True
        Me.RdoBtn_Add_Item.Text = "Add Item :"
        Me.RdoBtn_Add_Item.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.RdoBtn_Add_Item.UncheckedState.BorderThickness = 2
        Me.RdoBtn_Add_Item.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.RdoBtn_Add_Item.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.RdoBtn_Add_Item.UseVisualStyleBackColor = True
        '
        'TB_Item_MasterTableAdapter
        '
        Me.TB_Item_MasterTableAdapter.ClearBeforeFill = True
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.DG_All_Items)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(39, 43)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(718, 359)
        Me.Guna2ShadowPanel1.TabIndex = 9
        '
        'Item_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 696)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.Pnl_Edit_Item)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Item_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item_Master"
        CType(Me.DG_All_Items, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBItemMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_BillingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Edit_Item.ResumeLayout(False)
        Me.Pnl_Edit_Item.PerformLayout()
        CType(Me.ErrMsgPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrMsgItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrMsgType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Elipse_ItemMaster As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Label1 As Label
    Friend WithEvents DG_All_Items As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Pnl_Edit_Item As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents Btn_Add As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Btn_Update As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Txt_ItemPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Txt_ItemName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Lbl_Price As Label
    Friend WithEvents Lbl_Item_name As Label
    Friend WithEvents Lbl_Type As Label
    Friend WithEvents Combo_Type As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents RdoBtn_Edit_Item As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents RdoBtn_Add_Item As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents DB_BillingDataSet1 As DB_BillingDataSet1
    Friend WithEvents TBItemMasterBindingSource As BindingSource
    Friend WithEvents TB_Item_MasterTableAdapter As DB_BillingDataSet1TableAdapters.TB_Item_MasterTableAdapter
    Friend WithEvents ErrMsgPrice As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ErrMsgItemName As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents ErrMsgType As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Delete As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents RdoBtn_Delete As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
