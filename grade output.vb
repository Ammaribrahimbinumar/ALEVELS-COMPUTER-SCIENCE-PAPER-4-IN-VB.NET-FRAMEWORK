Imports System.Console

Module Module1

    Sub Main()
        Dim grade As Integer
        WriteLine("please enter grade")
        grade = ReadLine()

        Select Case grade
            Case 85 To 100
                WriteLine("grade A*")
            Case 75 To 85
                WriteLine("grade A")
            Case 65 To 75
                WriteLine("grade B")
            Case 55 To 65
                WriteLine("grade c")
            Case 45 To 55
                WriteLine("grade D")
            Case 1 To 45
                WriteLine("grade U")
            Case Else
                WriteLine("invalid")
        End Select
        ReadLine()

    End Sub

End Module
