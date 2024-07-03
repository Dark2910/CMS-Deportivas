
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_coaches()

    End Sub

    'Consulta coaches
    Protected Sub sub_consulta_coaches()
        Dim principal As New class_principal
        principal.obj_coaches.id_coach_deporte = Request.QueryString("id_deporte")
        principal.obj_coaches.sub_coaches_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_coaches.tbl_coaches_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_coaches.tbl_coaches_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_coaches.DataSource = principal.obj_coaches.tbl_coaches_consulta.tabla_llena
        Me.tbl_coaches.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_coaches.tbl_coaches_consulta.tabla_llena.Rows.Count - 1
            'Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "coach_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_coach.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_coach=" & principal.obj_coaches.tbl_coaches_consulta.tabla_llena.Rows(i)("id_coach").ToString
            Me.tbl_coaches.Rows(i).Cells(6).Controls.Add(liga)

            'Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "coach_elimina" & i
            liga.NavigateUrl = "deportivas_baja_coach.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_coach=" & principal.obj_coaches.tbl_coaches_consulta.tabla_llena.Rows(i)("id_coach").ToString
            Me.tbl_coaches.Rows(i).Cells(7).Controls.Add(liga)

        Next

    End Sub

    'Alta coach
    Protected Sub btn_alta_coach_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_coach.ServerClick
        Dim principal As New class_principal

        principal.obj_coach.coach_nombre = Me.txtCoachNombre.Text
        principal.obj_coach.coach_apaterno = Me.txtCoachApaterno.Text
        principal.obj_coach.coach_amaterno = Me.txtCoachAmaterno.Text
        principal.obj_coach.id_coach_deporte = Request.QueryString("id_deporte")
        principal.obj_coach.id_coach_genero = Me.Wuc_generos1.ftn_valor_seleccionado()
        principal.obj_coach.id_coach_turno = Me.Wuc_turnos1.ftn_valor_seleccionado()
        principal.obj_coach.coach_cv = Me.txtCv.Text

        principal.obj_coach.sub_coach_inserta()

        Response.Redirect("deportivas_consulta_coaches.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
