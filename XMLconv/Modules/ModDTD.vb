Module ModDTD

    Private ArrAllElements As New ArrayList           '** Array of all elements in Document
    Private ArrParentNodes As New ArrayList           '** Array of all elements that are parents of other elements
    Private ArrPrintedChildren As New ArrayList       '** Array of child elements that have children
    Private ArrCDataNodes As New ArrayList            '** Array of child elements that have NO children
    Private ddlOfElements As New ArrayList            '** Array of All Elements with parent objects for Drop Down List

    Private sbDTD As New System.Text.StringBuilder           '** String Builder Object that is built to create DTD message

    Function CreateDTD(ByRef sb As System.Text.StringBuilder, ByRef xmlDoc As Xml.XmlDocument) As Boolean

        Try
            'Clear all arrays
            ArrAllElements.Clear()
            ArrParentNodes.Clear()
            ArrPrintedChildren.Clear()
            ArrCDataNodes.Clear()

            'Start processing each node in the Message           
            If xmlDoc.HasChildNodes = True Then
                For Each nd As Xml.XmlNode In xmlDoc.ChildNodes
                    '*** Process each Node, if it is an element
                    '*** if it's not an element, ignore it
                    If nd.NodeType = Xml.XmlNodeType.Element Then
                        ProcessNode(nd)
                    End If
                Next 'next doc child
            End If

            If PrintCData(ArrCDataNodes) = True Then
                sb = sbDTD
                Return True
            Else
                sb = Nothing
                Return False
            End If

        Catch ex As Exception
            LogError(ex, "ModDTD CreateDTD")
            sb = Nothing
            Return False
        End Try

    End Function

    Friend Function ProcessNode(ByVal Node As Xml.XmlNode) As Boolean

        Try
            Dim Action As EnumXMLActionType = GetNodeAction(Node)
            'Dim ElementValue As String = Node.InnerText

            Select Case Action
                Case EnumXMLActionType.E_PrintwCldrn

                    '*** Print the Element with it's children
                    PrintNodeWithChildren(Node)
                    '*** Now process the Children
                    For Each cld As Xml.XmlNode In Node.ChildNodes
                        'sb.AppendLine()
                        'sb.AppendLine("   ***Child = " & cld.Name)
                        'sb.AppendLine("   ***Of Parent = " & Node.Name)
                        'sb.AppendLine("   ***Sent to processNode")
                        'sb.AppendLine()
                        ProcessNode(cld)
                    Next

                Case EnumXMLActionType.E_PrintAsCdata
                    Dim QualName As String = GetCDataName(Node)
                    'Dim ArrayName As String = String.Format("{0,-32}{1, -8}{2,-40}", QualName, ",  value:,", ElementValue)
                    ArrCDataNodes.Add(QualName)
                    'ArrAllElements.Add(QualName)

                Case EnumXMLActionType.E_Ignore
                    '*** Do Nothing except goto next sibling or parent

                Case EnumXMLActionType.Failed
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
            LogError(ex, "ModDTD processNode")
            Return False
        End Try

    End Function

    Friend Function GetNodeAction(ByVal nd As Xml.XmlNode) As EnumXMLActionType

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
                            GetNodeAction = EnumXMLActionType.E_PrintwCldrn
                            Exit Function
                        End If
                    End If
                Next
                If IsParentElement = True Then
                    GetNodeAction = EnumXMLActionType.E_PrintwCldrn
                Else
                    GetNodeAction = EnumXMLActionType.E_PrintAsCdata
                End If
            Else
                If nd.NodeType = Xml.XmlNodeType.Element Then
                    GetNodeAction = EnumXMLActionType.E_PrintAsCdata
                Else
                    GetNodeAction = EnumXMLActionType.E_Ignore
                End If
            End If

        Catch ex As Exception
            LogError(ex, "ModDTD GetNodeAction")
            GetNodeAction = EnumXMLActionType.Failed
            FrmXMLconv.sb.AppendLine("   --- Node action Failed ::" & nd.Name)
            FrmXMLconv.sb.AppendLine()
        End Try

    End Function

    Friend Function GetElementName(ByVal nd As Xml.XmlNode) As String

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
            LogError(ex, "ModDTD GetNameToAdd")
            GetElementName = ""
        End Try

    End Function

    Friend Function GetChildName(ByVal nd As Xml.XmlNode) As String

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
            LogError(ex, "ModDTD GetChildName")
            GetChildName = ""
        End Try

    End Function

    Friend Function GetCDataName(ByVal nd As Xml.XmlNode) As String

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
            LogError(ex, "ModDTD GetCDataNameToAdd")
            GetCDataName = ""
        End Try

    End Function

    Friend Function PrintNodeWithChildren(ByVal node As Xml.XmlNode) As Boolean

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
                sbDTD.AppendLine(Line1)                                        'Uncomment For DTD convert
                sbDTD.AppendLine(Line2)                                        'Uncomment For DTD convert
                For Each cld As Xml.XmlNode In node.ChildNodes
                    If cld.NodeType = Xml.XmlNodeType.Element Then
                        ChildElementName = GetChildName(cld)
                        Dim LineChild As String = String.Format("{0}{1}", Prefix, ChildElementName)
                        sbDTD.AppendLine(LineChild)                                        'Uncomment For DTD convert
                        Prefix = "    ,"                                        'Uncomment For DTD convert
                        '*** Add children to the child array
                        ArrAllElements.Add(ChildElementName)
                        ArrPrintedChildren.Add(ChildElementName)
                    End If
                Next
                sbDTD.AppendLine(LastLine)                                        'Uncomment For DTD convert
                sbDTD.AppendLine()                                        'Uncomment For DTD convert

                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            LogError(ex, "ModDTD printNode")
            Return False
        End Try

    End Function

    Friend Function PrintCData(ByVal Arr As ArrayList) As Boolean

        Try
            Dim FORfld As String

            For Each name As String In Arr
                FORfld = String.Format("{0}{1,30}{2,-100}", "<!ELEMENT ", name, " (#PCDATA)>")
                'FORfld = String.Format("{0}{1,30}", "Name:, ", name)
                sbDTD.AppendLine(FORfld)
            Next

            Return True

        Catch ex As Exception
            LogError(ex, "ModDTD printCData")
            Return False
        End Try

    End Function

End Module
