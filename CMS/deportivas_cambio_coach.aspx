<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_cambio_coach.aspx.vb" Inherits="Default2" title="Untitled Page" %>

<%@ Register Src="controls/wuc_turnos.ascx" TagName="wuc_turnos" TagPrefix="uc4" %>
<%@ Register Src="controls/wuc_generos.ascx" TagName="wuc_generos" TagPrefix="uc3" %>
<%@ Register Src="controls/wuc_deportes.ascx" TagName="wuc_deportes" TagPrefix="uc5" %>
<%@ Register Src="controls/wuc_login_session.ascx" TagName="wuc_login_session" TagPrefix="uc1" %>
<%@ Register Src="controls/wuc_validate_session.ascx" TagName="wuc_validate_session" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="navabar"> <!-- stikyContainer -->
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
        <h2>Coach</h2><hr/>
        <br/> 
        
        <div class="container text-center">
            <asp:Label ID="lblMensaje" runat="server" BackColor="White" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
        </div>
        
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_coach" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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
    <h2>Cambio coach</h2><hr/>
    <br/>
    
    <div class="section-forms">
      <form action="">
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblCoachNombre" runat="server" Text="Nombre" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtCoachNombre" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdCoachNombre" runat="server" ErrorMessage="*Ingrese un nombre"
              ControlToValidate="txtCoachNombre" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblCoachApaterno" runat="server" Text="Apellido Paterno" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtCoachApaterno" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdCoachApaterno" runat="server" ErrorMessage="*Ingrese un apellido paterno"
              ControlToValidate="txtCoachApaterno" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblCoachAmaterno" runat="server" Text="Apellido Materno" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtCoachAmaterno" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdCoachAmaterno" runat="server" ErrorMessage="*Ingrese un apellido materno"
              ControlToValidate="txtCoachAmaterno" ValidationGroup="1"></asp:RequiredFieldValidator>
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
            <asp:Label ID="lblTurno" runat="server" Text="Turno" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <uc4:wuc_turnos ID="Wuc_turnos1" runat="server" />
        </div>
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblCv" runat="server" Text="Curriculum vitae" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtCv" runat="server" Width="100%" Height="250px" TextMode="MultiLine"></asp:TextBox> 
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdCv" runat="server" ErrorMessage="*Ingrese Curriculum vitae"
              ControlToValidate="txtCv" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div><br/>         
        <button type="submit" id="btn_modificar_coach" class="btn btn-warning btn-block text-white" runat="server"
            validationgroup="1">MODIFICAR COACH</button>
      </form>

    </div>
  </div>
</section><br />

</asp:Content>

