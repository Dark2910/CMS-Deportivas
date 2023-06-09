
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_documentos_nota()

    End Sub

    'Consultar documentos calendario
    Protected Sub sub_constulta_documentos_nota()
        principal.obj_documentos_calendario.id_dcalendario_calendario = Request.QueryString("id_calendario")
        principal.obj_documentos_calendario.sub_decumentos_calendario_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_documentos_calendario.tbl_decumentos_calendario_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_documentos_calendario.tbl_decumentos_calendario_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_documentos_calendario.DataSource = principal.obj_documentos_calendario.tbl_decumentos_calendario_consulta.tabla_llena
        Me.tbl_documentos_calendario.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_documentos_calendario.tbl_decumentos_calendario_consulta.tabla_llena.Rows.Count - 1
            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "deportista_agrega" & i
            liga.NavigateUrl = "deportivas_cambio_documento_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario") & "&id_dcalendario=" & principal.obj_documentos_calendario.tbl_decumentos_calendario_consulta.tabla_llena.Rows(i)("id_dcalendario").ToString
            Me.tbl_documentos_calendario.Rows(i).Cells(4).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "deportista_elimina" & i
            liga.NavigateUrl = "deportivas_baja_documento_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario") & "&id_dcalendario=" & principal.obj_documentos_calendario.tbl_decumentos_calendario_consulta.tabla_llena.Rows(i)("id_dcalendario").ToString
            Me.tbl_documentos_calendario.Rows(i).Cells(5).Controls.Add(liga)

        Next

    End Sub

    Protected Sub btn_alta_documento_calendario_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_documento_calendario.ServerClick
        Dim file() As String

        Dim extension As String
        Dim tipo_archivo As String
        Dim dcalendario_nombre As String

        If Me.FileUpload_documento_calendario.HasFile = True Then

            file = Me.FileUpload_documento_calendario.FileName.Split(".")

            If Me.txt_dcalendario_nombre.Text = "" Then
                dcalendario_nombre = file(0)
            Else
                dcalendario_nombre = Me.txt_dcalendario_nombre.Text
            End If

            extension = file(1)

            tipo_archivo = ""

            If extension = "doc" Or extension = "docx" Or extension = "pdf" Or extension = "txt" Then
                tipo_archivo = "documentos_calendario"
            End If

            principal.obj_documento_calendario.extension = extension
            principal.obj_documento_calendario.tipo_archivo = tipo_archivo
            principal.obj_documento_calendario.dcalendario_nombre = dcalendario_nombre

            principal.obj_documento_calendario.dcalendario_descripcion = Me.txt_descripcion.Text
            principal.obj_documento_calendario.id_dcalendario_calendario = Request.QueryString("id_calendario")

            principal.obj_documento_calendario.sub_decumento_calendario_inserta()

            If (principal.obj_documento_calendario.codigo = "0") Then
                Me.FileUpload_documento_calendario.SaveAs(principal.obj_documento_calendario.ruta_fisica)
                Me.FileUpload_documento_calendario.PostedFile.InputStream.Dispose()

            Else
                Me.FileUpload_documento_calendario.PostedFile.InputStream.Dispose()

            End If

        End If
        Response.Redirect("deportivas_consulta_documentos_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario"))

    End Sub
End Class
