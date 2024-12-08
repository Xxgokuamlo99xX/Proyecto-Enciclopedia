Public Class Usuario

    Private currentchildform As Form
    Private filter_idex As Integer = 0
    Public info_man As New Info_manager



    Private Sub OpenChildForm(childForm As Form)

        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Left
        Panel_plantilla.Controls.Add(childForm)
        Panel_plantilla.Tag = childForm
        childForm.BringToFront()
        childForm.Show()

    End Sub

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
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



    Private Sub Administrado_1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        CerrarFormasEnPanel(Panel_plantilla)

    End Sub

    Private Sub Busqueda(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        filtrar(filter_idex)

    End Sub

    Private Sub filtrar(filtro As Integer) 'NO MOVER, FUNCIONA Y NO SE PORQUE!!!!!
        Dim tieneCoincidenciaCompleta As Boolean = False
        Dim formularioCoincidenciaCompleta As Plantilla_preview = Nothing
        Dim busqueda As String = TextBox1.Text
        ' Crear una lista para almacenar los formularios y sus coincidencias
        Dim listaFormularios As New List(Of Tuple(Of Plantilla_preview, Integer))()

        For Each control As Control In Panel_plantilla.Controls
            If TypeOf control Is Plantilla_preview Then
                Dim form As Plantilla_preview = CType(control, Plantilla_preview)
                Dim palabra As String
                Select Case filtro
                    Case 0
                        palabra = form.name_textBox.Text.ToLower()
                    Case 1
                        palabra = form.saga_TextBox.Text.ToLower()
                    Case 2
                        palabra = form.Peso_TextBox.Text.ToLower()
                    Case 3
                        palabra = form.year_TextBox.Text.ToLower()
                End Select
                Dim coincidencias As Integer = 0

                ' Contar coincidencias
                For Each letra As Char In palabra
                    If busqueda.Contains(letra) Then
                        coincidencias += 1
                    End If
                Next

                ' Verificar si es una coincidencia completa
                If coincidencias = palabra.Length AndAlso palabra.Length = busqueda.Length Then
                    tieneCoincidenciaCompleta = True
                    formularioCoincidenciaCompleta = form
                    Exit For ' No es necesario seguir buscando
                End If

                ' Agregar a la lista para coincidencias parciales
                listaFormularios.Add(New Tuple(Of Plantilla_preview, Integer)(form, coincidencias))
            End If

        Next

        If tieneCoincidenciaCompleta Then
            ' Mostrar solo el formulario con coincidencia completa
            For Each control As Control In Panel_plantilla.Controls
                If TypeOf control Is Plantilla_preview Then
                    Dim form As Plantilla_preview = CType(control, Plantilla_preview)
                    form.Visible = (form Is formularioCoincidenciaCompleta)
                End If
                If busqueda = "" Then
                    control.Show()
                End If
            Next
        Else
            ' Mostrar formularios con coincidencias parciales ordenados por relevancia
            listaFormularios = listaFormularios.OrderByDescending(Function(x) x.Item2).ToList()

            For Each item In listaFormularios
                Dim form As Plantilla_preview = item.Item1
                Dim coincidencias As Integer = item.Item2

                ' Mostrar formularios con coincidencias
                form.Visible = coincidencias > 0
                If busqueda = "" Then
                    form.Show()
                End If
            Next


        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        filter_idex = ComboBox1.SelectedIndex
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        actualizar()
    End Sub
End Class