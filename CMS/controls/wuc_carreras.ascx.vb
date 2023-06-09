
Partial Class controls_wuc_carreras
    Inherits System.Web.UI.UserControl

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_cargar_carreras()

    End Sub

    Protected Sub sub_cargar_carreras()
        principal.obj_carreras.sub_carreras_consulta()

        Me.DropDownList_carreras.DataValueField = "id_carrera"
        Me.DropDownList_carreras.DataTextField = "carrera_nombre"

        Me.DropDownList_carreras.DataSource = principal.obj_carreras.tbl_carreras_consulta.tabla_llena
        Me.DropDownList_carreras.DataBind()

    End Sub

    Public Function ftn_valor_seleccionado() As String
        Return Me.DropDownList_carreras.SelectedValue

    End Function
End Class
