
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_grupo()

    End Sub

    Protected Sub sub_consulta_grupo()
        Dim principal As New class_principal
        principal.obj_grupo.id_grupo = Request.QueryString("id_grupo")
        principal.obj_grupo.sub_grupo_consulta()

        Me.tbl_grupo.DataSource = principal.obj_grupo.tbl_grupo_consulta.tabla_llena
        Me.tbl_grupo.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        Dim principal As New class_principal
        principal.obj_grupo.id_grupo = Request.QueryString("id_grupo")
        principal.obj_grupo.sub_grupo_elimina()

        Response.Redirect("deportivas_consulta_grupos.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_grupos.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

End Class
