Imports Microsoft.VisualBasic

Public Class class_carrera

    Public id_carrera As String = Nothing
    Public carrera_nombre As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_carrera_consulta As New class_llenar_tabla
    Public tbl_carrera_inserta As New class_llenar_tabla
    Public tbl_carrera_modifica As New class_llenar_tabla
    Public tbl_carrera_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_carrera_consulta()
        conexion.sub_set_Conexion()
        tbl_carrera_consulta.cadena_conexion = conexion.db_cadena
        tbl_carrera_consulta.sqltext = "sp_carreras_get " _
        & " @id_carrera = N'" & sql.ft_Secure_SQL(id_carrera) & "'"
        tbl_carrera_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_carrera_consulta.tabla_llena.Rows.Count > 0 Then
            id_carrera = tbl_carrera_consulta.tabla_llena.Rows(0)("id_carrera").ToString
            carrera_nombre = tbl_carrera_consulta.tabla_llena.Rows(0)("carrera_nombre").ToString

            agregado = True
        End If
    End Sub

    'Inserta
    Public Sub sub_carrera_inserta()
        conexion.sub_set_Conexion()
        tbl_carrera_inserta.cadena_conexion = conexion.db_cadena
        tbl_carrera_inserta.sqltext = "sp_carrera_post " _
        & " @carrera_nombre = N'" & sql.ft_Secure_SQL(carrera_nombre) & "'"
        tbl_carrera_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_carrera_modifica()
        conexion.sub_set_Conexion()
        tbl_carrera_modifica.cadena_conexion = conexion.db_cadena
        tbl_carrera_modifica.sqltext = "sp_carrera_update " _
        & " @carrera_nombre = N'" & sql.ft_Secure_SQL(carrera_nombre) & "'"
        tbl_carrera_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_carrera_elimina()
        conexion.sub_set_Conexion()
        tbl_carrera_elimina.cadena_conexion = conexion.db_cadena
        tbl_carrera_elimina.sqltext = "sp_carrera_drop " _
        & " @id_carrera = N'" & sql.ft_Secure_SQL(id_carrera) & "'"
        tbl_carrera_elimina.sub_llenar_tabla()

    End Sub
End Class