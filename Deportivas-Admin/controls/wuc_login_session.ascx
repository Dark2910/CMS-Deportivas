<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wuc_login_session.ascx.vb" Inherits="controls_wuc_login_session" %>

<div class="container-fluid" style="background-color: white; height: 74px;">

    <nav class="headerMenu">
        <a class="nav-link text-dark fas fa-user"></a>
        <a href="#">Usuario:</a>
        <a href="#"><asp:Label ID="lbl_usuario" runat="server" Text="Nombre"></asp:Label></a>
        <a href="#">Cerrar Sesión</a>
        <a href="#"><asp:ImageButton ID="img_cerrar_sesion" runat="server"  ImageUrl="~/assets/img/cerrarsesion.png" CausesValidation="False"/></a>
     </nav>
    
</div>