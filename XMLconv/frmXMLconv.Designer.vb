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
        Me.gbIn = New System.Windows.Forms.GroupBox()
        Me.btnbrowseIn = New System.Windows.Forms.Button()
        Me.txtInMessage = New System.Windows.Forms.TextBox()
        Me.txtInPath = New System.Windows.Forms.TextBox()
        Me.gbXMLout = New System.Windows.Forms.GroupBox()
        Me.txtXMLout = New System.Windows.Forms.TextBox()
        Me.btnbrowseOut = New System.Windows.Forms.Button()
        Me.txtOutPath = New System.Windows.Forms.TextBox()
        Me.OFD1 = New System.Windows.Forms.OpenFileDialog()
        Me.SFD1 = New System.Windows.Forms.SaveFileDialog()
        Me.btnConv = New System.Windows.Forms.Button()
        Me.BtnNewValue = New System.Windows.Forms.Button()
        Me.cbElement = New System.Windows.Forms.ComboBox()
        Me.GbReplaceValue = New System.Windows.Forms.GroupBox()
        Me.RbAllElements = New System.Windows.Forms.RadioButton()
        Me.RbOnlyThisElement = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbNewValue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbIn.SuspendLayout()
        Me.gbXMLout.SuspendLayout()
        Me.GbReplaceValue.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(1138, 43)
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 515)
        Me.GroupBox1.Size = New System.Drawing.Size(1140, 7)
        '
        'cmdOk
        '
        Me.cmdOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(781, 538)
        Me.cmdOk.Size = New System.Drawing.Size(155, 24)
        Me.cmdOk.Text = "&Open Output File"
        '
        'cmdCancel
        '
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Location = New System.Drawing.Point(952, 538)
        Me.cmdCancel.Text = "&Close"
        '
        'cmdHelp
        '
        Me.cmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHelp.Location = New System.Drawing.Point(1048, 538)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(143, 5)
        Me.Label1.Text = "XML File Tool"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(143, 24)
        Me.Label2.Size = New System.Drawing.Size(1062, 19)
        Me.Label2.Text = "Open an XML message and convert it to an XML DTD description file, or change valu" &
    "es in any Element of the XML Structure."
        '
        'gbIn
        '
        Me.gbIn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbIn.Controls.Add(Me.btnbrowseIn)
        Me.gbIn.Controls.Add(Me.txtInMessage)
        Me.gbIn.Controls.Add(Me.txtInPath)
        Me.gbIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIn.Location = New System.Drawing.Point(12, 49)
        Me.gbIn.Name = "gbIn"
        Me.gbIn.Size = New System.Drawing.Size(1114, 198)
        Me.gbIn.TabIndex = 58
        Me.gbIn.TabStop = False
        Me.gbIn.Text = "XML File In"
        '
        'btnbrowseIn
        '
        Me.btnbrowseIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowseIn.Location = New System.Drawing.Point(902, 17)
        Me.btnbrowseIn.Name = "btnbrowseIn"
        Me.btnbrowseIn.Size = New System.Drawing.Size(206, 23)
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
        Me.txtInMessage.Size = New System.Drawing.Size(1102, 147)
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
        Me.txtInPath.Size = New System.Drawing.Size(890, 20)
        Me.txtInPath.TabIndex = 0
        '
        'gbXMLout
        '
        Me.gbXMLout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbXMLout.Controls.Add(Me.txtXMLout)
        Me.gbXMLout.Controls.Add(Me.btnbrowseOut)
        Me.gbXMLout.Controls.Add(Me.txtOutPath)
        Me.gbXMLout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbXMLout.Location = New System.Drawing.Point(12, 332)
        Me.gbXMLout.Name = "gbXMLout"
        Me.gbXMLout.Size = New System.Drawing.Size(1114, 177)
        Me.gbXMLout.TabIndex = 59
        Me.gbXMLout.TabStop = False
        Me.gbXMLout.Text = "XML File output"
        '
        'txtXMLout
        '
        Me.txtXMLout.AcceptsReturn = True
        Me.txtXMLout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXMLout.BackColor = System.Drawing.SystemColors.Window
        Me.txtXMLout.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXMLout.Location = New System.Drawing.Point(6, 19)
        Me.txtXMLout.Multiline = True
        Me.txtXMLout.Name = "txtXMLout"
        Me.txtXMLout.ReadOnly = True
        Me.txtXMLout.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtXMLout.Size = New System.Drawing.Size(1102, 124)
        Me.txtXMLout.TabIndex = 3
        '
        'btnbrowseOut
        '
        Me.btnbrowseOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbrowseOut.Location = New System.Drawing.Point(902, 149)
        Me.btnbrowseOut.Name = "btnbrowseOut"
        Me.btnbrowseOut.Size = New System.Drawing.Size(206, 23)
        Me.btnbrowseOut.TabIndex = 2
        Me.btnbrowseOut.Text = "Save Output File"
        Me.btnbrowseOut.UseVisualStyleBackColor = True
        '
        'txtOutPath
        '
        Me.txtOutPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutPath.Location = New System.Drawing.Point(6, 151)
        Me.txtOutPath.Name = "txtOutPath"
        Me.txtOutPath.Size = New System.Drawing.Size(890, 20)
        Me.txtOutPath.TabIndex = 1
        '
        'OFD1
        '
        Me.OFD1.Filter = "XML Files|*.xml|All Files|*.*"
        Me.OFD1.Title = "Open XML Message"
        '
        'SFD1
        '
        Me.SFD1.DefaultExt = "xml"
        Me.SFD1.Filter = "XML Files|*.xml|XML DTD Files|*.DTD|All Files|*.*"
        Me.SFD1.Title = "DTD File Save"
        '
        'btnConv
        '
        Me.btnConv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConv.Location = New System.Drawing.Point(12, 253)
        Me.btnConv.Name = "btnConv"
        Me.btnConv.Size = New System.Drawing.Size(124, 67)
        Me.btnConv.TabIndex = 61
        Me.btnConv.Text = "Convert to Data List"
        Me.btnConv.UseVisualStyleBackColor = True
        '
        'BtnNewValue
        '
        Me.BtnNewValue.Location = New System.Drawing.Point(790, 14)
        Me.BtnNewValue.Name = "BtnNewValue"
        Me.BtnNewValue.Size = New System.Drawing.Size(188, 28)
        Me.BtnNewValue.TabIndex = 62
        Me.BtnNewValue.Text = "Change Value"
        Me.BtnNewValue.UseVisualStyleBackColor = True
        '
        'cbElement
        '
        Me.cbElement.FormattingEnabled = True
        Me.cbElement.Location = New System.Drawing.Point(6, 48)
        Me.cbElement.Name = "cbElement"
        Me.cbElement.Size = New System.Drawing.Size(457, 24)
        Me.cbElement.TabIndex = 63
        '
        'GbReplaceValue
        '
        Me.GbReplaceValue.Controls.Add(Me.RbAllElements)
        Me.GbReplaceValue.Controls.Add(Me.RbOnlyThisElement)
        Me.GbReplaceValue.Controls.Add(Me.Label4)
        Me.GbReplaceValue.Controls.Add(Me.TbNewValue)
        Me.GbReplaceValue.Controls.Add(Me.Label3)
        Me.GbReplaceValue.Controls.Add(Me.BtnNewValue)
        Me.GbReplaceValue.Controls.Add(Me.cbElement)
        Me.GbReplaceValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbReplaceValue.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GbReplaceValue.Location = New System.Drawing.Point(142, 247)
        Me.GbReplaceValue.Name = "GbReplaceValue"
        Me.GbReplaceValue.Size = New System.Drawing.Size(986, 79)
        Me.GbReplaceValue.TabIndex = 64
        Me.GbReplaceValue.TabStop = False
        Me.GbReplaceValue.Text = "Replace Element Value"
        '
        'RbAllElements
        '
        Me.RbAllElements.AutoSize = True
        Me.RbAllElements.Location = New System.Drawing.Point(469, 47)
        Me.RbAllElements.Name = "RbAllElements"
        Me.RbAllElements.Size = New System.Drawing.Size(169, 20)
        Me.RbAllElements.TabIndex = 68
        Me.RbAllElements.Text = "All Elements like this"
        Me.RbAllElements.UseVisualStyleBackColor = True
        '
        'RbOnlyThisElement
        '
        Me.RbOnlyThisElement.AutoSize = True
        Me.RbOnlyThisElement.Checked = True
        Me.RbOnlyThisElement.Location = New System.Drawing.Point(469, 18)
        Me.RbOnlyThisElement.Name = "RbOnlyThisElement"
        Me.RbOnlyThisElement.Size = New System.Drawing.Size(151, 20)
        Me.RbOnlyThisElement.TabIndex = 67
        Me.RbOnlyThisElement.TabStop = True
        Me.RbOnlyThisElement.Text = "Only This Element"
        Me.RbOnlyThisElement.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(644, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Enter New Value"
        '
        'TbNewValue
        '
        Me.TbNewValue.Location = New System.Drawing.Point(647, 48)
        Me.TbNewValue.Name = "TbNewValue"
        Me.TbNewValue.Size = New System.Drawing.Size(331, 22)
        Me.TbNewValue.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Choose Element"
        '
        'frmXMLconv
        '
        Me.ClientSize = New System.Drawing.Size(1138, 577)
        Me.Controls.Add(Me.GbReplaceValue)
        Me.Controls.Add(Me.gbIn)
        Me.Controls.Add(Me.gbXMLout)
        Me.Controls.Add(Me.btnConv)
        Me.Name = "frmXMLconv"
        Me.Text = "XML Message Converter"
        Me.Controls.SetChildIndex(Me.btnConv, 0)
        Me.Controls.SetChildIndex(Me.gbXMLout, 0)
        Me.Controls.SetChildIndex(Me.gbIn, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdOk, 0)
        Me.Controls.SetChildIndex(Me.cmdCancel, 0)
        Me.Controls.SetChildIndex(Me.cmdHelp, 0)
        Me.Controls.SetChildIndex(Me.GbReplaceValue, 0)
        Me.Panel1.ResumeLayout(False)
        Me.gbIn.ResumeLayout(False)
        Me.gbIn.PerformLayout()
        Me.gbXMLout.ResumeLayout(False)
        Me.gbXMLout.PerformLayout()
        Me.GbReplaceValue.ResumeLayout(False)
        Me.GbReplaceValue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbIn As System.Windows.Forms.GroupBox
    Friend WithEvents txtInMessage As System.Windows.Forms.TextBox
    Friend WithEvents txtInPath As System.Windows.Forms.TextBox
    Friend WithEvents gbXMLout As System.Windows.Forms.GroupBox
    Friend WithEvents OFD1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnbrowseIn As System.Windows.Forms.Button
    Friend WithEvents btnConv As System.Windows.Forms.Button
    Friend WithEvents txtXMLout As System.Windows.Forms.TextBox
    Friend WithEvents btnbrowseOut As System.Windows.Forms.Button
    Friend WithEvents txtOutPath As System.Windows.Forms.TextBox
    Friend WithEvents BtnNewValue As Button
    Friend WithEvents cbElement As ComboBox
    Friend WithEvents GbReplaceValue As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TbNewValue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RbAllElements As RadioButton
    Friend WithEvents RbOnlyThisElement As RadioButton
End Class
