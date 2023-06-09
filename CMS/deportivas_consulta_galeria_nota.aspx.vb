
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_galeria_nota()

    End Sub

    'Consultar galeria nota
    Protected Sub sub_constulta_galeria_nota()
        Dim principal As New class_principal
        principal.obj_fotos_nota.id_fnota_nota = Request.QueryString("id_nota")
        principal.obj_fotos_nota.sub_fotos_nota_consulta()


        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_fotos_nota.tbl_fotos_nota_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_fotos_nota.tbl_fotos_nota_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_galeria_nota.DataSource = principal.obj_fotos_nota.tbl_fotos_nota_consulta.tabla_llena
        Me.tbl_galeria_nota.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_fotos_nota.tbl_fotos_nota_consulta.tabla_llena.Rows.Count - 1
            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "deportista_agrega" & i
            liga.NavigateUrl = "deportivas_cambio_galeria_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota") & "&id_fnota=" & principal.obj_fotos_nota.tbl_fotos_nota_consulta.tabla_llena.Rows(i)("id_fnota").ToString
            Me.tbl_galeria_nota.Rows(i).Cells(4).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "deportista_elimina" & i
            liga.NavigateUrl = "deportivas_baja_galeria_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota") & "&id_fnota=" & principal.obj_fotos_nota.tbl_fotos_nota_consulta.tabla_llena.Rows(i)("id_fnota").ToString
            Me.tbl_galeria_nota.Rows(i).Cells(5).Controls.Add(liga)

        Next

    End Sub

    'Alta galeria nota
    Protected Sub btn_alta_galeria_nota_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_galeria_nota.ServerClick
        Dim principal As New class_principal
        Dim file() As String

        Dim extension As String
        Dim tipo_archivo As String
        Dim fnota_nombre As String

        If Me.FileUpload_foto_nota.HasFile = True Then

            file = Me.FileUpload_foto_nota.FileName.Split(".")

            If Me.txt_fnota_nombre.Text = "" Then
                fnota_nombre = file(0)
            Else
                fnota_nombre = Me.txt_fnota_nombre.Text
            End If

            extension = file(1)

            tipo_archivo = ""

            If extension = "png" Or extension = "jpg" Or extension = "gif" Then
                tipo_archivo = "imagenes_nota"
            End If

            principal.obj_foto_nota.extension = extension
            principal.obj_foto_nota.tipo_archivo = tipo_archivo
            principal.obj_foto_nota.fnota_nombre = fnota_nombre

            principal.obj_foto_nota.fnota_descripcion = Me.txt_descripcion.Text
            principal.obj_foto_nota.id_fnota_nota = Request.QueryString("id_nota")

            principal.obj_foto_nota.sub_foto_nota_inserta()

            If (principal.obj_foto_nota.codigo = "0") Then
                Me.FileUpload_foto_nota.SaveAs(principal.obj_foto_nota.ruta_fisica)
                Me.FileUpload_foto_nota.PostedFile.InputStream.Dispose()

            Else
                Me.FileUpload_foto_nota.PostedFile.InputStream.Dispose()

            End If

        End If
        Response.Redirect("deportivas_consulta_galeria_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota"))

    End Sub

End Class
