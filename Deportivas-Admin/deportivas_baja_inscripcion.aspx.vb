
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_eliminar_inscripcion()

    End Sub

    Protected Sub sub_eliminar_inscripcion()
        Dim principal As New class_principal

        principal.obj_inscripcion.id_inscripcion = Request.QueryString("id_inscripcion")
        principal.obj_inscripcion.sub_inscripcion_elimina()

        Response.Redirect("deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub

End Class
