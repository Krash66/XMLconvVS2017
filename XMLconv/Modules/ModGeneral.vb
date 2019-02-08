Public Module ModGeneral

#Region "Mylist Class"

    ''' <summary>
    ''' Simple list of objects and their names
    ''' </summary>
    ''' <remarks>Useful for small collections, dropdown lists, etc...</remarks>
    Public Class Mylist

        Private sName As String
        ' You can also declare this as String,bitmap or almost anything. 
        ' If you change this delcaration you will also need to change the Sub New 
        ' to reflect any change. Also the ItemData Property will need to be updated. 
        Private iID As Object

        ''' <summary>
        ''' Default empty constructor. 
        ''' </summary>
        ''' <remarks>Defines new list of objects</remarks>
        Public Sub New()
            sName = ""
            ' This would need to be changed if you modified the declaration above. 
            iID = 0
        End Sub

        ''' <summary>
        ''' Contructor with item definition
        ''' </summary>
        ''' <param name="Name">Text Name</param>
        ''' <param name="ID">Object</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal Name As String, ByVal ID As Object)
            sName = Name
            iID = ID
        End Sub

        Public Property Name() As String
            Get
                Return sName
            End Get
            Set(ByVal sValue As String)
                sName = sValue
            End Set
        End Property

        ' This is the property that holds the extra data. 
        Public Property ItemData() As Object
            Get
                Return iID
            End Get
            Set(ByVal iValue As Object)
                iID = iValue
            End Set
        End Property

        ' This is neccessary because the ListBox and ComboBox rely 
        ' on this method when determining the text to display. 
        Public Overrides Function ToString() As String
            Return sName
        End Function

    End Class

#End Region

End Module
