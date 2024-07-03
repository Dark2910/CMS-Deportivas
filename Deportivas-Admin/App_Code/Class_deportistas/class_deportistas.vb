Imports Microsoft.VisualBasic

Public Class class_deportistas

    Public id_grupo As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_deportistas_consulta As New class_llenar_tabla

    Public Sub sub_deportistas_consulta()
        conexion.sub_set_Conexion()
        tbl_deportistas_consulta.cadena_conexion = conexion.db_cadena
        tbl_deportistas_consulta.sqltext = "sp_deportistas_get " _
        & " @id_grupo = N'" & sql.ft_Secure_SQL(id_grupo) & "'"
        tbl_deportistas_consulta.sub_llenar_tabla()

    End Sub

End Class
