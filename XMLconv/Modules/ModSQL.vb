Imports System.Xml
Imports System.Data
Imports System.Xml.XPath
Module ModSQL

    Private ArrAllElements As New ArrayList           '** Array of all elements in Document
    Private ArrParentNodes As New ArrayList           '** Array of all elements that are parents of other elements
    Private ArrPrintedChildren As New ArrayList       '** Array of child elements that have children
    Private ArrCDataNodes As New ArrayList            '** Array of child elements that have NO children
    Private ddlOfElements As New ArrayList            '** Array of All Elements with parent objects for Drop Down List
    Private TableName As String
    Private ReadOnly Semi As String = ";"
    Private SQLsb As New System.Text.StringBuilder()
    Private UseXMLval As Boolean
    Private NodeMaster As String = ""

    '/// Enum for open and closed braces and brackets
    Enum OpenClose As Integer
        OPEN = 0
        CLOSE = 1
    End Enum

    Function CreateSQL(ByRef sb As System.Text.StringBuilder, ByRef xmlDoc As Xml.XmlDocument, ByVal UseVal As Boolean, ByVal MasterNode As String) As String

        Try
again:      TableName = InputBox("Please Enter a Table Name", "Table Name", "",,)
            If TableName = "" Then GoTo again
            Dim FORcreate As String = String.Format("{0}{1}{2}", "CREATE ", "TABLE ", TableName)
            Dim First As Boolean = True
            Dim NameFld As String = ""
            UseXMLval = UseVal
            NodeMaster = MasterNode

            wBlankLine()
            SQLsb.AppendLine(FORcreate)
            wBracket(OpenClose.OPEN, True)

            For Each tnode As TreeNode In FrmXMLconv.TVsql.Nodes
                If tnode.Nodes.Count = 0 Then
                    Dim FldName As String = ""
                    If UseXMLval = True Then
                        FldName = CType(tnode.Tag, ClsXMLNode).Node.InnerText
                    Else
                        FldName = CType(tnode.Tag, ClsXMLNode).Node.LocalName
                    End If
                    If First = True Then
                        NameFld = " " & NodeMaster & "_" & FldName
                        First = False
                    Else
                        NameFld = "," & NodeMaster & "_" & FldName
                    End If
                    Dim ForFldLine As String = String.Format("{0,-10}{1}{2}", " ", NameFld, " varchar(50)")
                    SQLsb.AppendLine(ForFldLine)
                Else
                    For Each tnd As TreeNode In tnode.Nodes
                        ProcessTreeChildNodes(tnode, First)
                    Next
                End If
            Next

            wBracket(OpenClose.CLOSE, True)
            wSemiLine()

            sb = SQLsb

            Return TableName

        Catch ex As Exception
            LogError(ex, "ModSQL CreateSQl")
            Return ""
        End Try

    End Function

    Sub ProcessTreeChildNodes(ctn As TreeNode, ByVal First As Boolean)

        Try
            Dim FldName As String = ""
            Dim NameFld As String = ""
            Dim FldPre As String = ""

            For Each tnd As TreeNode In ctn.Nodes
                If tnd.Text = NodeMaster Then
                    FldPre = CType(tnd.Tag, ClsXMLNode).Node.InnerText
                    Exit For
                End If
            Next
            If ctn.Nodes.Count = 0 Then
                If ctn.Checked Then
                    If UseXMLval = True Then
                        FldName = CType(ctn.Tag, ClsXMLNode).Node.InnerText
                    Else
                        FldName = CType(ctn.Tag, ClsXMLNode).Node.LocalName
                    End If
                    If First = True Then
                        NameFld = " " & FldPre & "_" & FldName
                        First = False
                    Else
                        NameFld = "," & FldPre & "_" & FldName
                    End If
                    Dim ForFldLine As String = String.Format("{0,-10}{1,-25}{2}", " ", NameFld, " varchar(50)")
                    SQLsb.AppendLine(ForFldLine)
                End If
            Else
                For Each cn As TreeNode In ctn.Nodes
                    ProcessTreeChildNodes(cn, First)
                Next
            End If

        Catch ex As Exception
            LogError(ex, "ModSQL ProcessTreeChildNodes")
        End Try

    End Sub

#Region "Helper Functions and subs"

    Function wBlankLine() As Boolean

        Try
            SQLsb.AppendLine()
            wBlankLine = True

        Catch ex As Exception
            LogError(ex, "ModSQL wBlankLine")
            wBlankLine = False
        End Try

    End Function

    Function wSemiLine() As Boolean

        Try
            SQLsb.AppendLine(Semi)
            wSemiLine = True

        Catch ex As Exception
            LogError(ex, "ModSQL wSemiLine")
            wSemiLine = False
        End Try

    End Function

    Function wBrace(ByVal OC As OpenClose, ByVal NewLine As Boolean) As Boolean

        Try
            If OC = OpenClose.OPEN Then
                If NewLine = True Then
                    SQLsb.AppendLine("{")
                Else
                    SQLsb.Append("{")
                End If
            Else
                If NewLine = True Then
                    SQLsb.AppendLine("}")
                Else
                    SQLsb.Append("}")
                End If
            End If
            wBrace = True

        Catch ex As Exception
            LogError(ex, "ModSQL wBrace")
            wBrace = False
        End Try

    End Function

    Function wBracket(ByVal OC As OpenClose, ByVal NewLine As Boolean) As Boolean

        Try
            If OC = OpenClose.OPEN Then
                If NewLine = True Then
                    SQLsb.AppendLine("(")
                Else
                    SQLsb.Append("(")
                End If
            Else
                If NewLine = True Then
                    SQLsb.AppendLine(")")
                Else
                    SQLsb.Append(")")
                End If
            End If
            wBracket = True

        Catch ex As Exception
            LogError(ex, "ModSQL wBracket")
            wBracket = False
        End Try

    End Function

#End Region

End Module