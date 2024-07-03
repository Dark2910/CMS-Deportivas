Imports Microsoft.VisualBasic

Public Class class_fotos_deporte

    Public id_fdeporte_deporte As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_fotos_deporte_consulta As New class_llenar_tabla

    Public Sub sub_fotos_deporte_consulta()
        conexion.sub_set_Conexion()
        tbl_fotos_deporte_consulta.cadena_conexion = conexion.db_cadena
        tbl_fotos_deporte_consulta.sqltext = "sp_fotos_deporte_get " _
        & " @id_fdeporte_deporte = N'" & sql.ft_Secure_SQL(id_fdeporte_deporte) & "'"
        tbl_fotos_deporte_consulta.sub_llenar_tabla()

    End Sub
End Class
