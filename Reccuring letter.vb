Module Module1

    Sub Main()
        Dim alph(26), str1, con, letter, ans As String
        Dim count, alphcount(26), count2, heigh, x, y As Integer
        Dim duplicate As Boolean = False
        Dim same As Integer

        Do
            Do
                For count = 1 To 26
                    alphcount(count) = 0
                Next
                same = 0
                y = 0
                heigh = -9999
                count2 = 0
                ans = ""
                letter = ""
                con = ""
                str1 = ""
                alph(1) = "a" : alph(2) = "b" : alph(3) = "c"
                alph(4) = "d" : alph(5) = "e" : alph(6) = "f"
                alph(7) = "g" : alph(8) = "h" : alph(9) = "i"
                alph(10) = "j" : alph(11) = "k" : alph(12) = "l"
                alph(13) = "m" : alph(14) = "n" : alph(15) = "o"
                alph(16) = "p" : alph(17) = "q" : alph(18) = "r"
                alph(19) = "s" : alph(20) = "t" : alph(21) = "u"
                alph(22) = "v" : alph(23) = "w" : alph(24) = "x"
                alph(25) = "y" : alph(26) = "z"

                duplicate = False
                Do
                    Console.Write("Input your string: ")
                    str1 = Console.ReadLine()
                    str1 = LCase(str1)
                Loop Until str1 <> ""


                For count = 1 To Len(str1)
                    letter = Mid(str1, count, 1)
                    For count2 = 1 To 26
                        If letter = alph(count2) Then
                            alphcount(count2) = alphcount(count2) + 1
                        End If
                    Next
                Next


                For count = 1 To 26
                    If alphcount(count) > heigh Then
                        heigh = alphcount(count)
                        ans = alph(count)
                    End If
                Next

                If heigh = 1 Then
                    duplicate = True
                    Console.WriteLine("There are no reccuring letter in the string")
                End If

            Loop Until duplicate = False

            x = Len(str1)
            y = Len(str1)
            Dim mans(x) As String
            x = 0


            For count2 = 1 To 26
                If alphcount(count2) = heigh Then
                    same = same + 1
                    x = x + 1
                    mans(x) = alph(count2)
                End If
            Next


            If same >= 2 Then
                Console.Write("The highest reccuring letters are:")
                For x = 0 To y
                    Console.Write(mans(x) & " ")
                Next
            Else : Console.WriteLine("The highest reccuring letter is : " & ans)

            End If


            Console.WriteLine()
            Console.Write("Do you want to continue: ")
            con = Console.ReadLine()
            con = LCase(con)
        Loop Until con = "no"

    End Sub

End Module
