Public Class fSearch

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim OrderNo As String = fLoadSheet.GetOrderNo(tbOrderNo.Text.Trim)
        Dim LoadSheetNo As String = GetLoadSheetNo(OrderNo)
        If LoadSheetNo Is Nothing Then
            MsgBox("Order No " & OrderNo & " was not found.", MsgBoxStyle.OkOnly, "Order No Not Found")
            Exit Sub
        End If
        fLoadSheet.PopulateDataGridView(LoadSheetNo)
    End Sub
    Private Function GetLoadSheetNo(OrderNo As String)
        Dim sSQL As String = "Select Distinct load_sheet_no from OELOADSHEET_MAS where ord_no = '" & OrderNo & "'"
        Dim LoadSheetNo As String = DAC.Execute_Scalar(sSQL, cn)
        Return LoadSheetNo
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim OrderNo As String = fLoadSheet.GetOrderNo(tbOrderNo.Text.Trim)
        Dim LoadSheetNo As String = GetLoadSheetNo(OrderNo)

        If LoadSheetNo Is Nothing Then
            MsgBox("Order No " & OrderNo & " was not found.", MsgBoxStyle.OkOnly, "Order No Not Found")
            Exit Sub
        End If

        fLoadSheet.PreviewReport(LoadSheetNo)
    End Sub

    Private Sub tbOrderNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbOrderNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim OrderNo As String = fLoadSheet.GetOrderNo(tbOrderNo.Text.Trim)
            Dim LoadSheetNo As String = GetLoadSheetNo(OrderNo)
            fLoadSheet.PopulateDataGridView(LoadSheetNo)
            tbOrderNo.Text = OrderNo
        End If

    End Sub
End Class