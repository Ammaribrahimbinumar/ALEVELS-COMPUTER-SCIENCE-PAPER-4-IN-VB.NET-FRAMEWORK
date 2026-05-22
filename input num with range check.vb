Imports System.Console

Module Module1

    Sub Main()
        Dim num As Integer
        num = ReadLine()

        If num < 21 Then
            WriteLine("below range")
        ElseIf num > 29 Then
            WriteLine("above range")
        Else WriteLine("in range")

        End If
        ReadLine()

    End Sub

End Module
