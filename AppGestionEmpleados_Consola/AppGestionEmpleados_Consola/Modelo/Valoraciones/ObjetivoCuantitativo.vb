Public Class ObjetivoCuantitativo

    Inherits Objetivo

    Public valor As Single
    Public ventas As Single

    Sub New()
        descripcion = "Nuevo Objetivo Cuantitativo"
        peso = 50
        valor = 200
        establecerVentas(0)

    End Sub

    Public Sub establecerVentas(nuevasVentas As Single)
        ventas = nuevasVentas
        consecucion = (ventas / valor) * 100
    End Sub

End Class
