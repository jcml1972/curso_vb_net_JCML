Public Module CocheExtensiones

    <System.Runtime.CompilerServices.Extension()>
    Public Sub MostrarInfoCoche(coche As Coche)

        Console.WriteLine(coche.tostring())


        If coche.Es4x4() Then
            Console.WriteLine(coche.DameModelo() & " Es 4 x 4")
        Else
            Console.WriteLine(coche.DameModelo() & " No es 4x4")
        End If
    End Sub

    <System.Runtime.CompilerServices.Extension()>
    Public Function EsPalindromo(texto As String) As Boolean
        If texto = Nothing Then
            Return False
        End If
        Dim textoInverso As String = ""
        For i As Integer = texto.Length - 1 To 0 Step -1
            textoInverso = textoInverso + texto(i)
        Next
        Return textoInverso.Equals(texto)
    End Function

End Module
