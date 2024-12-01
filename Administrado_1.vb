Public Class Administrado_1
    Private currentchildform As Form
    Public info_man As New Info_manager
    Public Shared form_selec_id As Integer = 0
    Public Shared nom_selec_id As String
    Public Shared saga_selec_id As String
    Public Shared year_selec_id As Integer
    Public Shared peso_selec_id As Double
    Public Shared altura_selec_id As Double
    Public Shared color_selec_id As Color


    Private Sub OpenChildForm(childForm As Form)

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Left
        Panel_plantilla.Controls.Add(childForm)
        Panel_plantilla.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub Administrado_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel_plantilla.AutoScroll = True
        For i As Integer = info_man.id_getter() - 1 To 0 Step -1

            OpenChildForm(New Plantilla_preview)

        Next

    End Sub

    Public Sub actualizar()
        CerrarFormasEnPanel(Panel_plantilla)
        For i As Integer = info_man.id_getter() - 1 To 0 Step -1

            OpenChildForm(New Plantilla_preview)

        Next
    End Sub
    Private Sub CerrarFormasEnPanel(panel As Panel)
        Plantilla_preview.ReiniciarContador()
        For Each control As Control In panel.Controls

            If TypeOf control Is Form Then
                Dim formaIncrustada As Form = CType(control, Form)
                If Not formaIncrustada.IsDisposed Then
                    formaIncrustada.Close()
                End If
            End If
        Next


        panel.Controls.Clear()
    End Sub

    Private Sub Agregar(sender As Object, e As EventArgs) Handles IconButton1.Click
        Registro_Pj.Show()

    End Sub

    Private Sub borrar(sender As Object, e As EventArgs) Handles IconButton2.Click
        If form_selec_id <> 0 Then

            Alert_box.Alertar(
            "Vas a borrar un registro. " & vbCrLf & "Estas seguro?",
            Sub()
                Plantilla_preview.PersonajesTableAdapter1.Borrar_Pj(form_selec_id)
                Console.WriteLine("hola que hacen" & form_selec_id)
                actualizar()
            End Sub)
        Else
            MsgBox("Selecciona un registro primero!")
        End If
    End Sub

    Private Sub Administrado_1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CerrarFormasEnPanel(Panel_plantilla)

    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        actualizar()
    End Sub

    Private Sub Update_pj(sender As Object, e As EventArgs) Handles IconButton4.Click
        If form_selec_id <> 0 Then

            actualizar_pj.Show()
            'sexooooooooooooooooo!
        Else
            MsgBox("Selecciona un registro primero!")
        End If
    End Sub
End Class
