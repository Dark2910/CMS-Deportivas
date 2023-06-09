<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_cambio_galeria_deporte.aspx.vb" Inherits="Default2" title="Untitled Page" %>

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
        <h2>galeria deporte</h2><hr/>
        <br />
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_galeria_deporte" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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
    <h2>cambio galeria deporte</h2><hr />
    
    <div class="container text-center">
        <asp:Label ID="lblMensaje" runat="server" BackColor="White" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
    </div>

    <div class="section-forms">
      <label for="texto">Descripcion</label><br>
      <asp:TextBox ID="txt_descripcion" runat="server" Width="100%" Height="250px" TextMode="MultiLine"></asp:TextBox>
      <div class="input-group mb-2">
        <asp:RequiredFieldValidator ID="vddescripcion" runat="server" ErrorMessage="*Ingrese descripcion"
          ControlToValidate="txt_descripcion" ValidationGroup="1"></asp:RequiredFieldValidator>
      </div>
      
      <div style="text-align: right;">
        <button type="submit" id="btn_modificar_foto" class="btn btn-warning btn-block text-white" runat="server"
            validationgroup="1">MODIFICAR FOTO</button>
      </div>
      
    </div>

  </div>
</section><br />

</asp:Content>

