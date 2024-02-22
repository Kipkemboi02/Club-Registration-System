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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtname = New TextBox()
        txtreg = New TextBox()
        txtphone = New TextBox()
        txtemail = New TextBox()
        cmbgender = New ComboBox()
        cmbcourse = New ComboBox()
        cmbschool = New ComboBox()
        cmbresidence = New ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(51, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(51, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 1
        Label2.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 2
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(392, 63)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 4
        Label5.Text = "Reg No"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(392, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 5
        Label6.Text = "School"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(392, 180)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 15)
        Label7.TabIndex = 6
        Label7.Text = "Course"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(392, 242)
        Label8.Name = "Label8"
        Label8.Size = New Size(60, 15)
        Label8.TabIndex = 7
        Label8.Text = "Residence"
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(117, 55)
        txtname.Name = "txtname"
        txtname.Size = New Size(177, 23)
        txtname.TabIndex = 8
        ' 
        ' txtreg
        ' 
        txtreg.Location = New Point(460, 60)
        txtreg.Name = "txtreg"
        txtreg.Size = New Size(100, 23)
        txtreg.TabIndex = 9
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(117, 172)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(100, 23)
        txtphone.TabIndex = 10
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(117, 239)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(137, 23)
        txtemail.TabIndex = 11
        ' 
        ' cmbgender
        ' 
        cmbgender.FormattingEnabled = True
        cmbgender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        cmbgender.Location = New Point(117, 118)
        cmbgender.Name = "cmbgender"
        cmbgender.Size = New Size(121, 23)
        cmbgender.TabIndex = 14
        ' 
        ' cmbcourse
        ' 
        cmbcourse.FormattingEnabled = True
        cmbcourse.Items.AddRange(New Object() {"Bachelor of Education Arts", "Bachelor of Education Science", "Bacheor of Science", "Bachelor of Theology", "Bachelor of BUsiness in Commerce", "Bachelor of Business in Economics", "Bachelor Of Business in IT", "Bachelor of Economic Statistics", "Bachelor of Science in Computer Science", "Bachelor of Science in Arcturial Science", "Bachelor of IT", "Bachelor of Telecommunication Engineering", "Bachelor Of Pharmacy", "Bachelor of medicine", "Bachelor Of Nursing", "Bachelor Of Music", "Bachelor of Media ", "Bachelor of Law"})
        cmbcourse.Location = New Point(460, 172)
        cmbcourse.Name = "cmbcourse"
        cmbcourse.Size = New Size(121, 23)
        cmbcourse.TabIndex = 15
        ' 
        ' cmbschool
        ' 
        cmbschool.FormattingEnabled = True
        cmbschool.Items.AddRange(New Object() {"School Of Education", "School Of Business and Economics", "School of Science Engineeering And Technology", "School Of Pharmacy", "School Of Medicine and Nursing", "School of Music and Media", "School of Law"})
        cmbschool.Location = New Point(460, 113)
        cmbschool.Name = "cmbschool"
        cmbschool.Size = New Size(206, 23)
        cmbschool.TabIndex = 16
        ' 
        ' cmbresidence
        ' 
        cmbresidence.FormattingEnabled = True
        cmbresidence.Items.AddRange(New Object() {"Resident", "Non-Resident"})
        cmbresidence.Location = New Point(460, 234)
        cmbresidence.Name = "cmbresidence"
        cmbresidence.Size = New Size(121, 23)
        cmbresidence.TabIndex = 17
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(277, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 30)
        Button1.TabIndex = 18
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(cmbresidence)
        Controls.Add(cmbschool)
        Controls.Add(cmbcourse)
        Controls.Add(cmbgender)
        Controls.Add(txtemail)
        Controls.Add(txtphone)
        Controls.Add(txtreg)
        Controls.Add(txtname)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "User Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtreg As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents cmbcourse As ComboBox
    Friend WithEvents cmbschool As ComboBox
    Friend WithEvents cmbresidence As ComboBox
    Friend WithEvents Button1 As Button

End Class
