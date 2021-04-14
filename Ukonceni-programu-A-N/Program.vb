Imports System

Module Program
    Sub Main()
        Console.WriteLine("Chcete ukonèit tento program? Napište A/N: ")
        Dim PressKey = Console.ReadKey().Key

        If PressKey = ConsoleKey.A Then
            Console.WriteLine(" => Program se nyní ukonèí. Nashledanou.")
        ElseIf PressKey = ConsoleKey.N Then
            Console.WriteLine(" => Ty moná nechceš skonèit, ale já ano.")
        Else
            Console.WriteLine(" => Nepruï. Stejnì skonèím.")
        End If

    End Sub
End Module
