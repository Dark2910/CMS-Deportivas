Imports Microsoft.VisualBasic

Public Class class_documento_nota

    Public extension As String = Nothing
    Public tipo_archivo As String = Nothing

    Public id_dnota As String = Nothing
    Public dnota_nombre As String = Nothing
    Public dnota_descripcion As String = Nothing
    Public id_dnota_nota As String = Nothing

    Public msg As String
    Public codigo As String
    Public ruta_virtual As String
    Public ruta_fisica As String

    Public agregado As Boolean

    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public tbl_decumento_nota_consulta As New class_llenar_tabla
    Public tbl_decumento_nota_inserta As New class_llenar_tabla
    Public tbl_decumento_nota_modifica As New class_llenar_tabla
    Public tbl_decumento_nota_elimina As New class_llenar_tabla

    'Consulta
    Public Sub sub_decumento_nota_consulta()
        conexion.sub_set_Conexion()
        tbl_decumento_nota_consulta.cadena_conexion = conexion.db_cadena
        tbl_decumento_nota_consulta.sqltext = "sp_documento_nota_get " _
        & " @id_dnota = N'" & sql.ft_Secure_SQL(id_dnota) & "'"
        tbl_decumento_nota_consulta.sub_llenar_tabla()

        agregado = False

        If tbl_decumento_nota_consulta.tabla_llena.Rows.Count > 0 Then

            id_dnota = tbl_decumento_nota_consulta.tabla_llena.Rows(0)("id_dnota").ToString
            dnota_nombre = tbl_decumento_nota_consulta.tabla_llena.Rows(0)("dnota_nombre").ToString
            dnota_descripcion = tbl_decumento_nota_consulta.tabla_llena.Rows(0)("dnota_descripcion").ToString
            id_dnota_nota = tbl_decumento_nota_consulta.tabla_llena.Rows(0)("id_dnota_nota").ToString

            agregado = True

        End If
    End Sub

    'Inserta
    Public Sub sub_decumento_nota_inserta()
        conexion.sub_set_Conexion()
        tbl_decumento_nota_inserta.cadena_conexion = conexion.db_cadena
        tbl_decumento_nota_inserta.sqltext = "sp_documento_nota_post " _
        & " @extension = N'" & sql.ft_Secure_SQL(extension) & "'," _
        & " @tipo_archivo = N'" & sql.ft_Secure_SQL(tipo_archivo) & "'," _
        & " @dnota_nombre = N'" & sql.ft_Secure_SQL(dnota_nombre) & "'," _
        & " @dnota_descripcion = N'" & sql.ft_Secure_SQL(dnota_descripcion) & "'," _
        & " @id_dnota_nota = " & sql.ft_Secure_SQL(id_dnota_nota)
        tbl_decumento_nota_inserta.sub_llenar_tabla()

        If tbl_decumento_nota_inserta.tabla_llena.Rows.Count > 0 Then
            msg = tbl_decumento_nota_inserta.tabla_llena.Rows(0)("msg").ToString
            codigo = tbl_decumento_nota_inserta.tabla_llena.Rows(0)("codigo").ToString

            If tbl_decumento_nota_inserta.tabla_llena.Columns.Count > 2 Then
                ruta_fisica = tbl_decumento_nota_inserta.tabla_llena.Rows(0)("ruta_fisica").ToString
                ruta_virtual = tbl_decumento_nota_inserta.tabla_llena.Rows(0)("ruta_virtual").ToString

            End If
        Else
            msg = "No se encontro registro en la BD´s"
            'codigo = tbl_decumento_nota_inserta.tabla_llena.Rows(0)("codigo").ToString
        End If

    End Sub

    'Modifica
    Public Sub sub_decumento_nota_modifica()
        conexion.sub_set_Conexion()
        tbl_decumento_nota_modifica.cadena_conexion = conexion.db_cadena
        tbl_decumento_nota_modifica.sqltext = "sp_documento_nota_update " _
        & " @id_dnota = N'" & sql.ft_Secure_SQL(id_dnota) & "'," _
        & " @dnota_nombre = N'" & sql.ft_Secure_SQL(dnota_nombre) & "'," _
        & " @dnota_descripcion = N'" & sql.ft_Secure_SQL(dnota_descripcion) & "'," _
        & " @id_dnota_nota = " & sql.ft_Secure_SQL(id_dnota_nota)
        tbl_decumento_nota_modifica.sub_llenar_tabla()

    End Sub

    'Elimina
    Public Sub sub_decumento_nota_elimina()
        conexion.sub_set_Conexion()
        tbl_decumento_nota_elimina.cadena_conexion = conexion.db_cadena
        tbl_decumento_nota_elimina.sqltext = "sp_documento_nota_drop " _
        & " @id_dnota = N'" & sql.ft_Secure_SQL(id_dnota) & "'"
        tbl_decumento_nota_elimina.sub_llenar_tabla()

    End Sub
End Class
