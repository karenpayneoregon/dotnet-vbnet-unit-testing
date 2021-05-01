Public Class TestBase
    Protected TestContextInstance As TestContext
    Public Property TestContext() As TestContext
        Get
            Return TestContextInstance
        End Get
        Set(ByVal value As TestContext)
            TestContextInstance = value
            TestResults.Add(TestContext)
        End Set
    End Property

    Public Shared TestResults As IList(Of TestContext)
End Class
