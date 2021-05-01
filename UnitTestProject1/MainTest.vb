Imports System.IO
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Text
Imports UnitTestProject1.Base
Imports UnitTestProject1.LanguageExtensions

<TestClass()> Partial Public Class MainTest

    <TestMethod()>
    <TestTraits(Trait.IfStatements)>
    Public Sub TestMethod1()
        Assert.IsFalse(File.Exists(TransactionJsonFile))
    End Sub
    <TestMethod()>
    <TestTraits(Trait.Employee)>
    Public Sub Found_Single_Employee()
        '
        ' Arrange
        '
        Dim peep = People()
        Dim firstName = "Bob"
        Dim lastName = "Gallagher"

        '
        ' Act
        '
        Dim foundPerson = peep.FirstOrDefault(Function(person) person.FirstName = firstName AndAlso person.LastName = lastName)

        '
        ' Assert
        '
        Assert.IsTrue(foundPerson IsNot nothing,$"{NameOf(Found_Single_Employee)} expected to find a person")

    End Sub
    <TestMethod()>
    <TestTraits(Trait.Employee)>
    Public Sub Not_Found_Single_Employee()
        '
        ' Arrange
        '
        Dim peep = People()
        Dim firstName = "Jim"
        Dim lastName = "Gallagher"

        '
        ' Act
        '
        Dim foundPerson = peep.FirstOrDefault(Function(person) person.FirstName = firstName AndAlso person.LastName = lastName)

        '
        ' Assert
        '
        Assert.IsFalse(foundPerson IsNot nothing,$"{NameOf(Not_Found_Single_Employee)} expected to not find a person")

    End Sub
    <TestMethod>
    <TestTraits(Trait.Strings)>
    Public Sub String_Comparing1()

        Dim test1 = "Adam"
        Dim test2 = "adam"

        Assert.IsFalse(test1 = test2)
        Assert.IsTrue(test1.EqualsIgnoreCase(test2))

    End Sub
End Class