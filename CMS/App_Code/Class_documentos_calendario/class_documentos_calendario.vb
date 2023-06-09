Imports Microsoft.VisualBasic

Public Class class_documentos_calendario

    Public id_dcalendario_calendario As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_decumentos_calendario_consulta As New class_llenar_tabla

    Public Sub sub_decumentos_calendario_consulta()
        conexion.sub_set_Conexion()
        tbl_decumentos_calendario_consulta.cadena_conexion = conexion.db_cadena
        tbl_decumentos_calendario_consulta.sqltext = "sp_documentos_calendario_get " _
        & " @id_dcalendario_calendario = N'" & sql.ft_Secure_SQL(id_dcalendario_calendario) & "'"
        tbl_decumentos_calendario_consulta.sub_llenar_tabla()

    End Sub

End Class
