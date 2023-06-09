
Partial Class Default2
    Inherits System.Web.UI.Page

    Dim principal As New class_principal
    Dim columna As New Data.DataColumn
    Dim liga As New HyperLink
    Dim i As Integer

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_consulta_matutino()
        sub_consulta_vespertino()
        sub_consulta_pendientes()

    End Sub

    'Consultar grupo matutino
    Public Sub sub_consulta_matutino()
        principal.obj_grupos.id_grupo_deporte = Request.QueryString("id_deporte")
        principal.obj_grupos.sub_grupos_matutino_consulta()

        columna = New Data.DataColumn
        columna.ColumnName = "Integrantes"
        principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_grupos_matutino.DataSource = principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena
        Me.tbl_grupos_matutino.DataBind()

        For i = 0 To principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Rows.Count - 1
            'Liga Integrantes
            liga = New HyperLink
            liga.Text = "Integranetes"
            liga.ImageUrl = "./assets/img/integrantes.png"
            liga.ID = "grupo_matutino_integrantes" & i
            liga.NavigateUrl = "deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Rows(i)("id_grupo").ToString & "&id_grupo_turno=" & principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Rows(i)("id_grupo_turno").ToString
            Me.tbl_grupos_matutino.Rows(i).Cells(6).Controls.Add(liga)

            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "grupo_matutino_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_grupo.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Rows(i)("id_grupo")
            Me.tbl_grupos_matutino.Rows(i).Cells(7).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "grupo_matutino_elimina" & i
            liga.NavigateUrl = "deportivas_baja_grupo.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_matutino_consulta.tabla_llena.Rows(i)("id_grupo")
            Me.tbl_grupos_matutino.Rows(i).Cells(8).Controls.Add(liga)

        Next

    End Sub

    'Consultar grupo vespertino
    Public Sub sub_consulta_vespertino()
        principal.obj_grupos.id_grupo_deporte = Request.QueryString("id_deporte")
        principal.obj_grupos.sub_grupos_vespertino_consulta()

        columna = New Data.DataColumn
        columna.ColumnName = "Integrantes"
        principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_grupos_vespertino.DataSource = principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena
        Me.tbl_grupos_vespertino.DataBind()

        For i = 0 To principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Rows.Count - 1
            'Liga Integrantes
            liga = New HyperLink
            liga.Text = "Integranetes"
            liga.ImageUrl = "./assets/img/integrantes.png"
            liga.ID = "grupo_vespertino_integrantes" & i
            liga.NavigateUrl = "deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Rows(i)("id_grupo").ToString & "&id_grupo_turno=" & principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Rows(i)("id_grupo_turno").ToString
            Me.tbl_grupos_vespertino.Rows(i).Cells(6).Controls.Add(liga)

            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "grupo_vespertino_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_grupo.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Rows(i)("id_grupo").ToString
            Me.tbl_grupos_vespertino.Rows(i).Cells(7).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "grupo_vespertino_elimina" & i
            liga.NavigateUrl = "deportivas_baja_grupo.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_vespertino_consulta.tabla_llena.Rows(i)("id_grupo").ToString
            Me.tbl_grupos_vespertino.Rows(i).Cells(8).Controls.Add(liga)

        Next

    End Sub

    'Consultar grupos pendientes
    Public Sub sub_consulta_pendientes()
        principal.obj_grupos.id_grupo_deporte = Request.QueryString("id_deporte")
        principal.obj_grupos.sub_grupos_pendientes_consulta()

        columna = New Data.DataColumn
        columna.ColumnName = "Integrantes"
        principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Modificar"
        principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Columns.Add(columna)

        columna = New Data.DataColumn
        columna.ColumnName = "Eliminar"
        principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Columns.Add(columna)

        Me.tbl_grupos_pendientes.DataSource = principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena
        Me.tbl_grupos_pendientes.DataBind()

        For i = 0 To principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Rows.Count - 1
            'Liga Integrantes
            liga = New HyperLink
            liga.Text = "Integranetes"
            liga.ImageUrl = "./assets/img/integrantes.png"
            liga.ID = "grupo_pendiente_integrantes" & i
            liga.NavigateUrl = "deportivas_consulta_grupo_integrantes.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Rows(i)("id_grupo").ToString & "&id_grupo_turno=" & principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Rows(i)("id_grupo_turno").ToString
            Me.tbl_grupos_pendientes.Rows(i).Cells(6).Controls.Add(liga)

            'Liga Modificar
            liga = New HyperLink
            liga.Text = "Modificar"
            liga.ImageUrl = "./assets/img/edit.png"
            liga.ID = "grupo_pendiente_modifica" & i
            liga.NavigateUrl = "deportivas_cambio_grupo.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Rows(i)("id_grupo").ToString
            Me.tbl_grupos_pendientes.Rows(i).Cells(7).Controls.Add(liga)

            'Liga Eliminar
            liga = New HyperLink
            liga.Text = "Eliminar"
            liga.ImageUrl = "./assets/img/delete.png"
            liga.ID = "grupo_pendiente_elimina" & i
            liga.NavigateUrl = "deportivas_baja_grupo.aspx?id_deporte=" & Request.QueryString("id_deporte") & "&id_grupo=" & principal.obj_grupos.tbl_grupos_pendientes_consulta.tabla_llena.Rows(i)("id_grupo").ToString
            Me.tbl_grupos_pendientes.Rows(i).Cells(8).Controls.Add(liga)

        Next

    End Sub

    'Alta grupo
    Protected Sub btn_alta_grupo_ServerClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_alta_grupo.ServerClick
        Dim principal As New class_principal

        principal.obj_grupo.grupo_nombre = Me.txtGrupoNombre.Text
        principal.obj_grupo.id_grupo_coach = "NULL"
        principal.obj_grupo.id_grupo_deporte = Request.QueryString("id_deporte")
        principal.obj_grupo.id_grupo_turno = Me.Wuc_turnos1.ftn_valor_seleccionado()

        principal.obj_grupo.sub_grupo_inserta()

        Response.Redirect("deportivas_consulta_grupos.aspx?id_deporte=" & Request.QueryString("id_deporte"))

    End Sub

End Class
