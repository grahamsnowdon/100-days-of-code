Module Module1

    Sub Main()
        'writeFile()
        'readFile()
        appendFile()
    End Sub

    Sub writeFile()
        Dim file As String = "C:\Users\gsnowdon\source\repos\files\files\bin\Debug\test.txt"
        FileOpen(1, file, OpenMode.Output)
        Console.WriteLine("Enter Username:")
        Dim username As String = Console.ReadLine
        PrintLine(1, username)
        Console.WriteLine("Enter which room you are in:")
        Dim room As String = Console.ReadLine
        PrintLine(1, room)
        FileClose(1)
        Console.WriteLine("File Saved")
        Console.ReadKey()
    End Sub
    Sub readFile()
        Dim file As String = "C:\Users\gsnowdon\source\repos\files\files\bin\Debug\test.txt"
        Dim data As String
        FileOpen(1, file, OpenMode.Input)

        'Read data from the file
        Do While Not EOF(1)
            data = LineInput(1)
            Console.WriteLine(data)
        Loop

        FileClose(1)
        Console.WriteLine("File Closed")
        Console.ReadKey()
    End Sub
    Sub appendFile()
        Dim file As String = "C:\Users\gsnowdon\source\repos\files\files\bin\Debug\test.txt"
        FileOpen(1, file, OpenMode.Append)

        Console.WriteLine("Enter Item:")
        Dim item As String = Console.ReadLine
        PrintLine(1, item)

        FileClose(1)
        Console.WriteLine("File Saved")
        Console.ReadKey()
    End Sub
End Module
