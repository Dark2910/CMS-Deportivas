
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_nota()

    End Sub

    Protected Sub sub_consulta_nota()
        Dim principal As New class_principal
        principal.obj_nota.id_nota = Request.QueryString("id_nota")
        principal.obj_nota.sub_nota_consulta()

        Me.tbl_nota.DataSource = principal.obj_nota.tbl_nota_consulta.tabla_llena
        Me.tbl_nota.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        Dim principal As New class_principal
        principal.obj_nota.id_nota = Request.QueryString("id_nota")
        principal.obj_nota.sub_nota_elimina()

        Response.Redirect("deportivas_consulta_notas.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_notas.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

End Class
