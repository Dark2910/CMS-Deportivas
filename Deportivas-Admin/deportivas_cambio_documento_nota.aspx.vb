
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_documentos_nota()

    End Sub

    'Consultar documentos nota
    Protected Sub sub_constulta_documentos_nota()
        principal.obj_documento_nota.id_dnota = Request.QueryString("id_dnota")
        principal.obj_documento_nota.sub_decumento_nota_consulta()

        If (principal.obj_documento_nota.agregado = True) Then
            Me.txt_descripcion.Text = principal.obj_documento_nota.dnota_descripcion

            Me.tbl_documento_nota.DataSource = principal.obj_documento_nota.tbl_decumento_nota_consulta.tabla_llena
            Me.tbl_documento_nota.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    Protected Sub btn_cambio_documento_nota_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cambio_documento_nota.ServerClick
        principal.obj_documento_nota.dnota_descripcion = Me.txt_descripcion.Text

        principal.obj_documento_nota.sub_decumento_nota_modifica()

        Response.Redirect("deportivas_consulta_documentos_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota"))

    End Sub
End Class
