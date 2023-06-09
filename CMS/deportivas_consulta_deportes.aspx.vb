
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_deportes()

    End Sub

    'Consultar deportes
    Protected Sub sub_consulta_deportes()
        Dim principal As New class_principal
        principal.obj_deportes.sub_deportes_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Grupos"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Coaches"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Notas"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Calendario"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Galeria"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_deportes.DataSource = principal.obj_deportes.tbl_deportes_consulta.tabla_llena
        Me.tbl_deportes.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows.Count - 1
            'Liga modificar
            liga = New HyperLink
            liga.Text = "Grupos"
            liga.ImageUrl = "./assets/img/group.png"
            liga.ID = "deporte_grupos" & i
            liga.NavigateUrl = "deportivas_consulta_grupos.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(5).Controls.Add(liga)

            'Liga eliminar
            liga = New HyperLink
            liga.Text = "Coaches"
            liga.ImageUrl = "./assets/img/coach.png"
            liga.ID = "deporte_coaches" & i
            liga.NavigateUrl = "deportivas_consulta_coaches.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(6).Controls.Add(liga)

            'ver mas'
            liga = New HyperLink
            liga.Text = "Notas"
            liga.ImageUrl = "./assets/img/newspaper.png"
            liga.ID = "deporte_notas" & i
            liga.NavigateUrl = "deportivas_consulta_notas.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(7).Controls.Add(liga)

            'ver mas'
            liga = New HyperLink
            liga.Text = "Calendario"
            liga.ImageUrl = "./assets/img/calendar.png"
            liga.ID = "deporte_calendario" & i
            liga.NavigateUrl = "deportivas_consulta_calendario.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(8).Controls.Add(liga)

            'ver mas'
            liga = New HyperLink
            liga.Text = "Galeria"
            liga.ImageUrl = "./assets/img/gallery.png"
            liga.ID = "deporte_galeria" & i
            liga.NavigateUrl = "deportivas_consulta_galeria_deporte.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(9).Controls.Add(liga)

            'ver mas'
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "deporte_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_deporte.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(10).Controls.Add(liga)

            'ver mas'
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "deporte_elimina" & i
            liga.NavigateUrl = "deportivas_baja_deporte.aspx?id_deporte=" & principal.obj_deportes.tbl_deportes_consulta.tabla_llena.Rows(i)("id_deporte").ToString
            Me.tbl_deportes.Rows(i).Cells(11).Controls.Add(liga)

        Next
    End Sub

    Protected Sub btn_alta_deporte_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_deporte.ServerClick
        Dim principal As New class_principal

        principal.obj_deporte.deporte_nombre = Me.txtDeporteNombre.Text
        principal.obj_deporte.deporte_objetivo = Me.txtDeporteObjetivo.Text
        principal.obj_deporte.deporte_descripcion = Me.txtDeporteDescripcion.Text

        principal.obj_deporte.sub_deporte_inserta()

        Response.Redirect("deportivas_consulta_deportes.aspx")

    End Sub
End Class
