Module Module1

    Sub Main()
        Dim str, con, letter, alph, num, sign As String
        Dim count As Integer

        Do

            alph = ""
            num = ""
            sign = ""
            str = ""
            con = ""
            letter = ""
            count = 0

            Console.Write("Input your string: ")
            str = Console.ReadLine

            For count = 1 To Len(str)
                letter = Asc(Mid(str, count, 1))
                If letter >= 65 And letter <= 90 Or letter >= 97 And letter <= 122 Then
                    alph = alph & Chr(letter) & " "

                ElseIf letter >= 48 And letter <= 57 Then
                    num = num & Chr(letter) & " "

                Else : sign = sign & Chr(letter) & " "
                End If
            Next

            Console.WriteLine("Alphabets: " & alph)
            Console.WriteLine("Numbers: " & num)
            Console.WriteLine("Special Charactes: " & sign)

            Console.WriteLine("  ")
            Console.Write("Do you want to continue ?:")
            con = Console.ReadLine

            con = LCase(con)

        Loop Until con = "no"

    End Sub

End Module
