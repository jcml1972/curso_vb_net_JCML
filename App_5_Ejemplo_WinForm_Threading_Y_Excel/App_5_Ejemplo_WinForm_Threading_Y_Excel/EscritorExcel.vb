Public Class EscritorExcel

    Private _excelObj As Object

    Public Shared Sub NuevoExcelFijo(nombreFichero As String)
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
