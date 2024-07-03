Imports Microsoft.VisualBasic

Public Class class_turnos

    Public tbl_turnos_consulta As New class_llenar_tabla

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public Sub sub_turnos_consulta()

        conexion.sub_set_Conexion()
        tbl_turnos_consulta.cadena_conexion = conexion.db_cadena
        tbl_turnos_consulta.sqltext = "sp_turnos_get "
        tbl_turnos_consulta.sub_llenar_tabla()

    End Sub

End Class
