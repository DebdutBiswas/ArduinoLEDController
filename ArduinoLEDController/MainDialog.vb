Imports MaterialSkin
Imports MaterialSkin.Controls
Imports System.Management

Public Class MainDialog

    Inherits MaterialForm
    Private ReadOnly materialSkinManager As MaterialSkinManager
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Const DROPSHADOW = &H30000
            Dim cParam As CreateParams = MyBase.CreateParams
            cParam.ClassStyle = cParam.ClassStyle Or DROPSHADOW

            Return cParam
        End Get
    End Property

    Public ConnectionStatus As Boolean = False
    Public DevIdList As New List(Of String)()

    Public Sub New()
        InitializeComponent()

        ' Initialize MaterialSkinManager
        materialSkinManager = materialSkinManager.Instance
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = materialSkinManager.Themes.DARK
        materialSkinManager.ColorScheme = New ColorScheme(Primary.Indigo600, Primary.Indigo700, Primary.Indigo200, Accent.Indigo400, TextShade.WHITE)

    End Sub

    Public Function AutodetectArduinoPort() As String
        Dim connectionScope As New ManagementScope()
        Dim serialQuery As New SelectQuery("SELECT * FROM Win32_SerialPort")
        Dim searcher As New ManagementObjectSearcher(connectionScope, serialQuery)

        Try
            For Each item As ManagementObject In searcher.[Get]()
                Dim desc As String = item("Description").ToString()
                Dim deviceId As String = item("DeviceID").ToString()

                'If desc.Contains("Arduino") Then
                'Return deviceId

                SerialPortListView.Items.Add(desc + " (" + deviceId + ")")

                    For Each deviceId In SerialPortListView.Items
                        DevIdList.Add(deviceId)
                    Next

                'End If
            Next
        Catch e As ManagementException
        End Try

        If SerialPortListView.Items.Count = 0 Then
            SerialPortListView.Items.Add("No Serial Port Avilable!")
        ElseIf SerialPortListView.Items.Count > 0 Then
            ConnectBtn.Show()
        End If

        Return Nothing
    End Function

    Public Sub GetSerialPortNames()
        ' Show all available COM ports.
        For Each SerialPort As String In My.Computer.Ports.SerialPortNames
            SerialPortListView.Items.Add(SerialPort)
        Next

        If SerialPortListView.Items.Count = 0 Then
            SerialPortListView.Items.Add("No Serial Port Avilable!")
        ElseIf SerialPortListView.Items.Count > 0 Then
            ConnectBtn.Show()
        End If
    End Sub

    Sub ArduinoSerialPort_Open()
        If ArduinoSerialPort.IsOpen = False Then
            Try
                ArduinoSerialPort.Open()
            Catch
                MsgBox("The COM Port is used by another process!", MsgBoxStyle.Information, "COM Port is in use")
            End Try
        End If
    End Sub

    Sub ArduinoSerialPort_Close()
        If ArduinoSerialPort.IsOpen = True Then
            Try
                ArduinoSerialPort.Close()
            Catch
                'MsgBox("The COM Port is used by another process!", MsgBoxStyle.Information, "COM Port is in use")
            End Try
        End If
    End Sub

    Public Sub MainDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GetSerialPortNames()
        AutodetectArduinoPort()

        SerialPortListView.SelectedIndex = 0
        SerialPortListView.Select()

        'Try
        'ArduinoSerialPort_Open()
        'ArduinoSerialPort.Write("?")
        'ArduinoSerialPort_Close()
        'Catch
        'End Try
    End Sub

    Private Sub LEDTick0_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick0.CheckedChanged
        If LEDTick0.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(0)
            ArduinoSerialPort_Close()
        ElseIf LEDTick0.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(1)
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub LEDTick1_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick1.CheckedChanged
        If LEDTick1.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(2)
            ArduinoSerialPort_Close()
        ElseIf LEDTick1.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(3)
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub LEDTick2_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick2.CheckedChanged
        If LEDTick2.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(4)
            ArduinoSerialPort_Close()
        ElseIf LEDTick2.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(5)
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub LEDTick3_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick3.CheckedChanged
        If LEDTick3.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(6)
            ArduinoSerialPort_Close()
        ElseIf LEDTick3.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(7)
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub LEDTick4_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick4.CheckedChanged
        If LEDTick4.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(8)
            ArduinoSerialPort_Close()
        ElseIf LEDTick4.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(9)
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub LEDTick5_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick5.CheckedChanged
        If LEDTick5.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(":")
            ArduinoSerialPort_Close()
        ElseIf LEDTick5.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write(";")
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub LEDTick6_CheckedChanged(sender As Object, e As EventArgs) Handles LEDTick6.CheckedChanged
        If LEDTick6.CheckState = CheckState.Checked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write("<")
            ArduinoSerialPort_Close()
        ElseIf LEDTick6.CheckState = CheckState.Unchecked Then
            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write("=")
            ArduinoSerialPort_Close()
        End If
    End Sub

    Private Sub AllOnBtn_Click(sender As Object, e As EventArgs) Handles AllOnBtn.Click
        LEDTick0.Enabled = True
        LEDTick1.Enabled = True
        LEDTick2.Enabled = True
        LEDTick3.Enabled = True
        LEDTick4.Enabled = True
        LEDTick5.Enabled = True
        LEDTick6.Enabled = True

        LEDTick0.CheckState = CheckState.Checked
        LEDTick1.CheckState = CheckState.Checked
        LEDTick2.CheckState = CheckState.Checked
        LEDTick3.CheckState = CheckState.Checked
        LEDTick4.CheckState = CheckState.Checked
        LEDTick5.CheckState = CheckState.Checked
        LEDTick6.CheckState = CheckState.Checked

        If DelayClock.Enabled = True Then
            DelayClock.Enabled = False
        End If

        ArduinoSerialPort_Open()
        ArduinoSerialPort.Write(">")
        ArduinoSerialPort_Close()
    End Sub

    Private Sub AllOffBtn_Click(sender As Object, e As EventArgs) Handles AllOffBtn.Click
        LEDTick0.Enabled = True
        LEDTick1.Enabled = True
        LEDTick2.Enabled = True
        LEDTick3.Enabled = True
        LEDTick4.Enabled = True
        LEDTick5.Enabled = True
        LEDTick6.Enabled = True

        LEDTick0.CheckState = CheckState.Unchecked
        LEDTick1.CheckState = CheckState.Unchecked
        LEDTick2.CheckState = CheckState.Unchecked
        LEDTick3.CheckState = CheckState.Unchecked
        LEDTick4.CheckState = CheckState.Unchecked
        LEDTick5.CheckState = CheckState.Unchecked
        LEDTick6.CheckState = CheckState.Unchecked

        If DelayClock.Enabled = True Then
            DelayClock.Enabled = False
        End If

        ArduinoSerialPort_Open()
        ArduinoSerialPort.Write("?")
        ArduinoSerialPort_Close()
    End Sub

    Private Sub DelayONBtn_Click(sender As Object, e As EventArgs) Handles DelayONBtn.Click
        If DelayClock.Enabled = True Then
            DelayClock.Enabled = False
        End If

        ArduinoSerialPort_Open()
        ArduinoSerialPort.Write("@")
        ArduinoSerialPort_Close()

        LEDTick0.Enabled = True
        LEDTick1.Enabled = True
        LEDTick2.Enabled = True
        LEDTick3.Enabled = True
        LEDTick4.Enabled = True
        LEDTick5.Enabled = True
        LEDTick6.Enabled = True

        LEDTick0.CheckState = CheckState.Checked
        LEDTick1.CheckState = CheckState.Checked
        LEDTick2.CheckState = CheckState.Checked
        LEDTick3.CheckState = CheckState.Checked
        LEDTick4.CheckState = CheckState.Checked
        LEDTick5.CheckState = CheckState.Checked
        LEDTick6.CheckState = CheckState.Checked
    End Sub

    Private Sub DelayOFFBtn_Click(sender As Object, e As EventArgs) Handles DelayOFFBtn.Click
        If DelayClock.Enabled = True Then
            DelayClock.Enabled = False
        End If

        ArduinoSerialPort_Open()
        ArduinoSerialPort.Write("A")
        ArduinoSerialPort_Close()

        LEDTick0.Enabled = True
        LEDTick1.Enabled = True
        LEDTick2.Enabled = True
        LEDTick3.Enabled = True
        LEDTick4.Enabled = True
        LEDTick5.Enabled = True
        LEDTick6.Enabled = True

        LEDTick0.CheckState = CheckState.Unchecked
        LEDTick1.CheckState = CheckState.Unchecked
        LEDTick2.CheckState = CheckState.Unchecked
        LEDTick3.CheckState = CheckState.Unchecked
        LEDTick4.CheckState = CheckState.Unchecked
        LEDTick5.CheckState = CheckState.Unchecked
        LEDTick6.CheckState = CheckState.Unchecked
    End Sub

    Private Sub DelayClock_Tick(sender As Object, e As EventArgs) Handles DelayClock.Tick
        ArduinoSerialPort_Open()
        ArduinoSerialPort.Write("B")
        ArduinoSerialPort_Close()

        LEDTick0.Enabled = False
        LEDTick1.Enabled = False
        LEDTick2.Enabled = False
        LEDTick3.Enabled = False
        LEDTick4.Enabled = False
        LEDTick5.Enabled = False
        LEDTick6.Enabled = False
    End Sub

    Private Sub AllOffOnDelay_Click(sender As Object, e As EventArgs) Handles AllOffOnDelay.Click
        If DelayClock.Enabled = False Then
            LEDTick0.CheckState = CheckState.Unchecked
            LEDTick1.CheckState = CheckState.Unchecked
            LEDTick2.CheckState = CheckState.Unchecked
            LEDTick3.CheckState = CheckState.Unchecked
            LEDTick4.CheckState = CheckState.Unchecked
            LEDTick5.CheckState = CheckState.Unchecked
            LEDTick6.CheckState = CheckState.Unchecked

            LEDTick0.Enabled = False
            LEDTick1.Enabled = False
            LEDTick2.Enabled = False
            LEDTick3.Enabled = False
            LEDTick4.Enabled = False
            LEDTick5.Enabled = False
            LEDTick6.Enabled = False

            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write("B")
            ArduinoSerialPort_Close()

            DelayClock.Enabled = True
        ElseIf DelayClock.Enabled = True Then
            DelayClock.Enabled = False

            ArduinoSerialPort_Open()
            ArduinoSerialPort.Write("A")
            ArduinoSerialPort_Close()

            LEDTick0.Enabled = True
            LEDTick1.Enabled = True
            LEDTick2.Enabled = True
            LEDTick3.Enabled = True
            LEDTick4.Enabled = True
            LEDTick5.Enabled = True
            LEDTick6.Enabled = True
        End If
    End Sub

    Private Sub AuthLbl_Click(sender As Object, e As EventArgs) Handles AuthLbl.Click
        Process.Start("https://www.facebook.com/dev.software.development")
    End Sub

    Private Sub SerialMonitorOpenBtn_Click(sender As Object, e As EventArgs) Handles SerialMonitorOpenBtn.Click
        SerialConsoleDialog.Show()
    End Sub

    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click

        Dim connectionScope As New ManagementScope()
        Dim serialQuery As New SelectQuery("SELECT * FROM Win32_SerialPort")
        Dim searcher As New ManagementObjectSearcher(connectionScope, serialQuery)
        Dim deviceId As String

        Try
            For Each item As ManagementObject In searcher.[Get]()
                deviceId = item("DeviceID").ToString()
            Next
            ArduinoSerialPort.PortName = deviceId
        Catch
        End Try

        ArduinoSerialPort_Open()

        If ArduinoSerialPort.IsOpen = True Then
            ConnectBtn.Hide()
            DisconnectBtn.Show()
            ConnectionStatus = True

            LEDTick0.Enabled = True
            LEDTick1.Enabled = True
            LEDTick2.Enabled = True
            LEDTick3.Enabled = True
            LEDTick4.Enabled = True
            LEDTick5.Enabled = True
            LEDTick6.Enabled = True

            AllOnBtn.Enabled = True
            AllOffBtn.Enabled = True
            DelayONBtn.Enabled = True
            DelayOFFBtn.Enabled = True
            AllOffOnDelay.Enabled = True
        End If
    End Sub

    Private Sub DisconnectBtn_Click(sender As Object, e As EventArgs) Handles DisconnectBtn.Click
        ArduinoSerialPort_Close()

        If ArduinoSerialPort.IsOpen = False Then
            DisconnectBtn.Hide()
            ConnectBtn.Show()
            ConnectionStatus = False

            LEDTick0.Enabled = False
            LEDTick1.Enabled = False
            LEDTick2.Enabled = False
            LEDTick3.Enabled = False
            LEDTick4.Enabled = False
            LEDTick5.Enabled = False
            LEDTick6.Enabled = False

            AllOnBtn.Enabled = False
            AllOffBtn.Enabled = False
            DelayONBtn.Enabled = False
            DelayOFFBtn.Enabled = False
            AllOffOnDelay.Enabled = False
        End If
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        SerialPortListView.Items.Clear()
        AutodetectArduinoPort()
        SerialPortListView.SelectedIndex = 0
        SerialPortListView.Select()
    End Sub
End Class

