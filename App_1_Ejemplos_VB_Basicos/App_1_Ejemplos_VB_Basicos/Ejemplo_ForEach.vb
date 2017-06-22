Module Ejemplo_ForEach
    Sub Main()

        Dim arcoiris() As String = New String() {"rojo", "verde", "azu", "amarillo"}

        For Each color As String In arcoiris
            Console.WriteLine("Toca el color " & color)
        Next

        Console.Read()


    End Sub

End Module
