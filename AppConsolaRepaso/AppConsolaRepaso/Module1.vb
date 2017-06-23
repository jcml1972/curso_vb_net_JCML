Module Module1

    Public Class ClaseEjemplo
        Public cadena As String
        Public entero As Integer
        Public Overrides Function ToString() As String
            Return "texto: """ & cadena & """, entero=" & entero
        End Function
    End Class
    Public Structure EstructuraEjemplo
        Public cadena As String
        Public entero As Integer
        Public Overrides Function ToString() As String
            Return "texto: """ & cadena & """, entero=" & entero
        End Function
    End Structure

    Sub Main()
        Console.WriteLine(" ** ESTRUCTURAS **" & vbCrLf)
        EjemploEstructura()

        Console.WriteLine(vbCrLf & " ** CLASES **" & vbCrLf)
        EjemploClases()
        Console.WriteLine(vbCrLf & " ** CLASES2 **" & vbCrLf)
        EjemploClases_2()

        Console.ReadKey()
    End Sub
    Sub EjemploEstructura()
        Dim est_1 As EstructuraEjemplo = New EstructuraEjemplo() With {
            .cadena = "Cadena de la estructura", .entero = 10}
        Dim est_2 As EstructuraEjemplo = est_1
        est_1.cadena = "Nueva cadena estructura 1"

        SubrutinaQueHace(est_2)

        Console.WriteLine(est_2.ToString())

    End Sub
    Sub SubrutinaQueHace(ByRef estruc As EstructuraEjemplo)
        estruc.cadena = "Modificando estructura en subrutina"
        estruc = New EstructuraEjemplo()

    End Sub
    Sub EjemploClases()
        Dim obj_1 As ClaseEjemplo = New ClaseEjemplo() With {
            .cadena = "Cadena del objeto", .entero = 20}
        Dim obj_2 As ClaseEjemplo = obj_1
        obj_1.cadena = "Nueva cadena objeto 1"
        Console.WriteLine(obj_2.ToString())
    End Sub

    Sub EjemploClases_2()
        Dim obj_1 As ClaseEjemplo
        Dim obj_2 As ClaseEjemplo
        Dim obj_3 As ClaseEjemplo

        obj_2 = New ClaseEjemplo() With {
            .cadena = "Cadena del objeto", .entero = 20}
        obj_1 = obj_2
        obj_3 = obj_1
        obj_1.cadena = "Nueva cadena objeto 1"
        obj_3.entero = 99

        obj_1.cadena = "Nueva cadena objeto 1"
        SubrutinaQueHace(obj_2)
        Console.WriteLine(obj_1.ToString())
        Console.WriteLine(obj_2.ToString())
        Console.WriteLine(obj_3.ToString())

    End Sub
    Sub SubrutinaQueHace(ByVal objeto As ClaseEjemplo)
        objeto.entero = 200

        'objeto.cadena = "Modificando objeto en subrutina"
        objeto = New ClaseEjemplo()

    End Sub
End Module
