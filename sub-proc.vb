'Write out this code and comment each section (the section after the comments are '**) 
'to explain what the section does. Create an decomposition chart in PowerPoint and hand that into Teams.

Module Module1
    '**
    Dim maxNoOfStars, NoOfStars, NoOfSpaces As Integer

    '**
    Sub Main()
        '**
        InitialiseNoOfSpacesAndStars()
        '**
        Do
            OutputLeadingSpaces()
            OutputLineOfStars()
            AdjustNoOfSpacesAndStars()
        Loop While NoOfStars <= maxNoOfStars
        Console.ReadLine()
    End Sub

    '**
    Sub InitialiseNoOfSpacesAndStars()
        Console.Write("How many stars at the base (1-40)? ")
        maxNoOfStars = Console.ReadLine()
        '**
        NoOfSpaces = maxNoOfStars / 2
        '**
        NoOfStars = 1
    End Sub

    '**
    Sub OutputLeadingSpaces()
        Dim count As Integer
        For count = 1 To NoOfSpaces Step 1
            Console.Write(" ")
        Next count
    End Sub

    '**
    Sub OutputLineOfStars()
        Dim count As Integer
        For count = 1 To NoOfStars
            Console.Write("*")
        Next
        '**
        Console.WriteLine()
    End Sub

    '**
    Sub AdjustNoOfSpacesAndStars()
        NoOfSpaces = NoOfSpaces - 1
        NoOfStars = NoOfStars + 2
    End Sub

End Module
