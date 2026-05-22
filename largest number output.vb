Module Module1

    Sub Main()
        Dim num1, num2, num3 As Integer
        num1 = Console.ReadLine
        num2 = Console.ReadLine
        num3 = num1
        If num2 > num1 Then
            num3 = num2

        End If
        Console.WriteLine(num3)
        Console.ReadLine()
    End Sub

End Module
