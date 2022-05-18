Imports System.Data.SqlClient
Imports System.Data

Public Class Item_Master

    Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("constr").ConnectionString)
    Dim cmd As SqlCommand
    Dim str As String
    Dim ds As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim tbl As DataTable
    Dim id As Integer
    Private Sub Item_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_BillingDataSet1.TB_Item_Master' table. You can move, or remove it, as needed.
        Me.TB_Item_MasterTableAdapter.Fill(Me.DB_BillingDataSet1.TB_Item_Master)
        'TODO: This line of code loads data into the 'DB_BillingDataSet.TB_Item_Mater' table. You can move, or remove it, as needed.
        ' Me.TB_Item_MaterTableAdapter.Fill(Me.DB_BillingDataSet.TB_Item_Mater)

    End Sub

    Private Sub FillRecord()
        str = "select * from Tb_Item_Master"
        cmd = New SqlCommand(str, con)
        Dim da = New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        DG_All_Items.DataSource = dt
        ' EditItemForm.DG_EditItems.DataSource = dt
        'DeleteItemForm.DG_DeleteItems.DataSource = dt
    End Sub



    Private Sub RdoBtn_Add_Item_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Add_Item.CheckedChanged
        Btn_Add.Visible = True
        Btn_Update.Visible = False
        Btn_Delete.Visible = False
        Combo_Type.Enabled = True
        Txt_ItemName.ReadOnly = False
        Txt_ItemPrice.ReadOnly = False
        Combo_Type.Text = ""
        Txt_ItemName.Text = ""
        Txt_ItemPrice.Text = ""

        ErrMsgType.Visible = False
        ErrMsgItemName.Visible = False
        ErrMsgPrice.Visible = False

    End Sub

    Private Sub RdoBtn_Edit_Item_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Edit_Item.CheckedChanged
        Btn_Add.Visible = False
        Btn_Update.Visible = True
        Btn_Delete.Visible = False
        Combo_Type.Enabled = True
        Txt_ItemName.ReadOnly = False
        Txt_ItemPrice.ReadOnly = False

        ErrMsgType.Visible = False
        ErrMsgItemName.Visible = False
        ErrMsgPrice.Visible = False

    End Sub

    Private Sub RdoBtn_Delete_CheckedChanged(sender As Object, e As EventArgs) Handles RdoBtn_Delete.CheckedChanged
        Btn_Add.Visible = False
        Btn_Update.Visible = False
        Btn_Delete.Visible = True

        Combo_Type.Enabled = False
        Txt_ItemName.ReadOnly = True
        Txt_ItemPrice.ReadOnly = True

        ErrMsgType.Visible = False
        ErrMsgItemName.Visible = False
        ErrMsgPrice.Visible = False
    End Sub

    Private Sub DG_All_Items_MouseClick(sender As Object, e As MouseEventArgs) Handles DG_All_Items.MouseClick
        If RdoBtn_Add_Item.Checked Then
            Return
        End If
        Dim i As Integer
        i = DG_All_Items.CurrentRow.Index
        id = DG_All_Items.Item(0, i).Value
        Try
            Combo_Type.Text = DG_All_Items.Item(1, i).Value
            Txt_ItemName.Text = DG_All_Items.Item(2, i).Value
            Txt_ItemPrice.Text = DG_All_Items.Item(3, i).Value
        Catch
            Return
        End Try
    End Sub

    Public Function checkform()
        If Combo_Type.Text = "" Or Txt_ItemName.Text = "" Or Txt_ItemPrice.Text = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        If Not checkform() Then
            Return
        End If
        str = "select * from Tb_Item_Master where Item_Name=@Itemname"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Itemname", Txt_ItemName.Text)
        End With
        conn(con)
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            MsgBox("Item already Exist !")
            dr.Close()
            Return

        End If
        dr.Close()

        str = "insert into Tb_Item_Master values (@Type,@Itemname,@Price)"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Type", Combo_Type.Text)
            .AddWithValue("@Itemname", Txt_ItemName.Text)
            .AddWithValue("@Price", Txt_ItemPrice.Text)
        End With

        conn(con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Added Succesfully !")
        con.Close()
        FillRecord()
        Form_OrderLoad()


    End Sub
    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        If Not checkform() Then
            Return
        End If

        str = "update Tb_Item_Master set Type=@Type,Item_Name=@Itemname,Price=@Price where Id=@id"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Type", Combo_Type.Text)
            .AddWithValue("@Itemname", Txt_ItemName.Text)
            .AddWithValue("@Price", Math.Round(CDbl((Txt_ItemPrice.Text)), 2))
            .AddWithValue("@Id", id)
        End With

        conn(con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Updated Succesfully !")
        con.Close()
        FillRecord()
        Form_OrderLoad()
    End Sub
    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click

        str = "delete from Tb_Item_Master where Id=@id"
        cmd = New SqlCommand(str, con)
        With cmd.Parameters
            .AddWithValue("@Id", id)
        End With

        conn(con)
        cmd.ExecuteNonQuery()
        MsgBox("Item Deleted Succesfully !")
        con.Close()
        FillRecord()
        Form_OrderLoad()

    End Sub

    Private Sub Combo_Type_Leave(sender As Object, e As EventArgs) Handles Combo_Type.Leave
        If Combo_Type.Text = "" Then
            ErrMsgType.Visible = True
        End If
    End Sub

    Private Sub Txt_ItemName_Leave(sender As Object, e As EventArgs) Handles Txt_ItemName.Leave
        If Txt_ItemName.Text = "" Then
            ErrMsgItemName.Visible = True
        End If
    End Sub

    Private Sub Txt_ItemPrice_Leave(sender As Object, e As EventArgs) Handles Txt_ItemPrice.Leave
        If Txt_ItemPrice.Text = "" Then
            ErrMsgPrice.Visible = True
        End If
    End Sub

    Private Sub Combo_Type_Enter(sender As Object, e As EventArgs) Handles Combo_Type.Enter
        ErrMsgType.Visible = False
    End Sub

    Private Sub Txt_ItemName_Enter(sender As Object, e As EventArgs) Handles Txt_ItemName.Enter
        ErrMsgItemName.Visible = False
    End Sub

    Private Sub Txt_ItemPrice_Enter(sender As Object, e As EventArgs) Handles Txt_ItemPrice.Enter
        ErrMsgPrice.Visible = False
    End Sub

    Private Sub Txt_ItemPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_ItemPrice.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            'Ascle.KeyChar) Allow backspace
            '(asc(Keychar) - 48 And Asc(e.KeyChar) 57) // Allow number from 0 to 9 "Asc(e.KeyChar) = 46 / Allow decimal dot
        Else
            e.Handled = True
        End If
    End Sub
End Class



'Item Master almost complete , except Then price taxt box