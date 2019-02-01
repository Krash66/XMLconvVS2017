Imports System.Xml
Imports System.Data
Imports System.Xml.XPath
Module ModJSON

    Private ArrAllElements As New ArrayList           '** Array of all elements in Document
    Private ArrParentNodes As New ArrayList           '** Array of all elements that are parents of other elements
    Private ArrPrintedChildren As New ArrayList       '** Array of child elements that have children
    Private ArrCDataNodes As New ArrayList            '** Array of child elements that have NO children
    Private ddlOfElements As New ArrayList            '** Array of All Elements with parent objects for Drop Down List

    Function CreateJSON(ByRef JSONstr As String, ByRef xmlDoc As Xml.XmlDocument) As Boolean

        Try
            JSONstr = Newtonsoft.Json.JsonConvert.SerializeObject(xmlDoc, Newtonsoft.Json.Formatting.Indented)
            If JSONstr <> "" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            LogError(ex, "ModJSON CreateJSON")
            Return False
        End Try

    End Function

End Module