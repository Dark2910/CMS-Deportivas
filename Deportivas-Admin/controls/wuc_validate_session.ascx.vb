
Partial Class controls_wuc_validate_session
    Inherits System.Web.UI.UserControl

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_validate_session()

    End Sub

    Protected Sub sub_validate_session()
        If principal.obj_sesion.ft_valida_session(CType(Session("Id_Usuario"), String)) = False Then
            Response.Redirect("~/deportivas_login.aspx")
        End If

    End Sub

End Class
