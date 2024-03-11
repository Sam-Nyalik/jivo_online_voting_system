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
        PictureBox1 = New PictureBox()
        LinkLabel1 = New LinkLabel()
        Label1 = New Label()
        LinkLabel2 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(210), CByte(224), CByte(250))
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 50)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.FromArgb(CByte(10), CByte(10), CByte(22))
        LinkLabel1.Location = New Point(305, 18)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(164, 15)
        LinkLabel1.TabIndex = 1
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "JIVO ONLINE VOTING SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(296, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(214, 15)
        Label1.TabIndex = 2
        Label1.Text = "Welcome to our online voting platform"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
        LinkLabel2.Location = New Point(278, 187)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(39, 15)
        LinkLabel2.TabIndex = 3
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Voters"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.LinkColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
        LinkLabel3.Location = New Point(417, 187)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(158, 15)
        LinkLabel3.TabIndex = 4
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Election Commission Officer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel3)
        Controls.Add(LinkLabel2)
        Controls.Add(Label1)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel

End Class
