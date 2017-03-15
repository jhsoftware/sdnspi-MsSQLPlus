<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestRes
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
    Me.OK_Button = New System.Windows.Forms.Button
    Me.dgv = New System.Windows.Forms.DataGridView
    Me.Label1 = New System.Windows.Forms.Label
    Me.ColRecData = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ColRecName = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ColRecType = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ColRecTTL = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.ColRecSec = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'OK_Button
    '
    Me.OK_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.OK_Button.Location = New System.Drawing.Point(391, 207)
    Me.OK_Button.Name = "OK_Button"
    Me.OK_Button.Size = New System.Drawing.Size(75, 23)
    Me.OK_Button.TabIndex = 0
    Me.OK_Button.Text = "OK"
    '
    'dgv
    '
    Me.dgv.AllowUserToAddRows = False
    Me.dgv.AllowUserToDeleteRows = False
    Me.dgv.AllowUserToResizeRows = False
    Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColRecData, Me.ColRecName, Me.ColRecType, Me.ColRecTTL, Me.ColRecSec})
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgv.Location = New System.Drawing.Point(12, 25)
    Me.dgv.MultiSelect = False
    Me.dgv.Name = "dgv"
    Me.dgv.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgv.RowHeadersVisible = False
    Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
    Me.dgv.ShowEditingIcon = False
    Me.dgv.ShowRowErrors = False
    Me.dgv.Size = New System.Drawing.Size(454, 176)
    Me.dgv.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(309, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "The SELECT statement returned the following DNS record data:"
    '
    'ColRecData
    '
    Me.ColRecData.HeaderText = "RecData"
    Me.ColRecData.Name = "ColRecData"
    Me.ColRecData.ReadOnly = True
    Me.ColRecData.Width = 125
    '
    'ColRecName
    '
    Me.ColRecName.HeaderText = "RecName"
    Me.ColRecName.Name = "ColRecName"
    Me.ColRecName.ReadOnly = True
    '
    'ColRecType
    '
    Me.ColRecType.HeaderText = "RecType"
    Me.ColRecType.Name = "ColRecType"
    Me.ColRecType.ReadOnly = True
    Me.ColRecType.Width = 65
    '
    'ColRecTTL
    '
    Me.ColRecTTL.HeaderText = "RecTTL"
    Me.ColRecTTL.Name = "ColRecTTL"
    Me.ColRecTTL.ReadOnly = True
    Me.ColRecTTL.Width = 65
    '
    'ColRecSec
    '
    Me.ColRecSec.HeaderText = "RecSec"
    Me.ColRecSec.Name = "ColRecSec"
    Me.ColRecSec.ReadOnly = True
    Me.ColRecSec.Width = 65
    '
    'frmTestRes
    '
    Me.AcceptButton = Me.OK_Button
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(478, 242)
    Me.Controls.Add(Me.dgv)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.OK_Button)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmTestRes"
    Me.ShowIcon = False
    Me.ShowInTaskbar = False
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Test SELECT statement"
    CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents OK_Button As System.Windows.Forms.Button
  Friend WithEvents dgv As System.Windows.Forms.DataGridView
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ColRecData As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColRecName As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColRecType As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColRecTTL As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ColRecSec As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
