Module Module1

    Sub Main()
        handleMenu("main")
        Dim input As String = Console.ReadLine()
        If (input = "a" Or input = "A") Then
            handleTriangle()
        ElseIf (input = "b" Or input = "B") Then
            handleSquare()
        ElseIf (input = "c" Or input = "C") Then
            handleRectangle()
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
        Console.ReadLine()
    End Sub

End Module
