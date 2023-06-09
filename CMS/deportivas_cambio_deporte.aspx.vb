
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_deporte()

    End Sub

    Protected Sub sub_consulta_deporte()
        Dim principal As New class_principal
        principal.obj_deporte.id_deporte = Request.QueryString("id_deporte")
        principal.obj_deporte.sub_deporte_consulta()

        If (principal.obj_deporte.agregado = True) Then
            Me.txtDeporteNombre.Text = principal.obj_deporte.deporte_nombre
            Me.txtDeporteObjetivo.Text = principal.obj_deporte.deporte_objetivo
            Me.txtDeporteDescripcion.Text = principal.obj_deporte.deporte_descripcion

            Me.tbl_deporte.DataSource = principal.obj_deporte.tbl_deporte_consulta.tabla_llena
            Me.tbl_deporte.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    Protected Sub btn_cambio_deporte_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_cambio_deporte.ServerClick
        Dim principal As New class_principal
        principal.obj_deporte.id_deporte = Request.QueryString("id_deporte")
        principal.obj_deporte.deporte_nombre = Me.txtDeporteNombre.Text
        principal.obj_deporte.deporte_objetivo = Me.txtDeporteObjetivo.Text
        principal.obj_deporte.deporte_descripcion = Me.txtDeporteDescripcion.Text

        principal.obj_deporte.sub_deporte_modifica()

        Response.Redirect("deportivas_consulta_deportes.aspx")

    End Sub
End Class
