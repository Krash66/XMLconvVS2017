Option Strict On
Option Explicit On
Imports System.Xml
Public Class ClsXMLelement
    Private ReadOnly _Name As String
    Private _Node As XmlNode
    Private _Children As ArrayList
    Private _Parent As ClsXMLelement
    Private _ElementValue As XmlCharacterData
    Private _Siblings As ArrayList
    Private ReadOnly _FamilyLine As String

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

    Property Parent As ClsXMLelement
        Get
            Return _Parent
        End Get
        Set
            _Parent = Value
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

    Friend Function GetFamilyTree() As String
        Return Me.Parent.FamilyLine & "." & Me.Name
    End Function

End Class
