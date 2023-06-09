
Partial Class Default2
    Inherits System.Web.UI.Page


    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_galeria_nota()

    End Sub

    'Consultar galeria calendario
    Protected Sub sub_constulta_galeria_nota()
        principal.obj_foto_calendario.id_fcalendario = Request.QueryString("id_fcalendario")
        principal.obj_foto_calendario.sub_foto_calendario_consulta()

        Me.tbl_galeria_calendario.DataSource = principal.obj_foto_calendario.tbl_foto_calendario_consulta.tabla_llena
        Me.tbl_galeria_calendario.DataBind()

    End Sub


    Protected Sub btn_eliminar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_eliminar.ServerClick
        principal.obj_foto_calendario.id_fcalendario = Request.QueryString("id_fcalendario")
        principal.obj_foto_calendario.sub_foto_calendario_elimina()

        Response.Redirect("deportivas_consulta_galeria_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario"))

    End Sub


    Protected Sub btn_cancelar_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cancelar.ServerClick
        Response.Redirect("deportivas_consulta_galeria_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_calendario=" & Request.QueryString("id_calendario"))

    End Sub
End Class
