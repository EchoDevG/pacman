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
        Me.path1 = New System.Windows.Forms.PictureBox()
        Me.pacman = New System.Windows.Forms.PictureBox()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.pacmanImage = New System.Windows.Forms.PictureBox()
        Me.path2 = New System.Windows.Forms.PictureBox()
        Me.path3 = New System.Windows.Forms.PictureBox()
        Me.intersec1 = New System.Windows.Forms.PictureBox()
        CType(Me.path1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pacmanImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.path2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.path3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intersec1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'path1
        '
        Me.path1.BackColor = System.Drawing.Color.Blue
        Me.path1.Location = New System.Drawing.Point(200, 300)
        Me.path1.Name = "path1"
        Me.path1.Size = New System.Drawing.Size(300, 1)
        Me.path1.TabIndex = 26
        Me.path1.TabStop = False
        '
        'pacman
        '
        Me.pacman.BackColor = System.Drawing.Color.Yellow
        Me.pacman.Location = New System.Drawing.Point(200, 300)
        Me.pacman.Name = "pacman"
        Me.pacman.Size = New System.Drawing.Size(1, 1)
        Me.pacman.TabIndex = 30
        Me.pacman.TabStop = False
        '
        'Timer
        '
        '
        'pacmanImage
        '
        Me.pacmanImage.BackColor = System.Drawing.Color.Yellow
        Me.pacmanImage.Location = New System.Drawing.Point(182, 287)
        Me.pacmanImage.Name = "pacmanImage"
        Me.pacmanImage.Size = New System.Drawing.Size(30, 30)
        Me.pacmanImage.TabIndex = 31
        Me.pacmanImage.TabStop = False
        '
        'path2
        '
        Me.path2.BackColor = System.Drawing.Color.Blue
        Me.path2.Location = New System.Drawing.Point(500, 300)
        Me.path2.Name = "path2"
        Me.path2.Size = New System.Drawing.Size(1, 200)
        Me.path2.TabIndex = 32
        Me.path2.TabStop = False
        '
        'path3
        '
        Me.path3.BackColor = System.Drawing.Color.Blue
        Me.path3.Location = New System.Drawing.Point(350, 100)
        Me.path3.Name = "path3"
        Me.path3.Size = New System.Drawing.Size(1, 200)
        Me.path3.TabIndex = 33
        Me.path3.TabStop = False
        '
        'intersec1
        '
        Me.intersec1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.intersec1.Location = New System.Drawing.Point(345, 295)
        Me.intersec1.Name = "intersec1"
        Me.intersec1.Size = New System.Drawing.Size(10, 10)
        Me.intersec1.TabIndex = 34
        Me.intersec1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(684, 561)
        Me.Controls.Add(Me.intersec1)
        Me.Controls.Add(Me.path3)
        Me.Controls.Add(Me.path2)
        Me.Controls.Add(Me.pacmanImage)
        Me.Controls.Add(Me.pacman)
        Me.Controls.Add(Me.path1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.path1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pacman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pacmanImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.path2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.path3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intersec1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents path1 As PictureBox
    Friend WithEvents pacman As PictureBox
    Friend WithEvents Timer As Timer
    Friend WithEvents pacmanImage As PictureBox
    Friend WithEvents path2 As PictureBox
    Friend WithEvents path3 As PictureBox
    Friend WithEvents intersec1 As PictureBox
End Class
