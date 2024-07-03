Imports Microsoft.VisualBasic

Public Class class_fotos_calendario

    Public id_fcalendario_calendario As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_fotos_calendario_consulta As New class_llenar_tabla

    Public Sub sub_fotos_calendario_consulta()
        conexion.sub_set_Conexion()
        tbl_fotos_calendario_consulta.cadena_conexion = conexion.db_cadena
        tbl_fotos_calendario_consulta.sqltext = "sp_fotos_calendario_get " _
        & " @id_fcalendario_calendario = N'" & sql.ft_Secure_SQL(id_fcalendario_calendario) & "'"
        tbl_fotos_calendario_consulta.sub_llenar_tabla()

    End Sub
End Class
