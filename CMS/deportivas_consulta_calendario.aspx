<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_consulta_calendario.aspx.vb" Inherits="Default2" title="Untitled Page" %>

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
        <h2>calendario</h2><hr/>
        <br/>
        
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_calendario" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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
    <h2>alta calendario</h2><hr/>
    <br />

    <div class="section-forms">
      <form action="">
      
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblCalendarioNombreEvento" runat="server" Text="Evento" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtCalendarioNombreEvento" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdCalendarioNombreEvento" runat="server" ErrorMessage="*Ingrese un nombre"
              ControlToValidate="txtCalendarioNombreEvento" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblCalendarioDescripcionEvento" runat="server" Text="Descripcion" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtCalendarioDescripcionEvento" runat="server" Width="100%" Height="150px" TextMode="MultiLine"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdCalendarioDescripcionEvento" runat="server" ErrorMessage="*Ingrese subtitulo"
              ControlToValidate="txtCalendarioDescripcionEvento" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="Label1" runat="server" Text="Fecha evento" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtFechaEvento" runat="server" CssClass="form-control" ReadOnly="True"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdtxtFechaEvento" runat="server" ErrorMessage="*Ingrese un nombre"
              ControlToValidate="txtFechaEvento" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>          
        </div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar><br/>
        
        <button type="submit" id="btn_alta_calendario" class="btn btn-success btn-block" runat="server"
          validationgroup="1">AGREGAR AL CALENDARIO</button>
      </form>

    </div>
  </div>
</section><br />



</asp:Content>

