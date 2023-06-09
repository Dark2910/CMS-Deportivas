
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal



    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_documento_nota()

    End Sub

    'Consultar documento calendario
    Protected Sub sub_consulta_documento_nota()
        principal.obj_documento_calendario.id_dcalendario = Request.QueryString("id_dcalendario")
        principal.obj_documento_calendario.sub_decumento_calendario_consulta()

        Me.tbl_documento_calendario.DataSource = principal.obj_documento_calendario.tbl_decumento_calendario_consulta.tabla_llena
        Me.tbl_documento_calendario.DataBind()

    End Sub

    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        principal.obj_documento_calendario.id_dcalendario = Request.QueryString("id_dcalendario")
        principal.obj_documento_calendario.sub_decumento_calendario_elimina()

        Response.Redirect("deportivas_consulta_documentos_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario"))

    End Sub

    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_documentos_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario"))

    End Sub
End Class
