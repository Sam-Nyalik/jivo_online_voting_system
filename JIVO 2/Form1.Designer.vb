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
        ListBox1 = New ListBox()
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ListBox2 = New ListBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        ProgressBar2 = New ProgressBar()
        ProgressBar3 = New ProgressBar()
        ProgressBar4 = New ProgressBar()
        ProgressBar5 = New ProgressBar()
        ProgressBar6 = New ProgressBar()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"Babu owino", "George Wajakoyah", "Raila Odinga", "Mike Sonko", "Jonhson Sakaja", "", ""})
        ListBox1.Location = New Point(35, 93)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(364, 324)
        ListBox1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(286, 434)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 42)
        Button1.TabIndex = 1
        Button1.Text = "Add "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(93, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 45)
        Label1.TabIndex = 2
        Label1.Text = "Candidate List"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(36, 436)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(244, 39)
        TextBox1.TabIndex = 3
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.Items.AddRange(New Object() {"Embakasi South", "Embakasi East", "Dagoretti North", "Dagoretti South", "Starehe", "Westlands", "Langata", "Embakasi North", "Embakasi Central", "Embakasi West"})
        ListBox2.Location = New Point(558, 93)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(358, 324)
        ListBox2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(610, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(236, 45)
        Label2.TabIndex = 8
        Label2.Text = "Constituencies"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(558, 434)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(238, 39)
        TextBox2.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(802, 432)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 46)
        Button2.TabIndex = 10
        Button2.Text = "Add"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button3.Location = New Point(405, 233)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 46)
        Button3.TabIndex = 11
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(922, 231)
        Button4.Name = "Button4"
        Button4.Size = New Size(109, 46)
        Button4.TabIndex = 12
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(49, 509)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 45)
        Label3.TabIndex = 13
        Label3.Text = "POLLS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 592)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 32)
        Label4.TabIndex = 14
        Label4.Text = "Babu Owino"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(44, 667)
        Label5.Name = "Label5"
        Label5.Size = New Size(214, 32)
        Label5.TabIndex = 15
        Label5.Text = "George Wajakoyah"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(44, 736)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 32)
        Label6.TabIndex = 16
        Label6.Text = "Raila Odinga"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(44, 812)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 32)
        Label7.TabIndex = 17
        Label7.Text = "Mike Sonko"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(36, 887)
        Label8.Name = "Label8"
        Label8.Size = New Size(177, 32)
        Label8.TabIndex = 18
        Label8.Text = "Johnson Sakaja"
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(286, 578)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(200, 46)
        ProgressBar2.TabIndex = 19
        ProgressBar2.Value = 50
        ' 
        ' ProgressBar3
        ' 
        ProgressBar3.Location = New Point(286, 653)
        ProgressBar3.Name = "ProgressBar3"
        ProgressBar3.Size = New Size(200, 46)
        ProgressBar3.TabIndex = 20
        ProgressBar3.Value = 10
        ' 
        ' ProgressBar4
        ' 
        ProgressBar4.Location = New Point(286, 722)
        ProgressBar4.Name = "ProgressBar4"
        ProgressBar4.Size = New Size(200, 46)
        ProgressBar4.TabIndex = 21
        ProgressBar4.Value = 20
        ' 
        ' ProgressBar5
        ' 
        ProgressBar5.Location = New Point(286, 798)
        ProgressBar5.Name = "ProgressBar5"
        ProgressBar5.Size = New Size(200, 46)
        ProgressBar5.TabIndex = 22
        ProgressBar5.Value = 5
        ' 
        ' ProgressBar6
        ' 
        ProgressBar6.Location = New Point(286, 873)
        ProgressBar6.Name = "ProgressBar6"
        ProgressBar6.Size = New Size(200, 46)
        ProgressBar6.TabIndex = 23
        ProgressBar6.Value = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 954)
        Controls.Add(ProgressBar6)
        Controls.Add(ProgressBar5)
        Controls.Add(ProgressBar4)
        Controls.Add(ProgressBar3)
        Controls.Add(ProgressBar2)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(ListBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ProgressBar5 As ProgressBar
    Friend WithEvents ProgressBar6 As ProgressBar

End Class
