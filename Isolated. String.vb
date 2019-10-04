Module IsolatedString

    Sub Main()
        Dim dum, firstword, secondword, thirdword, str, con, sp As String

        Do

            str = ""
            con = ""
            sp = ""
            firstword = ""
            secondword = ""
            thirdword = ""
            dum = ""

            Console.Write("Input your string: ")
            str = Console.ReadLine

            sp = InStr(str, " ")
            firstword = Left(str, sp - 1)

            dum = Right(str, Len(str) - sp)

            sp = InStr(dum, " ")
            secondword = Left(dum, sp - 1)
            thirdword = Right(dum, Len(dum) - sp)


            Console.WriteLine(firstword)
            Console.WriteLine(secondword)
            Console.WriteLine(thirdword)

            Console.WriteLine(" ")
            Console.Write("Do you want to continue ?: ")
            con = Console.ReadLine
            con = LCase(con)

        Loop Until con = "no"

    End Sub

End Module
