<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Voter_Login
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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        LinkLabel2 = New LinkLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.FromArgb(CByte(10), CByte(10), CByte(22))
        LinkLabel1.Location = New Point(304, 18)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(164, 15)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "JIVO ONLINE VOTING SYSTEM"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(210), CByte(224), CByte(250))
        PictureBox1.Location = New Point(-1, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(800, 50)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 4
        Label1.Text = "Voter Login"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 5
        Label2.Text = "Email Address"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(27, 158)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(202, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(27, 222)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(202, 23)
        TextBox2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(27, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(202, 31)
        Button1.TabIndex = 9
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(27, 258)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(93, 15)
        LinkLabel2.TabIndex = 10
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "New to this site?"
        ' 
        ' Voter_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LinkLabel1)
        Controls.Add(PictureBox1)
        Name = "Voter_Login"
        Text = "Voter_Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
