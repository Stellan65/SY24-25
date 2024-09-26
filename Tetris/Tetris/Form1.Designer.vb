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
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy3 = New PictureBox()
        Platform = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        ScoreLabel = New Label()
        Label1 = New Label()
        ScoreTimer = New Timer(components)
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MovementTimer
        ' 
        MovementTimer.Enabled = True
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
        PictureBox2.Location = New Point(785, 284)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        PictureBox2.Tag = "1"
        ' 
        ' Enemy
        ' 
        Enemy.Image = CType(resources.GetObject("Enemy.Image"), Image)
        Enemy.Location = New Point(362, 498)
        Enemy.Name = "Enemy"
        Enemy.Size = New Size(77, 72)
        Enemy.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy.TabIndex = 2
        Enemy.TabStop = False
        Enemy.Tag = "-1"
        ' 
        ' Enemy2
        ' 
        Enemy2.Image = CType(resources.GetObject("Enemy2.Image"), Image)
        Enemy2.Location = New Point(259, 156)
        Enemy2.Name = "Enemy2"
        Enemy2.Size = New Size(102, 92)
        Enemy2.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy2.TabIndex = 3
        Enemy2.TabStop = False
        ' 
        ' Enemy3
        ' 
        Enemy3.Image = CType(resources.GetObject("Enemy3.Image"), Image)
        Enemy3.Location = New Point(519, 156)
        Enemy3.Name = "Enemy3"
        Enemy3.Size = New Size(103, 105)
        Enemy3.SizeMode = PictureBoxSizeMode.StretchImage
        Enemy3.TabIndex = 4
        Enemy3.TabStop = False
        ' 
        ' Platform
        ' 
        Platform.Image = CType(resources.GetObject("Platform.Image"), Image)
        Platform.Location = New Point(315, 567)
        Platform.Name = "Platform"
        Platform.Size = New Size(479, 32)
        Platform.SizeMode = PictureBoxSizeMode.StretchImage
        Platform.TabIndex = 5
        Platform.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1143, 412)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(479, 32)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(995, 498)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 361)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1819, 906)
        Controls.Add(Label1)
        Controls.Add(ScoreLabel)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox3)
        Controls.Add(Platform)
        Controls.Add(Enemy3)
        Controls.Add(Enemy2)
        Controls.Add(Enemy)
        Controls.Add(PictureBox2)
        Controls.Add(Avatar)
        Name = "Form1"
        Text = "Form1"
        CType(Avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).EndInit()
        CType(Platform, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MovementTimer As Timer
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Platform As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ScoreTimer As Timer

End Class
