Imports Microsoft.VisualBasic

Public Class class_calendarios

    Public id_calendario_deporte As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_calendarios_consulta As New class_llenar_tabla

    Public Sub sub_calendarios_consulta()
        conexion.sub_set_Conexion()
        tbl_calendarios_consulta.cadena_conexion = conexion.db_cadena
        tbl_calendarios_consulta.sqltext = "sp_calendarios_get " _
        & " @id_calendario_deporte = " & sql.ft_Secure_SQL(id_calendario_deporte)
        tbl_calendarios_consulta.sub_llenar_tabla()

    End Sub

End Class
