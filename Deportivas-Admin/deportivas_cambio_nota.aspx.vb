
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_nota()
    End Sub

    'Consulta nota
    Protected Sub sub_consulta_nota()
        principal.obj_nota.id_nota = Request.QueryString("id_nota")
        principal.obj_nota.sub_nota_consulta()

        If (principal.obj_nota.agregado = True) Then
            Me.txtNotaTitulo.Text = principal.obj_nota.nota_titulo
            Me.txtNotaSubtitulo.Text = principal.obj_nota.nota_subtitulo
            Me.txtNotaTexto.Text = principal.obj_nota.nota_texto

            Me.tbl_nota.DataSource = principal.obj_nota.tbl_nota_consulta.tabla_llena
            Me.tbl_nota.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    'Modificar nota
    Protected Sub btn_modificar_nota_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modificar_nota.ServerClick
        principal.obj_nota.nota_titulo = Me.txtNotaTitulo.Text
        principal.obj_nota.nota_subtitulo = Me.txtNotaSubtitulo.Text
        principal.obj_nota.nota_texto = Me.txtNotaTexto.Text

        principal.obj_nota.sub_nota_modifica()

        Response.Redirect("deportivas_consulta_notas.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
