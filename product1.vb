Module Module1

    Sub Main()
        'Sets up variables for input and file
        Dim code As Integer
        Dim description, record As String
        Dim price As Single
        Dim catalog As String = "catalog.txt"


        'Takes product details from the user and creates a single line (record) of data
        Console.WriteLine("Enter the Product code: ")
        code = Console.ReadLine()
        Console.WriteLine("Enter the Product Description: ")
        description = Console.ReadLine()
        Console.WriteLine("Enter the Product price: ")
        price = Console.ReadLine()
        record = (CStr(code) & ", " & description & ", " & CStr(price))

        'Opens file in append mode and writes data
        FileOpen(1, catalog, OpenMode.Append)
        PrintLine(1, record)

        'Closes the file and reports back to user
        FileClose(1)
        Console.WriteLine("Catalog Saved")
    End Sub

End Module


''*********************************************************************************************

Module Module1

    Sub Main()
        'Sets up variables for input and file and opens file ready to append.
        Dim code As Integer = 1
        Dim description, record As String
        Dim price As Single
        Dim catalog As String = "catalog.txt"
        FileOpen(1, catalog, OpenMode.Append)
        'takes user input and writes it to a new record until no user entry for code

        While code <> Nothing
            'Takes product details from the user and creates a single line (record) of data        Console.WriteLine("Enter the Product code: ")
            Console.WriteLine("Enter the Product code: ")
            code = Console.ReadLine()
            Console.WriteLine("Enter the Product Description: ")
            description = Console.ReadLine()
            Console.WriteLine("Enter the Product price: ")
            price = Console.ReadLine()
            record = (CStr(code) & ", " & description & ", " & CStr(price))

            'Opens file in append mode and writes data
            PrintLine(1, record)
        End While

        'Closes the file and reports back to user
        FileClose(1)
        Console.WriteLine("Catalog Saved")
        Console.ReadLine()
    End Sub

End Module
