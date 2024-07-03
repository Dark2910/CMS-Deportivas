
Partial Class controls_wuc_deportes
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_cargar_deportes()

    End Sub

    Protected Sub sub_cargar_deportes()
        Dim principal As New class_principal
        principal.obj_deportes.sub_deportes_consulta()

        Me.DropDownList_deportes.DataValueField = "id_deporte"
        Me.DropDownList_deportes.DataTextField = "deporte_nombre"

        Me.DropDownList_deportes.DataSource = principal.obj_deportes.tbl_deportes_consulta.tabla_llena
        Me.DropDownList_deportes.DataBind()

    End Sub

    Public Function ftn_valor_seleccionado() As String
        Return Me.DropDownList_deportes.SelectedValue

    End Function

End Class
