Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class SerialConsoleDialog

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

    Public Sub New()
        InitializeComponent()

        ' Initialize MaterialSkinManager
        materialSkinManager = materialSkinManager.Instance
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = materialSkinManager.Themes.DARK
        materialSkinManager.ColorScheme = New ColorScheme(Primary.Indigo600, Primary.Indigo700, Primary.Indigo200, Accent.Indigo400, TextShade.WHITE)

    End Sub

    Private Sub BudSendBtn_Click(sender As Object, e As EventArgs) Handles BudSendBtn.Click
        Try
            MainDialog.DelayClock.Enabled = False
            MainDialog.ArduinoSerialPort_Open()
        Catch
        End Try

        If MainDialog.ArduinoSerialPort.IsOpen = True Then
            MainDialog.ArduinoSerialPort.Write(InputConsole.Text)

            Try
                MainDialog.ArduinoSerialPort_Close()
            Catch
            End Try
        End If
    End Sub

    Private Sub SerialPort_DataReceived()
        If MainDialog.ConnectionStatus = True Then
            Try
                MainDialog.ArduinoSerialPort_Open()
                Dim str As String = MainDialog.ArduinoSerialPort.ReadExisting()
                SerialConsole.AppendText(str)
            Catch
            End Try

        Else
            SerialConsole.AppendText("Not Connected!" + vbNewLine)

        End If

    End Sub

    Private Sub SerialConsoleRefresh_Tick(sender As Object, e As EventArgs) Handles SerialConsoleRefresh.Tick
        SerialPort_DataReceived()
    End Sub

    Private Sub AuthLbl_Click(sender As Object, e As EventArgs) Handles AuthLbl.Click
        Process.Start("https://www.facebook.com/dev.software.development")
    End Sub
End Class