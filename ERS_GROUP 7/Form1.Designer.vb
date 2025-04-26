<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        PANELHEADER_GROUP7 = New Panel()
        LOGO_GROUP7 = New PictureBox()
        MAINLBL_GROUP7 = New Label()
        BG_GROUP7 = New PictureBox()
        AUTHLBL_GROUP7 = New Label()
        USERNAME_GROUP7 = New Label()
        USERNAMEBOX_GROUP7 = New MaskedTextBox()
        PASSWORD_GROUP7 = New Label()
        BIRTHDATE_GROUP7 = New Label()
        PASSWORDBOX_GROUP7 = New TextBox()
        CLEARBUT_GROUP7 = New Button()
        LOGINBUT_GROUP7 = New Button()
        SUB_GROUP7 = New Label()
        BIRTHDATEBOX_GROUP7 = New MaskedTextBox()
        TOOLTIP1_GROUP7 = New ToolTip(components)
        TOOLTIP2_GROUP7 = New ToolTip(components)
        PANELHEADER_GROUP7.SuspendLayout()
        CType(LOGO_GROUP7, ComponentModel.ISupportInitialize).BeginInit()
        CType(BG_GROUP7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PANELHEADER_GROUP7
        ' 
        PANELHEADER_GROUP7.BackColor = Color.FromArgb(CByte(196), CByte(32), CByte(57))
        PANELHEADER_GROUP7.Controls.Add(LOGO_GROUP7)
        PANELHEADER_GROUP7.Location = New Point(0, 0)
        PANELHEADER_GROUP7.Name = "PANELHEADER_GROUP7"
        PANELHEADER_GROUP7.Size = New Size(944, 67)
        PANELHEADER_GROUP7.TabIndex = 1
        ' 
        ' LOGO_GROUP7
        ' 
        LOGO_GROUP7.BackgroundImageLayout = ImageLayout.Zoom
        LOGO_GROUP7.Image = My.Resources.Resources.Your_paragraph_text__30_
        LOGO_GROUP7.Location = New Point(-6, 3)
        LOGO_GROUP7.Name = "LOGO_GROUP7"
        LOGO_GROUP7.Size = New Size(490, 58)
        LOGO_GROUP7.SizeMode = PictureBoxSizeMode.Zoom
        LOGO_GROUP7.TabIndex = 8
        LOGO_GROUP7.TabStop = False
        ' 
        ' MAINLBL_GROUP7
        ' 
        MAINLBL_GROUP7.AutoSize = True
        MAINLBL_GROUP7.BackColor = Color.FromArgb(CByte(249), CByte(231), CByte(232))
        MAINLBL_GROUP7.Font = New Font("Poppins Medium", 12F, FontStyle.Bold)
        MAINLBL_GROUP7.Location = New Point(363, 84)
        MAINLBL_GROUP7.Name = "MAINLBL_GROUP7"
        MAINLBL_GROUP7.Size = New Size(222, 28)
        MAINLBL_GROUP7.TabIndex = 2
        MAINLBL_GROUP7.Text = "Student Access Module"
        MAINLBL_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BG_GROUP7
        ' 
        BG_GROUP7.Image = My.Resources.Resources.Your_paragraph_text__23_
        BG_GROUP7.Location = New Point(0, 0)
        BG_GROUP7.Name = "BG_GROUP7"
        BG_GROUP7.Size = New Size(944, 532)
        BG_GROUP7.SizeMode = PictureBoxSizeMode.Zoom
        BG_GROUP7.TabIndex = 0
        BG_GROUP7.TabStop = False
        ' 
        ' AUTHLBL_GROUP7
        ' 
        AUTHLBL_GROUP7.AutoSize = True
        AUTHLBL_GROUP7.BackColor = Color.FromArgb(CByte(94), CByte(70), CByte(71))
        AUTHLBL_GROUP7.Font = New Font("Poppins Medium", 7F, FontStyle.Bold)
        AUTHLBL_GROUP7.ForeColor = Color.White
        AUTHLBL_GROUP7.Location = New Point(226, 146)
        AUTHLBL_GROUP7.Name = "AUTHLBL_GROUP7"
        AUTHLBL_GROUP7.Size = New Size(126, 17)
        AUTHLBL_GROUP7.TabIndex = 2
        AUTHLBL_GROUP7.Text = "User Authentication"
        AUTHLBL_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' USERNAME_GROUP7
        ' 
        USERNAME_GROUP7.AutoSize = True
        USERNAME_GROUP7.BackColor = Color.FromArgb(CByte(94), CByte(70), CByte(71))
        USERNAME_GROUP7.Font = New Font("Poppins Medium", 7F, FontStyle.Bold)
        USERNAME_GROUP7.ForeColor = Color.White
        USERNAME_GROUP7.Location = New Point(226, 181)
        USERNAME_GROUP7.Name = "USERNAME_GROUP7"
        USERNAME_GROUP7.Size = New Size(70, 17)
        USERNAME_GROUP7.TabIndex = 2
        USERNAME_GROUP7.Text = "Username:"
        USERNAME_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' USERNAMEBOX_GROUP7
        ' 
        USERNAMEBOX_GROUP7.Font = New Font("Poppins", 7F)
        USERNAMEBOX_GROUP7.Location = New Point(225, 199)
        USERNAMEBOX_GROUP7.Mask = "LLLL-00-0000"
        USERNAMEBOX_GROUP7.Name = "USERNAMEBOX_GROUP7"
        USERNAMEBOX_GROUP7.Size = New Size(494, 21)
        USERNAMEBOX_GROUP7.TabIndex = 3
        ' 
        ' PASSWORD_GROUP7
        ' 
        PASSWORD_GROUP7.AutoSize = True
        PASSWORD_GROUP7.BackColor = Color.FromArgb(CByte(94), CByte(70), CByte(71))
        PASSWORD_GROUP7.Font = New Font("Poppins Medium", 7F, FontStyle.Bold)
        PASSWORD_GROUP7.ForeColor = Color.White
        PASSWORD_GROUP7.Location = New Point(227, 228)
        PASSWORD_GROUP7.Name = "PASSWORD_GROUP7"
        PASSWORD_GROUP7.Size = New Size(67, 17)
        PASSWORD_GROUP7.TabIndex = 4
        PASSWORD_GROUP7.Text = "Password:"
        PASSWORD_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BIRTHDATE_GROUP7
        ' 
        BIRTHDATE_GROUP7.AutoSize = True
        BIRTHDATE_GROUP7.BackColor = Color.FromArgb(CByte(94), CByte(70), CByte(71))
        BIRTHDATE_GROUP7.Font = New Font("Poppins Medium", 7F, FontStyle.Bold)
        BIRTHDATE_GROUP7.ForeColor = Color.White
        BIRTHDATE_GROUP7.Location = New Point(225, 274)
        BIRTHDATE_GROUP7.Name = "BIRTHDATE_GROUP7"
        BIRTHDATE_GROUP7.Size = New Size(67, 17)
        BIRTHDATE_GROUP7.TabIndex = 4
        BIRTHDATE_GROUP7.Text = "Birthdate:"
        BIRTHDATE_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PASSWORDBOX_GROUP7
        ' 
        PASSWORDBOX_GROUP7.Font = New Font("Poppins", 7F)
        PASSWORDBOX_GROUP7.Location = New Point(225, 246)
        PASSWORDBOX_GROUP7.Name = "PASSWORDBOX_GROUP7"
        PASSWORDBOX_GROUP7.PasswordChar = "*"c
        PASSWORDBOX_GROUP7.Size = New Size(494, 21)
        PASSWORDBOX_GROUP7.TabIndex = 6
        ' 
        ' CLEARBUT_GROUP7
        ' 
        CLEARBUT_GROUP7.BackColor = Color.FromArgb(CByte(196), CByte(32), CByte(57))
        CLEARBUT_GROUP7.FlatAppearance.BorderSize = 0
        CLEARBUT_GROUP7.FlatStyle = FlatStyle.Flat
        CLEARBUT_GROUP7.Font = New Font("Poppins Medium", 7F, FontStyle.Bold)
        CLEARBUT_GROUP7.ForeColor = Color.White
        CLEARBUT_GROUP7.Location = New Point(227, 334)
        CLEARBUT_GROUP7.Name = "CLEARBUT_GROUP7"
        CLEARBUT_GROUP7.Size = New Size(67, 25)
        CLEARBUT_GROUP7.TabIndex = 7
        CLEARBUT_GROUP7.Text = "Clear Entries"
        CLEARBUT_GROUP7.UseVisualStyleBackColor = False
        ' 
        ' LOGINBUT_GROUP7
        ' 
        LOGINBUT_GROUP7.BackColor = Color.FromArgb(CByte(196), CByte(32), CByte(57))
        LOGINBUT_GROUP7.FlatAppearance.BorderSize = 0
        LOGINBUT_GROUP7.FlatStyle = FlatStyle.Flat
        LOGINBUT_GROUP7.Font = New Font("Poppins Medium", 7F, FontStyle.Bold)
        LOGINBUT_GROUP7.ForeColor = Color.White
        LOGINBUT_GROUP7.Location = New Point(652, 334)
        LOGINBUT_GROUP7.Name = "LOGINBUT_GROUP7"
        LOGINBUT_GROUP7.Size = New Size(67, 25)
        LOGINBUT_GROUP7.TabIndex = 7
        LOGINBUT_GROUP7.Text = "Login"
        LOGINBUT_GROUP7.UseVisualStyleBackColor = False
        ' 
        ' SUB_GROUP7
        ' 
        SUB_GROUP7.AutoSize = True
        SUB_GROUP7.BackColor = Color.FromArgb(CByte(94), CByte(70), CByte(71))
        SUB_GROUP7.Font = New Font("Poppins", 7F, FontStyle.Bold)
        SUB_GROUP7.ForeColor = Color.White
        SUB_GROUP7.Location = New Point(226, 370)
        SUB_GROUP7.Name = "SUB_GROUP7"
        SUB_GROUP7.Size = New Size(222, 17)
        SUB_GROUP7.TabIndex = 4
        SUB_GROUP7.Text = "Your login details are stored in a variable!"
        SUB_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BIRTHDATEBOX_GROUP7
        ' 
        BIRTHDATEBOX_GROUP7.Font = New Font("Poppins", 7F)
        BIRTHDATEBOX_GROUP7.Location = New Point(225, 291)
        BIRTHDATEBOX_GROUP7.Mask = "00/00/0000"
        BIRTHDATEBOX_GROUP7.Name = "BIRTHDATEBOX_GROUP7"
        BIRTHDATEBOX_GROUP7.Size = New Size(494, 21)
        BIRTHDATEBOX_GROUP7.TabIndex = 3
        BIRTHDATEBOX_GROUP7.ValidatingType = GetType(Date)
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 501)
        Controls.Add(LOGINBUT_GROUP7)
        Controls.Add(CLEARBUT_GROUP7)
        Controls.Add(PASSWORDBOX_GROUP7)
        Controls.Add(SUB_GROUP7)
        Controls.Add(BIRTHDATE_GROUP7)
        Controls.Add(PASSWORD_GROUP7)
        Controls.Add(BIRTHDATEBOX_GROUP7)
        Controls.Add(USERNAMEBOX_GROUP7)
        Controls.Add(USERNAME_GROUP7)
        Controls.Add(AUTHLBL_GROUP7)
        Controls.Add(MAINLBL_GROUP7)
        Controls.Add(PANELHEADER_GROUP7)
        Controls.Add(BG_GROUP7)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PANELHEADER_GROUP7.ResumeLayout(False)
        CType(LOGO_GROUP7, ComponentModel.ISupportInitialize).EndInit()
        CType(BG_GROUP7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PANELHEADER_GROUP7 As Panel
    Friend WithEvents MAINLBL_GROUP7 As Label
    Friend WithEvents BG_GROUP7 As PictureBox
    Friend WithEvents AUTHLBL_GROUP7 As Label
    Friend WithEvents USERNAME_GROUP7 As Label
    Friend WithEvents USERNAMEBOX_GROUP7 As MaskedTextBox
    Friend WithEvents PASSWORD_GROUP7 As Label
    Friend WithEvents BIRTHDATE_GROUP7 As Label
    Friend WithEvents PASSWORDBOX_GROUP7 As TextBox
    Friend WithEvents CLEARBUT_GROUP7 As Button
    Friend WithEvents LOGINBUT_GROUP7 As Button
    Friend WithEvents SUB_GROUP7 As Label
    Friend WithEvents BIRTHDATEBOX_GROUP7 As MaskedTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LOGO_GROUP7 As PictureBox
    Friend WithEvents TOOLTIP1_GROUP7 As ToolTip
    Friend WithEvents TOOLTIP2_GROUP7 As ToolTip

End Class
