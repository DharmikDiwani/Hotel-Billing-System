<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MDI
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
        Me.Elipse_MDI = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.btn_ItemMaster = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Btn_Table = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Btn_Order = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Btn_Reports = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2ShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Elipse_MDI
        '
        Me.Elipse_MDI.TargetControl = Me
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.Btn_Reports)
        Me.Guna2ShadowPanel1.Controls.Add(Me.btn_ItemMaster)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Btn_Table)
        Me.Guna2ShadowPanel1.Controls.Add(Me.Btn_Order)
        Me.Guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1386, 100)
        Me.Guna2ShadowPanel1.TabIndex = 1
        '
        'btn_ItemMaster
        '
        Me.btn_ItemMaster.CheckedState.Parent = Me.btn_ItemMaster
        Me.btn_ItemMaster.CustomImages.Parent = Me.btn_ItemMaster
        Me.btn_ItemMaster.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ItemMaster.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_ItemMaster.Font = New System.Drawing.Font("Shruti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ItemMaster.ForeColor = System.Drawing.Color.Black
        Me.btn_ItemMaster.HoverState.Parent = Me.btn_ItemMaster
        Me.btn_ItemMaster.Location = New System.Drawing.Point(377, 11)
        Me.btn_ItemMaster.Name = "btn_ItemMaster"
        Me.btn_ItemMaster.ShadowDecoration.Parent = Me.btn_ItemMaster
        Me.btn_ItemMaster.Size = New System.Drawing.Size(161, 75)
        Me.btn_ItemMaster.TabIndex = 0
        Me.btn_ItemMaster.Text = "Item Master"
        '
        'Btn_Table
        '
        Me.Btn_Table.CheckedState.Parent = Me.Btn_Table
        Me.Btn_Table.CustomImages.Parent = Me.Btn_Table
        Me.Btn_Table.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Table.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Table.Font = New System.Drawing.Font("Shruti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Table.ForeColor = System.Drawing.Color.Black
        Me.Btn_Table.HoverState.Parent = Me.Btn_Table
        Me.Btn_Table.Location = New System.Drawing.Point(190, 11)
        Me.Btn_Table.Name = "Btn_Table"
        Me.Btn_Table.ShadowDecoration.Parent = Me.Btn_Table
        Me.Btn_Table.Size = New System.Drawing.Size(161, 75)
        Me.Btn_Table.TabIndex = 0
        Me.Btn_Table.Text = "Tables"
        '
        'Btn_Order
        '
        Me.Btn_Order.CheckedState.Parent = Me.Btn_Order
        Me.Btn_Order.CustomImages.Parent = Me.Btn_Order
        Me.Btn_Order.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Order.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Order.Font = New System.Drawing.Font("Shruti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Order.ForeColor = System.Drawing.Color.Black
        Me.Btn_Order.HoverState.Parent = Me.Btn_Order
        Me.Btn_Order.Location = New System.Drawing.Point(10, 11)
        Me.Btn_Order.Name = "Btn_Order"
        Me.Btn_Order.ShadowDecoration.Parent = Me.Btn_Order
        Me.Btn_Order.Size = New System.Drawing.Size(161, 75)
        Me.Btn_Order.TabIndex = 0
        Me.Btn_Order.Text = "Order Master"
        '
        'Btn_Reports
        '
        Me.Btn_Reports.CheckedState.Parent = Me.Btn_Reports
        Me.Btn_Reports.CustomImages.Parent = Me.Btn_Reports
        Me.Btn_Reports.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Reports.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Reports.Font = New System.Drawing.Font("Shruti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Reports.ForeColor = System.Drawing.Color.Black
        Me.Btn_Reports.HoverState.Parent = Me.Btn_Reports
        Me.Btn_Reports.Location = New System.Drawing.Point(561, 11)
        Me.Btn_Reports.Name = "Btn_Reports"
        Me.Btn_Reports.ShadowDecoration.Parent = Me.Btn_Reports
        Me.Btn_Reports.Size = New System.Drawing.Size(161, 75)
        Me.Btn_Reports.TabIndex = 1
        Me.Btn_Reports.Text = "Reports"
        '
        'Form_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Form_MDI"
        Me.Text = "Form_MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Elipse_MDI As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents btn_ItemMaster As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Btn_Table As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Btn_Order As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Btn_Reports As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
