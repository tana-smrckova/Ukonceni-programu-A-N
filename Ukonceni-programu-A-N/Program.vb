Imports System

Module Program
    Sub Main()
        Console.WriteLine("Chcete ukon�it tento program? Napi�te A/N: ")
        Dim PressKey = Console.ReadKey().Key

        If PressKey = ConsoleKey.A Then
            Console.WriteLine(" => Program se nyn� ukon��. Nashledanou.")
        ElseIf PressKey = ConsoleKey.N Then
            Console.WriteLine(" => Ty mo�n� nechce� skon�it, ale j� ano.")
        Else
            Console.WriteLine(" => Nepru�. Stejn� skon��m.")
        End If

    End Sub
End Module
