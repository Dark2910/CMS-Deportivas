
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_foto()
    End Sub

    'Consulta foto deporte
    Protected Sub sub_consulta_foto()
        principal.obj_foto_deporte.id_fdeporte = Request.QueryString("id_fdeporte")
        principal.obj_foto_deporte.sub_foto_deporte_consulta()


        If (principal.obj_foto_deporte.agregado = True) Then
            Me.txt_descripcion.Text = principal.obj_foto_deporte.fdeporte_descripcion

            Me.tbl_galeria_deporte.DataSource = principal.obj_foto_deporte.tbl_foto_deporte_consulta.tabla_llena
            Me.tbl_galeria_deporte.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    'Modificar foto deporte
    Protected Sub btn_modificar_foto_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modificar_foto.ServerClick
        principal.obj_foto_deporte.fdeporte_descripcion = Me.txt_descripcion.Text

        principal.obj_foto_deporte.sub_foto_deporte_modifica()

        Response.Redirect("deportivas_consulta_galeria_deporte.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
