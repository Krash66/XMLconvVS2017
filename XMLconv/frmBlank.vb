Public Class FrmBlank
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents CmdOk As System.Windows.Forms.Button
    Public WithEvents CmdCancel As System.Windows.Forms.Button
    Public WithEvents CmdHelp As System.Windows.Forms.Button
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBlank))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmdHelp = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(516, 7)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdOk.Location = New System.Drawing.Point(232, 296)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(80, 24)
        Me.CmdOk.TabIndex = 1
        Me.CmdOk.Text = "&OK"
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(328, 296)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(80, 24)
        Me.CmdCancel.TabIndex = 56
        Me.CmdCancel.Text = "&Cancel"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "<Enter your long description here>"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(97, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "<Short Description>"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 44)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Global.XMLconv.My.Resources.Resources.Ball
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Global.XMLconv.My.Resources.Resources.Ball
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CmdHelp
        '
        Me.CmdHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdHelp.CausesValidation = False
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdHelp.Location = New System.Drawing.Point(424, 296)
        Me.CmdHelp.Name = "CmdHelp"
        Me.CmdHelp.Size = New System.Drawing.Size(80, 24)
        Me.CmdHelp.TabIndex = 57
        Me.CmdHelp.Text = "&Help"
        '
        'FrmBlank
        '
        Me.AcceptButton = Me.CmdOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.CmdCancel
        Me.ClientSize = New System.Drawing.Size(514, 335)
        Me.Controls.Add(Me.CmdHelp)
        Me.Controls.Add(Me.CmdCancel)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmBlank"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overridable Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        'Me.Close()
    End Sub

    Public Overridable Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click

    End Sub

    Public Overridable Sub MyForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Select Case e.KeyCode
        '    Case Keys.Escape
        '        cmdCancel_Click(sender, e)
        '    Case Keys.Enter
        '        cmdOk_Click(sender, e)
        '    Case Keys.F1
        '        cmdHelp_Click(sender, e)
        'End Select
    End Sub

    Public Overridable Sub CmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHelp.Click

    End Sub

    Private Sub FrmBlank_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '#If CONFIG = "ETI" Then
        '        Me.Text = "Design Studio" ' V3 " & Application.ProductVersion
        '        Me.PictureBox1.ImageLocation = "C:\Documents and Settings\tkarasc\My Documents\Visual Studio 2005\Projects\sqdstudio\images\ETI_Logo_Installation_Graphic\ETI-installer-right.bmp"
        '#Else
        '        Me.Text = "Design Studio V3 " '& Application.ProductVersion
        '        Me.PictureBox1.ImageLocation = "C:\Documents and Settings\tkarasc\My Documents\Visual Studio 2005\Projects\sqdstudio\images\FormTop\sq_skyblue.jpg"
        'Me.Icon = Drawing.Icon.ExtractAssociatedIcon("C:\Documents and Settings\tkarasc\My Documents\Visual Studio 2005\Projects\sqdstudio\images\icons\SQ.ico")
        '#End If

    End Sub


End Class
