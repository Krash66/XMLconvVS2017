﻿Imports System.Xml
Public Class FrmXMLconv
    Inherits FrmBlank
    '/// Created by TK   November 2011
    '/// Creates XML DTD files from XML messages
    '/// Modified Dec. 2018 to add changing of values in specified elements

    Public InFilePath As String                      '** Input XML Message File Path

    Public CSVOutFilePath As String                     '** Output CSV XML Description File
    Public CSVFileName As String                        '** Name of the file without path and extension
    Public DTDOutFilePath As String                     '** Output DTD XML Description File
    Public DTDFileName As String                        '** Name of the file without path and extension
    Public JSONOutFilePath As String                    '** Output JSON XML Description File
    Public JSONFileName As String                       '** Name of the file without path and extension
    Public XMLOutFilePath As String                     '** Output XML XML Description File
    Public XMLFileName As String                        '** Name of the file without path and extension
    Public SQLOutFilePath As String                     '** Output SQL XML Description File
    Public SQLFileName As String                        '** Name of the file without path and extension

    Public xml_Indoc As New Xml.XmlDocument          '** Windows XML doc that XML message is read into

    Public InputDir As String = ""                   '** Input Directory of the XML Message

    Public sb As System.Text.StringBuilder           '** String Builder Object that is built to create DTD message

    Public IsAll As Boolean = False

#Region "Form actions"

    Private Sub Main_Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'CmdOk.Enabled = False
            'BtnCreateCSV.Enabled = False
            'BtnSaveCSV.Enabled = False
            RbOnlyThisElement.Checked = True
            RbAllElements.Checked = False
            RetrieveSettingsFromXML()
            LoadGlobalValues()

            Me.Show()
            'Log("Trace Enabled")

        Catch ex As Exception
            LogError(ex, "frmXMLconv OpenForm")
        End Try

    End Sub

    Private Sub Main_Form_Close(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closing

        SaveSettingsToXML()

    End Sub

    Private Sub CmdCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click

        Me.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Abort

    End Sub

    Private Sub CmdHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHelp.Click

        'ShowHelp(HHId.H_XML_CONV)

    End Sub

    Public Sub MyCTL_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                CmdCancel_Click_1(sender, New EventArgs)
            Case Keys.F1
                CmdHelp_Click_1(sender, New EventArgs)
        End Select

    End Sub

    Private Sub CmdOk_Click_OpenLog(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
        Dim frm As New FrmLog ': 8/15/05
        frm.ShowLog()
    End Sub

    Public Function SaveTextFile(ByVal FilePath As String, ByVal FileContent As String, Optional ByVal Append As Boolean = False) As Boolean

        Dim sw As System.IO.StreamWriter = Nothing
        'Dim sw2 As System.IO.StreamWriter = Nothing
        Try
            sw = New System.IO.StreamWriter(FilePath, Append)

            sw.Write(FileContent)
            Return True

        Catch ex As Exception
            LogError(ex, "FrmXMLconv SaveTextFile")
            Return False
        Finally
            If sw IsNot Nothing Then sw.Close()
        End Try

    End Function

#End Region

#Region "Main Program XML Settings Storage and retrieval"

    Function SaveSettingsToXML(Optional ByVal Newpath As Boolean = False) As Boolean

        Try
            '*** Path to Studio XML file
            If Newpath = True Then
                AppDataPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments()
                If Strings.Right(AppDataPath, 1) <> "\" Then
                    AppDataPath = AppDataPath & "\"
                End If
                AppDataPath = AppDataPath & "XML Tool\"
                If System.IO.Directory.Exists(AppDataPath) = False Then
                    System.IO.Directory.CreateDirectory(AppDataPath)
                End If
            End If

            Dim StudioXMLFullPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments() &
            "\XML Tool\XMLtool.settings.xml"

            '*** New XML writer for XML file
            Dim XMLwrite As New XmlTextWriter(StudioXMLFullPath, System.Text.Encoding.UTF8)

            '*** define doctype and formatting and Open XML file
            XMLwrite.Formatting = Formatting.Indented
            XMLwrite.WriteStartDocument()
            XMLwrite.WriteStartElement("XMLtool", "XMLtool", StudioXMLFullPath)

            '*** write Data
            'XMLwrite.WriteElementString("Winstate", WinState.ToString())
            XMLwrite.WriteElementString("AppDataPath", AppDataPath)
            'XMLwrite.WriteElementString("CCurl", CCurl)

            '*** write closing element and close file
            XMLwrite.WriteEndElement()
            XMLwrite.WriteEndDocument()
            XMLwrite.Close()

            Return True

        Catch ex As Exception
            LogError(ex, "FrmXMLconv SaveSettingsToXML")
            Return False
        End Try

    End Function

    Function RetrieveSettingsFromXML() As Boolean

        Try
            Dim curNode As XmlNode
            '*** Path to Project XML file
            Dim StudioXMLFullPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments() &
            "\XML Tool\XMLtool.settings.xml"

            If System.IO.File.Exists(StudioXMLFullPath) = False Then
                'AppDataPath = System.Windows.Forms.Application.LocalUserAppDataPath()
                RetrieveSettingsFromXML = SaveSettingsToXML(True)
            End If

            '*** New XML Doc for XML file
            Dim XMLDoc As New Xml.XmlDocument
            XMLDoc.Load(StudioXMLFullPath)

            If XMLDoc.HasChildNodes = True Then
                curNode = XMLDoc.LastChild
                Dim TempStr As String = ""
                For Each nd As XmlNode In curNode.ChildNodes
                    If nd.InnerText <> "" Then
                        TempStr = nd.InnerText
                    Else
                        TempStr = ""
                    End If
                    Select Case nd.Name
                        'Case "Winstate"
                        '    Select Case TempStr
                        '        Case "Maximized"
                        '            WinState = FormWindowState.Maximized
                        '        Case "Normal"
                        '            WinState = FormWindowState.Normal
                        '        Case Else
                        '            WinState = FormWindowState.Normal
                        '    End Select
                        Case "AppDataPath"
                            AppDataPath = TempStr
                            'Case "CCurl"
                            '    CCurl = TempStr

                    End Select
                Next
            End If

            Return True

        Catch ex As Exception
            LogError(ex, "FrmXMLconv RetrieveSettingsFromXML")
            Return False
        End Try

    End Function

#End Region

#Region "Load Input XML Message and save Output Files"

    Private Sub BtnbrowseIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowseIn.Click

        Try
            OFD1.Title = "XML Message"
            If InputDir <> "" Then
                OFD1.InitialDirectory = InputDir
            End If
            OFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmXMLconv btnbrowseIn_Click")
        End Try
    End Sub

    Private Sub OFD1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OFD1.FileOk

        Try
            InFilePath = OFD1.FileName

            CSVFileName = OFD1.SafeFileName.Remove(OFD1.SafeFileName.LastIndexOf("."))
            DTDFileName = OFD1.SafeFileName.Remove(OFD1.SafeFileName.LastIndexOf("."))
            JSONFileName = OFD1.SafeFileName.Remove(OFD1.SafeFileName.LastIndexOf("."))
            XMLFileName = OFD1.SafeFileName.Remove(OFD1.SafeFileName.LastIndexOf("."))
            SQLFileName = OFD1.SafeFileName.Remove(OFD1.SafeFileName.LastIndexOf("."))

            If InFilePath <> "" Then
                txtInPath.Text = InFilePath
                xml_Indoc = LoadXMLdoc()
                'Format the XML Document
                If FormatDoc() Then
                    LoadInText()
                    BtnCreateCSV.Enabled = True
                    'load all the Element trees on all tabs
                    LoadTreeView()
                End If
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv OFD1_FileOk")
        End Try

    End Sub

    Private Sub LoadInText()
        ' Load the XML document in to the Text Window
        Try
            txtInMessage.Text = LoadTextFile(InFilePath)
            TxtCSVout.Text = ""
            txtDTDout.Text = ""
            TxtJSONout.Text = ""
            TxtXMLOut.Text = ""
            TxTSQLout.Text = ""

        Catch ex As Exception
            LogError(ex, "frmXMLconv LoadInText")
        End Try

    End Sub

    Private Function LoadXMLdoc() As Xml.XmlDocument

        Try
            Dim XMLtext As New Xml.XmlDocument
            If EncodeXMLFile(InFilePath) Then
                XMLtext.Load(InFilePath)
            End If
            Return XMLtext

        Catch ex As Exception
            LogError(ex, "frmXMLconv LoadXMLdoc")
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
            LogError(ex, "frmXMLconv EncodeXMLFile")
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
                        Dim tnode As New TreeNode(nd.Name) With {
                            .Tag = nd
                        }
                        TVelement.Nodes.Add(tnode)
                        TVelement.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child
                TVelement.ExpandAll()
                TVelement.CheckBoxes = True
                TVelement.SelectedNode.EnsureVisible()
                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        Dim tnode As New TreeNode(nd.Name) With {
                            .Tag = nd
                        }
                        TVcsv.Nodes.Add(tnode)
                        TVcsv.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child                                                                         
                TVcsv.ExpandAll()
                TVcsv.CheckBoxes = True
                TVcsv.SelectedNode.EnsureVisible()

                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        Dim tnode As New TreeNode(nd.Name) With {
                            .Tag = nd
                        }
                        TVdtd.Nodes.Add(tnode)
                        TVdtd.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child                                    
                TVdtd.ExpandAll()
                TVdtd.CheckBoxes = True
                TVdtd.SelectedNode.EnsureVisible()

                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        Dim tnode As New TreeNode(nd.Name) With {
                            .Tag = nd
                        }
                        TVxml.Nodes.Add(tnode)
                        TVxml.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child                                   
                TVxml.ExpandAll()
                TVxml.CheckBoxes = True
                TVxml.SelectedNode.EnsureVisible()

                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        Dim tnode As New TreeNode(nd.Name) With {
                            .Tag = nd
                        }
                        TVjson.Nodes.Add(tnode)
                        TVjson.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child                                   
                TVjson.ExpandAll()
                TVjson.CheckBoxes = True
                TVjson.SelectedNode.EnsureVisible()

                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        Dim tnode As New TreeNode(nd.Name) With {
                            .Tag = nd
                        }
                        TVsql.Nodes.Add(tnode)
                        TVsql.SelectedNode = tnode
                        ProcessTreeChild(nd, tnode)
                    End If
                Next 'next doc child                                   
                TVsql.ExpandAll()
                TVsql.CheckBoxes = True
                TVsql.SelectedNode.EnsureVisible()
            End If
        Catch ex As Exception
            LogError(ex, "frmXMLconv LoadTreeView")
        End Try
    End Function

    Sub ProcessTreeChild(nd As XmlNode, tnd As TreeNode)
        Try
            'now process all child nodes recursively
            If nd.HasChildNodes = True Then
                For Each cn As XmlNode In nd.ChildNodes
                    If cn.NodeType = XmlNodeType.Element Then
                        Dim tn As New TreeNode(cn.Name) With {
                            .Tag = cn
                        }  ' & " " & cn.InnerText
                        tnd.Nodes.Add(tn)
                        ProcessTreeChild(cn, tn)
                    End If
                Next
            End If
        Catch ex As Exception
            LogError(ex, "frmXMLconv ProcessTreeChild")
        End Try
    End Sub

    Friend Function FormatDoc() As Boolean
        Try
            For Each node As XmlNode In xml_Indoc.ChildNodes
                node.Normalize()
            Next
            Return True
        Catch ex As Exception
            LogError(ex, "frmXMLconv FormatDoc")
        End Try
    End Function

    Private Sub SFD1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SFD1.FileOk

        Try
            Dim Saved As Boolean = False
            Select Case SFD1.Title
                Case "CSV File"
                    CSVOutFilePath = SFD1.FileName
                    TxtCSVSavePath.Text = CSVOutFilePath
                    If CSVOutFilePath <> "" Then
                        If SaveCSV() = True Then
                            Saved = True
                            'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                            'CmdOk.Enabled = True
                            btnbrowseIn.Enabled = True
                        End If
                    End If
                Case "DTD File"
                    DTDOutFilePath = SFD1.FileName
                    TxtSaveDTDPath.Text = DTDOutFilePath
                    If DTDOutFilePath <> "" Then
                        If SaveDTD() = True Then
                            Saved = True
                            'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                            'CmdOk.Enabled = True
                            btnbrowseIn.Enabled = True
                        End If
                    End If
                Case "JSON File"
                    CSVOutFilePath = SFD1.FileName
                    TxtCSVSavePath.Text = CSVOutFilePath
                    If CSVOutFilePath <> "" Then
                        If SaveJSON() = True Then
                            Saved = True
                            'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                            'CmdOk.Enabled = True
                            btnbrowseIn.Enabled = True
                        End If
                    End If
                Case "XML File"
                    CSVOutFilePath = SFD1.FileName
                    TxtCSVSavePath.Text = CSVOutFilePath
                    If CSVOutFilePath <> "" Then
                        If SaveXML() = True Then
                            Saved = True
                            'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                            'CmdOk.Enabled = True
                            btnbrowseIn.Enabled = True
                        End If
                    End If
                Case "SQL File"
                    CSVOutFilePath = SFD1.FileName
                    TxtCSVSavePath.Text = CSVOutFilePath
                    If CSVOutFilePath <> "" Then
                        If SaveSQL() = True Then
                            Saved = True
                            'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                            'CmdOk.Enabled = True
                            btnbrowseIn.Enabled = True
                        End If
                    End If
                Case "Update XML File"
                    CSVOutFilePath = SFD1.FileName
                    TxtCSVSavePath.Text = CSVOutFilePath
                    If CSVOutFilePath <> "" Then
                        If SaveUpdate() = True Then
                            Saved = True
                            'MsgBox("Save was successful", MsgBoxStyle.OkOnly)
                            'CmdOk.Enabled = True
                            btnbrowseIn.Enabled = True
                        End If
                    End If

                    If Saved = False Then
                        MsgBox("Failed to save file. Please check your path and privilege", MsgBoxStyle.Critical, "Invalid Path")
                    End If
            End Select

        Catch ex As Exception
            LogError(ex, "frmXMLconv SFD1_FileOk")
        End Try

    End Sub

#End Region

#Region "Change Data Values"

    Sub ClearElementTab()
        Try
            TxtElementName.Text = ""
            TxtElementValue.Text = ""

            DGVElement.Rows.Clear()
            DGVAttrib.Rows.Clear()

        Catch ex As Exception
            LogError(ex, "FrmXMLconv ClearElementTab")
        End Try
    End Sub

    Private Sub TVelement_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVelement.AfterSelect

    End Sub

    Private Sub RbOnlyThisElement_CheckedChanged(sender As Object, e As EventArgs)
        If RbOnlyThisElement.Checked = True Then
            IsAll = False
            RbAllElements.Checked = False
        End If
    End Sub

    Private Sub RbAllElements_CheckedChanged(sender As Object, e As EventArgs)
        If RbAllElements.Checked = True Then
            IsAll = True
            RbOnlyThisElement.Checked = False
        End If
    End Sub

    Private Sub TxtElementValue_TextChanged(sender As Object, e As EventArgs) Handles TxtElementValue.TextChanged
        Try

        Catch ex As Exception
            LogError(ex, "FrmXMLconv TxtElementValue_TextChanged")
        End Try
    End Sub

    Private Sub TxtElementName_TextChanged(sender As Object, e As EventArgs) Handles TxtElementName.TextChanged
        Try

        Catch ex As Exception
            LogError(ex, "FrmXMLconv TxtElementName_TextChanged")
        End Try
    End Sub

    Private Sub DGVAttrib_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAttrib.CellContentClick
        Try

        Catch ex As Exception
            LogError(ex, "FrmXMLconv DGVAttrib_CellContentClick")
        End Try
    End Sub

    Private Sub DGVElement_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVElement.CellContentClick
        Try

        Catch ex As Exception
            LogError(ex, "FrmXMLconv DGVElement_CellContentClick")
        End Try
    End Sub

    Private Sub BtnReplace_Click(sender As Object, e As EventArgs) Handles BtnReplaceXMLvalue.Click

    End Sub

    Function SaveUpdate() As Boolean

        Try

        Catch ex As Exception
            LogError(ex, "frmXMLconv SaveUpdate")
        End Try

    End Function

#End Region

#Region "CSV Events"

    Private Sub TVcsv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVcsv.AfterSelect

    End Sub

    Private Sub BtnCreateCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateCSV.Click

        Try
            'Convert xml_doc to new string builder text
            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            xml_Indoc.Load(InFilePath)
            sb = New System.Text.StringBuilder
            TxtCSVout.Text = ""

            If CreateCSV(sb, xml_Indoc) = True Then
                TxtCSVout.Text = sb.ToString
                BtnSaveCSV.Enabled = True
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnCreateCSV_Click")
        End Try

    End Sub

    Private Sub BtnSaveCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveCSV.Click

        Try
            SFD1.Title = "CSV File"
            If InputDir <> "" Then
                SFD1.InitialDirectory = InputDir
                SFD1.FileName = CSVFileName
            End If
            SFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnSaveCSV_Click")
        End Try

    End Sub

    Private Function SaveCSV() As Boolean

        Try
            If SFD1.FileName <> "" Then
                SaveCSV = SaveTextFile(CSVOutFilePath, TxtCSVout.Text)
            Else
                MsgBox("Please enter a valid Output File Path", MsgBoxStyle.Information, "No Valid Output Path")
                SaveCSV = False
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv Save")
            SaveCSV = False
        End Try

    End Function

    Private Sub BtnOpenCSV_Click(sender As Object, e As EventArgs) Handles BtnOpenCSV.Click

        Try
            If CSVOutFilePath <> "" Then
                Dim OpenProcess As New System.Diagnostics.Process
                Process.Start(CSVOutFilePath)
            End If

        Catch ex As Exception
            LogError(ex, "FrmXMLConv BtnOpenCSV_Click")
        End Try

    End Sub

#End Region

#Region "DTD Events"

    Private Sub BtnCreateDTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateDTD.Click

        Try
            'Convert xml_doc to new string builder text
            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            xml_Indoc.Load(InFilePath)
            sb = New System.Text.StringBuilder
            txtDTDout.Text = ""

            If CreateDTD(sb, xml_Indoc) = True Then
                txtDTDout.Text = sb.ToString
                BtnSaveDTD.Enabled = True
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnCreateDTD_Click")
        End Try

    End Sub

    Private Sub BtnSaveDTD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveDTD.Click

        Try
            SFD1.Title = "DTD File"
            If InputDir <> "" Then
                SFD1.InitialDirectory = InputDir
                SFD1.FileName = DTDFileName
            End If
            SFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnSaveDTD_Click")
        End Try

    End Sub

    Private Function SaveDTD() As Boolean

        Try
            If SFD1.FileName <> "" Then
                SaveDTD = SaveTextFile(DTDOutFilePath, txtDTDout.Text)
            Else
                MsgBox("Please enter a valid Output File Path", MsgBoxStyle.Information, "No Valid Output Path")
                SaveDTD = False
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv SaveDTD")
            SaveDTD = False
        End Try

    End Function

    Private Sub BtnOpenDTD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnOpenDTD.Click

        Try
            If DTDOutFilePath <> "" Then
                Dim OpenProcess As New System.Diagnostics.Process
                Process.Start(DTDOutFilePath)
            End If

        Catch ex As Exception
            LogError(ex, "FrmXMLConv BtnOpenDTD_Click")
        End Try

    End Sub

#End Region

#Region "XML Events"

    Private Sub TVxml_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVxml.AfterSelect

    End Sub

    Private Sub BtnCreateXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateXML.Click

        Try
            'Convert xml_doc to new string builder text
            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            xml_Indoc.Load(InFilePath)
            sb = New System.Text.StringBuilder
            TxtXMLOut.Text = ""

            If CreateXML(sb, xml_Indoc) = True Then
                TxtXMLOut.Text = sb.ToString
                BtnSaveXML.Enabled = True
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnCreateCSV_Click")
        End Try

    End Sub

    Private Sub BtnSaveXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveXML.Click

        Try
            SFD1.Title = "CSV File"
            If InputDir <> "" Then
                SFD1.InitialDirectory = InputDir
                SFD1.FileName = XMLFileName
            End If
            SFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnSaveXML_Click")
        End Try

    End Sub

    Private Function SaveXML() As Boolean

        Try
            If SFD1.FileName <> "" Then
                SaveXML = SaveTextFile(CSVOutFilePath, TxtCSVout.Text)
            Else
                MsgBox("Please enter a valid Output File Path", MsgBoxStyle.Information, "No Valid Output Path")
                SaveXML = False
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv SaveXML")
            SaveXML = False
        End Try

    End Function

    Private Sub BtnOpenXML_Click(sender As Object, e As EventArgs) Handles BtnOpenXML.Click

        Try
            If XMLOutFilePath <> "" Then
                Dim OpenProcess As New System.Diagnostics.Process
                Process.Start(XMLOutFilePath)
            End If

        Catch ex As Exception
            LogError(ex, "FrmXMLConv BtnOpenXML_Click")
        End Try

    End Sub

#End Region

#Region "JSON Events"

    Private Sub TVjson_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVjson.AfterSelect

    End Sub

    Private Sub BtnCreateJSON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateJSON.Click

        Try
            'Convert xml_doc to new string builder text
            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            xml_Indoc.Load(InFilePath)
            'sb = New System.Text.StringBuilder
            Dim JSONstr As String = ""
            TxtJSONout.Text = ""

            If CreateJSON(JSONstr, xml_Indoc) = True Then
                TxtJSONout.Text = JSONstr
                BtnSaveJSON.Enabled = True
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnCreateCSV_Click")
        End Try

    End Sub

    Private Sub BtnSaveJSON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveJSON.Click

        Try
            SFD1.Title = "JSON File"
            If InputDir <> "" Then
                SFD1.InitialDirectory = InputDir
                SFD1.FileName = JSONFileName
            End If
            SFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnSaveJSON_Click")
        End Try

    End Sub

    Private Function SaveJSON() As Boolean

        Try
            If SFD1.FileName <> "" Then
                SaveJSON = SaveTextFile(JSONOutFilePath, TxtJSONout.Text)
            Else
                MsgBox("Please enter a valid Output File Path", MsgBoxStyle.Information, "No Valid Output Path")
                SaveJSON = False
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv SaveJSON")
            SaveJSON = False
        End Try

    End Function

    Private Sub BtnOpenJSON_Click(sender As Object, e As EventArgs) Handles BtnOpenJSON.Click

        Try
            If JSONOutFilePath <> "" Then
                Dim OpenProcess As New System.Diagnostics.Process
                Process.Start(JSONOutFilePath)
            End If

        Catch ex As Exception
            LogError(ex, "FrmXMLConv BtnOpenJSON_Click")
        End Try

    End Sub

#End Region

#Region "SQL Events"

    Private Sub TVsql_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TVsql.AfterSelect

    End Sub

    Private Sub BtnCreateSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreateSQL.Click

        Try
            'Convert xml_doc to new string builder text
            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            xml_Indoc.Load(InFilePath)
            sb = New System.Text.StringBuilder
            TxTSQLout.Text = ""

            If CreateSQL(sb, xml_Indoc) = True Then
                TxTSQLout.Text = sb.ToString
                BtnSaveSQL.Enabled = True
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnCreateSQL_Click")
        End Try

    End Sub

    Private Sub BtnSaveSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveSQL.Click

        Try
            SFD1.Title = "SQL File"
            If InputDir <> "" Then
                SFD1.InitialDirectory = InputDir
                SFD1.FileName = SQLFileName
            End If
            SFD1.ShowDialog()

        Catch ex As Exception
            LogError(ex, "frmXMLconv BtnSaveSQL_Click")
        End Try

    End Sub

    Private Function SaveSQL() As Boolean

        Try
            If SFD1.FileName <> "" Then
                SaveSQL = SaveTextFile(SQLOutFilePath, TxTSQLout.Text)
            Else
                MsgBox("Please enter a valid Output File Path", MsgBoxStyle.Information, "No Valid Output Path")
                SaveSQL = False
            End If

        Catch ex As Exception
            LogError(ex, "frmXMLconv SaveSQL")
            SaveSQL = False
        End Try

    End Function

    Private Sub BtnOpenSQL_Click(sender As Object, e As EventArgs) Handles BtnOpenSQL.Click

        Try
            If SQLOutFilePath <> "" Then
                Dim OpenProcess As New System.Diagnostics.Process
                Process.Start(SQLOutFilePath)
            End If

        Catch ex As Exception
            LogError(ex, "FrmXMLConv BtnOpenSQL_Click")
        End Try

    End Sub

#End Region

#Region "Old"

    'Private Sub CmdOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) ' Handles CmdOk.Click

    '    Me.Close()
    '    If Save() = True Then
    '        MsgBox("Save was successful", MsgBoxStyle.OkOnly)
    '    End If
    '    Try
    '        If CSVOutFilePath <> "" Then
    '            Dim OpenProcess As New System.Diagnostics.Process
    '            Process.Start(CSVOutFilePath)

    '            'Shell("notepad.exe " & RetCode.SQDPath, AppWinStyle.NormalFocus)
    '        End If

    '    Catch ex As Exception
    '        LogError(ex, "frmXMLconv cmdOk_Click_1")
    '    End Try

    'End Sub

#End Region

End Class
