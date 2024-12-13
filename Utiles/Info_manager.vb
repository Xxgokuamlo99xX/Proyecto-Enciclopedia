Imports System.IO

Public Class Info_manager

    Public Shared id_list As New List(Of Integer)

    Public directoriobase As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
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
        If nombre Is Nothing Then
            nombre = ""
        End If

        Dim ruta_archivo As String = Path.Combine(directorioapp, nombre)
        Dim directorio As String = Path.GetDirectoryName(ruta_archivo)
        If Not Directory.Exists(directorio) Then
            Directory.CreateDirectory(directorio)
        End If
        Using imagenClonada As Image = CType(imagen.Clone(), Image)
            ' Guardar la imagen clonada, sobrescribiendo el archivo original
            imagenClonada.Save(ruta_archivo, System.Drawing.Imaging.ImageFormat.Png)
        End Using

    End Sub

    Public Sub ModificarImagenConCopia(img As Panel, nombre As String)
        Dim rutaImagen As String = Path.Combine(directorioapp, nombre)
        Dim rutaTemporal As String = Path.Combine(directorioapp, "img_temp" & Administrado_1.form_selec_id & ".png")
        Dim temporal As Image
        Try
            ' Crear una copia temporal 
            If File.Exists(rutaImagen) Then
                IO.File.Copy(rutaImagen, rutaTemporal, overwrite:=True)
            Else
                IO.File.Create(rutaImagen)
            End If
            ' Modificar la copia temporal

            temporal = img.BackgroundImage
            temporal.Save(rutaTemporal)

            MessageBox.Show("Imagen modificada y reemplazada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
        End Try
        Console.WriteLine(id_list)

    End Sub

    Public Sub cargar_imagen(nombre_arch As String, imagen_box As PictureBox, id As Integer)

        Dim ruta_archivo As String = Path.Combine(directorioapp, nombre_arch)

        If File.Exists(ruta_archivo) Then
            If Not id_list.Contains(id) Then
                imagen_box.Image = Image.FromFile(ruta_archivo)
                Console.WriteLine($"Imagen cargada desde: {ruta_archivo}")
            Else
                ruta_archivo = Nothing
                ruta_archivo = Path.Combine(directorioapp, "img_temp" & Administrado_1.form_selec_id & ".png")
                If Not ruta_archivo = Path.Combine(directorioapp, "img_temp0.png") Then
                    imagen_box.Image = Image.FromFile(ruta_archivo)
                End If
            End If
        Else
            imagen_box.Image = Image.FromFile("E:\Oscar Alvarado 510\Visual Studio\Proyecto Enciclopedia\Resources\Unknown_person.jpg")
            Console.WriteLine("Archivo no existe. xdddddd")

        End If

    End Sub

    Public Sub cargar_imagen_panel(nombre_arch As String, imagen_box As Panel)
        If nombre_arch Is Nothing Then
            nombre_arch = ""
        End If
        Dim ruta_archivo As String = Path.Combine(directorioapp, nombre_arch)

        If File.Exists(ruta_archivo) Then
            imagen_box.BackgroundImage = Image.FromFile(ruta_archivo)
            Console.WriteLine($"Imagen cargada desde: {ruta_archivo}")

        Else
            imagen_box.BackgroundImage = Image.FromFile("E:\Oscar Alvarado 510\Visual Studio\Proyecto Enciclopedia\Resources\Unknown_person.jpg")
            Console.WriteLine($"no existe: {ruta_archivo}")

        End If

    End Sub

    Public Sub guardar_lista()
        ' Guardar el array en un archivo TXT
        File.WriteAllLines(directorioapp & "ID_lista.txt", id_list.Select(Function(num) num.ToString()))


    End Sub

    Public Sub leer_lista()
        If File.Exists(directorioapp & "ID_lista.txt") Then
            id_list = File.ReadAllLines(directorioapp & "ID_lista.txt").Select(Function(linea) Integer.Parse(linea)).ToList()

        Else
            Return
        End If

    End Sub

    Public Sub intercambiar_nombre()

        ' Verifica si la lista está vacía
        If id_list Is Nothing OrElse id_list.Count = 0 Then
            Console.WriteLine("La lista de IDs está vacía.")
            Return
        End If

        ' Itera sobre los IDs para renombrar y eliminar
        For Each id As Integer In id_list
            Dim rutaArchivo As String = Path.Combine(directorioapp, "img_" & id & ".png")
            Dim rutaArchivo_temp As String = Path.Combine(directorioapp, "img_temp" & id & ".png")

            ' Verificar si el archivo temporal existe
            If IO.File.Exists(rutaArchivo_temp) Then
                ' Si el archivo original existe, elimínalo
                If IO.File.Exists(rutaArchivo) Then
                    IO.File.Delete(rutaArchivo)
                    Console.WriteLine($"Archivo original eliminado: {rutaArchivo}")
                End If

                ' Renombrar el archivo temporal al nombre original
                File.Move(rutaArchivo_temp, rutaArchivo)
                Console.WriteLine($"Archivo renombrado: {rutaArchivo_temp} a {rutaArchivo}")
            Else
                Console.WriteLine($"Archivo temporal no encontrado: {rutaArchivo_temp}")
            End If
        Next

        vaciar_lista()
    End Sub
    Public Sub vaciar_lista()

        File.WriteAllLines(directorioapp & "ID_lista.txt", Enumerable.Empty(Of String)())

    End Sub
End Class
