Module Module1

    Sub Main()
        Dim str1, con, str2 As String
        Dim Astr2, Astr1, s1n, s2n, count As Integer

        Do

            str1 = ""
            str2 = ""
            con = ""
            count = 0
            s2n = 0
            s1n = 0
            Astr1 = 0
            Astr2 = 0

            Console.Write("Input your first string : ")
            str1 = Console.ReadLine

            Console.Write("Input your second string : ")
            str2 = Console.ReadLine

            For count = 1 To Len(str1)
                s1n = Asc(Mid(str1, count, 1))
                Astr1 = Astr1 + s1n
            Next


            For count = 1 To Len(str2)
                s2n = Asc(Mid(str2, count, 1))
                Astr2 = Astr2 + s2n

            Next

            If Astr1 = Astr2 Then
                Console.WriteLine(str1 & " and " & str2 & " are Anagrams")
            Else
                Console.WriteLine(str1 & " and " & str2 & " are not Anagrams")
            End If

            Console.WriteLine(" ")
            Console.Write("Do you want to continue? :")
            con = Console.ReadLine
            con = LCase(con)

        Loop Until con = "no"

    End Sub

End Module
