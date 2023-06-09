
Partial Class controls_wuc_login_session
    Inherits System.Web.UI.UserControl

    ReadOnly principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_login_session()

    End Sub

    Protected Sub sub_login_session()
        Dim principal As New class_principal

        If Session("id_usuario") IsNot Nothing Then
            principal.obj_usuario.Id_Usuario = Session("id_usuario")
            principal.obj_usuario.sub_usuario_consulta()

            With principal.obj_usuario

                lbl_usuario.Text = String.Format("{0} {1} {2}", .Nombre, .Apellido_Paterno, .Apellido_Materno)

            End With
        Else
        End If

    End Sub

    Protected Sub img_cerrar_sesion_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles img_cerrar_sesion.Click
        Session.RemoveAll()
        Session.Clear()
        Session.Abandon()
        Response.Redirect("deportivas_login.aspx")

    End Sub


End Class
