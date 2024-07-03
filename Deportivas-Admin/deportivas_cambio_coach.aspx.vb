
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_coach()
    End Sub

    'Consulta coach
    Protected Sub sub_consulta_coach()
        principal.obj_coach.id_coach = Request.QueryString("id_coach")
        principal.obj_coach.sub_coach_consulta()

        If (principal.obj_coach.agregado = True) Then
            Me.txtCoachNombre.Text = principal.obj_coach.coach_nombre
            Me.txtCoachApaterno.Text = principal.obj_coach.coach_apaterno
            Me.txtCoachAmaterno.Text = principal.obj_coach.coach_amaterno
            Me.txtCv.Text = principal.obj_coach.coach_cv

            Me.tbl_coach.DataSource = principal.obj_coach.tbl_coach_consulta.tabla_llena
            Me.tbl_coach.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    'Modificar coach
    Protected Sub btn_modificar_coach_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modificar_coach.ServerClick
        principal.obj_coach.id_coach = Request.QueryString("id_coach")
        principal.obj_coach.coach_nombre = Me.txtCoachNombre.Text
        principal.obj_coach.coach_apaterno = Me.txtCoachApaterno.Text
        principal.obj_coach.coach_amaterno = Me.txtCoachAmaterno.Text
        principal.obj_coach.coach_cv = Me.txtCv.Text
        principal.obj_coach.id_coach_genero = Me.Wuc_generos1.ftn_valor_seleccionado()
        principal.obj_coach.id_coach_turno = Me.Wuc_turnos1.ftn_valor_seleccionado()

        principal.obj_coach.sub_coach_modifica()

        Response.Redirect("deportivas_consulta_coaches.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
