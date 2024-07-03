
Partial Class controls_wuc_generos
    Inherits System.Web.UI.UserControl

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_cargar_generos()

    End Sub

    Protected Sub sub_cargar_generos()
        principal.obj_generos.sub_generos_consulta()

        Me.DropDownList_generos.DataValueField = "id_genero"
        Me.DropDownList_generos.DataTextField = "genero_nombre"

        Me.DropDownList_generos.DataSource = principal.obj_generos.tbl_generos_consulta.tabla_llena
        Me.DropDownList_generos.DataBind()

    End Sub

    Public Function ftn_valor_seleccionado() As String
        Return Me.DropDownList_generos.SelectedValue

    End Function
End Class
