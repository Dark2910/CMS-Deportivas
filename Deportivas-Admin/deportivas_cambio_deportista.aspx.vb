
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_coach()

    End Sub

    'Consulta deportista
    Protected Sub sub_consulta_coach()
        principal.obj_deportista.id_deportista = Request.QueryString("id_deportista")
        principal.obj_deportista.sub_deportista_consulta()

        If (principal.obj_deportista.agregado = True) Then
            Me.txtDeportistaNombre.Text = principal.obj_deportista.deportista_nombre
            Me.txtDeportistaApaterno.Text = principal.obj_deportista.deportista_apaterno
            Me.txtDeportistaAmaterno.Text = principal.obj_deportista.deportista_amaterno
            Me.txtDeportistaMatricula.Text = principal.obj_deportista.deportista_matricula

            Me.tbl_deportista.DataSource = principal.obj_deportista.tbl_deportista_consulta.tabla_llena
            Me.tbl_deportista.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    'Modificar deportista
    Protected Sub btn_cambio_deportista_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cambio_deportista.ServerClick
        principal.obj_deportista.deportista_nombre = Me.txtDeportistaNombre.Text
        principal.obj_deportista.deportista_apaterno = Me.txtDeportistaApaterno.Text
        principal.obj_deportista.deportista_amaterno = Me.txtDeportistaAmaterno.Text
        principal.obj_deportista.deportista_matricula = Me.txtDeportistaMatricula.Text
        principal.obj_deportista.id_deportista_genero = Me.Wuc_generos1.ftn_valor_seleccionado()
        principal.obj_deportista.id_deportista_carrera = Me.Wuc_carreras1.ftn_valor_seleccionado()

        principal.obj_deportista.sub_deportista_modifica()

        Response.Redirect("deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & Request.QueryString("id_grupo") & "&id_grupo_turno=" & Request.QueryString("id_grupo_turno"))

    End Sub
End Class
