Imports System.Data.SqlClient
Imports System.Data
Public Class Form_Tables

    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable
    Dim tbl_no As String
    Dim i As Integer
    Dim CurrentGDV As DataGridView
    'Dim tblno As String
    Dim Temptotal As Double
    Private Sub Form_Tables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Height = GD_Recp.Height + 220
        GridSettings()
        GD_Recp.Columns(0).Name = "Item Name"
        GD_Recp.Columns(1).Name = "Quantity"
        GD_Recp.Columns(2).Name = "Price"
        GD_Recp.Columns(3).Name = "Total"

        GD_Recp.Columns(0).Width = 100
        'GD_Recp.Columns(1).Width = 15
        'GD_Recp.Columns(2).Width = 50
        'GD_Recp.Columns(0).Width = 50
        ResizeGD()


    End Sub
    Private Sub GridSettings()
        GD_Recp.ScrollBars = ScrollBars.None
        ' GD_Recp.RowHeadersVisible = False

        GD_Recp.ColumnCount = 4

        GD_Recp.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        GD_Recp.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        GD_Recp.CellBorderStyle = DataGridViewCellBorderStyle.None

    End Sub
    Private Sub ResizeGD()
        Dim rowsize = GD_Recp.Rows.Cast(Of DataGridViewRow).Sum(Function(r) r.Height)
        GD_Recp.Height = GD_Recp.ColumnHeadersHeight + rowsize
        Panel1.Height = GD_Recp.Height + 150
        GD_Recp.ClearSelection()
        LblDash.Location = New Point(10, 117 + rowsize)
        lblrTotal.Location = New Point(270, 135 + rowsize)
        LblTotal.Location = New Point(329, 135 + rowsize)
        BtnPrint_A.Location = New Point(1237, 190 + rowsize)
        ComboPayMethod.Location = New Point(1091, 190 + rowsize)
    End Sub
    Public Sub FillRecord(ByVal tblno As String, ByVal gd As DataGridView, ByVal total As Label)
        CurrentGDV = gd
        tbl_no = tblno
        str = "select * from Tb_Order_Master where Table_No=@tblno"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@tblno", tblno)
        End With
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        gd.DataSource = dt
        For i = 0 To gd.Rows.Count - 1
            gd.Rows(i).HeaderCell.Value = (i + 1).ToString
        Next
        gd.Columns(0).Visible = False
        gd.Columns(1).Visible = False
        gd.Columns(2).Visible = False

        ' gd.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        gd.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        gd.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Temptotal = 0
        GD_Recp.Rows.Clear()
        If gd.Rows.Count > 0 Then
            For i As Integer = 0 To gd.Rows.Count - 1
                Temptotal += gd.Rows(i).Cells(6).Value
                GD_Recp.Rows.Add()
                GD_Recp.Rows(i).Cells(0).Value = gd.Rows(i).Cells(3).Value
                GD_Recp.Rows(i).Cells(1).Value = gd.Rows(i).Cells(4).Value
                GD_Recp.Rows(i).Cells(2).Value = gd.Rows(i).Cells(5).Value
                GD_Recp.Rows(i).Cells(3).Value = gd.Rows(i).Cells(6).Value
            Next
        End If
        total.Text = Format(Temptotal, "0.00")
        LblTotal.Text = Format(Temptotal, "0.00")
        LblDate.Text = Now.Date
        LblTblNo.Text = tblno
        ResizeGD()
    End Sub

    Public Sub BillRecord()
        If Temptotal = 0 Then
            Return
        End If

        str = "insert into TB_Bill_Records values (@Time,@Date,@TblNo,@Total,@PayType)"

        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Time", Now.ToString("T"))
            .AddWithValue("@Date", Now.Date)
                .AddWithValue("@TblNo", tbl_no)
                .AddWithValue("@Total", Temptotal)
                .AddWithValue("@PayType", ComboPayMethod.Text)
            End With
        conn(con)
        cmd.ExecuteNonQuery()
        con.Close()
        str = "delete from TB_Order_Master where Table_No=@tblno"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@tblNo", tbl_no)
        End With
        conn(con)
        cmd.ExecuteNonQuery()
        con.Close()
        FillRecord(tbl_no, CurrentGDV, LblTotal)
        Report_Load()
    End Sub
    Private Sub Combo_A_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_A.SelectedIndexChanged, Combo_A.Enter
        FillRecord("A" + Combo_A.Text, GDTbl_A, LblTotal_A)
    End Sub

    Private Sub Combo_B_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_B.SelectedIndexChanged, Combo_B.Enter
        FillRecord("B" + Combo_B.Text, GDTbl_B, LblTotal_B)
    End Sub

    Private Sub Combo_C_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_C.SelectedIndexChanged, Combo_C.Enter
        FillRecord("C" + Combo_C.Text, GDTbl_C, LblTotal_C)
    End Sub

    Private Sub Combo_D_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_D.SelectedIndexChanged, Combo_D.Enter
        FillRecord("D" + Combo_D.Text, GDTbl_D, LblTotal_D)
    End Sub

    Private Sub PrintRec_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintRec.PrintPage
        'Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        'Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        'e.Graphics.DrawImage(bm, 0, 0)
        'Dim aps As PageSetupDialog
        'aps.Document = PrintRec

    End Sub

    Private Sub BtnPrint_A_Click(sender As Object, e As EventArgs) Handles BtnPrint_A.Click
        'PrintRec.PrinterSettings.PrinterName = My.Settings.printer
        ' PrintRec.Print()
        BillRecord()

    End Sub

    Private Sub Combo_A_Enter(sender As Object, e As EventArgs) Handles Combo_A.Enter

    End Sub
End Class