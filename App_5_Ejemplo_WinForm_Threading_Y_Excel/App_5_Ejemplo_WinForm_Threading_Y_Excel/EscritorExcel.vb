Public Class EscritorExcel

    Private _excelObj As Object

    Public Shared Sub NuevoExcelFijo(nombreFichero As String)
        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object
        ' Creamos un objeto cuyo contenido es una instancia de Excel
        oExcel = CreateObject("Excel.Application")
        ' Comenzar nuevo libro de excel
        oLibro = oExcel.Workbooks.Add
        oHoja = oLibro.Worksheets(1)

        Dim ArrayDatos(99, 2) As String
        Dim r As Integer
        For r = 0 To 99
            ArrayDatos(r, 0) = "FACTURA_" & Format(r, "0000")
            ArrayDatos(r, 1) = Rnd() * 1000
            ArrayDatos(r, 2) = ArrayDatos(r, 1) * 0.21
        Next
        oHoja.range("A1:C1").value = New String() {"ID FACTURA", "Precio", "I.V.A."}
        oHoja.Range("A2").resize(100, 3).value = ArrayDatos

        ' Guardar el libro y salir de Excel
        oLibro.SaveAs(nombreFichero)
        oExcel.Quit()

    End Sub

    Public Shared Sub NuevoExcelFijo_2(nombreFichero As String)
        Dim oExcel As Object
        Dim oLibro As Object
        Dim oHoja As Object
        ' Comenzar nuevo libro de excel
        oExcel = CreateObject("Excel.Application")
        oLibro = oExcel.Workbooks.Add
        ' Añadimos datos a la hoja
        oHoja = oLibro.Worksheets(1)
        oHoja.Range("A1").Value = "Nombre de pila"
        oHoja.Range("B1").Value = "Apellidos"
        oHoja.Range("A1:B1").Font.Bold = True
        oHoja.Range("A2").value = "Juan Carlos"
        oHoja.Range("B2").value = "Martín Linares"
        ' Guardar el libro y salir de Excel
        oLibro.saveas(nombreFichero)
        oExcel.Quit()
    End Sub
End Class
