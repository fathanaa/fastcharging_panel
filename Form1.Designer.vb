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
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RightPanel.SuspendLayout()
        CType(Me.LogoMTI_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RightPanel
        '
        Me.RightPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RightPanel.Controls.Add(Me.Exit_Button)
        Me.RightPanel.Controls.Add(Me.LogoMTI_PictureBox)
        Me.RightPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.RightPanel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.RightPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightPanel.Name = "RightPanel"
        Me.RightPanel.Size = New System.Drawing.Size(355, 764)
        Me.RightPanel.TabIndex = 1
        '
        'Exit_Button
        '
        Me.Exit_Button.BackColor = System.Drawing.Color.DarkOrange
        Me.Exit_Button.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Exit_Button.FlatAppearance.BorderSize = 0
        Me.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit_Button.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit_Button.ForeColor = System.Drawing.Color.White
        Me.Exit_Button.Location = New System.Drawing.Point(0, 728)
        Me.Exit_Button.Name = "Exit_Button"
        Me.Exit_Button.Size = New System.Drawing.Size(355, 36)
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
        Me.LogoMTI_PictureBox.Size = New System.Drawing.Size(355, 244)
        Me.LogoMTI_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoMTI_PictureBox.TabIndex = 2
        Me.LogoMTI_PictureBox.TabStop = False
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.PeachPuff
        Me.MainPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1273, 764)
        Me.MainPanel.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Pink
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(394, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(840, 532)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RightPanel As Panel
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Exit_Button As Button
    Friend WithEvents LogoMTI_PictureBox As PictureBox
    Friend WithEvents MainPanel As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
