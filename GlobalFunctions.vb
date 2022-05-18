Module Global_Functions

    Public Function conn(con)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Return Nothing
    End Function

    Function Form_OrderLoad()
        Form_Order.TB_Item_MasterTableAdapter.Fill(Form_Order.DS_Menu.TB_Item_Master)
        Return Nothing
    End Function
    Function Report_Load()
        Reports.TB_Bill_RecordsTableAdapter.Fill(Reports.DB_BillRecords.TB_Bill_Records)
        Reports.GD_BillRecords.Refresh()
        Return Nothing
    End Function
End Module
