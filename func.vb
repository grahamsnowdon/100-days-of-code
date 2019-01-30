Module Module1
    Sub Main()
        Dim num1, num2 As Integer
        Console.WriteLine("Enter the first number: ")
        num1 = Console.ReadLine
        Console.WriteLine("Enter the second number: ")
        num2 = Console.ReadLine
        Console.WriteLine("The floor number is: " & floor(num1, num2))
        Console.ReadLine()
    End Sub

    Function floor(ByVal a As Integer, ByVal b As Integer)
        Dim f As Integer
        f = a - b
        If f > 0 Then Return f Else Return 0
    End Function
End Module
