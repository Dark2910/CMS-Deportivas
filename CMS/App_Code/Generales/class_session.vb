Imports Microsoft.VisualBasic

Public Class class_session

    Public cadena As Boolean

    Public Function ft_valida_session(ByVal id_session As String, Optional ByVal ver_session As Boolean = False) As Boolean

        Dim id As String

        id = id_session

        If id = "" Then
            Return False
            Exit Function
        End If

        If cadena = False Then
            If IsNumeric(id) = False Then
                Return False
                Exit Function
            Else
                If CDbl(id) <= 0 Then
                    Return False
                    Exit Function
                End If
            End If
        End If
        Return True
    End Function

End Class