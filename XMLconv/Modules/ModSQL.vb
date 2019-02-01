Imports System.Xml
Imports System.Data
Imports System.Xml.XPath
Module ModSQL

    Private ArrAllElements As New ArrayList           '** Array of all elements in Document
    Private ArrParentNodes As New ArrayList           '** Array of all elements that are parents of other elements
    Private ArrPrintedChildren As New ArrayList       '** Array of child elements that have children
    Private ArrCDataNodes As New ArrayList            '** Array of child elements that have NO children
    Private ddlOfElements As New ArrayList            '** Array of All Elements with parent objects for Drop Down List

    Function CreateSQL(ByRef sb As System.Text.StringBuilder, ByRef xmlDoc As Xml.XmlDocument) As Boolean

        Try

        Catch ex As Exception
            LogError(ex, "ModSQL CreateSQl")
        End Try

    End Function

End Module