Option Strict On
Option Explicit On

Imports System
Imports System.IO
Imports System.Xml
Public Class clsXMLelement

    Property Name As String
    Property Parent As clsXMLelement
    Property Children As XmlNodeList
    Property ElementValue As XmlCharacterData


End Class
