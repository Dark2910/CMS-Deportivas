Imports Microsoft.VisualBasic

Public Class class_coaches

    Public id_coach_deporte As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_coaches_consulta As New class_llenar_tabla

    Public Sub sub_coaches_consulta()
        conexion.sub_set_Conexion()
        tbl_coaches_consulta.cadena_conexion = conexion.db_cadena
        tbl_coaches_consulta.sqltext = "sp_coaches_get " _
        & " @id_coach_deporte = " & sql.ft_Secure_SQL(id_coach_deporte)
        tbl_coaches_consulta.sub_llenar_tabla()

    End Sub
End Class
