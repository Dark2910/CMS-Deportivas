Imports Microsoft.VisualBasic

Public Class class_nota

    Public id_nota As String = Nothing
    Public nota_titulo As String = Nothing
    Public nota_subtitulo As String = Nothing
    Public nota_texto As String = Nothing
    Public id_nota_deporte As String = Nothing

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_nota_consulta As New class_llenar_tabla
    Public tbl_nota_inserta As New class_llenar_tabla
    Public tbl_nota_modifica As New class_llenar_tabla
    Public tbl_nota_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_nota_consulta()
        conexion.sub_set_Conexion()
        tbl_nota_consulta.cadena_conexion = conexion.db_cadena
        tbl_nota_consulta.sqltext = "sp_nota_get " _
        & " @id_nota = N'" & sql.ft_Secure_SQL(id_nota) & "'"
        tbl_nota_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_nota_consulta.tabla_llena.Rows.Count > 0 Then

            id_nota = tbl_nota_consulta.tabla_llena.Rows(0)("id_nota").ToString
            nota_titulo = tbl_nota_consulta.tabla_llena.Rows(0)("nota_titulo").ToString
            nota_subtitulo = tbl_nota_consulta.tabla_llena.Rows(0)("nota_subtitulo").ToString
            nota_texto = tbl_nota_consulta.tabla_llena.Rows(0)("nota_texto").ToString
            id_nota_deporte = tbl_nota_consulta.tabla_llena.Rows(0)("id_nota_deporte").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_nota_inserta()
        conexion.sub_set_Conexion()
        tbl_nota_inserta.cadena_conexion = conexion.db_cadena
        tbl_nota_inserta.sqltext = "sp_nota_post " _
        & " @nota_titulo = N'" & sql.ft_Secure_SQL(nota_titulo) & "'," _
        & " @nota_subtitulo = N'" & sql.ft_Secure_SQL(nota_subtitulo) & "'," _
        & " @nota_texto = N'" & sql.ft_Secure_SQL(nota_texto) & "'," _
        & " @id_nota_deporte = " & sql.ft_Secure_SQL(id_nota_deporte)
        tbl_nota_inserta.sub_llenar_tabla()

    End Sub

    'Modifica
    Public Sub sub_nota_modifica()
        conexion.sub_set_Conexion()
        tbl_nota_modifica.cadena_conexion = conexion.db_cadena
        tbl_nota_modifica.sqltext = "sp_nota_update " _
        & " @id_nota = N'" & sql.ft_Secure_SQL(id_nota) & "'," _
        & " @nota_titulo = N'" & sql.ft_Secure_SQL(nota_titulo) & "'," _
        & " @nota_subtitulo = N'" & sql.ft_Secure_SQL(nota_subtitulo) & "'," _
        & " @nota_texto = N'" & sql.ft_Secure_SQL(nota_texto) & "'," _
        & " @id_nota_deporte = " & sql.ft_Secure_SQL(id_nota_deporte)
        tbl_nota_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_nota_elimina()
        conexion.sub_set_Conexion()
        tbl_nota_elimina.cadena_conexion = conexion.db_cadena
        tbl_nota_elimina.sqltext = "sp_nota_drop " _
        & " @id_nota = N'" & sql.ft_Secure_SQL(id_nota) & "'"
        tbl_nota_elimina.sub_llenar_tabla()

    End Sub
End Class
