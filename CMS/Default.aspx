<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Src="controls/wuc_deportes.ascx" TagName="wuc_deportes" TagPrefix="uc4" %>
<%@ Register Src="controls/wuc_carreras.ascx" TagName="wuc_carreras" TagPrefix="uc3" %>
<%@ Register Src="controls/wuc_turnos.ascx" TagName="wuc_turnos" TagPrefix="uc2" %>
<%@ Register Src="controls/wuc_generos.ascx" TagName="wuc_generos" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Label ID="Label1" runat="server" Text="Fecha evento: "></asp:Label>
        <asp:Label ID="lbl_fecha_evento" runat="server"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtFechaEvento" runat="server" ReadOnly="True"></asp:TextBox><br />
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div>
    </form>
</body>
</html>
