Imports Microsoft.VisualBasic

Public Class class_sql

    Function ft_Secure_SQL(ByVal strVar)

        Dim final, i
        Dim banned() As String = {"select", "update", "drop", ";", "--", "insert", "delete", "xp_", "<scrip>", "</scrip>", "'"}
        For i = 0 To UBound(banned)
            strVar = Replace(strVar, banned(i), "")
        Next
        final = Replace(strVar, "'", "")
        final = Replace(strVar, "'", "")
        final = Replace(strVar, "'", "")

        Return final
    End Function

End Class