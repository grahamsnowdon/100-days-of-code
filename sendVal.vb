Module Module1
    Sub Main()
        Dim number, max As Integer
        Console.Write("How many Werewolves do you want to set on your foe? ")
        number = Console.ReadLine()
        Console.Write("What is the maximum attack strength of the strongest wolf? ")
        max = Console.ReadLine
        outputrandoms(number, max)
        Console.ReadLine()
    End Sub

    Sub outputrandoms(ByVal n As Integer, ByVal m As Integer)
        Dim counter, randomnum, total As Integer
        For counter = 1 To n
            randomnum = CInt(Rnd() * m)
            total = total + randomnum
            Console.WriteLine("Wolfnumber " & counter & "  does " & randomnum & " damage.")
        Next
        Console.WriteLine("Your attack werewolves did a total of  " & total & "  damage.")
    End Sub

End Module
