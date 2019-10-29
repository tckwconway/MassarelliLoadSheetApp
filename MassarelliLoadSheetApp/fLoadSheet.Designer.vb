<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLoadSheet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLoadSheet))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblPricingType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDivider1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDivider2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCurrentDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDivider3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDefaultDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.tbPreviewPath = New System.Windows.Forms.TextBox()
        Me.tbDataPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertCustomerCommentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbShipToLocation = New System.Windows.Forms.TextBox()
        Me.tbShipToName = New System.Windows.Forms.TextBox()
        Me.tbProNumber = New System.Windows.Forms.TextBox()
        Me.tbOrderNo = New System.Windows.Forms.TextBox()
        Me.lblOrderNo = New System.Windows.Forms.Label()
        Me.lblProNo = New System.Windows.Forms.Label()
        Me.tbCrateQty = New System.Windows.Forms.TextBox()
        Me.lblPallets = New System.Windows.Forms.Label()
        Me.tbCrateQtyBackField = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtShipViaCode = New System.Windows.Forms.TextBox()
        Me.lblShipVia = New System.Windows.Forms.Label()
        Me.cboShipVia = New System.Windows.Forms.ComboBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPricingType, Me.lblDivider1, Me.lblCount, Me.lblDivider2, Me.lblCurrentDB, Me.lblDivider3, Me.lblDefaultDB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 772)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1259, 22)
        Me.StatusStrip1.TabIndex = 61
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPricingType
        '
        Me.lblPricingType.Name = "lblPricingType"
        Me.lblPricingType.Size = New System.Drawing.Size(0, 17)
        '
        'lblDivider1
        '
        Me.lblDivider1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblDivider1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblDivider1.Name = "lblDivider1"
        Me.lblDivider1.Size = New System.Drawing.Size(4, 17)
        '
        'lblCount
        '
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(0, 17)
        '
        'lblDivider2
        '
        Me.lblDivider2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblDivider2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblDivider2.Name = "lblDivider2"
        Me.lblDivider2.Size = New System.Drawing.Size(4, 17)
        '
        'lblCurrentDB
        '
        Me.lblCurrentDB.Name = "lblCurrentDB"
        Me.lblCurrentDB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCurrentDB.Size = New System.Drawing.Size(0, 17)
        Me.lblCurrentDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDivider3
        '
        Me.lblDivider3.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.lblDivider3.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken
        Me.lblDivider3.Name = "lblDivider3"
        Me.lblDivider3.Size = New System.Drawing.Size(4, 17)
        '
        'lblDefaultDB
        '
        Me.lblDefaultDB.Name = "lblDefaultDB"
        Me.lblDefaultDB.Size = New System.Drawing.Size(0, 17)
        Me.lblDefaultDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'tbPreviewPath
        '
        Me.tbPreviewPath.Location = New System.Drawing.Point(1603, 690)
        Me.tbPreviewPath.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPreviewPath.Name = "tbPreviewPath"
        Me.tbPreviewPath.Size = New System.Drawing.Size(67, 22)
        Me.tbPreviewPath.TabIndex = 68
        Me.tbPreviewPath.Visible = False
        '
        'tbDataPath
        '
        Me.tbDataPath.Location = New System.Drawing.Point(1603, 722)
        Me.tbDataPath.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDataPath.Name = "tbDataPath"
        Me.tbDataPath.Size = New System.Drawing.Size(67, 22)
        Me.tbDataPath.TabIndex = 69
        Me.tbDataPath.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1501, 697)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Preview Path"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1501, 731)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Data Path"
        Me.Label4.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1259, 772)
        Me.Panel3.TabIndex = 80
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.DataGridView1.Location = New System.Drawing.Point(0, 222)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1259, 550)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveRowToolStripMenuItem, Me.InsertCustomerCommentToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(251, 52)
        '
        'RemoveRowToolStripMenuItem
        '
        Me.RemoveRowToolStripMenuItem.Name = "RemoveRowToolStripMenuItem"
        Me.RemoveRowToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.RemoveRowToolStripMenuItem.Text = "Remove Row"
        '
        'InsertCustomerCommentToolStripMenuItem
        '
        Me.InsertCustomerCommentToolStripMenuItem.Name = "InsertCustomerCommentToolStripMenuItem"
        Me.InsertCustomerCommentToolStripMenuItem.Size = New System.Drawing.Size(250, 24)
        Me.InsertCustomerCommentToolStripMenuItem.Text = "Insert Customer Comment"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("KaiTi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1259, 222)
        Me.Panel1.TabIndex = 85
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnClearAll)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1137, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(122, 222)
        Me.Panel2.TabIndex = 104
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClearAll.Location = New System.Drawing.Point(9, 160)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(100, 46)
        Me.btnClearAll.TabIndex = 105
        Me.btnClearAll.Text = "Clear"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.Location = New System.Drawing.Point(9, 106)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 46)
        Me.btnSearch.TabIndex = 104
        Me.btnSearch.Text = "Find"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnPrint)
        Me.Panel5.Controls.Add(Me.btnSave)
        Me.Panel5.Controls.Add(Me.lblLocation)
        Me.Panel5.Controls.Add(Me.tbLocation)
        Me.Panel5.Controls.Add(Me.btnClear)
        Me.Panel5.Controls.Add(Me.tbShipToLocation)
        Me.Panel5.Controls.Add(Me.tbShipToName)
        Me.Panel5.Controls.Add(Me.tbProNumber)
        Me.Panel5.Controls.Add(Me.tbOrderNo)
        Me.Panel5.Controls.Add(Me.lblOrderNo)
        Me.Panel5.Controls.Add(Me.lblProNo)
        Me.Panel5.Controls.Add(Me.tbCrateQty)
        Me.Panel5.Controls.Add(Me.lblPallets)
        Me.Panel5.Controls.Add(Me.tbCrateQtyBackField)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(463, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(674, 222)
        Me.Panel5.TabIndex = 88
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(565, 160)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 46)
        Me.btnPrint.TabIndex = 107
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.Location = New System.Drawing.Point(455, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 46)
        Me.btnSave.TabIndex = 98
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblLocation.Location = New System.Drawing.Point(263, 165)
        Me.lblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(113, 35)
        Me.lblLocation.TabIndex = 97
        Me.lblLocation.Text = "Location"
        '
        'tbLocation
        '
        Me.tbLocation.BackColor = System.Drawing.SystemColors.Window
        Me.tbLocation.Location = New System.Drawing.Point(19, 164)
        Me.tbLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.tbLocation.Multiline = True
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.ReadOnly = True
        Me.tbLocation.Size = New System.Drawing.Size(242, 37)
        Me.tbLocation.TabIndex = 2
        Me.tbLocation.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("KaiTi", 10.75!)
        Me.btnClear.Location = New System.Drawing.Point(226, 17)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(35, 31)
        Me.btnClear.TabIndex = 95
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbShipToLocation
        '
        Me.tbShipToLocation.BackColor = System.Drawing.SystemColors.Window
        Me.tbShipToLocation.Location = New System.Drawing.Point(19, 115)
        Me.tbShipToLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.tbShipToLocation.Multiline = True
        Me.tbShipToLocation.Name = "tbShipToLocation"
        Me.tbShipToLocation.ReadOnly = True
        Me.tbShipToLocation.Size = New System.Drawing.Size(357, 37)
        Me.tbShipToLocation.TabIndex = 94
        Me.tbShipToLocation.TabStop = False
        '
        'tbShipToName
        '
        Me.tbShipToName.BackColor = System.Drawing.SystemColors.Window
        Me.tbShipToName.Location = New System.Drawing.Point(19, 66)
        Me.tbShipToName.Margin = New System.Windows.Forms.Padding(4)
        Me.tbShipToName.Multiline = True
        Me.tbShipToName.Name = "tbShipToName"
        Me.tbShipToName.ReadOnly = True
        Me.tbShipToName.Size = New System.Drawing.Size(357, 37)
        Me.tbShipToName.TabIndex = 93
        Me.tbShipToName.TabStop = False
        '
        'tbProNumber
        '
        Me.tbProNumber.Location = New System.Drawing.Point(383, 19)
        Me.tbProNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.tbProNumber.Name = "tbProNumber"
        Me.tbProNumber.Size = New System.Drawing.Size(172, 37)
        Me.tbProNumber.TabIndex = 1
        '
        'tbOrderNo
        '
        Me.tbOrderNo.AcceptsTab = True
        Me.tbOrderNo.Location = New System.Drawing.Point(19, 19)
        Me.tbOrderNo.Margin = New System.Windows.Forms.Padding(4)
        Me.tbOrderNo.Multiline = True
        Me.tbOrderNo.Name = "tbOrderNo"
        Me.tbOrderNo.Size = New System.Drawing.Size(207, 37)
        Me.tbOrderNo.TabIndex = 0
        '
        'lblOrderNo
        '
        Me.lblOrderNo.AutoSize = True
        Me.lblOrderNo.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblOrderNo.Location = New System.Drawing.Point(263, 19)
        Me.lblOrderNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOrderNo.Name = "lblOrderNo"
        Me.lblOrderNo.Size = New System.Drawing.Size(102, 35)
        Me.lblOrderNo.TabIndex = 90
        Me.lblOrderNo.Text = "Order #"
        '
        'lblProNo
        '
        Me.lblProNo.AutoSize = True
        Me.lblProNo.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblProNo.Location = New System.Drawing.Point(559, 19)
        Me.lblProNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProNo.Name = "lblProNo"
        Me.lblProNo.Size = New System.Drawing.Size(76, 35)
        Me.lblProNo.TabIndex = 89
        Me.lblProNo.Text = "Pro #"
        '
        'tbCrateQty
        '
        Me.tbCrateQty.BackColor = System.Drawing.SystemColors.Window
        Me.tbCrateQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbCrateQty.Font = New System.Drawing.Font("KaiTi", 36.0!)
        Me.tbCrateQty.Location = New System.Drawing.Point(465, 78)
        Me.tbCrateQty.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCrateQty.Multiline = True
        Me.tbCrateQty.Name = "tbCrateQty"
        Me.tbCrateQty.Size = New System.Drawing.Size(78, 67)
        Me.tbCrateQty.TabIndex = 3
        Me.tbCrateQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPallets
        '
        Me.lblPallets.AutoSize = True
        Me.lblPallets.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblPallets.Location = New System.Drawing.Point(559, 67)
        Me.lblPallets.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPallets.Name = "lblPallets"
        Me.lblPallets.Size = New System.Drawing.Size(89, 35)
        Me.lblPallets.TabIndex = 88
        Me.lblPallets.Text = "Pallets"
        '
        'tbCrateQtyBackField
        '
        Me.tbCrateQtyBackField.BackColor = System.Drawing.SystemColors.Window
        Me.tbCrateQtyBackField.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold)
        Me.tbCrateQtyBackField.Location = New System.Drawing.Point(455, 66)
        Me.tbCrateQtyBackField.Margin = New System.Windows.Forms.Padding(4)
        Me.tbCrateQtyBackField.Multiline = True
        Me.tbCrateQtyBackField.Name = "tbCrateQtyBackField"
        Me.tbCrateQtyBackField.ReadOnly = True
        Me.tbCrateQtyBackField.Size = New System.Drawing.Size(100, 86)
        Me.tbCrateQtyBackField.TabIndex = 86
        Me.tbCrateQtyBackField.TabStop = False
        Me.tbCrateQtyBackField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtShipViaCode)
        Me.Panel4.Controls.Add(Me.lblShipVia)
        Me.Panel4.Controls.Add(Me.cboShipVia)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(463, 222)
        Me.Panel4.TabIndex = 87
        '
        'txtShipViaCode
        '
        Me.txtShipViaCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtShipViaCode.Font = New System.Drawing.Font("KaiTi", 62.0!)
        Me.txtShipViaCode.Location = New System.Drawing.Point(19, 66)
        Me.txtShipViaCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtShipViaCode.Multiline = True
        Me.txtShipViaCode.Name = "txtShipViaCode"
        Me.txtShipViaCode.ReadOnly = True
        Me.txtShipViaCode.Size = New System.Drawing.Size(315, 132)
        Me.txtShipViaCode.TabIndex = 89
        Me.txtShipViaCode.TabStop = False
        Me.txtShipViaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblShipVia
        '
        Me.lblShipVia.AutoSize = True
        Me.lblShipVia.BackColor = System.Drawing.SystemColors.Control
        Me.lblShipVia.Font = New System.Drawing.Font("Segoe UI Semibold", 14.5!, System.Drawing.FontStyle.Bold)
        Me.lblShipVia.Location = New System.Drawing.Point(337, 20)
        Me.lblShipVia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblShipVia.Name = "lblShipVia"
        Me.lblShipVia.Size = New System.Drawing.Size(109, 35)
        Me.lblShipVia.TabIndex = 88
        Me.lblShipVia.Text = "Ship Via"
        '
        'cboShipVia
        '
        Me.cboShipVia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboShipVia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboShipVia.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboShipVia.Font = New System.Drawing.Font("KaiTi", 15.0!)
        Me.cboShipVia.FormattingEnabled = True
        Me.cboShipVia.Location = New System.Drawing.Point(17, 21)
        Me.cboShipVia.Margin = New System.Windows.Forms.Padding(4)
        Me.cboShipVia.Name = "cboShipVia"
        Me.cboShipVia.Size = New System.Drawing.Size(315, 33)
        Me.cboShipVia.TabIndex = 0
        '
        'Timer3
        '
        '
        'fLoadSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 794)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDataPath)
        Me.Controls.Add(Me.tbPreviewPath)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fLoadSheet"
        Me.Text = "Load Sheet"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPricingType As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivider1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivider2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCurrentDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDivider3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDefaultDB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents tbPreviewPath As System.Windows.Forms.TextBox
    Friend WithEvents tbDataPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    ' Friend WithEvents ControlBarTender1 As MassarelliShippingLabelApp.ControlBarTender
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tbShipToName As System.Windows.Forms.TextBox
    Friend WithEvents tbProNumber As System.Windows.Forms.TextBox
    Friend WithEvents tbOrderNo As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderNo As System.Windows.Forms.Label
    Friend WithEvents lblProNo As System.Windows.Forms.Label
    Friend WithEvents tbCrateQty As System.Windows.Forms.TextBox
    Friend WithEvents lblPallets As System.Windows.Forms.Label
    Friend WithEvents tbCrateQtyBackField As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtShipViaCode As System.Windows.Forms.TextBox
    Friend WithEvents lblShipVia As System.Windows.Forms.Label
    Friend WithEvents cboShipVia As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbShipToLocation As System.Windows.Forms.TextBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents tbLocation As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents InsertCustomerCommentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
