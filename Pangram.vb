Module Module1

    Sub Main()
        Dim alph(26), letter, str1, con As String
        Dim count1, count2, cpa(26) As Integer
        Dim pangram As Boolean

        Do

            pangram = True
            con = ""
            letter = ""
            str1 = ""
            count1 = 0
            count2 = 0
            alph(1) = "a" : alph(2) = "b" : alph(3) = "c"
            alph(4) = "d" : alph(5) = "e" : alph(6) = "f"
            alph(7) = "g" : alph(8) = "h" : alph(9) = "i"
            alph(10) = "j" : alph(11) = "k" : alph(12) = "l"
            alph(13) = "m" : alph(14) = "n" : alph(15) = "o"
            alph(16) = "p" : alph(17) = "q" : alph(18) = "r"
            alph(19) = "s" : alph(20) = "t" : alph(21) = "u"
            alph(22) = "v" : alph(23) = "w" : alph(24) = "x"
            alph(25) = "y" : alph(26) = "z"

            For count1 = 1 To 26
                cpa(count1) = 0
            Next


            Console.Write("Input your sentence: ")
            str1 = Console.ReadLine

            For count1 = 1 To Len(str1)
                letter = Mid(str1, count1, 1)
                For count2 = 1 To 26
                    If letter = alph(count2) Then
                        cpa(count2) = 1
                    End If
                Next
            Next

            For count1 = 1 To 26
                If cpa(count1) = 0 Then
                    pangram = False
                End If
            Next

            If pangram = False Then
                Console.WriteLine("Your sentence is not a pangram")
            Else
                Console.WriteLine("Your sentence is a pangram")
            End If

            Console.WriteLine("  ")
            Console.Write("Do you want to continue ?:")
            con = Console.ReadLine

            con = LCase(con)

        Loop Until con = "no"

    End Sub

End Module
