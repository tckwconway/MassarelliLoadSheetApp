'Imports System.Data
'Imports System.Data.SqlClient
''Imports SystemAcctSetting
'Imports System.Text
'Imports System.ComponentModel
'Imports System.Linq
'Imports System.Linq.Expressions
'Imports System.Globalization
'Imports System.Data.Common
'Imports System.Collections.Generic

Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.CrystalReports.Engine.ReportClass
'Imports CrystalDecisions.Shared
'Imports CrystalDecisions.ReportSource
'Imports CrystalDecisions.CrystalReports.ViewerObjectModel
Imports CrystalDecisions.Windows.Forms



Public Class fLoadSheet
    Private cOptionalCriteria As New OptionalCriteria
    Private bIsValidAddress As Boolean
    Private bIsClearing As Boolean
    Private loadsheet As New LoadSheetData
    Private hitContextMenu As DataGridView.HitTestInfo
    Public ls As LoadSheetData

    Const InventoryGL As String = "10400000" ' this is the mn_no in table SYACTFIL_SQL
    Const EmptyGL As String = "00000000"     ' this is the sb_no and db_no in table SYACTFIL_SQL, sub GL numbers, both "00000000" because sb_no and db_no values are not used for any GL Acct Nos at Massarelli...
    Const sCheckMark1 As Char = ChrW(&H2611)  'Check with box
    Const sCheckMark2 As Char = ChrW(&H2713)  'Light check mark
    Const sCheckMark3 As Char = ChrW(&H2714)  'Heavy check mark
    Const sGlyphDown As Char = ChrW(&H25BC) 'Glyph (down pointing triangle)
    Const sGlyphUp As Char = ChrW(&H25B2) 'Glyph (up pointing triangle)
    Const sElipsis As Char = ChrW(&H2026) 'Elipsis Horizontal
    Const sArrowTriangleLeft As Char = ChrW(&H25C0) 'Triangle Arrow Pointing Left
    Const sArrowTriangleRight As Char = ChrW(&H25B6) 'Triangle Arrow Pointing Left
    Const sXLargeCrossMark As Char = ChrW(&H274C) 'Triangle Arrow Pointing Left
    Const sXSmallCrossMark As Char = ChrW(&H2A2F) 'Triangle Arrow Pointing Left


    Private Sub fLoadSheet_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        MacStartup()
        LoadDataGridView()
        LINQ_GetShipViaList()
        With tbOrderNo
            .AcceptsTab = True 'this fires KeyDown event when the TAB is pressed (otherwise, it skips the Tab Key)
            .Multiline = True
            .Height = tbLocation.Height
        End With
        With tbProNumber
            .AcceptsTab = True
            .Multiline = True
            .Height = tbLocation.Height
        End With
        With tbCrateQty
            .AcceptsTab = True
            .Multiline = True
        End With
        btnClear.Text = sXLargeCrossMark
        With Timer1
            .Interval = 50
            .Enabled = True
        End With

    End Sub

    Private Sub LoadDataGridView()

        'DataGridView ...
        With DataGridView1

            '.AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True
            .RowHeadersVisible = True
            .RowHeadersWidth = 24
            .DataSource = Nothing
            .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            'Segoe UI Semibold, 15pt, style=Bold
            .DefaultCellStyle.Font = New Font("Segoe UI Semibold", 12)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .EnableHeadersVisualStyles = False

            If .RowCount > 0 Then .Rows.Clear()
            If .ColumnCount > 0 Then .Columns.Clear()

            With .Columns(.Columns.Add("OrderNo", "Order #"))
                '.MinimumWidth = 100
                .ToolTipText = "Order Number"
                .DataPropertyName = "order_no"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Width = 100
                '.ReadOnly = True
                '.Visible = False
            End With

            With .Columns(.Columns.Add("Customer", "Customer"))
                '.MinimumWidth = 250
                .ToolTipText = "Customer"
                .DataPropertyName = "customer"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Width = 250
                '.ReadOnly = True
                ' .Visible = False
            End With

            With .Columns(.Columns.Add("ShipToLocation", "ShipTo Location"))
                '.MinimumWidth = 250
                .ToolTipText = "ShipTo Location - City State Zip"
                .DataPropertyName = "shiptolocation"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.fill
                .Width = 250
                '.ReadOnly = True
                ' .Visible = False
            End With

            With .Columns(.Columns.Add("LocName", "Loc"))
                '.MinimumWidth = 75
                .DataPropertyName = "loc_name"
                .ToolTipText = "Crate Location"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Width = 75
                '.ReadOnly = True
            End With

            With .Columns(.Columns.Add("CrateQty", "Crates"))
                .ToolTipText = "Crate Quantity"
                .HeaderCell.ToolTipText = .ToolTipText
                .DataPropertyName = "crate_qty"
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleCenter
                    .WrapMode = DataGridViewTriState.True
                    .Format = "N0"
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                '.MinimumWidth = 30
                .Width = 75
                '.ReadOnly = True
            End With

            With .Columns(.Columns.Add("ProNo", "Pro #"))
                '.MinimumWidth = 100
                .DataPropertyName = "pro_no"
                .ToolTipText = "Pro Number"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Width = 100
                '.ReadOnly = True
            End With

            With .Columns(.Columns.Add("SearchOrdNo", "SearchOrdNo"))
                '.MinimumWidth = 100
                .DataPropertyName = "search_ord_no"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Width = 75
                .Visible = False
            End With

            With .Columns(.Columns.Add("Sequence", "Seq"))
                '.MinimumWidth = 100
                .DataPropertyName = "sequence"
                .HeaderCell.ToolTipText = .ToolTipText
                With .DefaultCellStyle
                    .Alignment = DataGridViewContentAlignment.MiddleLeft
                    .WrapMode = DataGridViewTriState.True
                End With
                '.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Width = 25
                .Visible = False
            End With


            ''Turn off sorting
            'Dim i As Integer
            'For i = 0 To .Columns.Count - 1
            '    .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
            'Next i
        End With

    End Sub

    Friend Function LINQ_GetShipViaList() As List(Of VLQ_ShipViaCode)
        Dim dc As New LQ_ShipViaListDataContext(cn)

        Dim shpvialst = _
    (From r In dc.VLQ_ShipViaCodes _
     Order By r.ship_via
     Select r).ToList

        For Each o In shpvialst
            With cboShipVia
                .Items.Add(o.ship_via.ToString)
            End With
        Next

            Return Nothing

    End Function

    Private Sub Timer1_Tick(sender As Object, e As System.EventArgs) Handles Timer1.Tick
        Dim tmr As Timer = CType(sender, Timer)
        tmr.Enabled = False
        cboShipVia.Focus()

    End Sub

    Private Sub cboShipVia_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboShipVia.DropDownClosed
        'Dim cbo As ComboBox = CType(sender, ComboBox)
        'Try
        '    Dim shpvia As String = cbo.SelectedItem.Substring(0, cbo.Text.IndexOf("|") - 1).Trim
        '    txtShipViaCode.Text = shpvia.ToUpper

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub cboShipVia_Enter(sender As Object, e As System.EventArgs) Handles cboShipVia.Enter
        Dim cbo As ComboBox = CType(sender, ComboBox)
        cbo.BackColor = Color.FromArgb(255, 255, 192) 'Color.FromArgb(255, 255, 128)

        lblShipVia.BackColor = Color.FromArgb(255, 255, 192) 'SystemColors.Window 'Color.FromArgb(255, 255, 128)
        lblShipVia.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub cboShipVia_Leave(sender As Object, e As System.EventArgs) Handles cboShipVia.Leave
        Dim cbo As ComboBox = CType(sender, ComboBox)
        cbo.BackColor = SystemColors.Window
        lblShipVia.BackColor = SystemColors.Control
        lblShipVia.BorderStyle = BorderStyle.None
        
        
    End Sub

    Private Sub TextBox_Enter(sender As Object, e As System.EventArgs) Handles tbOrderNo.Enter, tbCrateQty.Enter, tbProNumber.Enter
        Dim txt As TextBox = CType(sender, TextBox)
        txt.BackColor = Color.FromArgb(255, 255, 192) 'Color.FromArgb(255, 255, 128)

        Select Case txt.Name
            Case tbOrderNo.Name
                With lblOrderNo
                    .BackColor = Color.FromArgb(255, 255, 192) 'SystemColors.Window 'Color.FromArgb(255, 255, 128)
                    .BorderStyle = BorderStyle.FixedSingle
                End With
            Case tbProNumber.Name
                With lblProNo
                    .BackColor = Color.FromArgb(255, 255, 192) 'SystemColors.Window 'Color.FromArgb(255, 255, 128)
                    .BorderStyle = BorderStyle.FixedSingle
                End With
            Case tbCrateQty.Name
                With lblPallets
                    .BackColor = Color.FromArgb(255, 255, 192) 'SystemColors.Window 'Color.FromArgb(255, 255, 128)
                    .BorderStyle = BorderStyle.FixedSingle
                End With
                tbCrateQtyBackField.BackColor = Color.FromArgb(255, 255, 192)
        End Select

    End Sub

    Private Sub TextBox_Leave(sender As Object, e As System.EventArgs) Handles tbOrderNo.Leave, tbCrateQty.Leave, tbProNumber.Leave
        Dim txt As TextBox = CType(sender, TextBox)
        txt.BackColor = SystemColors.Window

        Select Case txt.Name
            Case tbOrderNo.Name
                With lblOrderNo
                    .BackColor = SystemColors.Control
                    .BorderStyle = BorderStyle.None
                End With
            Case tbProNumber.Name
                With lblProNo
                    .BackColor = SystemColors.Control
                    .BorderStyle = BorderStyle.None
                End With

            Case tbCrateQty.Name
                With lblPallets
                    .BackColor = SystemColors.Control
                    .BorderStyle = BorderStyle.None
                End With
                tbCrateQtyBackField.BackColor = SystemColors.Window
        End Select
    End Sub
    Private Sub tbOrderNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbOrderNo.KeyDown
        'Barcode Scanner fires the KEYDOWN EVENT

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            e.SuppressKeyPress = True
            If tbOrderNo.Text = "" Then
                tbProNumber.Focus()
            Else
                LoadData()
            End If

        ElseIf e.KeyCode = Keys.Escape Then
            'If Escape is presses, clear everything...
            ClearControls()
            tbOrderNo.Focus()
            Exit Sub
        End If
    End Sub
   

    Private Sub LoadData()
        If bIsClearing = True Then Exit Sub
        Try
            Dim dt As New DataTable
            loadsheet = New LoadSheetData
            With loadsheet

                .OrderNo = GetOrderNo(tbOrderNo.Text)
                .ShipVia = txtShipViaCode.Text.Trim
                dt = GetAddressCSZ(loadsheet.OrderNo)
                .Customer = dt(0)("ship_to_name").ToString.Trim
                .ShipToLocation = dt(0)("ship_to_location").ToString.Trim.Replace("-", " ").Trim
                .CrateLocation = GetCrateLocation(dt(0)("crate_location").ToString.Trim)
                .CrateQty = IIf(dt(0)("crate_qty") = 0, 0, dt(0)("crate_qty"))

                tbOrderNo.Text = loadsheet.OrderNo
                tbShipToName.Text = ""
                tbShipToName.Text = .Customer
                tbShipToLocation.Text = .ShipToLocation.Replace("-", " ").Trim
                tbLocation.Text = loadsheet.CrateLocation
                tbCrateQty.Text = IIf(.CrateQty = 0, "", .CrateQty.ToString.Trim)

            End With
            tbProNumber.Focus()

        Catch ex As Exception

        End Try
        
    End Sub
    Private Function GetCrateLocation(crate_loc As String) As String
        Dim loc As String = ""
        If crate_loc Is Nothing OrElse crate_loc = "" Then
            loc = "FACTORY"
        ElseIf IsNumeric(crate_loc) = True Then
            loc = "ROW " & crate_loc.ToString.Trim
        Else
            loc = crate_loc.ToString.Trim
        End If

        Return loc

    End Function

    Private Sub RemoveRowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveRowToolStripMenuItem.Click
        Dim cms As ContextMenuStrip = CType(CType(sender, ToolStripMenuItem).GetCurrentParent, ContextMenuStrip)

        Dim dgv As DataGridView = CType(cms.SourceControl, DataGridView)

        Dim rw As Integer = hitContextMenu.RowIndex

        dgv.Rows.Remove(dgv.Rows(rw))

    End Sub

    Public Sub PopulateDataGridView(dgv As DataGridView)

        With dgv
            .Rows.Add()
            Dim rw As Integer = dgv.rows.count - 1
            With .Rows(rw)
                .Cells("OrderNo").Value = loadsheet.OrderNo
                .Cells("Customer").Value = loadsheet.Customer
                .Cells("ShipToLocation").Value = loadsheet.ShipToLocation
                .Cells("LocName").Value = loadsheet.CrateLocation
                .Cells("CrateQty").Value = loadsheet.CrateQty
                .Cells("ProNo").Value = loadsheet.ProNo
                .Cells("SearchOrdNo").Value = loadsheet.OrderNo
                .Cells("Sequence").Value = 1
            End With

        End With

        With Timer3
            .Interval = 100
            .Enabled = True
        End With


    End Sub


    Public Sub PopulateDataGridView(LoadSheetNo As String)

        Dim sSQL As String = "Select load_sheet_no, ord_no, ship_to_name, ship_to_addr, loc_desc, pallet_qty, ship_via_cd, pro_number, search_ord_no, sequence, create_dt from OELOADSHEET_MAS where load_sheet_no = '" & LoadSheetNo & "' "
        Dim ds As New DataSet
        Dim dt As DataTable = DAC.ExecuteSQL_DataSet(sSQL, cn, "LoadSheet")

        If dt.Rows.Count = 0 Then
            MsgBox("Order No was not found.", MsgBoxStyle.OkOnly, "Order Number Not Found")
            Exit Sub
        End If

        loadsheet.LoadSheet = LoadSheetNo

        LoadDataGridView()
        Dim dgv As DataGridView = CType(DataGridView1, DataGridView)

        Dim shipviacode As String = dt(0)("ship_via_cd")
        txtShipViaCode.Text = shipviacode


        For Each r As DataRow In dt.Rows
            With dgv
                .Rows.Add()
                Dim rw As Integer = dgv.Rows.Count - 1
                With .Rows(rw)
                    .Cells("OrderNo").Value = r("ord_no")
                    .Cells("Customer").Value = r("ship_to_name")
                    .Cells("ShipToLocation").Value = r("ship_to_addr")
                    .Cells("LocName").Value = r("loc_desc")
                    .Cells("CrateQty").Value = r("pallet_qty")
                    .Cells("ProNo").Value = r("pro_number")
                    .Cells("SearchOrdNo").Value = r("search_ord_no")
                    .Cells("Sequence").Value = r("sequence")
                End With

            End With
        Next

        btnPrint.Enabled = True
        btnSave.Enabled = False
    End Sub

    Public Function GetOrderNo(ordno As String) As String
        'Pad with zeros to be sure it's a valid order_no
        Try

            If ordno.Length <> 8 Then
                ordno = ("00" & ordno)
                ordno = ordno.Substring(ordno.Length - 8)
            End If

        Catch ex As Exception

        End Try
        'clear barcode scanner char
        ordno = System.Text.RegularExpressions.Regex.Replace(ordno, vbCrLf, "")
        ordno = System.Text.RegularExpressions.Regex.Replace(ordno, vbCr, "")
        ordno = System.Text.RegularExpressions.Regex.Replace(ordno, vbLf, "")
        ordno = System.Text.RegularExpressions.Regex.Replace(ordno, "[^a-zA-Z0-9_ .+]", "")

        Return ordno

    End Function

    Private Sub SaveLoadSheet()
        If DataGridView1.Rows.Count = 0 Then Exit Sub
        Dim dt As DataTable = GetDataTableFromDataGridView(DataGridView1)
        Dim sSQL As String = "Select  distinct Cast(max(IsNull(load_sheet_no, 0)) as int) + 1 as next_no from OELOADSHEET_MAS"
        Dim LoadSheetNo As Object = DAC.Execute_Scalar(sSQL, cn)
        If LoadSheetNo Is DBNull.Value Then LoadSheetNo = 1 Else LoadSheetNo = LoadSheetNo + 1 ' this only seeds the first entry
        Dim sLoadSheetNo As String = ("00000000" & LoadSheetNo.ToString.Trim).Substring(LoadSheetNo.ToString.Length, 8)
        loadsheet.LoadSheet = sLoadSheetNo
        For Each rw As DataRow In dt.Rows
            ls = New LoadSheetData
            'See if Order is on a LoadSheet already...
            Dim isOnLoadSheet As Integer = DAC.Execute_Scalar("Select Count(*) from OELOADSHEET_MAS where ord_no = '" & rw("OrderNo").ToString.Trim & "'", cn)

            With ls
                .State = IIf(isOnLoadSheet = 0, "New", "Modify")
                .LoadSheetNo = sLoadSheetNo
                .OrderNo = rw("OrderNo").ToString.Trim
                .Customer = rw("Customer").ToString.Trim
                .ShipToLocation = rw("ShipToLocation").ToString.Trim.Replace("-", " ").Trim
                .CrateLocation = rw("LocName").ToString.Trim
                .CrateQty = IIf(rw("CrateQty") = 0 Or rw("CrateQty") = "", 0, rw("CrateQty"))
                .ProNo = rw("ProNo").ToString.Trim
                .ShipVia = txtShipViaCode.Text.Trim
                .CreateDate = GetMacolaDate(Now.Year.ToString, Format(Now.Month.ToString.PadLeft(2, "0")), Format(Now.Day.ToString.PadLeft(2, "0")))
                .SearchOrdNo = rw("SearchOrdNo").ToString.Trim
                .Sequence = rw("Sequence")
            End With

            DAC.ExecuteSaveSP(My.Resources.SP_spOESaveLoadSheet_MAS, cn, _
                              DAC.Parameter(My.Resources.Param_iLoadSheetNo, ls.LoadSheetNo, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iOrdNo, ls.OrderNo, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iShipToName, ls.Customer, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iShipToAddr, ls.ShipToLocation, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iLocDesc, ls.CrateLocation, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iPalletQty, ls.CrateQty, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iShipVia, ls.ShipVia, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iProNumber, ls.ProNo, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iCreateDate, ls.CreateDate, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iSearchOrdNo, ls.SearchOrdNo, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iSequence, ls.Sequence, Data.ParameterDirection.Input), _
                              DAC.Parameter(My.Resources.Param_iState, ls.State, ParameterDirection.Input))

        Next

    End Sub
 
    Private Function GetDataTableFromDataGridView(dgv As DataGridView) As DataTable
        Dim dt As New DataTable()

        ' add the columns to the datatable            
        If dgv IsNot Nothing Then

            For i As Integer = 0 To dgv.Columns.Count - 1
                dt.Columns.Add(dgv.Columns(i).Name.ToString)
            Next
        End If

        '  add each of the data rows to the table
        For Each row As DataGridViewRow In dgv.Rows
            Dim dr As DataRow
            dr = dt.NewRow()

            For i As Integer = 0 To row.Cells.Count - 1
                If row.DataGridView.Columns(i).Name = "CrateQty" Then
                    If row.Cells(i).Value Is Nothing Then dr(i) = 0 Else dr(i) = row.Cells(i).Value
                Else
                    If row.Cells(i).Value Is Nothing Then dr(i) = "" Else dr(i) = row.Cells(i).Value.ToString.Trim
                End If


            Next
            dt.Rows.Add(dr)
        Next
        Return dt
    End Function
    Private Sub ClearControls()

        For Each ctl As Control In Panel5.Controls
            If TypeOf ctl Is TextBox Then
                ctl.Text = ""
            End If
        Next

    End Sub

    Private Function GetAddressCSZ(orderNo As String) As DataTable
        Dim dt As New DataTable
        

        dt = DAC.ExecuteSP_DataTable(My.Resources.SP_spOEGetOrdHdrBillShipCSZ, cn, _
                                     DAC.Parameter(My.Resources.PARAM_ord_no, orderNo, Data.ParameterDirection.Input), _
                                     DAC.Parameter(My.Resources.PARAM_billorship, "SHIP", Data.ParameterDirection.Input))

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MsgBox("Order_no " & tbOrderNo.Text & " was not found.", MsgBoxStyle.OkOnly, "Order Not Found.")
            tbOrderNo.Text = ""
            Return Nothing
        End If

        Return dt

    End Function

    Private Sub tbProNumber_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbProNumber.KeyDown

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Dim txt As TextBox = CType(sender, TextBox)

            e.SuppressKeyPress = True
            loadsheet.ProNo = txt.Text.Trim
            With Timer2
                .Interval = 100
                .Enabled = True
            End With
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As System.EventArgs) Handles Timer2.Tick
        Dim tmr As Timer = CType(sender, Timer)

        tmr.Enabled = False
        tbCrateQty.Focus()
    End Sub

    Private Sub tbCrateQty_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles tbCrateQty.KeyDown
        Dim txt As TextBox = CType(sender, TextBox)
        Dim dgv As DataGridView = CType(DataGridView1, DataGridView)

        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If Not IsNumeric(tbCrateQty.Text) Then
                MsgBox("Crate Qty must be a Number.  Value is " & tbCrateQty.Text.Trim & ".", MsgBoxStyle.OkOnly, "Qty is not a Number")
                tbCrateQty.Text = ""
                Exit Sub
            End If
            loadsheet.CrateQty = txt.Text.Replace(Chr(13), "")
            PopulateDataGridView(dgv)

            btnSave.Enabled = True
            btnPrint.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As System.EventArgs) Handles Timer3.Tick
        Dim tmr As Timer = CType(sender, Timer)
        tmr.Enabled = False

        UnselectDataGridViewRows(DataGridView1)

        bIsClearing = True
        ClearControls()
        bIsClearing = False

        tbOrderNo.Focus()
    End Sub

    Private Sub UnselectDataGridViewRows(ByVal dgv As DataGridView)
        For Each rw As DataGridViewRow In dgv.Rows
            rw.Selected = False
            For Each cel As DataGridViewCell In rw.Cells
                With cel
                    .Selected = False

                End With

            Next
        Next
        dgv.EndEdit()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearControls()
    End Sub

    Private Sub btnClear_MouseEnter(sender As Object, e As System.EventArgs) Handles btnClear.MouseEnter, btnClearAll.MouseEnter
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.OrangeRed
        btn.ForeColor = Color.White

    End Sub

    Private Sub btnClear_MouseLeave(sender As Object, e As System.EventArgs) Handles btnClear.MouseLeave, btnClearAll.MouseLeave
        Dim btn As Button = CType(sender, Button)
        btn.BackColor = SystemColors.Control
        btn.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub cboShipVia_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboShipVia.SelectedValueChanged
        Dim cbo As ComboBox = CType(sender, ComboBox)
        Try
            Dim shpvia As String = cbo.SelectedItem.Substring(0, cbo.Text.IndexOf("|") - 1).Trim
            txtShipViaCode.Text = shpvia.ToUpper

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        DataGridView1.AutoResizeRow(e.RowIndex, DataGridViewAutoSizeRowMode.AllCellsExceptHeader)
    End Sub

    'Private Sub DataGridView1_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.CurrentCellDirtyStateChanged
    '    'btnPrint.Enabled = False
    '    'btnSave.Enabled = True
    'End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If Me.DataGridView1.CurrentCell.ColumnIndex = 0 And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler (tb.KeyDown), AddressOf TextBox_KeyDown

        End If

    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Dim dgv As DataGridView = CType(DataGridView1, DataGridView)
            UnselectDataGridViewRows(dgv)
            'flag = True
        End If
    End Sub

    'Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    'e.Handled = flag
    '    'flag = False
    'End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Dim dgv As DataGridView = CType(sender, DataGridView)
            UnselectDataGridViewRows(dgv)
        End If

    End Sub


    Private Sub DataGridView1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown
        Dim dgv As DataGridView = CType(sender, DataGridView)
        If e.Button = MouseButtons.Right Then
            'Dim ht As DataGridView.HitTestInfo
            'ht = dgv.HitTest(e.X, e.Y)
            hitContextMenu = dgv.HitTest(e.X, e.Y)
        End If

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveLoadSheet()
        btnPrint.Enabled = True
        btnSave.Enabled = False
    End Sub

    Public Shared Function GetMacolaDate(Year As String, Month As String, Day As String) As Integer
        Return CInt(Year & Month & Day)
    End Function

    Public Shared Function GetMacolaTime(Hour As String, Minute As String, Second As String) As Integer
        Return CInt(Hour & Minute & Second)
    End Function

    Public Sub PreviewReport(LoadSheetNo As String)

        Try
            Dim rptdoc = New ReportDocument

            Cursor = Cursors.WaitCursor

            rptdoc.Load(App_Path() & "LoadSheetReport.rpt")

            rptdoc.RecordSelectionFormula = "{OELOADSHEET_MAS.load_sheet_no} = '" & loadsheet.LoadSheet & "'"
            rptdoc.SetDatabaseLogon("sa", "C@sT1nST0nE")

            Dim crv As New CRViewer

            With crv.crLoadSheetViewer
                .ToolPanelView = ToolPanelViewType.None
                .AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
                .AutoSize = True
                .SelectionFormula = "{OELOADSHEET_MAS.load_sheet_no} = '" & loadsheet.LoadSheet & "'"
                .ReportSource = rptdoc
            End With
            crv.Show()

        Catch ex As Exception

            MsgBox("The Load Sheet report was not found.  The Load Sheet Report, LoadSheetReport.rpt, must be located at " & Application.StartupPath & ".  ", MsgBoxStyle.OkOnly, "Load Sheet Report on Network Drive not found.")
            MsgBox(Application.StartupPath & " - " & ex.Message)
            Cursor = Cursors.Default
        End Try

        Cursor = Cursors.Default

    End Sub
    Public Function App_Path() As String
        Return System.AppDomain.CurrentDomain.BaseDirectory()
    End Function
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Cursor = Cursors.WaitCursor
        Try
            PreviewReport(loadsheet.LoadSheet)
        Catch ex As Exception
            Cursor = Cursors.Default
        End Try
        Cursor = Cursors.Default

    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        fSearch.Show()
        fSearch.BringToFront()
    End Sub

    Private Sub btnClearAll_Click(sender As System.Object, e As System.EventArgs) Handles btnClearAll.Click
        LoadDataGridView()
        ClearControls()
        txtShipViaCode.Text = ""
        cboShipVia.SelectedIndex = -1
        btnSave.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Sub InsertCustomerCommentToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InsertCustomerCommentToolStripMenuItem.Click
        Dim dgv As DataGridView = CType(DataGridView1, DataGridView)
        Dim rw As Integer = hitContextMenu.RowIndex
        Dim maxsequence_no As Integer = 1
        Dim searchordno As String = dgv.Rows(rw).Cells("SearchOrdNo").Value.ToString.Trim

        For Each r As DataGridViewRow In dgv.Rows
            If r.Cells("SearchOrdNo").Value = searchordno Then
                maxsequence_no = r.Cells("Sequence").Value
            End If
        Next


        With dgv
            .Rows.Insert(rw + 1, 1)
            .Rows(rw + 1).Cells("SearchOrdNo").Value = .Rows(rw).Cells("SearchOrdNo").Value.ToString.Trim
            .Rows(rw + 1).Cells("Sequence").Value = maxsequence_no + 1
            .Rows(rw + 1).Cells("Customer").Value = "COMMENT:"
        End With


    End Sub

End Class

Public Class LoadSheetData
    Public ShipVia As String
    Public OrderNo As String
    Public Customer As String
    Public ShipToLocation As String
    Public CrateLocation As String
    Public CrateQty As Integer
    Public ProNo As String
    Public CreateDate As Integer
    Public LoadSheetNo As String
    Public State As String
    Public SearchOrdNo As String
    Public Sequence As Integer

    Public Sub New()
        ShipVia = ""
        OrderNo = ""
        Customer = ""
        ShipToLocation = ""
        CrateLocation = ""
        CrateQty = 0
        ProNo = ""
        CreateDate = 0
        LoadSheetNo = ""
        State = ""
        SearchOrdNo = ""
        Sequence = 0
    End Sub
    Public Sub Clear()
        ShipVia = ""
        OrderNo = ""
        Customer = ""
        ShipToLocation = ""
        CrateLocation = ""
        CrateQty = 0
        ProNo = ""
        CreateDate = 0
        LoadSheetNo = ""
        State = ""
        SearchOrdNo = ""
        Sequence = 0
    End Sub

    Private mLoadSheet As String
    Public Property LoadSheet() As String
        Get
            Return mLoadSheet
        End Get
        Set(ByVal value As String)
            mLoadSheet = value
        End Set
    End Property

End Class
Public Class OptionalCriteria

    Public DBName As String
    Public DefaultDB As String
    Public CurrentDB As String
    Public mOrderNo As String
    Public mShipToName As String
    Public mShipToAddr1 As String
    Public mShipToAddr2 As String
    Public mShipToAddr3 As String
    Public mShipToCountry As String
    Public mShipAddressForLabel As String
    Public mShippingDate As String
    Public mShippingMonth As String
    Public mPalletCount As String
    Public mNofPalletCount As String

    Public Sub Clear()
        mOrderNo = ""
        mShipToName = ""
        mShipToAddr1 = ""
        mShipToAddr2 = ""
        mShipToAddr3 = ""
        mShipToCountry = ""
        mShippingDate = ""
        mShippingMonth = ""
        mPalletCount = ""
        mNofPalletCount = ""
    End Sub

End Class