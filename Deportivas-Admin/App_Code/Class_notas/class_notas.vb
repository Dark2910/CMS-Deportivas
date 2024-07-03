Imports Microsoft.VisualBasic

Public Class class_notas

    Public id_nota_deporte As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_notas_consulta As New class_llenar_tabla

    Public Sub sub_notas_consulta()
        conexion.sub_set_Conexion()
        tbl_notas_consulta.cadena_conexion = conexion.db_cadena
        tbl_notas_consulta.sqltext = "sp_notas_get " _
        & " @id_nota_deporte = N'" & sql.ft_Secure_SQL(id_nota_deporte) & "'"
        tbl_notas_consulta.sub_llenar_tabla()

    End Sub
End Class
