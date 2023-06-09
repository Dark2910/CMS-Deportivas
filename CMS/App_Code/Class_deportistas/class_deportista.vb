Imports Microsoft.VisualBasic

Public Class class_deportista

    Public id_deportista As String = Nothing
    Public deportista_nombre As String = Nothing
    Public deportista_apaterno As String = Nothing
    Public deportista_amaterno As String = Nothing
    Public deportista_matricula As String = Nothing
    Public id_deportista_genero As String = Nothing
    Public id_deportista_carrera As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_deportista_consulta As New class_llenar_tabla
    Public tbl_deportista_inserta As New class_llenar_tabla
    Public tbl_deportista_modifica As New class_llenar_tabla
    Public tbl_deportista_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_deportista_consulta()
        conexion.sub_set_Conexion()
        tbl_deportista_consulta.cadena_conexion = conexion.db_cadena
        tbl_deportista_consulta.sqltext = "sp_deportista_get " _
        & " @id_deportista = N'" & sql.ft_Secure_SQL(id_deportista) & "'"
        tbl_deportista_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_deportista_consulta.tabla_llena.Rows.Count > 0 Then

            id_deportista = tbl_deportista_consulta.tabla_llena.Rows(0)("id_deportista").ToString
            deportista_nombre = tbl_deportista_consulta.tabla_llena.Rows(0)("deportista_nombre").ToString
            deportista_apaterno = tbl_deportista_consulta.tabla_llena.Rows(0)("deportista_apaterno").ToString
            deportista_amaterno = tbl_deportista_consulta.tabla_llena.Rows(0)("deportista_amaterno").ToString
            deportista_matricula = tbl_deportista_consulta.tabla_llena.Rows(0)("deportista_matricula").ToString
            id_deportista_genero = tbl_deportista_consulta.tabla_llena.Rows(0)("id_deportista_genero").ToString
            id_deportista_carrera = tbl_deportista_consulta.tabla_llena.Rows(0)("id_deportista_carrera").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_deportista_inserta()
        conexion.sub_set_Conexion()
        tbl_deportista_inserta.cadena_conexion = conexion.db_cadena
        tbl_deportista_inserta.sqltext = "sp_deportista_post " _
        & " @deportista_nombre = N'" & sql.ft_Secure_SQL(deportista_nombre) & "'," _
        & " @deportista_apaterno = N'" & sql.ft_Secure_SQL(deportista_apaterno) & "'," _
        & " @deportista_amaterno = N'" & sql.ft_Secure_SQL(deportista_amaterno) & "'," _
        & " @deportista_matricula = N'" & sql.ft_Secure_SQL(deportista_matricula) & "'," _
        & " @id_deportista_genero = " & sql.ft_Secure_SQL(id_deportista_genero) & "," _
        & " @id_deportista_carrera = " & sql.ft_Secure_SQL(id_deportista_carrera)
        tbl_deportista_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_deportista_modifica()
        conexion.sub_set_Conexion()
        tbl_deportista_modifica.cadena_conexion = conexion.db_cadena
        tbl_deportista_modifica.sqltext = "sp_deportista_update " _
        & " @id_deportista = N'" & sql.ft_Secure_SQL(id_deportista) & "'," _
        & " @deportista_nombre = N'" & sql.ft_Secure_SQL(deportista_nombre) & "'," _
        & " @deportista_apaterno = N'" & sql.ft_Secure_SQL(deportista_apaterno) & "'," _
        & " @deportista_amaterno = N'" & sql.ft_Secure_SQL(deportista_amaterno) & "'," _
        & " @deportista_matricula = N'" & sql.ft_Secure_SQL(deportista_matricula) & "'," _
        & " @id_deportista_genero = " & sql.ft_Secure_SQL(id_deportista_genero) & "," _
        & " @id_deportista_carrera = " & sql.ft_Secure_SQL(id_deportista_carrera)
        tbl_deportista_modifica.sub_llenar_tabla()

    End Sub

    'Eliminar
    Public Sub sub_deportista_elimina()
        conexion.sub_set_Conexion()
        tbl_deportista_elimina.cadena_conexion = conexion.db_cadena
        tbl_deportista_elimina.sqltext = "sp_deportista_drop " _
        & " @id_deportista = N'" & sql.ft_Secure_SQL(id_deportista) & "'"
        tbl_deportista_elimina.sub_llenar_tabla()

    End Sub
End Class
