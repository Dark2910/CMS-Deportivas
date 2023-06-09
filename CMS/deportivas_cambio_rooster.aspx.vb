
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_rooster()

    End Sub

    Protected Sub sub_consulta_rooster()
        principal.obj_inscripcion.id_inscripcion = Request.QueryString("id_inscripcion")
        principal.obj_inscripcion.sub_inscripcion_consulta()

        principal.obj_inscripcion.inscripcion_rooster = Request.QueryString("inscripcion_rooster")
        principal.obj_inscripcion.sub_inscripcion_modifica()

        Response.Redirect("deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub

End Class
