Imports Microsoft.VisualBasic

Public Class class_documentos_nota

    Public id_dnota_nota As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_decumentos_nota_consulta As New class_llenar_tabla

    Public Sub sub_decumentos_consulta()
        conexion.sub_set_Conexion()
        tbl_decumentos_nota_consulta.cadena_conexion = conexion.db_cadena
        tbl_decumentos_nota_consulta.sqltext = "sp_documentos_nota_get " _
        & " @id_dnota_nota = N'" & sql.ft_Secure_SQL(id_dnota_nota) & "'"
        tbl_decumentos_nota_consulta.sub_llenar_tabla()

    End Sub

End Class