
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        consulta_calendario()

    End Sub

    Protected Sub consulta_calendario()
        principal.obj_calendarios.id_calendario_deporte = Request.QueryString("id_deporte")
        principal.obj_calendarios.sub_calendarios_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Documentos"
        principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Galeria"
        principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_calendario.DataSource = principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena
        Me.tbl_calendario.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Rows.Count - 1
            'Documentos
            liga = New HyperLink
            liga.Text = "Documentos"
            liga.ImageUrl = "./assets/img/documents.png"
            liga.ID = "nota_documentos" & i
            liga.NavigateUrl = "deportivas_consulta_documentos_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Rows(i)("id_calendario").ToString
            Me.tbl_calendario.Rows(i).Cells(5).Controls.Add(liga)

            'Galeria
            liga = New HyperLink
            liga.Text = "Galeria"
            liga.ImageUrl = "./assets/img/gallery.png"
            liga.ID = "nota_galeria" & i
            liga.NavigateUrl = "deportivas_consulta_galeria_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Rows(i)("id_calendario").ToString
            Me.tbl_calendario.Rows(i).Cells(6).Controls.Add(liga)

            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "nota_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Rows(i)("id_calendario").ToString
            Me.tbl_calendario.Rows(i).Cells(7).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "nota_elimina" & i
            liga.NavigateUrl = "deportivas_baja_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & principal.obj_calendarios.tbl_calendarios_consulta.tabla_llena.Rows(i)("id_calendario").ToString
            Me.tbl_calendario.Rows(i).Cells(8).Controls.Add(liga)

        Next

    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        Me.txtFechaEvento.Text = Me.Calendar1.SelectedDate.Year & "-" & Me.Calendar1.SelectedDate.Month & "-" & Me.Calendar1.SelectedDate.Day

    End Sub

    Protected Sub btn_alta_calendario_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_calendario.ServerClick
        principal.obj_calendario.calendario_nombre_evento = Me.txtCalendarioNombreEvento.Text
        principal.obj_calendario.calendario_descripcion_evento = Me.txtCalendarioDescripcionEvento.Text
        principal.obj_calendario.calendario_fecha_evento = Me.txtFechaEvento.Text
        principal.obj_calendario.id_calendario_deporte = Request.QueryString("id_deporte")

        principal.obj_calendario.sub_calendario_inserta()

        Response.Redirect("deportivas_consulta_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
