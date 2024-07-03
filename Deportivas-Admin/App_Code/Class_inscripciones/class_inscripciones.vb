Imports Microsoft.VisualBasic

Public Class class_inscripciones

    Public id_inscripcion_grupo As String = Nothing
    
    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_inscripciones_consulta As New class_llenar_tabla
    Public tbl_inscripciones_rooster_consulta As New class_llenar_tabla

    Public Sub sub_inscripciones_consulta()
        conexion.sub_set_Conexion()
        tbl_inscripciones_consulta.cadena_conexion = conexion.db_cadena
        tbl_inscripciones_consulta.sqltext = "sp_inscripciones_get " _
        & " @id_inscripcion_grupo = N'" & sql.ft_Secure_SQL(id_inscripcion_grupo) & "'"
        tbl_inscripciones_consulta.sub_llenar_tabla()

    End Sub

    Public Sub sub_inscripciones_rooster_consulta()
        conexion.sub_set_Conexion()
        tbl_inscripciones_rooster_consulta.cadena_conexion = conexion.db_cadena
        tbl_inscripciones_rooster_consulta.sqltext = "sp_inscripciones_rooster_get " _
        & " @id_inscripcion_grupo = N'" & sql.ft_Secure_SQL(id_inscripcion_grupo) & "'"
        tbl_inscripciones_rooster_consulta.sub_llenar_tabla()

    End Sub

End Class
