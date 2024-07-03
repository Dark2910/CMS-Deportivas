
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_galeria_nota()

    End Sub

    'Consultar galeria calendario
    Protected Sub sub_constulta_galeria_nota()
        principal.obj_fotos_calendario.id_fcalendario_calendario = Request.QueryString("id_calendario")
        principal.obj_fotos_calendario.sub_fotos_calendario_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_fotos_calendario.tbl_fotos_calendario_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_fotos_calendario.tbl_fotos_calendario_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_galeria_calendario.DataSource = principal.obj_fotos_calendario.tbl_fotos_calendario_consulta.tabla_llena
        Me.tbl_galeria_calendario.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_fotos_calendario.tbl_fotos_calendario_consulta.tabla_llena.Rows.Count - 1
            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "deportista_agrega" & i
            liga.NavigateUrl = "deportivas_cambio_galeria_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario") & "&id_fcalendario=" & principal.obj_fotos_calendario.tbl_fotos_calendario_consulta.tabla_llena.Rows(i)("id_fcalendario").ToString
            Me.tbl_galeria_calendario.Rows(i).Cells(4).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "deportista_elimina" & i
            liga.NavigateUrl = "deportivas_baja_galeria_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario") & "&id_fcalendario=" & principal.obj_fotos_calendario.tbl_fotos_calendario_consulta.tabla_llena.Rows(i)("id_fcalendario").ToString
            Me.tbl_galeria_calendario.Rows(i).Cells(5).Controls.Add(liga)

        Next

    End Sub

    'Alta galeria nota
    Protected Sub btn_alta_galeria_calendario_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_galeria_calendario.ServerClick
        Dim file() As String

        Dim extension As String
        Dim tipo_archivo As String
        Dim fcalendario_nombre As String

        If Me.FileUpload_foto_calendario.HasFile = True Then

            file = Me.FileUpload_foto_calendario.FileName.Split(".")

            If Me.txt_fcalendario_nombre.Text = "" Then
                fcalendario_nombre = file(0)
            Else
                fcalendario_nombre = Me.txt_fcalendario_nombre.Text
            End If

            extension = file(1)

            tipo_archivo = ""

            If extension = "png" Or extension = "jpg" Or extension = "gif" Then
                tipo_archivo = "imagenes_calendario"
            End If

            principal.obj_foto_calendario.extension = extension
            principal.obj_foto_calendario.tipo_archivo = tipo_archivo
            principal.obj_foto_calendario.fcalendario_nombre = fcalendario_nombre

            principal.obj_foto_calendario.fcalendario_descripcion = Me.txt_descripcion.Text
            principal.obj_foto_calendario.id_fcalendario_calendario = Request.QueryString("id_calendario")

            principal.obj_foto_calendario.sub_foto_calendario_inserta()

            If (principal.obj_foto_calendario.codigo = "0") Then
                Me.FileUpload_foto_calendario.SaveAs(principal.obj_foto_calendario.ruta_fisica)
                Me.FileUpload_foto_calendario.PostedFile.InputStream.Dispose()

            Else
                Me.FileUpload_foto_calendario.PostedFile.InputStream.Dispose()

            End If

        End If
        Response.Redirect("deportivas_consulta_galeria_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario"))

    End Sub

End Class
