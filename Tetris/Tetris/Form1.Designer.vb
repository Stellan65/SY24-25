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
        Timer1 = New Timer(components)
        Avatar = New PictureBox()
        PictureBox2 = New PictureBox()
        Enemy = New PictureBox()
        Enemy2 = New PictureBox()
        Enemy3 = New PictureBox()
        Platform = New PictureBox()
        CType(Avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Enemy3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Platform, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Avatar
        ' 
        Avatar.Image = CType(resources.GetObject("Avatar.Image"), Image)
        Avatar.Location = New Point(1016, 147)
        Avatar.Name = "Avatar"
        Avatar.Size = New Size(77, 72)
        Avatar.SizeMode = PictureBoxSizeMode.StretchImage
        Avatar.TabIndex = 0
        Avatar.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(565, 498)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
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
        Platform.Size = New Size(336, 32)
        Platform.SizeMode = PictureBoxSizeMode.StretchImage
        Platform.TabIndex = 5
        Platform.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1318, 1055)
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
        ResumeLayout(False)
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Enemy As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Platform As PictureBox

End Class
