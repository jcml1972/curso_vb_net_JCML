<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Excel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtRutaFichero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreHoja = New System.Windows.Forms.Label()
        Me.txtNombreHoja = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtColumna = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblValorCelda = New System.Windows.Forms.Label()
        Me.btnMuestraValorCelda = New System.Windows.Forms.Button()
        Me.numFila = New System.Windows.Forms.NumericUpDown()
        CType(Me.numFila, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRutaFichero
        '
        Me.txtRutaFichero.Location = New System.Drawing.Point(139, 23)
        Me.txtRutaFichero.Name = "txtRutaFichero"
        Me.txtRutaFichero.Size = New System.Drawing.Size(295, 20)
        Me.txtRutaFichero.TabIndex = 0
        Me.txtRutaFichero.Text = "C:\Users\JuanCarlos\Documents\Ejemplo - Caso programacion excel.xlsx"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta del Fichero:"
        '
        'NombreHoja
        '
        Me.NombreHoja.AutoSize = True
        Me.NombreHoja.Location = New System.Drawing.Point(35, 57)
        Me.NombreHoja.Name = "NombreHoja"
        Me.NombreHoja.Size = New System.Drawing.Size(98, 13)
        Me.NombreHoja.TabIndex = 3
        Me.NombreHoja.Text = "Nombre de la Hoja:"
        '
        'txtNombreHoja
        '
        Me.txtNombreHoja.Location = New System.Drawing.Point(139, 54)
        Me.txtNombreHoja.Name = "txtNombreHoja"
        Me.txtNombreHoja.Size = New System.Drawing.Size(194, 20)
        Me.txtNombreHoja.TabIndex = 2
        Me.txtNombreHoja.Text = "Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Columna:"
        '
        'txtColumna
        '
        Me.txtColumna.Location = New System.Drawing.Point(139, 86)
        Me.txtColumna.Name = "txtColumna"
        Me.txtColumna.Size = New System.Drawing.Size(70, 20)
        Me.txtColumna.TabIndex = 4
        Me.txtColumna.Text = "F"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fila:"
        '
        'lblValorCelda
        '
        Me.lblValorCelda.AutoSize = True
        Me.lblValorCelda.Location = New System.Drawing.Point(222, 179)
        Me.lblValorCelda.Name = "lblValorCelda"
        Me.lblValorCelda.Size = New System.Drawing.Size(87, 13)
        Me.lblValorCelda.TabIndex = 9
        Me.lblValorCelda.Text = "Valor de la Celda"
        '
        'btnMuestraValorCelda
        '
        Me.btnMuestraValorCelda.Location = New System.Drawing.Point(33, 164)
        Me.btnMuestraValorCelda.Name = "btnMuestraValorCelda"
        Me.btnMuestraValorCelda.Size = New System.Drawing.Size(153, 43)
        Me.btnMuestraValorCelda.TabIndex = 10
        Me.btnMuestraValorCelda.Text = "Muestra el valor de la celda"
        Me.btnMuestraValorCelda.UseVisualStyleBackColor = True
        '
        'numFila
        '
        Me.numFila.Location = New System.Drawing.Point(141, 115)
        Me.numFila.Maximum = New Decimal(New Integer() {65365, 0, 0, 0})
        Me.numFila.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numFila.Name = "numFila"
        Me.numFila.Size = New System.Drawing.Size(93, 20)
        Me.numFila.TabIndex = 11
        Me.numFila.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Form_Excel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 261)
        Me.Controls.Add(Me.numFila)
        Me.Controls.Add(Me.btnMuestraValorCelda)
        Me.Controls.Add(Me.lblValorCelda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtColumna)
        Me.Controls.Add(Me.NombreHoja)
        Me.Controls.Add(Me.txtNombreHoja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRutaFichero)
        Me.Name = "Form_Excel"
        Me.Text = "Form_Excel"
        CType(Me.numFila, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRutaFichero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreHoja As Label
    Friend WithEvents txtNombreHoja As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtColumna As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblValorCelda As Label
    Friend WithEvents btnMuestraValorCelda As Button
    Friend WithEvents numFila As NumericUpDown
End Class
