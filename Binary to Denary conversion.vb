Module Module1


    Sub Main()
        Dim str1, con As String
        Dim number(8), count, letter, bnum, denary, x, y, count2, dnum As Integer
        Dim validbinarystring As Boolean

        Do

            Do
                count2 = 0
                validbinarystring = True
                dnum = 0
                denary = 0
                bnum = 0
                letter = 0
                str1 = ""
                con = ""
                number(1) = 1
                number(2) = 2 : number(8) = 128
                number(3) = 4 : number(7) = 64
                number(4) = 8 : number(6) = 32
                number(5) = 16
                count = 0



                Console.Write("Enter Your Binary Number: ")
                str1 = Console.ReadLine

                dnum = Len(str1)
                If dnum > 8 Or dnum < 1 Then
                    validbinarystring = False
                End If

                For count = 1 To Len(str1)
                    letter = Val(Mid(str1, count, 1))
                    If letter > 1 Or letter < 0 Then
                        validbinarystring = False
                    End If
                Next

                If validbinarystring = False Then
                    Console.WriteLine("Not a valid binary number.....")
                End If
            Loop Until validbinarystring = True

            y = 1
            x = Len(str1) - 1
            For count = Len(str1) To 1 Step -1
                bnum = Val(Mid(str1, count, 1))
                For count2 = y To Len(str1) - x Step -1
                    bnum = bnum * number(count2)
                    denary = denary + bnum
                Next
                y = y + 1
                x = x - 1
            Next

            Console.WriteLine(str1 & " = " & denary)
            Console.WriteLine("Do you want to continue ?:")
            con = Console.ReadLine
            con = LCase(con)

        Loop Until con = "no"
    End Sub

End Module
