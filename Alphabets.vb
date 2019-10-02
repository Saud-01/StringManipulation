Module Module1

    Sub Main()
         Dim Con, Str1 As String
        Dim counter, alnum, Noalnum As Integer
        Dim letter As String

        Do

            Str1 = ""
            letter = ""
            counter = 0
            alnum = 0
            Noalnum = 0
            Con = ""

            Console.Write("Input String: ")
            Str1 = Console.ReadLine


            For counter = 1 To Len(Str1)
                letter = Mid(Str1, counter, 1)
                If LCase(letter) < "a" Or LCase(letter) > "z" Then
                    Noalnum = Noalnum + 1
                Else
                    alnum = alnum + 1
                End If
            Next

            Console.WriteLine(alnum & ", " & "Alphabets")
            Console.WriteLine(Noalnum & ", " & "Non Alphabets")
            Console.WriteLine(" ")
            Console.Write("Do you want to continue ?: ")
            Con = Console.ReadLine

            Con = LCase(Con)

        Loop Until Con = "no"
    End Sub

End Module
