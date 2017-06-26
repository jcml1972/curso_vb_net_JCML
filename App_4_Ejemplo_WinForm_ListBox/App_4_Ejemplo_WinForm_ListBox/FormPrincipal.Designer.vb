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
        Me.txtMultilinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiezCaracteres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLongitudes = New System.Windows.Forms.Label()
        Me.lstListaDatos = New System.Windows.Forms.ListBox()
        Me.ListaDatos = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.btnElminardelaLista = New System.Windows.Forms.Button()
        Me.btnAbrirForm = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMultilinea
        '
        Me.txtMultilinea.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.txtMultilinea.Location = New System.Drawing.Point(22, 32)
        Me.txtMultilinea.Multiline = True
        Me.txtMultilinea.Name = "txtMultilinea"
        Me.txtMultilinea.Size = New System.Drawing.Size(290, 80)
        Me.txtMultilinea.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Texto con longitud máxima de 10 carácteres"
        '
        'txtDiezCaracteres
        '
        Me.txtDiezCaracteres.Location = New System.Drawing.Point(22, 145)
        Me.txtDiezCaracteres.MaxLength = 10
        Me.txtDiezCaracteres.Name = "txtDiezCaracteres"
        Me.txtDiezCaracteres.Size = New System.Drawing.Size(290, 20)
        Me.txtDiezCaracteres.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Texto multilínea"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Mostrar Longitud"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Longitudes:"
        '
        'lblLongitudes
        '
        Me.lblLongitudes.AutoSize = True
        Me.lblLongitudes.Location = New System.Drawing.Point(29, 231)
        Me.lblLongitudes.Name = "lblLongitudes"
        Me.lblLongitudes.Size = New System.Drawing.Size(59, 13)
        Me.lblLongitudes.TabIndex = 6
        Me.lblLongitudes.Text = "Longitudes"
        '
        'lstListaDatos
        '
        Me.lstListaDatos.FormattingEnabled = True
        Me.lstListaDatos.Items.AddRange(New Object() {"Perro", "Gato", "Murciélago", "Ratón"})
        Me.lstListaDatos.Location = New System.Drawing.Point(401, 32)
        Me.lstListaDatos.Name = "lstListaDatos"
        Me.lstListaDatos.Size = New System.Drawing.Size(249, 134)
        Me.lstListaDatos.TabIndex = 7
        '
        'ListaDatos
        '
        Me.ListaDatos.AutoSize = True
        Me.ListaDatos.Location = New System.Drawing.Point(411, 9)
        Me.ListaDatos.Name = "ListaDatos"
        Me.ListaDatos.Size = New System.Drawing.Size(76, 13)
        Me.ListaDatos.TabIndex = 8
        Me.ListaDatos.Text = "Lista de datos:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(325, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(67, 25)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Añadir"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd2.Location = New System.Drawing.Point(325, 141)
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
        Me.btnElminardelaLista.Location = New System.Drawing.Point(508, 176)
        Me.btnElminardelaLista.Name = "btnElminardelaLista"
        Me.btnElminardelaLista.Size = New System.Drawing.Size(142, 25)
        Me.btnElminardelaLista.TabIndex = 11
        Me.btnElminardelaLista.Text = "Eliminar de Lista"
        Me.btnElminardelaLista.UseVisualStyleBackColor = True
        '
        'btnAbrirForm
        '
        Me.btnAbrirForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirForm.Location = New System.Drawing.Point(488, 219)
        Me.btnAbrirForm.Name = "btnAbrirForm"
        Me.btnAbrirForm.Size = New System.Drawing.Size(161, 30)
        Me.btnAbrirForm.TabIndex = 12
        Me.btnAbrirForm.Text = "Abrir FormComboListas"
        Me.btnAbrirForm.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(391, 221)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(74, 27)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 261)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAbrirForm)
        Me.Controls.Add(Me.btnElminardelaLista)
        Me.Controls.Add(Me.btnAdd2)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListaDatos)
        Me.Controls.Add(Me.lstListaDatos)
        Me.Controls.Add(Me.lblLongitudes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDiezCaracteres)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMultilinea)
        Me.Name = "FormPrincipal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMultilinea As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiezCaracteres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLongitudes As Label
    Friend WithEvents lstListaDatos As ListBox
    Friend WithEvents ListaDatos As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents btnElminardelaLista As Button
    Friend WithEvents btnAbrirForm As Button
    Friend WithEvents btnCerrar As Button
End Class
