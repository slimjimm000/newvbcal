Module PerimeterFunctions
    Public Sub handleMenu(ByVal type As String)
        If type = "main" Then
            Console.WriteLine("What do you want to compute?")
            Console.WriteLine("a.) Triangle")
            Console.WriteLine("b.) Square")
            Console.WriteLine("c.) Rectangle")
            Console.Write("Enter the letter: ")
        End If


    End Sub

    Public Sub handleTriangle()
        Console.Write("What is the length of the base?: ")
        Dim inputBase As String = Console.ReadLine()
        Dim base As Decimal
        If Decimal.TryParse(inputBase, base) Then
            Console.Write("What is the length of the right side?: ")
            Dim inputRightSide As String = Console.ReadLine()
            Dim rightSide As Decimal
            If Decimal.TryParse(inputRightSide, rightSide) Then
                Console.Write("What is the length of the left side?: ")
                Dim inputLeftSide As String = Console.ReadLine()
                Dim leftSide As Decimal
                If Decimal.TryParse(inputLeftSide, leftSide) Then
                    Dim perimeterTriangle As String = base + rightSide + leftSide
                    Console.WriteLine("The perimeter of the triangle is " + perimeterTriangle)
                    Console.WriteLine()
                    Main()
                Else
                    Console.WriteLine("Invalid Input")
                    Console.WriteLine()
                    Main()
                End If
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
    End Sub

    Public Sub handleSquare()
        Console.Write("What is the length of the sides?: ")
        Dim inputSide As String = Console.ReadLine()
        Dim side As Decimal
        If Decimal.TryParse(inputSide, side) Then
            Dim perimeterSquare As String = side * 4
            Console.WriteLine("The perimeter of the square is " + perimeterSquare)
            Console.WriteLine()
            Main()
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
    End Sub

    Public Sub handleRectangle()
        Console.Write("What is the length: ")
        Dim inputlength As String = Console.ReadLine()
        Dim length As Decimal
        If Decimal.TryParse(inputlength, length) Then
            Console.Write("What is the width?: ")
            Dim inputWidth As String = Console.ReadLine()
            Dim width As Decimal
            If Decimal.TryParse(inputWidth, width) Then
                Dim perimeterRectangle As String = (length + width) * 2
                Console.WriteLine("The perimeter of the rectangle is " + perimeterRectangle)
                Console.WriteLine()
                Main()
            Else
                Console.WriteLine("Invalid Input")
                Console.WriteLine()
                Main()
            End If
        Else
            Console.WriteLine("Invalid Input")
            Console.WriteLine()
            Main()
        End If
    End Sub



End Module
