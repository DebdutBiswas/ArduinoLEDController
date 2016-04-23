<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialConsoleDialog
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SerialConsoleDialog))
        Me.SerialConsole = New System.Windows.Forms.TextBox()
        Me.BudSendBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.InputConsole = New System.Windows.Forms.TextBox()
        Me.SerialConsoleRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.AuthLbl = New System.Windows.Forms.Label()
        Me.SerialMonitorOpenBtn = New System.Windows.Forms.PictureBox()
        CType(Me.SerialMonitorOpenBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialConsole
        '
        Me.SerialConsole.BackColor = System.Drawing.Color.Black
        Me.SerialConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerialConsole.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialConsole.ForeColor = System.Drawing.Color.DarkGreen
        Me.SerialConsole.Location = New System.Drawing.Point(12, 118)
        Me.SerialConsole.Multiline = True
        Me.SerialConsole.Name = "SerialConsole"
        Me.SerialConsole.Size = New System.Drawing.Size(736, 330)
        Me.SerialConsole.TabIndex = 3
        '
        'BudSendBtn
        '
        Me.BudSendBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BudSendBtn.Depth = 0
        Me.BudSendBtn.Location = New System.Drawing.Point(613, 76)
        Me.BudSendBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.BudSendBtn.Name = "BudSendBtn"
        Me.BudSendBtn.Primary = True
        Me.BudSendBtn.Size = New System.Drawing.Size(135, 36)
        Me.BudSendBtn.TabIndex = 2
        Me.BudSendBtn.Text = "SEND"
        Me.BudSendBtn.UseVisualStyleBackColor = True
        '
        'InputConsole
        '
        Me.InputConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputConsole.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputConsole.Location = New System.Drawing.Point(12, 76)
        Me.InputConsole.Name = "InputConsole"
        Me.InputConsole.Size = New System.Drawing.Size(595, 35)
        Me.InputConsole.TabIndex = 1
        '
        'SerialConsoleRefresh
        '
        Me.SerialConsoleRefresh.Enabled = True
        Me.SerialConsoleRefresh.Interval = 1
        '
        'AuthLbl
        '
        Me.AuthLbl.AutoSize = True
        Me.AuthLbl.BackColor = System.Drawing.Color.Transparent
        Me.AuthLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuthLbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthLbl.ForeColor = System.Drawing.Color.White
        Me.AuthLbl.Location = New System.Drawing.Point(530, 37)
        Me.AuthLbl.Name = "AuthLbl"
        Me.AuthLbl.Size = New System.Drawing.Size(218, 13)
        Me.AuthLbl.TabIndex = 45
        Me.AuthLbl.Text = "Copyright (C) Dev Doftware Development"
        '
        'SerialMonitorOpenBtn
        '
        Me.SerialMonitorOpenBtn.BackColor = System.Drawing.Color.Transparent
        Me.SerialMonitorOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SerialMonitorOpenBtn.ErrorImage = Nothing
        Me.SerialMonitorOpenBtn.Image = CType(resources.GetObject("SerialMonitorOpenBtn.Image"), System.Drawing.Image)
        Me.SerialMonitorOpenBtn.InitialImage = Nothing
        Me.SerialMonitorOpenBtn.Location = New System.Drawing.Point(129, 29)
        Me.SerialMonitorOpenBtn.Name = "SerialMonitorOpenBtn"
        Me.SerialMonitorOpenBtn.Size = New System.Drawing.Size(30, 30)
        Me.SerialMonitorOpenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SerialMonitorOpenBtn.TabIndex = 54
        Me.SerialMonitorOpenBtn.TabStop = False
        '
        'SerialConsoleDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 460)
        Me.Controls.Add(Me.SerialMonitorOpenBtn)
        Me.Controls.Add(Me.AuthLbl)
        Me.Controls.Add(Me.InputConsole)
        Me.Controls.Add(Me.BudSendBtn)
        Me.Controls.Add(Me.SerialConsole)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(760, 460)
        Me.MinimumSize = New System.Drawing.Size(760, 460)
        Me.Name = "SerialConsoleDialog"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serial Monitor"
        CType(Me.SerialMonitorOpenBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialConsole As System.Windows.Forms.TextBox
    Private WithEvents BudSendBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents InputConsole As System.Windows.Forms.TextBox
    Friend WithEvents SerialConsoleRefresh As System.Windows.Forms.Timer
    Friend WithEvents AuthLbl As System.Windows.Forms.Label
    Friend WithEvents SerialMonitorOpenBtn As System.Windows.Forms.PictureBox
End Class
