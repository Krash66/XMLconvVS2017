<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXMLconv
    Inherits frmBlank

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXMLconv))
        Me.gbIn = New System.Windows.Forms.GroupBox()
        Me.btnbrowseIn = New System.Windows.Forms.Button()
        Me.txtInMessage = New System.Windows.Forms.TextBox()
        Me.txtInPath = New System.Windows.Forms.TextBox()
        Me.gbXMLout = New System.Windows.Forms.GroupBox()
        Me.txtCSVout = New System.Windows.Forms.TextBox()
        Me.BtnSaveCSV = New System.Windows.Forms.Button()
        Me.txtOutPath = New System.Windows.Forms.TextBox()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.GbReplaceValue = New System.Windows.Forms.GroupBox()
        Me.TVxml = New System.Windows.Forms.TreeView()
        Me.RbAllElements = New System.Windows.Forms.RadioButton()
        Me.RbOnlyThisElement = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDTDout = New System.Windows.Forms.TextBox()
        Me.BtnSaveDTD = New System.Windows.Forms.Button()
        Me.TxtSaveDTDPath = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.gbEditElement = New System.Windows.Forms.GroupBox()
        Me.TxtElementValue = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SCElement = New System.Windows.Forms.SplitContainer()
        Me.GBAttribute = New System.Windows.Forms.GroupBox()
        Me.DGVAttrib = New System.Windows.Forms.DataGridView()
        Me.AttrName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttrValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBChildren = New System.Windows.Forms.GroupBox()
        Me.DGVElement = New System.Windows.Forms.DataGridView()
        Me.CldName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtElementName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CopyToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PasteToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.LogFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.gbIn.SuspendLayout()
        Me.gbXMLout.SuspendLayout()
        Me.GbReplaceValue.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gbEditElement.SuspendLayout()
        Me.SCElement.Panel1.SuspendLayout()
        Me.SCElement.Panel2.SuspendLayout()
        Me.SCElement.SuspendLayout()
        Me.GBAttribute.SuspendLayout()
        CType(Me.DGVAttrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBChildren.SuspendLayout()
        CType(Me.DGVElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(1200, 43)
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 515)
        Me.GroupBox1.Size = New System.Drawing.Size(1202, 7)
        '
        'cmdOk
        '
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(843, 538)
        Me.cmdOk.Size = New System.Drawing.Size(155, 24)
        Me.cmdOk.Text = "&Open Output File"
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(1014, 538)
        Me.cmdCancel.Text = "&Close"
        '
        'cmdHelp
        '
        Me.cmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Location = New System.Drawing.Point(1110, 538)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(393, 16)
        Me.Label1.Text = "XML File Tool"
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(1088, 19)
        Me.Label2.Text = "Open an XML message and convert it to an XML DTD description file, or change valu" &
    "es in any Element of the XML Structure."
        '
        'gbIn
        '
        Me.gbIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbIn.Controls.Add(Me.btnbrowseIn)
        Me.gbIn.Controls.Add(Me.txtInMessage)
        Me.gbIn.Controls.Add(Me.txtInPath)
        Me.gbIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIn.Location = New System.Drawing.Point(12, 70)
        Me.gbIn.Name = "gbIn"
        Me.gbIn.Size = New System.Drawing.Size(450, 439)
        Me.gbIn.TabIndex = 58
        Me.gbIn.TabStop = False
        Me.gbIn.Text = "XML File In"
        '
        'btnbrowseIn
        '
        Me.btnbrowseIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowseIn.Location = New System.Drawing.Point(358, 17)
        Me.btnbrowseIn.Name = "btnbrowseIn"
        Me.btnbrowseIn.Size = New System.Drawing.Size(86, 23)
        Me.btnbrowseIn.TabIndex = 2
        Me.btnbrowseIn.Text = "Input File"
        Me.btnbrowseIn.UseVisualStyleBackColor = True
        '
        'txtInMessage
        '
        Me.txtInMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInMessage.BackColor = System.Drawing.SystemColors.Window
        Me.txtInMessage.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInMessage.Location = New System.Drawing.Point(6, 45)
        Me.txtInMessage.Multiline = True
        Me.txtInMessage.Name = "txtInMessage"
        Me.txtInMessage.ReadOnly = True
        Me.txtInMessage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtInMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInMessage.Size = New System.Drawing.Size(438, 388)
        Me.txtInMessage.TabIndex = 1
        Me.txtInMessage.Text = " "
        Me.txtInMessage.WordWrap = False
        '
        'txtInPath
        '
        Me.txtInPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInPath.Location = New System.Drawing.Point(6, 19)
        Me.txtInPath.Name = "txtInPath"
        Me.txtInPath.Size = New System.Drawing.Size(346, 20)
        Me.txtInPath.TabIndex = 0
        '
        'gbXMLout
        '
        Me.gbXMLout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbXMLout.Controls.Add(Me.txtCSVout)
        Me.gbXMLout.Controls.Add(Me.BtnSaveCSV)
        Me.gbXMLout.Controls.Add(Me.txtOutPath)
        Me.gbXMLout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbXMLout.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbXMLout.Location = New System.Drawing.Point(3, 3)
        Me.gbXMLout.Name = "gbXMLout"
        Me.gbXMLout.Size = New System.Drawing.Size(426, 395)
        Me.gbXMLout.TabIndex = 59
        Me.gbXMLout.TabStop = False
        Me.gbXMLout.Text = "CSV File output"
        '
        'txtCSVout
        '
        Me.txtCSVout.AcceptsReturn = True
        Me.txtCSVout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCSVout.BackColor = System.Drawing.SystemColors.Window
        Me.txtCSVout.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSVout.Location = New System.Drawing.Point(6, 19)
        Me.txtCSVout.Multiline = True
        Me.txtCSVout.Name = "txtCSVout"
        Me.txtCSVout.ReadOnly = True
        Me.txtCSVout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCSVout.Size = New System.Drawing.Size(414, 342)
        Me.txtCSVout.TabIndex = 3
        Me.txtCSVout.WordWrap = False
        '
        'BtnSaveCSV
        '
        Me.BtnSaveCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveCSV.Location = New System.Drawing.Point(298, 367)
        Me.BtnSaveCSV.Name = "BtnSaveCSV"
        Me.BtnSaveCSV.Size = New System.Drawing.Size(59, 23)
        Me.BtnSaveCSV.TabIndex = 2
        Me.BtnSaveCSV.Text = "Save CSV"
        Me.BtnSaveCSV.UseVisualStyleBackColor = True
        '
        'txtOutPath
        '
        Me.txtOutPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutPath.Location = New System.Drawing.Point(6, 369)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(286, 20)
        Me.txtOutPath.TabIndex = 1
        '
        'OFD1
        '
        Me.OFD1.Filter = "XML Files|*.xml|All Files|*.*"
        Me.OFD1.Title = "Open XML Message"
        '
        'SFD1
        '
        Me.SFD1.Filter = "Comma Sep|*.csv|XML Files|*.xml|XML DTD Files|*.DTD|All Files|*.*"
        Me.SFD1.Title = "DTD File Save"
        '
        'btnConv
        '
        Me.btnConv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConv.Location = New System.Drawing.Point(468, 469)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(276, 40)
        Me.btnConv.TabIndex = 61
        Me.btnConv.Text = "Process Message"
        Me.btnConv.UseVisualStyleBackColor = True
        '
        'GbReplaceValue
        '
        Me.GbReplaceValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GbReplaceValue.Controls.Add(Me.TVxml)
        Me.GbReplaceValue.Controls.Add(Me.RbAllElements)
        Me.GbReplaceValue.Controls.Add(Me.RbOnlyThisElement)
        Me.GbReplaceValue.Controls.Add(Me.Label3)
        Me.GbReplaceValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbReplaceValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GbReplaceValue.Location = New System.Drawing.Point(468, 70)
        Me.GbReplaceValue.Name = "GbReplaceValue"
        Me.GbReplaceValue.Size = New System.Drawing.Size(276, 393)
        Me.GbReplaceValue.TabIndex = 64
        Me.GbReplaceValue.TabStop = False
        Me.GbReplaceValue.Text = "Replace Element Value"
        '
        'TVxml
        '
        Me.TVxml.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVxml.Location = New System.Drawing.Point(9, 36)
        Me.TVxml.Name = "TVxml"
        Me.TVxml.Size = New System.Drawing.Size(261, 298)
        Me.TVxml.TabIndex = 69
        '
        'RbAllElements
        '
        Me.RbAllElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbAllElements.AutoSize = True
        Me.RbAllElements.Location = New System.Drawing.Point(9, 367)
        Me.RbAllElements.Name = "RbAllElements"
        Me.RbAllElements.Size = New System.Drawing.Size(159, 19)
        Me.RbAllElements.TabIndex = 68
        Me.RbAllElements.Text = "All Elements like this"
        Me.RbAllElements.UseVisualStyleBackColor = True
        '
        'RbOnlyThisElement
        '
        Me.RbOnlyThisElement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbOnlyThisElement.AutoSize = True
        Me.RbOnlyThisElement.Checked = True
        Me.RbOnlyThisElement.Location = New System.Drawing.Point(9, 341)
        Me.RbOnlyThisElement.Name = "RbOnlyThisElement"
        Me.RbOnlyThisElement.Size = New System.Drawing.Size(141, 19)
        Me.RbOnlyThisElement.TabIndex = 67
        Me.RbOnlyThisElement.TabStop = True
        Me.RbOnlyThisElement.Text = "Only This Element"
        Me.RbOnlyThisElement.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Choose Element"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(750, 82)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(440, 427)
        Me.TabControl1.TabIndex = 65
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbXMLout)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(432, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CSV"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(432, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DTD"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtDTDout)
        Me.GroupBox2.Controls.Add(Me.BtnSaveDTD)
        Me.GroupBox2.Controls.Add(Me.TxtSaveDTDPath)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(426, 395)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DTD File output"
        '
        'txtDTDout
        '
        Me.txtDTDout.AcceptsReturn = True
        Me.txtDTDout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDTDout.BackColor = System.Drawing.SystemColors.Window
        Me.txtDTDout.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDTDout.Location = New System.Drawing.Point(6, 19)
        Me.txtDTDout.Multiline = True
        Me.txtDTDout.Name = "txtDTDout"
        Me.txtDTDout.ReadOnly = True
        Me.txtDTDout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDTDout.Size = New System.Drawing.Size(414, 342)
        Me.txtDTDout.TabIndex = 3
        Me.txtDTDout.WordWrap = False
        '
        'BtnSaveDTD
        '
        Me.BtnSaveDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveDTD.Location = New System.Drawing.Point(298, 367)
        Me.BtnSaveDTD.Name = "BtnSaveDTD"
        Me.BtnSaveDTD.Size = New System.Drawing.Size(122, 23)
        Me.BtnSaveDTD.TabIndex = 2
        Me.BtnSaveDTD.Text = "Save Output File"
        Me.BtnSaveDTD.UseVisualStyleBackColor = True
        '
        'TxtSaveDTDPath
        '
        Me.TxtSaveDTDPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaveDTDPath.Location = New System.Drawing.Point(6, 369)
        Me.TxtSaveDTDPath.Name = "TxtSaveDTDPath"
        Me.TxtSaveDTDPath.Size = New System.Drawing.Size(286, 20)
        Me.TxtSaveDTDPath.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.gbEditElement)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(432, 401)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Elements"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'gbEditElement
        '
        Me.gbEditElement.Controls.Add(Me.TxtElementValue)
        Me.gbEditElement.Controls.Add(Me.Label5)
        Me.gbEditElement.Controls.Add(Me.SCElement)
        Me.gbEditElement.Controls.Add(Me.TxtElementName)
        Me.gbEditElement.Controls.Add(Me.Label4)
        Me.gbEditElement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbEditElement.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbEditElement.Location = New System.Drawing.Point(3, 3)
        Me.gbEditElement.Name = "gbEditElement"
        Me.gbEditElement.Size = New System.Drawing.Size(426, 395)
        Me.gbEditElement.TabIndex = 0
        Me.gbEditElement.TabStop = False
        Me.gbEditElement.Text = "Edit XML Element"
        '
        'TxtElementValue
        '
        Me.TxtElementValue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtElementValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtElementValue.Location = New System.Drawing.Point(107, 47)
        Me.TxtElementValue.Name = "TxtElementValue"
        Me.TxtElementValue.Size = New System.Drawing.Size(313, 21)
        Me.TxtElementValue.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Element Value"
        '
        'SCElement
        '
        Me.SCElement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SCElement.Location = New System.Drawing.Point(3, 73)
        Me.SCElement.Name = "SCElement"
        '
        'SCElement.Panel1
        '
        Me.SCElement.Panel1.Controls.Add(Me.GBAttribute)
        '
        'SCElement.Panel2
        '
        Me.SCElement.Panel2.Controls.Add(Me.GBChildren)
        Me.SCElement.Size = New System.Drawing.Size(423, 319)
        Me.SCElement.SplitterDistance = 209
        Me.SCElement.TabIndex = 4
        '
        'GBAttribute
        '
        Me.GBAttribute.Controls.Add(Me.DGVAttrib)
        Me.GBAttribute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBAttribute.Location = New System.Drawing.Point(0, 0)
        Me.GBAttribute.Name = "GBAttribute"
        Me.GBAttribute.Size = New System.Drawing.Size(209, 319)
        Me.GBAttribute.TabIndex = 0
        Me.GBAttribute.TabStop = False
        Me.GBAttribute.Text = "Attributes"
        '
        'DGVAttrib
        '
        Me.DGVAttrib.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAttrib.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVAttrib.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVAttrib.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAttrib.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AttrName, Me.AttrValue})
        Me.DGVAttrib.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAttrib.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVAttrib.Location = New System.Drawing.Point(3, 16)
        Me.DGVAttrib.Name = "DGVAttrib"
        Me.DGVAttrib.RowHeadersVisible = False
        Me.DGVAttrib.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVAttrib.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue
        Me.DGVAttrib.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAttrib.Size = New System.Drawing.Size(203, 300)
        Me.DGVAttrib.TabIndex = 0
        '
        'AttrName
        '
        Me.AttrName.HeaderText = "Name"
        Me.AttrName.Name = "AttrName"
        Me.AttrName.ReadOnly = True
        '
        'AttrValue
        '
        Me.AttrValue.HeaderText = "Value"
        Me.AttrValue.Name = "AttrValue"
        '
        'GBChildren
        '
        Me.GBChildren.Controls.Add(Me.DGVElement)
        Me.GBChildren.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBChildren.Location = New System.Drawing.Point(0, 0)
        Me.GBChildren.Name = "GBChildren"
        Me.GBChildren.Size = New System.Drawing.Size(210, 319)
        Me.GBChildren.TabIndex = 3
        Me.GBChildren.TabStop = False
        Me.GBChildren.Text = "Child Elements"
        '
        'DGVElement
        '
        Me.DGVElement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVElement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVElement.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVElement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVElement.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CldName, Me.CldValue})
        Me.DGVElement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVElement.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVElement.Location = New System.Drawing.Point(3, 16)
        Me.DGVElement.Name = "DGVElement"
        Me.DGVElement.RowHeadersVisible = False
        Me.DGVElement.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DGVElement.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.Highlight
        Me.DGVElement.Size = New System.Drawing.Size(204, 300)
        Me.DGVElement.TabIndex = 0
        '
        'CldName
        '
        Me.CldName.HeaderText = "Name"
        Me.CldName.Name = "CldName"
        '
        'CldValue
        '
        Me.CldValue.HeaderText = "Value"
        Me.CldValue.Name = "CldValue"
        '
        'TxtElementName
        '
        Me.TxtElementName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtElementName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtElementName.Location = New System.Drawing.Point(107, 21)
        Me.TxtElementName.Name = "TxtElementName"
        Me.TxtElementName.Size = New System.Drawing.Size(313, 21)
        Me.TxtElementName.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Element Name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(1, 43)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(179, 24)
        Me.MenuStrip1.TabIndex = 66
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Enabled = False
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.LogFilesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.PrintToolStripButton, Me.toolStripSeparator6, Me.CutToolStripButton, Me.CopyToolStripButton, Me.PasteToolStripButton, Me.toolStripSeparator7, Me.HelpToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(191, 43)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(208, 25)
        Me.ToolStrip1.TabIndex = 67
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NewToolStripButton.Text = "&New"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), System.Drawing.Image)
        Me.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        Me.OpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenToolStripButton.Text = "&Open"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintToolStripButton.Text = "&Print"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'CutToolStripButton
        '
        Me.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), System.Drawing.Image)
        Me.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripButton.Name = "CutToolStripButton"
        Me.CutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CutToolStripButton.Text = "C&ut"
        '
        'CopyToolStripButton
        '
        Me.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), System.Drawing.Image)
        Me.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripButton.Name = "CopyToolStripButton"
        Me.CopyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CopyToolStripButton.Text = "&Copy"
        '
        'PasteToolStripButton
        '
        Me.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), System.Drawing.Image)
        Me.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripButton.Name = "PasteToolStripButton"
        Me.PasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.PasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'HelpToolStripButton
        '
        Me.HelpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), System.Drawing.Image)
        Me.HelpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpToolStripButton.Name = "HelpToolStripButton"
        Me.HelpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HelpToolStripButton.Text = "He&lp"
        '
        'LogFilesToolStripMenuItem
        '
        Me.LogFilesToolStripMenuItem.Name = "LogFilesToolStripMenuItem"
        Me.LogFilesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogFilesToolStripMenuItem.Text = "Log Files"
        '
        'frmXMLconv
        '
        Me.ClientSize = New System.Drawing.Size(1200, 577)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GbReplaceValue)
        Me.Controls.Add(Me.gbIn)
        Me.Controls.Add(Me.btnConv)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmXMLconv"
        Me.Text = "XML Message Converter"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.btnConv, 0)
        Me.Controls.SetChildIndex(Me.gbIn, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdOk, 0)
        Me.Controls.SetChildIndex(Me.cmdCancel, 0)
        Me.Controls.SetChildIndex(Me.cmdHelp, 0)
        Me.Controls.SetChildIndex(Me.GbReplaceValue, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        Me.Panel1.ResumeLayout(False)
        Me.gbIn.ResumeLayout(False)
        Me.gbIn.PerformLayout()
        Me.gbXMLout.ResumeLayout(False)
        Me.gbXMLout.PerformLayout()
        Me.GbReplaceValue.ResumeLayout(False)
        Me.GbReplaceValue.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.gbEditElement.ResumeLayout(False)
        Me.gbEditElement.PerformLayout()
        Me.SCElement.Panel1.ResumeLayout(False)
        Me.SCElement.Panel2.ResumeLayout(False)
        Me.SCElement.ResumeLayout(False)
        Me.GBAttribute.ResumeLayout(False)
        CType(Me.DGVAttrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBChildren.ResumeLayout(False)
        CType(Me.DGVElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbIn As System.Windows.Forms.GroupBox
    Friend WithEvents txtInMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtInPath As System.Windows.Forms.TextBox
    Friend WithEvents gbXMLout As System.Windows.Forms.GroupBox
    Friend WithEvents OFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnbrowseIn As System.Windows.Forms.Button
    Friend WithEvents btnConv As System.Windows.Forms.Button
    Friend WithEvents txtCSVout As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaveCSV As System.Windows.Forms.Button
    Friend WithEvents txtOutPath As System.Windows.Forms.TextBox
    Friend WithEvents GbReplaceValue As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RbAllElements As RadioButton
    Friend WithEvents RbOnlyThisElement As RadioButton
    Friend WithEvents TVxml As TreeView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDTDout As TextBox
    Friend WithEvents BtnSaveDTD As Button
    Friend WithEvents TxtSaveDTDPath As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents gbEditElement As GroupBox
    Friend WithEvents TxtElementValue As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SCElement As SplitContainer
    Friend WithEvents GBAttribute As GroupBox
    Friend WithEvents DGVAttrib As DataGridView
    Friend WithEvents GBChildren As GroupBox
    Friend WithEvents DGVElement As DataGridView
    Friend WithEvents TxtElementName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AttrName As DataGridViewTextBoxColumn
    Friend WithEvents AttrValue As DataGridViewTextBoxColumn
    Friend WithEvents CldName As DataGridViewTextBoxColumn
    Friend WithEvents CldValue As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator6 As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator7 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton
    Friend WithEvents LogFilesToolStripMenuItem As ToolStripMenuItem
End Class
