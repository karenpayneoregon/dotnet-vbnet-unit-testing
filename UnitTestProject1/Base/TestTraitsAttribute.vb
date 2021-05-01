Namespace Base
    Public Enum Trait
        PlaceHolder
        IfStatements
        Employee
        Strings
    End Enum
    ''' <summary>
    ''' Declarative class for using Trait enum about for traits on test method.
    ''' </summary>
    Public Class TestTraitsAttribute
        Inherits TestCategoryBaseAttribute

        Private ReadOnly _traits() As Trait

        Public Sub New(ParamArray traits() As Trait)
            _traits = traits
        End Sub

        Public Overrides ReadOnly Property TestCategories() As IList(Of String)
            Get
                Return _traits.Select(Function(trait) [Enum].GetName(GetType(Trait), trait)).ToList()
            End Get
        End Property
    End Class
End Namespace