Module Ejemplo_DoLoop3
    Sub main()
        Dim texto, texto2 As String
        Dim valor As Integer
        Dim dato As Single
        Do
            Console.WriteLine("Donde te encuentras?")
            Console.WriteLine("E - Europa (km/h)")
            Console.WriteLine("U - USA (MILLAS/HORA)")
            Console.WriteLine("M - MAR (NUDOS)")
            Console.WriteLine("S - SALIR")
            Console.Write("opcion: ")
            texto = Console.ReadLine
            Select Case texto
                Case "E"
                    dato = 3.6
                    texto2 = "km/h"
                Case "U"
                    dato = 4
                    texto2 = "millas"
                Case "M"
                    dato = 5
                    texto2 = "nudos"
                Case "S"
                    Exit Do
            End Select
            Console.Write("dime cuantos metros por segundo: ")
            valor = Console.ReadLine()
            Console.WriteLine("Son: " & valor * dato & " " & texto2)
        Loop
    End Sub

End Module
