Imports Microsoft.VisualBasic

Public Class class_turno

    Public id_turno As String = Nothing
    Public turno_nombre As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_turno_consulta As New class_llenar_tabla
    Public tbl_turno_inserta As New class_llenar_tabla
    Public tbl_turno_modifica As New class_llenar_tabla
    Public tbl_turno_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_turno_consulta()
        conexion.sub_set_Conexion()
        tbl_turno_consulta.cadena_conexion = conexion.db_cadena
        tbl_turno_consulta.sqltext = "sp_turno_get " _
        & " @id_turno = N'" & sql.ft_Secure_SQL(id_turno) & "'"
        tbl_turno_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_turno_consulta.tabla_llena.Rows.Count > 0 Then

            id_turno = tbl_turno_consulta.tabla_llena.Rows(0)("id_turno").ToString
            turno_nombre = tbl_turno_consulta.tabla_llena.Rows(0)("turno_nombre").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_turno_inserta()
        conexion.sub_set_Conexion()
        tbl_turno_inserta.cadena_conexion = conexion.db_cadena
        tbl_turno_inserta.sqltext = "sp_turno_post " _
        & " @turno_nombre = N'" & sql.ft_Secure_SQL(turno_nombre) & "'"
        tbl_turno_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_turno_modifica()
        conexion.sub_set_Conexion()
        tbl_turno_modifica.cadena_conexion = conexion.db_cadena
        tbl_turno_modifica.sqltext = "sp_turno_update " _
        & " @id_turno = N'" & sql.ft_Secure_SQL(turno_nombre) & "'," _
        & " @turno_nombre = N'" & sql.ft_Secure_SQL(turno_nombre) & "'"
        tbl_turno_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_turno_elimina()
        conexion.sub_set_Conexion()
        tbl_turno_elimina.cadena_conexion = conexion.db_cadena
        tbl_turno_elimina.sqltext = "sp_turno_drop " _
        & " @id_turno = N'" & sql.ft_Secure_SQL(id_turno) & "'"
        tbl_turno_elimina.sub_llenar_tabla()

    End Sub
End Class
