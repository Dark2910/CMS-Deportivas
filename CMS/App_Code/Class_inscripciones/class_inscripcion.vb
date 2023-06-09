Imports Microsoft.VisualBasic

Public Class class_inscripcion

    Public id_inscripcion As String = Nothing
    Public id_inscripcion_deportista As String = Nothing
    Public id_inscripcion_grupo As String = Nothing
    Public inscripcion_rooster As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_inscripcion_consulta As New class_llenar_tabla
    Public tbl_inscripcion_inserta As New class_llenar_tabla
    Public tbl_inscripcion_modifica As New class_llenar_tabla
    Public tbl_inscripcion_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_inscripcion_consulta()
        conexion.sub_set_Conexion()
        tbl_inscripcion_consulta.cadena_conexion = conexion.db_cadena
        tbl_inscripcion_consulta.sqltext = "sp_inscripcion_get " _
        & " @id_inscripcion = N'" & sql.ft_Secure_SQL(id_inscripcion) & "'"
        tbl_inscripcion_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_inscripcion_consulta.tabla_llena.Rows.Count > 0 Then

            id_inscripcion = tbl_inscripcion_consulta.tabla_llena.Rows(0)("id_inscripcion").ToString
            id_inscripcion_deportista = tbl_inscripcion_consulta.tabla_llena.Rows(0)("id_inscripcion_deportista").ToString
            id_inscripcion_grupo = tbl_inscripcion_consulta.tabla_llena.Rows(0)("id_inscripcion_grupo").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_inscripcion_inserta()
        conexion.sub_set_Conexion()
        tbl_inscripcion_inserta.cadena_conexion = conexion.db_cadena
        tbl_inscripcion_inserta.sqltext = "sp_inscripcion_post " _
        & " @id_inscripcion_deportista = " & sql.ft_Secure_SQL(id_inscripcion_deportista) & "," _
        & " @id_inscripcion_grupo = " & sql.ft_Secure_SQL(id_inscripcion_grupo)
        tbl_inscripcion_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_inscripcion_modifica()
        conexion.sub_set_Conexion()
        tbl_inscripcion_modifica.cadena_conexion = conexion.db_cadena
        tbl_inscripcion_modifica.sqltext = "sp_inscripcion_update " _
        & " @id_inscripcion = " & sql.ft_Secure_SQL(id_inscripcion) & "," _
        & " @id_inscripcion_deportista = " & sql.ft_Secure_SQL(id_inscripcion_deportista) & "," _
        & " @id_inscripcion_grupo = " & sql.ft_Secure_SQL(id_inscripcion_grupo) & "," _
        & " @inscripcion_rooster = " & sql.ft_Secure_SQL(inscripcion_rooster)
        tbl_inscripcion_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_inscripcion_elimina()
        conexion.sub_set_Conexion()
        tbl_inscripcion_elimina.cadena_conexion = conexion.db_cadena
        tbl_inscripcion_elimina.sqltext = "sp_inscripcion_drop " _
        & " @id_inscripcion = N'" & sql.ft_Secure_SQL(id_inscripcion) & "'"
        tbl_inscripcion_elimina.sub_llenar_tabla()

    End Sub

End Class
