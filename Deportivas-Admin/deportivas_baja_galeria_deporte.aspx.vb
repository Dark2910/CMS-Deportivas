
Partial Class Default2
    Inherits System.Web.UI.Page


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_eliminar_galeria_deporte()

    End Sub

    Protected Sub sub_eliminar_galeria_deporte()
        Dim principal As New class_principal
        principal.obj_foto_deporte.id_fdeporte = Request.QueryString("id_fdeporte")
        principal.obj_foto_deporte.sub_foto_deporte_consulta()

        Me.tbl_galeria_deporte.DataSource = principal.obj_foto_deporte.tbl_foto_deporte_consulta.tabla_llena
        Me.tbl_galeria_deporte.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        Dim principal As New class_principal
        principal.obj_foto_deporte.id_fdeporte = Request.QueryString("id_fdeporte")
        principal.obj_foto_deporte.sub_foto_deporte_elimina()

        Response.Redirect("deportivas_consulta_galeria_deporte.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_galeria_deporte.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
