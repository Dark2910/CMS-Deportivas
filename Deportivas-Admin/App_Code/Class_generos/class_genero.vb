Imports Microsoft.VisualBasic

Public Class class_genero

    Public id_genero As String = Nothing
    Public genero_nombre As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_genero_consulta As New class_llenar_tabla
    Public tbl_genero_inserta As New class_llenar_tabla
    Public tbl_genero_modifica As New class_llenar_tabla
    Public tbl_genero_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_tbl_genero_consulta()
        conexion.sub_set_Conexion()
        tbl_genero_consulta.cadena_conexion = conexion.db_cadena
        tbl_genero_consulta.sqltext = "sp_genero_get " _
        & " @id_genero = N'" & sql.ft_Secure_SQL(id_genero) & "'"
        tbl_genero_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_genero_consulta.tabla_llena.Rows.Count > 0 Then

            id_genero = tbl_genero_consulta.tabla_llena.Rows(0)("id_genero").ToString
            genero_nombre = tbl_genero_consulta.tabla_llena.Rows(0)("genero_nombre").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_tbl_genero_inserta()
        conexion.sub_set_Conexion()
        tbl_genero_inserta.cadena_conexion = conexion.db_cadena
        tbl_genero_inserta.sqltext = "sp_genero_post " _
        & " @genero_nombre = N'" & sql.ft_Secure_SQL(genero_nombre) & "'"
        tbl_genero_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_tbl_genero_modifica()
        conexion.sub_set_Conexion()
        tbl_genero_modifica.cadena_conexion = conexion.db_cadena
        tbl_genero_modifica.sqltext = "sp_genero_update " _
        & " @id_genero = N'" & sql.ft_Secure_SQL(id_genero) & "'," _
        & " @genero_nombre = N'" & sql.ft_Secure_SQL(id_genero) & "'"
        tbl_genero_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_tbl_genero_elimina()
        conexion.sub_set_Conexion()
        tbl_genero_elimina.cadena_conexion = conexion.db_cadena
        tbl_genero_elimina.sqltext = "sp_genero_drop " _
        & " @id_genero = N'" & sql.ft_Secure_SQL(id_genero) & "'"
        tbl_genero_elimina.sub_llenar_tabla()

    End Sub
End Class
