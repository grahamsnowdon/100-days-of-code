'REQUIREMENTS
'  'Create a minimum five-question quiz that uses a single procedure (Shared Sub Main)
' 'Use a mixture of SELECT CASE and IF statements
' 'The user’s score must be displayed at the end of the quiz, along with a message based on how well they performed

Imports System

Public Class Application
	Public Shared Sub Main()
    Dim correct As Integer = 0

        Console.WriteLine("*****************Snowdon's Amazing Quiz*****************")
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("A: True or False, VB stands for visual basic?")
        Dim ans_Bool as Boolean = Console.ReadLine()
        If ans_Bool = True Then
            correct = correct + 1
            Console.WriteLine("Correct!")
        Else
            Console.WriteLine("Sorry wrong. ")
        End If

        Console.WriteLine()
        Console.WriteLine("B: Which type of programming promotes code reuse?")
        Console.WriteLine("1: Event driven programming")
        Console.WriteLine("2: Object Oriented Programming")
        Console.WriteLine("3: Sequential Programming")
        Console.WriteLine("4: Procedural Programming")

        Dim ans_int As Integer = Console.Readline()
        Select Case ans_int
            Case 1
                Console.WriteLine("Nope")
            Case 2
                Console.WriteLine("Correct!")
                correct = correct + 1
            Case 3
                Console.WriteLine("Nope")
            Case 4
                Console.WriteLine("Nope")
            Case Else
                Console.WriteLine("That wasn't an option")
        End Select

        Console.WriteLine()
        Console.WriteLine("C: True or False, a while loop is a counter loop?")
        ans_Bool = Console.ReadLine()
        If ans_Bool = True Then
            Console.WriteLine("Sorry wrong. ")
        Else

            correct = correct + 1
            Console.WriteLine("Correct!")
        End If

        Console.WriteLine()
        Console.WriteLine("D: Which type of programming concept can be used to make a decision?")
        Console.WriteLine("1: Sequence Statement")
        Console.WriteLine("2: My stomach thinks my throat's been cut")
        Console.WriteLine("3: Procedural Programming")
        Console.WriteLine("4: Conditional Statement")

        ans_int  = Console.Readline()
        Select Case ans_int
            Case 1
                Console.WriteLine("Nope")
            Case 2
                Console.WriteLine("Nope")
            Case 3
                Console.WriteLine("Nope")
            Case 4
                Console.WriteLine("Correct!")
                correct = correct + 1
            Case Else
                Console.WriteLine("That wasn't an option")
        End Select

        Console.WriteLine()
        Console.WriteLine("5: True or False, the geek shall inherit the earth?")
        ans_Bool = Console.ReadLine()
        If ans_Bool = True Then
                    correct = correct + 1
            Console.WriteLine("Correct!")
        Else
            Console.WriteLine("Sorry wrong.")
        End If

        Select Case correct
            Case 1, 2
                Console.WriteLine(correct & " question(s) right?!, You suck at this game.")
            Case 3
                Console.WriteLine(correct & " correct?!, medium points is mediorce.")
            Case 4
                Console.WriteLine("You got " & correct & " answers correct. Close but no cigar")
            Case 5
                Console.WriteLine("You got " & correct & " answers correct. Are you chuffed? Is your life complete? It's a lame game what do you want?")
         End Select
	End Sub
End Class
