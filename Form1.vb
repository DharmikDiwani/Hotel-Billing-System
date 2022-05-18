Imports System.Data.SqlClient
Imports System.Data

Public Class Form_Order
    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable
    Dim ordertbl As New DataTable
    Dim id As Integer
    Dim i As Integer
    Dim tblno As String
    Dim Tempitemid As Integer
    Dim Tempitemname As String
    Dim Tempquantity As Integer
    Dim Tempprice As Double
    Dim Temptotal As Double


    Public Sub FillRecord()
        str = "select * from Tb_Order_Master where Table_No=@tblno"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@tblno", tblno)
        End With
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        OrderGD.DataSource = dt
        OrderGD.Columns(0).Visible = False
        OrderGD.Columns(1).Visible = False
        GDQT.Rows.Clear()
        Temptotal = 0
        If OrderGD.Rows.Count > 0 Then

            For i As Integer = 0 To OrderGD.Rows.Count - 1
                Temptotal += OrderGD.Rows(i).Cells(6).Value
                GDQT.Rows.Add()
            Next
        End If
        LblTotal.Text = Temptotal

    End Sub


    Private Sub Form_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Menu.TB_Item_Master' table. You can move, or remove it, as needed.
        Me.TB_Item_MasterTableAdapter.Fill(Me.DS_Menu.TB_Item_Master)
        tblno = "A1"
        FillRecord()

    End Sub


    Private Sub Guna2DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Dim row As DataGridViewRow
        row = GDMenu.CurrentRow

        str = "select Price from Tb_Item_Master where Item_Name=@Itemname"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Itemname", GDMenu.CurrentRow.Cells(0).ToString)
        End With
        conn(con)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            GDMenu.CurrentRow.Cells(2) = dr("Price")
            dr.Close()
            Return
        Else

        End If
        dr.Close()

    End Sub
    Private Sub Btn_AddItems_Click(sender As Object, e As EventArgs) Handles Btn_AddItems.Click
        For i = 0 To GDMenu.Rows.Count - 1
            Dim rowalreadyexist As Boolean = False
            Dim check As Boolean
            check = GDMenu.Rows(i).Cells(4).Value
            If check <> False Then
                Dim row As DataGridViewRow = GDMenu.Rows(i)
                Tempitemid = row.Cells(0).Value.ToString()
                Tempitemname = row.Cells(2).Value.ToString()
                Tempprice = row.Cells(3).Value.ToString()
                Tempquantity = 1
                Temptotal = Tempprice
                If OrderGD.Rows.Count > 0 Then
                    For j = 0 To OrderGD.Rows.Count - 1
                        Dim iid, jid As Integer
                        iid = row.Cells(0).Value.ToString()
                        jid = OrderGD.Rows(j).Cells(2).Value.ToString()
                        If iid = jid Then
                            rowalreadyexist = True
                            Exit For
                        End If
                    Next
                    If rowalreadyexist = False Then
                        str = "insert into TB_Order_Master values (@Tblno,@ItemId,@ItemName,@Quantity,@Price,@Total)"
                        cmd = New SqlCommand(str, con)
                        With cmd.Parameters
                            .AddWithValue("@Tblno", tblno)
                            .AddWithValue("@ItemId", Tempitemid)
                            .AddWithValue("@ItemName", Tempitemname)
                            .AddWithValue("@Quantity", Tempquantity)
                            .AddWithValue("@Price", Tempprice)
                            .AddWithValue("@Total", Temptotal)
                        End With

                        conn(con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        FillRecord()
                    End If
                Else
                    str = "insert into TB_Order_Master values (@Tblno,@ItemId,@ItemName,@Quantity,@Price,@Total)"
                    cmd = New SqlCommand(str, con)
                    With cmd.Parameters
                        .AddWithValue("@Tblno", tblno)
                        .AddWithValue("@ItemId", Tempitemid)
                        .AddWithValue("@ItemName", Tempitemname)
                        .AddWithValue("@Quantity", Tempquantity)
                        .AddWithValue("@Price", Tempprice)
                        .AddWithValue("@Total", Temptotal)
                    End With

                    conn(con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    FillRecord()
                End If
            End If

        Next


    End Sub
    Private Sub BtnDeleteAll_Click(sender As Object, e As EventArgs) Handles BtnDeleteAll.Click
        str = "Delete from TB_Order_Master"
        cmd = New SqlCommand(str, con)

        conn(con)
        cmd.ExecuteNonQuery()
        FillRecord()

    End Sub



    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        For i As Integer = 0 To OrderGD.Rows.Count - 1
            Dim tempquant As String
            Dim temptot As Double
            Tempitemid = OrderGD.Rows(i).Cells(2).Value
            tempquant = GDQT.Rows(i).Cells(0).Value
            If String.IsNullOrEmpty(tempquant) Then
                Continue For
            End If
            If tempquant = "D" Then
                str = "delete from TB_Order_Master where Table_No= @tblno  and Item_Id=@itemid"
            Else
                temptot = GDQT.Rows(i).Cells(1).Value
                str = "update  TB_Order_Master set Quantity=@quantity,Total=@total where Table_No= @tblno  and Item_Id=@itemid"

            End If
            cmd = New SqlCommand(str, con)
            With cmd.Parameters
                .AddWithValue("@quantity", tempquant)
                .AddWithValue("@total", temptot)
                .AddWithValue("@tblno", tblno)
                .AddWithValue("@itemid", Tempitemid)
            End With
            conn(con)
            cmd.ExecuteNonQuery()
            con.Close()


        Next
        FillRecord()
        ' MessageBox.Show("Records updated")
    End Sub

    Private Sub GDQT_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles GDQT.CellValueChanged
        For i As Integer = 0 To OrderGD.Rows.Count - 1
            'GDQT.Rows.Add()
            Dim temp As String
            temp = GDQT.Rows(i).Cells(0).Value
            If String.IsNullOrEmpty(temp) Or temp = "D" Then
                Continue For
            End If
            GDQT.Rows(i).Cells(1).Value = (OrderGD.Rows(i).Cells(5).Value.ToString * GDQT.Rows(i).Cells(0).Value.ToString)
        Next
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        For i As Integer = 0 To GDMenu.Rows.Count - 1
            'Dim check As Boolean
            'check = GDMenu.Rows(i).Cells(4).Value
            If GDMenu.Rows(i).Cells(4).Value = True Then
                GDMenu.Rows(i).Cells(4).Value = False
            End If

        Next
    End Sub

    Private Sub Combo_TableAlpha_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_TableAlpha.SelectedIndexChanged, Combo_TableNo.SelectedIndexChanged
        tblno = Combo_TableAlpha.Text + Combo_TableNo.Text
        FillRecord()
    End Sub
End Class
