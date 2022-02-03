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
        Dim product As String = ""

        'statement for the user to know what the table is multiplying
        Console.WriteLine("Enjoy you " & factor & " x " & factor & " Multiplication Table:" & vbNewLine)
        For index = 1 To factor 'for loop that repeats until reaching the factor value
            For count = 1 To factor 'nested for loop
                countHori = count * countVert 'multiplies the count by the index of the first for loop
                product = CStr(countHori)
                Console.Write(product.PadRight(5)) 'displays the product and pads the space to the right for the next number
            Next
            countVert = countVert + 1 'increases the multiple by 1 for the next for loop
            Console.Write(vbNewLine) 'Add a space for the next for loop
        Next

        Console.ReadLine()
    End Sub

End Module
