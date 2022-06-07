Imports System

Module Program
    Sub Main(args As String())
        Dim firstName As String
        Dim lastName As String
        Console.WriteLine("Enter your first name: ")
        firstName = Console.ReadLine()
        Console.WriteLine("Enter your last name: ")
        lastName = Console.ReadLine()

        Console.WriteLine($"Hello, {firstName} {lastName}!")
    End Sub
End Module
