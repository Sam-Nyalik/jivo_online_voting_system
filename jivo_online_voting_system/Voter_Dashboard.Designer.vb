<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voter_Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LinkLabel1 = New LinkLabel()
        PictureBox1 = New PictureBox()
        LinkLabel2 = New LinkLabel()
        LinkLabel3 = New LinkLabel()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        LinkLabel4 = New LinkLabel()
        LinkLabel5 = New LinkLabel()
        LinkLabel6 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.FromArgb(CByte(10), CByte(10), CByte(22))
        LinkLabel1.Location = New Point(12, 18)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(164, 15)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "JIVO ONLINE VOTING SYSTEM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(210), CByte(224), CByte(250))
        PictureBox1.Location = New Point(0, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 50)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.FromArgb(CByte(10), CByte(10), CByte(22))
        LinkLabel2.Location = New Point(725, 18)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(52, 15)
        LinkLabel2.TabIndex = 6
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Account"
        ' 
        ' LinkLabel3
        ' 
        LinkLabel3.AutoSize = True
        LinkLabel3.LinkColor = Color.FromArgb(CByte(10), CByte(10), CByte(22))
        LinkLabel3.Location = New Point(596, 18)
        LinkLabel3.Name = "LinkLabel3"
        LinkLabel3.Size = New Size(64, 15)
        LinkLabel3.TabIndex = 7
        LinkLabel3.TabStop = True
        LinkLabel3.Text = "Dashboard"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 15)
        Label1.TabIndex = 8
        Label1.Text = "Welcome [Name of the user]"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(246, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 9
        Label2.Text = "POLLS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(470, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 15)
        Label3.TabIndex = 10
        Label3.Text = "ELECTION RESULTS"
        ' 
        ' LinkLabel4
        ' 
        LinkLabel4.AutoSize = True
        LinkLabel4.LinkColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
        LinkLabel4.Location = New Point(237, 197)
        LinkLabel4.Name = "LinkLabel4"
        LinkLabel4.Size = New Size(63, 15)
        LinkLabel4.TabIndex = 11
        LinkLabel4.TabStop = True
        LinkLabel4.Text = "View More"
        ' 
        ' LinkLabel5
        ' 
        LinkLabel5.AutoSize = True
        LinkLabel5.LinkColor = Color.FromArgb(CByte(255), CByte(153), CByte(0))
        LinkLabel5.Location = New Point(492, 197)
        LinkLabel5.Name = "LinkLabel5"
        LinkLabel5.Size = New Size(63, 15)
        LinkLabel5.TabIndex = 12
        LinkLabel5.TabStop = True
        LinkLabel5.Text = "View More"
        ' 
        ' LinkLabel6
        ' 
        LinkLabel6.AutoSize = True
        LinkLabel6.LinkColor = Color.FromArgb(CByte(10), CByte(10), CByte(22))
        LinkLabel6.Location = New Point(677, 18)
        LinkLabel6.Name = "LinkLabel6"
        LinkLabel6.Size = New Size(32, 15)
        LinkLabel6.TabIndex = 13
        LinkLabel6.TabStop = True
        LinkLabel6.Text = "Help"
        ' 
        ' Voter_Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel6)
        Controls.Add(LinkLabel5)
        Controls.Add(LinkLabel4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LinkLabel3)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox1)
        Name = "Voter_Dashboard"
        Text = "Voter_Dashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
End Class
