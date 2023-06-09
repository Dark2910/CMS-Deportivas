<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_login.aspx.vb" Inherits="Default2" title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="container jumbotron">
    <!--Titulo-->
    <div class="container-fluid bg-success text-white text-center py-2 mb-5">
        <h1>INICIO DE SESIÓN</h1>
    </div>

    <!--Imagen-->
    <div class="row">
        <div class="col-sm-3">
            <img src="./assets/img/usuarios.png" alt="" class="img-fluid" />
        </div>

        <div class="col-sm-9">
            <form action="">

                <!--Textbox Usuario-->
                <div class="input-group">
                    <div class="input-group-prepend">
                        <asp:Label ID="lbl_login" runat="server" Text="Usuario" BackColor="#FFFFFF"
                            CssClass="input-group-text" Width="120px"></asp:Label>
                    </div>
                    <asp:TextBox ID="txt_login" runat="server" CssClass="form-control"></asp:TextBox>
                    <div class="input-group mb-2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="txt_login" ErrorMessage="Ingrese su nombre de usuario"
                            ValidationGroup="1"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <!--Textbox Contraseña-->
                <div class="input-group">
                    <div class="input-group-prepend">
                        <asp:Label ID="lbl_contraseña" runat="server" Text="Contraseña" BackColor="#FFFFFF"
                            CssClass="input-group-text" Width="120px"></asp:Label>
                    </div>
                    <asp:TextBox ID="txt_contraseña" runat="server" CssClass="form-control Password"
                        TextMode="Password"></asp:TextBox>
                    <div class="input-group mb-2">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="txt_contraseña" ErrorMessage="Ingrese su contraseña" ValidationGroup="1">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>

                <!--Button Iniciar Sesion-->
                <asp:Label ID="lbl_error" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                <button type="submit" id="btn_login" class="btn btn-primary btn-block" runat="server"
                    validationgroup="1">INICIAR SESIÓN</button>

            </form>
        </div>
    </div>
</div>


</asp:Content>

