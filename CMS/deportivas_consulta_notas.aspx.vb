
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_notas()
    End Sub

    'Consultar notas
    Public Sub sub_consulta_notas()
        Dim principal As New class_principal
        principal.obj_notas.id_nota_deporte = Request.QueryString("id_deporte")
        principal.obj_notas.sub_notas_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Documentos"
        principal.obj_notas.tbl_notas_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Galeria"
        principal.obj_notas.tbl_notas_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_notas.tbl_notas_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_notas.tbl_notas_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_notas.DataSource = principal.obj_notas.tbl_notas_consulta.tabla_llena
        Me.tbl_notas.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_notas.tbl_notas_consulta.tabla_llena.Rows.Count - 1
            'Documentos
            liga = New HyperLink
            liga.Text = "Documentos"
            liga.ImageUrl = "./assets/img/documents.png"
            liga.ID = "nota_documentos" & i
            liga.NavigateUrl = "deportivas_consulta_documentos_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & principal.obj_notas.tbl_notas_consulta.tabla_llena.Rows(i)("id_nota").ToString
            Me.tbl_notas.Rows(i).Cells(5).Controls.Add(liga)

            'Galeria
            liga = New HyperLink
            liga.Text = "Galeria"
            liga.ImageUrl = "./assets/img/gallery.png"
            liga.ID = "nota_galeria" & i
            liga.NavigateUrl = "deportivas_consulta_galeria_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & principal.obj_notas.tbl_notas_consulta.tabla_llena.Rows(i)("id_nota").ToString
            Me.tbl_notas.Rows(i).Cells(6).Controls.Add(liga)

            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "nota_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & principal.obj_notas.tbl_notas_consulta.tabla_llena.Rows(i)("id_nota").ToString
            Me.tbl_notas.Rows(i).Cells(7).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "nota_elimina" & i
            liga.NavigateUrl = "deportivas_baja_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & principal.obj_notas.tbl_notas_consulta.tabla_llena.Rows(i)("id_nota").ToString
            Me.tbl_notas.Rows(i).Cells(8).Controls.Add(liga)

        Next

    End Sub

    'Alta nota
    Protected Sub btn_alta_nota_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_nota.ServerClick
        Dim principal As New class_principal

        principal.obj_nota.nota_titulo = Me.txtNotaTitulo.Text
        principal.obj_nota.nota_subtitulo = Me.txtNotaSubtitulo.Text
        principal.obj_nota.nota_texto = Me.txtNotaTexto.Text
        principal.obj_nota.id_nota_deporte = Request.QueryString("id_deporte")

        principal.obj_nota.sub_nota_inserta()

        Response.Redirect("deportivas_consulta_notas.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
