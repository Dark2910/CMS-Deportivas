
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        Me.lbl_fecha_evento.Text = Me.Calendar1.SelectedDate.Year & "-" & Me.Calendar1.SelectedDate.Month & "-" & Me.Calendar1.SelectedDate.Day
        Me.txtFechaEvento.Text = Me.Calendar1.SelectedDate.Year & "-" & Me.Calendar1.SelectedDate.Month & "-" & Me.Calendar1.SelectedDate.Day
    End Sub
End Class
