Public Class Valoracion

    Public empleado As String
    Public ejercicio As Integer ' Año

    ' Objetivos cuantitativos de la valoración
    Public ventasComerciales As ObjetivoCuantitativo

    ' Objetivos cuantitativos de la valoración
    Public calidad As Objetivo
    Public esfuerzo As Objetivo

    ' Public resultadoMinimo As Single ' Sólo afecta a la retribución variable
    ' Public resultadoMaximo As Single ' Sólo afecta a 
    Public Sub New(emp As String)
        empleado = emp
        ejercicio = DateTime.Now.Year

        ventasComerciales = New ObjetivoCuantitativo()
        calidad = New ObjetivoCualitativo()
        esfuerzo = New ObjetivoCualitativo()

    End Sub

    Public Sub New(emp As String, ejer As Integer)
        empleado = emp
        ejercicio = ejer

        ventasComerciales = New ObjetivoCuantitativo()
        calidad = New ObjetivoCualitativo()
        esfuerzo = New ObjetivoCualitativo()

    End Sub

    Public Sub establecerVentas(ventas As Single)

        ventasComerciales.EstablecerVentas(ventas)

    End Sub

    Public Sub Mostrar()

        Console.WriteLine("Empleado: " & empleado & ", ejercicio: " & ejercicio)
        Console.WriteLine("Ventas comerciales: " & ventasComerciales.ToString)
        Console.WriteLine("Calidad: " & calidad.ToString)
        Console.WriteLine("Esfuerzo: " & esfuerzo.ToString)

    End Sub

End Class
