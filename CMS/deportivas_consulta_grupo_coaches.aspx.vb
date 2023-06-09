
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_coaches_grupo()

    End Sub

    'Consultar coaches
    Protected Sub sub_consulta_coaches_grupo()
        principal.obj_grupo.id_grupo = Request.QueryString("id_grupo")
        principal.obj_grupo.id_grupo_deporte = Request.QueryString("id_deporte")
        principal.obj_grupo.id_grupo_turno = Request.QueryString("id_grupo_turno")
        principal.obj_grupo.sub_grupo_coaches_consulta()

        Dim columna As New Data.DataColumn
        columna.ColumnName = "Cambiar coach"
        principal.obj_grupo.tbl_grupo_coaches_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_coaches_grupo.DataSource = principal.obj_grupo.tbl_grupo_coaches_consulta.tabla_llena
        Me.tbl_coaches_grupo.DataBind()

        Dim liga As New HyperLink
        Dim i As Integer

        For i = 0 To principal.obj_grupo.tbl_grupo_coaches_consulta.tabla_llena.Rows.Count - 1
            'Liga modificar
            liga = New HyperLink
            liga.Text = "Cambiar coach"
            liga.ImageUrl = "./assets/img/switch_coach.png"
            liga.ID = "coaches_grupo_cambia_coache" & i
            liga.NavigateUrl = "deportivas_cambio_grupo_coach.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno") & "&id_coach=" & principal.obj_grupo.tbl_grupo_coaches_consulta.tabla_llena.Rows(i)("id_coach").ToString
            Me.tbl_coaches_grupo.Rows(i).Cells(5).Controls.Add(liga)

        Next

        'Alta coach
    End Sub

    Protected Sub btn_alta_coach_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_coach.ServerClick
        principal.obj_coach.coach_nombre = Me.txtCoachNombre.Text
        principal.obj_coach.coach_apaterno = Me.txtCoachApaterno.Text
        principal.obj_coach.coach_amaterno = Me.txtCoachAmaterno.Text
        principal.obj_coach.id_coach_deporte = Request.QueryString("id_deporte")
        principal.obj_coach.id_coach_genero = Me.Wuc_generos1.ftn_valor_seleccionado()
        principal.obj_coach.id_coach_turno = Request.QueryString("id_grupo_turno")
        principal.obj_coach.coach_cv = Me.txtCv.Text

        principal.obj_coach.sub_coach_inserta()

        Response.Redirect("deportivas_consulta_grupo_coaches.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub
End Class
