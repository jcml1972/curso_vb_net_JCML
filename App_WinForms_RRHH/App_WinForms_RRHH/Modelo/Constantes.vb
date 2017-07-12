
Namespace Modelo
        Module Constantes
        ' Public Const RUTA_EMPLEADOS As String = "C:\Users\JuanCarlos\Documents\Visual Studio 2017\"

        Public Const CADENA_CONEX_EXCEL As String = "Provider=Microsoft.ACE.OLEDB.12.0;" &
                                                    "Extended Properties='Excel 12.0 Xml;HDR=No';" &
                                                    "Data Source="

        Public Const CADENA_CONEX_ACCESS As String = "Provider=Microsoft.Jet.OLEDB.4.0;" &
            "Data Source=" 'Justo aquí tiene que ir el nombre del fichero
        ' Si la BD tuviera password habría que añadir, añadir separado por punto y coma, usuario y password
        ' TODO: Añadir ";User Id=admin;Password=Contraseña_1234"

    End Module
    End Namespace

