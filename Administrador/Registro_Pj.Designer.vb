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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label2.Location = New System.Drawing.Point(8, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.nombre.Location = New System.Drawing.Point(110, 26)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(151, 24)
        Me.nombre.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label3.Location = New System.Drawing.Point(23, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Saga"
        '
        'saga
        '
        Me.saga.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.saga.Location = New System.Drawing.Point(110, 91)
        Me.saga.Name = "saga"
        Me.saga.Size = New System.Drawing.Size(151, 24)
        Me.saga.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label4.Location = New System.Drawing.Point(23, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Año"
        '
        'year
        '
        Me.year.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.year.Location = New System.Drawing.Point(110, 153)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(151, 24)
        Me.year.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label6.Location = New System.Drawing.Point(23, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Altura"
        '
        'alt
        '
        Me.alt.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.alt.Location = New System.Drawing.Point(110, 278)
        Me.alt.Name = "alt"
        Me.alt.Size = New System.Drawing.Size(151, 24)
        Me.alt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label7.Location = New System.Drawing.Point(23, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Peso"
        '
        'peso
        '
        Me.peso.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.peso.Location = New System.Drawing.Point(110, 213)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(151, 24)
        Me.peso.TabIndex = 8
        '
        'no
        '
        Me.no.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.no.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.no.Location = New System.Drawing.Point(186, 427)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(83, 30)
        Me.no.TabIndex = 13
        Me.no.Text = "Cancelar"
        Me.no.UseVisualStyleBackColor = True
        '
        'accept
        '
        Me.accept.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!)
        Me.accept.Location = New System.Drawing.Point(62, 427)
        Me.accept.Name = "accept"
        Me.accept.Size = New System.Drawing.Size(76, 30)
        Me.accept.TabIndex = 12
        Me.accept.Text = "Aceptar"
        Me.accept.UseVisualStyleBackColor = True
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(123, 363)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 47)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label1.Location = New System.Drawing.Point(129, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Color"
        '
        'Registro_Pj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(308, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Registro_Pj"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Personaje"
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
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
