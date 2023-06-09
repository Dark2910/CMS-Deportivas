Imports Microsoft.VisualBasic

Public Class class_usuario

    Public Id_Usuario As String
    Public Usuario As String
    Public Password As String
    Public Cargo As String
    Public Nombre As String
    Public Apellido_Paterno As String
    Public Apellido_Materno As String
    Public Activo As Boolean
    Public Resultado As String
    Public Mensaje As String

    Dim tbl_usuario_valida As New class_llenar_tabla
    Dim tbl_usuario_consulta As New class_llenar_tabla
    Dim conexion As New class_conexion
    Dim sql As New class_sql

    Public Sub sub_propiedades_login_limpiar()

        Usuario = ""
        Password = ""

    End Sub

    Public Sub sub_usuario_valida()

        conexion.sub_set_Conexion()
        tbl_usuario_valida.cadena_conexion = conexion.db_cadena
        tbl_usuario_valida.sqltext = "sp_administradores_valida " & _
        "@usuario='" & sql.ft_Secure_SQL(Usuario) & "', " & _
        "@password='" & sql.ft_Secure_SQL(Password) & "'"
        tbl_usuario_valida.sub_llenar_tabla()
        If tbl_usuario_valida.tabla_llena.Rows(0)("Resultado").ToString() = "1" Then
            Resultado = tbl_usuario_valida.tabla_llena.Rows(0)("Resultado").ToString()
            Id_Usuario = tbl_usuario_valida.tabla_llena.Rows(0)("Mensaje").ToString()
        Else
            Resultado = tbl_usuario_valida.tabla_llena.Rows(0)("Resultado").ToString()
            Mensaje = tbl_usuario_valida.tabla_llena.Rows(0)("Mensaje").ToString()

        End If
    End Sub

    Public Sub sub_usuario_consulta()

        conexion.sub_set_Conexion()
        tbl_usuario_consulta.cadena_conexion = conexion.db_cadena
        tbl_usuario_consulta.sqltext = "sp_administradores_consulta " & _
        "@id_usuario='" & sql.ft_Secure_SQL(Id_Usuario) & "'"
        tbl_usuario_consulta.sub_llenar_tabla()
        If tbl_usuario_consulta.tabla_llena.Rows.Count > 0 Then
            Id_Usuario = tbl_usuario_consulta.tabla_llena.Rows(0)("id_usuario").ToString()
            Nombre = tbl_usuario_consulta.tabla_llena.Rows(0)("nombre").ToString()
            Apellido_Paterno = tbl_usuario_consulta.tabla_llena.Rows(0)("apellido_paterno").ToString()
            Apellido_Materno = tbl_usuario_consulta.tabla_llena.Rows(0)("apellido_materno").ToString()
            Cargo = tbl_usuario_consulta.tabla_llena.Rows(0)("cargo").ToString()

        End If
    End Sub

End Class