Option Strict On
Option Explicit On
Imports System.Xml
Public Class ClsXMLNode
    Private ReadOnly _Name As String
    Private _Node As XmlNode
    Private _Children As ArrayList
    Private _NodeParent As XmlNode
    Private _Parent As ClsXMLNode
    Private _ElementValue As XmlCharacterData
    Private _Siblings As ArrayList
    Private _GUID As Guid
    Private _TVnode As TreeNode
    Private ReadOnly _FamilyLine As String

#Region "Properties"

    Public Property GUID As Guid
        Get
            Return _GUID
        End Get
        Set(value As Guid)
            _GUID = value
        End Set
    End Property

    Public ReadOnly Property Name As String
        Get
            Return Node.LocalName
        End Get
    End Property

    Public Property Node As XmlNode
        Get
            Return _Node
        End Get
        Set
            _Node = Value
        End Set
    End Property

    Property NodeParent As XmlNode
        Get
            Return _NodeParent
        End Get
        Set
            _NodeParent = Value
        End Set
    End Property

    Public Property Parent As ClsXMLNode
        Get
            Return _Parent
        End Get
        Set(value As ClsXMLNode)
            _Parent = value
        End Set
    End Property

    Property Children As ArrayList
        Get
            Return _Children
        End Get
        Set
            _Children = Value
        End Set
    End Property

    Public Property Siblings As ArrayList
        Get
            Return _Siblings
        End Get
        Set
            _Siblings = Value
        End Set
    End Property

    Property ElementValue As XmlCharacterData
        Get
            Return _ElementValue
        End Get
        Set
            _ElementValue = Value
        End Set
    End Property

    Public ReadOnly Property FamilyLine As String
        Get
            Return GetFamilyTree()
        End Get
    End Property

    Public Property TVnode As TreeNode
        Get
            Return _TVnode
        End Get
        Set(value As TreeNode)
            _TVnode = value
        End Set
    End Property

#End Region

#Region "Methods"

    Friend Function GetFamilyTree() As String
        If Me.Parent IsNot Nothing Then
            Return Me.Parent.FamilyLine & "." & Me.Name
        Else
            Return Me.Name
        End If
    End Function

#End Region

#Region "New"

    Sub New()
        Me.GUID = New Guid
    End Sub

    Sub New(ByRef Xnode As XmlNode)
        GUID = New Guid
        Node = Xnode
        NodeParent = Node.ParentNode
    End Sub

    Sub New(ByRef Xnode As XmlNode, ByRef Tnode As TreeNode)
        GUID = New Guid
        Node = Xnode
        NodeParent = Node.ParentNode
        TVnode = Tnode
    End Sub

#End Region

End Class
