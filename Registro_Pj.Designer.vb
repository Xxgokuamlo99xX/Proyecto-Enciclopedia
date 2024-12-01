<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_Pj
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.alt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.peso = New System.Windows.Forms.TextBox()
        Me.no = New System.Windows.Forms.Button()
        Me.accept = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(110, 26)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(151, 22)
        Me.nombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Saga"
        '
        'saga
        '
        Me.saga.Location = New System.Drawing.Point(110, 91)
        Me.saga.Name = "saga"
        Me.saga.Size = New System.Drawing.Size(151, 22)
        Me.saga.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Año"
        '
        'year
        '
        Me.year.Location = New System.Drawing.Point(110, 153)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(151, 22)
        Me.year.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Altura"
        '
        'alt
        '
        Me.alt.Location = New System.Drawing.Point(110, 278)
        Me.alt.Name = "alt"
        Me.alt.Size = New System.Drawing.Size(151, 22)
        Me.alt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Peso"
        '
        'peso
        '
        Me.peso.Location = New System.Drawing.Point(110, 213)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(151, 22)
        Me.peso.TabIndex = 8
        '
        'no
        '
        Me.no.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.no.Location = New System.Drawing.Point(186, 383)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(75, 30)
        Me.no.TabIndex = 13
        Me.no.Text = "Cancelar"
        Me.no.UseVisualStyleBackColor = True
        '
        'accept
        '
        Me.accept.Location = New System.Drawing.Point(62, 383)
        Me.accept.Name = "accept"
        Me.accept.Size = New System.Drawing.Size(76, 30)
        Me.accept.TabIndex = 12
        Me.accept.Text = "Aceptar"
        Me.accept.UseVisualStyleBackColor = True
        '
        'Registro_Pj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 425)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.accept)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.alt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.peso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.saga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Registro_Pj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro_Pj"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents saga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents alt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents peso As TextBox
    Friend WithEvents no As Button
    Friend WithEvents accept As Button
End Class
