<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actualizar_pj
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.no = New System.Windows.Forms.Button()
        Me.accept = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.alt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.peso = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.saga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 14.2!)
        Me.Label1.Location = New System.Drawing.Point(102, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Color"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(99, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(77, 47)
        Me.Panel1.TabIndex = 29
        '
        'no
        '
        Me.no.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.no.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.no.Location = New System.Drawing.Point(164, 408)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(82, 30)
        Me.no.TabIndex = 28
        Me.no.Text = "Cancelar"
        Me.no.UseVisualStyleBackColor = True
        '
        'accept
        '
        Me.accept.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accept.Location = New System.Drawing.Point(40, 408)
        Me.accept.Name = "accept"
        Me.accept.Size = New System.Drawing.Size(76, 30)
        Me.accept.TabIndex = 27
        Me.accept.Text = "Aceptar"
        Me.accept.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label6.Location = New System.Drawing.Point(6, 261)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Altura"
        '
        'alt
        '
        Me.alt.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alt.Location = New System.Drawing.Point(88, 259)
        Me.alt.Name = "alt"
        Me.alt.Size = New System.Drawing.Size(151, 24)
        Me.alt.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label7.Location = New System.Drawing.Point(20, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 22)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Peso"
        '
        'peso
        '
        Me.peso.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peso.Location = New System.Drawing.Point(88, 194)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(151, 24)
        Me.peso.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label4.Location = New System.Drawing.Point(28, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 22)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Año"
        '
        'year
        '
        Me.year.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(88, 134)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(151, 24)
        Me.year.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label3.Location = New System.Drawing.Point(19, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Saga"
        '
        'saga
        '
        Me.saga.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saga.Location = New System.Drawing.Point(88, 72)
        Me.saga.Name = "saga"
        Me.saga.Size = New System.Drawing.Size(151, 24)
        Me.saga.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.2!)
        Me.Label2.Location = New System.Drawing.Point(5, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 22)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre"
        '
        'nombre
        '
        Me.nombre.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.Location = New System.Drawing.Point(88, 7)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(151, 24)
        Me.nombre.TabIndex = 17
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.Proyecto_Enciclopedia.My.Resources.Resources._3ae913d2143c423e8bc05c49d4186578
        Me.PictureBox1.Location = New System.Drawing.Point(209, 314)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 73)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 20.2!)
        Me.Label5.Location = New System.Drawing.Point(336, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 35)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Imagen"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.Proyecto_Enciclopedia.My.Resources.Resources.Unknown_person
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Location = New System.Drawing.Point(316, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 181)
        Me.Panel2.TabIndex = 32
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """Archivos PNG (*.png)|*.png"""
        '
        'actualizar_pj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(520, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "actualizar_pj"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Personaje"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents no As Button
    Friend WithEvents accept As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents alt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents peso As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents saga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
