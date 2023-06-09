Imports Microsoft.VisualBasic

Public Class class_fotos_nota

    Public id_fnota_nota As String = Nothing

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_fotos_nota_consulta As New class_llenar_tabla

    Public Sub sub_fotos_nota_consulta()
        conexion.sub_set_Conexion()
        tbl_fotos_nota_consulta.cadena_conexion = conexion.db_cadena
        tbl_fotos_nota_consulta.sqltext = "sp_fotos_nota_get " _
        & " @id_fnota_nota = N'" & sql.ft_Secure_SQL(id_fnota_nota) & "'"
        tbl_fotos_nota_consulta.sub_llenar_tabla()

    End Sub
End Class
