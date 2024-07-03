<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_consulta_galeria_nota.aspx.vb" Inherits="Default2" title="Untitled Page" %>

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
        <h2>galeria nota</h2><hr/>
        <br />
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_galeria_nota" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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
    <h2>Alta galeria nota</h2><hr />

    <div class="section-forms">
      <asp:FileUpload ID="FileUpload_foto_nota" runat="server" /><br />
      <br />
      <label for="title">nombre archivo:</label>
      <asp:TextBox ID="txt_fnota_nombre" runat="server" Width="20%"></asp:TextBox><br />
      <br />
      <label for="texto">Descripcion</label><br/>
      <asp:TextBox ID="txt_descripcion" runat="server" Width="100%" Height="250px" TextMode="MultiLine"></asp:TextBox>
      <div class="input-group mb-2">
        <asp:RequiredFieldValidator ID="vddescripcion" runat="server" ErrorMessage="*Ingrese descripcion"
          ControlToValidate="txt_descripcion" ValidationGroup="1"></asp:RequiredFieldValidator>
      </div>
      
      <div style="text-align: right;">
        <button id="btn_alta_galeria_nota" type="submit" class="btn btn-success btn-block" runat="server"
          validationgroup="1">AGREGAR FOTO</button>
      </div>
      
    </div>

  </div>
</section><br />

</asp:Content>

