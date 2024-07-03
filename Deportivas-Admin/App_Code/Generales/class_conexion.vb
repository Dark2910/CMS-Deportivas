Imports Microsoft.VisualBasic

Public Class class_conexion
    Public db_usuario As String
    Public db_password As String
    Public db_server As String
    Public db_base As String
    Public db_cadena As String

    Sub sub_set_Conexion()
        db_usuario = "sa"
        db_password = "<Eiae001029>"
        db_server = "127.0.0.1"
        db_base = "Deportivas_TEST"

        db_cadena = "server=" & db_server & "; Persist Security Info=false; database=" & db_base & ";uid=" & db_usuario & ";pwd=" & db_password & ";"

    End Sub

End Class