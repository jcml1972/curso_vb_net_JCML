Public Module ModuloCocheExtensiones
    <System.Runtime.CompilerServices.Extension()>
    Public Sub MostrarInfoCoche(coche As Coche)
        Console.WriteLine(coche.EnTexto() & " es un " & coche.DameModelo)
        If coche.Es4x4() Then
            Console.WriteLine("Mi " & coche.DameModelo & " es un 4x4")
        Else
            Console.WriteLine("Mi " & coche.DameModelo & " no es un 4x4")
        End If
    End Sub
End Module
