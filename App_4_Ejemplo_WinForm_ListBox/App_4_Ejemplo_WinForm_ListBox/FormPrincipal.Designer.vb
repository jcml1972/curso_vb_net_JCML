<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtMultilinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiezCaracteres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMostrarLongitud = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLongitudes = New System.Windows.Forms.Label()
        Me.lstListaDatos = New System.Windows.Forms.ListBox()
        Me.ListaDatos = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnElminardelaLista = New System.Windows.Forms.Button()
        Me.btnAbrirForm = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMultilinea
        '
        Me.txtMultilinea.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.txtMultilinea.Location = New System.Drawing.Point(22, 58)
        Me.txtMultilinea.Multiline = True
        Me.txtMultilinea.Name = "txtMultilinea"
        Me.txtMultilinea.Size = New System.Drawing.Size(290, 80)
        Me.txtMultilinea.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Texto con longitud máxima de 10 carácteres"
        '
        'txtDiezCaracteres
        '
        Me.txtDiezCaracteres.Location = New System.Drawing.Point(22, 171)
        Me.txtDiezCaracteres.MaxLength = 10
        Me.txtDiezCaracteres.Name = "txtDiezCaracteres"
        Me.txtDiezCaracteres.Size = New System.Drawing.Size(290, 20)
        Me.txtDiezCaracteres.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Texto multilínea"
        '
        'btnMostrarLongitud
        '
        Me.btnMostrarLongitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarLongitud.Location = New System.Drawing.Point(22, 197)
        Me.btnMostrarLongitud.Name = "btnMostrarLongitud"
        Me.btnMostrarLongitud.Size = New System.Drawing.Size(157, 32)
        Me.btnMostrarLongitud.TabIndex = 4
        Me.btnMostrarLongitud.Text = "Mostrar Longitud"
        Me.btnMostrarLongitud.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Longitudes:"
        '
        'lblLongitudes
        '
        Me.lblLongitudes.AutoSize = True
        Me.lblLongitudes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitudes.Location = New System.Drawing.Point(29, 257)
        Me.lblLongitudes.Name = "lblLongitudes"
        Me.lblLongitudes.Size = New System.Drawing.Size(84, 16)
        Me.lblLongitudes.TabIndex = 6
        Me.lblLongitudes.Text = "Longitudes"
        '
        'lstListaDatos
        '
        Me.lstListaDatos.FormattingEnabled = True
        Me.lstListaDatos.Items.AddRange(New Object() {"Perro", "Gato", "Murciélago", "Ratón"})
        Me.lstListaDatos.Location = New System.Drawing.Point(401, 58)
        Me.lstListaDatos.Name = "lstListaDatos"
        Me.lstListaDatos.Size = New System.Drawing.Size(249, 134)
        Me.lstListaDatos.TabIndex = 7
        '
        'ListaDatos
        '
        Me.ListaDatos.AutoSize = True
        Me.ListaDatos.Location = New System.Drawing.Point(411, 35)
        Me.ListaDatos.Name = "ListaDatos"
        Me.ListaDatos.Size = New System.Drawing.Size(76, 13)
        Me.ListaDatos.TabIndex = 8
        Me.ListaDatos.Text = "Lista de datos:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(325, 58)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(67, 25)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.Location = New System.Drawing.Point(325, 167)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(67, 25)
        Me.btnAdd2.TabIndex = 10
        Me.btnAdd2.Text = "Añadir"
        Me.btnAdd2.UseVisualStyleBackColor = True
        '
        'btnElminardelaLista
        '
        Me.btnElminardelaLista.Enabled = False
        Me.btnElminardelaLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElminardelaLista.Location = New System.Drawing.Point(508, 202)
        Me.btnElminardelaLista.Name = "btnElminardelaLista"
        Me.btnElminardelaLista.Size = New System.Drawing.Size(142, 25)
        Me.btnElminardelaLista.TabIndex = 11
        Me.btnElminardelaLista.Text = "Eliminar de Lista"
        Me.btnElminardelaLista.UseVisualStyleBackColor = True
        '
        'btnAbrirForm
        '
        Me.btnAbrirForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirForm.Location = New System.Drawing.Point(327, 212)
        Me.btnAbrirForm.Name = "btnAbrirForm"
        Me.btnAbrirForm.Size = New System.Drawing.Size(161, 30)
        Me.btnAbrirForm.TabIndex = 12
        Me.btnAbrirForm.Text = "Abrir FormComboListas"
        Me.btnAbrirForm.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(576, 243)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(74, 27)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(199, 201)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(106, 27)
        Me.btnCambiar.TabIndex = 14
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Texto largo que no entra en label pequeño"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(22, 291)
        Me.DateTimePicker1.MaxDate = New Date(2018, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 16
        Me.DateTimePicker1.Value = New Date(2017, 6, 27, 0, 0, 0, 0)
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(22, 323)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.RightToLeftLayout = True
        Me.MonthCalendar1.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2017, 1, 1, 0, 0, 0, 0), New Date(2017, 1, 7, 0, 0, 0, 0))
        Me.MonthCalendar1.TabIndex = 17
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(673, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 491)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAbrirForm)
        Me.Controls.Add(Me.btnElminardelaLista)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListaDatos)
        Me.Controls.Add(Me.lstListaDatos)
        Me.Controls.Add(Me.lblLongitudes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMostrarLongitud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiezCaracteres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMultilinea)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMultilinea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiezCaracteres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMostrarLongitud As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLongitudes As Label
    Friend WithEvents lstListaDatos As ListBox
    Friend WithEvents ListaDatos As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnElminardelaLista As Button
    Friend WithEvents btnAbrirForm As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnCambiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
End Class
