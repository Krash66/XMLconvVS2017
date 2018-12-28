Imports System.Data
Imports System.Xml
Imports System.Xml.XPath
Module ModEditXML

#Region "XML Message Processing"

    '/// *** Created by TK   November 2011
    '/// *** Creates XML DTD files from XML messages
    '/// Main function:
    '/// -- Function ProcessXMLmessage(ByVal InfilePath As String, ByVal DirOut As String) As String
    '/// Arguments: 
    '/// -- InfilePath --> Path of the XML Message file to convert to DTD
    '/// -- DirOut     --> Path of Output Directory to Put new DTD file into
    '/// Return Value:
    '/// -- String Value of the complete filepath of the New DTD file 
    '/// -- or "" if no new file wanted or no new file was created, by user choice or by Error

    Private InFilePath As String                   '** Input XML Message File Path
    Private OutFilePath As String                  '** Output DTD XML Description File
    Private OutDir As String                       '** Output Directory for the new DTD file
    Private xml_Indoc As New XmlDocument           '** Windows XML doc that XML message is read into

    Private ArrAllElements As New ArrayList        '** Array of all elements in Document
    Private ArrParentNodes As New ArrayList        '** Array of all elements that are parents of other elements
    Private ArrPrintedChildren As New ArrayList    '** Array of child elements that have children
    Private ArrCDataNodes As New ArrayList         '** Array of child elements that have NO children
    Private InputDir As String = ""                '** Input Directory of the XML Message
    Private sbldr As System.Text.StringBuilder     '** String Builder Object that is built to create DTD message

    Private Enum enumXMLActionType
        Failed = 0
        E_PrintwCldrn = 1
        E_PrintAsCdata = 2
        E_Ignore = 3
    End Enum

    Public Function ProcessXMLmessage(ByVal InfilePath As String, ByVal DirOut As String) As String

        Try
            ArrAllElements.Clear()
            ArrParentNodes.Clear()
            ArrPrintedChildren.Clear()
            ArrCDataNodes.Clear()

            '            OutDir = DirOut
            '            sbldr = New System.Text.StringBuilder

            '            'Convert xml_doc to new string builder text
            '            'EncodeXMLFile(InFilePath) '//encode some special characters like & to &amp;
            '            xml_Indoc.Load(InfilePath)

            '            '*** Create a new filepath of the DTD named the same as the XML Message
            '            '*** in the new output directory
            '            OutFilePath = OutDir & "\" & GetFileNameWithoutExtenstionFromPath(InfilePath) & ".dtd"

            '            '*** See if the DTD file already exists
            '            '*** If so ask user how to proceed
            'TryAgain:   If System.IO.File.Exists(OutFilePath) = True Then
            '                Dim result As MsgBoxResult
            '                result = MsgBox("The file: " &
            '                                GetFileNameFromPath(OutFilePath) &
            '                                " Already exists." & Chr(13) & Chr(13) &
            '                                " (Yes) Create a new DTD with a new Name." & Chr(13) &
            '                                " (No) Overwrite Existing File." & Chr(13) &
            '                                " (Cancel) Use Existing File.",
            '                                MsgBoxStyle.YesNoCancel,
            '                                "DTD File Already Exists. Create New, Overwrite or Use Existing.")
            '                '*** Process result of MsgBox ***
            '                Select Case result
            '                    Case MsgBoxResult.Yes
            '                        '*** Get New name from InputBox and insert it into the OutFilePath
            '                        OutFilePath = GetDirFromPath(OutFilePath) &
            '                        InputBox("Enter New Name (no extension) for .dtd File",
            '                                 "Rename DTD file",
            '                                 GetFileNameWithoutExtenstionFromPath(OutFilePath)) &
            '                                 ".dtd"
            '                        GoTo TryAgain
            '                    Case MsgBoxResult.Cancel
            '                        '*** Don't build a new DTD
            '                        '*** Use the existing file, Return the Path, and EXIT
            '                        ProcessXMLmessage = OutFilePath
            '                        Exit Try
            '                    Case Else
            '                        'Overwrite will happen automatically
            '                End Select
            '            End If

            'Start processing each node in the Message
            If xml_Indoc.HasChildNodes = True Then
                For Each nd As XmlNode In xml_Indoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = XmlNodeType.Element Then
                        If processNode(nd) = False Then
                            ProcessXMLmessage = ""
                            Exit Function
                        End If
                    End If
                Next 'next doc child
            End If

            'If printCData(ArrCDataNodes) = True Then
            '    If SaveTextFile(OutFilePath, sbldr.ToString) = True Then
            '        '***** Success ***** return the dtd file Path
            '        ProcessXMLmessage = OutFilePath
            '    Else
            '        ProcessXMLmessage = ""
            '    End If
            'Else
            '    ProcessXMLmessage = ""
            'End If

        Catch ex As Exception
            'LogError(ex, "modXML ProcessXMLmessage")
            ProcessXMLmessage = ""
        End Try

    End Function

    Private Function processNode(ByVal Node As XmlNode) As Boolean

        Try
            Dim Action As enumXMLActionType = GetNodeAction(Node)

            Select Case Action
                Case enumXMLActionType.E_PrintwCldrn

                    '*** Print the Element with it's children
                    printNodeWithChildren(Node)
                    '*** Now process the Children
                    For Each cld As XmlNode In Node.ChildNodes
                        processNode(cld)
                    Next

                Case enumXMLActionType.E_PrintAsCdata
                    Dim QualName As String = GetCDataName(Node)
                    ArrCDataNodes.Add(QualName)

                Case enumXMLActionType.E_Ignore
                    '*** Do Nothing except goto next sibling or parent

                Case enumXMLActionType.Failed
                    If MsgBox("Translation failed at Element: " & Node.Name & Chr(13) &
                           "Would you like to continue processing?",
                           MsgBoxStyle.YesNo,
                           "Translation Failed") = MsgBoxResult.No Then
                        '*** abort here
                        Return False
                        Exit Function
                    End If

            End Select

            Return True

        Catch ex As Exception
            'LogError(ex, "modXML processNode")
            Return False
        End Try

    End Function

    Private Function GetNodeAction(ByVal nd As XmlNode) As enumXMLActionType

        Try
            Dim IsParentElement As Boolean = False

            If nd.HasChildNodes = True Then
                Dim NumEle As Integer = 0
                For Each node As XmlNode In nd.ChildNodes
                    If node.NodeType = XmlNodeType.Element Then
                        If node.HasChildNodes = True Then
                            If node.FirstChild.NodeType = XmlNodeType.Element Then
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
                If nd.NodeType = XmlNodeType.Element Then
                    GetNodeAction = enumXMLActionType.E_PrintAsCdata
                Else
                    GetNodeAction = enumXMLActionType.E_Ignore
                    'Log("XML node:  " & nd.LocalName & "  was Ignored")
                End If
            End If


        Catch ex As Exception
            'LogError(ex, "modXML GetNodeAction")
            GetNodeAction = enumXMLActionType.Failed
            sbldr.AppendLine("   --- Node action Failed ::" & nd.Name)
            sbldr.AppendLine("   --- Check XML Message for Syntax Errors")
        End Try

    End Function

    Private Function GetElementName(ByVal nd As XmlNode) As String

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
            'LogError(ex, "modXML GetNameToAdd")
            GetElementName = ""
        End Try

    End Function

    Private Function GetChildName(ByVal nd As XmlNode) As String

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
            'LogError(ex, "modXML GetChildName")
            GetChildName = ""
        End Try

    End Function

    Private Function GetCDataName(ByVal nd As XmlNode) As String

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
            'LogError(ex, "modXML GetCDataNameToAdd")
            GetCDataName = ""
        End Try

    End Function

    Private Function printNodeWithChildren(ByVal node As XmlNode) As Boolean

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
                sbldr.AppendLine(Line1)
                sbldr.AppendLine(Line2)
                For Each cld As XmlNode In node.ChildNodes
                    If cld.NodeType = XmlNodeType.Element Then
                        ChildElementName = GetChildName(cld)
                        Dim LineChild As String = String.Format("{0}{1}", Prefix, ChildElementName)
                        sbldr.AppendLine(LineChild)
                        Prefix = "    ,"
                        '*** Add children to the child array
                        ArrAllElements.Add(ChildElementName)
                        ArrPrintedChildren.Add(ChildElementName)
                    End If
                Next
                sbldr.AppendLine(LastLine)
                sbldr.AppendLine()

                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            'LogError(ex, "modXML printNode")
            Return False
        End Try

    End Function

    Private Function printCData(ByVal Arr As ArrayList) As Boolean

        Try
            Dim FORfld As String

            For Each name As String In Arr
                FORfld = String.Format("{0}{1,-40}{2}", "<!ELEMENT ", name, " (#PCDATA)>")
                sbldr.AppendLine(FORfld)
            Next

            Return True

        Catch ex As Exception
            'LogError(ex, "modXML printCData")
            Return False
        End Try

    End Function

#End Region
End Module
