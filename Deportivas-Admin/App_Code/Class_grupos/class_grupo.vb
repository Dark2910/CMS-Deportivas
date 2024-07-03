Imports Microsoft.VisualBasic

Public Class class_grupo

    Public id_grupo As String = Nothing
    Public grupo_nombre As String = Nothing
    Public id_grupo_coach As String = Nothing
    Public id_grupo_deporte As String = Nothing
    Public id_grupo_turno As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_grupo_consulta As New class_llenar_tabla
    Public tbl_grupo_inserta As New class_llenar_tabla
    Public tbl_grupo_modifica As New class_llenar_tabla
    Public tbl_grupo_elimina As New class_llenar_tabla
    Public tbl_grupo_coach_consulta As New class_llenar_tabla
    Public tbl_grupo_coaches_consulta As New class_llenar_tabla
    Public tbl_grupo_inscripciones_consulta As New class_llenar_tabla

    'Consulta
    Public Sub sub_grupo_consulta()
        conexion.sub_set_Conexion()
        tbl_grupo_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupo_consulta.sqltext = "sp_grupo_get " _
        & " @id_grupo = N'" & sql.ft_Secure_SQL(id_grupo) & "'"
        tbl_grupo_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_grupo_consulta.tabla_llena.Rows.Count > 0 Then

            id_grupo = tbl_grupo_consulta.tabla_llena.Rows(0)("id_grupo").ToString
            grupo_nombre = tbl_grupo_consulta.tabla_llena.Rows(0)("grupo_nombre").ToString
            'id_grupo_coach = tbl_grupo_consulta.tabla_llena.Rows(0)("id_grupo_coach").ToString
            'id_grupo_deporte = tbl_grupo_consulta.tabla_llena.Rows(0)("deporte_nombre").ToString
            'id_grupo_turno = tbl_grupo_consulta.tabla_llena.Rows(0)("turno_nombre").ToString

            id_grupo_coach = tbl_grupo_consulta.tabla_llena.Rows(0)("id_grupo_coach").ToString
            id_grupo_deporte = tbl_grupo_consulta.tabla_llena.Rows(0)("id_grupo_deporte").ToString
            id_grupo_turno = tbl_grupo_consulta.tabla_llena.Rows(0)("id_grupo_turno").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_grupo_inserta()
        conexion.sub_set_Conexion()
        tbl_grupo_inserta.cadena_conexion = conexion.db_cadena
        tbl_grupo_inserta.sqltext = "sp_grupo_post " _
        & " @grupo_nombre = N'" & sql.ft_Secure_SQL(grupo_nombre) & "'," _
        & " @id_grupo_coach = " & sql.ft_Secure_SQL(id_grupo_coach) & "," _
        & " @id_grupo_deporte = " & sql.ft_Secure_SQL(id_grupo_deporte) & "," _
        & " @id_grupo_turno = " & sql.ft_Secure_SQL(id_grupo_turno)
        tbl_grupo_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_grupo_modifica()
        conexion.sub_set_Conexion()
        tbl_grupo_modifica.cadena_conexion = conexion.db_cadena
        tbl_grupo_modifica.sqltext = "sp_grupo_update " _
        & " @id_grupo = N'" & sql.ft_Secure_SQL(id_grupo) & "'," _
        & " @grupo_nombre = N'" & sql.ft_Secure_SQL(grupo_nombre) & "'," _
        & " @id_grupo_coach = " & sql.ft_Secure_SQL(id_grupo_coach) & "," _
        & " @id_grupo_deporte = " & sql.ft_Secure_SQL(id_grupo_deporte) & "," _
        & " @id_grupo_turno = " & sql.ft_Secure_SQL(id_grupo_turno)
        tbl_grupo_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_grupo_elimina()
        conexion.sub_set_Conexion()
        tbl_grupo_elimina.cadena_conexion = conexion.db_cadena
        tbl_grupo_elimina.sqltext = "sp_grupo_drop " _
        & " @id_grupo = N'" & sql.ft_Secure_SQL(id_grupo) & "'"
        tbl_grupo_elimina.sub_llenar_tabla()

    End Sub

    'sp_grupo_coach_get
    Public Sub sub_grupo_coach_consulta()
        conexion.sub_set_Conexion()
        tbl_grupo_coach_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupo_coach_consulta.sqltext = "sp_grupo_coach_get " _
        & " @id_grupo = N'" & sql.ft_Secure_SQL(id_grupo) & "'"
        tbl_grupo_coach_consulta.sub_llenar_tabla()

    End Sub

    'sp_grupo_coaches_get
    Public Sub sub_grupo_coaches_consulta()
        conexion.sub_set_Conexion()
        tbl_grupo_coaches_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupo_coaches_consulta.sqltext = "sp_grupo_coaches_get " _
        & " @id_grupo = N'" & sql.ft_Secure_SQL(id_grupo) & "'," _
        & " @id_grupo_deporte = " & sql.ft_Secure_SQL(id_grupo_deporte) & "," _
        & " @id_grupo_turno = " & sql.ft_Secure_SQL(id_grupo_turno)
        tbl_grupo_coaches_consulta.sub_llenar_tabla()

    End Sub

End Class
