Public Class ConsecucionObjetivo

    Public objetivoBase As Single
    Public objetivoPropio As Single
    Private porcentajeSobreBase As Single

    Public Sub New(objBase As Single, objPropio As Single)

        objetivoBase = objBase
        objetivoPropio = objPropio
        porcentajeSobreBase = (objPropio / objBase) * 100

    End Sub
    Public Function DevolverPorcentaje() As Single

        Return porcentajeSobreBase

    End Function


End Class
