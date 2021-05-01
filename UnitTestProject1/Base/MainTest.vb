Imports UnitTestProject1.Classes
Imports UnitTestProject1.Helpers

Partial Public Class MainTest
    Inherits TestBase

    Public Sub New()
        Console.WriteLine($"New constructor for {NameOf(MainTest)}")
    End Sub
    <TestInitialize>
    Public Async Function Init() As Task
        If TestContext.TestName = "TestMethod1" Then
            Await Task.Delay(0)
            Console.WriteLine("Called before TestMethod1")
        End If
    End Function

    <TestCleanup>
    Public Sub TestCleanup()
        If TestContext.TestName = "TestMethod1" Then
            Console.WriteLine($"TestCleanup: {TestContext.TestName}")
        Else
            Console.WriteLine("In test cleanup but don't care what test it is.")
        End If

    End Sub
    <ClassInitialize()>
    Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
        TestResults = New List(Of TestContext)()
    End Sub
    <ClassCleanup()>
    Public Shared Async Function ClassCleanup() As Task
        Await Task.Delay(0)
    End Function

    Public Shared TransactionJsonFile As String = "IccTransData.json"
    Public Shared Function People As List(Of Person) 
        Return Mocked.PeopleList()
    End Function
End Class
