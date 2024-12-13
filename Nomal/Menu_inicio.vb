
Imports FontAwesome.Sharp
Imports System.IO
Imports WMPLib
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class Menu_inicio
    Private currentBtn As IconButton
    Private leftborderBtn As Panel
    Private currentchildform As Form
    Private info_man As New Info_manager


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        leftborderBtn = New Panel()
        leftborderBtn.Size = New Size(7, 101)
        Panelmenu.Controls.Add(leftborderBtn)

    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            ' Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.Transparent
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleRight
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            ' Left Border
            leftborderBtn.BackColor = customColor
            leftborderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftborderBtn.Visible = True
            leftborderBtn.BringToFront()


        End If
    End Sub
    Private Sub OpenChildForm(childForm As Form)
        ' Open only form
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        currentchildform = childForm
        ' End

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextAlign = ContentAlignment.MiddleRight
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub


    Private Sub usuario(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, Color.Lime)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        OpenChildForm(New Usuario)
        Inicio_sesion.Hide()
    End Sub

    Private Sub admin(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, Color.Yellow)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        Inicio_sesion.Show()
    End Sub

    Private Sub salir(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, Color.Red)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        Alert_box.Alertar(
        "Estas seguro que quieres salir?",
        Sub()
            Me.Close()
        End Sub
        )
        Inicio_sesion.Hide()
    End Sub

    Private Sub Menu_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActivateButton(IconButton4, Color.Purple)
        info_man.leer_lista()

        info_man.intercambiar_nombre()

        info_man.vaciar_lista()
        Pantalla_de_carga.Show()
        'My.Computer.Audio.Play("E:\Oscar Alvarado 510\Visual Studio\Proyecto Enciclopedia\bin\Debug\Syn-Cole-Feel-Good-_NCS-Release_.wav")
        info_man.create_directory()


    End Sub

    Private Sub inicio(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, Color.Purple)
        If currentchildform IsNot Nothing Then
            currentchildform.Close()
        End If
        Inicio_sesion.Hide()
    End Sub


    Public Sub abrir_admin()
        OpenChildForm(New Administrado_1)

    End Sub

    Private Sub Github_button_Click(sender As Object, e As EventArgs) Handles Github_button.Click
        Dim url As String = "https://github.com/Xxgokuamlo99xX/Proyecto-Enciclopedia" 'URL a abrir

        Try
            Process.Start(New ProcessStartInfo(url) With {
                .UseShellExecute = True
            })
        Catch ex As Exception
            MessageBox.Show("No se pudo abrir el enlace. Verifica la URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub creditos_Button_Click(sender As Object, e As EventArgs) Handles creditos_Button.Click
        creditosxd.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fecha As String = DateTime.Now.ToString("d/M/yyyy")
        Dim hora As String = DateTime.Now.ToString("HH:mm:ss")

        fecha_lbl.Text = fecha
        Hora_lbl.Text = hora
    End Sub
End Class