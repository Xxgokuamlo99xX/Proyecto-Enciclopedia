Public Class Inicio_sesion

    Private us_list As New List(Of String)
    Private pass_list As String
    Private id_de_usuario As Integer
    Private cant_us As Integer

    Private Sub Inicio_sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cant_us = Me.UsuariosTableAdapter.get_cant_us()
        For i As Integer = cant_us To 1 Step -1
            us_list.Add(Me.UsuariosTableAdapter.Get_usuarios(i))

        Next


        For Each usuario In us_list
            Console.WriteLine(usuario)
        Next


    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If Not us_list.Contains(TextBox1.Text) Then
            MsgBox("Usuario no valido")
            Return
        End If

        pass_list = Me.UsuariosTableAdapter.get_password(TextBox1.Text)

        If Not pass_list = TextBox2.Text Then
            MsgBox("Contraseña no valida")
            Return
        End If

        Me.Hide()
        Menu_inicio.abrir_admin()

    End Sub
End Class