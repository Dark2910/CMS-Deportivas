Imports Microsoft.VisualBasic

Public Class class_deporte

    Public id_deporte As String = Nothing
    Public deporte_nombre As String = Nothing
    Public deporte_objetivo As String = Nothing
    Public deporte_descripcion As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_deporte_consulta As New class_llenar_tabla
    Public tbl_deporte_inserta As New class_llenar_tabla
    Public tbl_deporte_modifica As New class_llenar_tabla
    Public tbl_deporte_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_deporte_consulta()
        conexion.sub_set_Conexion()
        tbl_deporte_consulta.cadena_conexion = conexion.db_cadena
        tbl_deporte_consulta.sqltext = "sp_deporte_get " _
        & " @id_deporte = N'" & sql.ft_Secure_SQL(id_deporte) & "'"
        tbl_deporte_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_deporte_consulta.tabla_llena.Rows.Count > 0 Then

            id_deporte = tbl_deporte_consulta.tabla_llena.Rows(0)("id_deporte").ToString
            deporte_nombre = tbl_deporte_consulta.tabla_llena.Rows(0)("deporte_nombre").ToString
            deporte_objetivo = tbl_deporte_consulta.tabla_llena.Rows(0)("deporte_objetivo").ToString
            deporte_descripcion = tbl_deporte_consulta.tabla_llena.Rows(0)("deporte_descripcion").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_deporte_inserta()
        conexion.sub_set_Conexion()
        tbl_deporte_inserta.cadena_conexion = conexion.db_cadena
        tbl_deporte_inserta.sqltext = "sp_deporte_post " _
        & " @deporte_nombre = N'" & sql.ft_Secure_SQL(deporte_nombre) & "'," _
        & " @deporte_objetivo = N'" & sql.ft_Secure_SQL(deporte_objetivo) & "'," _
        & " @deporte_descripcion = N'" & sql.ft_Secure_SQL(deporte_descripcion) & "'"
        tbl_deporte_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_deporte_modifica()
        conexion.sub_set_Conexion()
        tbl_deporte_modifica.cadena_conexion = conexion.db_cadena
        tbl_deporte_modifica.sqltext = "sp_deporte_update " _
        & " @id_deporte = N'" & sql.ft_Secure_SQL(id_deporte) & "'," _
        & " @deporte_nombre = N'" & sql.ft_Secure_SQL(deporte_nombre) & "'," _
        & " @deporte_objetivo = N'" & sql.ft_Secure_SQL(deporte_objetivo) & "'," _
        & " @deporte_descripcion = N'" & sql.ft_Secure_SQL(deporte_descripcion) & "'"
        tbl_deporte_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_deporte_elimina()
        conexion.sub_set_Conexion()
        tbl_deporte_elimina.cadena_conexion = conexion.db_cadena
        tbl_deporte_elimina.sqltext = "sp_deporte_drop " _
        & " @id_deporte = N'" & sql.ft_Secure_SQL(id_deporte) & "'"
        tbl_deporte_elimina.sub_llenar_tabla()

    End Sub
End Class
