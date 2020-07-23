Module Module1

    Sub Main()
        Dim xMap(3, 5), s As String
        Dim x, countrow, countcol, row, col As Integer
        Dim filled As Boolean = False


        countcol = 0
        x = 0
        countrow = 0
        row = 1
        col = 1
        For row = 1 To 3
            For col = 1 To 5
                xMap(row, col) = "a"
            Next
        Next

        While filled = False
            filled = True
            countrow = Int((Rnd() * 3) + 1)
            countcol = Int((Rnd() * 5) + 1)
            xMap(countrow, countcol) = "X"

            For row = 1 To 2
                For col = 1 To 4
                    x = Asc(xMap(row, col))
                    If x <> 88 Then
                        filled = False
                    End If
                Next
            Next
        End While




        For col = 1 To 5
            For row = 1 To 3
                Console.Write(xMap(row, col) & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadKey()
    End Sub

End Module
