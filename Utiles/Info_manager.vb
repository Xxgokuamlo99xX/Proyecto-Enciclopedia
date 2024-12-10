Imports System.IO

Public Class Info_manager

    Public directoriobase As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    Public directorioapp As String = Path.Combine(directoriobase, "Enciclopedia")

    Public Function id_getter() As Integer

        Return Plantilla_preview.PersonajesTableAdapter1.get_cant_id()

    End Function


    Public Sub create_directory()
        If Not Directory.Exists(directorioapp) Then
            Directory.CreateDirectory(directorioapp)
        End If

    End Sub

    Public Sub guarda_imagen(nombre As String, imagen As Image)
        Dim ruta_archivo As String = Path.Combine(directorioapp, nombre)
        imagen.Save(ruta_archivo, System.Drawing.Imaging.ImageFormat.Png)

    End Sub

    Public Sub cargar_imagen(nombre_arch As String, imagen_box As PictureBox)
        Dim ruta_archivo As String = Path.Combine(directorioapp, nombre_arch)

        If File.Exists(ruta_archivo) Then
            imagen_box.Image = Image.FromFile(ruta_archivo)
            Console.WriteLine($"Imagen cargada desde: {ruta_archivo}")

        Else
            imagen_box.Image = Image.FromFile("E:\Oscar Alvarado 510\Visual Studio\Proyecto Enciclopedia\Resources\Unknown_person.jpg")
            Console.WriteLine("Archivo no existe. xdddddd")

        End If

    End Sub

    Public Sub actualizar_img(nombre As String, imagen_arch As Image)

        Dim ruta_archivo As String = Path.Combine(directorioapp, nombre)
        File.Delete(ruta_archivo)
        imagen_arch.Save(ruta_archivo, System.Drawing.Imaging.ImageFormat.Png)

    End Sub

End Class
