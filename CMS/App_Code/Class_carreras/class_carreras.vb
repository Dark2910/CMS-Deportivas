Imports Microsoft.VisualBasic

Public Class class_carreras

    Dim conexion As New class_conexion

    Public tbl_carreras_consulta As New class_llenar_tabla

    Public Sub sub_carreras_consulta()
        conexion.sub_set_Conexion()
        tbl_carreras_consulta.cadena_conexion = conexion.db_cadena
        tbl_carreras_consulta.sqltext = "sp_carreras_get "
        tbl_carreras_consulta.sub_llenar_tabla()

    End Sub

End Class
