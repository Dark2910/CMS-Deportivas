
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub btn_login_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_login.ServerClick
        principal.obj_usuario.Usuario = txt_login.Text
        principal.obj_usuario.Password = txt_contraseña.Text
        principal.obj_usuario.sub_usuario_valida()

        If principal.obj_usuario.Resultado = "1" Then
            principal.obj_usuario.sub_propiedades_login_limpiar()
            principal.obj_usuario.sub_usuario_consulta()

            Session.Timeout = 360

            Session.Add("Id_Usuario", principal.obj_usuario.Id_Usuario)
            Response.Redirect("deportivas_consulta_deportes.aspx")

        Else
            lbl_error.Visible = True
            lbl_error.Text = principal.obj_usuario.Mensaje
        End If

    End Sub

End Class
