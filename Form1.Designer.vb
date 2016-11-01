<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PracticalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordHandlingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubmitTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PracticalsToolStripMenuItem, Me.SubmitTSMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PracticalsToolStripMenuItem
        '
        Me.PracticalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSourceToolStripMenuItem, Me.PasswordHandlingToolStripMenuItem})
        Me.PracticalsToolStripMenuItem.Name = "PracticalsToolStripMenuItem"
        Me.PracticalsToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.PracticalsToolStripMenuItem.Text = "Practicals"
        '
        'ViewSourceToolStripMenuItem
        '
        Me.ViewSourceToolStripMenuItem.Name = "ViewSourceToolStripMenuItem"
        Me.ViewSourceToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.ViewSourceToolStripMenuItem.Text = "View source"
        '
        'PasswordHandlingToolStripMenuItem
        '
        Me.PasswordHandlingToolStripMenuItem.Name = "PasswordHandlingToolStripMenuItem"
        Me.PasswordHandlingToolStripMenuItem.Size = New System.Drawing.Size(237, 26)
        Me.PasswordHandlingToolStripMenuItem.Text = "09 - Password handling"
        '
        'SubmitTSMI
        '
        Me.SubmitTSMI.Name = "SubmitTSMI"
        Me.SubmitTSMI.Size = New System.Drawing.Size(68, 24)
        Me.SubmitTSMI.Text = "Submit"
        '
        'contentPanel
        '
        Me.contentPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.contentPanel.Location = New System.Drawing.Point(0, 28)
        Me.contentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(282, 225)
        Me.contentPanel.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PracticalsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSourceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasswordHandlingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubmitTSMI As ToolStripMenuItem
    Friend WithEvents contentPanel As Panel
End Class
