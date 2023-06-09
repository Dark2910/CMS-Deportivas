
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal
    Dim columna As New Data.DataColumn
    Dim liga As New HyperLink
    Dim i As Integer

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_grupo_coach()
        sub_consulta_grupo_inscripciones()
        sub_consulta_inscripciones_rooster()

    End Sub

    'Consultar coaches
    Protected Sub sub_consulta_grupo_coach()
        principal.obj_grupo.id_grupo = Request.QueryString("id_grupo")
        principal.obj_grupo.sub_grupo_coach_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Quitar"
        principal.obj_grupo.tbl_grupo_coach_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_grupo_coach.DataSource = principal.obj_grupo.tbl_grupo_coach_consulta.tabla_llena
        Me.tbl_grupo_coach.DataBind()

        For i = 0 To principal.obj_grupo.tbl_grupo_coach_consulta.tabla_llena.Rows.Count - 1
            'Eliminar
            liga = New HyperLink
            liga.Text = "Quitar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "quitar" & i
            liga.NavigateUrl = "deportivas_cambio_grupo_coach.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_coach=NULL"
            Me.tbl_grupo_coach.Rows(i).Cells(5).Controls.Add(liga)

        Next

    End Sub

    'Consultar inscripciones
    Protected Sub sub_consulta_grupo_inscripciones()
        principal.obj_insrcipciones.id_inscripcion_grupo = Request.QueryString("id_grupo")
        principal.obj_insrcipciones.sub_inscripciones_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Agregar al rooster"
        principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Quitar"
        principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_grupo_inscripciones.DataSource = principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena
        Me.tbl_grupo_inscripciones.DataBind()

        For i = 0 To principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Rows.Count - 1
            'Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "modficar" & i
            liga.NavigateUrl = "deportivas_cambio_deportista.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_deportista=" & principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Rows(i)("id_deportista").ToString
            Me.tbl_grupo_inscripciones.Rows(i).Cells(6).Controls.Add(liga)

            'Agregar al rooster
            liga = New HyperLink
            liga.Text = "Agregar"
            liga.ImageUrl = "./assets/img/medal.png"
            liga.ID = "agregar" & i
            liga.NavigateUrl = "deportivas_cambio_rooster.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_inscripcion=" & principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Rows(i)("id_inscripcion").ToString & "&inscripcion_rooster=1".ToString
            Me.tbl_grupo_inscripciones.Rows(i).Cells(7).Controls.Add(liga)

            'Eliminar inscripcion
            liga = New HyperLink
            liga.Text = "Quitar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "quitar" & i
            liga.NavigateUrl = "deportivas_baja_inscripcion.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_inscripcion=" & principal.obj_insrcipciones.tbl_inscripciones_consulta.tabla_llena.Rows(i)("id_inscripcion").ToString
            Me.tbl_grupo_inscripciones.Rows(i).Cells(8).Controls.Add(liga)

        Next

    End Sub

    'Consultar rooster
    Protected Sub sub_consulta_inscripciones_rooster()
        principal.obj_insrcipciones.id_inscripcion_grupo = Request.QueryString("id_grupo")
        principal.obj_insrcipciones.sub_inscripciones_rooster_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Quitar"
        principal.obj_insrcipciones.tbl_inscripciones_rooster_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_grupo_rooster.DataSource = principal.obj_insrcipciones.tbl_inscripciones_rooster_consulta.tabla_llena
        Me.tbl_grupo_rooster.DataBind()

        For i = 0 To principal.obj_insrcipciones.tbl_inscripciones_rooster_consulta.tabla_llena.Rows.Count - 1
            'Eliminar rooster
            liga = New HyperLink
            liga.Text = "Quitar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "quitar" & i
            liga.NavigateUrl = "deportivas_cambio_rooster.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_inscripcion=" & principal.obj_insrcipciones.tbl_inscripciones_rooster_consulta.tabla_llena.Rows(i)("id_inscripcion").ToString & "&inscripcion_rooster=0".ToString
            Me.tbl_grupo_rooster.Rows(i).Cells(6).Controls.Add(liga)

        Next

    End Sub


    'Btn alta inscripcion
    Protected Sub btn_alta_inscripcion_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_inscripcion.ServerClick
        Response.Redirect("deportivas_consulta_deportistas.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub

    'Btn cambio coach
    Protected Sub btn_cambio_grupo_coach_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cambio_grupo_coach.ServerClick
        Response.Redirect("deportivas_consulta_grupo_coaches.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub

End Class
