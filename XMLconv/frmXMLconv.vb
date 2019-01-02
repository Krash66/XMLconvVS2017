Imports System.Xml

Public Class frmXMLconv
    Inherits frmBlank
    '/// Created by TK   November 2011
    '/// Creates XML DTD files from XML messages
    '/// Modified Dec. 2018 to add changing of values in specified elements

    Private InFilePath As String                      '** Input XML Message File Path
    Private OutFilePath As String                     '** Output DTD XML Description File
    Private FileName As String                        '** Name of the file without path and extension
    Private xml_Indoc As New Xml.XmlDocument          '** Windows XML doc that XML message is read into

    Private ArrAllElements As New ArrayList           '** Array of all elements in Document
    Private ArrParentNodes As New ArrayList           '** Array of all elements that are parents of other elements
    Private ArrPrintedChildren As New ArrayList       '** Array of child elements that have children
    Private ArrCDataNodes As New ArrayList            '** Array of child elements that have NO children
    Private ddlOfElements As New ArrayList            '** Array of All Elements with parent objects for Drop Down List
    Private InputDir As String = ""                   '** Input Directory of the XML Message

    Private sb As System.Text.StringBuilder           '** String Builder Object that is built to create DTD message

    Private IsAll As Boolean = False

    Private Enum enumXMLActionType
        Failed = 0
        E_PrintwCldrn = 1
        E_PrintAsCdata = 2
        E_Ignore = 3
    End Enum

#Region "Form actions"

    Public Function OpenForm() As Boolean

        Try
            cmdOk.Enabled = False
            btnConv.Enabled = False
            btnbrowseOut.Enabled = False
            RbOnlyThisElement.Checked = True
            RbAllElements.Checked = False

            Me.Show()

        Catch ex As Exception
            'LogError(ex, "frmXMLconv OpenForm")
            Return False
        End Try

    End Function

    '    Public Function GetDTD(Optional ByVal InDir As String = "") As String

    '        cmdOk.Enabled = False
    '        btnConv.Enabled = False
    '        btnbrowseOut.Enabled = False
    '        'btnImportDTD.Visible = True
    '        'btnImportDTD.Enabled = False
    '        InputDir = InDir

    'doAgain:
    '        Select Case Me.ShowDialog
    '            Case Windows.Forms.DialogResult.OK
    '                GetDTD = txtOutPath.Text
    '            Case Windows.Forms.DialogResult.Retry
    '                GoTo doAgain
    '            Case Else
    '                GetDTD = ""
    '        End Select

    '    End Function

    Private Sub cmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Abort

    End Sub

    Private Sub cmdHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click

        'ShowHelp(HHId.H_XML_CONV)

    End Sub

    Public Sub MyCTL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                cmdCancel_Click_1(sender, New EventArgs)
            Case Keys.F1
                cmdHelp_Click_1(sender, New EventArgs)
        End Select

    End Sub

#End Region

#Region "Load Input XML Message"

    Private Sub btnbrowseIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowseIn.Click

        Try
            OFD1.Title = "XML Message"
            If InputDir <> "" Then
                OFD1.InitialDirectory = InputDir
            End If
            OFD1.ShowDialog()

        Catch ex As Exception
            'LogError(ex, "frmXMLconv btnbrowseIn_Click")
        End Try
    End Sub

    Private Sub OFD1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFD1.FileOk

        Try
            InFilePath = OFD1.FileName
            FileName = OFD1.SafeFileName.Remove(OFD1.SafeFileName.LastIndexOf("."))
            If InFilePath <> "" Then
                txtInPath.Text = InFilePath
                xml_Indoc = LoadXMLdoc()
                'Format the XML Document
                If FormatDoc() Then
                    LoadInText()
                    btnConv.Enabled = True
                    LoadTreeView()
                End If
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv OFD1_FileOk")
        End Try

    End Sub

    Private Sub LoadInText()

        ' Load the XML document in to the Text Window
        Try
            txtCSVout.Text = ""
            txtInMessage.Text = LoadTextFile(InFilePath)

        Catch ex As Exception
            'LogError(ex, "frmXMLconv LoadInText")
        End Try

    End Sub

    Function LoadTextFile(ByVal FilePath As String) As String

        Dim sr As System.IO.StreamReader = Nothing
        Try
            sr = New System.IO.StreamReader(FilePath)
            LoadTextFile = sr.ReadToEnd()

        Catch ex As Exception
            'LogError(ex, "modGeneral LoadTextFile")
            Return ""
        Finally
            If Not sr Is Nothing Then sr.Close()
        End Try

    End Function

    Private Function LoadXMLdoc() As Xml.XmlDocument

        Try
            Dim XMLtext As New Xml.XmlDocument
            If EncodeXMLFile(InFilePath) Then
                XMLtext.Load(InFilePath)
            End If
            Return XMLtext

        Catch ex As Exception
            'LogError(ex, "modGeneral LoadTextFile")
            Return Nothing
        End Try

    End Function

    Function EncodeXMLFile(ByVal file As String) As Boolean

        Try
            Dim s As String

            s = LoadTextFile(file)
            s = s.Replace("&", "&amp;")

            EncodeXMLFile = SaveTextFile(file, s)

        Catch ex As Exception
            'LogError(ex, "modXML EncodeXMLFile")
            EncodeXMLFile = False
        End Try

    End Function

    Function LoadTreeView() As Boolean
        Try
            If xml_Indoc.HasChildNodes = True Then
                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        Dim tnode As New TreeNode(nd.Name)
                        tnode.Tag = nd
                        TVxml.Nodes.Add(tnode)
                        TVxml.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child
                TVxml.ExpandAll()
                TVxml.CheckBoxes = True
                TVxml.SelectedNode.EnsureVisible()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading Treeview")
        End Try
    End Function

    Sub ProcessTreeChild(nd As XmlNode, tnd As TreeNode)
        Try
            'now process all child nodes recursively
            If nd.HasChildNodes = True Then
                For Each cn As XmlNode In nd.ChildNodes
                    If cn.NodeType = XmlNodeType.Element Then
                        Dim tn As New TreeNode(cn.Name)  ' & " " & cn.InnerText
                        tn.Tag = cn
                        tnd.Nodes.Add(tn)
                        ProcessTreeChild(cn, tn)
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading Treeview")
        End Try
    End Sub

    Friend Function FormatDoc() As Boolean
        Try
            For Each node As XmlNode In xml_Indoc.ChildNodes
                node.Normalize()
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show("Error formatting XML Document")
        End Try
    End Function

#End Region

#Region "Change Data Values"

    'Private Sub BtnNewValue_Click(sender As Object, e As EventArgs)
    '    Try
    '        ArrAllElements.Clear()
    '        ArrParentNodes.Clear()
    '        ArrPrintedChildren.Clear()
    '        ArrCDataNodes.Clear()
    '        'Convert xml_doc to new string builder text
    '        'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
    '        'xml_Indoc.Load(InFilePath)
    '        sb = New System.Text.StringBuilder
    '        txtCSVout.Text = ""

    '        'Start processing each node in the Message
    '        If xml_Indoc.HasChildNodes = True Then
    '            For Each nd As Xml.XmlNode In xml_Indoc.ChildNodes
    '                '*** Process each Node, if it is an element
    '                '*** if it's not an element, ignore it
    '                If nd.NodeType = Xml.XmlNodeType.Element Then
    '                    processNode(nd)
    '                End If
    '            Next 'next doc child
    '        End If

    '        If printCData(ArrCDataNodes) = True Then
    '            txtCSVout.Text = sb.ToString
    '            btnbrowseOut.Enabled = True
    '        End If

    '    Catch ex As Exception
    '        'LogError(ex, "frmXMLconv btnConv_Click")
    '    End Try

    'End Sub

    Private Sub RbOnlyThisElement_CheckedChanged(sender As Object, e As EventArgs) Handles RbOnlyThisElement.CheckedChanged
        If RbOnlyThisElement.Checked = True Then
            IsAll = False
            RbAllElements.Checked = False
        End If
    End Sub

    Private Sub RbAllElements_CheckedChanged(sender As Object, e As EventArgs) Handles RbAllElements.CheckedChanged
        If RbAllElements.Checked = True Then
            IsAll = True
            RbOnlyThisElement.Checked = False
        End If
    End Sub


#End Region

#Region "Convert to DTD"

    Private Sub btnConv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConv.Click

        Try
            ArrAllElements.Clear()
            ArrParentNodes.Clear()
            ArrPrintedChildren.Clear()
            ArrCDataNodes.Clear()
            'Convert xml_doc to new string builder text
            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            xml_Indoc.Load(InFilePath)
            sb = New System.Text.StringBuilder
            txtCSVout.Text = ""

            'Start processing each node in the Message           
            If xml_Indoc.HasChildNodes = True Then
                For Each nd As Xml.XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = Xml.XmlNodeType.Element Then
                        processNode(nd)
                    End If
                Next 'next doc child
            End If

            If printCData(ArrCDataNodes) = True Then
                txtCSVout.Text = sb.ToString
                btnbrowseOut.Enabled = True
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv btnConv_Click")
        End Try

    End Sub

    Private Function processNode(ByVal Node As Xml.XmlNode) As Boolean

        Try
            Dim Action As enumXMLActionType = GetNodeAction(Node)
            Dim ElementValue As String = Node.InnerText

            Select Case Action
                Case enumXMLActionType.E_PrintwCldrn

                    '*** Print the Element with it's children
                    printNodeWithChildren(Node)
                    '*** Now process the Children
                    For Each cld As Xml.XmlNode In Node.ChildNodes
                        'sb.AppendLine()
                        'sb.AppendLine("   ***Child = " & cld.Name)
                        'sb.AppendLine("   ***Of Parent = " & Node.Name)
                        'sb.AppendLine("   ***Sent to processNode")
                        'sb.AppendLine()
                        processNode(cld)
                    Next

                Case enumXMLActionType.E_PrintAsCdata
                    Dim QualName As String = GetCDataName(Node)
                    Dim ArrayName As String = String.Format("{0,-32}{1, -8}{2,-40}", QualName, ",  value:,", ElementValue)
                    ArrCDataNodes.Add(ArrayName)
                    'ArrAllElements.Add(QualName)

                Case enumXMLActionType.E_Ignore
                    '*** Do Nothing except goto next sibling or parent

                Case enumXMLActionType.Failed
                    If MsgBox("Translation failed at Element: " & Node.Name & Chr(13) &
                           "Would you like to continue processing?", MsgBoxStyle.YesNo, "Translation Failed") = MsgBoxResult.No Then
                        '*** abort here
                        Exit Function
                    End If

            End Select

            'If Node.NextSibling IsNot Nothing Then
            '    Node = Node.NextSibling
            '    sb.AppendLine()
            '    sb.AppendLine("   ***Next Sibling = " & Node.Name)
            '    sb.AppendLine()
            '    processNode(Node)
            '    'Else
            '    '    If Node.ParentNode IsNot Nothing Then
            '    '        Node = Node.ParentNode
            '    '        sb.AppendLine()
            '    '        sb.AppendLine("   ***Parent Node = " & Node.Name)
            '    '        sb.AppendLine()
            '    '    End If

            '    '    If Node.NextSibling IsNot Nothing Then
            '    '        Node = Node.NextSibling
            '    '        sb.AppendLine()
            '    '        sb.AppendLine("   ***Next Parent Sibling = " & Node.Name)
            '    '        sb.AppendLine()
            '    '        processNode(Node)
            '    '    End If
            'End If

            Return True

        Catch ex As Exception
            'LogError(ex, "frmXMLconv processNode")
            Return False
        End Try

    End Function

    Private Function GetNodeAction(ByVal nd As Xml.XmlNode) As enumXMLActionType

        Try
            Dim IsParentElement As Boolean = False

            If nd.HasChildNodes = True Then
                Dim NumEle As Integer = 0
                For Each node As Xml.XmlNode In nd.ChildNodes
                    If node.NodeType = Xml.XmlNodeType.Element Then
                        If node.HasChildNodes Then
                            If node.FirstChild.NodeType = Xml.XmlNodeType.Element Then
                                IsParentElement = True
                            End If
                        End If
                        NumEle += 1
                        If NumEle = 2 Then
                            GetNodeAction = enumXMLActionType.E_PrintwCldrn
                            Exit Function
                        End If
                    End If
                Next
                If IsParentElement = True Then
                    GetNodeAction = enumXMLActionType.E_PrintwCldrn
                Else
                    GetNodeAction = enumXMLActionType.E_PrintAsCdata
                End If
            Else
                If nd.NodeType = Xml.XmlNodeType.Element Then
                    GetNodeAction = enumXMLActionType.E_PrintAsCdata
                Else
                    GetNodeAction = enumXMLActionType.E_Ignore
                End If
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv GetNodeAction")
            GetNodeAction = enumXMLActionType.Failed
            sb.AppendLine("   --- Node action Failed ::" & nd.Name)
            sb.AppendLine()
        End Try

    End Function

    Private Function GetElementName(ByVal nd As Xml.XmlNode) As String

        Try
            Dim NewName As String = nd.LocalName
            Dim origName As String = NewName
            Dim count As Integer = 0

TryAgain:   If ArrParentNodes.Contains(NewName) = True Then
                count += 1
                NewName = origName & count.ToString
                GoTo TryAgain
            End If

            GetElementName = NewName

        Catch ex As Exception
            'LogError(ex, "frmXMLconv GetNameToAdd")
            GetElementName = ""
        End Try

    End Function

    Private Function GetChildName(ByVal nd As Xml.XmlNode) As String

        Try
            Dim NewName As String = nd.LocalName
            Dim origName As String = NewName
            Dim count As Integer = 0

TryAgain:   If ArrAllElements.Contains(NewName) = True Then
                count += 1
                NewName = origName & count.ToString
                GoTo TryAgain
            End If

            GetChildName = NewName

        Catch ex As Exception
            'LogError(ex, "frmXMLconv GetChildName")
            GetChildName = ""
        End Try

    End Function

    Private Function GetCDataName(ByVal nd As Xml.XmlNode) As String

        Try
            Dim NewName As String = nd.LocalName
            Dim origName As String = NewName
            Dim count As Integer = 0

TryAgain:   If ArrParentNodes.Contains(NewName) = True Then
                count += 1
                NewName = origName & count.ToString
                GoTo TryAgain
            End If
            If ArrPrintedChildren.Contains(NewName) = True Then
                ArrPrintedChildren.Remove(NewName)
                GetCDataName = NewName
            Else
                count += 1
                NewName = origName & count.ToString
                GoTo TryAgain
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv GetCDataNameToAdd")
            GetCDataName = ""
        End Try

    End Function

    Private Function printNodeWithChildren(ByVal node As Xml.XmlNode) As Boolean

        Try
            Dim QualName As String = GetElementName(node)


            If QualName <> "" Then
                Dim ChildElementName As String = ""
                Dim Prefix As String = "     "
                Dim Line1 As String = String.Format("{0}{1}", "<!ELEMENT ", QualName)
                Dim Line2 As String = String.Format("{0}", "(")
                Dim LastLine As String = String.Format("{0}", ")>")

                '*** Add to the all elements list for comparison BEFORE printing
                '*** So child can't have parent's name
                ArrAllElements.Add(QualName)
                ArrParentNodes.Add(QualName)

                '*** Print element and it's children
                'sb.AppendLine(Line1)                                        Uncomment for DTD convert
                'sb.AppendLine(Line2)                                        Uncomment for DTD convert
                For Each cld As Xml.XmlNode In node.ChildNodes
                    If cld.NodeType = Xml.XmlNodeType.Element Then
                        ChildElementName = GetChildName(cld)
                        Dim LineChild As String = String.Format("{0}{1}", Prefix, ChildElementName)
                        'sb.AppendLine(LineChild)                                        Uncomment for DTD convert
                        'Prefix = "    ,"                                        Uncomment for DTD convert
                        '*** Add children to the child array
                        ArrAllElements.Add(ChildElementName)
                        ArrPrintedChildren.Add(ChildElementName)
                    End If
                Next
                'sb.AppendLine(LastLine)                                        Uncomment for DTD convert
                'sb.AppendLine()                                        Uncomment for DTD convert

                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            'LogError(ex, "frmXMLconv printNode")
            Return False
        End Try

    End Function

    Private Function printCData(ByVal Arr As ArrayList) As Boolean

        Try
            Dim FORfld As String

            For Each name As String In Arr
                'FORfld = String.Format("{0}{1,30}{2,-100}", "<!ELEMENT ", name, " (#PCDATA)>")
                FORfld = String.Format("{0}{1,30}", "Name:, ", name)
                sb.AppendLine(FORfld)
            Next

            Return True

        Catch ex As Exception
            'LogError(ex, "frmXMLconv printCData")
            Return False
        End Try

    End Function

#End Region

#Region "Save Output DTD file"

    Private Sub btnbrowseOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowseOut.Click

        Try
            SFD1.Title = "Output File"
            If InputDir <> "" Then
                SFD1.InitialDirectory = InputDir
                SFD1.FileName = FileName
            End If
            SFD1.ShowDialog()

        Catch ex As Exception
            'LogError(ex, "frmXMLconv btnbrowseOut_Click")
        End Try

    End Sub

    Private Sub SFD1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SFD1.FileOk

        Try
            OutFilePath = SFD1.FileName
            txtOutPath.Text = OutFilePath
            If OutFilePath <> "" Then
                If Save() = True Then
                    'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                    cmdOk.Enabled = True
                    'btnImportDTD.Enabled = True
                End If
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv SFD1_FileOk")
        End Try

    End Sub

    Private Sub cmdOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        'Me.Close()
        'If Save() = True Then
        '    MsgBox("Save was successful", MsgBoxStyle.OkOnly)
        'End If
        Try
            If OutFilePath <> "" Then
                Dim OpenProcess As New System.Diagnostics.Process
                Process.Start(OutFilePath)

                'Shell("notepad.exe " & RetCode.SQDPath, AppWinStyle.NormalFocus)
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv cmdOk_Click_1")
        End Try

    End Sub

    '*** Save XML DTD to File
    Private Function Save() As Boolean

        Try
            If SFD1.FileName <> "" Then
                Save = SaveTextFile(OutFilePath, txtCSVout.Text)
            Else
                MsgBox("Please enter a valid Output File Path", MsgBoxStyle.Information, "No Valid Output Path")
                Save = False
            End If

        Catch ex As Exception
            'LogError(ex, "frmXMLconv Save")
            Save = False
        End Try

    End Function

    Public Function SaveTextFile(ByVal FilePath As String, ByVal FileContent As String, Optional ByVal Append As Boolean = False) As Boolean

        Dim sw As System.IO.StreamWriter = Nothing
        'Dim sw2 As System.IO.StreamWriter = Nothing
        Try
            sw = New System.IO.StreamWriter(FilePath, Append)

            sw.Write(FileContent)
            Return True

        Catch ex As Exception
            'LogError(ex, "modGeneral SaveTextFile")
            Return False
        Finally
            If sw IsNot Nothing Then sw.Close()
        End Try

    End Function

#End Region

End Class
