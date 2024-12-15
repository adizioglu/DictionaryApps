Imports System

Module Program
    Sub Main(args As String())

        Dim lookup As New Dictionary(Of String, String)()

        lookup("animal") = "Not a human"
        lookup("fish") = "Not a human that swims"
        lookup("human") = "Us"

        Console.WriteLine($"The definition of fish is {lookup("fish")}")


        Dim employees As New Dictionary(Of Integer, String)()

        employees(95) = "Tim Corey"
        employees(28) = "Sue Storm"

        Console.WriteLine($"The employee with ID number 28 is {employees(28)}")


        Dim dayOfWeek As New Dictionary(Of String, Integer)()

        dayOfWeek("Wednesday") = 4
        dayOfWeek("Thursday") = 5
        dayOfWeek("Friday") = 6

        Console.WriteLine($"Wednesday is day number {dayOfWeek("Wednesday")}")

    End Sub
End Module
