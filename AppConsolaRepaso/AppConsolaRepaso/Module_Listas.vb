Module Module_Listas

    Public Class Persona

        Public nombre As String
        Public edad As Integer
        Public Sub New(nombre As String, edad As Integer)
            Me.nombre = nombre
            Me.edad = edad
        End Sub
        Public Overrides Function ToString() As String
            Return "nombre: " & nombre & " edad: " & edad
        End Function

    End Class

    Public Sub main()

        Console.WriteLine("EJEMPLO ARRAYLIST" & vbCrLf)
        Ejemplo_ArrayList()
        Console.Write(vbCrLf)
        Console.WriteLine("EJEMPLO LIST" & vbCrLf)
        Ejemplo_List()
        Console.Write(vbCrLf)
        Console.ReadKey()

    End Sub

    Public Sub Ejemplo_ArrayList()
        Dim listaPer As ArrayList
        listaPer = New ArrayList(3)

        Dim yo As Persona = New Persona("Juan Carlos", 44)

        listaPer.Add(New Persona("Juan", 15))

        listaPer.Add(New Persona("Luís", 40))

        listaPer.Add(New Persona("Miguel", 50))
        listaPer.Add(yo)
        listaPer.Add("UN TEXTO")
        listaPer.Add(100)
        listaPer.Remove(yo)

        For Each person In listaPer

            'persona = CType(persona, Persona)
            Console.WriteLine(person.ToString())

            If person.GetType().ToString().Contains("Persona") Then
                Dim laPersona As Persona = CType(person, Persona)
                Console.WriteLine(If(person.EDAD >= 18, "ADULTO", "NO ADULTO"))
            Else
                Console.WriteLine("No es una persona")
            End If


        Next
        Console.WriteLine("Yo mismo: " & yo.ToString() & " estoy en " & listaPer.IndexOf(yo))
        Console.WriteLine("Número personas: " & listaPer.Count)

    End Sub

    Public Sub Ejemplo_List()
        Dim listaPer As List(Of Persona)
        listaPer = New List(Of Persona)(3)

        Dim yo As Persona = New Persona("Juan Carlos", 44)

        listaPer.Add(New Persona("Juan", 15))

        listaPer.Add(New Persona("Luís", 40))

        listaPer.Add(New Persona("Miguel", 50))
        listaPer.Add(yo)



        listaPer.RemoveAt(1)

        For Each persona In listaPer

            If persona.edad >= 18 Then
                Console.WriteLine(persona.ToString())
                Console.WriteLine(persona.nombre & " ES MAYOR DE EDAD")
            Else
                Console.WriteLine(persona.ToString())
                Console.WriteLine(persona.nombre & " ES MENOR DE EDAD")
            End If

        Next
        Console.WriteLine("Yo mismo: " & yo.ToString() & " estoy en " & listaPer.IndexOf(yo))
        Console.WriteLine("Número personas: " & listaPer.Count)

    End Sub
End Module
