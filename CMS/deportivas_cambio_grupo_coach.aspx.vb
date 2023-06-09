
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_cambiar_coach()

    End Sub

    'Cargar datos
    Protected Sub sub_cambiar_coach()
        Dim principal As New class_principal
        principal.obj_grupo.id_grupo = Request.QueryString("id_grupo")
        principal.obj_grupo.sub_grupo_consulta()

        principal.obj_grupo.id_grupo_coach = Request.QueryString("id_coach")
        principal.obj_grupo.sub_grupo_modifica()

        Response.Redirect("deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub

End Class
