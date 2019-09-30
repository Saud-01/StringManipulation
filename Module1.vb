Module Module1

    Sub Main()
        Dim S1, S2, FirstWord, SecWord As String
        Dim SP As Integer

        S1 = ""
        S2 = ""
        FirstWord = ""
        SecWord = ""
        SP = 0

        Console.Write("Enter First String: ")
        S1 = Console.ReadLine

        Console.Write("Enter Second String: ")
        S2 = Console.ReadLine

        SP = InStr(S1, " ")
        FirstWord = Left(S1, SP - 1)

        SP = InStr(S2, " ")
        SecWord = Right(S2, Len(S2) - SP)

        Console.Write("Final Sring = " & FirstWord & " " & SecWord)

        Console.ReadKey()

    End Sub

End Module
