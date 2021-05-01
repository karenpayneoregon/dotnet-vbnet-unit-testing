Imports UnitTestProject1.Classes

Namespace Helpers
    ''' <summary>
    ''' Responsible for creating containers to use in various test methods
    ''' </summary>
    Public Class Mocked
        Public Shared Function PeopleList() As List(Of Person)

            Dim employees = New List(Of Employee)() From {
                    New Employee() With {.Id = 1,.FirstName = "Joe",.LastName = "Jones",.HireDate = New DateTime(2018,12,1),.ReportsTo = 5},
                    New Employee() with {.Id = 2,.FirstName = "Mary",.LastName = "Smith",.HireDate = New DateTime(2018,9,1),.ReportsTo = 5},
                    New Employee() With {.Id = 3,.FirstName = "Nancy",.LastName = "Ravioli",.HireDate = New DateTime(2017,4,12),.ReportsTo = 6},
                    New Employee() With {.Id = 4,.FirstName = "Andrew",.LastName = "Fuller",.HireDate = New DateTime(2019,7,2),.ReportsTo = 6},
                    New Employee() With {.Id = 7,.FirstName = "Steven",.LastName = "Buchanan",.HireDate = New DateTime(2015,5,16),.ReportsTo = 5},
                    New Employee() With  {.Id = 9,.FirstName = "Karen",.LastName = "Stone",.HireDate = New DateTime(2020,5,16),.ReportsTo = 8}
            }

            Dim people = New List(Of Person)() From {
                        New Manager() With {.Id = 5,.FirstName = "Anne",.LastName = "Wordsworth",.HireDate = New DateTime(2015,7,2),.YearsAsManager = 3,.Employees = employees.Take(2).ToList()},
                        New Manager() With {.Id = 6,.FirstName = "Bob",.LastName = "Gallagher",.HireDate = New DateTime(2014,7,2),.YearsAsManager = 4,.Employees = employees.Skip(2).Take(2).ToList()},
                        New Manager() With {.Id = 8,.FirstName = "Michael",.LastName = "Suyama",.HireDate = New DateTime(2014,7,2),.YearsAsManager = 1,.Employees = employees.Skip(employees.Count -1).Take(1).ToList()}
                    }

            people.AddRange(employees)

            Return people

        End Function

    End Class
End NameSpace