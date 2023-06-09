
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_coach()

    End Sub

    Protected Sub sub_consulta_coach()
        Dim principal As New class_principal
        principal.obj_coach.id_coach = Request.QueryString("id_coach")
        principal.obj_coach.sub_coach_consulta()

        Me.tbl_coach.DataSource = principal.obj_coach.tbl_coach_consulta.tabla_llena
        Me.tbl_coach.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        Dim principal As New class_principal
        principal.obj_coach.id_coach = Request.QueryString("id_coach")
        principal.obj_coach.sub_coach_elimina()

        Response.Redirect("deportivas_consulta_coaches.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_coaches.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
