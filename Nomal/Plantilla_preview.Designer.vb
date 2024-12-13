<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Plantilla_preview
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
        Me.Seleccion_lbl = New System.Windows.Forms.Label()
        Me.MashDataSet = New Proyecto_Enciclopedia.mashDataSet()
        Me.PersonajesTableAdapter1 = New Proyecto_Enciclopedia.mashDataSetTableAdapters.personajesTableAdapter()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.id_lbl = New System.Windows.Forms.Label()
        Me.year_lbl = New System.Windows.Forms.Label()
        Me.peso_lbl = New System.Windows.Forms.Label()
        Me.altura_lbl = New System.Windows.Forms.Label()
        Me.saga_lbl = New CuoreUI.Controls.cuiLabel()
        Me.name_lbl = New CuoreUI.Controls.cuiLabel()
        CType(Me.MashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Seleccion_lbl
        '
        Me.Seleccion_lbl.AutoSize = True
        Me.Seleccion_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.Seleccion_lbl.ForeColor = System.Drawing.Color.White
        Me.Seleccion_lbl.Location = New System.Drawing.Point(100, 430)
        Me.Seleccion_lbl.Name = "Seleccion_lbl"
        Me.Seleccion_lbl.Size = New System.Drawing.Size(179, 38)
        Me.Seleccion_lbl.TabIndex = 6
        Me.Seleccion_lbl.Text = "SELECCION"
        Me.Seleccion_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MashDataSet
        '
        Me.MashDataSet.DataSetName = "mashDataSet"
        Me.MashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonajesTableAdapter1
        '
        Me.PersonajesTableAdapter1.ClearBeforeFill = True
        '
        'Imagen
        '
        Me.Imagen.Enabled = False
        Me.Imagen.Image = Global.Proyecto_Enciclopedia.My.Resources.Resources.Unknown_person
        Me.Imagen.Location = New System.Drawing.Point(4, 73)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(150, 162)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Imagen.TabIndex = 12
        Me.Imagen.TabStop = False
        '
        'id_lbl
        '
        Me.id_lbl.AutoSize = True
        Me.id_lbl.BackColor = System.Drawing.Color.Transparent
        Me.id_lbl.Enabled = False
        Me.id_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.id_lbl.ForeColor = System.Drawing.Color.White
        Me.id_lbl.Location = New System.Drawing.Point(12, 9)
        Me.id_lbl.Name = "id_lbl"
        Me.id_lbl.Size = New System.Drawing.Size(53, 38)
        Me.id_lbl.TabIndex = 13
        Me.id_lbl.Text = "Id"
        Me.id_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'year_lbl
        '
        Me.year_lbl.AutoSize = True
        Me.year_lbl.BackColor = System.Drawing.Color.Transparent
        Me.year_lbl.Enabled = False
        Me.year_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.year_lbl.ForeColor = System.Drawing.Color.White
        Me.year_lbl.Location = New System.Drawing.Point(12, 288)
        Me.year_lbl.Name = "year_lbl"
        Me.year_lbl.Size = New System.Drawing.Size(89, 38)
        Me.year_lbl.TabIndex = 16
        Me.year_lbl.Text = "Year"
        Me.year_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'peso_lbl
        '
        Me.peso_lbl.AutoSize = True
        Me.peso_lbl.BackColor = System.Drawing.Color.Transparent
        Me.peso_lbl.Enabled = False
        Me.peso_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.peso_lbl.ForeColor = System.Drawing.Color.White
        Me.peso_lbl.Location = New System.Drawing.Point(12, 335)
        Me.peso_lbl.Name = "peso_lbl"
        Me.peso_lbl.Size = New System.Drawing.Size(89, 38)
        Me.peso_lbl.TabIndex = 17
        Me.peso_lbl.Text = "Peso"
        Me.peso_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'altura_lbl
        '
        Me.altura_lbl.AutoSize = True
        Me.altura_lbl.BackColor = System.Drawing.Color.Transparent
        Me.altura_lbl.Enabled = False
        Me.altura_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.altura_lbl.ForeColor = System.Drawing.Color.White
        Me.altura_lbl.Location = New System.Drawing.Point(12, 390)
        Me.altura_lbl.Name = "altura_lbl"
        Me.altura_lbl.Size = New System.Drawing.Size(125, 38)
        Me.altura_lbl.TabIndex = 18
        Me.altura_lbl.Text = "Altura"
        Me.altura_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'saga_lbl
        '
        Me.saga_lbl.BackColor = System.Drawing.Color.Transparent
        Me.saga_lbl.Content = "The\ legend\ of\ zelda"
        Me.saga_lbl.Enabled = False
        Me.saga_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.saga_lbl.ForeColor = System.Drawing.Color.White
        Me.saga_lbl.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center
        Me.saga_lbl.Location = New System.Drawing.Point(168, 146)
        Me.saga_lbl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.saga_lbl.Name = "saga_lbl"
        Me.saga_lbl.Size = New System.Drawing.Size(193, 138)
        Me.saga_lbl.TabIndex = 19
        '
        'name_lbl
        '
        Me.name_lbl.BackColor = System.Drawing.Color.Transparent
        Me.name_lbl.Content = "Donkey\ kong"
        Me.name_lbl.Enabled = False
        Me.name_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.name_lbl.ForeColor = System.Drawing.Color.White
        Me.name_lbl.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center
        Me.name_lbl.Location = New System.Drawing.Point(168, 13)
        Me.name_lbl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.name_lbl.Name = "name_lbl"
        Me.name_lbl.Size = New System.Drawing.Size(193, 125)
        Me.name_lbl.TabIndex = 20
        '
        'Plantilla_preview
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(374, 477)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.name_lbl)
        Me.Controls.Add(Me.saga_lbl)
        Me.Controls.Add(Me.altura_lbl)
        Me.Controls.Add(Me.peso_lbl)
        Me.Controls.Add(Me.year_lbl)
        Me.Controls.Add(Me.id_lbl)
        Me.Controls.Add(Me.Seleccion_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Plantilla_preview"
        Me.Text = "Plantilla_preview"
        CType(Me.MashDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MashDataSet As mashDataSet
    Friend WithEvents PersonajesTableAdapter1 As mashDataSetTableAdapters.personajesTableAdapter
    Friend WithEvents Seleccion_lbl As Label
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents id_lbl As Label
    Friend WithEvents year_lbl As Label
    Friend WithEvents peso_lbl As Label
    Friend WithEvents altura_lbl As Label
    Friend WithEvents saga_lbl As CuoreUI.Controls.cuiLabel
    Friend WithEvents name_lbl As CuoreUI.Controls.cuiLabel
End Class
