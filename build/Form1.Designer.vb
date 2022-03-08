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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RightPanel = New System.Windows.Forms.Panel()
        Me.Exit_Button = New System.Windows.Forms.Button()
        Me.LogoMTI_PictureBox = New System.Windows.Forms.PictureBox()
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DCurrentTarget_Panel = New System.Windows.Forms.Panel()
        Me.dcurrentarget_unit = New System.Windows.Forms.Label()
        Me.DCurrentTarget_TextBox = New System.Windows.Forms.TextBox()
        Me.DCurrentTarget_Label = New System.Windows.Forms.Label()
        Me.DPowerTarget_Panel = New System.Windows.Forms.Panel()
        Me.dpowertarget_unit = New System.Windows.Forms.Label()
        Me.DPowerTarget_TextBox = New System.Windows.Forms.TextBox()
        Me.DPowerTarget_Label = New System.Windows.Forms.Label()
        Me.PWMOut_Panel = New System.Windows.Forms.Panel()
        Me.pwmout_unit = New System.Windows.Forms.Label()
        Me.PWMOut_TextBox = New System.Windows.Forms.TextBox()
        Me.PWMOut_Label = New System.Windows.Forms.Label()
        Me.CellFanCool_Panel = New System.Windows.Forms.Panel()
        Me.cellfancool_unit = New System.Windows.Forms.Label()
        Me.CellFanCool_TextBox = New System.Windows.Forms.TextBox()
        Me.CellFanCool_Label = New System.Windows.Forms.Label()
        Me.AmbHumid_Panel = New System.Windows.Forms.Panel()
        Me.ambhumid_unit = New System.Windows.Forms.Label()
        Me.AmbHumid_TextBox = New System.Windows.Forms.TextBox()
        Me.AmbientHumid_Label = New System.Windows.Forms.Label()
        Me.AmbTemp_Panel = New System.Windows.Forms.Panel()
        Me.ambtemp_unit = New System.Windows.Forms.Label()
        Me.AmbTemp_TextBox = New System.Windows.Forms.TextBox()
        Me.AmbientTemp_Label = New System.Windows.Forms.Label()
        Me.Cycle_Panel = New System.Windows.Forms.Panel()
        Me.Cycle_TextBox = New System.Windows.Forms.TextBox()
        Me.Cycle_Label = New System.Windows.Forms.Label()
        Me.CellTemp_Panel = New System.Windows.Forms.Panel()
        Me.celltemp_unit = New System.Windows.Forms.Label()
        Me.CellTemp_TextBox = New System.Windows.Forms.TextBox()
        Me.CellTemp_Label = New System.Windows.Forms.Label()
        Me.Energy_Panel = New System.Windows.Forms.Panel()
        Me.energy_unit = New System.Windows.Forms.Label()
        Me.Energy_TextBox = New System.Windows.Forms.TextBox()
        Me.Energy_Label = New System.Windows.Forms.Label()
        Me.Voltage_Panel = New System.Windows.Forms.Panel()
        Me.Voltage_unit = New System.Windows.Forms.Label()
        Me.Voltage_TextBox = New System.Windows.Forms.TextBox()
        Me.Voltage_Label = New System.Windows.Forms.Label()
        Me.Current_Panel = New System.Windows.Forms.Panel()
        Me.Current_unit = New System.Windows.Forms.Label()
        Me.Current_TextBox = New System.Windows.Forms.TextBox()
        Me.Current_Label = New System.Windows.Forms.Label()
        Me.Power_Panel = New System.Windows.Forms.Panel()
        Me.power_unit = New System.Windows.Forms.Label()
        Me.Power_TextBox = New System.Windows.Forms.TextBox()
        Me.Power_Label = New System.Windows.Forms.Label()
        Me.Status_Panel = New System.Windows.Forms.Panel()
        Me.Status_TextBox = New System.Windows.Forms.TextBox()
        Me.Status_Label = New System.Windows.Forms.Label()
        Me.ClockTime_Panel = New System.Windows.Forms.Panel()
        Me.ClockTime_TextBox = New System.Windows.Forms.TextBox()
        Me.ClockTime_Label = New System.Windows.Forms.Label()
        Me.RunningTime_Panel = New System.Windows.Forms.Panel()
        Me.RunningText_Label = New System.Windows.Forms.Label()
        Me.RunningTime_TextBox = New System.Windows.Forms.TextBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.RightPanel.SuspendLayout()
        CType(Me.LogoMTI_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.TableLayoutPanel.SuspendLayout()
        Me.DCurrentTarget_Panel.SuspendLayout()
        Me.DPowerTarget_Panel.SuspendLayout()
        Me.PWMOut_Panel.SuspendLayout()
        Me.CellFanCool_Panel.SuspendLayout()
        Me.AmbHumid_Panel.SuspendLayout()
        Me.AmbTemp_Panel.SuspendLayout()
        Me.Cycle_Panel.SuspendLayout()
        Me.CellTemp_Panel.SuspendLayout()
        Me.Energy_Panel.SuspendLayout()
        Me.Voltage_Panel.SuspendLayout()
        Me.Current_Panel.SuspendLayout()
        Me.Power_Panel.SuspendLayout()
        Me.Status_Panel.SuspendLayout()
        Me.ClockTime_Panel.SuspendLayout()
        Me.RunningTime_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.AliceBlue
        Me.RightPanel.Controls.Add(Me.Exit_Button)
        Me.RightPanel.Controls.Add(Me.LogoMTI_PictureBox)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.RightPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RightPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(333, 764)
        Me.RightPanel.TabIndex = 1
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.DarkOrange
        Me.Exit_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(0, 720)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(333, 44)
        Me.Exit_Button.TabIndex = 3
        Me.Exit_Button.Text = "Exit"
        Me.Exit_Button.UseVisualStyleBackColor = False
        '
        'LogoMTI_PictureBox
        '
        Me.LogoMTI_PictureBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.LogoMTI_PictureBox.Image = CType(resources.GetObject("LogoMTI_PictureBox.Image"), System.Drawing.Image)
        Me.LogoMTI_PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoMTI_PictureBox.Name = "LogoMTI_PictureBox"
        Me.LogoMTI_PictureBox.Size = New System.Drawing.Size(333, 244)
        Me.LogoMTI_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoMTI_PictureBox.TabIndex = 2
        Me.LogoMTI_PictureBox.TabStop = False
        '
        'SerialPortArduino
        '
        Me.SerialPortArduino.PortName = "COM3"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.SeaShell
        Me.MainPanel.Controls.Add(Me.TableLayoutPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1273, 764)
        Me.MainPanel.TabIndex = 0
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel.ColumnCount = 3
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel.Controls.Add(Me.DCurrentTarget_Panel, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.DPowerTarget_Panel, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.PWMOut_Panel, 2, 4)
        Me.TableLayoutPanel.Controls.Add(Me.CellFanCool_Panel, 2, 3)
        Me.TableLayoutPanel.Controls.Add(Me.AmbHumid_Panel, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.AmbTemp_Panel, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.Cycle_Panel, 2, 2)
        Me.TableLayoutPanel.Controls.Add(Me.CellTemp_Panel, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.Energy_Panel, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.Voltage_Panel, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.Current_Panel, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.Power_Panel, 2, 1)
        Me.TableLayoutPanel.Controls.Add(Me.Status_Panel, 2, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ClockTime_Panel, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.RunningTime_Panel, 0, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(455, 40)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 5
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(711, 495)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'DCurrentTarget_Panel
        '
        Me.DCurrentTarget_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DCurrentTarget_Panel.BackColor = System.Drawing.Color.Bisque
        Me.DCurrentTarget_Panel.Controls.Add(Me.dcurrentarget_unit)
        Me.DCurrentTarget_Panel.Controls.Add(Me.DCurrentTarget_TextBox)
        Me.DCurrentTarget_Panel.Controls.Add(Me.DCurrentTarget_Label)
        Me.DCurrentTarget_Panel.Location = New System.Drawing.Point(8, 404)
        Me.DCurrentTarget_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.DCurrentTarget_Panel.Name = "DCurrentTarget_Panel"
        Me.DCurrentTarget_Panel.Size = New System.Drawing.Size(220, 83)
        Me.DCurrentTarget_Panel.TabIndex = 1
        '
        'dcurrentarget_unit
        '
        Me.dcurrentarget_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dcurrentarget_unit.AutoSize = True
        Me.dcurrentarget_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dcurrentarget_unit.Location = New System.Drawing.Point(197, 48)
        Me.dcurrentarget_unit.Name = "dcurrentarget_unit"
        Me.dcurrentarget_unit.Size = New System.Drawing.Size(20, 20)
        Me.dcurrentarget_unit.TabIndex = 7
        Me.dcurrentarget_unit.Text = "A"
        '
        'DCurrentTarget_TextBox
        '
        Me.DCurrentTarget_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DCurrentTarget_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.DCurrentTarget_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DCurrentTarget_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DCurrentTarget_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DCurrentTarget_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.DCurrentTarget_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.DCurrentTarget_TextBox.Name = "DCurrentTarget_TextBox"
        Me.DCurrentTarget_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.DCurrentTarget_TextBox.TabIndex = 3
        Me.DCurrentTarget_TextBox.Text = "28.01"
        Me.DCurrentTarget_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DCurrentTarget_Label
        '
        Me.DCurrentTarget_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DCurrentTarget_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.DCurrentTarget_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DCurrentTarget_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DCurrentTarget_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DCurrentTarget_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.DCurrentTarget_Label.Location = New System.Drawing.Point(0, 0)
        Me.DCurrentTarget_Label.Name = "DCurrentTarget_Label"
        Me.DCurrentTarget_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.DCurrentTarget_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DCurrentTarget_Label.Size = New System.Drawing.Size(220, 37)
        Me.DCurrentTarget_Label.TabIndex = 2
        Me.DCurrentTarget_Label.Text = "D. Current Target"
        Me.DCurrentTarget_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DPowerTarget_Panel
        '
        Me.DPowerTarget_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DPowerTarget_Panel.BackColor = System.Drawing.Color.Bisque
        Me.DPowerTarget_Panel.Controls.Add(Me.dpowertarget_unit)
        Me.DPowerTarget_Panel.Controls.Add(Me.DPowerTarget_TextBox)
        Me.DPowerTarget_Panel.Controls.Add(Me.DPowerTarget_Label)
        Me.DPowerTarget_Panel.Location = New System.Drawing.Point(244, 404)
        Me.DPowerTarget_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.DPowerTarget_Panel.Name = "DPowerTarget_Panel"
        Me.DPowerTarget_Panel.Size = New System.Drawing.Size(221, 83)
        Me.DPowerTarget_Panel.TabIndex = 1
        '
        'dpowertarget_unit
        '
        Me.dpowertarget_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpowertarget_unit.AutoSize = True
        Me.dpowertarget_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpowertarget_unit.Location = New System.Drawing.Point(194, 48)
        Me.dpowertarget_unit.Name = "dpowertarget_unit"
        Me.dpowertarget_unit.Size = New System.Drawing.Size(24, 20)
        Me.dpowertarget_unit.TabIndex = 7
        Me.dpowertarget_unit.Text = "W"
        '
        'DPowerTarget_TextBox
        '
        Me.DPowerTarget_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DPowerTarget_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.DPowerTarget_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DPowerTarget_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DPowerTarget_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPowerTarget_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.DPowerTarget_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.DPowerTarget_TextBox.Name = "DPowerTarget_TextBox"
        Me.DPowerTarget_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.DPowerTarget_TextBox.TabIndex = 4
        Me.DPowerTarget_TextBox.Text = "-"
        Me.DPowerTarget_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DPowerTarget_Label
        '
        Me.DPowerTarget_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DPowerTarget_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.DPowerTarget_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DPowerTarget_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DPowerTarget_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DPowerTarget_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.DPowerTarget_Label.Location = New System.Drawing.Point(0, 0)
        Me.DPowerTarget_Label.Name = "DPowerTarget_Label"
        Me.DPowerTarget_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.DPowerTarget_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DPowerTarget_Label.Size = New System.Drawing.Size(221, 37)
        Me.DPowerTarget_Label.TabIndex = 2
        Me.DPowerTarget_Label.Text = "D. Power Target"
        Me.DPowerTarget_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PWMOut_Panel
        '
        Me.PWMOut_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PWMOut_Panel.BackColor = System.Drawing.Color.Bisque
        Me.PWMOut_Panel.Controls.Add(Me.pwmout_unit)
        Me.PWMOut_Panel.Controls.Add(Me.PWMOut_TextBox)
        Me.PWMOut_Panel.Controls.Add(Me.PWMOut_Label)
        Me.PWMOut_Panel.Location = New System.Drawing.Point(481, 404)
        Me.PWMOut_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.PWMOut_Panel.Name = "PWMOut_Panel"
        Me.PWMOut_Panel.Size = New System.Drawing.Size(222, 83)
        Me.PWMOut_Panel.TabIndex = 1
        '
        'pwmout_unit
        '
        Me.pwmout_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pwmout_unit.AutoSize = True
        Me.pwmout_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwmout_unit.Location = New System.Drawing.Point(196, 48)
        Me.pwmout_unit.Name = "pwmout_unit"
        Me.pwmout_unit.Size = New System.Drawing.Size(23, 20)
        Me.pwmout_unit.TabIndex = 8
        Me.pwmout_unit.Text = "%"
        '
        'PWMOut_TextBox
        '
        Me.PWMOut_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PWMOut_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.PWMOut_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PWMOut_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PWMOut_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PWMOut_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.PWMOut_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.PWMOut_TextBox.Name = "PWMOut_TextBox"
        Me.PWMOut_TextBox.Size = New System.Drawing.Size(211, 28)
        Me.PWMOut_TextBox.TabIndex = 5
        Me.PWMOut_TextBox.Text = "40"
        Me.PWMOut_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PWMOut_Label
        '
        Me.PWMOut_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PWMOut_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.PWMOut_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PWMOut_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PWMOut_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PWMOut_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.PWMOut_Label.Location = New System.Drawing.Point(0, 0)
        Me.PWMOut_Label.Name = "PWMOut_Label"
        Me.PWMOut_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.PWMOut_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PWMOut_Label.Size = New System.Drawing.Size(222, 37)
        Me.PWMOut_Label.TabIndex = 2
        Me.PWMOut_Label.Text = "PWM Out"
        Me.PWMOut_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CellFanCool_Panel
        '
        Me.CellFanCool_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellFanCool_Panel.BackColor = System.Drawing.Color.Bisque
        Me.CellFanCool_Panel.Controls.Add(Me.cellfancool_unit)
        Me.CellFanCool_Panel.Controls.Add(Me.CellFanCool_TextBox)
        Me.CellFanCool_Panel.Controls.Add(Me.CellFanCool_Label)
        Me.CellFanCool_Panel.Location = New System.Drawing.Point(481, 305)
        Me.CellFanCool_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.CellFanCool_Panel.Name = "CellFanCool_Panel"
        Me.CellFanCool_Panel.Size = New System.Drawing.Size(222, 83)
        Me.CellFanCool_Panel.TabIndex = 1
        '
        'cellfancool_unit
        '
        Me.cellfancool_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cellfancool_unit.AutoSize = True
        Me.cellfancool_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cellfancool_unit.Location = New System.Drawing.Point(199, 48)
        Me.cellfancool_unit.Name = "cellfancool_unit"
        Me.cellfancool_unit.Size = New System.Drawing.Size(20, 20)
        Me.cellfancool_unit.TabIndex = 8
        Me.cellfancool_unit.Text = "V"
        '
        'CellFanCool_TextBox
        '
        Me.CellFanCool_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellFanCool_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.CellFanCool_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CellFanCool_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CellFanCool_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CellFanCool_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CellFanCool_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.CellFanCool_TextBox.Name = "CellFanCool_TextBox"
        Me.CellFanCool_TextBox.ReadOnly = True
        Me.CellFanCool_TextBox.Size = New System.Drawing.Size(211, 28)
        Me.CellFanCool_TextBox.TabIndex = 3
        Me.CellFanCool_TextBox.Text = "ON"
        Me.CellFanCool_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CellFanCool_Label
        '
        Me.CellFanCool_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellFanCool_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.CellFanCool_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CellFanCool_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CellFanCool_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CellFanCool_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.CellFanCool_Label.Location = New System.Drawing.Point(0, 0)
        Me.CellFanCool_Label.Name = "CellFanCool_Label"
        Me.CellFanCool_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.CellFanCool_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CellFanCool_Label.Size = New System.Drawing.Size(222, 37)
        Me.CellFanCool_Label.TabIndex = 2
        Me.CellFanCool_Label.Text = "Cell Fan Cooling"
        Me.CellFanCool_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AmbHumid_Panel
        '
        Me.AmbHumid_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbHumid_Panel.BackColor = System.Drawing.Color.Bisque
        Me.AmbHumid_Panel.Controls.Add(Me.ambhumid_unit)
        Me.AmbHumid_Panel.Controls.Add(Me.AmbHumid_TextBox)
        Me.AmbHumid_Panel.Controls.Add(Me.AmbientHumid_Label)
        Me.AmbHumid_Panel.Location = New System.Drawing.Point(244, 305)
        Me.AmbHumid_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.AmbHumid_Panel.Name = "AmbHumid_Panel"
        Me.AmbHumid_Panel.Size = New System.Drawing.Size(221, 83)
        Me.AmbHumid_Panel.TabIndex = 1
        '
        'ambhumid_unit
        '
        Me.ambhumid_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ambhumid_unit.AutoSize = True
        Me.ambhumid_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ambhumid_unit.Location = New System.Drawing.Point(195, 48)
        Me.ambhumid_unit.Name = "ambhumid_unit"
        Me.ambhumid_unit.Size = New System.Drawing.Size(23, 20)
        Me.ambhumid_unit.TabIndex = 7
        Me.ambhumid_unit.Text = "%"
        '
        'AmbHumid_TextBox
        '
        Me.AmbHumid_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbHumid_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.AmbHumid_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmbHumid_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AmbHumid_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbHumid_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.AmbHumid_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.AmbHumid_TextBox.Name = "AmbHumid_TextBox"
        Me.AmbHumid_TextBox.ReadOnly = True
        Me.AmbHumid_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.AmbHumid_TextBox.TabIndex = 3
        Me.AmbHumid_TextBox.Text = "71"
        Me.AmbHumid_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmbientHumid_Label
        '
        Me.AmbientHumid_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbientHumid_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.AmbientHumid_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AmbientHumid_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AmbientHumid_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientHumid_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.AmbientHumid_Label.Location = New System.Drawing.Point(0, 0)
        Me.AmbientHumid_Label.Name = "AmbientHumid_Label"
        Me.AmbientHumid_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.AmbientHumid_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AmbientHumid_Label.Size = New System.Drawing.Size(221, 37)
        Me.AmbientHumid_Label.TabIndex = 2
        Me.AmbientHumid_Label.Text = "Ambient Humidity"
        Me.AmbientHumid_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AmbTemp_Panel
        '
        Me.AmbTemp_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbTemp_Panel.BackColor = System.Drawing.Color.Bisque
        Me.AmbTemp_Panel.Controls.Add(Me.ambtemp_unit)
        Me.AmbTemp_Panel.Controls.Add(Me.AmbTemp_TextBox)
        Me.AmbTemp_Panel.Controls.Add(Me.AmbientTemp_Label)
        Me.AmbTemp_Panel.Location = New System.Drawing.Point(8, 305)
        Me.AmbTemp_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.AmbTemp_Panel.Name = "AmbTemp_Panel"
        Me.AmbTemp_Panel.Size = New System.Drawing.Size(220, 83)
        Me.AmbTemp_Panel.TabIndex = 1
        '
        'ambtemp_unit
        '
        Me.ambtemp_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ambtemp_unit.AutoSize = True
        Me.ambtemp_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ambtemp_unit.Location = New System.Drawing.Point(197, 48)
        Me.ambtemp_unit.Name = "ambtemp_unit"
        Me.ambtemp_unit.Size = New System.Drawing.Size(20, 20)
        Me.ambtemp_unit.TabIndex = 6
        Me.ambtemp_unit.Text = "C"
        '
        'AmbTemp_TextBox
        '
        Me.AmbTemp_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbTemp_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.AmbTemp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AmbTemp_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AmbTemp_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbTemp_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.AmbTemp_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.AmbTemp_TextBox.Name = "AmbTemp_TextBox"
        Me.AmbTemp_TextBox.ReadOnly = True
        Me.AmbTemp_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.AmbTemp_TextBox.TabIndex = 3
        Me.AmbTemp_TextBox.Text = "28.01"
        Me.AmbTemp_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AmbientTemp_Label
        '
        Me.AmbientTemp_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmbientTemp_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.AmbientTemp_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AmbientTemp_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AmbientTemp_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmbientTemp_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.AmbientTemp_Label.Location = New System.Drawing.Point(0, 0)
        Me.AmbientTemp_Label.Name = "AmbientTemp_Label"
        Me.AmbientTemp_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.AmbientTemp_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AmbientTemp_Label.Size = New System.Drawing.Size(220, 37)
        Me.AmbientTemp_Label.TabIndex = 2
        Me.AmbientTemp_Label.Text = "Ambient Temperature"
        Me.AmbientTemp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cycle_Panel
        '
        Me.Cycle_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cycle_Panel.BackColor = System.Drawing.Color.Bisque
        Me.Cycle_Panel.Controls.Add(Me.Cycle_TextBox)
        Me.Cycle_Panel.Controls.Add(Me.Cycle_Label)
        Me.Cycle_Panel.Location = New System.Drawing.Point(481, 206)
        Me.Cycle_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.Cycle_Panel.Name = "Cycle_Panel"
        Me.Cycle_Panel.Size = New System.Drawing.Size(222, 83)
        Me.Cycle_Panel.TabIndex = 1
        '
        'Cycle_TextBox
        '
        Me.Cycle_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cycle_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.Cycle_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Cycle_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Cycle_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cycle_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Cycle_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.Cycle_TextBox.Name = "Cycle_TextBox"
        Me.Cycle_TextBox.ReadOnly = True
        Me.Cycle_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.Cycle_TextBox.TabIndex = 3
        Me.Cycle_TextBox.Text = "35"
        Me.Cycle_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cycle_Label
        '
        Me.Cycle_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cycle_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Cycle_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cycle_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cycle_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cycle_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Cycle_Label.Location = New System.Drawing.Point(0, 0)
        Me.Cycle_Label.Name = "Cycle_Label"
        Me.Cycle_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Cycle_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cycle_Label.Size = New System.Drawing.Size(222, 37)
        Me.Cycle_Label.TabIndex = 2
        Me.Cycle_Label.Text = "Cycle"
        Me.Cycle_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CellTemp_Panel
        '
        Me.CellTemp_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellTemp_Panel.BackColor = System.Drawing.Color.Bisque
        Me.CellTemp_Panel.Controls.Add(Me.celltemp_unit)
        Me.CellTemp_Panel.Controls.Add(Me.CellTemp_TextBox)
        Me.CellTemp_Panel.Controls.Add(Me.CellTemp_Label)
        Me.CellTemp_Panel.Location = New System.Drawing.Point(244, 206)
        Me.CellTemp_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.CellTemp_Panel.Name = "CellTemp_Panel"
        Me.CellTemp_Panel.Size = New System.Drawing.Size(221, 83)
        Me.CellTemp_Panel.TabIndex = 1
        '
        'celltemp_unit
        '
        Me.celltemp_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.celltemp_unit.AutoSize = True
        Me.celltemp_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.celltemp_unit.Location = New System.Drawing.Point(198, 48)
        Me.celltemp_unit.Name = "celltemp_unit"
        Me.celltemp_unit.Size = New System.Drawing.Size(20, 20)
        Me.celltemp_unit.TabIndex = 5
        Me.celltemp_unit.Text = "C"
        '
        'CellTemp_TextBox
        '
        Me.CellTemp_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellTemp_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.CellTemp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CellTemp_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CellTemp_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CellTemp_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.CellTemp_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.CellTemp_TextBox.Name = "CellTemp_TextBox"
        Me.CellTemp_TextBox.ReadOnly = True
        Me.CellTemp_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.CellTemp_TextBox.TabIndex = 4
        Me.CellTemp_TextBox.Text = "36.02"
        Me.CellTemp_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CellTemp_Label
        '
        Me.CellTemp_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellTemp_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.CellTemp_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CellTemp_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CellTemp_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CellTemp_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.CellTemp_Label.Location = New System.Drawing.Point(0, 0)
        Me.CellTemp_Label.Name = "CellTemp_Label"
        Me.CellTemp_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.CellTemp_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CellTemp_Label.Size = New System.Drawing.Size(221, 37)
        Me.CellTemp_Label.TabIndex = 2
        Me.CellTemp_Label.Text = "Cell Temperature"
        Me.CellTemp_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Energy_Panel
        '
        Me.Energy_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Energy_Panel.BackColor = System.Drawing.Color.Bisque
        Me.Energy_Panel.Controls.Add(Me.energy_unit)
        Me.Energy_Panel.Controls.Add(Me.Energy_TextBox)
        Me.Energy_Panel.Controls.Add(Me.Energy_Label)
        Me.Energy_Panel.Location = New System.Drawing.Point(8, 206)
        Me.Energy_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.Energy_Panel.Name = "Energy_Panel"
        Me.Energy_Panel.Size = New System.Drawing.Size(220, 83)
        Me.Energy_Panel.TabIndex = 1
        '
        'energy_unit
        '
        Me.energy_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.energy_unit.AutoSize = True
        Me.energy_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.energy_unit.Location = New System.Drawing.Point(184, 48)
        Me.energy_unit.Name = "energy_unit"
        Me.energy_unit.Size = New System.Drawing.Size(33, 20)
        Me.energy_unit.TabIndex = 5
        Me.energy_unit.Text = "Wh"
        '
        'Energy_TextBox
        '
        Me.Energy_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Energy_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.Energy_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Energy_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Energy_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Energy_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Energy_TextBox.Location = New System.Drawing.Point(8, 40)
        Me.Energy_TextBox.Name = "Energy_TextBox"
        Me.Energy_TextBox.ReadOnly = True
        Me.Energy_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.Energy_TextBox.TabIndex = 5
        Me.Energy_TextBox.Text = "12.241"
        Me.Energy_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Energy_Label
        '
        Me.Energy_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Energy_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Energy_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Energy_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Energy_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Energy_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Energy_Label.Location = New System.Drawing.Point(0, 0)
        Me.Energy_Label.Name = "Energy_Label"
        Me.Energy_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Energy_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Energy_Label.Size = New System.Drawing.Size(220, 37)
        Me.Energy_Label.TabIndex = 2
        Me.Energy_Label.Text = "Energy"
        Me.Energy_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Voltage_Panel
        '
        Me.Voltage_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Voltage_Panel.BackColor = System.Drawing.Color.Bisque
        Me.Voltage_Panel.Controls.Add(Me.Voltage_unit)
        Me.Voltage_Panel.Controls.Add(Me.Voltage_TextBox)
        Me.Voltage_Panel.Controls.Add(Me.Voltage_Label)
        Me.Voltage_Panel.Location = New System.Drawing.Point(8, 107)
        Me.Voltage_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.Voltage_Panel.Name = "Voltage_Panel"
        Me.Voltage_Panel.Size = New System.Drawing.Size(220, 83)
        Me.Voltage_Panel.TabIndex = 1
        '
        'Voltage_unit
        '
        Me.Voltage_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Voltage_unit.AutoSize = True
        Me.Voltage_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voltage_unit.Location = New System.Drawing.Point(197, 52)
        Me.Voltage_unit.Name = "Voltage_unit"
        Me.Voltage_unit.Size = New System.Drawing.Size(20, 20)
        Me.Voltage_unit.TabIndex = 4
        Me.Voltage_unit.Text = "V"
        '
        'Voltage_TextBox
        '
        Me.Voltage_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Voltage_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.Voltage_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Voltage_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Voltage_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voltage_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Voltage_TextBox.Location = New System.Drawing.Point(8, 44)
        Me.Voltage_TextBox.Name = "Voltage_TextBox"
        Me.Voltage_TextBox.ReadOnly = True
        Me.Voltage_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.Voltage_TextBox.TabIndex = 3
        Me.Voltage_TextBox.Text = "12.715"
        Me.Voltage_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Voltage_Label
        '
        Me.Voltage_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Voltage_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Voltage_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Voltage_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Voltage_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Voltage_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Voltage_Label.Location = New System.Drawing.Point(0, 0)
        Me.Voltage_Label.Name = "Voltage_Label"
        Me.Voltage_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Voltage_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Voltage_Label.Size = New System.Drawing.Size(220, 37)
        Me.Voltage_Label.TabIndex = 2
        Me.Voltage_Label.Text = "Voltage"
        Me.Voltage_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Current_Panel
        '
        Me.Current_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Current_Panel.BackColor = System.Drawing.Color.Bisque
        Me.Current_Panel.Controls.Add(Me.Current_unit)
        Me.Current_Panel.Controls.Add(Me.Current_TextBox)
        Me.Current_Panel.Controls.Add(Me.Current_Label)
        Me.Current_Panel.Location = New System.Drawing.Point(244, 107)
        Me.Current_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.Current_Panel.Name = "Current_Panel"
        Me.Current_Panel.Size = New System.Drawing.Size(221, 83)
        Me.Current_Panel.TabIndex = 1
        '
        'Current_unit
        '
        Me.Current_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Current_unit.AutoSize = True
        Me.Current_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_unit.Location = New System.Drawing.Point(198, 52)
        Me.Current_unit.Name = "Current_unit"
        Me.Current_unit.Size = New System.Drawing.Size(20, 20)
        Me.Current_unit.TabIndex = 5
        Me.Current_unit.Text = "A"
        '
        'Current_TextBox
        '
        Me.Current_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Current_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.Current_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Current_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Current_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Current_TextBox.Location = New System.Drawing.Point(8, 44)
        Me.Current_TextBox.Name = "Current_TextBox"
        Me.Current_TextBox.ReadOnly = True
        Me.Current_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.Current_TextBox.TabIndex = 3
        Me.Current_TextBox.Text = "5.411"
        Me.Current_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Current_Label
        '
        Me.Current_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Current_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Current_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Current_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Current_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Current_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Current_Label.Location = New System.Drawing.Point(0, 0)
        Me.Current_Label.Name = "Current_Label"
        Me.Current_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Current_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Current_Label.Size = New System.Drawing.Size(221, 37)
        Me.Current_Label.TabIndex = 2
        Me.Current_Label.Text = "Current"
        Me.Current_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Power_Panel
        '
        Me.Power_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Power_Panel.BackColor = System.Drawing.Color.Bisque
        Me.Power_Panel.Controls.Add(Me.power_unit)
        Me.Power_Panel.Controls.Add(Me.Power_TextBox)
        Me.Power_Panel.Controls.Add(Me.Power_Label)
        Me.Power_Panel.Location = New System.Drawing.Point(481, 107)
        Me.Power_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.Power_Panel.Name = "Power_Panel"
        Me.Power_Panel.Size = New System.Drawing.Size(222, 83)
        Me.Power_Panel.TabIndex = 1
        '
        'power_unit
        '
        Me.power_unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.power_unit.AutoSize = True
        Me.power_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.power_unit.Location = New System.Drawing.Point(195, 52)
        Me.power_unit.Name = "power_unit"
        Me.power_unit.Size = New System.Drawing.Size(24, 20)
        Me.power_unit.TabIndex = 6
        Me.power_unit.Text = "W"
        '
        'Power_TextBox
        '
        Me.Power_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Power_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.Power_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Power_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Power_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Power_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Power_TextBox.Location = New System.Drawing.Point(8, 44)
        Me.Power_TextBox.Name = "Power_TextBox"
        Me.Power_TextBox.ReadOnly = True
        Me.Power_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.Power_TextBox.TabIndex = 3
        Me.Power_TextBox.Text = "68.788"
        Me.Power_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Power_Label
        '
        Me.Power_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Power_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Power_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Power_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Power_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Power_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Power_Label.Location = New System.Drawing.Point(0, 0)
        Me.Power_Label.Name = "Power_Label"
        Me.Power_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Power_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Power_Label.Size = New System.Drawing.Size(222, 37)
        Me.Power_Label.TabIndex = 2
        Me.Power_Label.Text = "Power"
        Me.Power_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Status_Panel
        '
        Me.Status_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status_Panel.BackColor = System.Drawing.Color.Bisque
        Me.Status_Panel.Controls.Add(Me.Status_TextBox)
        Me.Status_Panel.Controls.Add(Me.Status_Label)
        Me.Status_Panel.Location = New System.Drawing.Point(481, 8)
        Me.Status_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.Status_Panel.Name = "Status_Panel"
        Me.Status_Panel.Size = New System.Drawing.Size(222, 83)
        Me.Status_Panel.TabIndex = 2
        '
        'Status_TextBox
        '
        Me.Status_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.Status_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Status_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Status_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Status_TextBox.Location = New System.Drawing.Point(8, 44)
        Me.Status_TextBox.Name = "Status_TextBox"
        Me.Status_TextBox.ReadOnly = True
        Me.Status_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.Status_TextBox.TabIndex = 3
        Me.Status_TextBox.Text = "CYCLE TEST"
        Me.Status_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Status_Label
        '
        Me.Status_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.Status_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Status_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Status_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Status_Label.Location = New System.Drawing.Point(0, 0)
        Me.Status_Label.Name = "Status_Label"
        Me.Status_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.Status_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Status_Label.Size = New System.Drawing.Size(222, 37)
        Me.Status_Label.TabIndex = 2
        Me.Status_Label.Text = "Status"
        Me.Status_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClockTime_Panel
        '
        Me.ClockTime_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClockTime_Panel.BackColor = System.Drawing.Color.Bisque
        Me.ClockTime_Panel.Controls.Add(Me.ClockTime_TextBox)
        Me.ClockTime_Panel.Controls.Add(Me.ClockTime_Label)
        Me.ClockTime_Panel.Location = New System.Drawing.Point(244, 8)
        Me.ClockTime_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.ClockTime_Panel.Name = "ClockTime_Panel"
        Me.ClockTime_Panel.Size = New System.Drawing.Size(221, 83)
        Me.ClockTime_Panel.TabIndex = 1
        '
        'ClockTime_TextBox
        '
        Me.ClockTime_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClockTime_TextBox.BackColor = System.Drawing.Color.Bisque
        Me.ClockTime_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClockTime_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ClockTime_TextBox.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockTime_TextBox.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ClockTime_TextBox.Location = New System.Drawing.Point(8, 44)
        Me.ClockTime_TextBox.Name = "ClockTime_TextBox"
        Me.ClockTime_TextBox.ReadOnly = True
        Me.ClockTime_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.ClockTime_TextBox.TabIndex = 3
        Me.ClockTime_TextBox.Text = "00 : 00 : 00"
        Me.ClockTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClockTime_Label
        '
        Me.ClockTime_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClockTime_Label.BackColor = System.Drawing.Color.PeachPuff
        Me.ClockTime_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ClockTime_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClockTime_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockTime_Label.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.ClockTime_Label.Location = New System.Drawing.Point(0, 0)
        Me.ClockTime_Label.Name = "ClockTime_Label"
        Me.ClockTime_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.ClockTime_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClockTime_Label.Size = New System.Drawing.Size(221, 37)
        Me.ClockTime_Label.TabIndex = 2
        Me.ClockTime_Label.Text = "Clock Time"
        Me.ClockTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RunningTime_Panel
        '
        Me.RunningTime_Panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunningTime_Panel.BackColor = System.Drawing.Color.SandyBrown
        Me.RunningTime_Panel.Controls.Add(Me.RunningText_Label)
        Me.RunningTime_Panel.Controls.Add(Me.RunningTime_TextBox)
        Me.RunningTime_Panel.ForeColor = System.Drawing.Color.Transparent
        Me.RunningTime_Panel.Location = New System.Drawing.Point(8, 8)
        Me.RunningTime_Panel.Margin = New System.Windows.Forms.Padding(8)
        Me.RunningTime_Panel.Name = "RunningTime_Panel"
        Me.RunningTime_Panel.Size = New System.Drawing.Size(220, 83)
        Me.RunningTime_Panel.TabIndex = 0
        '
        'RunningText_Label
        '
        Me.RunningText_Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunningText_Label.BackColor = System.Drawing.Color.SandyBrown
        Me.RunningText_Label.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RunningText_Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RunningText_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningText_Label.ForeColor = System.Drawing.Color.DimGray
        Me.RunningText_Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RunningText_Label.Location = New System.Drawing.Point(0, 6)
        Me.RunningText_Label.Name = "RunningText_Label"
        Me.RunningText_Label.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.RunningText_Label.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RunningText_Label.Size = New System.Drawing.Size(220, 32)
        Me.RunningText_Label.TabIndex = 0
        Me.RunningText_Label.Text = "Running Time"
        Me.RunningText_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RunningTime_TextBox
        '
        Me.RunningTime_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RunningTime_TextBox.BackColor = System.Drawing.Color.SandyBrown
        Me.RunningTime_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RunningTime_TextBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RunningTime_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningTime_TextBox.ForeColor = System.Drawing.Color.DimGray
        Me.RunningTime_TextBox.Location = New System.Drawing.Point(8, 41)
        Me.RunningTime_TextBox.Name = "RunningTime_TextBox"
        Me.RunningTime_TextBox.ReadOnly = True
        Me.RunningTime_TextBox.Size = New System.Drawing.Size(204, 28)
        Me.RunningTime_TextBox.TabIndex = 1
        Me.RunningTime_TextBox.Text = "00 : 00 : 00"
        Me.RunningTime_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 764)
        Me.Controls.Add(Me.RightPanel)
        Me.Controls.Add(Me.MainPanel)
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.RightPanel.ResumeLayout(False)
        CType(Me.LogoMTI_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.DCurrentTarget_Panel.ResumeLayout(False)
        Me.DCurrentTarget_Panel.PerformLayout()
        Me.DPowerTarget_Panel.ResumeLayout(False)
        Me.DPowerTarget_Panel.PerformLayout()
        Me.PWMOut_Panel.ResumeLayout(False)
        Me.PWMOut_Panel.PerformLayout()
        Me.CellFanCool_Panel.ResumeLayout(False)
        Me.CellFanCool_Panel.PerformLayout()
        Me.AmbHumid_Panel.ResumeLayout(False)
        Me.AmbHumid_Panel.PerformLayout()
        Me.AmbTemp_Panel.ResumeLayout(False)
        Me.AmbTemp_Panel.PerformLayout()
        Me.Cycle_Panel.ResumeLayout(False)
        Me.Cycle_Panel.PerformLayout()
        Me.CellTemp_Panel.ResumeLayout(False)
        Me.CellTemp_Panel.PerformLayout()
        Me.Energy_Panel.ResumeLayout(False)
        Me.Energy_Panel.PerformLayout()
        Me.Voltage_Panel.ResumeLayout(False)
        Me.Voltage_Panel.PerformLayout()
        Me.Current_Panel.ResumeLayout(False)
        Me.Current_Panel.PerformLayout()
        Me.Power_Panel.ResumeLayout(False)
        Me.Power_Panel.PerformLayout()
        Me.Status_Panel.ResumeLayout(False)
        Me.Status_Panel.PerformLayout()
        Me.ClockTime_Panel.ResumeLayout(False)
        Me.ClockTime_Panel.PerformLayout()
        Me.RunningTime_Panel.ResumeLayout(False)
        Me.RunningTime_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RightPanel As Panel
    Friend WithEvents SerialPortArduino As IO.Ports.SerialPort
    Friend WithEvents Exit_Button As Button
    Friend WithEvents LogoMTI_PictureBox As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents RunningTime_Panel As Panel
    Friend WithEvents DCurrentTarget_Panel As Panel
    Friend WithEvents DPowerTarget_Panel As Panel
    Friend WithEvents PWMOut_Panel As Panel
    Friend WithEvents CellFanCool_Panel As Panel
    Friend WithEvents AmbHumid_Panel As Panel
    Friend WithEvents AmbTemp_Panel As Panel
    Friend WithEvents Cycle_Panel As Panel
    Friend WithEvents CellTemp_Panel As Panel
    Friend WithEvents Energy_Panel As Panel
    Friend WithEvents Voltage_Panel As Panel
    Friend WithEvents Current_Panel As Panel
    Friend WithEvents Power_Panel As Panel
    Friend WithEvents Status_Panel As Panel
    Friend WithEvents ClockTime_Panel As Panel
    Friend WithEvents DCurrentTarget_Label As Label
    Friend WithEvents DPowerTarget_Label As Label
    Friend WithEvents PWMOut_Label As Label
    Friend WithEvents CellFanCool_Label As Label
    Friend WithEvents AmbientHumid_Label As Label
    Friend WithEvents AmbientTemp_Label As Label
    Friend WithEvents Cycle_Label As Label
    Friend WithEvents CellTemp_Label As Label
    Friend WithEvents Energy_Label As Label
    Friend WithEvents Voltage_Label As Label
    Friend WithEvents Current_Label As Label
    Friend WithEvents Power_Label As Label
    Friend WithEvents Status_Label As Label
    Friend WithEvents RunningTime_TextBox As TextBox
    Friend WithEvents DCurrentTarget_TextBox As TextBox
    Friend WithEvents DPowerTarget_TextBox As TextBox
    Friend WithEvents PWMOut_TextBox As TextBox
    Friend WithEvents CellFanCool_TextBox As TextBox
    Friend WithEvents AmbHumid_TextBox As TextBox
    Friend WithEvents AmbTemp_TextBox As TextBox
    Friend WithEvents Cycle_TextBox As TextBox
    Friend WithEvents CellTemp_TextBox As TextBox
    Friend WithEvents Voltage_TextBox As TextBox
    Friend WithEvents Current_TextBox As TextBox
    Friend WithEvents Power_TextBox As TextBox
    Friend WithEvents Status_TextBox As TextBox
    Friend WithEvents ClockTime_TextBox As TextBox
    Friend WithEvents ClockTime_Label As Label
    Friend WithEvents Energy_TextBox As TextBox
    Friend WithEvents RunningText_Label As Label
    Friend WithEvents Voltage_unit As Label
    Friend WithEvents dcurrentarget_unit As Label
    Friend WithEvents dpowertarget_unit As Label
    Friend WithEvents pwmout_unit As Label
    Friend WithEvents cellfancool_unit As Label
    Friend WithEvents ambhumid_unit As Label
    Friend WithEvents ambtemp_unit As Label
    Friend WithEvents celltemp_unit As Label
    Friend WithEvents energy_unit As Label
    Friend WithEvents Current_unit As Label
    Friend WithEvents power_unit As Label
    Friend WithEvents Timer As Timer
End Class
