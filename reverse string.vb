Module Module1

    Sub Main()
        Dim Con, Str, letter, rStr As String
        Dim counter As Integer

        Do
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

            Console.WriteLine(rStr)
            Console.Write("Do you want to continue ?: ")
            Con = Console.ReadLine

            Con = LCase(Con)

        Loop Until Con = "no"

    End Sub

End Module
