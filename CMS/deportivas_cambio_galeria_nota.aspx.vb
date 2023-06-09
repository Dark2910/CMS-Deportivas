
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_constulta_galeria_nota()

    End Sub

    'Consultar galeria nota
    Protected Sub sub_constulta_galeria_nota()
        principal.obj_foto_nota.id_fnota = Request.QueryString("id_fnota")
        principal.obj_foto_nota.sub_foto_nota_consulta()

        If (principal.obj_foto_nota.agregado = True) Then
            Me.txt_descripcion.Text = principal.obj_foto_nota.fnota_descripcion

            Me.tbl_galeria_nota.DataSource = principal.obj_foto_nota.tbl_foto_nota_consulta.tabla_llena
            Me.tbl_galeria_nota.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If


    End Sub

    Protected Sub btn_cambio_foto_nota_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cambio_foto_nota.ServerClick
        principal.obj_foto_nota.fnota_descripcion = Me.txt_descripcion.Text

        principal.obj_foto_nota.sub_foto_nota_modifica()

        Response.Redirect("deportivas_consulta_galeria_nota.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_nota=" & Request.QueryString("id_nota"))

    End Sub
End Class
