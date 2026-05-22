Module Module1

    Sub Main()
        Dim age As Integer
        Console.WriteLine("enter your age")
        age = Console.ReadLine()
        If age < 17 Then
            Console.WriteLine("underage")
        End If

        If age > 17 Then
            Console.WriteLine("you can get licnce")
        End If

        Console.ReadLine()
    End Sub

End Module
