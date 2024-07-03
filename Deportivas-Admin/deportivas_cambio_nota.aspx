<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_cambio_nota.aspx.vb" Inherits="Default2" title="Untitled Page" %>

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
        <h2>Nota</h2><hr/>
        <br/>
        
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_nota" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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
    <h2>cambio nota</h2><hr/>
    <br />
    
    <div class="container text-center">
        <asp:Label ID="lblMensaje" runat="server" BackColor="White" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
    </div>

    <div class="section-forms">
      <form action="">
      
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblNotaTitulo" runat="server" Text="Titulo" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtNotaTitulo" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdNotaTitulo" runat="server" ErrorMessage="*Ingrese un nombre"
              ControlToValidate="txtNotaTitulo" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblNotaSubtitulo" runat="server" Text="Subtitulo" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtNotaSubtitulo" runat="server" Width="100%" Height="150px" TextMode="MultiLine"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdNotaSubtitulo" runat="server" ErrorMessage="*Ingrese subtitulo"
              ControlToValidate="txtNotaSubtitulo" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        
        
        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblNotaTexto" runat="server" Text="Texto" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtNotaTexto" runat="server" Width="100%" Height="250px" TextMode="MultiLine"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdNotaTexto" runat="server" ErrorMessage="*Ingrese texto"
              ControlToValidate="txtNotaTexto" ValidationGroup="1"></asp:RequiredFieldValidator>
          </div>
        </div>
        <button type="submit" id="btn_modificar_nota" class="btn btn-warning btn-block text-white" runat="server"
            validationgroup="1">MODIFICAR NOTA</button>
      </form>

    </div>
  </div>
</section><br />

</asp:Content>

