Module Module1

    Sub Main()
        Dim mArray(4, 5) As String
        Dim row, col, count, i As Integer

        For row = 1 To 4
            For col = 1 To 5
                mArray(row, col) = "a"
            Next
        Next

        count = 0
        i = 0

        Do
            row = Int(Rnd() * 4) + 1
            col = Int(Rnd() * 5) + 1

            If mArray(row, col) <> "X" Then
                count = count + 1
                mArray(row, col) = "X"
            End If
        Loop Until count = 20

        For row = 1 To 4
            For col = 1 To 5
                Console.Write(mArray(row, col))
            Next
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
