'Jamison Burton
'RCET0265
'Spring 2022
'Multiplication Table
'https://github.com/Reimonoe17/MultiplicationTable

Option Explicit On
Option Strict On
Option Compare Text

Module MultiplicationTable

    Sub Main()
        Dim factor As Integer = 12
        Dim countHori As Integer = 1
        Dim countVert As Integer = 1


        Console.WriteLine("Enjoy you " & factor & " x " & factor & " Multiplication Table:" & vbNewLine)
        For index = 1 To factor
            For count = 1 To factor
                countHori = count * countVert
                Console.Write(countHori & "  ")
            Next
            countVert = countVert + 1
            Console.Write(vbNewLine)
        Next

            Console.ReadLine()
    End Sub

End Module
