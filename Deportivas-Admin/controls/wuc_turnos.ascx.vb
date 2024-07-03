
Partial Class controls_wuc_turnos
    Inherits System.Web.UI.UserControl

    Dim principal As New class_principal

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        sub_cargar_turnos()
    End Sub

    Protected Sub sub_cargar_turnos()
        principal.obj_turnos.sub_turnos_consulta()

        Me.DropDownList_turnos.DataValueField = "id_turno"
        Me.DropDownList_turnos.DataTextField = "turno_nombre"

        Me.DropDownList_turnos.DataSource = principal.obj_turnos.tbl_turnos_consulta.tabla_llena
        Me.DropDownList_turnos.DataBind()

    End Sub


    Public Function ftn_valor_seleccionado() As String
        Return Me.DropDownList_turnos.SelectedValue

    End Function


End Class
