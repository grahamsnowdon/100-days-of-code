Imports System
'Quick change to enable commit
Public Class Application
	Public Shared Sub Main()
	Dim choice As Integer
        Console.WriteLine("Objective 4, select below: ")
        Console.WriteLine("1 for Task 1 ")
        Console.WriteLine("2 for Task 2 ")
        Console.WriteLine("3 for Task 3 ")
        Console.WriteLine("4 for Task 4 ")
        Console.WriteLine("5 for Task 5 ")
        Console.WriteLine("6 for Task 6 ")
        Console.WriteLine("7 for Under age")
        Console.WriteLine("8 for Water Temp")
        Console.WriteLine("9 for Vocational Grade")
        Console.WriteLine("10 for Visual Dice")
        Console.WriteLine("11 for Greater number")
        Console.WriteLine("12 for nitrate")
        Console.WriteLine("13 for Portfolio grade")
        Console.WriteLine("14 for Cash machine")
        Console.WriteLine("15 for Periodic table")
        Console.WriteLine("16 for Train ticket")
        Console.WriteLine("17 for Hours Worked")
        Console.WriteLine("0 to exit")
        choice = Console.ReadLine

        If choice = 1 Then
            task1()
        ElseIf choice = 2 Then
            task2()
        ElseIf choice = 3 Then
            task3()
        ElseIf choice = 4 Then
            task4()
        ElseIf choice = 5 Then
            task5()
        ElseIf choice = 6 Then
            task6()
        ElseIf choice = 7 Then
            underAge()
        ElseIf choice = 8 Then
            waterTemp()
        ElseIf choice = 9 Then
            VocGrad()
        ElseIf choice = 10 Then
            VisDice()
        ElseIf choice = 11 Then
            GreaterNum()
        ElseIf choice = 12 Then
            nitrate()
        ElseIf choice = 13 Then
            portGrad()
        ElseIf choice = 14 Then
            cashMach()
        ElseIf choice = 15 Then
            periodTable()
        ElseIf choice = 16 Then
            trainTicket()
        ElseIf choice = 17 Then
            hoursWorked()
        ElseIf choice = 0 Then
            Console.WriteLine("BYEEEEEEEEE!!!!!!!!!!!!!!!!!!!")
        Else
            Console.WriteLine("Not a valid option")
        End If

    End Sub

    Public Shared Sub task1()
        'Using select statements to chekc variables
        'Declare a number variable

        Dim number As Integer
        'Ask the user for a number
        Console.WriteLine("Enter a number 1-3: ")
        number = Console.ReadLine
        'Check the value of the number
        If number = 1 Then
            Console.WriteLine("You entered one")
            Console.ReadLine()
        ElseIf number = 2 Then
            Console.WriteLine("You entered two")
            Console.ReadLine()
        ElseIf number = 3 Then
            Console.WriteLine("You entered three")
            Console.ReadLine()
        Else
            Console.WriteLine("Not a valid option")
            Console.ReadLine()
        End If
        Main()
    End Sub

    Public Shared Sub task2()
        'works out wether a candidate has passed or failed
        Dim score As Integer
        Console.WriteLine("Enter the test score 1-100: ")
        score = Console.ReadLine
        'Branch depending on the value of the variable
        If score > 40 Then
            Console.WriteLine("You passed")
        Else
            Console.WriteLine("You failed")
        End If
        Console.ReadKey()
        Main()
    End Sub
    Public Shared Sub task3()
        'works out wether a candidate has passed or failed
        Dim score As Integer
        Console.WriteLine("Enter the test score 1-100: ")
        score = Console.ReadLine
        'Branch depending on the value of the variable
        If score > 50 Then
            Console.WriteLine("You passed")
        Else
            Console.WriteLine("You failed")
        End If
        Console.ReadKey()
        Main()
    End Sub
    Public Shared Sub task4()
        'returns whether two numbers are the same
        Dim num1, num2 As Integer
        Console.WriteLine("Enter the first number: ")
        num1 = Console.ReadLine
        ' Console.WriteLine("Enter the second number: ")
        num2 = Console.ReadLine
        'Branching depending on the value of the variable
        If num1 <> num2 Then
            Console.WriteLine("The numbers are different")
        Else
            Console.WriteLine("The numbers are the same")
        End If
        Console.ReadKey()
        Main()
    End Sub
    Public Shared Sub task5()
        Dim choice As String
        Console.WriteLine("Enter a number 1-3: ")
        choice = Console.ReadLine
        If choice > "0" And choice < "3" Then
            Console.WriteLine("Valid input")
        Else
            Console.WriteLine("Invalid input")
        End If
        Console.ReadKey()
        Main()
    End Sub
    Public Shared Sub task6()
        'Using case selection
        Dim choice As String
        'Ask user for the number
        Console.WriteLine("1. Add numbers")
        Console.WriteLine("2. Subtract numbers")
        Console.WriteLine("3. Quit")


        Console.WriteLine("Enter your choice: ")
        choice = Console.ReadLine
        'Multiple branches depending on selection
        Select Case choice
            Case Is = "1"
                Console.WriteLine("Add numbers chosen")
            Case Is = "2"
                Console.WriteLine("Subtract numbers chosen")
            Case Is = "3"
                Console.WriteLine("Quit chosen")
        End Select
        Console.ReadKey()
        Main()
    End Sub

    Public Shared Sub underAge()
        Dim age As Integer
        Console.WriteLine("Enter your age: ")
        age = CInt(Console.ReadLine)
        If age > 18 Then
            Console.WriteLine("Over 18")
        Else
            Console.WriteLine("Under 18")
        End If
        Console.ReadKey()
        Main()
    End Sub

    Public Shared Sub waterTemp()
        Dim water As Integer
        Console.WriteLine("Enter the temperature of the water: ")
        water = Console.ReadLine
        If water <= 0 Then
            Console.WriteLine("The water is frozen")
        ElseIf water >= 100 Then
            Console.WriteLine("The water is boiling")
        Else
            Console.WriteLine("The water is neither boiling or frozen")
        End If
        Main()
    End Sub

    Public Shared Sub VocGrad()
        Dim testMark As Integer
        Console.WriteLine("Enter the grade out of 100: ")
        testMark = Console.ReadLine
        If testMark < 40 Then
            Console.WriteLine("Fail")
        ElseIf testMark < 60 Then
            Console.WriteLine("Pass")
        ElseIf testMark < 80 Then
            Console.WriteLine("Merit")
        Else
            Console.WriteLine("Distinction")
        End If
        Main()
    End Sub

    Public Shared Sub VisDice()
        Dim number As Integer
        'Ask the user for a number
        Console.WriteLine("Enter a number 1-6: ")
        number = Console.ReadLine
        'Check the value of the number
        If number = 1 Then
            Console.WriteLine("ooooooooooo")
            Console.WriteLine("o         o")
            Console.WriteLine("o         o")
            Console.WriteLine("o    #    o")
            Console.WriteLine("o         o")
            Console.WriteLine("o         o")
            Console.WriteLine("ooooooooooo")
        ElseIf number = 2 Then
            Console.WriteLine("ooooooooooo")
            Console.WriteLine("o         o")
            Console.WriteLine("o    #    o")
            Console.WriteLine("o         o")
            Console.WriteLine("o    #    o")
            Console.WriteLine("o         o")
            Console.WriteLine("ooooooooooo")
        ElseIf number = 3 Then
            Console.WriteLine("ooooooooooo")
            Console.WriteLine("o    #    o")
            Console.WriteLine("o         o")
            Console.WriteLine("o    #    o")
            Console.WriteLine("o         o")
            Console.WriteLine("o    #    o")
            Console.WriteLine("ooooooooooo")
        ElseIf number = 4 Then
            Console.WriteLine("ooooooooooo")
            Console.WriteLine("o         o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o         o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o         o")
            Console.WriteLine("ooooooooooo")
        ElseIf number = 5 Then
            Console.WriteLine("ooooooooooo")
            Console.WriteLine("o         o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o    #    o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o         o")
            Console.WriteLine("ooooooooooo")
        ElseIf number = 6 Then
            Console.WriteLine("ooooooooooo")
            Console.WriteLine("o         o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o  #  #   o")
            Console.WriteLine("o         o")
            Console.WriteLine("ooooooooooo")
        Else
            Console.WriteLine("Not a valid option")
            Console.ReadLine()
        End If
        Main()
    End Sub
    Public Shared Sub GreaterNum()
        Dim num1, num2 As Integer
        'Ask the user for a number
        Console.WriteLine("Enter a number: ")
        num1 = Console.ReadLine
        Console.WriteLine("Enter a different number: ")
        num2 = Console.ReadLine
        'Check the value of the number
        If num1 > num2 Then
            Console.WriteLine("The first number: " & num1 & " is greater than the second number " & num2)
        ElseIf num1 < num2 Then
            Console.WriteLine("The second number: " & num2 & " is greater than the first number " & num1)
        ElseIf num1 = num2 Then
            Console.WriteLine("Those numbers: " & num1 & " were the same.")
        Else
            Console.WriteLine("That seemed to go wrong, did you enter a number?")
        End If
        Main()
    End Sub
    Public Shared Sub nitrate()
        Dim num1 As Double
        'Ask the user for a number
        Console.WriteLine("Enter the nitrate: ")
        num1 = Console.ReadLine
        'Check the value of the number
        If num1 > 10 Then
            Console.WriteLine("Dose 3ml")
        ElseIf num1 > 2.5 Then
            Console.WriteLine("Dose 2ml")
        ElseIf num1 > 1 Then
            Console.WriteLine("Dose 1ml")
        Else
            Console.WriteLine("Dose 0.5ml")
        End If
        Main()
    End Sub

    Public Shared Sub portGrad()
        Dim aGrad, dGrad, iGrad, eGrad, total, extra As Integer
        'Ask the user for a number
        Console.WriteLine("Enter the analysis grade: ")
        aGrad = Console.ReadLine
        Console.WriteLine("Enter the design grade: ")
        dGrad = Console.ReadLine
        Console.WriteLine("Enter the implementation grade: ")
        iGrad = Console.ReadLine
        Console.WriteLine("Enter the evaluation grade: ")
        eGrad = Console.ReadLine
        'Check the value of the number
        total = aGrad + dGrad + iGrad + eGrad

        If total > 79 Then
            Console.WriteLine("Your grade was A*")
        ElseIf total > 66 Then
            Console.WriteLine("Your grade was A you were " & 80 - total & " off an A*")
        ElseIf total > 53 Then
            Console.WriteLine("Your grade was B you were " & 67 - total & " off an A")
        ElseIf total > 40 Then
            Console.WriteLine("Your grade was C you were " & 52 - total & " off a B")
        ElseIf total > 30 Then
            Console.WriteLine("Your grade was D you were " & 41 - total & " off a C")
        ElseIf total > 21 Then
            Console.WriteLine("Your grade was E you were " & 31 - total & " off a D")
        ElseIf total > 12 Then
            Console.WriteLine("Your grade was F you were " & 22 - total & " off an E ")
        ElseIf total > 3 Then
            Console.WriteLine("Your grade was G you were " & 11 - total & " off a F")
        Else
            Console.WriteLine("Your grade was U you were " & 4 - total & " off a G")
        End If
        Main()
    End Sub

    Public Shared Sub cashMach()
        Dim balance As Double = 500
        Dim maxWithdraw As Double = 250
        Dim uWithDraw As Integer
        'Ask the user for a withdrawl amount
        Console.WriteLine("Your balance is: £" & balance)
        Console.WriteLine("How much would you like to withdraw?: ")
        uWithDraw = Console.ReadLine
        If uWithDraw > 250 Then
            Console.WriteLine("Sorry the maximum withdrawl is £250")
        ElseIf (uWithDraw Mod 10 <> 0) Or (uWithDraw Mod 20 <> 0) Then
            Console.WriteLine("The amount must be divisable by £10 or £20 notes")
        Else
            Console.WriteLine("Your remaining balance is: " & balance - uWithDraw)
        End If
        Main()
    End Sub

    Public Shared Sub periodTable()
        Dim uInput As String

        Console.WriteLine("Please enter the name or symbol of an element: ")
        uInput = Console.ReadLine
        If uInput = "Li" Or uInput = "Lithium" Then
            Console.WriteLine("Element: Lithium")
            Console.WriteLine("Atomic Weight: 6.94")
            Console.WriteLine("Group: Alkali Metals")
        ElseIf uInput = "Na" Or uInput = "Sodium" Then
            Console.WriteLine("Element: Sodium")
            Console.WriteLine("Atomic Weight: 22.990")
            Console.WriteLine("Group: Alkali Metals")
        ElseIf uInput = "K" Or uInput = "Potassium" Then
            Console.WriteLine("Element: Potassium")
            Console.WriteLine("Atomic Weight: 39.098")
            Console.WriteLine("Group: Alkali Metals")
        ElseIf uInput = "He" Or uInput = "Helium" Then
            Console.WriteLine("Element: Helium")
            Console.WriteLine("Atomic Weight: 4.0026")
            Console.WriteLine("Group: Noble Gases")
        ElseIf uInput = "Ne" Or uInput = "Neon" Then
            Console.WriteLine("Element: Neon")
            Console.WriteLine("Atomic Weight: 20.180")
            Console.WriteLine("Group: Noble Gases")
        ElseIf uInput = "Ar" Or uInput = "Argon" Then
            Console.WriteLine("Element: Argon")
            Console.WriteLine("Atomic Weight: 39.948")
            Console.WriteLine("Group: Noble Gases")

            'This outputs all Alkali metals
        ElseIf uInput = "Alkali Metals" Then
            Console.WriteLine("Element: Lithium")
            Console.WriteLine("Atomic Weight: 6.94")
            Console.WriteLine("Group: Alkali Metals")
            Console.Writeline("---------------------------")
            Console.WriteLine("Element: Sodium")
            Console.WriteLine("Atomic Weight: 22.990")
            Console.WriteLine("Group: Alkali Metals")
            Console.Writeline("---------------------------")
            Console.WriteLine("Element: Potassium")
            Console.WriteLine("Atomic Weight: 39.098")
            Console.WriteLine("Group: Alkali Metals")
        ElseIf uInput = "Noble Gases" Then
            Console.WriteLine("Element: Helium")
            Console.WriteLine("Atomic Weight: 4.0026")
            Console.WriteLine("Group: Noble Gases")
            Console.Writeline("---------------------------")
            Console.WriteLine("Element: Neon")
            Console.WriteLine("Atomic Weight: 20.180")
            Console.WriteLine("Group: Noble Gases")
            Console.Writeline("---------------------------")
            Console.WriteLine("Element: Argon")
            Console.WriteLine("Atomic Weight: 39.948")
            Console.WriteLine("Group: Noble Gases")
        Else
            Console.WriteLine("Sorry I don't understand that input")
        End If
        Main()
    End Sub

    Public Shared Sub trainTicket()
        Dim stations, adults, children, time, fare As Integer
        Dim aSubTotal, cSubTotal, total As Double
        Console.WriteLine("Please enter the amount of stations: ")
        stations = Console.ReadLine
        Console.WriteLine("Please enter the amount of adults: ")
        adults = Console.ReadLine
        Console.WriteLine("Please enter the amount of children: ")
        children = Console.ReadLine
        Console.WriteLine("Please enter the hour of the day: ")
        time = Console.ReadLine

        If time > 6 And time < 9 Then
            fare = 25
            aSubTotal = stations * fare * adults
            cSubTotal = stations * (fare / 2) * children
            total = aSubTotal + cSubTotal
            Console.WriteLine("The fare is: £" & total)
        Else
            fare = 20
            aSubTotal = stations * fare * adults
            cSubTotal = stations * (fare / 2) * children
            total = aSubTotal + cSubTotal
            Console.WriteLine("The fare is: £" & total)
        End If
        Console.ReadKey
        Main()
    End Sub

    Public Shared Sub hoursWorked()
        'Not that tricky to complete
        Dim hours As Integer
        Dim rate, pay As Double

        Console.WriteLine("Please enter the amount of hours worked: ")
        hours = Console.ReadLine
        Console.WriteLine("Please enter your rate of pay: ")
        rate = Console.ReadLine

        If hours > 0 And hours < 41 Then
            pay = hours * rate
            Console.WriteLine("Your pay is: £" & pay)

        ElseIf hours > 40 And hours < 60 Then
            pay = (40 * rate) + (((hours - 40) * 1.5) * rate)
            Console.WriteLine("Your pay is: £" & pay)

        Else
            Console.WriteLine("Your hours are not in the range.")

        End If
        Console.ReadKey
        Main()
    End Sub

End Class
