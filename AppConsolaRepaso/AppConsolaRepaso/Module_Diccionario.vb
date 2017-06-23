Module Module_Diccionario

    Public Class Empleado
        Inherits Persona
        Dim salario As Single

        Public Sub New(nombre As String, edad As Integer, salario As Single)
            MyBase.New(nombre, edad)
            Me.salario = salario
        End Sub

        Public Overrides Function ToString() As String
            Return MyBase.ToString() & ", salario= " & Me.salario
        End Function
    End Class

    Sub main()



        Dim e1, e2, e3, e4 As Empleado

        e1 = New Empleado("Luís", 30, 20000)
        e2 = New Empleado("Pedro", 40, 30000)
        e3 = New Empleado("Juan", 50, 40000)
        e4 = New Empleado("Kevin", 25, 50000)

        Dim diccEmp As Dictionary(Of String, Empleado)
        diccEmp = New Dictionary(Of String, Empleado)

        diccEmp.Add("L", e1)
        diccEmp.Add("P", e2)
        diccEmp.Add("J", e3)
        diccEmp.Add("K", e4)


        Console.WriteLine("P:" & diccEmp.Item("P").ToString)
        If diccEmp.ContainsKey("K") Then
            Console.WriteLine("K:" & diccEmp.Item("K").ToString)
        Else
            Console.WriteLine("No se ha encontrado la clave K")
        End If

        Dim diccResponsables As Dictionary(Of Empleado, Empleado)
        diccResponsables = New Dictionary(Of Empleado, Empleado)

        diccResponsables.Add(diccEmp.Item("L"), diccEmp.Item("P"))
        diccResponsables.Add(diccEmp.Item("K"), diccEmp.Item("P"))
        diccResponsables.Add(diccEmp.Item("P"), diccEmp.Item("J"))

        Console.WriteLine("El responsable de " & diccEmp.Item("K").ToString & " es " &
                            diccResponsables.Item(diccEmp.Item("K")).ToString())

        For Each kvp As KeyValuePair(Of String, Empleado) In diccEmp
            Console.WriteLine("[" & kvp.Key & "] = " & kvp.Value.ToString())

        Next


        For Each Resp As KeyValuePair(Of Empleado, Empleado) In diccResponsables
            Console.WriteLine("Empleado " & Resp.ToString & " JEFE " & Resp.Value.ToString())
        Next


        Console.ReadKey()

    End Sub


End Module
