Partial Public Class Coche

    Private transmision As TransmisionCoche
    ' Clase anidada
    Private Class TransmisionCoche
        Public delantera As Boolean
        Public trasera As Boolean
    End Class

    ' Constructor por defecto
    Private Sub New()
        transmision = New TransmisionCoche()
    End Sub
    ' Otros constructores
    Public Sub New(nuevoKM As Integer)
        kilometraje = nuevoKM
        transmision = New TransmisionCoche()

    End Sub

    Public Sub New(modelo As String)
        Me.modelo = modelo
        Me.transmision = New TransmisionCoche()
        _ruedas = New Int32(3) {50, 60, 70, 80}
        numeroCoches = numeroCoches + 1
    End Sub
    Public Sub New(nuevoKM As Integer, modelo As String)
        kilometraje = nuevoKM
        Me.transmision = New TransmisionCoche()
        Me.modelo = modelo
        _ruedas = New Int32(3) {50, 60, 70, 80}
        numeroCoches = numeroCoches + 1
    End Sub

    Protected Overrides Sub finalize()
        Console.WriteLine("Eliminando coche " & modelo)
        Console.ReadLine()
    End Sub

End Class
