
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_calendario()

    End Sub

    'Consulta nota
    Protected Sub sub_consulta_calendario()
        principal.obj_calendario.id_calendario = Request.QueryString("id_calendario")
        principal.obj_calendario.sub_calendario_consulta()

        Me.tbl_calendario.DataSource = principal.obj_calendario.tbl_calendario_consulta.tabla_llena
        Me.tbl_calendario.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        principal.obj_calendario.id_calendario = Request.QueryString("id_calendario")
        principal.obj_calendario.sub_calendario_elimina()

        Response.Redirect("deportivas_consulta_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
