Public Class Form_MDI
    Private Sub Form_MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function InstanceNewForm(ByRef ParentForm As Form, ByRef Childform As Form) As Boolean

        Dim bOpen As Boolean = False
        Dim frm As Form

        For Each frm In ParentForm.MdiChildren
            If Childform.Name = frm.Name Then
                Childform.Focus()
                bOpen = True
                Exit For
            Else
                frm.Hide()
            End If
        Next

        If Not bOpen Then
            With Childform
                .StartPosition = FormStartPosition.CenterScreen
                .MdiParent = ParentForm
                .Show()
            End With
        End If

        frm = Nothing

        Return bOpen

    End Function

    Private Sub Btn_Order_Click(sender As Object, e As EventArgs) Handles Btn_Order.Click
        InstanceNewForm(Me, Form_Order)
    End Sub

    Private Sub Btn_Table_Click(sender As Object, e As EventArgs) Handles Btn_Table.Click
        InstanceNewForm(Me, Form_Tables)

    End Sub

    Private Sub btn_ItemMaster_Click(sender As Object, e As EventArgs) Handles btn_ItemMaster.Click
        InstanceNewForm(Me, Item_Master)
    End Sub

    Private Sub Btn_Reports_Click(sender As Object, e As EventArgs) Handles Btn_Reports.Click
        InstanceNewForm(Me, Reports)
    End Sub
End Class