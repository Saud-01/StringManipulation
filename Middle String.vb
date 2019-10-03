Module Module1

    Sub Main()
        Dim Middle, str1, con, last2w As String
        Dim sp As Integer

        Do

            Middle = " "
            str1 = ""
            con = ""
            sp = 0
            last2w = ""

            Console.Write("Enter your string: ")
            str1 = Console.ReadLine

            sp = InStr(str1, " ")
            last2w = Right(str1, Len(str1) - sp)

            sp = InStr(last2w, " ")
            Middle = Left(last2w, sp - 1)

            Console.WriteLine("'" & Middle & "'" & " is the middle word")

            Console.WriteLine(" ")
            Console.Write("Do you want to continue ?: ")
            con = Console.ReadLine
            con = LCase(con)

        Loop Until con = "no"

    End Sub

End Module
