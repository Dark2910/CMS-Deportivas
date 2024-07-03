Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class class_llenar_tabla

    Public cadena_conexion As String
    Public sqltext As String
    Public error_datos As String
    Public tabla_llena As New DataTable

    Public Sub sub_llenar_tabla()

        Dim conexion As New SqlConnection

        Try
            tabla_llena = New DataTable
            tabla_llena.Clear()
            conexion.ConnectionString = cadena_conexion
            conexion.Open()

            Dim Adapter3 As New SqlDataAdapter(sqltext, conexion)
            Adapter3.Fill(tabla_llena)

            Adapter3 = Nothing
            conexion.Close()
            conexion = Nothing

        Catch ex As SqlException

            error_datos = ex.Message.ToString

        End Try
    End Sub

End Class