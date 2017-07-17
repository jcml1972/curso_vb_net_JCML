Imports System.Windows.Forms
Imports App_WinForms_RRHH.Modelo

Public Class MDI_Principal

    Private frmAlta As Form_Alta
    Private frmBusqueda As Form_Busqueda
    Private frmModificacion As Form_Modificacion

    Private Sub abrir_Formulario(Of TForm As {Form, New})(ByRef formulario As TForm)
        If formulario Is Nothing OrElse formulario.IsDisposed() Then
            formulario = New TForm()
            formulario.MdiParent = Me
            formulario.Show()
        Else
            formulario.Show()
            ActivateMdiChild(formulario)
        End If
        formulario.Activate()
    End Sub
    Public Sub AbrirAlta()
        abrir_Formulario(Of Form_Alta)(frmAlta)
    End Sub
    Public Sub AbrirBusqueda()
        abrir_Formulario(Of Form_Busqueda)(frmBusqueda)
    End Sub

    Public Sub AbrirModificacion()
        abrir_Formulario(Of Form_Modificacion)(frmModificacion)
    End Sub

    Private Sub BusquedaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BusquedaToolStripMenuItem.Click
        abrir_Formulario(Of Form_Busqueda)(frmBusqueda)
    End Sub

    Private Sub AltaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltaToolStripMenuItem.Click
        AbrirAlta()
    End Sub

    Private Sub AltasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AltasToolStripMenuItem.Click
        abrir_Formulario(Of Form_Alta)(frmAlta)
    End Sub

    ' CÓDIGO GENERADO POR VISUAL STUDIO

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDI_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1
        EmpleadosToolStripMenuItem.Enabled = False
        EmpleadosCRUD.avisarEnModificacion = AddressOf HabilitarMenusGuardarExportar
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer https://www.bbva.es")
    End Sub

    Private Sub CambiarFuenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFuenteToolStripMenuItem.Click
        Dim dialogoFuente As New FontDialog
        If dialogoFuente.ShowDialog(Me) = DialogResult.OK Then
            Me.Font = dialogoFuente.Font
            For Each formulario In Me.MdiChildren
                formulario.Font = dialogoFuente.Font
            Next
        End If
    End Sub

    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónToolStripMenuItem.Click
        AbrirModificacion()
    End Sub

    Private empleadosFichero As New EmpleadosFichero
    Private empleadosExcel As New EmpleadosExcel
    Private empleadosAccess As New EmpleadosAccess
    Private empleadosGenerador As New EmpleadosGenerador


    Private Function DialogoAbrirFichero(extension As String) As String
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*." & extension & ")|*." & extension & "|Todos los archivos (*.*)|*.*"
        OpenFileDialog.CheckFileExists = True
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            EmpleadosToolStripMenuItem.Enabled = True
            Return OpenFileDialog.FileName
        Else
            Return ""
        End If
    End Function

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        empleadosFichero.NombreFichero = DialogoAbrirFichero("csv")
        EmpleadosCRUD.Restaurar(empleadosFichero)
        HabilitarMenusGuardarExportar(True)
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        empleadosFichero.NombreFichero = DialogoGuardarFichero("csv")
        EmpleadosCRUD.Grabar(empleadosFichero)
    End Sub

    Private Function DialogoGuardarFichero(extension As String) As String
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = empleadosFichero.NombreFichero
        SaveFileDialog.Filter = "Archivos de texto (*." & extension & ")|*." & extension & "|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Return SaveFileDialog.FileName
        Else
            Return ""
        End If
    End Function

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        EmpleadosCRUD.Grabar(empleadosFichero)
    End Sub

    Private Sub ImportarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarExcelToolStripMenuItem.Click
        empleadosExcel.NombreFichero = DialogoAbrirFichero("xlsx")
        EmpleadosCRUD.Restaurar(empleadosExcel)
        HabilitarMenusGuardarExportar(True)
    End Sub

    Private Sub ExportarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarExcelToolStripMenuItem.Click
        empleadosExcel.NombreFichero = DialogoGuardarFichero("xlsx")
        EmpleadosCRUD.Grabar(empleadosExcel)
    End Sub

    Private Sub ImportarAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportarAccessToolStripMenuItem.Click
        empleadosAccess.NombreFichero = DialogoAbrirFichero("mdb")
        EmpleadosCRUD.Restaurar(empleadosAccess)
        HabilitarMenusGuardarExportar(True)
    End Sub

    Private Sub ExportarAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAccessToolStripMenuItem.Click
        empleadosAccess.NombreFichero = DialogoGuardarFichero("mdb")
        EmpleadosCRUD.Grabar(empleadosAccess)
    End Sub

    Sub HabilitarMenusGuardarExportar(estado As Boolean)
        SaveToolStripMenuItem.Enabled = estado
        SaveAsToolStripMenuItem.Enabled = estado
        ExportarExcelToolStripMenuItem.Enabled = estado
        SaveToolStripButton.Enabled = estado
        ExportarAccessToolStripMenuItem.Enabled = estado
    End Sub

    Private Sub GeneradorEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneradorEmpleadosToolStripMenuItem.Click
        EmpleadosCRUD.Restaurar(empleadosGenerador)
        HabilitarMenusGuardarExportar(True)
    End Sub
End Class
