Imports System
Imports System.Threading
Imports System.Diagnostics

Public Class Form1

    Dim dataMasuk As String
    Dim pemisahData As String()
    Dim stopWatch As New Diagnostics.Stopwatch

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            SerialPortArduino.Open()
            If SerialPortArduino.IsOpen Then
                Timer.Enabled = True
                Timer.Start()
            End If
            System.Console.WriteLine("Succes to open the port")
        Catch ex As Exception
            System.Console.WriteLine("Failed to open the port")
            System.Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        stopWatch.Start()
        Dim elapsed As TimeSpan = stopWatch.Elapsed
        RunningTime_TextBox.Text = String.Format("{0:00}:{1:00}:{2:00}",
                                                 elapsed.Hours, elapsed.Minutes, elapsed.Seconds)

        ClockTime_TextBox.Text = Date.Now.ToString("hh:mm:ss")

        Try
            pemisahData = dataMasuk.Split(";")
            Voltage_TextBox.Text = pemisahData(0)
            Current_TextBox.Text = pemisahData(1)
            Power_TextBox.Text = pemisahData(2)

            Energy_TextBox.Text = pemisahData(4)
            CellTemp_TextBox.Text = pemisahData(5)
            Cycle_TextBox.Text = pemisahData(6)

            AmbTemp_TextBox.Text = pemisahData(7)
            AmbHumid_TextBox.Text = pemisahData(8)
            CellFanCool_TextBox.Text = pemisahData(9)

            DCurrentTarget_TextBox.Text = pemisahData(10)
            DPowerTarget_TextBox.Text = pemisahData(11)
            PWMOut_TextBox.Text = pemisahData(12)



        Catch ex As Exception
            System.Console.WriteLine("Failed to split data")
            System.Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub SerialPortArduino_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortArduino.DataReceived
        Try
            dataMasuk = SerialPortArduino.ReadLine()
            System.Console.WriteLine("Succes to read data")
            System.Console.WriteLine(dataMasuk)
        Catch ex As Exception
            System.Console.WriteLine("Failed to read data")
            System.Console.WriteLine(ex.Message)
        End Try
    End Sub

    Dim ticksThisTime As Long = 0
    Dim inputNum As Integer
    Dim timePerParse As Stopwatch

End Class

