
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_calendario()

    End Sub

    'Consulta nota
    Protected Sub sub_consulta_calendario()
        principal.obj_calendario.id_calendario = Request.QueryString("id_calendario")
        principal.obj_calendario.sub_calendario_consulta()

        If (principal.obj_calendario.agregado = True) Then
            Me.txtCalendarioNombreEvento.Text = principal.obj_calendario.calendario_nombre_evento
            Me.txtCalendarioDescripcionEvento.Text = principal.obj_calendario.calendario_descripcion_evento
            Me.txtFechaEvento.Text = principal.obj_calendario.calendario_fecha_evento

            Me.tbl_calendario.DataSource = principal.obj_calendario.tbl_calendario_consulta.tabla_llena
            Me.tbl_calendario.DataBind()

        Else
            Me.lblMensaje.Visible = True
            Me.lblMensaje.Text = "Error de busqueda"

        End If

    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged
        Me.txtFechaEvento.Text = Me.Calendar1.SelectedDate.Year & "-" & Me.Calendar1.SelectedDate.Month & "-" & Me.Calendar1.SelectedDate.Day

    End Sub

    Protected Sub btn_modificar_calendario_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_modificar_calendario.ServerClick
        principal.obj_calendario.calendario_nombre_evento = Me.txtCalendarioNombreEvento.Text
        principal.obj_calendario.calendario_descripcion_evento = Me.txtCalendarioDescripcionEvento.Text
        principal.obj_calendario.calendario_fecha_evento = Me.txtFechaEvento.Text

        principal.obj_calendario.sub_calendario_modifica()

        Response.Redirect("deportivas_consulta_calendario.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub
End Class
