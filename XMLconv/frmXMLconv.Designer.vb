<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmXMLconv
    Inherits FrmBlank

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.gbIn = New System.Windows.Forms.GroupBox()
        Me.btnbrowseIn = New System.Windows.Forms.Button()
        Me.txtInMessage = New System.Windows.Forms.TextBox()
        Me.txtInPath = New System.Windows.Forms.TextBox()
        Me.gbXMLout = New System.Windows.Forms.GroupBox()
        Me.BtnOpenCSV = New System.Windows.Forms.Button()
        Me.TxtCSVout = New System.Windows.Forms.TextBox()
        Me.BtnSaveCSV = New System.Windows.Forms.Button()
        Me.TxtCSVSavePath = New System.Windows.Forms.TextBox()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnCreateCSV = New System.Windows.Forms.Button()
        Me.GbChooseEleCSV = New System.Windows.Forms.GroupBox()
        Me.TVcsv = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TVelement = New System.Windows.Forms.TreeView()
        Me.BtnReplaceXMLvalue = New System.Windows.Forms.Button()
        Me.RbAllElements = New System.Windows.Forms.RadioButton()
        Me.RbOnlyThisElement = New System.Windows.Forms.RadioButton()
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
        Me.BtnCreateDTD = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnOpenDTD = New System.Windows.Forms.Button()
        Me.txtDTDout = New System.Windows.Forms.TextBox()
        Me.BtnSaveDTD = New System.Windows.Forms.Button()
        Me.TxtSaveDTDPath = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnCreateXML = New System.Windows.Forms.Button()
        Me.TVxml = New System.Windows.Forms.TreeView()
        Me.GBOutXML = New System.Windows.Forms.GroupBox()
        Me.TxtXMLOut = New System.Windows.Forms.TextBox()
        Me.BtnSaveXML = New System.Windows.Forms.Button()
        Me.TxtOutXMLPath = New System.Windows.Forms.TextBox()
        Me.BtnOpenXML = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TVjson = New System.Windows.Forms.TreeView()
        Me.BtnCreateJSON = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.BtnOpenJSON = New System.Windows.Forms.Button()
        Me.TxtJSONout = New System.Windows.Forms.TextBox()
        Me.BtnSaveJSON = New System.Windows.Forms.Button()
        Me.TxtOutJSONpath = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RbUseValue = New System.Windows.Forms.RadioButton()
        Me.RbUseTag = New System.Windows.Forms.RadioButton()
        Me.BtnCreateSQL = New System.Windows.Forms.Button()
        Me.TVsql = New System.Windows.Forms.TreeView()
        Me.GBsqlOut = New System.Windows.Forms.GroupBox()
        Me.BtnOpenSQL = New System.Windows.Forms.Button()
        Me.TxTSQLout = New System.Windows.Forms.TextBox()
        Me.BtnSaveSQL = New System.Windows.Forms.Button()
        Me.TxtOutSQLpath = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GBframe1 = New System.Windows.Forms.GroupBox()
        Me.GBframe2 = New System.Windows.Forms.GroupBox()
        Me.CbMasterFld = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.TabPage6.SuspendLayout()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GBsqlOut.SuspendLayout()
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
        Me.CmdOk.Location = New System.Drawing.Point(892, 538)
        Me.CmdOk.Size = New System.Drawing.Size(133, 27)
        Me.CmdOk.Text = "Open Log"
        '
        'CmdCancel
        '
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.Location = New System.Drawing.Point(1031, 538)
        Me.CmdCancel.Text = "&Close"
        '
        'CmdHelp
        '
        Me.CmdHelp.Enabled = False
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdHelp.Location = New System.Drawing.Point(790, 538)
        Me.CmdHelp.Visible = False
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
        Me.gbIn.Controls.Add(Me.btnbrowseIn)
        Me.gbIn.Controls.Add(Me.txtInMessage)
        Me.gbIn.Controls.Add(Me.txtInPath)
        Me.gbIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbIn.Location = New System.Drawing.Point(3, 16)
        Me.gbIn.Name = "gbIn"
        Me.gbIn.Size = New System.Drawing.Size(371, 444)
        Me.gbIn.TabIndex = 58
        Me.gbIn.TabStop = False
        Me.gbIn.Text = "XML File In"
        '
        'btnbrowseIn
        '
        Me.btnbrowseIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowseIn.BackColor = System.Drawing.SystemColors.Control
        Me.btnbrowseIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnbrowseIn.Location = New System.Drawing.Point(279, 17)
        Me.btnbrowseIn.Name = "btnbrowseIn"
        Me.btnbrowseIn.Size = New System.Drawing.Size(86, 25)
        Me.btnbrowseIn.TabIndex = 2
        Me.btnbrowseIn.Text = "Input File"
        Me.btnbrowseIn.UseVisualStyleBackColor = False
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
        Me.txtInMessage.Size = New System.Drawing.Size(359, 398)
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
        Me.txtInPath.Size = New System.Drawing.Size(267, 20)
        Me.txtInPath.TabIndex = 0
        '
        'gbXMLout
        '
        Me.gbXMLout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbXMLout.Controls.Add(Me.BtnOpenCSV)
        Me.gbXMLout.Controls.Add(Me.TxtCSVout)
        Me.gbXMLout.Controls.Add(Me.BtnSaveCSV)
        Me.gbXMLout.Controls.Add(Me.TxtCSVSavePath)
        Me.gbXMLout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbXMLout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbXMLout.ForeColor = System.Drawing.SystemColors.ControlText
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
        'TxtCSVSavePath
        '
        Me.TxtCSVSavePath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCSVSavePath.Location = New System.Drawing.Point(6, 383)
        Me.TxtCSVSavePath.Name = "TxtCSVSavePath"
        Me.TxtCSVSavePath.Size = New System.Drawing.Size(340, 20)
        Me.TxtCSVSavePath.TabIndex = 1
        '
        'OFD1
        '
        Me.OFD1.Filter = "XML Files|*.xml|All Files|*.*"
        Me.OFD1.Title = "Open XML Message"
        '
        'SFD1
        '
        Me.SFD1.RestoreDirectory = True
        Me.SFD1.Title = "Save File"
        '
        'BtnCreateCSV
        '
        Me.BtnCreateCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateCSV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreateCSV.Location = New System.Drawing.Point(125, 381)
        Me.BtnCreateCSV.Name = "BtnCreateCSV"
        Me.BtnCreateCSV.Size = New System.Drawing.Size(111, 23)
        Me.BtnCreateCSV.TabIndex = 61
        Me.BtnCreateCSV.Text = "Create CSV"
        Me.BtnCreateCSV.UseVisualStyleBackColor = True
        '
        'GbChooseEleCSV
        '
        Me.GbChooseEleCSV.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GbChooseEleCSV.Controls.Add(Me.TVcsv)
        Me.GbChooseEleCSV.Controls.Add(Me.BtnCreateCSV)
        Me.GbChooseEleCSV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GbChooseEleCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbChooseEleCSV.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.TVcsv.Location = New System.Drawing.Point(9, 20)
        Me.TVcsv.Name = "TVcsv"
        Me.TVcsv.Size = New System.Drawing.Size(227, 355)
        Me.TVcsv.TabIndex = 69
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
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
        Me.SplitContainer4.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.Controls.Add(Me.TVelement)
        Me.GroupBox4.Controls.Add(Me.BtnReplaceXMLvalue)
        Me.GroupBox4.Controls.Add(Me.RbAllElements)
        Me.GroupBox4.Controls.Add(Me.RbOnlyThisElement)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(242, 409)
        Me.GroupBox4.TabIndex = 71
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Choose Element Values"
        '
        'TVelement
        '
        Me.TVelement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVelement.Location = New System.Drawing.Point(9, 20)
        Me.TVelement.Name = "TVelement"
        Me.TVelement.Size = New System.Drawing.Size(227, 293)
        Me.TVelement.TabIndex = 69
        '
        'BtnReplaceXMLvalue
        '
        Me.BtnReplaceXMLvalue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnReplaceXMLvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReplaceXMLvalue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnReplaceXMLvalue.Location = New System.Drawing.Point(6, 375)
        Me.BtnReplaceXMLvalue.Name = "BtnReplaceXMLvalue"
        Me.BtnReplaceXMLvalue.Size = New System.Drawing.Size(227, 28)
        Me.BtnReplaceXMLvalue.TabIndex = 69
        Me.BtnReplaceXMLvalue.Text = "Save Changes to Elements"
        Me.BtnReplaceXMLvalue.UseVisualStyleBackColor = True
        '
        'RbAllElements
        '
        Me.RbAllElements.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbAllElements.AutoSize = True
        Me.RbAllElements.Location = New System.Drawing.Point(9, 350)
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
        Me.RbOnlyThisElement.Location = New System.Drawing.Point(9, 322)
        Me.RbOnlyThisElement.Name = "RbOnlyThisElement"
        Me.RbOnlyThisElement.Size = New System.Drawing.Size(141, 19)
        Me.RbOnlyThisElement.TabIndex = 67
        Me.RbOnlyThisElement.TabStop = True
        Me.RbOnlyThisElement.Text = "Only This Element"
        Me.RbOnlyThisElement.UseVisualStyleBackColor = True
        '
        'gbEditElement
        '
        Me.gbEditElement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.gbEditElement.Controls.Add(Me.TxtElementValue)
        Me.gbEditElement.Controls.Add(Me.Label5)
        Me.gbEditElement.Controls.Add(Me.SCElement)
        Me.gbEditElement.Controls.Add(Me.TxtElementName)
        Me.gbEditElement.Controls.Add(Me.Label4)
        Me.gbEditElement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbEditElement.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.GBAttribute.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.GBChildren.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.SplitContainer2.BackColor = System.Drawing.SystemColors.Control
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
        Me.SplitContainer3.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.TVdtd)
        Me.GroupBox3.Controls.Add(Me.BtnCreateDTD)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(242, 409)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choose Output Elements"
        '
        'TVdtd
        '
        Me.TVdtd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVdtd.Location = New System.Drawing.Point(9, 20)
        Me.TVdtd.Name = "TVdtd"
        Me.TVdtd.Size = New System.Drawing.Size(227, 355)
        Me.TVdtd.TabIndex = 69
        '
        'BtnCreateDTD
        '
        Me.BtnCreateDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateDTD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateDTD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreateDTD.Location = New System.Drawing.Point(129, 381)
        Me.BtnCreateDTD.Name = "BtnCreateDTD"
        Me.BtnCreateDTD.Size = New System.Drawing.Size(107, 23)
        Me.BtnCreateDTD.TabIndex = 68
        Me.BtnCreateDTD.Text = "Create DTD"
        Me.BtnCreateDTD.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.BtnOpenDTD)
        Me.GroupBox2.Controls.Add(Me.txtDTDout)
        Me.GroupBox2.Controls.Add(Me.BtnSaveDTD)
        Me.GroupBox2.Controls.Add(Me.TxtSaveDTDPath)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 409)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DTD File output"
        '
        'BtnOpenDTD
        '
        Me.BtnOpenDTD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenDTD.Location = New System.Drawing.Point(413, 381)
        Me.BtnOpenDTD.Name = "BtnOpenDTD"
        Me.BtnOpenDTD.Size = New System.Drawing.Size(61, 23)
        Me.BtnOpenDTD.TabIndex = 4
        Me.BtnOpenDTD.Text = "Open"
        Me.BtnOpenDTD.UseVisualStyleBackColor = True
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
        Me.BtnSaveDTD.Location = New System.Drawing.Point(353, 381)
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
        Me.SplitContainer5.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox5.Controls.Add(Me.BtnCreateXML)
        Me.GroupBox5.Controls.Add(Me.TVxml)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(241, 409)
        Me.GroupBox5.TabIndex = 71
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Choose Output Elements"
        '
        'BtnCreateXML
        '
        Me.BtnCreateXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateXML.Location = New System.Drawing.Point(127, 380)
        Me.BtnCreateXML.Name = "BtnCreateXML"
        Me.BtnCreateXML.Size = New System.Drawing.Size(108, 23)
        Me.BtnCreateXML.TabIndex = 70
        Me.BtnCreateXML.Text = "Create XML"
        Me.BtnCreateXML.UseVisualStyleBackColor = True
        '
        'TVxml
        '
        Me.TVxml.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVxml.Location = New System.Drawing.Point(9, 20)
        Me.TVxml.Name = "TVxml"
        Me.TVxml.Size = New System.Drawing.Size(226, 354)
        Me.TVxml.TabIndex = 69
        '
        'GBOutXML
        '
        Me.GBOutXML.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GBOutXML.Controls.Add(Me.TxtXMLOut)
        Me.GBOutXML.Controls.Add(Me.BtnSaveXML)
        Me.GBOutXML.Controls.Add(Me.TxtOutXMLPath)
        Me.GBOutXML.Controls.Add(Me.BtnOpenXML)
        Me.GBOutXML.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBOutXML.ForeColor = System.Drawing.SystemColors.ControlText
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
        Me.BtnSaveXML.Location = New System.Drawing.Point(350, 380)
        Me.BtnSaveXML.Name = "BtnSaveXML"
        Me.BtnSaveXML.Size = New System.Drawing.Size(58, 23)
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
        Me.TxtOutXMLPath.Size = New System.Drawing.Size(338, 20)
        Me.TxtOutXMLPath.TabIndex = 1
        '
        'BtnOpenXML
        '
        Me.BtnOpenXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenXML.Location = New System.Drawing.Point(414, 380)
        Me.BtnOpenXML.Name = "BtnOpenXML"
        Me.BtnOpenXML.Size = New System.Drawing.Size(61, 23)
        Me.BtnOpenXML.TabIndex = 2
        Me.BtnOpenXML.Text = "Open"
        Me.BtnOpenXML.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.SplitContainer7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(732, 415)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "JSON"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'SplitContainer7
        '
        Me.SplitContainer7.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.GroupBox7)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.GroupBox8)
        Me.SplitContainer7.Size = New System.Drawing.Size(732, 415)
        Me.SplitContainer7.SplitterDistance = 242
        Me.SplitContainer7.TabIndex = 62
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox7.Controls.Add(Me.TVjson)
        Me.GroupBox7.Controls.Add(Me.BtnCreateJSON)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox7.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(242, 415)
        Me.GroupBox7.TabIndex = 70
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Choose Output Elements"
        '
        'TVjson
        '
        Me.TVjson.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVjson.Location = New System.Drawing.Point(9, 19)
        Me.TVjson.Name = "TVjson"
        Me.TVjson.Size = New System.Drawing.Size(227, 362)
        Me.TVjson.TabIndex = 69
        '
        'BtnCreateJSON
        '
        Me.BtnCreateJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateJSON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreateJSON.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCreateJSON.Location = New System.Drawing.Point(129, 387)
        Me.BtnCreateJSON.Name = "BtnCreateJSON"
        Me.BtnCreateJSON.Size = New System.Drawing.Size(107, 23)
        Me.BtnCreateJSON.TabIndex = 68
        Me.BtnCreateJSON.Text = "Create JSON"
        Me.BtnCreateJSON.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox8.Controls.Add(Me.BtnOpenJSON)
        Me.GroupBox8.Controls.Add(Me.TxtJSONout)
        Me.GroupBox8.Controls.Add(Me.BtnSaveJSON)
        Me.GroupBox8.Controls.Add(Me.TxtOutJSONpath)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(486, 415)
        Me.GroupBox8.TabIndex = 60
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "JSON File output"
        '
        'BtnOpenJSON
        '
        Me.BtnOpenJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenJSON.Location = New System.Drawing.Point(419, 387)
        Me.BtnOpenJSON.Name = "BtnOpenJSON"
        Me.BtnOpenJSON.Size = New System.Drawing.Size(61, 23)
        Me.BtnOpenJSON.TabIndex = 4
        Me.BtnOpenJSON.Text = "Open"
        Me.BtnOpenJSON.UseVisualStyleBackColor = True
        '
        'TxtJSONout
        '
        Me.TxtJSONout.AcceptsReturn = True
        Me.TxtJSONout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtJSONout.BackColor = System.Drawing.SystemColors.Window
        Me.TxtJSONout.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtJSONout.Location = New System.Drawing.Point(6, 19)
        Me.TxtJSONout.Multiline = True
        Me.TxtJSONout.Name = "TxtJSONout"
        Me.TxtJSONout.ReadOnly = True
        Me.TxtJSONout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtJSONout.Size = New System.Drawing.Size(474, 362)
        Me.TxtJSONout.TabIndex = 3
        Me.TxtJSONout.WordWrap = False
        '
        'BtnSaveJSON
        '
        Me.BtnSaveJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveJSON.Location = New System.Drawing.Point(359, 387)
        Me.BtnSaveJSON.Name = "BtnSaveJSON"
        Me.BtnSaveJSON.Size = New System.Drawing.Size(54, 23)
        Me.BtnSaveJSON.TabIndex = 2
        Me.BtnSaveJSON.Text = "Save"
        Me.BtnSaveJSON.UseVisualStyleBackColor = True
        '
        'TxtOutJSONpath
        '
        Me.TxtOutJSONpath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutJSONpath.Location = New System.Drawing.Point(6, 389)
        Me.TxtOutJSONpath.Name = "TxtOutJSONpath"
        Me.TxtOutJSONpath.Size = New System.Drawing.Size(346, 20)
        Me.TxtOutJSONpath.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.SplitContainer6)
        Me.TabPage5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(732, 415)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "SQL"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.GroupBox6)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.GBsqlOut)
        Me.SplitContainer6.Size = New System.Drawing.Size(732, 415)
        Me.SplitContainer6.SplitterDistance = 244
        Me.SplitContainer6.TabIndex = 66
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.CbMasterFld)
        Me.GroupBox6.Controls.Add(Me.RbUseValue)
        Me.GroupBox6.Controls.Add(Me.RbUseTag)
        Me.GroupBox6.Controls.Add(Me.BtnCreateSQL)
        Me.GroupBox6.Controls.Add(Me.TVsql)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(244, 415)
        Me.GroupBox6.TabIndex = 64
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Choose Output Elements"
        '
        'RbUseValue
        '
        Me.RbUseValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbUseValue.AutoSize = True
        Me.RbUseValue.Location = New System.Drawing.Point(9, 322)
        Me.RbUseValue.Name = "RbUseValue"
        Me.RbUseValue.Size = New System.Drawing.Size(97, 19)
        Me.RbUseValue.TabIndex = 72
        Me.RbUseValue.Text = "Use Values"
        Me.RbUseValue.UseVisualStyleBackColor = True
        '
        'RbUseTag
        '
        Me.RbUseTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RbUseTag.AutoSize = True
        Me.RbUseTag.Checked = True
        Me.RbUseTag.Location = New System.Drawing.Point(9, 297)
        Me.RbUseTag.Name = "RbUseTag"
        Me.RbUseTag.Size = New System.Drawing.Size(127, 19)
        Me.RbUseTag.TabIndex = 71
        Me.RbUseTag.TabStop = True
        Me.RbUseTag.Text = "Use Tag Names"
        Me.RbUseTag.UseVisualStyleBackColor = True
        '
        'BtnCreateSQL
        '
        Me.BtnCreateSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCreateSQL.Location = New System.Drawing.Point(145, 386)
        Me.BtnCreateSQL.Name = "BtnCreateSQL"
        Me.BtnCreateSQL.Size = New System.Drawing.Size(93, 23)
        Me.BtnCreateSQL.TabIndex = 70
        Me.BtnCreateSQL.Text = "Create SQL"
        Me.BtnCreateSQL.UseVisualStyleBackColor = True
        '
        'TVsql
        '
        Me.TVsql.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TVsql.CheckBoxes = True
        Me.TVsql.FullRowSelect = True
        Me.TVsql.HotTracking = True
        Me.TVsql.Location = New System.Drawing.Point(9, 20)
        Me.TVsql.Name = "TVsql"
        Me.TVsql.Size = New System.Drawing.Size(229, 270)
        Me.TVsql.TabIndex = 69
        '
        'GBsqlOut
        '
        Me.GBsqlOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GBsqlOut.Controls.Add(Me.BtnOpenSQL)
        Me.GBsqlOut.Controls.Add(Me.TxTSQLout)
        Me.GBsqlOut.Controls.Add(Me.BtnSaveSQL)
        Me.GBsqlOut.Controls.Add(Me.TxtOutSQLpath)
        Me.GBsqlOut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBsqlOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBsqlOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GBsqlOut.Location = New System.Drawing.Point(0, 0)
        Me.GBsqlOut.Name = "GBsqlOut"
        Me.GBsqlOut.Size = New System.Drawing.Size(484, 415)
        Me.GBsqlOut.TabIndex = 59
        Me.GBsqlOut.TabStop = False
        Me.GBsqlOut.Text = "SQL File output"
        '
        'BtnOpenSQL
        '
        Me.BtnOpenSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOpenSQL.Location = New System.Drawing.Point(421, 387)
        Me.BtnOpenSQL.Name = "BtnOpenSQL"
        Me.BtnOpenSQL.Size = New System.Drawing.Size(56, 23)
        Me.BtnOpenSQL.TabIndex = 4
        Me.BtnOpenSQL.Text = "Open"
        Me.BtnOpenSQL.UseVisualStyleBackColor = True
        '
        'TxTSQLout
        '
        Me.TxTSQLout.AcceptsReturn = True
        Me.TxTSQLout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxTSQLout.BackColor = System.Drawing.SystemColors.Window
        Me.TxTSQLout.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxTSQLout.Location = New System.Drawing.Point(6, 19)
        Me.TxTSQLout.Multiline = True
        Me.TxTSQLout.Name = "TxTSQLout"
        Me.TxTSQLout.ReadOnly = True
        Me.TxTSQLout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxTSQLout.Size = New System.Drawing.Size(472, 362)
        Me.TxTSQLout.TabIndex = 3
        Me.TxTSQLout.WordWrap = False
        '
        'BtnSaveSQL
        '
        Me.BtnSaveSQL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSaveSQL.Location = New System.Drawing.Point(356, 387)
        Me.BtnSaveSQL.Name = "BtnSaveSQL"
        Me.BtnSaveSQL.Size = New System.Drawing.Size(59, 23)
        Me.BtnSaveSQL.TabIndex = 2
        Me.BtnSaveSQL.Text = "Save"
        Me.BtnSaveSQL.UseVisualStyleBackColor = True
        '
        'TxtOutSQLpath
        '
        Me.TxtOutSQLpath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOutSQLpath.Location = New System.Drawing.Point(6, 389)
        Me.TxtOutSQLpath.Name = "TxtOutSQLpath"
        Me.TxtOutSQLpath.Size = New System.Drawing.Size(344, 20)
        Me.TxtOutSQLpath.TabIndex = 1
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
        Me.GBframe1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBframe1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GBframe1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GBframe1.Location = New System.Drawing.Point(0, 0)
        Me.GBframe1.Name = "GBframe1"
        Me.GBframe1.Size = New System.Drawing.Size(377, 463)
        Me.GBframe1.TabIndex = 70
        Me.GBframe1.TabStop = False
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
        'CbMasterFld
        '
        Me.CbMasterFld.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbMasterFld.FormattingEnabled = True
        Me.CbMasterFld.Location = New System.Drawing.Point(6, 362)
        Me.CbMasterFld.Name = "CbMasterFld"
        Me.CbMasterFld.Size = New System.Drawing.Size(121, 23)
        Me.CbMasterFld.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Choose Master"
        '
        'FrmXMLconv
        '
        Me.BackColor = System.Drawing.SystemColors.Control
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GBOutXML.ResumeLayout(False)
        Me.GBOutXML.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        Me.SplitContainer7.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GBsqlOut.ResumeLayout(False)
        Me.GBsqlOut.PerformLayout()
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
    Friend WithEvents BtnCreateCSV As System.Windows.Forms.Button
    Friend WithEvents TxtCSVout As System.Windows.Forms.TextBox
    Friend WithEvents BtnSaveCSV As System.Windows.Forms.Button
    Friend WithEvents TxtCSVSavePath As System.Windows.Forms.TextBox
    Friend WithEvents GbChooseEleCSV As GroupBox
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
    Friend WithEvents BtnCreateDTD As Button
    Friend WithEvents BtnOpenCSV As Button
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TVdtd As TreeView
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TVelement As TreeView
    Friend WithEvents RbAllElements As RadioButton
    Friend WithEvents RbOnlyThisElement As RadioButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnReplaceXMLvalue As Button
    Friend WithEvents BtnOpenDTD As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents GBOutXML As GroupBox
    Friend WithEvents TxtXMLOut As TextBox
    Friend WithEvents BtnSaveXML As Button
    Friend WithEvents BtnOpenXML As Button
    Friend WithEvents TxtOutXMLPath As TextBox
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TVxml As TreeView
    Friend WithEvents GBframe1 As GroupBox
    Friend WithEvents GBframe2 As GroupBox
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents SplitContainer6 As SplitContainer
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TVsql As TreeView
    Friend WithEvents GBsqlOut As GroupBox
    Friend WithEvents BtnOpenSQL As Button
    Friend WithEvents TxTSQLout As TextBox
    Friend WithEvents BtnSaveSQL As Button
    Friend WithEvents TxtOutSQLpath As TextBox
    Friend WithEvents BtnCreateXML As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents SplitContainer7 As SplitContainer
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TVjson As TreeView
    Friend WithEvents BtnCreateJSON As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents BtnOpenJSON As Button
    Friend WithEvents TxtJSONout As TextBox
    Friend WithEvents BtnSaveJSON As Button
    Friend WithEvents TxtOutJSONpath As TextBox
    Friend WithEvents CldName As DataGridViewTextBoxColumn
    Friend WithEvents CldValue As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreateSQL As Button
    Friend WithEvents RbUseValue As RadioButton
    Friend WithEvents RbUseTag As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents CbMasterFld As ComboBox
End Class
