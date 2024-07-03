
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_grupo()

    End Sub

    'Consulta grupo
    Protected Sub sub_consulta_grupo()
        principal.obj_grupo.id_grupo = Request.QueryString("id_grupo")
        principal.obj_grupo.sub_grupo_consulta()

        If (principal.obj_grupo.agregado = True) Then
            Me.txtGrupoNombre.Text = principal.obj_grupo.grupo_nombre

            Me.tbl_grupo.DataSource = principal.obj_grupo.tbl_grupo_consulta.tabla_llena
            Me.tbl_grupo.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"
        End If

    End Sub

    'Modifica grupo
    Protected Sub btn_modificar_grupo_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modificar_grupo.ServerClick
        principal.obj_grupo.grupo_nombre = Me.txtGrupoNombre.Text
        principal.obj_grupo.id_grupo_turno = Me.Wuc_turnos1.ftn_valor_seleccionado()

        If (principal.obj_grupo.id_grupo_coach = "") Then
            principal.obj_grupo.id_grupo_coach = "NULL"
        End If

        principal.obj_grupo.sub_grupo_modifica()

        Response.Redirect("deportivas_consulta_grupos.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
