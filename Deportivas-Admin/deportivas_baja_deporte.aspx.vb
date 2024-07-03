
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_deporte()

    End Sub

    Protected Sub sub_consulta_deporte()
        Dim principal As New class_principal
        principal.obj_deporte.id_deporte = Request.QueryString("id_deporte")
        principal.obj_deporte.sub_deporte_consulta()

        Me.tbl_deporte.DataSource = principal.obj_deporte.tbl_deporte_consulta.tabla_llena
        Me.tbl_deporte.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        Dim principal As New class_principal
        principal.obj_deporte.id_deporte = Request.QueryString("id_deporte")
        principal.obj_deporte.sub_deporte_elimina()

        Response.Redirect("deportivas_consulta_deportes.aspx")

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_deportes.aspx")

    End Sub
End Class
