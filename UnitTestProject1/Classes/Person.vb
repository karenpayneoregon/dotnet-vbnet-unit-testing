Imports UnitTestProject1.Interfaces

Namespace Classes

    Public Class Person
        Implements IPerson

        Public Property Id() As Integer Implements IPerson.Id
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property HireDate() As DateTime
        Public ReadOnly Property FullName() As String
            Get
                Return $"{FirstName} {LastName}"
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return $"{Id} {FullName}"
        End Function
    End Class
End Namespace