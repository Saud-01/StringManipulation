Module Module1

    Sub Main()

        Dim NewString, con, Instring As String
        Dim Index As Integer
        Dim AfterSpace As Boolean
        Dim NextChar As Char
        Dim Space As String

        Do
            con = ""
            Space = ""
            AfterSpace = False
            NewString = ""


            Console.Write("Enter New String: ")
            Instring = Console.ReadLine

            Console.Write("Which character do you want to truncate: ")
            Space = Console.ReadLine


            For Index = 1 To Len(Instring)
                NextChar = (Mid(Instring, Index, 1))

                If NextChar <> Space Then
                    NewString = NewString & NextChar
                End If
            Next
            Console.WriteLine(NewString)

            Console.WriteLine("  ")
            Console.Write("Do you want to continue ?:")
            con = Console.ReadLine

            con = LCase(con)

        Loop Until con = "no"


    End Sub

End Module
