
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_deportistas()
    End Sub

    Protected Sub sub_consulta_deportistas()
        Dim principal As New class_principal
        principal.obj_deportistas.id_grupo = Request.QueryString("id_grupo")
        principal.obj_deportistas.sub_deportistas_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Agregar"
        principal.obj_deportistas.tbl_deportistas_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_deportistas.tbl_deportistas_consulta.tabla_llena.Columns.Add(columna)


        Me.tbl_deportistas.DataSource = principal.obj_deportistas.tbl_deportistas_consulta.tabla_llena
        Me.tbl_deportistas.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_deportistas.tbl_deportistas_consulta.tabla_llena.Rows.Count - 1
            'Agregar deportista
            liga = New HyperLink
            liga.Text = "Agregar"
            liga.ImageUrl = "./assets/img/agregar.png"
            liga.ID = "agregar" & i
            liga.NavigateUrl = "deportivas_alta_inscripcion.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_deportista=" & principal.obj_deportistas.tbl_deportistas_consulta.tabla_llena.Rows(i)("id_deportista").ToString
            Me.tbl_deportistas.Rows(i).Cells(6).Controls.Add(liga)

            'Agregar deportista
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "eliminar" & i
            liga.NavigateUrl = "deportivas_baja_deportista.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_deportista=" & principal.obj_deportistas.tbl_deportistas_consulta.tabla_llena.Rows(i)("id_deportista").ToString
            Me.tbl_deportistas.Rows(i).Cells(7).Controls.Add(liga)

        Next

    End Sub

    Protected Sub btn_alta_deportista_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_deportista.ServerClick
        Dim principal As New class_principal

        principal.obj_deportista.deportista_nombre = Me.txtDeportistaNombre.Text
        principal.obj_deportista.deportista_apaterno = Me.txtDeportistaApaterno.Text
        principal.obj_deportista.deportista_amaterno = Me.txtDeportistaAmaterno.Text
        principal.obj_deportista.deportista_matricula = Me.txtDeportistaMatricula.Text
        principal.obj_deportista.id_deportista_genero = Me.Wuc_generos1.ftn_valor_seleccionado()
        principal.obj_deportista.id_deportista_carrera = Me.Wuc_carreras1.ftn_valor_seleccionado()

        principal.obj_deportista.sub_deportista_inserta()

        Response.Redirect("deportivas_consulta_deportistas.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub
End Class
