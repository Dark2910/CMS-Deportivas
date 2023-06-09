Imports Microsoft.VisualBasic

Public Class class_deportes

    Dim conexion As New class_conexion

    Public tbl_deportes_consulta As New class_llenar_tabla

    Public Sub sub_deportes_consulta()
        conexion.sub_set_Conexion()
        tbl_deportes_consulta.cadena_conexion = conexion.db_cadena
        tbl_deportes_consulta.sqltext = "sp_deportes_get "
        tbl_deportes_consulta.sub_llenar_tabla()

    End Sub

End Class
