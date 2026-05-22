Imports System.Console


Module Module1
    Sub Main()


        Write("Enter the number of rows for the pyramid: ")

        Dim rows As Integer
        rows = ReadLine()


        For index As Integer = 1 To rows
            For space As Integer = 1 To rows - index

                Write(" ")
            Next


            For draw As Integer = 1 To (2 * index - 1)
                If draw = 1 Or draw = (2 * index - 1) Or index = rows Then
                    Write("-")
                Else
                    Write(" ")
                End If

            Next

            WriteLine()
        Next

        ReadKey()
    End Sub
End Module

