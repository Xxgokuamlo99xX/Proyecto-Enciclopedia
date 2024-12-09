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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.high_TextBox = New System.Windows.Forms.TextBox()
        Me.Peso_TextBox = New System.Windows.Forms.TextBox()
        Me.year_TextBox = New System.Windows.Forms.TextBox()
        Me.saga_TextBox = New System.Windows.Forms.TextBox()
        Me.name_textBox = New System.Windows.Forms.TextBox()
        Me.Id_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MashDataSet = New Proyecto_Enciclopedia.mashDataSet()
        Me.PersonajesTableAdapter1 = New Proyecto_Enciclopedia.mashDataSetTableAdapters.personajesTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.MashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Id_TextBox)
        Me.Panel1.Controls.Add(Me.high_TextBox)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Peso_TextBox)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.year_TextBox)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.saga_TextBox)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.name_textBox)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 410)
        Me.Panel1.TabIndex = 7
        '
        'high_TextBox
        '
        Me.high_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.high_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.high_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.high_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.high_TextBox.ForeColor = System.Drawing.Color.White
        Me.high_TextBox.Location = New System.Drawing.Point(0, 368)
        Me.high_TextBox.Name = "high_TextBox"
        Me.high_TextBox.ReadOnly = True
        Me.high_TextBox.Size = New System.Drawing.Size(350, 44)
        Me.high_TextBox.TabIndex = 4
        Me.high_TextBox.Text = "Altura: 1.54"
        '
        'Peso_TextBox
        '
        Me.Peso_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Peso_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Peso_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Peso_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.Peso_TextBox.ForeColor = System.Drawing.Color.White
        Me.Peso_TextBox.Location = New System.Drawing.Point(0, 287)
        Me.Peso_TextBox.Name = "Peso_TextBox"
        Me.Peso_TextBox.ReadOnly = True
        Me.Peso_TextBox.Size = New System.Drawing.Size(350, 44)
        Me.Peso_TextBox.TabIndex = 3
        Me.Peso_TextBox.Text = "Peso: 57"
        '
        'year_TextBox
        '
        Me.year_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.year_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.year_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.year_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.year_TextBox.ForeColor = System.Drawing.Color.White
        Me.year_TextBox.Location = New System.Drawing.Point(0, 206)
        Me.year_TextBox.Name = "year_TextBox"
        Me.year_TextBox.ReadOnly = True
        Me.year_TextBox.Size = New System.Drawing.Size(350, 44)
        Me.year_TextBox.TabIndex = 2
        Me.year_TextBox.Text = "Year: 1957"
        '
        'saga_TextBox
        '
        Me.saga_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.saga_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.saga_TextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.saga_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.saga_TextBox.ForeColor = System.Drawing.Color.White
        Me.saga_TextBox.Location = New System.Drawing.Point(0, 125)
        Me.saga_TextBox.Name = "saga_TextBox"
        Me.saga_TextBox.ReadOnly = True
        Me.saga_TextBox.Size = New System.Drawing.Size(350, 44)
        Me.saga_TextBox.TabIndex = 1
        Me.saga_TextBox.Text = "Saga"
        Me.saga_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'name_textBox
        '
        Me.name_textBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_textBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.name_textBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.name_textBox.ForeColor = System.Drawing.Color.White
        Me.name_textBox.Location = New System.Drawing.Point(0, 44)
        Me.name_textBox.Name = "name_textBox"
        Me.name_textBox.ReadOnly = True
        Me.name_textBox.Size = New System.Drawing.Size(350, 44)
        Me.name_textBox.TabIndex = 0
        Me.name_textBox.Text = "Nombre"
        Me.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Id_TextBox
        '
        Me.Id_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Id_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Id_TextBox.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_TextBox.ForeColor = System.Drawing.Color.White
        Me.Id_TextBox.Location = New System.Drawing.Point(13, 3)
        Me.Id_TextBox.Name = "Id_TextBox"
        Me.Id_TextBox.ReadOnly = True
        Me.Id_TextBox.Size = New System.Drawing.Size(41, 37)
        Me.Id_TextBox.TabIndex = 5
        Me.Id_TextBox.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SELECCION"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 478)
        Me.Panel2.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(0, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(350, 37)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox2.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(0, 0)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(350, 44)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox3.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(0, 250)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(350, 37)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox4.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(0, 331)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(350, 37)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TextBox5.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(0, 88)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(350, 37)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 26.2!)
        Me.TextBox6.ForeColor = System.Drawing.Color.Black
        Me.TextBox6.Location = New System.Drawing.Point(-8, 46)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(344, 44)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Text = "Nombre"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
End Class
