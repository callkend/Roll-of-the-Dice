'Kendall Callister
'RCET0265
'Spring 2021
'Roll of the Dice
'https://github.com/callkend/Roll-of-the-Dice.git

Option Explicit On
Option Strict On

Module RollOfDice

    Sub Main()
        Dim outcome(10) As Integer
        Dim number As Integer
        Randomize()

        'Looks for two random numbers between 1 & 6 and than adds them togther, and stores the
        'outcome in a array 1000 times.
        For i = 0 To 999
            number = CInt(6 * Rnd()) + 1 + CInt(6 * Rnd()) + 1
            Select Case number
                Case = 2
                    outcome(0) += 1
                Case = 3
                    outcome(1) += 1
                Case = 4
                    outcome(2) += 1
                Case = 5
                    outcome(3) += 1
                Case = 6
                    outcome(4) += 1
                Case = 7
                    outcome(5) += 1
                Case = 8
                    outcome(6) += 1
                Case = 9
                    outcome(7) += 1
                Case = 10
                    outcome(8) += 1
                Case = 11
                    outcome(9) += 1
                Case = 12
                    outcome(10) += 1
            End Select
        Next

        'Formats table and pulls info from array.
        Console.WriteLine("Roll of the Dice" + vbNewLine)
        For j = 0 To 20
            If j > 10 Then
                Console.Write(vbTab + "|" + CStr(outcome(j - 10)))
            ElseIf j = 10 Then
                Console.Write(vbTab + "|" + CStr(j + 2) + vbNewLine)
                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " _
                    + "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" + vbNewLine)
                Console.Write(vbTab + "|" + CStr(outcome(j - 10)))
            Else
                Console.Write(vbTab + "|" + CStr(j + 2))
            End If
        Next

        Console.ReadLine()
    End Sub

End Module
