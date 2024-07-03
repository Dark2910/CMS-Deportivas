
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_coach()
    End Sub

    'Consulta deportista
    Protected Sub sub_consulta_coach()
        principal.obj_deportista.id_deportista = Request.QueryString("id_deportista")
        principal.obj_deportista.sub_deportista_consulta()

        Me.tbl_deportista.DataSource = principal.obj_deportista.tbl_deportista_consulta.tabla_llena
        Me.tbl_deportista.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        principal.obj_deportista.id_deportista = Request.QueryString("id_deportista")
        principal.obj_deportista.sub_deportista_elimina()

        Response.Redirect("deportivas_consulta_deportistas.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))
    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_deportistas.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))
    End Sub
End Class
