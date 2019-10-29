<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRViewer
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
        Me.crLoadSheetViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crLoadSheetViewer
        '
        Me.crLoadSheetViewer.ActiveViewIndex = -1
        Me.crLoadSheetViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crLoadSheetViewer.CachedPageNumberPerDoc = 10
        Me.crLoadSheetViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crLoadSheetViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crLoadSheetViewer.Location = New System.Drawing.Point(0, 0)
        Me.crLoadSheetViewer.Name = "crLoadSheetViewer"
        Me.crLoadSheetViewer.Size = New System.Drawing.Size(1482, 695)
        Me.crLoadSheetViewer.TabIndex = 0
        '
        'CRViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 695)
        Me.Controls.Add(Me.crLoadSheetViewer)
        Me.Name = "CRViewer"
        Me.Text = "CRViewer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crLoadSheetViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
