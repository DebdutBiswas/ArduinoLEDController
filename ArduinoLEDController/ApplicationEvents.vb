Imports System.IO

Namespace My

    Class MyApplication

#If _MyType = "WindowsForms" Then

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As ApplicationServices.StartupEventArgs) Handles Me.Startup

            If e.CommandLine.Count > 0 Then
                ' Get the 2 character command line argument
                Dim CommandLineArgument As String = e.CommandLine(0).ToLower(System.Globalization.CultureInfo.InvariantCulture).Trim().Substring(0, 2)
                Select Case CommandLineArgument
                    Case "/m"
                        Me.MainForm = MainDialog
                    Case "/h"
                        Process.Start("https://facebook.com/dev.software.development")
                        End
                    Case Else
                        MessageBox.Show("Invalid Command Line Argument :" + CommandLineArgument, "Invalid Command Line Argument", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End
                End Select

            End If

        End Sub

        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

            MessageBox.Show("Applicaton Can't Start!", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End

        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown

            MainDialog.ArduinoSerialPort_Close()

        End Sub

        'OnInitialize is used for advanced customization of the My Application Model (MyApplication).
        'Startup code for your specific application should be placed in a Startup event handler.
        <Global.System.Diagnostics.DebuggerStepThrough()> _
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean

            Return MyBase.OnInitialize(commandLineArgs)

        End Function
#End If

    End Class

End Namespace