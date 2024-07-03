
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_galeria_deporte()

    End Sub

    'Consultar galeria deporte
    Protected Sub sub_constulta_galeria_deporte()
        Dim principal As New class_principal
        principal.obj_fotos_deporte.id_fdeporte_deporte = Request.QueryString("id_deporte")
        principal.obj_fotos_deporte.sub_fotos_deporte_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_fotos_deporte.tbl_fotos_deporte_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_fotos_deporte.tbl_fotos_deporte_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_galeria_deporte.DataSource = principal.obj_fotos_deporte.tbl_fotos_deporte_consulta.tabla_llena
        Me.tbl_galeria_deporte.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_fotos_deporte.tbl_fotos_deporte_consulta.tabla_llena.Rows.Count - 1
            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "deportista_agrega" & i
            liga.NavigateUrl = "deportivas_cambio_galeria_deporte.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_fdeporte=" & principal.obj_fotos_deporte.tbl_fotos_deporte_consulta.tabla_llena.Rows(i)("id_fdeporte").ToString
            Me.tbl_galeria_deporte.Rows(i).Cells(4).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "deportista_elimina" & i
            liga.NavigateUrl = "deportivas_baja_galeria_deporte.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_fdeporte=" & principal.obj_fotos_deporte.tbl_fotos_deporte_consulta.tabla_llena.Rows(i)("id_fdeporte").ToString
            Me.tbl_galeria_deporte.Rows(i).Cells(5).Controls.Add(liga)

        Next

    End Sub

    'Alta galeria deporte
    Protected Sub btn_alta_galeria_deporte_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_galeria_deporte.ServerClick
        Dim principal As New class_principal
        Dim file() As String

        Dim extension As String
        Dim tipo_archivo As String
        Dim fdeporte_nombre As String

        If Me.FileUpload_fotos_deporte.HasFile = True Then

            file = Me.FileUpload_fotos_deporte.FileName.Split(".")

            If Me.txt_fdeporte_nombre.Text = "" Then
                fdeporte_nombre = file(0)
            Else
                fdeporte_nombre = Me.txt_fdeporte_nombre.Text
            End If

            extension = file(1)

            tipo_archivo = ""

            If extension = "png" Or extension = "jpg" Or extension = "gif" Then
                tipo_archivo = "imagenes_deporte"
            End If

            principal.obj_foto_deporte.extension = extension
            principal.obj_foto_deporte.tipo_archivo = tipo_archivo
            principal.obj_foto_deporte.fdeporte_nombre = fdeporte_nombre

            principal.obj_foto_deporte.fdeporte_descripcion = Me.txt_descripcion.Text
            principal.obj_foto_deporte.id_fdeporte_deporte = Request.QueryString("id_deporte")

            principal.obj_foto_deporte.sub_foto_deporte_inserta()

            If principal.obj_foto_deporte.codigo = "0" Then
                Me.FileUpload_fotos_deporte.SaveAs(principal.obj_foto_deporte.ruta_fisica)
                Me.FileUpload_fotos_deporte.PostedFile.InputStream.Dispose()

            Else
                Me.FileUpload_fotos_deporte.PostedFile.InputStream.Dispose()

            End If

        End If
        Response.Redirect("deportivas_consulta_galeria_deporte.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

End Class
