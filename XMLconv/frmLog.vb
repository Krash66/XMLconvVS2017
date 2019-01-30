Public Class FrmLog
    Inherits FrmBlank

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
    Friend WithEvents TxtLog As System.Windows.Forms.TextBox
    Friend WithEvents CmdClearLog As System.Windows.Forms.Button
    Friend WithEvents ChkWordWrap As System.Windows.Forms.CheckBox
    Friend WithEvents SqlLog As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ODBClog As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChkEnableLogging As System.Windows.Forms.CheckBox
    Public Event OnEvent(Msg As String)

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.CmdClearLog = New System.Windows.Forms.Button()
        Me.ChkWordWrap = New System.Windows.Forms.CheckBox()
        Me.ChkEnableLogging = New System.Windows.Forms.CheckBox()
        Me.SqlLog = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ODBClog = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(696, 68)
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 511)
        Me.GroupBox1.Size = New System.Drawing.Size(698, 7)
        '
        'CmdOk
        '
        Me.CmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdOk.Location = New System.Drawing.Point(416, 535)
        Me.CmdOk.Size = New System.Drawing.Size(80, 25)
        Me.CmdOk.TabIndex = 2
        '
        'CmdCancel
        '
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdCancel.Location = New System.Drawing.Point(512, 535)
        Me.CmdCancel.Size = New System.Drawing.Size(80, 25)
        Me.CmdCancel.TabIndex = 3
        Me.CmdCancel.Visible = False
        '
        'CmdHelp
        '
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdHelp.Location = New System.Drawing.Point(608, 535)
        Me.CmdHelp.Size = New System.Drawing.Size(80, 25)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(97, 5)
        Me.Label1.Size = New System.Drawing.Size(347, 16)
        Me.Label1.Text = "Log Window"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(100, 24)
        Me.Label2.Size = New System.Drawing.Size(586, 39)
        Me.Label2.Text = "You can view detailed log of database activities and application errors. You can " &
    "also start/stop logging using this window."
        '
        'TxtLog
        '
        Me.TxtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLog.Location = New System.Drawing.Point(8, 96)
        Me.TxtLog.MaxLength = 100000
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(678, 163)
        Me.TxtLog.TabIndex = 1
        Me.TxtLog.WordWrap = False
        '
        'CmdClearLog
        '
        Me.CmdClearLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdClearLog.Location = New System.Drawing.Point(8, 534)
        Me.CmdClearLog.Name = "CmdClearLog"
        Me.CmdClearLog.Size = New System.Drawing.Size(120, 24)
        Me.CmdClearLog.TabIndex = 4
        Me.CmdClearLog.Text = "Clear Log"
        '
        'ChkWordWrap
        '
        Me.ChkWordWrap.Location = New System.Drawing.Point(8, 72)
        Me.ChkWordWrap.Name = "ChkWordWrap"
        Me.ChkWordWrap.Size = New System.Drawing.Size(104, 24)
        Me.ChkWordWrap.TabIndex = 6
        Me.ChkWordWrap.Text = "Word Wrap"
        '
        'ChkEnableLogging
        '
        Me.ChkEnableLogging.Checked = True
        Me.ChkEnableLogging.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEnableLogging.Location = New System.Drawing.Point(120, 72)
        Me.ChkEnableLogging.Name = "ChkEnableLogging"
        Me.ChkEnableLogging.Size = New System.Drawing.Size(104, 24)
        Me.ChkEnableLogging.TabIndex = 7
        Me.ChkEnableLogging.Text = "Enable Logging"
        '
        'SqlLog
        '
        Me.SqlLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SqlLog.Location = New System.Drawing.Point(8, 278)
        Me.SqlLog.Multiline = True
        Me.SqlLog.Name = "SqlLog"
        Me.SqlLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.SqlLog.Size = New System.Drawing.Size(678, 126)
        Me.SqlLog.TabIndex = 58
        Me.SqlLog.WordWrap = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(637, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "SQL Log"
        '
        'ODBClog
        '
        Me.ODBClog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ODBClog.Location = New System.Drawing.Point(8, 423)
        Me.ODBClog.Multiline = True
        Me.ODBClog.Name = "ODBClog"
        Me.ODBClog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ODBClog.Size = New System.Drawing.Size(678, 82)
        Me.ODBClog.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(636, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Error Log"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(603, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "ODBC Error Log"
        '
        'FrmLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(696, 573)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ODBClog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SqlLog)
        Me.Controls.Add(Me.ChkEnableLogging)
        Me.Controls.Add(Me.ChkWordWrap)
        Me.Controls.Add(Me.CmdClearLog)
        Me.Controls.Add(Me.TxtLog)
        Me.Name = "FrmLog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.CmdHelp, 0)
        Me.Controls.SetChildIndex(Me.TxtLog, 0)
        Me.Controls.SetChildIndex(Me.CmdClearLog, 0)
        Me.Controls.SetChildIndex(Me.ChkWordWrap, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.CmdOk, 0)
        Me.Controls.SetChildIndex(Me.CmdCancel, 0)
        Me.Controls.SetChildIndex(Me.ChkEnableLogging, 0)
        Me.Controls.SetChildIndex(Me.SqlLog, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ODBClog, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        EnableLogging = ChkEnableLogging.Checked
        AddHandler OnEvent, AddressOf OnNewEvent

    End Sub

    Public Function ShowLog() As Boolean

        Try
            If IO.File.Exists(GetAppLog() & errorTrace) Then
                TxtLog.Text = LoadTextFile(GetAppLog() & errorTrace)
            End If
            If IO.File.Exists(GetAppLog() & TraceFile) Then
                SqlLog.Text = LoadTextFile(GetAppLog() & TraceFile)
                SqlLog.ScrollToCaret()
            End If
            If IO.File.Exists(GetAppLog() & ODBCTrace) Then
                ODBClog.Text = LoadTextFile(GetAppLog() & ODBCTrace)
                ODBClog.ScrollToCaret()
            End If
        Catch ex As Exception
        End Try

        WindowState = FormWindowState.Normal
        Me.Show()

    End Function

    Private Sub OnNewEvent(ByVal Msg As String)

        TxtLog.Text = TxtLog.Text & Msg

    End Sub

    Private Sub CmdClearLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClearLog.Click

        Try
            IO.File.Delete(GetAppLog() & errorTrace)   '& "\"
            TxtLog.Text = ""
            IO.File.Delete(GetAppLog() & TraceFile)
            SqlLog.Text = ""
            IO.File.Delete(GetAppLog() & ODBCTrace)
            ODBClog.Text = ""
        Catch ex As Exception
        End Try

    End Sub

    Public Overrides Sub CmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub ChkWordWrap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkWordWrap.CheckedChanged

        TxtLog.WordWrap = ChkWordWrap.Checked
        SqlLog.WordWrap = ChkWordWrap.Checked
        ODBClog.WordWrap = ChkWordWrap.Checked

    End Sub

    Private Sub ChkEnableLogging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEnableLogging.CheckedChanged

        EnableLogging = ChkEnableLogging.Checked

    End Sub

End Class
