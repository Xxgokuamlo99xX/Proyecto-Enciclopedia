<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_inicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_inicio))
        Me.MashDataSet1 = New Proyecto_Enciclopedia.mashDataSet()
        Me.Panelmenu = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Hora_lbl = New System.Windows.Forms.Label()
        Me.fecha_lbl = New System.Windows.Forms.Label()
        Me.Github_button = New System.Windows.Forms.Button()
        Me.creditos_Button = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.MashDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelmenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MashDataSet1
        '
        Me.MashDataSet1.DataSetName = "mashDataSet"
        Me.MashDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panelmenu
        '
        Me.Panelmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panelmenu.Controls.Add(Me.IconButton3)
        Me.Panelmenu.Controls.Add(Me.IconButton1)
        Me.Panelmenu.Controls.Add(Me.IconButton2)
        Me.Panelmenu.Controls.Add(Me.IconButton4)
        Me.Panelmenu.Controls.Add(Me.Panel2)
        Me.Panelmenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panelmenu.Location = New System.Drawing.Point(0, 0)
        Me.Panelmenu.Name = "Panelmenu"
        Me.Panelmenu.Size = New System.Drawing.Size(200, 586)
        Me.Panelmenu.TabIndex = 2
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.Transparent
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.IconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 20.0!)
        Me.IconButton3.ForeColor = System.Drawing.Color.White
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 460)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(200, 101)
        Me.IconButton3.TabIndex = 3
        Me.IconButton3.Text = "Salir"
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.Transparent
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.IconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 12.0!)
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Pencil
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 359)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(200, 101)
        Me.IconButton1.TabIndex = 1
        Me.IconButton1.Text = "Administrador"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.Transparent
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.IconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 20.0!)
        Me.IconButton2.ForeColor = System.Drawing.Color.White
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 258)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(200, 101)
        Me.IconButton2.TabIndex = 2
        Me.IconButton2.Text = "Usuario"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'IconButton4
        '
        Me.IconButton4.AutoSize = True
        Me.IconButton4.BackColor = System.Drawing.Color.Transparent
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.IconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 20.0!)
        Me.IconButton4.ForeColor = System.Drawing.Color.White
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.House
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 157)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Size = New System.Drawing.Size(200, 101)
        Me.IconButton4.TabIndex = 4
        Me.IconButton4.Text = "Inicio"
        Me.IconButton4.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 157)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 157)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.AutoSize = True
        Me.PanelDesktop.BackColor = System.Drawing.Color.LightGreen
        Me.PanelDesktop.BackgroundImage = Global.Proyecto_Enciclopedia.My.Resources.Resources._581e7fdaca3b1730707383226ba9cf5f
        Me.PanelDesktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelDesktop.Controls.Add(Me.Panel1)
        Me.PanelDesktop.Controls.Add(Me.Github_button)
        Me.PanelDesktop.Controls.Add(Me.creditos_Button)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(200, 0)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(941, 586)
        Me.PanelDesktop.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Hora_lbl)
        Me.Panel1.Controls.Add(Me.fecha_lbl)
        Me.Panel1.Location = New System.Drawing.Point(758, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 100)
        Me.Panel1.TabIndex = 4
        '
        'Hora_lbl
        '
        Me.Hora_lbl.AutoSize = True
        Me.Hora_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Hora_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Hora_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Hora_lbl.Location = New System.Drawing.Point(0, 38)
        Me.Hora_lbl.Name = "Hora_lbl"
        Me.Hora_lbl.Size = New System.Drawing.Size(125, 38)
        Me.Hora_lbl.TabIndex = 2
        Me.Hora_lbl.Text = "12:0:0"
        '
        'fecha_lbl
        '
        Me.fecha_lbl.AutoSize = True
        Me.fecha_lbl.BackColor = System.Drawing.Color.Transparent
        Me.fecha_lbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.fecha_lbl.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fecha_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.fecha_lbl.Location = New System.Drawing.Point(0, 0)
        Me.fecha_lbl.Name = "fecha_lbl"
        Me.fecha_lbl.Size = New System.Drawing.Size(179, 38)
        Me.fecha_lbl.TabIndex = 3
        Me.fecha_lbl.Text = "8/12/2024"
        '
        'Github_button
        '
        Me.Github_button.BackColor = System.Drawing.Color.Transparent
        Me.Github_button.FlatAppearance.BorderSize = 0
        Me.Github_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Github_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Github_button.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Github_button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Github_button.Location = New System.Drawing.Point(772, 485)
        Me.Github_button.Name = "Github_button"
        Me.Github_button.Size = New System.Drawing.Size(166, 46)
        Me.Github_button.TabIndex = 1
        Me.Github_button.Text = "Github"
        Me.Github_button.UseVisualStyleBackColor = False
        '
        'creditos_Button
        '
        Me.creditos_Button.BackColor = System.Drawing.Color.Transparent
        Me.creditos_Button.FlatAppearance.BorderSize = 0
        Me.creditos_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.creditos_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.creditos_Button.Font = New System.Drawing.Font("Fixedsys Excelsior 3.01", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.creditos_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.creditos_Button.Location = New System.Drawing.Point(771, 537)
        Me.creditos_Button.Name = "creditos_Button"
        Me.creditos_Button.Size = New System.Drawing.Size(166, 46)
        Me.creditos_Button.TabIndex = 0
        Me.creditos_Button.Text = "Creditos"
        Me.creditos_Button.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Menu_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 586)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panelmenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu_inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enciclopedia"
        CType(Me.MashDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelmenu.ResumeLayout(False)
        Me.Panelmenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents MashDataSet1 As mashDataSet
    Friend WithEvents Panelmenu As Panel
    Friend WithEvents Github_button As Button
    Friend WithEvents creditos_Button As Button
    Friend WithEvents Hora_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents fecha_lbl As Label
    Friend WithEvents Timer1 As Timer
End Class
