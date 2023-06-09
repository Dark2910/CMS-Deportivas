
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_documentos_nota()

    End Sub

    'Consultar documentos nota
    Protected Sub sub_constulta_documentos_nota()
        Dim principal As New class_principal
        principal.obj_documentos_nota.id_dnota_nota = Request.QueryString("id_nota")
        principal.obj_documentos_nota.sub_decumentos_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_documentos_nota.tbl_decumentos_nota_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_documentos_nota.tbl_decumentos_nota_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_documentos_nota.DataSource = principal.obj_documentos_nota.tbl_decumentos_nota_consulta.tabla_llena
        Me.tbl_documentos_nota.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_documentos_nota.tbl_decumentos_nota_consulta.tabla_llena.Rows.Count - 1
            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "deportista_agrega" & i
            liga.NavigateUrl = "deportivas_cambio_documento_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota") & "&id_dnota=" & principal.obj_documentos_nota.tbl_decumentos_nota_consulta.tabla_llena.Rows(i)("id_dnota").ToString
            Me.tbl_documentos_nota.Rows(i).Cells(4).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "deportista_elimina" & i
            liga.NavigateUrl = "deportivas_baja_documento_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota") & "&id_dnota=" & principal.obj_documentos_nota.tbl_decumentos_nota_consulta.tabla_llena.Rows(i)("id_dnota").ToString
            Me.tbl_documentos_nota.Rows(i).Cells(5).Controls.Add(liga)

        Next

    End Sub

    'Alta documento nota
    Protected Sub btn_alta_documento_nota_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_documento_nota.ServerClick
        Dim principal As New class_principal
        Dim file() As String

        Dim extension As String
        Dim tipo_archivo As String
        Dim dnota_nombre As String

        If Me.FileUpload_documento_nota.HasFile = True Then

            file = Me.FileUpload_documento_nota.FileName.Split(".")

            If Me.txt_dnota_nombre.Text = "" Then
                dnota_nombre = file(0)
            Else
                dnota_nombre = Me.txt_dnota_nombre.Text
            End If

            extension = file(1)

            tipo_archivo = ""

            If extension = "doc" Or extension = "docx" Or extension = "pdf" Or extension = "txt" Then
                tipo_archivo = "documentos_nota"
            End If

            principal.obj_documento_nota.extension = extension
            principal.obj_documento_nota.tipo_archivo = tipo_archivo
            principal.obj_documento_nota.dnota_nombre = dnota_nombre

            principal.obj_documento_nota.dnota_descripcion = Me.txt_descripcion.Text
            principal.obj_documento_nota.id_dnota_nota = Request.QueryString("id_nota")

            principal.obj_documento_nota.sub_decumento_nota_inserta()


            If (principal.obj_documento_nota.codigo = "0") Then
                Me.FileUpload_documento_nota.SaveAs(principal.obj_documento_nota.ruta_fisica)
                Me.FileUpload_documento_nota.PostedFile.InputStream.Dispose()

            Else
                Me.FileUpload_documento_nota.PostedFile.InputStream.Dispose()

            End If

        End If
        Response.Redirect("deportivas_consulta_documentos_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota"))

    End Sub


End Class
