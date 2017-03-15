<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsCtrl
  Inherits JHSoftware.SimpleDNS.Plugin.OptionsUI ' System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.components = New System.ComponentModel.Container
    Dim Label1 As System.Windows.Forms.Label
    Dim Label2 As System.Windows.Forms.Label
    Dim Label6 As System.Windows.Forms.Label
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsCtrl))
    Me.txtConn = New System.Windows.Forms.TextBox
    Me.txtSelect = New System.Windows.Forms.TextBox
    Me.btnTestConn = New System.Windows.Forms.Button
    Me.btnTestSelect = New System.Windows.Forms.Button
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
    Me.btnBuildConn = New System.Windows.Forms.Button
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Label1 = New System.Windows.Forms.Label
    Label2 = New System.Windows.Forms.Label
    Label6 = New System.Windows.Forms.Label
    Me.TableLayoutPanel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Label1.AutoSize = True
    Label1.Location = New System.Drawing.Point(3, 0)
    Label1.Name = "Label1"
    Label1.Size = New System.Drawing.Size(140, 13)
    Label1.TabIndex = 0
    Label1.Text = "Database connection string:"
    '
    'Label2
    '
    Label2.AutoSize = True
    Me.TableLayoutPanel1.SetColumnSpan(Label2, 3)
    Label2.Location = New System.Drawing.Point(3, 57)
    Label2.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
    Label2.Name = "Label2"
    Label2.Size = New System.Drawing.Size(222, 13)
    Label2.TabIndex = 4
    Label2.Text = "SELECT statement to fetch DNS record data:"
    '
    'Label6
    '
    Label6.AutoSize = True
    Me.TableLayoutPanel1.SetColumnSpan(Label6, 3)
    Label6.Location = New System.Drawing.Point(3, 140)
    Label6.Name = "Label6"
    Label6.Size = New System.Drawing.Size(417, 143)
    Label6.TabIndex = 22
    Label6.Text = resources.GetString("Label6.Text")
    '
    'txtConn
    '
    Me.txtConn.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtConn.Location = New System.Drawing.Point(3, 17)
    Me.txtConn.Name = "txtConn"
    Me.txtConn.Size = New System.Drawing.Size(354, 20)
    Me.txtConn.TabIndex = 1
    '
    'txtSelect
    '
    Me.txtSelect.AcceptsReturn = True
    Me.txtSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel1.SetColumnSpan(Me.txtSelect, 2)
    Me.txtSelect.Location = New System.Drawing.Point(3, 73)
    Me.txtSelect.Multiline = True
    Me.txtSelect.Name = "txtSelect"
    Me.txtSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtSelect.Size = New System.Drawing.Size(383, 64)
    Me.txtSelect.TabIndex = 6
    '
    'btnTestConn
    '
    Me.btnTestConn.Anchor = System.Windows.Forms.AnchorStyles.None
    Me.btnTestConn.Location = New System.Drawing.Point(392, 16)
    Me.btnTestConn.Name = "btnTestConn"
    Me.btnTestConn.Size = New System.Drawing.Size(55, 23)
    Me.btnTestConn.TabIndex = 3
    Me.btnTestConn.Text = "Test"
    Me.btnTestConn.UseVisualStyleBackColor = True
    '
    'btnTestSelect
    '
    Me.btnTestSelect.Location = New System.Drawing.Point(392, 73)
    Me.btnTestSelect.Name = "btnTestSelect"
    Me.btnTestSelect.Size = New System.Drawing.Size(55, 23)
    Me.btnTestSelect.TabIndex = 8
    Me.btnTestSelect.Text = "Test..."
    Me.btnTestSelect.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 3
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
    Me.TableLayoutPanel1.Controls.Add(Me.btnTestConn, 2, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.btnTestSelect, 2, 3)
    Me.TableLayoutPanel1.Controls.Add(Label2, 0, 2)
    Me.TableLayoutPanel1.Controls.Add(Me.txtConn, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Label1, 0, 0)
    Me.TableLayoutPanel1.Controls.Add(Label6, 0, 4)
    Me.TableLayoutPanel1.Controls.Add(Me.btnBuildConn, 1, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.txtSelect, 0, 3)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 5
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(450, 294)
    Me.TableLayoutPanel1.TabIndex = 0
    '
    'btnBuildConn
    '
    Me.btnBuildConn.Location = New System.Drawing.Point(363, 16)
    Me.btnBuildConn.Name = "btnBuildConn"
    Me.btnBuildConn.Size = New System.Drawing.Size(23, 23)
    Me.btnBuildConn.TabIndex = 2
    Me.btnBuildConn.Text = ".."
    Me.ToolTip1.SetToolTip(Me.btnBuildConn, "Build")
    Me.btnBuildConn.UseVisualStyleBackColor = True
    '
    'OptionsCtrl
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TableLayoutPanel1)
    Me.Name = "OptionsCtrl"
    Me.Size = New System.Drawing.Size(450, 294)
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.TableLayoutPanel1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents txtConn As System.Windows.Forms.TextBox
  Friend WithEvents txtSelect As System.Windows.Forms.TextBox
  Friend WithEvents btnTestConn As System.Windows.Forms.Button
  Friend WithEvents btnTestSelect As System.Windows.Forms.Button
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents btnBuildConn As System.Windows.Forms.Button
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
