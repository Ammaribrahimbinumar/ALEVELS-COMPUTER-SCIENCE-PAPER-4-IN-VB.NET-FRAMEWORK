Imports System.Console

Module Module1

    Sub Main()
        Dim mark As Integer
        WriteLine("input marks")
        mark = ReadLine()
        If mark >= 40 Then
            WriteLine("passed")
        Else : WriteLine("fail")
        End If
    End Sub

End Module
