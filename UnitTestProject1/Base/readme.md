# About

**Base\TestBase.vb**

This class is used in each test class for creating an instance of [TestContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.testcontext?view=mstest-net-1.3.2).

TestContext provides access to the current test name which can be used in a method using &lt;`TestInitialize`&gt; responsible for a method which runs before each test method and &lt;`TestCleanup`&gt; for after a test has completed.

---

**Base\MainTest.vb**

Example where the `Async` and `Task` can be non-async. In this case all that is being done is writing to the console. Consider instead a file needs to be reset or a database table needs to be cleaned up, this might be done here by calling a helper method.

```
<TestInitialize>
Public Async Function Init() As Task
    If TestContext.TestName = "TestMethod1" Then
        Await Task.Delay(0)
        Console.WriteLine("Called before TestMethod1")
    End If
End Function
```
</br>

```
<TestCleanup>
Public Sub TestCleanup()
    If TestContext.TestName = "TestMethod1" Then
        Console.WriteLine($"TestCleanup: {TestContext.TestName}")
    Else
        Console.WriteLine("In test cleanup but don't care what test it is.")
    End If

End Sub
```

Similarly there are events for initializing a unit class and cleanup.

---

**Base\TestTraitsAttribute**

This class along with the Enum `Trait` provide traits visible in `Test Explorer`
