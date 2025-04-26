<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Panel1 = New Panel()
        ToolStripContainer2 = New ToolStripContainer()
        MENU_GROUP7 = New MenuStrip()
        ScheduleToolStripMenuItem = New ToolStripMenuItem()
        GradesToolStripMenuItem = New ToolStripMenuItem()
        CalendarToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        FacultyEvaluationToolStripMenuItem = New ToolStripMenuItem()
        ApplyForGraduationToolStripMenuItem = New ToolStripMenuItem()
        WELCOMELBL_GROUP7 = New Label()
        LOGOUTLBL_GROUP7 = New Label()
        BG_GROUP7 = New PictureBox()
        PANELHEADER_GROUP7 = New Panel()
        LOGO_GROUP7 = New PictureBox()
        Panel1.SuspendLayout()
        ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        ToolStripContainer2.SuspendLayout()
        MENU_GROUP7.SuspendLayout()
        CType(BG_GROUP7, ComponentModel.ISupportInitialize).BeginInit()
        PANELHEADER_GROUP7.SuspendLayout()
        CType(LOGO_GROUP7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ToolStripContainer2)
        Panel1.Controls.Add(WELCOMELBL_GROUP7)
        Panel1.Controls.Add(LOGOUTLBL_GROUP7)
        Panel1.Controls.Add(BG_GROUP7)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1906, 1046)
        Panel1.TabIndex = 0
        ' 
        ' ToolStripContainer2
        ' 
        ' 
        ' ToolStripContainer2.ContentPanel
        ' 
        ToolStripContainer2.ContentPanel.Size = New Size(947, 1)
        ToolStripContainer2.Location = New Point(0, 66)
        ToolStripContainer2.Name = "ToolStripContainer2"
        ToolStripContainer2.Size = New Size(947, 25)
        ToolStripContainer2.TabIndex = 8
        ToolStripContainer2.Text = "ToolStripContainer2"
        ' 
        ' ToolStripContainer2.TopToolStripPanel
        ' 
        ToolStripContainer2.TopToolStripPanel.Controls.Add(MENU_GROUP7)
        ' 
        ' MENU_GROUP7
        ' 
        MENU_GROUP7.BackColor = Color.FromArgb(CByte(159), CByte(58), CByte(59))
        MENU_GROUP7.Dock = DockStyle.None
        MENU_GROUP7.GripMargin = New Padding(2)
        MENU_GROUP7.Items.AddRange(New ToolStripItem() {ScheduleToolStripMenuItem, GradesToolStripMenuItem, CalendarToolStripMenuItem, ToolStripMenuItem1, FacultyEvaluationToolStripMenuItem, ApplyForGraduationToolStripMenuItem})
        MENU_GROUP7.Location = New Point(0, 0)
        MENU_GROUP7.Name = "MENU_GROUP7"
        MENU_GROUP7.Size = New Size(947, 24)
        MENU_GROUP7.TabIndex = 0
        MENU_GROUP7.Text = "MenuStrip1"
        ' 
        ' ScheduleToolStripMenuItem
        ' 
        ScheduleToolStripMenuItem.BackColor = Color.FromArgb(CByte(121), CByte(44), CByte(45))
        ScheduleToolStripMenuItem.ForeColor = Color.White
        ScheduleToolStripMenuItem.Margin = New Padding(23, 0, 4, 0)
        ScheduleToolStripMenuItem.Name = "ScheduleToolStripMenuItem"
        ScheduleToolStripMenuItem.Size = New Size(67, 20)
        ScheduleToolStripMenuItem.Text = "Schedule"
        ' 
        ' GradesToolStripMenuItem
        ' 
        GradesToolStripMenuItem.BackColor = Color.FromArgb(CByte(121), CByte(44), CByte(45))
        GradesToolStripMenuItem.ForeColor = Color.White
        GradesToolStripMenuItem.Margin = New Padding(4, 0, 4, 0)
        GradesToolStripMenuItem.Name = "GradesToolStripMenuItem"
        GradesToolStripMenuItem.Size = New Size(55, 20)
        GradesToolStripMenuItem.Text = "Grades"
        ' 
        ' CalendarToolStripMenuItem
        ' 
        CalendarToolStripMenuItem.BackColor = Color.FromArgb(CByte(121), CByte(44), CByte(45))
        CalendarToolStripMenuItem.ForeColor = Color.White
        CalendarToolStripMenuItem.Margin = New Padding(4, 0, 4, 0)
        CalendarToolStripMenuItem.Name = "CalendarToolStripMenuItem"
        CalendarToolStripMenuItem.Size = New Size(66, 20)
        CalendarToolStripMenuItem.Text = "Calendar"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.BackColor = Color.FromArgb(CByte(121), CByte(44), CByte(45))
        ToolStripMenuItem1.ForeColor = Color.White
        ToolStripMenuItem1.Margin = New Padding(4, 0, 4, 0)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(69, 20)
        ToolStripMenuItem1.Text = "Password"
        ' 
        ' FacultyEvaluationToolStripMenuItem
        ' 
        FacultyEvaluationToolStripMenuItem.BackColor = Color.FromArgb(CByte(121), CByte(44), CByte(45))
        FacultyEvaluationToolStripMenuItem.ForeColor = Color.White
        FacultyEvaluationToolStripMenuItem.Margin = New Padding(4, 0, 4, 0)
        FacultyEvaluationToolStripMenuItem.Name = "FacultyEvaluationToolStripMenuItem"
        FacultyEvaluationToolStripMenuItem.Size = New Size(115, 20)
        FacultyEvaluationToolStripMenuItem.Text = "Faculty Evaluation"
        ' 
        ' ApplyForGraduationToolStripMenuItem
        ' 
        ApplyForGraduationToolStripMenuItem.BackColor = Color.FromArgb(CByte(121), CByte(44), CByte(45))
        ApplyForGraduationToolStripMenuItem.ForeColor = Color.White
        ApplyForGraduationToolStripMenuItem.Margin = New Padding(4, 0, 4, 0)
        ApplyForGraduationToolStripMenuItem.Name = "ApplyForGraduationToolStripMenuItem"
        ApplyForGraduationToolStripMenuItem.Size = New Size(130, 20)
        ApplyForGraduationToolStripMenuItem.Text = "Apply for Graduation"
        ' 
        ' WELCOMELBL_GROUP7
        ' 
        WELCOMELBL_GROUP7.AutoSize = True
        WELCOMELBL_GROUP7.BackColor = Color.FromArgb(CByte(237), CByte(184), CByte(186))
        WELCOMELBL_GROUP7.Font = New Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        WELCOMELBL_GROUP7.ForeColor = Color.Black
        WELCOMELBL_GROUP7.Location = New Point(32, 106)
        WELCOMELBL_GROUP7.Name = "WELCOMELBL_GROUP7"
        WELCOMELBL_GROUP7.Size = New Size(407, 22)
        WELCOMELBL_GROUP7.TabIndex = 7
        WELCOMELBL_GROUP7.Text = "Welcome, LAST NAME, FIRST NAME, MIDDLE NAME (TUP-00-0000)"
        WELCOMELBL_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LOGOUTLBL_GROUP7
        ' 
        LOGOUTLBL_GROUP7.AutoSize = True
        LOGOUTLBL_GROUP7.BackColor = Color.FromArgb(CByte(237), CByte(184), CByte(186))
        LOGOUTLBL_GROUP7.Font = New Font("Poppins", 9F, FontStyle.Bold)
        LOGOUTLBL_GROUP7.ForeColor = Color.Black
        LOGOUTLBL_GROUP7.Location = New Point(859, 106)
        LOGOUTLBL_GROUP7.Name = "LOGOUTLBL_GROUP7"
        LOGOUTLBL_GROUP7.Size = New Size(53, 22)
        LOGOUTLBL_GROUP7.TabIndex = 6
        LOGOUTLBL_GROUP7.Text = "Logout"
        LOGOUTLBL_GROUP7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BG_GROUP7
        ' 
        BG_GROUP7.Image = My.Resources.Resources.Your_paragraph_text__37_
        BG_GROUP7.Location = New Point(-21, -3)
        BG_GROUP7.Name = "BG_GROUP7"
        BG_GROUP7.Size = New Size(983, 552)
        BG_GROUP7.SizeMode = PictureBoxSizeMode.Zoom
        BG_GROUP7.TabIndex = 2
        BG_GROUP7.TabStop = False
        ' 
        ' PANELHEADER_GROUP7
        ' 
        PANELHEADER_GROUP7.BackColor = Color.FromArgb(CByte(196), CByte(32), CByte(57))
        PANELHEADER_GROUP7.Controls.Add(LOGO_GROUP7)
        PANELHEADER_GROUP7.Location = New Point(0, 0)
        PANELHEADER_GROUP7.Name = "PANELHEADER_GROUP7"
        PANELHEADER_GROUP7.Size = New Size(946, 67)
        PANELHEADER_GROUP7.TabIndex = 3
        ' 
        ' LOGO_GROUP7
        ' 
        LOGO_GROUP7.BackgroundImageLayout = ImageLayout.Zoom
        LOGO_GROUP7.Image = My.Resources.Resources.Your_paragraph_text__30_
        LOGO_GROUP7.Location = New Point(-6, 3)
        LOGO_GROUP7.Name = "LOGO_GROUP7"
        LOGO_GROUP7.Size = New Size(490, 58)
        LOGO_GROUP7.SizeMode = PictureBoxSizeMode.Zoom
        LOGO_GROUP7.TabIndex = 0
        LOGO_GROUP7.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 501)
        Controls.Add(PANELHEADER_GROUP7)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer2.TopToolStripPanel.PerformLayout()
        ToolStripContainer2.ResumeLayout(False)
        ToolStripContainer2.PerformLayout()
        MENU_GROUP7.ResumeLayout(False)
        MENU_GROUP7.PerformLayout()
        CType(BG_GROUP7, ComponentModel.ISupportInitialize).EndInit()
        PANELHEADER_GROUP7.ResumeLayout(False)
        CType(LOGO_GROUP7, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PANELHEADER_GROUP7 As Panel
    Friend WithEvents LOGO_GROUP7 As PictureBox
    Friend WithEvents BG_GROUP7 As PictureBox
    Friend WithEvents LOGOUTLBL_GROUP7 As Label
    Friend WithEvents WELCOMELBL_GROUP7 As Label
    Friend WithEvents ToolStripContainer2 As ToolStripContainer
    Friend WithEvents MENU_GROUP7 As MenuStrip
    Friend WithEvents ScheduleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalendarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FacultyEvaluationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplyForGraduationToolStripMenuItem As ToolStripMenuItem
End Class
