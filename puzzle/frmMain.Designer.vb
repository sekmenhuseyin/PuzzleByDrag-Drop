<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.tsmiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiLevel5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmiRotate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiShowHint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHowtoPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAboutMe = New System.Windows.Forms.ToolStripMenuItem()
        Me.fdOpen = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PboxSelected = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PboxSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 438)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(492, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFile, Me.tsmiLevel, Me.tsmiShowHint, Me.tsmiHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(492, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiFile
        '
        Me.tsmiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiNew, Me.tsmiOpen, Me.tsmiSave, Me.ToolStripMenuItem1, Me.tsmiExit})
        Me.tsmiFile.Name = "tsmiFile"
        Me.tsmiFile.Size = New System.Drawing.Size(37, 20)
        Me.tsmiFile.Text = "File"
        '
        'tsmiNew
        '
        Me.tsmiNew.Name = "tsmiNew"
        Me.tsmiNew.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsmiNew.Size = New System.Drawing.Size(133, 22)
        Me.tsmiNew.Text = "New"
        '
        'tsmiOpen
        '
        Me.tsmiOpen.Name = "tsmiOpen"
        Me.tsmiOpen.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.tsmiOpen.Size = New System.Drawing.Size(133, 22)
        Me.tsmiOpen.Text = "Open"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.tsmiSave.Size = New System.Drawing.Size(133, 22)
        Me.tsmiSave.Text = "Save"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 6)
        '
        'tsmiExit
        '
        Me.tsmiExit.Name = "tsmiExit"
        Me.tsmiExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.tsmiExit.Size = New System.Drawing.Size(133, 22)
        Me.tsmiExit.Text = "Exit"
        '
        'tsmiLevel
        '
        Me.tsmiLevel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiLevel1, Me.tsmiLevel2, Me.tsmiLevel3, Me.tsmiLevel4, Me.tsmiLevel5, Me.ToolStripMenuItem2, Me.tsmiRotate})
        Me.tsmiLevel.Name = "tsmiLevel"
        Me.tsmiLevel.Size = New System.Drawing.Size(46, 20)
        Me.tsmiLevel.Text = "Level"
        '
        'tsmiLevel1
        '
        Me.tsmiLevel1.Checked = True
        Me.tsmiLevel1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmiLevel1.Name = "tsmiLevel1"
        Me.tsmiLevel1.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel1.Text = "Level 1"
        '
        'tsmiLevel2
        '
        Me.tsmiLevel2.Name = "tsmiLevel2"
        Me.tsmiLevel2.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel2.Text = "Level 2"
        '
        'tsmiLevel3
        '
        Me.tsmiLevel3.Name = "tsmiLevel3"
        Me.tsmiLevel3.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel3.Text = "Level 3"
        '
        'tsmiLevel4
        '
        Me.tsmiLevel4.Name = "tsmiLevel4"
        Me.tsmiLevel4.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel4.Text = "Level 4"
        '
        'tsmiLevel5
        '
        Me.tsmiLevel5.Name = "tsmiLevel5"
        Me.tsmiLevel5.Size = New System.Drawing.Size(110, 22)
        Me.tsmiLevel5.Text = "Level 5"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(107, 6)
        '
        'tsmiRotate
        '
        Me.tsmiRotate.Name = "tsmiRotate"
        Me.tsmiRotate.Size = New System.Drawing.Size(110, 22)
        Me.tsmiRotate.Text = "Rotate"
        '
        'tsmiShowHint
        '
        Me.tsmiShowHint.Name = "tsmiShowHint"
        Me.tsmiShowHint.Size = New System.Drawing.Size(74, 20)
        Me.tsmiShowHint.Text = "Show Hint"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiHowtoPlay, Me.tsmiAboutMe})
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(44, 20)
        Me.tsmiHelp.Text = "Help"
        '
        'tsmiHowtoPlay
        '
        Me.tsmiHowtoPlay.Name = "tsmiHowtoPlay"
        Me.tsmiHowtoPlay.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsmiHowtoPlay.Size = New System.Drawing.Size(157, 22)
        Me.tsmiHowtoPlay.Text = "How to play"
        '
        'tsmiAboutMe
        '
        Me.tsmiAboutMe.Name = "tsmiAboutMe"
        Me.tsmiAboutMe.Size = New System.Drawing.Size(157, 22)
        Me.tsmiAboutMe.Text = "About Puzzle"
        '
        'fdOpen
        '
        Me.fdOpen.Title = "Please select a picture"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PboxSelected
        '
        Me.PboxSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PboxSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PboxSelected.Location = New System.Drawing.Point(12, 49)
        Me.PboxSelected.Name = "PboxSelected"
        Me.PboxSelected.Size = New System.Drawing.Size(100, 50)
        Me.PboxSelected.TabIndex = 2
        Me.PboxSelected.TabStop = False
        Me.PboxSelected.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 460)
        Me.Controls.Add(Me.PboxSelected)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Puzzle"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PboxSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiHowtoPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiAboutMe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fdOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsmiLevel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiLevel5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PboxSelected As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiRotate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiShowHint As System.Windows.Forms.ToolStripMenuItem

End Class
