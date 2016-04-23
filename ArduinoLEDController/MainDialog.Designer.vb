<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDialog))
        Me.LEDTick0 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LEDTick1 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LEDTick2 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LEDTick3 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LEDTick4 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.LEDTick5 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.ArduinoSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.LEDTick6 = New MaterialSkin.Controls.MaterialCheckBox()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.AppPic = New System.Windows.Forms.PictureBox()
        Me.AuthLbl = New System.Windows.Forms.Label()
        Me.DelayClock = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBoxLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.AllOffOnDelay = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.AllOnBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DelayONBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DelayOFFBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.AllOffBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SerialPortListView = New System.Windows.Forms.ComboBox()
        Me.SerialMonitorOpenBtn = New System.Windows.Forms.PictureBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ConnectBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DisconnectBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.RefreshBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckBoxLayoutPanel.SuspendLayout()
        CType(Me.SerialMonitorOpenBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LEDTick0
        '
        Me.LEDTick0.AutoSize = True
        Me.LEDTick0.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick0.Depth = 0
        Me.LEDTick0.Enabled = False
        Me.LEDTick0.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick0.Location = New System.Drawing.Point(0, 0)
        Me.LEDTick0.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick0.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick0.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick0.Name = "LEDTick0"
        Me.LEDTick0.Ripple = True
        Me.LEDTick0.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick0.TabIndex = 33
        Me.LEDTick0.Text = "LED0 >> Serial Data: 0x30"
        Me.LEDTick0.UseVisualStyleBackColor = True
        '
        'LEDTick1
        '
        Me.LEDTick1.AutoSize = True
        Me.LEDTick1.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick1.Depth = 0
        Me.LEDTick1.Enabled = False
        Me.LEDTick1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick1.Location = New System.Drawing.Point(0, 40)
        Me.LEDTick1.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick1.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick1.Name = "LEDTick1"
        Me.LEDTick1.Ripple = True
        Me.LEDTick1.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick1.TabIndex = 34
        Me.LEDTick1.Text = "LED1 >> Serial Data: 0x32"
        Me.LEDTick1.UseVisualStyleBackColor = True
        '
        'LEDTick2
        '
        Me.LEDTick2.AutoSize = True
        Me.LEDTick2.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick2.Depth = 0
        Me.LEDTick2.Enabled = False
        Me.LEDTick2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick2.Location = New System.Drawing.Point(0, 81)
        Me.LEDTick2.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick2.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick2.Name = "LEDTick2"
        Me.LEDTick2.Ripple = True
        Me.LEDTick2.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick2.TabIndex = 35
        Me.LEDTick2.Text = "LED2 >> Serial Data: 0x34"
        Me.LEDTick2.UseVisualStyleBackColor = True
        '
        'LEDTick3
        '
        Me.LEDTick3.AutoSize = True
        Me.LEDTick3.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick3.Depth = 0
        Me.LEDTick3.Enabled = False
        Me.LEDTick3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick3.Location = New System.Drawing.Point(0, 119)
        Me.LEDTick3.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick3.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick3.Name = "LEDTick3"
        Me.LEDTick3.Ripple = True
        Me.LEDTick3.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick3.TabIndex = 36
        Me.LEDTick3.Text = "LED3 >> Serial Data: 0x36"
        Me.LEDTick3.UseVisualStyleBackColor = True
        '
        'LEDTick4
        '
        Me.LEDTick4.AutoSize = True
        Me.LEDTick4.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick4.Depth = 0
        Me.LEDTick4.Enabled = False
        Me.LEDTick4.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick4.Location = New System.Drawing.Point(0, 158)
        Me.LEDTick4.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick4.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick4.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick4.Name = "LEDTick4"
        Me.LEDTick4.Ripple = True
        Me.LEDTick4.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick4.TabIndex = 37
        Me.LEDTick4.Text = "LED4 >> Serial Data: 0x38"
        Me.LEDTick4.UseVisualStyleBackColor = True
        '
        'LEDTick5
        '
        Me.LEDTick5.AutoSize = True
        Me.LEDTick5.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick5.Depth = 0
        Me.LEDTick5.Enabled = False
        Me.LEDTick5.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick5.Location = New System.Drawing.Point(0, 197)
        Me.LEDTick5.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick5.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick5.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick5.Name = "LEDTick5"
        Me.LEDTick5.Ripple = True
        Me.LEDTick5.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick5.TabIndex = 38
        Me.LEDTick5.Text = "LED5 >> Serial Data: 0x3a"
        Me.LEDTick5.UseVisualStyleBackColor = True
        '
        'ArduinoSerialPort
        '
        Me.ArduinoSerialPort.DtrEnable = True
        Me.ArduinoSerialPort.Handshake = System.IO.Ports.Handshake.RequestToSend
        Me.ArduinoSerialPort.RtsEnable = True
        '
        'LEDTick6
        '
        Me.LEDTick6.AutoSize = True
        Me.LEDTick6.Cursor = System.Windows.Forms.Cursors.Default
        Me.LEDTick6.Depth = 0
        Me.LEDTick6.Enabled = False
        Me.LEDTick6.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.LEDTick6.Location = New System.Drawing.Point(0, 238)
        Me.LEDTick6.Margin = New System.Windows.Forms.Padding(0)
        Me.LEDTick6.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.LEDTick6.MouseState = MaterialSkin.MouseState.HOVER
        Me.LEDTick6.Name = "LEDTick6"
        Me.LEDTick6.Ripple = True
        Me.LEDTick6.Size = New System.Drawing.Size(187, 30)
        Me.LEDTick6.TabIndex = 39
        Me.LEDTick6.Text = "LED6 >> Serial Data: 0x3c"
        Me.LEDTick6.UseVisualStyleBackColor = True
        '
        'AppIcon
        '
        Me.AppIcon.BackColor = System.Drawing.Color.Transparent
        Me.AppIcon.ErrorImage = Nothing
        Me.AppIcon.Image = CType(resources.GetObject("AppIcon.Image"), System.Drawing.Image)
        Me.AppIcon.InitialImage = Nothing
        Me.AppIcon.Location = New System.Drawing.Point(724, 29)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(30, 30)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppIcon.TabIndex = 42
        Me.AppIcon.TabStop = False
        '
        'AppPic
        '
        Me.AppPic.BackColor = System.Drawing.Color.Transparent
        Me.AppPic.ErrorImage = Nothing
        Me.AppPic.Image = CType(resources.GetObject("AppPic.Image"), System.Drawing.Image)
        Me.AppPic.InitialImage = Nothing
        Me.AppPic.Location = New System.Drawing.Point(193, 29)
        Me.AppPic.Name = "AppPic"
        Me.AppPic.Size = New System.Drawing.Size(30, 30)
        Me.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppPic.TabIndex = 43
        Me.AppPic.TabStop = False
        '
        'AuthLbl
        '
        Me.AuthLbl.AutoSize = True
        Me.AuthLbl.BackColor = System.Drawing.Color.Transparent
        Me.AuthLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AuthLbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthLbl.ForeColor = System.Drawing.Color.White
        Me.AuthLbl.Location = New System.Drawing.Point(5, 443)
        Me.AuthLbl.Name = "AuthLbl"
        Me.AuthLbl.Size = New System.Drawing.Size(218, 13)
        Me.AuthLbl.TabIndex = 44
        Me.AuthLbl.Text = "Copyright (C) Dev Doftware Development"
        '
        'DelayClock
        '
        Me.DelayClock.Interval = 1400
        '
        'CheckBoxLayoutPanel
        '
        Me.CheckBoxLayoutPanel.ColumnCount = 1
        Me.CheckBoxLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.17139!))
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick6, 0, 6)
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick5, 0, 5)
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick4, 0, 4)
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick0, 0, 0)
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick1, 0, 1)
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick3, 0, 3)
        Me.CheckBoxLayoutPanel.Controls.Add(Me.LEDTick2, 0, 2)
        Me.CheckBoxLayoutPanel.Location = New System.Drawing.Point(12, 74)
        Me.CheckBoxLayoutPanel.Name = "CheckBoxLayoutPanel"
        Me.CheckBoxLayoutPanel.RowCount = 7
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049!))
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951!))
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.CheckBoxLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.CheckBoxLayoutPanel.Size = New System.Drawing.Size(198, 279)
        Me.CheckBoxLayoutPanel.TabIndex = 46
        '
        'AllOffOnDelay
        '
        Me.AllOffOnDelay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllOffOnDelay.Depth = 0
        Me.AllOffOnDelay.Enabled = False
        Me.AllOffOnDelay.Location = New System.Drawing.Point(312, 402)
        Me.AllOffOnDelay.MouseState = MaterialSkin.MouseState.HOVER
        Me.AllOffOnDelay.Name = "AllOffOnDelay"
        Me.AllOffOnDelay.Primary = True
        Me.AllOffOnDelay.Size = New System.Drawing.Size(135, 36)
        Me.AllOffOnDelay.TabIndex = 51
        Me.AllOffOnDelay.Text = "ALL ON/OFF DELAY"
        Me.AllOffOnDelay.UseVisualStyleBackColor = True
        '
        'AllOnBtn
        '
        Me.AllOnBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllOnBtn.Depth = 0
        Me.AllOnBtn.Enabled = False
        Me.AllOnBtn.Location = New System.Drawing.Point(12, 360)
        Me.AllOnBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AllOnBtn.Name = "AllOnBtn"
        Me.AllOnBtn.Primary = True
        Me.AllOnBtn.Size = New System.Drawing.Size(135, 36)
        Me.AllOnBtn.TabIndex = 48
        Me.AllOnBtn.Text = "ALL ON"
        Me.AllOnBtn.UseVisualStyleBackColor = True
        '
        'DelayONBtn
        '
        Me.DelayONBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelayONBtn.Depth = 0
        Me.DelayONBtn.Enabled = False
        Me.DelayONBtn.Location = New System.Drawing.Point(12, 402)
        Me.DelayONBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.DelayONBtn.Name = "DelayONBtn"
        Me.DelayONBtn.Primary = True
        Me.DelayONBtn.Size = New System.Drawing.Size(135, 36)
        Me.DelayONBtn.TabIndex = 50
        Me.DelayONBtn.Text = "ALL ON DELAY"
        Me.DelayONBtn.UseVisualStyleBackColor = True
        '
        'DelayOFFBtn
        '
        Me.DelayOFFBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DelayOFFBtn.Depth = 0
        Me.DelayOFFBtn.Enabled = False
        Me.DelayOFFBtn.Location = New System.Drawing.Point(613, 402)
        Me.DelayOFFBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.DelayOFFBtn.Name = "DelayOFFBtn"
        Me.DelayOFFBtn.Primary = True
        Me.DelayOFFBtn.Size = New System.Drawing.Size(135, 36)
        Me.DelayOFFBtn.TabIndex = 49
        Me.DelayOFFBtn.Text = "ALL OFF DELAY"
        Me.DelayOFFBtn.UseVisualStyleBackColor = True
        '
        'AllOffBtn
        '
        Me.AllOffBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllOffBtn.Depth = 0
        Me.AllOffBtn.Enabled = False
        Me.AllOffBtn.Location = New System.Drawing.Point(613, 360)
        Me.AllOffBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.AllOffBtn.Name = "AllOffBtn"
        Me.AllOffBtn.Primary = True
        Me.AllOffBtn.Size = New System.Drawing.Size(135, 36)
        Me.AllOffBtn.TabIndex = 47
        Me.AllOffBtn.Text = "ALL OFF"
        Me.AllOffBtn.UseVisualStyleBackColor = True
        '
        'SerialPortListView
        '
        Me.SerialPortListView.BackColor = System.Drawing.Color.DimGray
        Me.SerialPortListView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SerialPortListView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SerialPortListView.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialPortListView.ForeColor = System.Drawing.Color.White
        Me.SerialPortListView.FormattingEnabled = True
        Me.SerialPortListView.Location = New System.Drawing.Point(216, 75)
        Me.SerialPortListView.Name = "SerialPortListView"
        Me.SerialPortListView.Size = New System.Drawing.Size(532, 29)
        Me.SerialPortListView.TabIndex = 52
        '
        'SerialMonitorOpenBtn
        '
        Me.SerialMonitorOpenBtn.BackColor = System.Drawing.Color.Transparent
        Me.SerialMonitorOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SerialMonitorOpenBtn.ErrorImage = Nothing
        Me.SerialMonitorOpenBtn.Image = CType(resources.GetObject("SerialMonitorOpenBtn.Image"), System.Drawing.Image)
        Me.SerialMonitorOpenBtn.InitialImage = Nothing
        Me.SerialMonitorOpenBtn.Location = New System.Drawing.Point(688, 29)
        Me.SerialMonitorOpenBtn.Name = "SerialMonitorOpenBtn"
        Me.SerialMonitorOpenBtn.Size = New System.Drawing.Size(30, 30)
        Me.SerialMonitorOpenBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SerialMonitorOpenBtn.TabIndex = 53
        Me.SerialMonitorOpenBtn.TabStop = False
        Me.ToolTip.SetToolTip(Me.SerialMonitorOpenBtn, "Open Serial Monitor")
        '
        'ToolTip
        '
        Me.ToolTip.BackColor = System.Drawing.Color.White
        Me.ToolTip.ForeColor = System.Drawing.Color.Black
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ConnectBtn.Depth = 0
        Me.ConnectBtn.Location = New System.Drawing.Point(627, 113)
        Me.ConnectBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ConnectBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Primary = True
        Me.ConnectBtn.Size = New System.Drawing.Size(120, 36)
        Me.ConnectBtn.TabIndex = 54
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        Me.ConnectBtn.Visible = False
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DisconnectBtn.BackColor = System.Drawing.SystemColors.Control
        Me.DisconnectBtn.Depth = 0
        Me.DisconnectBtn.Location = New System.Drawing.Point(627, 113)
        Me.DisconnectBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DisconnectBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Primary = True
        Me.DisconnectBtn.Size = New System.Drawing.Size(120, 36)
        Me.DisconnectBtn.TabIndex = 55
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        Me.DisconnectBtn.Visible = False
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshBtn.BackColor = System.Drawing.SystemColors.Control
        Me.RefreshBtn.Depth = 0
        Me.RefreshBtn.Location = New System.Drawing.Point(217, 113)
        Me.RefreshBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RefreshBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Primary = True
        Me.RefreshBtn.Size = New System.Drawing.Size(120, 36)
        Me.RefreshBtn.TabIndex = 56
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'MainDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 460)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.DisconnectBtn)
        Me.Controls.Add(Me.ConnectBtn)
        Me.Controls.Add(Me.SerialMonitorOpenBtn)
        Me.Controls.Add(Me.SerialPortListView)
        Me.Controls.Add(Me.AllOffOnDelay)
        Me.Controls.Add(Me.AllOnBtn)
        Me.Controls.Add(Me.DelayONBtn)
        Me.Controls.Add(Me.DelayOFFBtn)
        Me.Controls.Add(Me.AllOffBtn)
        Me.Controls.Add(Me.AuthLbl)
        Me.Controls.Add(Me.AppPic)
        Me.Controls.Add(Me.AppIcon)
        Me.Controls.Add(Me.CheckBoxLayoutPanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(760, 460)
        Me.MinimumSize = New System.Drawing.Size(760, 460)
        Me.Name = "MainDialog"
        Me.Opacity = 0.98R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arduino LED Controller"
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckBoxLayoutPanel.ResumeLayout(False)
        Me.CheckBoxLayoutPanel.PerformLayout()
        CType(Me.SerialMonitorOpenBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents LEDTick0 As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents LEDTick1 As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents LEDTick2 As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents LEDTick3 As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents LEDTick4 As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents LEDTick5 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents ArduinoSerialPort As System.IO.Ports.SerialPort
    Private WithEvents LEDTick6 As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents AppPic As System.Windows.Forms.PictureBox
    Friend WithEvents AuthLbl As System.Windows.Forms.Label
    Friend WithEvents DelayClock As System.Windows.Forms.Timer
    Friend WithEvents CheckBoxLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Private WithEvents AllOffOnDelay As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents AllOnBtn As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents DelayONBtn As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents DelayOFFBtn As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents AllOffBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents SerialMonitorOpenBtn As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Private WithEvents ConnectBtn As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents DisconnectBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents SerialPortListView As System.Windows.Forms.ComboBox
    Private WithEvents RefreshBtn As MaterialSkin.Controls.MaterialRaisedButton

End Class
