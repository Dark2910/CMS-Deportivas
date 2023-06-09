Imports Microsoft.VisualBasic

Public Class class_grupos

    Public id_grupo_deporte As String = Nothing
    Dim conexion As New class_conexion

    Dim sql As New class_sql

    Public tbl_grupos_consulta As New class_llenar_tabla
    Public tbl_grupos_matutino_consulta As New class_llenar_tabla
    Public tbl_grupos_vespertino_consulta As New class_llenar_tabla
    Public tbl_grupos_pendientes_consulta As New class_llenar_tabla

    Public Sub sub_grupos_consulta()
        conexion.sub_set_Conexion()
        tbl_grupos_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupos_consulta.sqltext = "sp_grupos_get " _
        & " @id_grupo_deporte = N'" & sql.ft_Secure_SQL(id_grupo_deporte) & "'"
        tbl_grupos_consulta.sub_llenar_tabla()

    End Sub

    Public Sub sub_grupos_matutino_consulta()
        conexion.sub_set_Conexion()
        tbl_grupos_matutino_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupos_matutino_consulta.sqltext = "sp_grupos_matutino_get " _
        & " @id_grupo_deporte = N'" & sql.ft_Secure_SQL(id_grupo_deporte) & "'"
        tbl_grupos_matutino_consulta.sub_llenar_tabla()

    End Sub

    Public Sub sub_grupos_vespertino_consulta()
        conexion.sub_set_Conexion()
        tbl_grupos_vespertino_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupos_vespertino_consulta.sqltext = "sp_grupos_vespertino_get " _
        & " @id_grupo_deporte = N'" & sql.ft_Secure_SQL(id_grupo_deporte) & "'"
        tbl_grupos_vespertino_consulta.sub_llenar_tabla()

    End Sub

    Public Sub sub_grupos_pendientes_consulta()
        conexion.sub_set_Conexion()
        tbl_grupos_pendientes_consulta.cadena_conexion = conexion.db_cadena
        tbl_grupos_pendientes_consulta.sqltext = "sp_grupos_pendientes_get " _
        & " @id_grupo_deporte = N'" & sql.ft_Secure_SQL(id_grupo_deporte) & "'"
        tbl_grupos_pendientes_consulta.sub_llenar_tabla()

    End Sub

End Class
