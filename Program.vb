Imports System.Console

Module Program
    Sub Main()
        Dim num As Integer
        Randomize()
        num = Rnd() * 6
        WriteLine(num)
        While num < 6
            num = Rnd() * 6
            WriteLine(num)
        End While
        ReadKey()
    End Sub
End Module
