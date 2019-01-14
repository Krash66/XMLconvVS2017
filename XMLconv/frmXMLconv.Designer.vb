<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TVcsv = New System.Windows.Forms.TreeView()
        Me.RbAllElements = New System.Windows.Forms.RadioButton()
        Me.RbOnlyThisElement = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TVelement = New System.Windows.Forms.TreeView()
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TVdtd = New System.Windows.Forms.TreeView()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnOpneDTD = New System.Windows.Forms.Button()
        Me.txtDTDout = New System.Windows.Forms.TextBox()
        Me.BtnSaveDTD = New System.Windows.Forms.Button()
        Me.TxtSaveDTDPath = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TVxmlOut = New System.Windows.Forms.TreeView()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GBOutXML = New System.Windows.Forms.GroupBox()
        Me.TxtXMLOut = New System.Windows.Forms.TextBox()
        Me.BtnSaveXML = New System.Windows.Forms.Button()
        Me.TxtOutXMLPath = New System.Windows.Forms.TextBox()
        Me.BtnOpenXML = New System.Windows.Forms.Button()
        Me.BtnCreateCSV = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GBframe1 = New System.Windows.Forms.GroupBox()
        Me.BtnReplace = New System.Windows.Forms.Button()
        Me.GBframe2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.gbIn.SuspendLayout()
        Me.gbXMLout.SuspendLayout()
        Me.GbChooseEleCSV.SuspendLayout()
        Me.TabControl1.SuspendLayout()
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
        Me.TabPage4.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GBOutXML.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GBframe1.SuspendLayout()
        Me.GBframe2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(1134, 43)
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(1, 515)
        Me.GroupBox1.Size = New System.Drawing.Size(1136, 7)
        '
        'CmdOk
        '
        Me.CmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOk.Location = New System.Drawing.Point(827, 538)
        Me.CmdOk.Size = New System.Drawing.Size(115, 24)
        Me.CmdOk.Text = "&Open"
        '
        'CmdCancel
        '
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(948, 538)
        Me.CmdCancel.Text = "&Close"
        '
        'CmdHelp
        '
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdHelp.Location = New System.Drawing.Point(1044, 538)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(393, 16)
        Me.Label1.Text = "XML File Tool"
        '
        'Label2
        '
        Me.Label2.Size = New System.Drawing.Size(1022, 19)
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
        Me.gbIn.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.gbIn.Location = New System.Drawing.Point(3, 16)
        Me.gbIn.Name = "gbIn"
        Me.gbIn.Size = New System.Drawing.Size(368, 394)
        Me.gbIn.TabIndex = 58
        Me.gbIn.TabStop = False
        Me.gbIn.Text = "XML File In"
        '
        'btnbrowseIn
        '
        Me.btnbrowseIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowseIn.Location = New System.Drawing.Point(276, 17)
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
        Me.txtInMessage.Size = New System.Drawing.Size(356, 339)
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
        Me.txtInPath.Size = New System.Drawing.Size(264, 20)
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
        Me.gbXMLout.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.gbXMLout.Location = New System.Drawing.Point(0, 0)
        Me.gbXMLout.Name = "gbXMLout"
        Me.gbXMLout.Size = New System.Drawing.Size(480, 409)
        Me.gbXMLout.TabIndex = 59
        Me.gbXMLout.TabStop = False
        Me.gbXMLout.Text = "CSV File output"
        '
        'BtnOpenCSV
        '
        Me.BtnOpenCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenCSV.Location = New System.Drawing.Point(417, 381)
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
        Me.TxtCSVout.Size = New System.Drawing.Size(468, 356)
        Me.TxtCSVout.TabIndex = 3
        Me.TxtCSVout.WordWrap = False
        '
        'BtnSaveCSV
        '
        Me.BtnSaveCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveCSV.Location = New System.Drawing.Point(352, 381)
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
        Me.txtOutPath.Location = New System.Drawing.Point(6, 383)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(340, 20)
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
        Me.BtnCreateDTD.Location = New System.Drawing.Point(80, 416)
        Me.BtnCreateDTD.Name = "BtnCreateDTD"
        Me.BtnCreateDTD.Size = New System.Drawing.Size(68, 40)
        Me.BtnCreateDTD.TabIndex = 61
        Me.BtnCreateDTD.Text = "Create DTD"
        Me.BtnCreateDTD.UseVisualStyleBackColor = True
        '
        'GbChooseEleCSV
        '
        Me.GbChooseEleCSV.Controls.Add(Me.TVcsv)
        Me.GbChooseEleCSV.Controls.Add(Me.RbAllElements)
        Me.GbChooseEleCSV.Controls.Add(Me.RbOnlyThisElement)
        Me.GbChooseEleCSV.Controls.Add(Me.Label3)
        Me.GbChooseEleCSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbChooseEleCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbChooseEleCSV.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GbChooseEleCSV.Location = New System.Drawing.Point(0, 0)
        Me.GbChooseEleCSV.Name = "GbChooseEleCSV"
        Me.GbChooseEleCSV.Size = New System.Drawing.Size(242, 409)
        Me.GbChooseEleCSV.TabIndex = 64
        Me.GbChooseEleCSV.TabStop = False
        Me.GbChooseEleCSV.Text = "Choose Output Values"
        '
        'TVcsv
        '
        Me.TVcsv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVcsv.Location = New System.Drawing.Point(9, 36)
        Me.TVcsv.Name = "TVcsv"
        Me.TVcsv.Size = New System.Drawing.Size(227, 314)
        Me.TVcsv.TabIndex = 69
        '
        'RbAllElements
        '
        Me.RbAllElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbAllElements.AutoSize = True
        Me.RbAllElements.Location = New System.Drawing.Point(9, 383)
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
        Me.RbOnlyThisElement.Location = New System.Drawing.Point(9, 357)
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
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(3, 16)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(740, 444)
        Me.TabControl1.TabIndex = 65
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage3.Controls.Add(Me.SplitContainer4)
        Me.TabPage3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(732, 415)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Elements"
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
        Me.SplitContainer4.Size = New System.Drawing.Size(726, 409)
        Me.SplitContainer4.SplitterDistance = 242
        Me.SplitContainer4.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TVelement)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(242, 409)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Replace Element Value"
        '
        'TVelement
        '
        Me.TVelement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVelement.Location = New System.Drawing.Point(9, 36)
        Me.TVelement.Name = "TVelement"
        Me.TVelement.Size = New System.Drawing.Size(227, 314)
        Me.TVelement.TabIndex = 69
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(9, 383)
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
        Me.RadioButton4.Location = New System.Drawing.Point(9, 357)
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
        Me.gbEditElement.Size = New System.Drawing.Size(480, 409)
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
        Me.TxtElementValue.Size = New System.Drawing.Size(367, 21)
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
        Me.SCElement.Size = New System.Drawing.Size(477, 333)
        Me.SCElement.SplitterDistance = 235
        Me.SCElement.TabIndex = 4
        '
        'GBAttribute
        '
        Me.GBAttribute.Controls.Add(Me.DGVAttrib)
        Me.GBAttribute.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBAttribute.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GBAttribute.Location = New System.Drawing.Point(0, 0)
        Me.GBAttribute.Name = "GBAttribute"
        Me.GBAttribute.Size = New System.Drawing.Size(235, 333)
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
        Me.DGVAttrib.Size = New System.Drawing.Size(229, 314)
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
        Me.GBChildren.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GBChildren.Location = New System.Drawing.Point(0, 0)
        Me.GBChildren.Name = "GBChildren"
        Me.GBChildren.Size = New System.Drawing.Size(238, 333)
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
        Me.DGVElement.Size = New System.Drawing.Size(232, 314)
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
        Me.TxtElementName.Size = New System.Drawing.Size(367, 21)
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
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(732, 415)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CSV"
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
        Me.SplitContainer2.Size = New System.Drawing.Size(726, 409)
        Me.SplitContainer2.SplitterDistance = 242
        Me.SplitContainer2.TabIndex = 65
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage2.Controls.Add(Me.SplitContainer3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(732, 415)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DTD"
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
        Me.SplitContainer3.Size = New System.Drawing.Size(726, 409)
        Me.SplitContainer3.SplitterDistance = 242
        Me.SplitContainer3.TabIndex = 61
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TVdtd)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 409)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Replace Element Value"
        '
        'TVdtd
        '
        Me.TVdtd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVdtd.Location = New System.Drawing.Point(9, 36)
        Me.TVdtd.Name = "TVdtd"
        Me.TVdtd.Size = New System.Drawing.Size(227, 314)
        Me.TVdtd.TabIndex = 69
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(9, 383)
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
        Me.RadioButton2.Location = New System.Drawing.Point(9, 357)
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
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 409)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DTD File output"
        '
        'BtnOpneDTD
        '
        Me.BtnOpneDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpneDTD.Location = New System.Drawing.Point(412, 381)
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
        Me.txtDTDout.Size = New System.Drawing.Size(468, 356)
        Me.txtDTDout.TabIndex = 3
        Me.txtDTDout.WordWrap = False
        '
        'BtnSaveDTD
        '
        Me.BtnSaveDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveDTD.Location = New System.Drawing.Point(352, 381)
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
        Me.TxtSaveDTDPath.Location = New System.Drawing.Point(6, 383)
        Me.TxtSaveDTDPath.Name = "TxtSaveDTDPath"
        Me.TxtSaveDTDPath.Size = New System.Drawing.Size(340, 20)
        Me.TxtSaveDTDPath.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage4.Controls.Add(Me.SplitContainer5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(732, 415)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "XML"
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
        Me.SplitContainer5.Size = New System.Drawing.Size(726, 409)
        Me.SplitContainer5.SplitterDistance = 241
        Me.SplitContainer5.TabIndex = 5
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TVxmlOut)
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(241, 409)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Replace Element Value"
        '
        'TVxmlOut
        '
        Me.TVxmlOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVxmlOut.Location = New System.Drawing.Point(9, 36)
        Me.TVxmlOut.Name = "TVxmlOut"
        Me.TVxmlOut.Size = New System.Drawing.Size(226, 314)
        Me.TVxmlOut.TabIndex = 69
        '
        'RadioButton5
        '
        Me.RadioButton5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(9, 383)
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
        Me.RadioButton6.Location = New System.Drawing.Point(9, 357)
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
        'GBOutXML
        '
        Me.GBOutXML.Controls.Add(Me.TxtXMLOut)
        Me.GBOutXML.Controls.Add(Me.BtnSaveXML)
        Me.GBOutXML.Controls.Add(Me.TxtOutXMLPath)
        Me.GBOutXML.Controls.Add(Me.BtnOpenXML)
        Me.GBOutXML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBOutXML.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GBOutXML.Location = New System.Drawing.Point(0, 0)
        Me.GBOutXML.Name = "GBOutXML"
        Me.GBOutXML.Size = New System.Drawing.Size(481, 409)
        Me.GBOutXML.TabIndex = 4
        Me.GBOutXML.TabStop = False
        Me.GBOutXML.Text = "XML Output File"
        '
        'TxtXMLOut
        '
        Me.TxtXMLOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtXMLOut.Location = New System.Drawing.Point(6, 18)
        Me.TxtXMLOut.Multiline = True
        Me.TxtXMLOut.Name = "TxtXMLOut"
        Me.TxtXMLOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtXMLOut.Size = New System.Drawing.Size(469, 356)
        Me.TxtXMLOut.TabIndex = 0
        Me.TxtXMLOut.WordWrap = False
        '
        'BtnSaveXML
        '
        Me.BtnSaveXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveXML.Location = New System.Drawing.Point(319, 380)
        Me.BtnSaveXML.Name = "BtnSaveXML"
        Me.BtnSaveXML.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveXML.TabIndex = 3
        Me.BtnSaveXML.Text = "Save"
        Me.BtnSaveXML.UseVisualStyleBackColor = True
        '
        'TxtOutXMLPath
        '
        Me.TxtOutXMLPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutXMLPath.Location = New System.Drawing.Point(6, 382)
        Me.TxtOutXMLPath.Name = "TxtOutXMLPath"
        Me.TxtOutXMLPath.Size = New System.Drawing.Size(307, 20)
        Me.TxtOutXMLPath.TabIndex = 1
        '
        'BtnOpenXML
        '
        Me.BtnOpenXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenXML.Location = New System.Drawing.Point(400, 380)
        Me.BtnOpenXML.Name = "BtnOpenXML"
        Me.BtnOpenXML.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpenXML.TabIndex = 2
        Me.BtnOpenXML.Text = "Open"
        Me.BtnOpenXML.UseVisualStyleBackColor = True
        '
        'BtnCreateCSV
        '
        Me.BtnCreateCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateCSV.Location = New System.Drawing.Point(6, 416)
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
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 46)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GBframe1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GBframe2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1131, 463)
        Me.SplitContainer1.SplitterDistance = 377
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 69
        '
        'GBframe1
        '
        Me.GBframe1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GBframe1.Controls.Add(Me.gbIn)
        Me.GBframe1.Controls.Add(Me.BtnReplace)
        Me.GBframe1.Controls.Add(Me.BtnCreateCSV)
        Me.GBframe1.Controls.Add(Me.BtnCreateDTD)
        Me.GBframe1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBframe1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GBframe1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GBframe1.Location = New System.Drawing.Point(0, 0)
        Me.GBframe1.Name = "GBframe1"
        Me.GBframe1.Size = New System.Drawing.Size(377, 463)
        Me.GBframe1.TabIndex = 70
        Me.GBframe1.TabStop = False
        '
        'BtnReplace
        '
        Me.BtnReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReplace.Location = New System.Drawing.Point(154, 416)
        Me.BtnReplace.Name = "BtnReplace"
        Me.BtnReplace.Size = New System.Drawing.Size(89, 40)
        Me.BtnReplace.TabIndex = 69
        Me.BtnReplace.Text = "Replace and create XML"
        Me.BtnReplace.UseVisualStyleBackColor = True
        '
        'GBframe2
        '
        Me.GBframe2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GBframe2.Controls.Add(Me.TabControl1)
        Me.GBframe2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBframe2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GBframe2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GBframe2.Location = New System.Drawing.Point(0, 0)
        Me.GBframe2.Name = "GBframe2"
        Me.GBframe2.Size = New System.Drawing.Size(746, 463)
        Me.GBframe2.TabIndex = 66
        Me.GBframe2.TabStop = False
        '
        'FrmXMLconv
        '
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1134, 577)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FrmXMLconv"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "XML Message Tool"
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
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GBOutXML.ResumeLayout(False)
        Me.GBOutXML.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GBframe1.ResumeLayout(False)
        Me.GBframe2.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents TVcsv As TreeView
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
    Friend WithEvents BtnCreateCSV As Button
    Friend WithEvents BtnOpenCSV As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TVdtd As TreeView
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TVelement As TreeView
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnReplace As Button
    Friend WithEvents BtnOpneDTD As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GBOutXML As GroupBox
    Friend WithEvents TxtXMLOut As TextBox
    Friend WithEvents BtnSaveXML As Button
    Friend WithEvents BtnOpenXML As Button
    Friend WithEvents TxtOutXMLPath As TextBox
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TVxmlOut As TreeView
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents GBframe1 As GroupBox
    Friend WithEvents GBframe2 As GroupBox
End Class
