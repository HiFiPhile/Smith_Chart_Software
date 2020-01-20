Imports System.ComponentModel

Public Class ImpedanceTransformForm2
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents B1TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents B2TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents ZoLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents XinLabel As System.Windows.Forms.Label
    Friend WithEvents RinLabel As System.Windows.Forms.Label
    Friend WithEvents BinLabel As System.Windows.Forms.Label
    Friend WithEvents GinLabel As System.Windows.Forms.Label
    Friend WithEvents B2MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents B1MaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents B1MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents B2MinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents T1TrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents T1PhaseMaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents T1PhaseMinTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents T1PhaseLabel As System.Windows.Forms.Label
    Friend WithEvents B1Label As System.Windows.Forms.Label
    Friend WithEvents B2Label As System.Windows.Forms.Label
    Friend WithEvents SetLoadButton As System.Windows.Forms.Button
    Friend WithEvents ZL_XLabel As System.Windows.Forms.Label
    Friend WithEvents ZL_RLabel As System.Windows.Forms.Label
    Friend WithEvents T1LengthLabel As System.Windows.Forms.Label
    Friend WithEvents B2LumpedLabel As System.Windows.Forms.Label
    Friend WithEvents B1LumpedLabel As System.Windows.Forms.Label
    Friend WithEvents T1VTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BetaLabel As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImpedanceTransformForm2))
        Me.B1TrackBar = New System.Windows.Forms.TrackBar()
        Me.B2TrackBar = New System.Windows.Forms.TrackBar()
        Me.FrequencyLabel = New System.Windows.Forms.Label()
        Me.ZoLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.XinLabel = New System.Windows.Forms.Label()
        Me.RinLabel = New System.Windows.Forms.Label()
        Me.BinLabel = New System.Windows.Forms.Label()
        Me.GinLabel = New System.Windows.Forms.Label()
        Me.B2MaxTextBox = New System.Windows.Forms.TextBox()
        Me.B1MaxTextBox = New System.Windows.Forms.TextBox()
        Me.B1MinTextBox = New System.Windows.Forms.TextBox()
        Me.B2MinTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.T1TrackBar = New System.Windows.Forms.TrackBar()
        Me.T1PhaseMaxTextBox = New System.Windows.Forms.TextBox()
        Me.T1PhaseMinTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.T1PhaseLabel = New System.Windows.Forms.Label()
        Me.B1Label = New System.Windows.Forms.Label()
        Me.B2Label = New System.Windows.Forms.Label()
        Me.SetLoadButton = New System.Windows.Forms.Button()
        Me.ZL_XLabel = New System.Windows.Forms.Label()
        Me.ZL_RLabel = New System.Windows.Forms.Label()
        Me.T1LengthLabel = New System.Windows.Forms.Label()
        Me.B2LumpedLabel = New System.Windows.Forms.Label()
        Me.B1LumpedLabel = New System.Windows.Forms.Label()
        Me.T1VTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BetaLabel = New System.Windows.Forms.Label()
        CType(Me.B1TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B2TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'B1TrackBar
        '
        Me.B1TrackBar.Location = New System.Drawing.Point(94, 290)
        Me.B1TrackBar.Maximum = 200
        Me.B1TrackBar.Name = "B1TrackBar"
        Me.B1TrackBar.Size = New System.Drawing.Size(233, 45)
        Me.B1TrackBar.TabIndex = 2
        Me.B1TrackBar.TickFrequency = 10
        Me.B1TrackBar.Value = 100
        '
        'B2TrackBar
        '
        Me.B2TrackBar.Location = New System.Drawing.Point(94, 341)
        Me.B2TrackBar.Maximum = 200
        Me.B2TrackBar.Name = "B2TrackBar"
        Me.B2TrackBar.Size = New System.Drawing.Size(233, 45)
        Me.B2TrackBar.TabIndex = 3
        Me.B2TrackBar.TickFrequency = 10
        Me.B2TrackBar.Value = 100
        '
        'FrequencyLabel
        '
        Me.FrequencyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FrequencyLabel.Location = New System.Drawing.Point(456, 309)
        Me.FrequencyLabel.Name = "FrequencyLabel"
        Me.FrequencyLabel.Size = New System.Drawing.Size(64, 26)
        Me.FrequencyLabel.TabIndex = 6
        '
        'ZoLabel
        '
        Me.ZoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ZoLabel.Location = New System.Drawing.Point(457, 343)
        Me.ZoLabel.Name = "ZoLabel"
        Me.ZoLabel.Size = New System.Drawing.Size(63, 25)
        Me.ZoLabel.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(431, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Zo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(393, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Frequency"
        '
        'XinLabel
        '
        Me.XinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.XinLabel.Location = New System.Drawing.Point(40, 58)
        Me.XinLabel.Name = "XinLabel"
        Me.XinLabel.Size = New System.Drawing.Size(55, 21)
        Me.XinLabel.TabIndex = 16
        '
        'RinLabel
        '
        Me.RinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RinLabel.Location = New System.Drawing.Point(40, 34)
        Me.RinLabel.Name = "RinLabel"
        Me.RinLabel.Size = New System.Drawing.Size(55, 20)
        Me.RinLabel.TabIndex = 15
        '
        'BinLabel
        '
        Me.BinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BinLabel.Location = New System.Drawing.Point(40, 108)
        Me.BinLabel.Name = "BinLabel"
        Me.BinLabel.Size = New System.Drawing.Size(55, 21)
        Me.BinLabel.TabIndex = 18
        '
        'GinLabel
        '
        Me.GinLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GinLabel.Location = New System.Drawing.Point(40, 84)
        Me.GinLabel.Name = "GinLabel"
        Me.GinLabel.Size = New System.Drawing.Size(55, 20)
        Me.GinLabel.TabIndex = 17
        '
        'B2MaxTextBox
        '
        Me.B2MaxTextBox.Location = New System.Drawing.Point(333, 341)
        Me.B2MaxTextBox.Name = "B2MaxTextBox"
        Me.B2MaxTextBox.Size = New System.Drawing.Size(44, 20)
        Me.B2MaxTextBox.TabIndex = 19
        Me.B2MaxTextBox.Text = "0.02"
        '
        'B1MaxTextBox
        '
        Me.B1MaxTextBox.Location = New System.Drawing.Point(333, 290)
        Me.B1MaxTextBox.Name = "B1MaxTextBox"
        Me.B1MaxTextBox.Size = New System.Drawing.Size(44, 20)
        Me.B1MaxTextBox.TabIndex = 20
        Me.B1MaxTextBox.Text = "0.02"
        '
        'B1MinTextBox
        '
        Me.B1MinTextBox.Location = New System.Drawing.Point(40, 290)
        Me.B1MinTextBox.Name = "B1MinTextBox"
        Me.B1MinTextBox.Size = New System.Drawing.Size(48, 20)
        Me.B1MinTextBox.TabIndex = 23
        Me.B1MinTextBox.Text = "-0.02"
        '
        'B2MinTextBox
        '
        Me.B2MinTextBox.Location = New System.Drawing.Point(40, 341)
        Me.B2MinTextBox.Name = "B2MinTextBox"
        Me.B2MinTextBox.Size = New System.Drawing.Size(48, 20)
        Me.B2MinTextBox.TabIndex = 24
        Me.B2MinTextBox.Text = "-0.02"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Rin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Xin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Gin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Bin"
        '
        'T1TrackBar
        '
        Me.T1TrackBar.Location = New System.Drawing.Point(94, 239)
        Me.T1TrackBar.Maximum = 200
        Me.T1TrackBar.Name = "T1TrackBar"
        Me.T1TrackBar.Size = New System.Drawing.Size(233, 45)
        Me.T1TrackBar.TabIndex = 1
        Me.T1TrackBar.TickFrequency = 10
        '
        'T1PhaseMaxTextBox
        '
        Me.T1PhaseMaxTextBox.Location = New System.Drawing.Point(333, 239)
        Me.T1PhaseMaxTextBox.Name = "T1PhaseMaxTextBox"
        Me.T1PhaseMaxTextBox.Size = New System.Drawing.Size(44, 20)
        Me.T1PhaseMaxTextBox.TabIndex = 21
        Me.T1PhaseMaxTextBox.Text = "4.0"
        '
        'T1PhaseMinTextBox
        '
        Me.T1PhaseMinTextBox.Location = New System.Drawing.Point(40, 239)
        Me.T1PhaseMinTextBox.Name = "T1PhaseMinTextBox"
        Me.T1PhaseMinTextBox.Size = New System.Drawing.Size(48, 20)
        Me.T1PhaseMinTextBox.TabIndex = 22
        Me.T1PhaseMinTextBox.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(202, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Beta x Length"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(202, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "B1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(202, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "B2"
        '
        'T1PhaseLabel
        '
        Me.T1PhaseLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.T1PhaseLabel.Location = New System.Drawing.Point(263, 77)
        Me.T1PhaseLabel.Name = "T1PhaseLabel"
        Me.T1PhaseLabel.Size = New System.Drawing.Size(48, 21)
        Me.T1PhaseLabel.TabIndex = 36
        '
        'B1Label
        '
        Me.B1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.B1Label.Location = New System.Drawing.Point(256, 144)
        Me.B1Label.Name = "B1Label"
        Me.B1Label.Size = New System.Drawing.Size(62, 24)
        Me.B1Label.TabIndex = 37
        '
        'B2Label
        '
        Me.B2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.B2Label.Location = New System.Drawing.Point(111, 144)
        Me.B2Label.Name = "B2Label"
        Me.B2Label.Size = New System.Drawing.Size(57, 24)
        Me.B2Label.TabIndex = 38
        '
        'SetLoadButton
        '
        Me.SetLoadButton.Location = New System.Drawing.Point(406, 117)
        Me.SetLoadButton.Name = "SetLoadButton"
        Me.SetLoadButton.Size = New System.Drawing.Size(34, 34)
        Me.SetLoadButton.TabIndex = 39
        Me.SetLoadButton.Tag = ""
        Me.SetLoadButton.Text = "Set"
        Me.SetLoadButton.UseVisualStyleBackColor = True
        '
        'ZL_XLabel
        '
        Me.ZL_XLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ZL_XLabel.Location = New System.Drawing.Point(454, 130)
        Me.ZL_XLabel.Name = "ZL_XLabel"
        Me.ZL_XLabel.Size = New System.Drawing.Size(66, 21)
        Me.ZL_XLabel.TabIndex = 41
        '
        'ZL_RLabel
        '
        Me.ZL_RLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ZL_RLabel.Location = New System.Drawing.Point(454, 104)
        Me.ZL_RLabel.Name = "ZL_RLabel"
        Me.ZL_RLabel.Size = New System.Drawing.Size(66, 20)
        Me.ZL_RLabel.TabIndex = 40
        '
        'T1LengthLabel
        '
        Me.T1LengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.T1LengthLabel.Location = New System.Drawing.Point(226, 103)
        Me.T1LengthLabel.Name = "T1LengthLabel"
        Me.T1LengthLabel.Size = New System.Drawing.Size(92, 21)
        Me.T1LengthLabel.TabIndex = 42
        '
        'B2LumpedLabel
        '
        Me.B2LumpedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.B2LumpedLabel.Location = New System.Drawing.Point(111, 171)
        Me.B2LumpedLabel.Name = "B2LumpedLabel"
        Me.B2LumpedLabel.Size = New System.Drawing.Size(57, 33)
        Me.B2LumpedLabel.TabIndex = 43
        '
        'B1LumpedLabel
        '
        Me.B1LumpedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.B1LumpedLabel.Location = New System.Drawing.Point(256, 171)
        Me.B1LumpedLabel.Name = "B1LumpedLabel"
        Me.B1LumpedLabel.Size = New System.Drawing.Size(62, 33)
        Me.B1LumpedLabel.TabIndex = 44
        '
        'T1VTextBox
        '
        Me.T1VTextBox.Location = New System.Drawing.Point(448, 12)
        Me.T1VTextBox.Name = "T1VTextBox"
        Me.T1VTextBox.Size = New System.Drawing.Size(72, 20)
        Me.T1VTextBox.TabIndex = 45
        Me.T1VTextBox.Text = "2.998E8"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.winRF_CAD.My.Resources.Resources.DoubleStub
        Me.PictureBox1.Location = New System.Drawing.Point(111, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 204)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(371, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Phase Velocity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(216, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Beta x l"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(373, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Beta"
        '
        'BetaLabel
        '
        Me.BetaLabel.AutoSize = True
        Me.BetaLabel.Location = New System.Drawing.Point(451, 35)
        Me.BetaLabel.Name = "BetaLabel"
        Me.BetaLabel.Size = New System.Drawing.Size(45, 13)
        Me.BetaLabel.TabIndex = 49
        Me.BetaLabel.Text = "Label13"
        '
        'ImpedanceTransformForm2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(541, 389)
        Me.Controls.Add(Me.BetaLabel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.T1VTextBox)
        Me.Controls.Add(Me.B1LumpedLabel)
        Me.Controls.Add(Me.B2LumpedLabel)
        Me.Controls.Add(Me.T1LengthLabel)
        Me.Controls.Add(Me.ZL_XLabel)
        Me.Controls.Add(Me.ZL_RLabel)
        Me.Controls.Add(Me.SetLoadButton)
        Me.Controls.Add(Me.B2Label)
        Me.Controls.Add(Me.B1Label)
        Me.Controls.Add(Me.T1PhaseLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B2MinTextBox)
        Me.Controls.Add(Me.B1MinTextBox)
        Me.Controls.Add(Me.T1PhaseMinTextBox)
        Me.Controls.Add(Me.T1PhaseMaxTextBox)
        Me.Controls.Add(Me.B1MaxTextBox)
        Me.Controls.Add(Me.B2MaxTextBox)
        Me.Controls.Add(Me.BinLabel)
        Me.Controls.Add(Me.GinLabel)
        Me.Controls.Add(Me.XinLabel)
        Me.Controls.Add(Me.RinLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ZoLabel)
        Me.Controls.Add(Me.FrequencyLabel)
        Me.Controls.Add(Me.B2TrackBar)
        Me.Controls.Add(Me.B1TrackBar)
        Me.Controls.Add(Me.T1TrackBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ImpedanceTransformForm2"
        Me.Text = "ImpedanceTransformForm"
        CType(Me.B1TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B2TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Author:            Fabian Kung Wai Lee
    'Last modified:     1st April 2016
    'Description:       Codes to modify the reflection coefficient in the Smith Chart window      
    'Filename:          ImpedanceTransformForm2.vb
    'Language:          Visual Basic .NET
    'Development tool:  Microsoft Visual Studio .NET 2013 express

    '--- Module level declarations ---
    'Environment:
    Public mstrFormTitle As String
    Public mstrVersion As String
    Public mobjInterFormMessage As New MessageClass
    Public Const PI As Double = 3.1415926535897931

    'Variables
    Private mobjZL As New ComplexNumberClass(0.001, 0)  'Load impedance ZL
    Private mobjYL As New ComplexNumberClass(1000, 0)   'Load admittance YL = 1/ZL
    Private mobjTL As New ComplexNumberClass(0, 0)      'Load reflection coefficient
    Private mobjYin As New ComplexNumberClass(1000, 0)  'Default Yin = YL
    Private mobjZin As New ComplexNumberClass(0.001, 0) 'Default Zin = ZL
    Private mobjTin As New ComplexNumberClass(0, 0) 'Input reflection coefficient
    Private mobjB1 As New ComplexNumberClass(0, 0)  'jB1
    Private mobjB2 As New ComplexNumberClass(0, 0)  'jB2
    Private mobj1Complex As New ComplexNumberClass(1, 0) ' 1+j0

    Private mdblT1PhaseMax As Double = 4.0
    Private mdblT1PhaseMin As Double = 0
    Private mdblT1Vp As Double = 299800000.0
    Private mdblB1Max As Double = 0.02
    Private mdblB1Min As Double = -0.02
    Private mdblB2Max As Double = 0.02
    Private mdblB2Min As Double = -0.02
    Private mdblT1Phase As Double = 0.0
    Private mdblB1 As Double = 0.0
    Private mdblB2 As Double = 0.0
    Private mdblT1PhaseDelta As Double = 0.02
    Private mdblB1Delta As Double = 0.0002
    Private mdblB2Delta As Double = 0.0002

    Private Sub ImpedanceTransformForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Update the title and version of the main window
            Me.Text = mstrFormTitle & " " & "Version " & mstrVersion
            FrequencyLabel.Text = CStr(mobjInterFormMessage.dblFreq / 1000000) & " MHz"
            ZoLabel.Text = CStr(mobjInterFormMessage.dblZo) & " Ohm"

            'Initialize all labels
            T1PhaseLabel.Text = CStr(mdblT1Phase)
            B1Label.Text = CStr(mdblB1)
            B2Label.Text = CStr(mdblB2)
            T1LengthLabel.Text = "Through"
            B1LumpedLabel.Text = "Open"
            B2LumpedLabel.Text = "Open"

            T1PhaseMaxTextBox.Text = CStr(mdblT1PhaseMax)
            T1PhaseMinTextBox.Text = CStr(mdblT1PhaseMin)
            B1MaxTextBox.Text = CStr(mdblB1Max)
            B1MinTextBox.Text = CStr(mdblB1Min)
            B2MaxTextBox.Text = CStr(mdblB2Max)
            B2MinTextBox.Text = CStr(mdblB2Min)

            BetaLabel.Text = Format((2 * PI * mobjInterFormMessage.dblFreq) / mdblT1Vp, "####0.00")
            'Initialize trackbars
            T1TrackBar.Enabled = False
            B1TrackBar.Enabled = False
            B2TrackBar.Enabled = False

        Catch theException As Exception

            MessageBox.Show("ImpedanceTransformForm2_Load " & theException.Message, "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub SetLoadButton_Click(sender As Object, e As EventArgs) Handles SetLoadButton.Click
        Dim dblRe As Double
        Dim dblIm As Double
        Dim objZo As New ComplexNumberClass(mobjInterFormMessage.dblZo, 0)
        Dim objC As New ComplexNumberClass(0, 0)

        Try

            'Set the title and version of the About Window
            ZLForm.mstrFormTitle = mstrFormTitle
            ZLForm.mstrVersion = mstrVersion
            ZLForm.ShowDialog(Me) 'Display About Box in Modal mode.

            'Capture value keyed in by user.  
            'To prevent possible divide by zero, we always limit the real part magnitude to be not less than
            '0.001
            mobjZL.Real = ZLForm.mobjZL.Real    'Create a complex impedance Z from user inputs.
            If mobjZL.Real < 0.0 Then
                If mobjZL.Real > -0.001 Then
                    mobjZL.Real = -0.001
                End If
            Else
                If mobjZL.Real < 0.001 Then
                    mobjZL.Real = 0.001
                End If
            End If

            mobjZL.Imagninary = ZLForm.mobjZL.Imagninary
            mobjYL = mobjZL.DivComplex(mobj1Complex, mobjZL)

            ZL_RLabel.Text = "RL = " & CStr(mobjZL.Real)
            ZL_XLabel.Text = "XL = " & CStr(mobjZL.Imagninary)

            'Convert ZL into reflection coefficient TL.
            objC = mobjZL.SubComplex(mobjZL, objZo)
            mobjTL = mobjTL.DivComplex(objC, mobjTL.AddComplex(mobjZL, objZo))

            'Update the new input reflection coefficient.
            CalculateTin()
            RinLabel.Text = Format(mobjZin.Real, "####0.00")
            XinLabel.Text = Format(mobjZin.Imagninary, "####0.00")
            GinLabel.Text = Format(mobjYin.Real, "####0.0000")
            BinLabel.Text = Format(mobjYin.Imagninary, "####0.0000")

            'Display this on the Smith Chart
            MainForm.SmithChartWindow.mobjTaux.Real = mobjTin.Real
            MainForm.SmithChartWindow.mobjTaux.Imagninary = mobjTin.Imagninary
            MainForm.SmithChartWindow.mobjTaux.Visible = True
            MainForm.SmithChartWindow.Refresh()

            'Enable all trackbars
            T1TrackBar.Enabled = True
            B1TrackBar.Enabled = True
            B2TrackBar.Enabled = True

        Catch theException As Exception
            MessageBox.Show("SetLoadButton_Click" & theException.Message, "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub T1TrackBar_Scroll(sender As Object, e As EventArgs) Handles T1TrackBar.Scroll
        Dim nIndex As Integer
        Dim dblT1Length_mm As Double
        Dim dblwo As Double
        Dim dblBeta As Double

        nIndex = T1TrackBar.Value
        mdblT1Phase = (nIndex * mdblT1PhaseDelta) + mdblT1PhaseMin
        T1PhaseLabel.Text = Format(mdblT1Phase, "####0.00")
        CalculateTin()              'Recalculate the new input impedance and update all relevant labels
        RinLabel.Text = Format(mobjZin.Real, "####0.00")
        XinLabel.Text = Format(mobjZin.Imagninary, "####0.00")
        GinLabel.Text = Format(mobjYin.Real, "####0.0000")
        BinLabel.Text = Format(mobjYin.Imagninary, "####0.0000")

        'Calculate the corresponding lumped component and display on window
        dblwo = 2 * PI * mobjInterFormMessage.dblFreq  'Calculate frequency in rad/sec
        dblBeta = dblwo / mdblT1Vp                     'Calculate propagation factor

        If mdblT1Phase > 0.0 Then    'Delay
            dblT1Length_mm = (mdblT1Phase / dblBeta) * 1000 'Normalize to mm
            T1LengthLabel.Text = "Len=" & Format(dblT1Length_mm, "####0.00") & " mm"
        Else '0.0, short circuit
            T1LengthLabel.Text = "Through"
        End If

        'Display this on the Smith Chart
        MainForm.SmithChartWindow.mobjTaux.Real = mobjTin.Real  'Update the real and imaginary part of auxiliary reflection coefficient
        'in the Smith Chart Form.
        MainForm.SmithChartWindow.mobjTaux.Imagninary = mobjTin.Imagninary
        MainForm.SmithChartWindow.Refresh()
    End Sub

    Private Sub B1TrackBar_Scroll(sender As Object, e As EventArgs) Handles B1TrackBar.Scroll
        Dim nIndex As Integer
        Dim dblBLump As Double
        Dim dblwo As Double

        nIndex = B1TrackBar.Value
        mdblB1 = (nIndex * mdblB1Delta) + mdblB1Min
        B1Label.Text = Format(mdblB1, "####0.0000")
        mobjB1.Imagninary = mdblB1  'Update the imaginary part of jB1
        CalculateTin()              'Recalculate the new input impedance and update all relevant labels
        RinLabel.Text = Format(mobjZin.Real, "####0.00")
        XinLabel.Text = Format(mobjZin.Imagninary, "####0.00")
        GinLabel.Text = Format(mobjYin.Real, "####0.0000")
        BinLabel.Text = Format(mobjYin.Imagninary, "####0.0000")

        'Calculate the corresponding lumped component and display on window
        dblwo = 2 * PI * mobjInterFormMessage.dblFreq  'Calculate frequency in rad/sec
        If mdblB1 > 0.0 Then    'Capacitance
            dblBLump = (mdblB1 / dblwo) * 1000000000000.0 'Normalize to pF
            B1LumpedLabel.Text = "C=" & Format(dblBLump, "####0.00") & " pF"
        ElseIf mdblB1 < 0.0 Then 'Inductance
            dblBLump = (1 / (-mdblB1 * dblwo)) * 1000000000.0 'Normalize to nH
            B1LumpedLabel.Text = "L=" & Format(dblBLump, "####0.00") & " nH"
        Else '0.0, open circuit
            B1LumpedLabel.Text = "Short"
        End If

        'Display this on the Smith Chart
        MainForm.SmithChartWindow.mobjTaux.Real = mobjTin.Real  'Update the real and imaginary part of auxiliary reflection coefficient
        'in the Smith Chart Form.
        MainForm.SmithChartWindow.mobjTaux.Imagninary = mobjTin.Imagninary
        MainForm.SmithChartWindow.Refresh()
    End Sub

    Private Sub B2TrackBar_Scroll(sender As Object, e As EventArgs) Handles B2TrackBar.Scroll
        Dim nIndex As Integer
        Dim dblBLump As Double
        Dim dblwo As Double

        nIndex = B2TrackBar.Value
        mdblB2 = (nIndex * mdblB2Delta) + mdblB2Min
        B2Label.Text = Format(mdblB2, "####0.0000")
        mobjB2.Imagninary = mdblB2  'Update the imaginary part of jB2
        CalculateTin()              'Recalculate the new input impedance and update all relevant labels
        RinLabel.Text = Format(mobjZin.Real, "####0.00")
        XinLabel.Text = Format(mobjZin.Imagninary, "####0.00")
        GinLabel.Text = Format(mobjYin.Real, "####0.0000")
        BinLabel.Text = Format(mobjYin.Imagninary, "####0.0000")

        'Calculate the corresponding lumped component and display on window
        dblwo = 2 * PI * mobjInterFormMessage.dblFreq  'Calculate frequency in rad/sec
        If mdblB2 > 0.0 Then    'Capacitance
            dblBLump = (mdblB2 / dblwo) * 1000000000000.0 'Normalize to pF
            B2LumpedLabel.Text = "C=" & Format(dblBLump, "####0.00") & " pF"
        ElseIf mdblB2 < 0.0 Then 'Inductance
            dblBLump = (1 / (-mdblB2 * dblwo)) * 1000000000.0 'Normalize to nH
            B2LumpedLabel.Text = "L=" & Format(dblBLump, "####0.00") & " nH"
        Else '0.0, open circuit
            B2LumpedLabel.Text = "Short"
        End If

        'Display this on the Smith Chart
        MainForm.SmithChartWindow.mobjTaux.Real = mobjTin.Real  'Update the real and imaginary part of auxiliary reflection coefficient
        'in the Smith Chart Form.
        MainForm.SmithChartWindow.mobjTaux.Imagninary = mobjTin.Imagninary
        MainForm.SmithChartWindow.Refresh()
    End Sub

    Private Sub T1PhaseMaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles T1PhaseMaxTextBox.DoubleClick
        Dim dblMaxTemp As Double
        Dim dblDeltaTemp As Double
        Dim nTemp As Integer

        Try

            dblMaxTemp = Val(T1PhaseMaxTextBox.Text)

            If dblMaxTemp > mdblT1PhaseMin Then              'Make sure the new value is greater than the minimum limit.
                dblDeltaTemp = (dblMaxTemp - mdblT1PhaseMin) / (T1TrackBar.Maximum - T1TrackBar.Minimum) 'Update the interval for T1.

                'The followings check for the validity of the new limits, then only updates all the relevant controls.
                nTemp = Fix((mdblT1Phase - mdblT1PhaseMin) / dblDeltaTemp) 'Compute the new position of the tick in the Trackbar in relation of the new limits.
                If nTemp <= T1TrackBar.Maximum Then         'Make sure this is within the trackbar!
                    T1TrackBar.Value = nTemp                'Update tick position
                    mdblT1PhaseMax = dblMaxTemp              'Update max limit
                    mdblT1PhaseDelta = dblDeltaTemp          'Update interval
                    T1PhaseMaxTextBox.Text = CStr(mdblT1PhaseMax) 'Update text
                Else
                    MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                    T1PhaseMaxTextBox.Text = CStr(mdblT1PhaseMax)
                End If
            Else
                MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                T1PhaseMaxTextBox.Text = CStr(mdblT1PhaseMax)
            End If

        Catch theException As Exception
            MessageBox.Show(theException.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub T1PhaseMinTextBox_TextChanged(sender As Object, e As EventArgs) Handles T1PhaseMinTextBox.DoubleClick
        Dim dblMinTemp As Double
        Dim dblDeltaTemp As Double
        Dim nTemp As Integer

        Try
            dblMinTemp = Val(T1PhaseMinTextBox.Text)

            If (dblMinTemp < mdblT1PhaseMax) And (dblMinTemp >= 0) Then              'Make sure the new value is less than the minimum limit.
                dblDeltaTemp = (mdblT1PhaseMax - dblMinTemp) / (T1TrackBar.Maximum - T1TrackBar.Minimum) 'Update the interval for T1.

                'The followings check for the validity of the new limits, then only updates all the relevant controls.
                nTemp = Fix((mdblT1Phase - dblMinTemp) / dblDeltaTemp) 'Compute the new position of the tick in the Trackbar in relation of the new limits.
                If nTemp >= T1TrackBar.Minimum Then     'Make sure this is within the trackbar!
                    T1TrackBar.Value = nTemp            'Update tick position
                    mdblT1PhaseMin = dblMinTemp              'Update max limit
                    mdblT1PhaseDelta = dblDeltaTemp          'Update interval
                    T1PhaseMinTextBox.Text = CStr(mdblT1PhaseMin) 'Update text
                Else
                    MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                    T1PhaseMinTextBox.Text = CStr(mdblT1PhaseMin)
                End If
            Else
                MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                T1PhaseMinTextBox.Text = CStr(mdblT1PhaseMin)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub B1MaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles B1MaxTextBox.DoubleClick
        Dim dblMaxTemp As Double
        Dim dblDeltaTemp As Double
        Dim nTemp As Integer

        Try

            dblMaxTemp = Val(B1MaxTextBox.Text)

            If dblMaxTemp > mdblB1Min Then              'Make sure the new value is greater than the minimum limit.
                dblDeltaTemp = (dblMaxTemp - mdblB1Min) / (B1TrackBar.Maximum - B1TrackBar.Minimum) 'Update the interval for B1.

                'The followings check for the validity of the new limits, then only updates all the relevant controls.
                nTemp = Fix((mdblB1 - mdblB1Min) / dblDeltaTemp) 'Compute the new position of the tick in the Trackbar in relation of the new limits.
                If nTemp <= B1TrackBar.Maximum Then     'Make sure this is within the trackbar!
                    B1TrackBar.Value = nTemp            'Update tick position
                    mdblB1Max = dblMaxTemp              'Update max limit
                    mdblB1Delta = dblDeltaTemp          'Update interval
                    B1MaxTextBox.Text = CStr(mdblB1Max) 'Update text
                Else
                    MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                    B1MaxTextBox.Text = CStr(mdblB1Max)
                End If
            Else
                MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                B1MaxTextBox.Text = CStr(mdblB1Max)
            End If

        Catch theException As Exception
            MessageBox.Show(theException.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub B1MinTextBox_TextChanged(sender As Object, e As EventArgs) Handles B1MinTextBox.DoubleClick
        Dim dblMinTemp As Double
        Dim dblDeltaTemp As Double
        Dim nTemp As Integer

        Try
            dblMinTemp = Val(B1MinTextBox.Text)

            If dblMinTemp < mdblB1Max Then              'Make sure the new value is less than the minimum limit.
                dblDeltaTemp = (mdblB1Max - dblMinTemp) / (B1TrackBar.Maximum - B1TrackBar.Minimum) 'Update the interval for B1.

                'The followings check for the validity of the new limits, then only updates all the relevant controls.
                nTemp = Fix((mdblB1 - dblMinTemp) / dblDeltaTemp) 'Compute the new position of the tick in the Trackbar in relation of the new limits.
                If nTemp >= B1TrackBar.Minimum Then     'Make sure this is within the trackbar!
                    B1TrackBar.Value = nTemp            'Update tick position
                    mdblB1Min = dblMinTemp              'Update max limit
                    mdblB1Delta = dblDeltaTemp          'Update interval
                    B1MinTextBox.Text = CStr(mdblB1Min) 'Update text
                Else
                    MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                    B1MinTextBox.Text = CStr(mdblB1Min)
                End If
            Else
                MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                B1MinTextBox.Text = CStr(mdblB1Min)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub B2MaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles B2MaxTextBox.DoubleClick
        Dim dblMaxTemp As Double
        Dim dblDeltaTemp As Double
        Dim nTemp As Integer

        Try

            dblMaxTemp = Val(B2MaxTextBox.Text)

            If dblMaxTemp > mdblB1Min Then              'Make sure the new value is greater than the minimum limit.
                dblDeltaTemp = (dblMaxTemp - mdblB2Min) / (B2TrackBar.Maximum - B2TrackBar.Minimum) 'Update the interval for B2.

                'The followings check for the validity of the new limits, then only updates all the relevant controls.
                nTemp = Fix((mdblB2 - mdblB2Min) / dblDeltaTemp) 'Compute the new position of the tick in the Trackbar in relation of the new limits.
                If nTemp <= B1TrackBar.Maximum Then     'Make sure this is within the trackbar!
                    B2TrackBar.Value = nTemp            'Update tick position
                    mdblB2Max = dblMaxTemp              'Update max limit
                    mdblB2Delta = dblDeltaTemp          'Update interval
                    B1MaxTextBox.Text = CStr(mdblB2Max) 'Update text
                Else
                    MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                    B2MaxTextBox.Text = CStr(mdblB2Max)
                End If
            Else
                MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                B2MaxTextBox.Text = CStr(mdblB2Max)
            End If

        Catch theException As Exception
            MessageBox.Show(theException.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub B2MinTextBox_TextChanged(sender As Object, e As EventArgs) Handles B2MinTextBox.DoubleClick
        Dim dblMinTemp As Double
        Dim dblDeltaTemp As Double
        Dim nTemp As Integer

        Try
            dblMinTemp = Val(B2MinTextBox.Text)

            If dblMinTemp < mdblB2Max Then              'Make sure the new value is less than the minimum limit.
                dblDeltaTemp = (mdblB2Max - dblMinTemp) / (B2TrackBar.Maximum - B2TrackBar.Minimum) 'Update the interval for B2.

                'The followings check for the validity of the new limits, then only updates all the relevant controls.
                nTemp = Fix((mdblB2 - dblMinTemp) / dblDeltaTemp) 'Compute the new position of the tick in the Trackbar in relation of the new limits.
                If nTemp >= B2TrackBar.Minimum Then     'Make sure this is within the trackbar!
                    B2TrackBar.Value = nTemp            'Update tick position
                    mdblB2Min = dblMinTemp              'Update max limit
                    mdblB2Delta = dblDeltaTemp          'Update interval
                    B2MinTextBox.Text = CStr(mdblB2Min) 'Update text
                Else
                    MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                    B2MinTextBox.Text = CStr(mdblB2Min)
                End If
            Else
                MessageBox.Show("Invalid limit", "Error!", MessageBoxButtons.OK)
                B2MinTextBox.Text = CStr(mdblB2Min)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub T1VTextBox_TextChanged(sender As Object, e As EventArgs) Handles T1VTextBox.TextChanged

        Dim dblTemp As Double

        Try
            dblTemp = Val(T1VTextBox.Text)

            If dblTemp > 1.0 Then              'Make sure it is a number and positive.
                mdblT1Vp = dblTemp
                BetaLabel.Text = Format((2 * PI * mobjInterFormMessage.dblFreq) / mdblT1Vp, "####0.00")

            Else
                MessageBox.Show("Invalid number", "Error!", MessageBoxButtons.OK)
                T1VTextBox.Text = CStr(mdblT1Vp)    'Restore the original 
                'T1VTextBox.Text = Format(mdblT1Vp, )    'Restore the original value
            End If

        Catch theException As Exception
            MessageBox.Show(theException.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Author             :  Fabian Kung
    'Last date modified :  1st April 2016
    'Language           :  VB .NET
    'Description        :  Subroutine to compute the input impedance looking into a network, consisting
    '                      of a load in series with double-stub transmission line network.
    'Argument           :  None

    Private Sub CalculateTin()
        Static Dim objY1 As New ComplexNumberClass(0, 0)
        Static Dim objT1 As New ComplexNumberClass(0, 0)
        Static Dim objZ1 As New ComplexNumberClass(0, 0)
        Static Dim objT1p As New ComplexNumberClass(0, 0)
        Static Dim objY1p As New ComplexNumberClass(0, 0)
        Static Dim objTemp As New ComplexNumberClass(0, 0)
        Static Dim objNum As New ComplexNumberClass(0, 0)
        Static Dim objY2 As New ComplexNumberClass(0, 0)
        Static Dim objExp2BetaLen As New ComplexNumberClass(0, 0)
        Static Dim objDen As New ComplexNumberClass(0, 0)

        Dim objZo As New ComplexNumberClass(mobjInterFormMessage.dblZo, 0)
        Dim dbl2BetaLen As Double


        '2*(Phase of Transmission line 1), where the phase is
        'given by Beta x Length.
        dbl2BetaLen = 2.0 * mdblT1Phase

        objY1 = objY1.AddComplex(mobjYL, mobjB1)          'Y1 = jB1 + (1/ZL)
        objZ1 = objY1.DivComplex(mobj1Complex, objY1)     'Z1 = 1/Y1
        objT1 = objT1.SubComplex(objZ1, objZo)            'Form Z1-Zo
        objTemp = objTemp.AddComplex(objZ1, objZo)        'Form Z1+Zo
        objT1 = objT1.DivComplex(objT1, objTemp)          'T1 = (Z1-Zo)/(Z1+Zo)
        objExp2BetaLen.Real = Math.Cos(dbl2BetaLen)       'Form exp(-j*2*Beta*Length)
        objExp2BetaLen.Imagninary = Math.Sin(-dbl2BetaLen)
        objT1p = objT1.MulComplex(objT1, objExp2BetaLen)   'Form T1p=T1*exp(-j*2*Beta*Length)
        objY1p = objY1p.AddComplex(mobj1Complex, objT1p)   'Form 1+T1p
        objY1p = objY1p.MulComplex(objY1p, objZo)          'Form (1+T1p)Zo
        objTemp = objTemp.SubComplex(mobj1Complex, objT1p) 'Form 1-T1p

        objY2 = objY2.DivComplex(objTemp, objY1p)           'Form Y2 = (1-T1p)/[(1+T1p)*Zo]
        mobjYin = mobjYin.AddComplex(mobjB2, objY2)         'Yin = jB2 + Y2
        mobjZin = mobjZin.DivComplex(mobj1Complex, mobjYin) 'Zin = 1/Yin 

        'Calculate Tin = (Zin-Zo)/(Zin+Zo)
        objNum = objNum.SubComplex(mobjZin, objZo)
        objDen = objDen.AddComplex(mobjZin, objZo)
        mobjTin = mobjTin.DivComplex(objNum, objDen)
    End Sub

    Private Sub ImpedanceTransformForm2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        mobjInterFormMessage.intID3 = 0 'Indicate this resources is disposed.

    End Sub

End Class


