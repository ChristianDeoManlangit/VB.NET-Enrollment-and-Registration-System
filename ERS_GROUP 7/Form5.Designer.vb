<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        MAIN_GROUP7 = New Panel()
        SuspendLayout()
        ' 
        ' MAIN_GROUP7
        ' 
        MAIN_GROUP7.Location = New Point(0, -2)
        MAIN_GROUP7.Name = "MAIN_GROUP7"
        MAIN_GROUP7.Size = New Size(945, 504)
        MAIN_GROUP7.TabIndex = 0
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 501)
        Controls.Add(MAIN_GROUP7)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MAIN_GROUP7 As Panel
End Class
