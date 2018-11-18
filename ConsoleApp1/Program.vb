Imports System

Module Program
    Public num1 As Integer
    Public num2 As Integer
    Public answer As Integer
    Sub Main(args As String())
        Console.WriteLine(vbCrLf + "What is your name? ")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}")

        Console.WriteLine($"{name}, type a number and press Enter")
        num1 = Console.ReadLine()
        Console.WriteLine($"{name}, type another number to add to it and press Enter")
        num2 = Console.ReadLine()
        answer = num1 + num2
        Console.WriteLine($"{name}, the answer is " & answer)
        Console.Write(vbCrLf + "Press any key to exit... ")
        Console.ReadKey(True)
    End Sub
End Module
