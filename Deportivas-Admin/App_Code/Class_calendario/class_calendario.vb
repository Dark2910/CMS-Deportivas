Imports Microsoft.VisualBasic

Public Class class_calendario

    Public id_calendario As String = Nothing
    Public calendario_nombre_evento As String = Nothing
    Public calendario_descripcion_evento As String = Nothing
    Public calendario_fecha_evento As String = Nothing
    Public id_calendario_deporte As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_calendario_consulta As New class_llenar_tabla
    Public tbl_calendario_inserta As New class_llenar_tabla
    Public tbl_calendario_modifica As New class_llenar_tabla
    Public tbl_calendario_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_calendario_consulta()
        conexion.sub_set_Conexion()
        tbl_calendario_consulta.cadena_conexion = conexion.db_cadena
        tbl_calendario_consulta.sqltext = "sp_calendario_get " _
        & " @id_calendario = N'" & sql.ft_Secure_SQL(id_calendario) & "'"
        tbl_calendario_consulta.sub_llenar_tabla()

        agregado = False

        If (tbl_calendario_consulta.tabla_llena.Rows.Count > 0) Then
            id_calendario = tbl_calendario_consulta.tabla_llena.Rows(0)("id_calendario").ToString
            calendario_nombre_evento = tbl_calendario_consulta.tabla_llena.Rows(0)("calendario_nombre_evento").ToString
            calendario_descripcion_evento = tbl_calendario_consulta.tabla_llena.Rows(0)("calendario_descripcion_evento").ToString
            calendario_fecha_evento = tbl_calendario_consulta.tabla_llena.Rows(0)("calendario_fecha_evento").ToString
            id_calendario_deporte = tbl_calendario_consulta.tabla_llena.Rows(0)("id_calendario_deporte").ToString

            agregado = True

        End If

    End Sub

    'Inserta
    Public Sub sub_calendario_inserta()
        conexion.sub_set_Conexion()
        tbl_calendario_inserta.cadena_conexion = conexion.db_cadena
        tbl_calendario_inserta.sqltext = "sp_calendario_post " _
        & " @calendario_nombre_evento = N'" & sql.ft_Secure_SQL(calendario_nombre_evento) & "'," _
        & " @calendario_descripcion_evento = N'" & sql.ft_Secure_SQL(calendario_descripcion_evento) & "'," _
        & " @calendario_fecha_evento = N'" & sql.ft_Secure_SQL(calendario_fecha_evento) & "'," _
        & " @id_calendario_deporte = " & sql.ft_Secure_SQL(id_calendario_deporte)
        tbl_calendario_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_calendario_modifica()
        conexion.sub_set_Conexion()
        tbl_calendario_modifica.cadena_conexion = conexion.db_cadena
        tbl_calendario_modifica.sqltext = "sp_calendario_update " _
        & " @id_calendario = N'" & sql.ft_Secure_SQL(id_calendario) & "'," _
        & " @calendario_nombre_evento = N'" & sql.ft_Secure_SQL(calendario_nombre_evento) & "'," _
        & " @calendario_descripcion_evento = N'" & sql.ft_Secure_SQL(calendario_descripcion_evento) & "'," _
        & " @calendario_fecha_evento = N'" & sql.ft_Secure_SQL(calendario_fecha_evento) & "'," _
        & " @id_calendario_deporte = " & sql.ft_Secure_SQL(id_calendario_deporte)
        tbl_calendario_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_calendario_elimina()
        conexion.sub_set_Conexion()
        tbl_calendario_elimina.cadena_conexion = conexion.db_cadena
        tbl_calendario_elimina.sqltext = "sp_calendario_drop " _
        & " @id_calendario = N'" & sql.ft_Secure_SQL(id_calendario) & "'"
        tbl_calendario_elimina.sub_llenar_tabla()

    End Sub

End Class
