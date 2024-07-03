Imports Microsoft.VisualBasic

Public Class class_coach

    Public id_coach As String = Nothing
    Public coach_nombre As String = Nothing
    Public coach_apaterno As String = Nothing
    Public coach_amaterno As String = Nothing
    Public coach_cv As String = Nothing
    Public id_coach_deporte As String = Nothing
    Public id_coach_genero As String = Nothing
    Public id_coach_turno As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_coach_consulta As New class_llenar_tabla
    Public tbl_coach_inserta As New class_llenar_tabla
    Public tbl_coach_modifica As New class_llenar_tabla
    Public tbl_coach_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_coach_consulta()
        conexion.sub_set_Conexion()
        tbl_coach_consulta.cadena_conexion = conexion.db_cadena
        tbl_coach_consulta.sqltext = "sp_coach_get " _
        & " @id_coach = N'" & sql.ft_Secure_SQL(id_coach) & "'"
        tbl_coach_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_coach_consulta.tabla_llena.Rows.Count > 0 Then
            id_coach = tbl_coach_consulta.tabla_llena.Rows(0)("id_coach").ToString
            coach_nombre = tbl_coach_consulta.tabla_llena.Rows(0)("coach_nombre").ToString
            coach_apaterno = tbl_coach_consulta.tabla_llena.Rows(0)("coach_apaterno").ToString
            coach_amaterno = tbl_coach_consulta.tabla_llena.Rows(0)("coach_amaterno").ToString
            coach_cv = tbl_coach_consulta.tabla_llena.Rows(0)("coach_cv").ToString
            id_coach_deporte = tbl_coach_consulta.tabla_llena.Rows(0)("id_coach_deporte").ToString
            id_coach_genero = tbl_coach_consulta.tabla_llena.Rows(0)("id_coach_genero").ToString
            id_coach_turno = tbl_coach_consulta.tabla_llena.Rows(0)("id_coach_turno").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_coach_inserta()
        conexion.sub_set_Conexion()
        tbl_coach_inserta.cadena_conexion = conexion.db_cadena
        tbl_coach_inserta.sqltext = "sp_coach_post " _
        & " @coach_nombre = N'" & sql.ft_Secure_SQL(coach_nombre) & "'," _
        & " @coach_apaterno = N'" & sql.ft_Secure_SQL(coach_apaterno) & "'," _
        & " @coach_amaterno = N'" & sql.ft_Secure_SQL(coach_amaterno) & "'," _
        & " @coach_cv = N'" & sql.ft_Secure_SQL(coach_cv) & "'," _
        & " @id_coach_deporte = " & sql.ft_Secure_SQL(id_coach_deporte) & "," _
        & " @id_coach_genero = " & sql.ft_Secure_SQL(id_coach_genero) & "," _
        & " @id_coach_turno = " & sql.ft_Secure_SQL(id_coach_turno)
        tbl_coach_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_coach_modifica()
        conexion.sub_set_Conexion()
        tbl_coach_modifica.cadena_conexion = conexion.db_cadena
        tbl_coach_modifica.sqltext = "sp_coach_update " _
        & " @id_coach = N'" & sql.ft_Secure_SQL(id_coach) & "'," _
        & " @coach_nombre = N'" & sql.ft_Secure_SQL(coach_nombre) & "'," _
        & " @coach_apaterno = N'" & sql.ft_Secure_SQL(coach_apaterno) & "'," _
        & " @coach_amaterno = N'" & sql.ft_Secure_SQL(coach_amaterno) & "'," _
        & " @coach_cv = N'" & sql.ft_Secure_SQL(coach_cv) & "'," _
        & " @id_coach_deporte = " & sql.ft_Secure_SQL(id_coach_deporte) & "," _
        & " @id_coach_genero = " & sql.ft_Secure_SQL(id_coach_genero) & "," _
        & " @id_coach_turno = " & sql.ft_Secure_SQL(id_coach_turno)
        tbl_coach_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_coach_elimina()
        conexion.sub_set_Conexion()
        tbl_coach_elimina.cadena_conexion = conexion.db_cadena
        tbl_coach_elimina.sqltext = "sp_coach_drop " _
        & " @id_coach = N'" & sql.ft_Secure_SQL(id_coach) & "'"
        tbl_coach_elimina.sub_llenar_tabla()

    End Sub

End Class
