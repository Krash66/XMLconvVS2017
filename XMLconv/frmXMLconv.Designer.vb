﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXMLconv
    Inherits FrmBlank

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmXMLconv))
        Me.gbIn = New System.Windows.Forms.GroupBox()
        Me.btnbrowseIn = New System.Windows.Forms.Button()
        Me.txtInMessage = New System.Windows.Forms.TextBox()
        Me.txtInPath = New System.Windows.Forms.TextBox()
        Me.gbXMLout = New System.Windows.Forms.GroupBox()
        Me.BtnOpenCSV = New System.Windows.Forms.Button()
        Me.TxtCSVout = New System.Windows.Forms.TextBox()
        Me.BtnSaveCSV = New System.Windows.Forms.Button()
        Me.txtOutPath = New System.Windows.Forms.TextBox()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnCreateDTD = New System.Windows.Forms.Button()
        Me.GbChooseEleCSV = New System.Windows.Forms.GroupBox()
        Me.TVxml = New System.Windows.Forms.TreeView()
        Me.RbAllElements = New System.Windows.Forms.RadioButton()
        Me.RbOnlyThisElement = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnOpneDTD = New System.Windows.Forms.Button()
        Me.txtDTDout = New System.Windows.Forms.TextBox()
        Me.BtnSaveDTD = New System.Windows.Forms.Button()
        Me.TxtSaveDTDPath = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GBOutXML = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnSaveXML = New System.Windows.Forms.Button()
        Me.BtnOpenXML = New System.Windows.Forms.Button()
        Me.TxtOutXMLPath = New System.Windows.Forms.TextBox()
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
        Me.LogFilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnCreateCSV = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.BtnReplace = New System.Windows.Forms.Button()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbIn.SuspendLayout()
        Me.gbXMLout.SuspendLayout()
        Me.GbChooseEleCSV.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gbEditElement.SuspendLayout()
        Me.SCElement.Panel1.SuspendLayout()
        Me.SCElement.Panel2.SuspendLayout()
        Me.SCElement.SuspendLayout()
        Me.GBAttribute.SuspendLayout()
        CType(Me.DGVAttrib, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBChildren.SuspendLayout()
        CType(Me.DGVElement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GBOutXML.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
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
        'CmdOk
        '
        Me.CmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOk.Location = New System.Drawing.Point(893, 538)
        Me.CmdOk.Size = New System.Drawing.Size(115, 24)
        Me.CmdOk.Text = "&Open"
        '
        'CmdCancel
        '
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(1014, 538)
        Me.CmdCancel.Text = "&Close"
        '
        'CmdHelp
        '
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdHelp.Location = New System.Drawing.Point(1110, 538)
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
        Me.gbIn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbIn.Controls.Add(Me.btnbrowseIn)
        Me.gbIn.Controls.Add(Me.txtInMessage)
        Me.gbIn.Controls.Add(Me.txtInPath)
        Me.gbIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIn.Location = New System.Drawing.Point(0, 3)
        Me.gbIn.Name = "gbIn"
        Me.gbIn.Size = New System.Drawing.Size(396, 389)
        Me.gbIn.TabIndex = 58
        Me.gbIn.TabStop = False
        Me.gbIn.Text = "XML File In"
        '
        'btnbrowseIn
        '
        Me.btnbrowseIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowseIn.Location = New System.Drawing.Point(304, 17)
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
        Me.txtInMessage.Size = New System.Drawing.Size(384, 334)
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
        Me.txtInPath.Size = New System.Drawing.Size(292, 20)
        Me.txtInPath.TabIndex = 0
        '
        'gbXMLout
        '
        Me.gbXMLout.Controls.Add(Me.BtnOpenCSV)
        Me.gbXMLout.Controls.Add(Me.TxtCSVout)
        Me.gbXMLout.Controls.Add(Me.BtnSaveCSV)
        Me.gbXMLout.Controls.Add(Me.txtOutPath)
        Me.gbXMLout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbXMLout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbXMLout.ForeColor = System.Drawing.SystemColors.Highlight
        Me.gbXMLout.Location = New System.Drawing.Point(0, 0)
        Me.gbXMLout.Name = "gbXMLout"
        Me.gbXMLout.Size = New System.Drawing.Size(516, 406)
        Me.gbXMLout.TabIndex = 59
        Me.gbXMLout.TabStop = False
        Me.gbXMLout.Text = "CSV File output"
        '
        'BtnOpenCSV
        '
        Me.BtnOpenCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenCSV.Location = New System.Drawing.Point(453, 378)
        Me.BtnOpenCSV.Name = "BtnOpenCSV"
        Me.BtnOpenCSV.Size = New System.Drawing.Size(56, 23)
        Me.BtnOpenCSV.TabIndex = 4
        Me.BtnOpenCSV.Text = "Open"
        Me.BtnOpenCSV.UseVisualStyleBackColor = True
        '
        'TxtCSVout
        '
        Me.TxtCSVout.AcceptsReturn = True
        Me.TxtCSVout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCSVout.BackColor = System.Drawing.SystemColors.Window
        Me.TxtCSVout.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCSVout.Location = New System.Drawing.Point(6, 19)
        Me.TxtCSVout.Multiline = True
        Me.TxtCSVout.Name = "TxtCSVout"
        Me.TxtCSVout.ReadOnly = True
        Me.TxtCSVout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtCSVout.Size = New System.Drawing.Size(504, 353)
        Me.TxtCSVout.TabIndex = 3
        Me.TxtCSVout.WordWrap = False
        '
        'BtnSaveCSV
        '
        Me.BtnSaveCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveCSV.Location = New System.Drawing.Point(388, 378)
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
        Me.txtOutPath.Location = New System.Drawing.Point(6, 380)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(376, 20)
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
        'BtnCreateDTD
        '
        Me.BtnCreateDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateDTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateDTD.Location = New System.Drawing.Point(80, 398)
        Me.BtnCreateDTD.Name = "BtnCreateDTD"
        Me.BtnCreateDTD.Size = New System.Drawing.Size(76, 40)
        Me.BtnCreateDTD.TabIndex = 61
        Me.BtnCreateDTD.Text = "Create DTD"
        Me.BtnCreateDTD.UseVisualStyleBackColor = True
        '
        'GbChooseEleCSV
        '
        Me.GbChooseEleCSV.Controls.Add(Me.TVxml)
        Me.GbChooseEleCSV.Controls.Add(Me.RbAllElements)
        Me.GbChooseEleCSV.Controls.Add(Me.RbOnlyThisElement)
        Me.GbChooseEleCSV.Controls.Add(Me.Label3)
        Me.GbChooseEleCSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbChooseEleCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbChooseEleCSV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GbChooseEleCSV.Location = New System.Drawing.Point(0, 0)
        Me.GbChooseEleCSV.Name = "GbChooseEleCSV"
        Me.GbChooseEleCSV.Size = New System.Drawing.Size(260, 406)
        Me.GbChooseEleCSV.TabIndex = 64
        Me.GbChooseEleCSV.TabStop = False
        Me.GbChooseEleCSV.Text = "Choose Output Values"
        '
        'TVxml
        '
        Me.TVxml.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVxml.Location = New System.Drawing.Point(9, 36)
        Me.TVxml.Name = "TVxml"
        Me.TVxml.Size = New System.Drawing.Size(245, 311)
        Me.TVxml.TabIndex = 69
        '
        'RbAllElements
        '
        Me.RbAllElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbAllElements.AutoSize = True
        Me.RbAllElements.Location = New System.Drawing.Point(9, 380)
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
        Me.RbOnlyThisElement.Location = New System.Drawing.Point(9, 354)
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
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(794, 438)
        Me.TabControl1.TabIndex = 65
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(786, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CSV"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GbChooseEleCSV)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.gbXMLout)
        Me.SplitContainer2.Size = New System.Drawing.Size(780, 406)
        Me.SplitContainer2.SplitterDistance = 260
        Me.SplitContainer2.TabIndex = 65
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(786, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DTD"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(780, 406)
        Me.SplitContainer3.SplitterDistance = 260
        Me.SplitContainer3.TabIndex = 61
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TreeView1)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(260, 406)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Replace Element Value"
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(9, 36)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(245, 311)
        Me.TreeView1.TabIndex = 69
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 380)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(159, 19)
        Me.RadioButton1.TabIndex = 68
        Me.RadioButton1.Text = "All Elements like this"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(9, 354)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(141, 19)
        Me.RadioButton2.TabIndex = 67
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Only This Element"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Choose Element"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnOpneDTD)
        Me.GroupBox2.Controls.Add(Me.txtDTDout)
        Me.GroupBox2.Controls.Add(Me.BtnSaveDTD)
        Me.GroupBox2.Controls.Add(Me.TxtSaveDTDPath)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 406)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DTD File output"
        '
        'BtnOpneDTD
        '
        Me.BtnOpneDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpneDTD.Location = New System.Drawing.Point(448, 378)
        Me.BtnOpneDTD.Name = "BtnOpneDTD"
        Me.BtnOpneDTD.Size = New System.Drawing.Size(61, 23)
        Me.BtnOpneDTD.TabIndex = 4
        Me.BtnOpneDTD.Text = "Open"
        Me.BtnOpneDTD.UseVisualStyleBackColor = True
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
        Me.txtDTDout.Size = New System.Drawing.Size(504, 353)
        Me.txtDTDout.TabIndex = 3
        Me.txtDTDout.WordWrap = False
        '
        'BtnSaveDTD
        '
        Me.BtnSaveDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveDTD.Location = New System.Drawing.Point(388, 378)
        Me.BtnSaveDTD.Name = "BtnSaveDTD"
        Me.BtnSaveDTD.Size = New System.Drawing.Size(54, 23)
        Me.BtnSaveDTD.TabIndex = 2
        Me.BtnSaveDTD.Text = "Save"
        Me.BtnSaveDTD.UseVisualStyleBackColor = True
        '
        'TxtSaveDTDPath
        '
        Me.TxtSaveDTDPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaveDTDPath.Location = New System.Drawing.Point(6, 380)
        Me.TxtSaveDTDPath.Name = "TxtSaveDTDPath"
        Me.TxtSaveDTDPath.Size = New System.Drawing.Size(376, 20)
        Me.TxtSaveDTDPath.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SplitContainer4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(786, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Elements"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.GroupBox4)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.gbEditElement)
        Me.SplitContainer4.Size = New System.Drawing.Size(780, 406)
        Me.SplitContainer4.SplitterDistance = 260
        Me.SplitContainer4.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TreeView2)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(260, 406)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Replace Element Value"
        '
        'TreeView2
        '
        Me.TreeView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView2.Location = New System.Drawing.Point(9, 36)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(245, 311)
        Me.TreeView2.TabIndex = 69
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(9, 380)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(159, 19)
        Me.RadioButton3.TabIndex = 68
        Me.RadioButton3.Text = "All Elements like this"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(9, 354)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(141, 19)
        Me.RadioButton4.TabIndex = 67
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Only This Element"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 15)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Choose Element"
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
        Me.gbEditElement.Location = New System.Drawing.Point(0, 0)
        Me.gbEditElement.Name = "gbEditElement"
        Me.gbEditElement.Size = New System.Drawing.Size(516, 406)
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
        Me.TxtElementValue.Size = New System.Drawing.Size(403, 21)
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
        Me.SCElement.Size = New System.Drawing.Size(513, 330)
        Me.SCElement.SplitterDistance = 253
        Me.SCElement.TabIndex = 4
        '
        'GBAttribute
        '
        Me.GBAttribute.Controls.Add(Me.DGVAttrib)
        Me.GBAttribute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBAttribute.Location = New System.Drawing.Point(0, 0)
        Me.GBAttribute.Name = "GBAttribute"
        Me.GBAttribute.Size = New System.Drawing.Size(253, 330)
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
        Me.DGVAttrib.Size = New System.Drawing.Size(247, 311)
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
        Me.GBChildren.Size = New System.Drawing.Size(256, 330)
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
        Me.DGVElement.Size = New System.Drawing.Size(250, 311)
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
        Me.TxtElementName.Size = New System.Drawing.Size(403, 21)
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.SplitContainer5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(786, 412)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "XML"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GBOutXML
        '
        Me.GBOutXML.Controls.Add(Me.TextBox1)
        Me.GBOutXML.Controls.Add(Me.BtnSaveXML)
        Me.GBOutXML.Controls.Add(Me.TxtOutXMLPath)
        Me.GBOutXML.Controls.Add(Me.BtnOpenXML)
        Me.GBOutXML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBOutXML.Location = New System.Drawing.Point(0, 0)
        Me.GBOutXML.Name = "GBOutXML"
        Me.GBOutXML.Size = New System.Drawing.Size(517, 406)
        Me.GBOutXML.TabIndex = 4
        Me.GBOutXML.TabStop = False
        Me.GBOutXML.Text = "XML Output File"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(6, 18)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(505, 353)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.WordWrap = False
        '
        'BtnSaveXML
        '
        Me.BtnSaveXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveXML.Location = New System.Drawing.Point(355, 377)
        Me.BtnSaveXML.Name = "BtnSaveXML"
        Me.BtnSaveXML.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveXML.TabIndex = 3
        Me.BtnSaveXML.Text = "Save"
        Me.BtnSaveXML.UseVisualStyleBackColor = True
        '
        'BtnOpenXML
        '
        Me.BtnOpenXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenXML.Location = New System.Drawing.Point(436, 377)
        Me.BtnOpenXML.Name = "BtnOpenXML"
        Me.BtnOpenXML.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpenXML.TabIndex = 2
        Me.BtnOpenXML.Text = "Open"
        Me.BtnOpenXML.UseVisualStyleBackColor = True
        '
        'TxtOutXMLPath
        '
        Me.TxtOutXMLPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutXMLPath.Location = New System.Drawing.Point(6, 379)
        Me.TxtOutXMLPath.Name = "TxtOutXMLPath"
        Me.TxtOutXMLPath.Size = New System.Drawing.Size(343, 20)
        Me.TxtOutXMLPath.TabIndex = 1
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
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
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
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
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
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'LogFilesToolStripMenuItem
        '
        Me.LogFilesToolStripMenuItem.Name = "LogFilesToolStripMenuItem"
        Me.LogFilesToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.LogFilesToolStripMenuItem.Text = "Log Files"
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
        'BtnCreateCSV
        '
        Me.BtnCreateCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateCSV.Location = New System.Drawing.Point(6, 398)
        Me.BtnCreateCSV.Name = "BtnCreateCSV"
        Me.BtnCreateCSV.Size = New System.Drawing.Size(68, 40)
        Me.BtnCreateCSV.TabIndex = 68
        Me.BtnCreateCSV.Text = "Create CSV"
        Me.BtnCreateCSV.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnReplace)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbIn)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnCreateCSV)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BtnCreateDTD)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1197, 438)
        Me.SplitContainer1.SplitterDistance = 399
        Me.SplitContainer1.TabIndex = 69
        '
        'BtnReplace
        '
        Me.BtnReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReplace.Location = New System.Drawing.Point(162, 398)
        Me.BtnReplace.Name = "BtnReplace"
        Me.BtnReplace.Size = New System.Drawing.Size(89, 40)
        Me.BtnReplace.TabIndex = 69
        Me.BtnReplace.Text = "Replace and create XML"
        Me.BtnReplace.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.GroupBox5)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.GBOutXML)
        Me.SplitContainer5.Size = New System.Drawing.Size(780, 406)
        Me.SplitContainer5.SplitterDistance = 259
        Me.SplitContainer5.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TreeView3)
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(259, 406)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Replace Element Value"
        '
        'TreeView3
        '
        Me.TreeView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView3.Location = New System.Drawing.Point(9, 36)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.Size = New System.Drawing.Size(244, 311)
        Me.TreeView3.TabIndex = 69
        '
        'RadioButton5
        '
        Me.RadioButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(9, 380)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(159, 19)
        Me.RadioButton5.TabIndex = 68
        Me.RadioButton5.Text = "All Elements like this"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(9, 354)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(141, 19)
        Me.RadioButton6.TabIndex = 67
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Only This Element"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 15)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Choose Element"
        '
        'FrmXMLconv
        '
        Me.ClientSize = New System.Drawing.Size(1200, 577)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmXMLconv"
        Me.Text = "XML Message Converter"
        Me.Controls.SetChildIndex(Me.MenuStrip1, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.CmdOk, 0)
        Me.Controls.SetChildIndex(Me.CmdCancel, 0)
        Me.Controls.SetChildIndex(Me.CmdHelp, 0)
        Me.Panel1.ResumeLayout(False)
        Me.gbIn.ResumeLayout(False)
        Me.gbIn.PerformLayout()
        Me.gbXMLout.ResumeLayout(False)
        Me.gbXMLout.PerformLayout()
        Me.GbChooseEleCSV.ResumeLayout(False)
        Me.GbChooseEleCSV.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gbEditElement.ResumeLayout(False)
        Me.gbEditElement.PerformLayout()
        Me.SCElement.Panel1.ResumeLayout(False)
        Me.SCElement.Panel2.ResumeLayout(False)
        Me.SCElement.ResumeLayout(False)
        Me.GBAttribute.ResumeLayout(False)
        CType(Me.DGVAttrib, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBChildren.ResumeLayout(False)
        CType(Me.DGVElement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GBOutXML.ResumeLayout(False)
        Me.GBOutXML.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
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
    Friend WithEvents BtnCreateDTD As System.Windows.Forms.Button
    Friend WithEvents TxtCSVout As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaveCSV As System.Windows.Forms.Button
    Friend WithEvents txtOutPath As System.Windows.Forms.TextBox
    Friend WithEvents GbChooseEleCSV As GroupBox
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
    Friend WithEvents LogFilesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnCreateCSV As Button
    Friend WithEvents BtnOpenCSV As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnReplace As Button
    Friend WithEvents BtnOpneDTD As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GBOutXML As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnSaveXML As Button
    Friend WithEvents BtnOpenXML As Button
    Friend WithEvents TxtOutXMLPath As TextBox
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TreeView3 As TreeView
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Label8 As Label
End Class
