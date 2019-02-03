Imports System

Public Class Application
	Public Shared Sub Main()
		Dim Num1, Num2, Sum As Integer

        Console.WriteLine("Please enter your first number;")

                Num1 = CInt(Console.ReadLine())
        Console.WriteLine()

        Console.WriteLine("Please enter your second number;")
        Num2 = CInt(Console.ReadLine())
        Console.WriteLine()

        Console.WriteLine("Please choose an operator;")
        Console.WriteLine("1 - Add (+)")
        Console.WriteLine("2 - Subtract (-)")
        Console.WriteLine("3 - Mulitiplication (*)")
        Console.WriteLine("4 - Division(/)")
        Sum = CInt(Console.ReadLine())
        Console.WriteLine()

        Console.WriteLine("****************YOUR ANSWER***************")
            If Sum = 1 Then
                Console.WriteLine(Num1 & " + " & Num2 & " = " & Num1 + Num2)
                ElseIf Sum = 2 Then
                Console.WriteLine(Num1 & " - " & Num2 & " = " & Num1 - Num2)
                ElseIf Sum = 3 Then
                Console.WriteLine(Num1 & " * " & Num2 & " = " & Num1 * Num2)
                ElseIf Sum = 4 Then
                Console.WriteLine(Num1 & " / " & Num2 & " = " & Num1 / Num2)
            End If
         Console.WriteLine("*****************************************")
         Console.ReadLine()
     End Sub
 End Class  
