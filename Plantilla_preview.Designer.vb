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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.high_TextBox = New System.Windows.Forms.TextBox()
        Me.Peso_TextBox = New System.Windows.Forms.TextBox()
        Me.year_TextBox = New System.Windows.Forms.TextBox()
        Me.saga_TextBox = New System.Windows.Forms.TextBox()
        Me.name_textBox = New System.Windows.Forms.TextBox()
        Me.Id_TextBox = New System.Windows.Forms.TextBox()
        Me.MashDataSet = New Proyecto_Enciclopedia.mashDataSet()
        Me.PersonajesTableAdapter1 = New Proyecto_Enciclopedia.mashDataSetTableAdapters.personajesTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.MashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 240)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(350, 223)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Descripcion del presonaje:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.high_TextBox)
        Me.Panel1.Controls.Add(Me.Peso_TextBox)
        Me.Panel1.Controls.Add(Me.year_TextBox)
        Me.Panel1.Controls.Add(Me.saga_TextBox)
        Me.Panel1.Controls.Add(Me.name_textBox)
        Me.Panel1.Controls.Add(Me.Id_TextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 231)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(85, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SELECCION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'high_TextBox
        '
        Me.high_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.high_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.high_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.high_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.high_TextBox.ForeColor = System.Drawing.Color.White
        Me.high_TextBox.Location = New System.Drawing.Point(0, 185)
        Me.high_TextBox.Name = "high_TextBox"
        Me.high_TextBox.ReadOnly = True
        Me.high_TextBox.Size = New System.Drawing.Size(350, 37)
        Me.high_TextBox.TabIndex = 4
        Me.high_TextBox.Text = "Altura"
        Me.high_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Peso_TextBox
        '
        Me.Peso_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Peso_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Peso_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Peso_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Peso_TextBox.ForeColor = System.Drawing.Color.White
        Me.Peso_TextBox.Location = New System.Drawing.Point(0, 148)
        Me.Peso_TextBox.Name = "Peso_TextBox"
        Me.Peso_TextBox.ReadOnly = True
        Me.Peso_TextBox.Size = New System.Drawing.Size(350, 37)
        Me.Peso_TextBox.TabIndex = 3
        Me.Peso_TextBox.Text = "Peso"
        Me.Peso_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'year_TextBox
        '
        Me.year_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.year_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.year_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.year_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year_TextBox.ForeColor = System.Drawing.Color.White
        Me.year_TextBox.Location = New System.Drawing.Point(0, 111)
        Me.year_TextBox.Name = "year_TextBox"
        Me.year_TextBox.ReadOnly = True
        Me.year_TextBox.Size = New System.Drawing.Size(350, 37)
        Me.year_TextBox.TabIndex = 2
        Me.year_TextBox.Text = "Year"
        Me.year_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'saga_TextBox
        '
        Me.saga_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saga_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.saga_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.saga_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saga_TextBox.ForeColor = System.Drawing.Color.White
        Me.saga_TextBox.Location = New System.Drawing.Point(0, 74)
        Me.saga_TextBox.Name = "saga_TextBox"
        Me.saga_TextBox.ReadOnly = True
        Me.saga_TextBox.Size = New System.Drawing.Size(350, 37)
        Me.saga_TextBox.TabIndex = 1
        Me.saga_TextBox.Text = "Saga"
        Me.saga_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name_textBox
        '
        Me.name_textBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_textBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.name_textBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_textBox.ForeColor = System.Drawing.Color.White
        Me.name_textBox.Location = New System.Drawing.Point(0, 37)
        Me.name_textBox.Name = "name_textBox"
        Me.name_textBox.ReadOnly = True
        Me.name_textBox.Size = New System.Drawing.Size(350, 37)
        Me.name_textBox.TabIndex = 0
        Me.name_textBox.Text = "Nombre"
        Me.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Id_TextBox
        '
        Me.Id_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Id_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Id_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_TextBox.ForeColor = System.Drawing.Color.White
        Me.Id_TextBox.Location = New System.Drawing.Point(0, 0)
        Me.Id_TextBox.Name = "Id_TextBox"
        Me.Id_TextBox.ReadOnly = True
        Me.Id_TextBox.Size = New System.Drawing.Size(350, 37)
        Me.Id_TextBox.TabIndex = 5
        Me.Id_TextBox.Text = "Id"
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 478)
        Me.Panel2.TabIndex = 8
        '
        'Plantilla_preview
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(374, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Plantilla_preview"
        Me.Text = "Plantilla_preview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MashDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MashDataSet As mashDataSet
    Friend WithEvents PersonajesTableAdapter1 As mashDataSetTableAdapters.personajesTableAdapter
    Friend WithEvents name_textBox As TextBox
    Friend WithEvents high_TextBox As TextBox
    Friend WithEvents Peso_TextBox As TextBox
    Friend WithEvents year_TextBox As TextBox
    Friend WithEvents saga_TextBox As TextBox
    Friend WithEvents Id_TextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
