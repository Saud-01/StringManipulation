Module Module1

    Sub Main()
        Dim Str1 As String
        Dim counter, alnum, Noalnum As Integer
        Dim Chr As String


        Str1 = ""
        Chr = ""
        counter = 0
        alnum = 0
        Noalnum = 0

        Console.Write("Input String: ")
        Str1 = Console.Read

        For counter = 1 To Len(Str1)
            Chr = Mid(Str1, counter, 1)
            If LCase(Chr) < "a" Or LCase(Chr) > "z" Then
                Noalnum = Noalnum + 1
            Else
                alnum = alnum + 1
            End If
        Next

        Console.WriteLine(alnum)
        Console.WriteLine(Noalnum)
        Console.ReadKey()


    End Sub
End Module

