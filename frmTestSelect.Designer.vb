﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestSelect
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
    Me.btnOK = New System.Windows.Forms.Button
    Me.btnCancel = New System.Windows.Forms.Button
    Me.GroupBox1 = New System.Windows.Forms.GroupBox
    Me.txtQIP = New System.Windows.Forms.TextBox
    Me.txtQType = New System.Windows.Forms.TextBox
    Me.txtQName = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'btnOK
    '
    Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnOK.Location = New System.Drawing.Point(133, 214)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(75, 23)
    Me.btnOK.TabIndex = 1
    Me.btnOK.Text = "Test"
    '
    'btnCancel
    '
    Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnCancel.Location = New System.Drawing.Point(214, 214)
    Me.btnCancel.Name = "btnCancel"
    Me.btnCancel.Size = New System.Drawing.Size(75, 23)
    Me.btnCancel.TabIndex = 2
    Me.btnCancel.Text = "Cancel"
    '
    'GroupBox1
    '
    Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.GroupBox1.Controls.Add(Me.txtQIP)
    Me.GroupBox1.Controls.Add(Me.txtQType)
    Me.GroupBox1.Controls.Add(Me.txtQName)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(15)
    Me.GroupBox1.Size = New System.Drawing.Size(277, 196)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Test SELECT statement"
    '
    'txtQIP
    '
    Me.txtQIP.Location = New System.Drawing.Point(18, 152)
    Me.txtQIP.Name = "txtQIP"
    Me.txtQIP.Size = New System.Drawing.Size(237, 20)
    Me.txtQIP.TabIndex = 5
    Me.txtQIP.Text = "127.0.0.1"
    '
    'txtQType
    '
    Me.txtQType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
    Me.txtQType.Location = New System.Drawing.Point(18, 98)
    Me.txtQType.Name = "txtQType"
    Me.txtQType.Size = New System.Drawing.Size(100, 20)
    Me.txtQType.TabIndex = 3
    Me.txtQType.Text = "A"
    '
    'txtQName
    '
    Me.txtQName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
    Me.txtQName.Location = New System.Drawing.Point(18, 44)
    Me.txtQName.Name = "txtQName"
    Me.txtQName.Size = New System.Drawing.Size(237, 20)
    Me.txtQName.TabIndex = 1
    Me.txtQName.Text = "www.example.com"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(18, 136)
    Me.Label3.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(86, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "@QIP parameter"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(18, 82)
    Me.Label2.Margin = New System.Windows.Forms.Padding(3, 15, 3, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(107, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "@QTYPE parameter:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(18, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(110, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "@QNAME parameter:"
    '
    'frmTestSelect
    '
    Me.AcceptButton = Me.btnOK
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnCancel
    Me.ClientSize = New System.Drawing.Size(301, 249)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.btnCancel)
    Me.Controls.Add(Me.btnOK)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmTestSelect"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Test SELECT statement"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents btnCancel As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents txtQIP As System.Windows.Forms.TextBox
  Friend WithEvents txtQType As System.Windows.Forms.TextBox
  Friend WithEvents txtQName As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
