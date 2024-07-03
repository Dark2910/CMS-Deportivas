Imports Microsoft.VisualBasic

Public Class class_foto_calendario

    Public extension As String = Nothing
    Public tipo_archivo As String = Nothing

    Public id_fcalendario As String = Nothing
    Public fcalendario_nombre As String = Nothing
    Public fcalendario_descripcion As String = Nothing
    Public id_fcalendario_calendario As String = Nothing

    Public msg As String
    Public codigo As String
    Public ruta_virtual As String
    Public ruta_fisica As String

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_foto_calendario_consulta As New class_llenar_tabla
    Public tbl_foto_calendario_inserta As New class_llenar_tabla
    Public tbl_foto_calendario_modifica As New class_llenar_tabla
    Public tbl_foto_calendario_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_foto_calendario_consulta()
        conexion.sub_set_Conexion()
        tbl_foto_calendario_consulta.cadena_conexion = conexion.db_cadena
        tbl_foto_calendario_consulta.sqltext = "sp_foto_calendario_get " _
        & " @id_fcalendario = N'" & sql.ft_Secure_SQL(id_fcalendario) & "'"
        tbl_foto_calendario_consulta.sub_llenar_tabla()

        agregado = False

        If (tbl_foto_calendario_consulta.tabla_llena.Rows.Count > 0) Then
            id_fcalendario = tbl_foto_calendario_consulta.tabla_llena.Rows(0)("id_fcalendario").ToString
            fcalendario_nombre = tbl_foto_calendario_consulta.tabla_llena.Rows(0)("fcalendario_nombre").ToString
            fcalendario_descripcion = tbl_foto_calendario_consulta.tabla_llena.Rows(0)("fcalendario_descripcion").ToString
            id_fcalendario_calendario = tbl_foto_calendario_consulta.tabla_llena.Rows(0)("id_fcalendario_calendario").ToString

            agregado = True

        End If

    End Sub

    'Inserta
    Public Sub sub_foto_calendario_inserta()
        conexion.sub_set_Conexion()
        tbl_foto_calendario_inserta.cadena_conexion = conexion.db_cadena
        tbl_foto_calendario_inserta.sqltext = "sp_foto_calendario_post " _
        & " @extension = N'" & sql.ft_Secure_SQL(extension) & "'," _
        & " @tipo_archivo = N'" & sql.ft_Secure_SQL(tipo_archivo) & "'," _
        & " @fcalendario_nombre = N'" & sql.ft_Secure_SQL(fcalendario_nombre) & "'," _
        & " @fcalendario_descripcion = N'" & sql.ft_Secure_SQL(fcalendario_descripcion) & "'," _
        & " @id_fcalendario_calendario = " & sql.ft_Secure_SQL(id_fcalendario_calendario)
        tbl_foto_calendario_inserta.sub_llenar_tabla()

        If tbl_foto_calendario_inserta.tabla_llena.Rows.Count > 0 Then
            msg = tbl_foto_calendario_inserta.tabla_llena.Rows(0)("msg").ToString
            codigo = tbl_foto_calendario_inserta.tabla_llena.Rows(0)("codigo").ToString

            If tbl_foto_calendario_inserta.tabla_llena.Columns.Count > 2 Then
                ruta_fisica = tbl_foto_calendario_inserta.tabla_llena.Rows(0)("ruta_fisica").ToString
                ruta_virtual = tbl_foto_calendario_inserta.tabla_llena.Rows(0)("ruta_virtual").ToString

            End If
        Else
            msg = "No se encontro registro en la BD´s"
            'codigo = tbl_foto_calendario_inserta.tabla_llena.Rows(0)("codigo").ToString
        End If


    End Sub

    'Modifica
    Public Sub sub_foto_calendario_modifica()
        conexion.sub_set_Conexion()
        tbl_foto_calendario_modifica.cadena_conexion = conexion.db_cadena
        tbl_foto_calendario_modifica.sqltext = "sp_foto_calendario_update " _
        & " @id_fcalendario = N'" & sql.ft_Secure_SQL(id_fcalendario) & "'," _
        & " @fcalendario_nombre = N'" & sql.ft_Secure_SQL(fcalendario_nombre) & "'," _
        & " @fcalendario_descripcion = N'" & sql.ft_Secure_SQL(fcalendario_descripcion) & "'," _
        & " @id_fcalendario_calendario = " & sql.ft_Secure_SQL(id_fcalendario_calendario)
        tbl_foto_calendario_modifica.sub_llenar_tabla()

    End Sub

    'Eliminar
    Public Sub sub_foto_calendario_elimina()
        conexion.sub_set_Conexion()
        tbl_foto_calendario_elimina.cadena_conexion = conexion.db_cadena
        tbl_foto_calendario_elimina.sqltext = "sp_foto_calendario_drop " _
        & " @id_fcalendario = N'" & sql.ft_Secure_SQL(id_fcalendario) & "'"
        tbl_foto_calendario_elimina.sub_llenar_tabla()

    End Sub

End Class
