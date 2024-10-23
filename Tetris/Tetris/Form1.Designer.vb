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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MovementTimer = New Timer(components)
        Avatar = New PictureBox()
        PictureBox2 = New PictureBox()
        EnemyKill = New PictureBox()
        Enemy2Kill = New PictureBox()
        Enemy3 = New PictureBox()
        Platform = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        ScoreLabel = New Label()
        Label1 = New Label()
        ScoreTimer = New Timer(components)
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox16 = New PictureBox()
        PictureBox17 = New PictureBox()
        PictureBox18 = New PictureBox()
        PictureBox19 = New PictureBox()
        PictureBox20 = New PictureBox()
        PictureBox21 = New PictureBox()
        PictureBox22 = New PictureBox()
        PictureBox24 = New PictureBox()
        PictureBox25 = New PictureBox()
        PictureBox26 = New PictureBox()
        PictureBox27 = New PictureBox()
        PictureBox28 = New PictureBox()
        PictureBox29 = New PictureBox()
        PictureBox30 = New PictureBox()
        PictureBox31 = New PictureBox()
        PictureBox23 = New PictureBox()
        PictureBox32 = New PictureBox()
        DiedScreen = New PictureBox()
        LooseLabel = New Label()
        Label2 = New Label()
        CoinsCollected = New Label()
        YOUWIN = New Label()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(EnemyKill, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2Kill, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox17, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox21, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox22, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox24, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox25, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox26, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox27, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox28, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox29, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox30, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox31, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox32, ComponentModel.ISupportInitialize).BeginInit()
        CType(DiedScreen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MovementTimer
        ' 
        MovementTimer.Enabled = True
        MovementTimer.Interval = 20
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(972, 137)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(77, 72)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(473, 158)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        PictureBox2.Tag = "coin"
        ' 
        ' EnemyKill
        ' 
        EnemyKill.Image = CType(resources.GetObject("EnemyKill.Image"), Image)
        EnemyKill.Location = New Point(361, 494)
        EnemyKill.Name = "EnemyKill"
        EnemyKill.Size = New Size(77, 72)
        EnemyKill.SizeMode = PictureBoxSizeMode.StretchImage
        EnemyKill.TabIndex = 2
        EnemyKill.TabStop = False
        EnemyKill.Tag = "-1"
        ' 
        ' Enemy2Kill
        ' 
        Enemy2Kill.Image = CType(resources.GetObject("Enemy2Kill.Image"), Image)
        Enemy2Kill.Location = New Point(40, 663)
        Enemy2Kill.Name = "Enemy2Kill"
        Enemy2Kill.Size = New Size(102, 92)
        Enemy2Kill.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2Kill.TabIndex = 3
        Enemy2Kill.TabStop = False
        Enemy2Kill.Tag = "Kill"
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(1623, 551)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(103, 105)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        Enemy3.Tag = "Kill"
        ' 
        ' Platform
        ' 
        Platform.Image = CType(resources.GetObject("Platform.Image"), Image)
        Platform.Location = New Point(315, 567)
        Platform.Name = "Platform"
        Platform.Size = New Size(396, 43)
        Platform.SizeMode = PictureBoxSizeMode.StretchImage
        Platform.TabIndex = 5
        Platform.TabStop = False
        Platform.Tag = "wall"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-1, -2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(1820, 20)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        PictureBox3.Tag = "wall"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(160, 705)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 206)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        PictureBox1.Tag = "wall"
        ' 
        ' ScoreLabel
        ' 
        ScoreLabel.AutoSize = True
        ScoreLabel.BorderStyle = BorderStyle.FixedSingle
        ScoreLabel.Font = New Font("Bookman Old Style", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ScoreLabel.Location = New Point(160, 9)
        ScoreLabel.Name = "ScoreLabel"
        ScoreLabel.Size = New Size(46, 45)
        ScoreLabel.TabIndex = 9
        ScoreLabel.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Bookman Old Style", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(-1, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 45)
        Label1.TabIndex = 10
        Label1.Text = "Points:"
        ' 
        ' ScoreTimer
        ' 
        ScoreTimer.Enabled = True
        ScoreTimer.Interval = 1000
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(26, 567)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(160, 39)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        PictureBox4.Tag = "wall"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1306, 92)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(57, 51)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        PictureBox5.Tag = "coin"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(218, 350)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(57, 51)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        PictureBox6.Tag = "coin"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(954, 652)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(57, 51)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        PictureBox7.Tag = "coin"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(549, 498)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(57, 51)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        PictureBox8.Tag = "coin"
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), Image)
        PictureBox9.Location = New Point(1109, 722)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(57, 51)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 17
        PictureBox9.TabStop = False
        PictureBox9.Tag = "coin"
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), Image)
        PictureBox10.Location = New Point(1596, 272)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(57, 51)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 18
        PictureBox10.TabStop = False
        PictureBox10.Tag = "coin"
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(254, 819)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(57, 51)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 19
        PictureBox11.TabStop = False
        PictureBox11.Tag = "coin"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), Image)
        PictureBox12.Location = New Point(1555, 722)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(57, 51)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 20
        PictureBox12.TabStop = False
        PictureBox12.Tag = "coin"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(489, 648)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(57, 51)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 21
        PictureBox13.TabStop = False
        PictureBox13.Tag = "coin"
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(841, 158)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(57, 51)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 22
        PictureBox14.TabStop = False
        PictureBox14.Tag = "coin"
        ' 
        ' PictureBox15
        ' 
        PictureBox15.Image = CType(resources.GetObject("PictureBox15.Image"), Image)
        PictureBox15.Location = New Point(85, 158)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(57, 51)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 23
        PictureBox15.TabStop = False
        PictureBox15.Tag = "coin"
        ' 
        ' PictureBox16
        ' 
        PictureBox16.Image = CType(resources.GetObject("PictureBox16.Image"), Image)
        PictureBox16.Location = New Point(841, 428)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(57, 51)
        PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox16.TabIndex = 24
        PictureBox16.TabStop = False
        PictureBox16.Tag = "coin"
        ' 
        ' PictureBox17
        ' 
        PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), Image)
        PictureBox17.Location = New Point(1054, 284)
        PictureBox17.Name = "PictureBox17"
        PictureBox17.Size = New Size(57, 51)
        PictureBox17.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox17.TabIndex = 25
        PictureBox17.TabStop = False
        PictureBox17.Tag = "coin"
        ' 
        ' PictureBox18
        ' 
        PictureBox18.Image = CType(resources.GetObject("PictureBox18.Image"), Image)
        PictureBox18.Location = New Point(489, 304)
        PictureBox18.Name = "PictureBox18"
        PictureBox18.Size = New Size(57, 51)
        PictureBox18.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox18.TabIndex = 26
        PictureBox18.TabStop = False
        PictureBox18.Tag = "coin"
        ' 
        ' PictureBox19
        ' 
        PictureBox19.Image = CType(resources.GetObject("PictureBox19.Image"), Image)
        PictureBox19.Location = New Point(1485, 428)
        PictureBox19.Name = "PictureBox19"
        PictureBox19.Size = New Size(57, 51)
        PictureBox19.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox19.TabIndex = 27
        PictureBox19.TabStop = False
        PictureBox19.Tag = "coin"
        ' 
        ' PictureBox20
        ' 
        PictureBox20.Image = CType(resources.GetObject("PictureBox20.Image"), Image)
        PictureBox20.Location = New Point(1669, 494)
        PictureBox20.Name = "PictureBox20"
        PictureBox20.Size = New Size(57, 51)
        PictureBox20.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox20.TabIndex = 28
        PictureBox20.TabStop = False
        PictureBox20.Tag = "coin"
        ' 
        ' PictureBox21
        ' 
        PictureBox21.Image = CType(resources.GetObject("PictureBox21.Image"), Image)
        PictureBox21.Location = New Point(911, 223)
        PictureBox21.Name = "PictureBox21"
        PictureBox21.Size = New Size(27, 387)
        PictureBox21.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox21.TabIndex = 29
        PictureBox21.TabStop = False
        PictureBox21.Tag = "wall"
        ' 
        ' PictureBox22
        ' 
        PictureBox22.Image = CType(resources.GetObject("PictureBox22.Image"), Image)
        PictureBox22.Location = New Point(-1, 57)
        PictureBox22.Name = "PictureBox22"
        PictureBox22.Size = New Size(30, 854)
        PictureBox22.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox22.TabIndex = 30
        PictureBox22.TabStop = False
        PictureBox22.Tag = "wall"
        ' 
        ' PictureBox24
        ' 
        PictureBox24.Image = CType(resources.GetObject("PictureBox24.Image"), Image)
        PictureBox24.Location = New Point(1109, 366)
        PictureBox24.Name = "PictureBox24"
        PictureBox24.Size = New Size(57, 51)
        PictureBox24.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox24.TabIndex = 32
        PictureBox24.TabStop = False
        PictureBox24.Tag = "coin"
        ' 
        ' PictureBox25
        ' 
        PictureBox25.Image = CType(resources.GetObject("PictureBox25.Image"), Image)
        PictureBox25.Location = New Point(97, 786)
        PictureBox25.Name = "PictureBox25"
        PictureBox25.Size = New Size(57, 51)
        PictureBox25.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox25.TabIndex = 33
        PictureBox25.TabStop = False
        PictureBox25.Tag = "coin"
        ' 
        ' PictureBox26
        ' 
        PictureBox26.Image = CType(resources.GetObject("PictureBox26.Image"), Image)
        PictureBox26.Location = New Point(35, 786)
        PictureBox26.Name = "PictureBox26"
        PictureBox26.Size = New Size(57, 51)
        PictureBox26.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox26.TabIndex = 34
        PictureBox26.TabStop = False
        PictureBox26.Tag = "coin"
        ' 
        ' PictureBox27
        ' 
        PictureBox27.Image = CType(resources.GetObject("PictureBox27.Image"), Image)
        PictureBox27.Location = New Point(98, 843)
        PictureBox27.Name = "PictureBox27"
        PictureBox27.Size = New Size(57, 51)
        PictureBox27.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox27.TabIndex = 35
        PictureBox27.TabStop = False
        PictureBox27.Tag = "coin"
        ' 
        ' PictureBox28
        ' 
        PictureBox28.Image = CType(resources.GetObject("PictureBox28.Image"), Image)
        PictureBox28.Location = New Point(35, 843)
        PictureBox28.Name = "PictureBox28"
        PictureBox28.Size = New Size(57, 51)
        PictureBox28.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox28.TabIndex = 36
        PictureBox28.TabStop = False
        PictureBox28.Tag = "coin"
        ' 
        ' PictureBox29
        ' 
        PictureBox29.Image = CType(resources.GetObject("PictureBox29.Image"), Image)
        PictureBox29.Location = New Point(315, 606)
        PictureBox29.Name = "PictureBox29"
        PictureBox29.Size = New Size(56, 202)
        PictureBox29.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox29.TabIndex = 37
        PictureBox29.TabStop = False
        PictureBox29.Tag = "wall"
        ' 
        ' PictureBox30
        ' 
        PictureBox30.Image = CType(resources.GetObject("PictureBox30.Image"), Image)
        PictureBox30.Location = New Point(473, 705)
        PictureBox30.Name = "PictureBox30"
        PictureBox30.Size = New Size(56, 202)
        PictureBox30.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox30.TabIndex = 38
        PictureBox30.TabStop = False
        PictureBox30.Tag = "wall"
        ' 
        ' PictureBox31
        ' 
        PictureBox31.Image = CType(resources.GetObject("PictureBox31.Image"), Image)
        PictureBox31.Location = New Point(655, 606)
        PictureBox31.Name = "PictureBox31"
        PictureBox31.Size = New Size(56, 202)
        PictureBox31.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox31.TabIndex = 39
        PictureBox31.TabStop = False
        PictureBox31.Tag = "wall"
        ' 
        ' PictureBox23
        ' 
        PictureBox23.Image = CType(resources.GetObject("PictureBox23.Image"), Image)
        PictureBox23.Location = New Point(1109, 498)
        PictureBox23.Name = "PictureBox23"
        PictureBox23.Size = New Size(503, 38)
        PictureBox23.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox23.TabIndex = 40
        PictureBox23.TabStop = False
        PictureBox23.Tag = "wall"
        ' 
        ' PictureBox32
        ' 
        PictureBox32.Image = CType(resources.GetObject("PictureBox32.Image"), Image)
        PictureBox32.Location = New Point(1485, 137)
        PictureBox32.Name = "PictureBox32"
        PictureBox32.Size = New Size(316, 41)
        PictureBox32.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox32.TabIndex = 41
        PictureBox32.TabStop = False
        PictureBox32.Tag = "wall"
        ' 
        ' DiedScreen
        ' 
        DiedScreen.BackColor = Color.DimGray
        DiedScreen.Location = New Point(-1, -2)
        DiedScreen.Name = "DiedScreen"
        DiedScreen.Size = New Size(1820, 909)
        DiedScreen.TabIndex = 42
        DiedScreen.TabStop = False
        DiedScreen.Visible = False
        ' 
        ' LooseLabel
        ' 
        LooseLabel.AutoSize = True
        LooseLabel.BackColor = SystemColors.Control
        LooseLabel.BorderStyle = BorderStyle.FixedSingle
        LooseLabel.Font = New Font("Bookman Old Style", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LooseLabel.ForeColor = Color.Red
        LooseLabel.Location = New Point(655, 304)
        LooseLabel.Name = "LooseLabel"
        LooseLabel.Size = New Size(468, 95)
        LooseLabel.TabIndex = 43
        LooseLabel.Text = "YOU LOSE"
        LooseLabel.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Bookman Old Style", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1428, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(321, 45)
        Label2.TabIndex = 44
        Label2.Text = "CoinsCollected:"
        ' 
        ' CoinsCollected
        ' 
        CoinsCollected.AutoSize = True
        CoinsCollected.BorderStyle = BorderStyle.FixedSingle
        CoinsCollected.Font = New Font("Bookman Old Style", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        CoinsCollected.Location = New Point(1755, 9)
        CoinsCollected.Name = "CoinsCollected"
        CoinsCollected.Size = New Size(46, 45)
        CoinsCollected.TabIndex = 45
        CoinsCollected.Text = "0"
        ' 
        ' YOUWIN
        ' 
        YOUWIN.AutoSize = True
        YOUWIN.BackColor = SystemColors.Control
        YOUWIN.BorderStyle = BorderStyle.FixedSingle
        YOUWIN.Font = New Font("Bookman Old Style", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        YOUWIN.ForeColor = Color.Green
        YOUWIN.Location = New Point(674, 306)
        YOUWIN.Name = "YOUWIN"
        YOUWIN.Size = New Size(437, 95)
        YOUWIN.TabIndex = 46
        YOUWIN.Text = "YOU WIN!"
        YOUWIN.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1819, 906)
        Controls.Add(YOUWIN)
        Controls.Add(CoinsCollected)
        Controls.Add(Label2)
        Controls.Add(LooseLabel)
        Controls.Add(ScoreLabel)
        Controls.Add(Label1)
        Controls.Add(DiedScreen)
        Controls.Add(PictureBox32)
        Controls.Add(PictureBox23)
        Controls.Add(PictureBox31)
        Controls.Add(PictureBox30)
        Controls.Add(PictureBox29)
        Controls.Add(PictureBox28)
        Controls.Add(PictureBox27)
        Controls.Add(PictureBox26)
        Controls.Add(PictureBox25)
        Controls.Add(PictureBox24)
        Controls.Add(PictureBox22)
        Controls.Add(PictureBox21)
        Controls.Add(PictureBox20)
        Controls.Add(PictureBox19)
        Controls.Add(PictureBox18)
        Controls.Add(PictureBox17)
        Controls.Add(PictureBox16)
        Controls.Add(PictureBox15)
        Controls.Add(PictureBox14)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox12)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox10)
        Controls.Add(PictureBox9)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(Platform)
        Controls.Add(Enemy3)
        Controls.Add(Enemy2Kill)
        Controls.Add(EnemyKill)
        Controls.Add(PictureBox2)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(EnemyKill, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2Kill, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox17, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox18, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox19, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox20, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox21, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox22, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox24, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox25, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox26, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox27, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox28, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox29, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox30, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox31, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox23, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox32, ComponentModel.ISupportInitialize).EndInit()
        CType(DiedScreen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MovementTimer As Timer
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EnemyKill As PictureBox
    Friend WithEvents Enemy2Kill As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ScoreTimer As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents PictureBox21 As PictureBox
    Friend WithEvents PictureBox22 As PictureBox
    Friend WithEvents PictureBox24 As PictureBox
    Friend WithEvents PictureBox25 As PictureBox
    Friend WithEvents PictureBox26 As PictureBox
    Friend WithEvents PictureBox27 As PictureBox
    Friend WithEvents PictureBox28 As PictureBox
    Friend WithEvents PictureBox29 As PictureBox
    Friend WithEvents PictureBox30 As PictureBox
    Friend WithEvents PictureBox31 As PictureBox
    Friend WithEvents PictureBox23 As PictureBox
    Friend WithEvents PictureBox32 As PictureBox
    Friend WithEvents DiedScreen As PictureBox
    Friend WithEvents LooseLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CoinsCollected As Label
    Friend WithEvents YOUWIN As Label

End Class
