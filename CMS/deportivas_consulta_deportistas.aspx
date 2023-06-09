<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_consulta_deportistas.aspx.vb" Inherits="Default2" title="Untitled Page" %>

<%@ Register Src="controls/wuc_generos.ascx" TagName="wuc_generos" TagPrefix="uc3" %>
<%@ Register Src="controls/wuc_carreras.ascx" TagName="wuc_carreras" TagPrefix="uc4" %>
<%@ Register Src="controls/wuc_login_session.ascx" TagName="wuc_login_session" TagPrefix="uc1" %>
<%@ Register Src="controls/wuc_validate_session.ascx" TagName="wuc_validate_session" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="navabar">
    <div>
        <h2 style="line-height: 50px;">Actividades deportivas</h2>
    </div>
    <nav>
        <uc1:wuc_login_session ID="Wuc_login_session1" runat="server" />
        <uc2:wuc_validate_session ID="Wuc_validate_session1" runat="server" />
    </nav>
</div>

<main class="main">
    <section class="main-content container">        
        <h2>deportistas</h2><hr/>
        <br/>
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_deportistas" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                    BorderWidth="1px" CellPadding="4" CssClass="table tbl-hover" ForeColor="Black" GridLines="Horizontal">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
                
    </section>
</main>

<section class="section">
  <div class="section-content container">
    <h2>Alta deportista</h2><hr/>
    <br/>
    <div class="section-forms">
      <form action="">
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblDeportistaNombre" runat="server" Text="Nombre" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtDeportistaNombre" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdDeportistaNombre" runat="server" ErrorMessage="*Ingrese un nombre"
              ControlToValidate="txtDeportistaNombre" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblDeportistaApaterno" runat="server" Text="Apellido Paterno" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtDeportistaApaterno" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdDeportistaApaterno" runat="server" ErrorMessage="*Ingrese un apellido paterno"
              ControlToValidate="txtDeportistaApaterno" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblDeportistaAmaterno" runat="server" Text="Apellido Materno" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtDeportistaAmaterno" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdDeportistaAmaterno" runat="server" ErrorMessage="*Ingrese un apellido materno"
              ControlToValidate="txtDeportistaAmaterno" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblMatricula" runat="server" Text="Matricula" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtDeportistaMatricula" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdDeportistaMatricula" runat="server" ErrorMessage="*Ingrese matricula"
              ControlToValidate="txtDeportistaMatricula" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <div class="input-group mb-5">
          <div class="input-group-prepend">
            <asp:Label ID="lblGenero" runat="server" Text="Genero" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <uc3:wuc_generos ID="Wuc_generos1" runat="server" />
        </div>
        <div class="input-group mb-5">
          <div class="input-group-prepend">
            <asp:Label ID="lblCarreras" runat="server" Text="Carreras" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
            <uc4:wuc_carreras ID="Wuc_carreras1" runat="server" />
        </div>  
        <button type="submit" id="btn_alta_deportista" class="btn btn-success btn-block" runat="server"
          validationgroup="1">AGREGAR DEPORTISTA</button>
      </form>

    </div>
  </div>
</section><br />

</asp:Content>

