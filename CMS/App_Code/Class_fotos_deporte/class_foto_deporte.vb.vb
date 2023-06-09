Imports Microsoft.VisualBasic

Public Class class_foto_deporte

    Public extension As String = Nothing
    Public tipo_archivo As String = Nothing

    Public id_fdeporte As String = Nothing
    Public fdeporte_nombre As String = Nothing
    Public fdeporte_descripcion As String = Nothing
    Public id_fdeporte_deporte As String = Nothing

    Public msg As String
    Public codigo As String
    Public ruta_virtual As String
    Public ruta_fisica As String

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_foto_deporte_consulta As New class_llenar_tabla
    Public tbl_foto_deporte_inserta As New class_llenar_tabla
    Public tbl_foto_deporte_modifica As New class_llenar_tabla
    Public tbl_foto_deporte_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_foto_deporte_consulta()
        conexion.sub_set_Conexion()
        tbl_foto_deporte_consulta.cadena_conexion = conexion.db_cadena
        tbl_foto_deporte_consulta.sqltext = "sp_foto_deporte_get " _
        & " @id_fdeporte = N'" & sql.ft_Secure_SQL(id_fdeporte) & "'"
        tbl_foto_deporte_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_foto_deporte_consulta.tabla_llena.Rows.Count > 0 Then

            id_fdeporte = tbl_foto_deporte_consulta.tabla_llena.Rows(0)("id_fdeporte").ToString
            fdeporte_nombre = tbl_foto_deporte_consulta.tabla_llena.Rows(0)("fdeporte_nombre").ToString
            fdeporte_descripcion = tbl_foto_deporte_consulta.tabla_llena.Rows(0)("fdeporte_descripcion").ToString
            id_fdeporte_deporte = tbl_foto_deporte_consulta.tabla_llena.Rows(0)("id_fdeporte_deporte").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_foto_deporte_inserta()
        conexion.sub_set_Conexion()
        tbl_foto_deporte_inserta.cadena_conexion = conexion.db_cadena
        tbl_foto_deporte_inserta.sqltext = "sp_foto_deporte_post " _
        & " @extension = N'" & sql.ft_Secure_SQL(extension) & "'," _
        & " @tipo_archivo = N'" & sql.ft_Secure_SQL(tipo_archivo) & "'," _
        & " @fdeporte_nombre = N'" & sql.ft_Secure_SQL(fdeporte_nombre) & "'," _
        & " @fdeporte_descripcion = N'" & sql.ft_Secure_SQL(fdeporte_descripcion) & "'," _
        & " @id_fdeporte_deporte = " & sql.ft_Secure_SQL(id_fdeporte_deporte)
        tbl_foto_deporte_inserta.sub_llenar_tabla()

        If tbl_foto_deporte_inserta.tabla_llena.Rows.Count > 0 Then
            msg = tbl_foto_deporte_inserta.tabla_llena.Rows(0)("msg").ToString
            codigo = tbl_foto_deporte_inserta.tabla_llena.Rows(0)("codigo").ToString

            If tbl_foto_deporte_inserta.tabla_llena.Columns.Count > 2 Then
                ruta_fisica = tbl_foto_deporte_inserta.tabla_llena.Rows(0)("ruta_fisica").ToString
                ruta_virtual = tbl_foto_deporte_inserta.tabla_llena.Rows(0)("ruta_virtual").ToString

            End If
        Else
            msg = "No se encontro registro en la BD´s"
            'codigo = tbl_foto_deporte_inserta.tabla_llena.Rows(0)("codigo").ToString
        End If

    End Sub

    'Modifica
    Public Sub sub_foto_deporte_modifica()
        conexion.sub_set_Conexion()
        tbl_foto_deporte_modifica.cadena_conexion = conexion.db_cadena
        tbl_foto_deporte_modifica.sqltext = "sp_foto_deporte_update " _
        & " @id_fdeporte = N'" & sql.ft_Secure_SQL(id_fdeporte) & "'," _
        & " @fdeporte_nombre = N'" & sql.ft_Secure_SQL(fdeporte_nombre) & "'," _
        & " @fdeporte_descripcion = N'" & sql.ft_Secure_SQL(fdeporte_descripcion) & "'," _
        & " @id_fdeporte_deporte = " & sql.ft_Secure_SQL(id_fdeporte_deporte)
        tbl_foto_deporte_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_foto_deporte_elimina()
        conexion.sub_set_Conexion()
        tbl_foto_deporte_elimina.cadena_conexion = conexion.db_cadena
        tbl_foto_deporte_elimina.sqltext = "sp_foto_deporte_drop " _
        & " @id_fdeporte = N'" & sql.ft_Secure_SQL(id_fdeporte) & "'"
        tbl_foto_deporte_elimina.sub_llenar_tabla()

    End Sub
End Class
