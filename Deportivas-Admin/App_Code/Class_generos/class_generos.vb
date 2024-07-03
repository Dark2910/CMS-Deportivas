Imports Microsoft.VisualBasic

Public Class class_generos

    Dim conexion As New class_conexion

    Public tbl_generos_consulta As New class_llenar_tabla

    Public Sub sub_generos_consulta()
        conexion.sub_set_Conexion()
        tbl_generos_consulta.cadena_conexion = conexion.db_cadena
        tbl_generos_consulta.sqltext = "sp_generos_get"
        tbl_generos_consulta.sub_llenar_tabla()

    End Sub
End Class
