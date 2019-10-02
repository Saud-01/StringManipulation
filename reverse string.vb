Module Module1

    Sub Main()
        Dim Str, letter, rStr As String
        Dim counter As Integer

            Str = ""
            counter = 0
            letter = ""
            rStr = ""

            Console.Write("Input your String: ")
            Str = Console.ReadLine

            For counter = Len(Str) To 1 Step -1
                letter = Mid(Str, counter, 1)
                rStr = rStr & letter
            Next

            Console.Write(rStr)
        Console.ReadKey()

    End Sub

End Module
