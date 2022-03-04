<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RunningTime_Label = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.PWMOut_TextBox = New System.Windows.Forms.TextBox()
        Me.PWMOut_Label = New System.Windows.Forms.Label()
        Me.DPowerTarget_TextBox = New System.Windows.Forms.TextBox()
        Me.DPowerTarget_Label = New System.Windows.Forms.Label()
        Me.DCurrentTarget_TextBox = New System.Windows.Forms.TextBox()
        Me.DCurrentTarget_Label = New System.Windows.Forms.Label()
        Me.CellFanCool_TextBox = New System.Windows.Forms.TextBox()
        Me.CellFanCool_Label = New System.Windows.Forms.Label()
        Me.AmbHumid_TextBox = New System.Windows.Forms.TextBox()
        Me.AmbHumid_Label = New System.Windows.Forms.Label()
        Me.AmbTemp_TextBox = New System.Windows.Forms.TextBox()
        Me.AmbTemp_Label = New System.Windows.Forms.Label()
        Me.Cycle_TextBox = New System.Windows.Forms.TextBox()
        Me.Cycle_Label = New System.Windows.Forms.Label()
        Me.CellTemp_TextBox = New System.Windows.Forms.TextBox()
        Me.CellTemp_Label = New System.Windows.Forms.Label()
        Me.Energy_TextBox = New System.Windows.Forms.TextBox()
        Me.Energy_Label = New System.Windows.Forms.Label()
        Me.Status_TextBox = New System.Windows.Forms.TextBox()
        Me.ClockTime_TextBox = New System.Windows.Forms.TextBox()
        Me.Power_TextBox = New System.Windows.Forms.TextBox()
        Me.Current_TextBox = New System.Windows.Forms.TextBox()
        Me.Power_Label = New System.Windows.Forms.Label()
        Me.Current_Label = New System.Windows.Forms.Label()
        Me.Voltage_TextBox = New System.Windows.Forms.TextBox()
        Me.Voltage_Label = New System.Windows.Forms.Label()
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.ClockTime_Label = New System.Windows.Forms.Label()
        Me.RunningTime_TextBox = New System.Windows.Forms.TextBox()
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.Exit_button = New System.Windows.Forms.Label()
        Me.Title2_Label = New System.Windows.Forms.Label()
        Me.Title1_label = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MainPanel.SuspendLayout()
        Me.RightPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RunningTime_Label
        '
        Me.RunningTime_Label.AutoSize = True
        Me.RunningTime_Label.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.RunningTime_Label.ForeColor = System.Drawing.Color.Teal
        Me.RunningTime_Label.Location = New System.Drawing.Point(26, 17)
        Me.RunningTime_Label.Name = "RunningTime_Label"
        Me.RunningTime_Label.Size = New System.Drawing.Size(145, 30)
        Me.RunningTime_Label.TabIndex = 0
        Me.RunningTime_Label.Tag = "v"
        Me.RunningTime_Label.Text = "Running Time"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MainPanel.Controls.Add(Me.PWMOut_TextBox)
        Me.MainPanel.Controls.Add(Me.PWMOut_Label)
        Me.MainPanel.Controls.Add(Me.DPowerTarget_TextBox)
        Me.MainPanel.Controls.Add(Me.DPowerTarget_Label)
        Me.MainPanel.Controls.Add(Me.DCurrentTarget_TextBox)
        Me.MainPanel.Controls.Add(Me.DCurrentTarget_Label)
        Me.MainPanel.Controls.Add(Me.CellFanCool_TextBox)
        Me.MainPanel.Controls.Add(Me.CellFanCool_Label)
        Me.MainPanel.Controls.Add(Me.AmbHumid_TextBox)
        Me.MainPanel.Controls.Add(Me.AmbHumid_Label)
        Me.MainPanel.Controls.Add(Me.AmbTemp_TextBox)
        Me.MainPanel.Controls.Add(Me.AmbTemp_Label)
        Me.MainPanel.Controls.Add(Me.Cycle_TextBox)
        Me.MainPanel.Controls.Add(Me.Cycle_Label)
        Me.MainPanel.Controls.Add(Me.CellTemp_TextBox)
        Me.MainPanel.Controls.Add(Me.CellTemp_Label)
        Me.MainPanel.Controls.Add(Me.Energy_TextBox)
        Me.MainPanel.Controls.Add(Me.Energy_Label)
        Me.MainPanel.Controls.Add(Me.Status_TextBox)
        Me.MainPanel.Controls.Add(Me.ClockTime_TextBox)
        Me.MainPanel.Controls.Add(Me.Power_TextBox)
        Me.MainPanel.Controls.Add(Me.Current_TextBox)
        Me.MainPanel.Controls.Add(Me.Power_Label)
        Me.MainPanel.Controls.Add(Me.Current_Label)
        Me.MainPanel.Controls.Add(Me.Voltage_TextBox)
        Me.MainPanel.Controls.Add(Me.Voltage_Label)
        Me.MainPanel.Controls.Add(Me.Status_Label)
        Me.MainPanel.Controls.Add(Me.ClockTime_Label)
        Me.MainPanel.Controls.Add(Me.RunningTime_TextBox)
        Me.MainPanel.Controls.Add(Me.RunningTime_Label)
        Me.MainPanel.Location = New System.Drawing.Point(149, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(626, 464)
        Me.MainPanel.TabIndex = 0
        '
        'PWMOut_TextBox
        '
        Me.PWMOut_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.PWMOut_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PWMOut_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PWMOut_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.PWMOut_TextBox.Location = New System.Drawing.Point(459, 392)
        Me.PWMOut_TextBox.Name = "PWMOut_TextBox"
        Me.PWMOut_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.PWMOut_TextBox.TabIndex = 35
        Me.PWMOut_TextBox.Text = "12.241"
        Me.PWMOut_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PWMOut_Label
        '
        Me.PWMOut_Label.AutoSize = True
        Me.PWMOut_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.PWMOut_Label.ForeColor = System.Drawing.Color.Teal
        Me.PWMOut_Label.Location = New System.Drawing.Point(459, 366)
        Me.PWMOut_Label.Name = "PWMOut_Label"
        Me.PWMOut_Label.Size = New System.Drawing.Size(80, 21)
        Me.PWMOut_Label.TabIndex = 34
        Me.PWMOut_Label.Tag = ""
        Me.PWMOut_Label.Text = "PWM Out"
        '
        'DPowerTarget_TextBox
        '
        Me.DPowerTarget_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.DPowerTarget_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DPowerTarget_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DPowerTarget_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DPowerTarget_TextBox.Location = New System.Drawing.Point(249, 392)
        Me.DPowerTarget_TextBox.Name = "DPowerTarget_TextBox"
        Me.DPowerTarget_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.DPowerTarget_TextBox.TabIndex = 33
        Me.DPowerTarget_TextBox.Text = "12.241"
        Me.DPowerTarget_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DPowerTarget_Label
        '
        Me.DPowerTarget_Label.AutoSize = True
        Me.DPowerTarget_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DPowerTarget_Label.ForeColor = System.Drawing.Color.Teal
        Me.DPowerTarget_Label.Location = New System.Drawing.Point(249, 366)
        Me.DPowerTarget_Label.Name = "DPowerTarget_Label"
        Me.DPowerTarget_Label.Size = New System.Drawing.Size(125, 21)
        Me.DPowerTarget_Label.TabIndex = 32
        Me.DPowerTarget_Label.Tag = ""
        Me.DPowerTarget_Label.Text = "D. Power Target"
        '
        'DCurrentTarget_TextBox
        '
        Me.DCurrentTarget_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.DCurrentTarget_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DCurrentTarget_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DCurrentTarget_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DCurrentTarget_TextBox.Location = New System.Drawing.Point(27, 392)
        Me.DCurrentTarget_TextBox.Name = "DCurrentTarget_TextBox"
        Me.DCurrentTarget_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.DCurrentTarget_TextBox.TabIndex = 31
        Me.DCurrentTarget_TextBox.Text = "12.241"
        Me.DCurrentTarget_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DCurrentTarget_Label
        '
        Me.DCurrentTarget_Label.AutoSize = True
        Me.DCurrentTarget_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DCurrentTarget_Label.ForeColor = System.Drawing.Color.Teal
        Me.DCurrentTarget_Label.Location = New System.Drawing.Point(27, 366)
        Me.DCurrentTarget_Label.Name = "DCurrentTarget_Label"
        Me.DCurrentTarget_Label.Size = New System.Drawing.Size(134, 21)
        Me.DCurrentTarget_Label.TabIndex = 30
        Me.DCurrentTarget_Label.Tag = ""
        Me.DCurrentTarget_Label.Text = "D. Current Target"
        '
        'CellFanCool_TextBox
        '
        Me.CellFanCool_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.CellFanCool_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CellFanCool_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CellFanCool_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CellFanCool_TextBox.Location = New System.Drawing.Point(459, 310)
        Me.CellFanCool_TextBox.Name = "CellFanCool_TextBox"
        Me.CellFanCool_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.CellFanCool_TextBox.TabIndex = 29
        Me.CellFanCool_TextBox.Text = "12.241"
        Me.CellFanCool_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CellFanCool_Label
        '
        Me.CellFanCool_Label.AutoSize = True
        Me.CellFanCool_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CellFanCool_Label.ForeColor = System.Drawing.Color.Teal
        Me.CellFanCool_Label.Location = New System.Drawing.Point(459, 284)
        Me.CellFanCool_Label.Name = "CellFanCool_Label"
        Me.CellFanCool_Label.Size = New System.Drawing.Size(126, 21)
        Me.CellFanCool_Label.TabIndex = 28
        Me.CellFanCool_Label.Tag = ""
        Me.CellFanCool_Label.Text = "Cell Fan Cooling"
        '
        'AmbHumid_TextBox
        '
        Me.AmbHumid_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.AmbHumid_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmbHumid_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AmbHumid_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.AmbHumid_TextBox.Location = New System.Drawing.Point(251, 310)
        Me.AmbHumid_TextBox.Name = "AmbHumid_TextBox"
        Me.AmbHumid_TextBox.Size = New System.Drawing.Size(145, 22)
        Me.AmbHumid_TextBox.TabIndex = 27
        Me.AmbHumid_TextBox.Text = "12.241"
        Me.AmbHumid_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmbHumid_Label
        '
        Me.AmbHumid_Label.AutoSize = True
        Me.AmbHumid_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AmbHumid_Label.ForeColor = System.Drawing.Color.Teal
        Me.AmbHumid_Label.Location = New System.Drawing.Point(251, 284)
        Me.AmbHumid_Label.Name = "AmbHumid_Label"
        Me.AmbHumid_Label.Size = New System.Drawing.Size(144, 21)
        Me.AmbHumid_Label.TabIndex = 26
        Me.AmbHumid_Label.Tag = ""
        Me.AmbHumid_Label.Text = "Ambient Humidity"
        '
        'AmbTemp_TextBox
        '
        Me.AmbTemp_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.AmbTemp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmbTemp_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AmbTemp_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.AmbTemp_TextBox.Location = New System.Drawing.Point(27, 310)
        Me.AmbTemp_TextBox.Name = "AmbTemp_TextBox"
        Me.AmbTemp_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.AmbTemp_TextBox.TabIndex = 25
        Me.AmbTemp_TextBox.Text = "12.241"
        Me.AmbTemp_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmbTemp_Label
        '
        Me.AmbTemp_Label.AutoSize = True
        Me.AmbTemp_Label.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbTemp_Label.ForeColor = System.Drawing.Color.Teal
        Me.AmbTemp_Label.Location = New System.Drawing.Point(27, 284)
        Me.AmbTemp_Label.Name = "AmbTemp_Label"
        Me.AmbTemp_Label.Size = New System.Drawing.Size(141, 17)
        Me.AmbTemp_Label.TabIndex = 24
        Me.AmbTemp_Label.Tag = ""
        Me.AmbTemp_Label.Text = "Ambient Temperature"
        '
        'Cycle_TextBox
        '
        Me.Cycle_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Cycle_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cycle_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cycle_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Cycle_TextBox.Location = New System.Drawing.Point(459, 220)
        Me.Cycle_TextBox.Name = "Cycle_TextBox"
        Me.Cycle_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.Cycle_TextBox.TabIndex = 23
        Me.Cycle_TextBox.Text = "12.715"
        Me.Cycle_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cycle_Label
        '
        Me.Cycle_Label.AutoSize = True
        Me.Cycle_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Cycle_Label.ForeColor = System.Drawing.Color.Teal
        Me.Cycle_Label.Location = New System.Drawing.Point(459, 194)
        Me.Cycle_Label.Name = "Cycle_Label"
        Me.Cycle_Label.Size = New System.Drawing.Size(49, 21)
        Me.Cycle_Label.TabIndex = 22
        Me.Cycle_Label.Tag = ""
        Me.Cycle_Label.Text = "Cycle"
        '
        'CellTemp_TextBox
        '
        Me.CellTemp_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.CellTemp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CellTemp_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CellTemp_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CellTemp_TextBox.Location = New System.Drawing.Point(250, 220)
        Me.CellTemp_TextBox.Name = "CellTemp_TextBox"
        Me.CellTemp_TextBox.Size = New System.Drawing.Size(145, 22)
        Me.CellTemp_TextBox.TabIndex = 21
        Me.CellTemp_TextBox.Text = "12.715"
        Me.CellTemp_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CellTemp_Label
        '
        Me.CellTemp_Label.AutoSize = True
        Me.CellTemp_Label.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.CellTemp_Label.ForeColor = System.Drawing.Color.Teal
        Me.CellTemp_Label.Location = New System.Drawing.Point(250, 194)
        Me.CellTemp_Label.Name = "CellTemp_Label"
        Me.CellTemp_Label.Size = New System.Drawing.Size(124, 20)
        Me.CellTemp_Label.TabIndex = 20
        Me.CellTemp_Label.Tag = ""
        Me.CellTemp_Label.Text = "Cell Temperature"
        '
        'Energy_TextBox
        '
        Me.Energy_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Energy_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Energy_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Energy_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Energy_TextBox.Location = New System.Drawing.Point(27, 219)
        Me.Energy_TextBox.Name = "Energy_TextBox"
        Me.Energy_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.Energy_TextBox.TabIndex = 19
        Me.Energy_TextBox.Text = "12.241"
        Me.Energy_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Energy_Label
        '
        Me.Energy_Label.AutoSize = True
        Me.Energy_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Energy_Label.ForeColor = System.Drawing.Color.Teal
        Me.Energy_Label.Location = New System.Drawing.Point(27, 193)
        Me.Energy_Label.Name = "Energy_Label"
        Me.Energy_Label.Size = New System.Drawing.Size(60, 21)
        Me.Energy_Label.TabIndex = 18
        Me.Energy_Label.Tag = ""
        Me.Energy_Label.Text = "Energy"
        '
        'Status_TextBox
        '
        Me.Status_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Status_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Status_TextBox.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Status_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Status_TextBox.Location = New System.Drawing.Point(455, 52)
        Me.Status_TextBox.Name = "Status_TextBox"
        Me.Status_TextBox.Size = New System.Drawing.Size(104, 19)
        Me.Status_TextBox.TabIndex = 17
        Me.Status_TextBox.Text = "CYCLE TEST"
        Me.Status_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClockTime_TextBox
        '
        Me.ClockTime_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ClockTime_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClockTime_TextBox.Font = New System.Drawing.Font("Symbol", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ClockTime_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.ClockTime_TextBox.Location = New System.Drawing.Point(249, 52)
        Me.ClockTime_TextBox.Name = "ClockTime_TextBox"
        Me.ClockTime_TextBox.Size = New System.Drawing.Size(104, 20)
        Me.ClockTime_TextBox.TabIndex = 16
        Me.ClockTime_TextBox.Text = "00 : 00 : 00"
        Me.ClockTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Power_TextBox
        '
        Me.Power_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Power_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Power_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Power_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Power_TextBox.Location = New System.Drawing.Point(459, 135)
        Me.Power_TextBox.Name = "Power_TextBox"
        Me.Power_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.Power_TextBox.TabIndex = 15
        Me.Power_TextBox.Text = "68.788"
        Me.Power_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Current_TextBox
        '
        Me.Current_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Current_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Current_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Current_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Current_TextBox.Location = New System.Drawing.Point(250, 135)
        Me.Current_TextBox.Name = "Current_TextBox"
        Me.Current_TextBox.Size = New System.Drawing.Size(145, 22)
        Me.Current_TextBox.TabIndex = 14
        Me.Current_TextBox.Text = "5.411"
        Me.Current_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Power_Label
        '
        Me.Power_Label.AutoSize = True
        Me.Power_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Power_Label.ForeColor = System.Drawing.Color.Teal
        Me.Power_Label.Location = New System.Drawing.Point(459, 109)
        Me.Power_Label.Name = "Power_Label"
        Me.Power_Label.Size = New System.Drawing.Size(56, 21)
        Me.Power_Label.TabIndex = 13
        Me.Power_Label.Tag = "v"
        Me.Power_Label.Text = "Power"
        '
        'Current_Label
        '
        Me.Current_Label.AutoSize = True
        Me.Current_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Current_Label.ForeColor = System.Drawing.Color.Teal
        Me.Current_Label.Location = New System.Drawing.Point(250, 109)
        Me.Current_Label.Name = "Current_Label"
        Me.Current_Label.Size = New System.Drawing.Size(65, 21)
        Me.Current_Label.TabIndex = 11
        Me.Current_Label.Tag = "v"
        Me.Current_Label.Text = "Current"
        '
        'Voltage_TextBox
        '
        Me.Voltage_TextBox.BackColor = System.Drawing.Color.LightCyan
        Me.Voltage_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Voltage_TextBox.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Voltage_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Voltage_TextBox.Location = New System.Drawing.Point(27, 135)
        Me.Voltage_TextBox.Name = "Voltage_TextBox"
        Me.Voltage_TextBox.Size = New System.Drawing.Size(146, 22)
        Me.Voltage_TextBox.TabIndex = 10
        Me.Voltage_TextBox.Text = "12.715"
        Me.Voltage_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Voltage_Label
        '
        Me.Voltage_Label.AutoSize = True
        Me.Voltage_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Voltage_Label.ForeColor = System.Drawing.Color.Teal
        Me.Voltage_Label.Location = New System.Drawing.Point(27, 109)
        Me.Voltage_Label.Name = "Voltage_Label"
        Me.Voltage_Label.Size = New System.Drawing.Size(66, 21)
        Me.Voltage_Label.TabIndex = 9
        Me.Voltage_Label.Tag = ""
        Me.Voltage_Label.Text = "Voltage"
        '
        'Status_Label
        '
        Me.Status_Label.AutoSize = True
        Me.Status_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Status_Label.ForeColor = System.Drawing.Color.Teal
        Me.Status_Label.Location = New System.Drawing.Point(455, 26)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Size = New System.Drawing.Size(55, 21)
        Me.Status_Label.TabIndex = 8
        Me.Status_Label.Tag = "v"
        Me.Status_Label.Text = "Status"
        '
        'ClockTime_Label
        '
        Me.ClockTime_Label.AutoSize = True
        Me.ClockTime_Label.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ClockTime_Label.ForeColor = System.Drawing.Color.Teal
        Me.ClockTime_Label.Location = New System.Drawing.Point(249, 26)
        Me.ClockTime_Label.Name = "ClockTime_Label"
        Me.ClockTime_Label.Size = New System.Drawing.Size(90, 21)
        Me.ClockTime_Label.TabIndex = 7
        Me.ClockTime_Label.Tag = "v"
        Me.ClockTime_Label.Text = "Clock Time"
        '
        'RunningTime_TextBox
        '
        Me.RunningTime_TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.RunningTime_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RunningTime_TextBox.Font = New System.Drawing.Font("Symbol", 14.25!, System.Drawing.FontStyle.Bold)
        Me.RunningTime_TextBox.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.RunningTime_TextBox.Location = New System.Drawing.Point(31, 50)
        Me.RunningTime_TextBox.Name = "RunningTime_TextBox"
        Me.RunningTime_TextBox.Size = New System.Drawing.Size(140, 24)
        Me.RunningTime_TextBox.TabIndex = 4
        Me.RunningTime_TextBox.Text = "00 : 00 : 00"
        Me.RunningTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.Teal
        Me.RightPanel.Controls.Add(Me.Exit_button)
        Me.RightPanel.Controls.Add(Me.Title2_Label)
        Me.RightPanel.Controls.Add(Me.Title1_label)
        Me.RightPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RightPanel.Location = New System.Drawing.Point(-3, 0)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(161, 464)
        Me.RightPanel.TabIndex = 1
        '
        'Exit_button
        '
        Me.Exit_button.AutoSize = True
        Me.Exit_button.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Exit_button.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.Exit_button.Location = New System.Drawing.Point(15, 432)
        Me.Exit_button.Name = "Exit_button"
        Me.Exit_button.Size = New System.Drawing.Size(34, 21)
        Me.Exit_button.TabIndex = 2
        Me.Exit_button.Text = "Exit"
        '
        'Title2_Label
        '
        Me.Title2_Label.AutoSize = True
        Me.Title2_Label.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Title2_Label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Title2_Label.Location = New System.Drawing.Point(32, 42)
        Me.Title2_Label.Name = "Title2_Label"
        Me.Title2_Label.Size = New System.Drawing.Size(114, 31)
        Me.Title2_Label.TabIndex = 1
        Me.Title2_Label.Text = "Monitor"
        '
        'Title1_label
        '
        Me.Title1_label.AutoSize = True
        Me.Title1_label.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Title1_label.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Title1_label.Location = New System.Drawing.Point(39, 16)
        Me.Title1_label.Name = "Title1_label"
        Me.Title1_label.Size = New System.Drawing.Size(88, 31)
        Me.Title1_label.TabIndex = 0
        Me.Title1_label.Text = " Panel"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 462)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.RightPanel.ResumeLayout(False)
        Me.RightPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RunningTime_Label As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents RightPanel As Panel
    Friend WithEvents Title1_label As Label

    Private Sub MainPanel_Paint(sender As Object, e As PaintEventArgs) Handles MainPanel.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Title1_label.Click

    End Sub
    Friend WithEvents Title2_Label As Label

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Status_Label As Label
    Friend WithEvents ClockTime_Label As Label
    Friend WithEvents RunningTime_TextBox As TextBox
    Friend WithEvents Power_Label As Label
    Friend WithEvents Current_Label As Label
    Friend WithEvents Voltage_TextBox As TextBox
    Friend WithEvents Voltage_Label As Label


    Friend WithEvents Cycle_TextBox As TextBox
    Friend WithEvents Cycle_Label As Label
    Friend WithEvents CellTemp_TextBox As TextBox
    Friend WithEvents CellTemp_Label As Label
    Friend WithEvents Energy_TextBox As TextBox
    Friend WithEvents Energy_Label As Label
    Friend WithEvents Status_TextBox As TextBox
    Friend WithEvents ClockTime_TextBox As TextBox
    Friend WithEvents Power_TextBox As TextBox
    Friend WithEvents Current_TextBox As TextBox
    Friend WithEvents PWMOut_TextBox As TextBox
    Friend WithEvents PWMOut_Label As Label
    Friend WithEvents DPowerTarget_TextBox As TextBox
    Friend WithEvents DPowerTarget_Label As Label
    Friend WithEvents DCurrentTarget_TextBox As TextBox
    Friend WithEvents DCurrentTarget_Label As Label
    Friend WithEvents CellFanCool_TextBox As TextBox
    Friend WithEvents CellFanCool_Label As Label
    Friend WithEvents AmbHumid_TextBox As TextBox
    Friend WithEvents AmbHumid_Label As Label
    Friend WithEvents AmbTemp_TextBox As TextBox
    Friend WithEvents AmbTemp_Label As Label
    Friend WithEvents Exit_button As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
