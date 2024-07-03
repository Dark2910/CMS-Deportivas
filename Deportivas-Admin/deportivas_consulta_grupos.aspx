<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_consulta_grupos.aspx.vb" Inherits="Default2" title="Untitled Page" %>

<%@ Register Src="controls/wuc_turnos.ascx" TagName="wuc_turnos" TagPrefix="uc4" %>
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
        <h2>grupos matutino</h2><hr/>
        <br/>
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_grupos_matutino" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                    BorderWidth="1px" CellPadding="4" CssClass="table tbl-hover" ForeColor="Black" GridLines="Horizontal">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
        
        <h2>grupos vespertino</h2><hr/>
        <br/>
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_grupos_vespertino" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                    BorderWidth="1px" CellPadding="4" CssClass="table tbl-hover" ForeColor="Black" GridLines="Horizontal">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
        
        <h2>grupos pendientes</h2><hr/>
        <br/>
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_grupos_pendientes" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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
    <h2>Alta grupo</h2>
    <hr />

    <div class="section-forms">
      <form action="">

        <div class="input-group">
          <div class="input-group-prepend">
            <asp:Label ID="lblGrupoNombre" runat="server" Text="Nombre del grupo" CssClass="input-group-text"
              BackColor="#FFFFFF" Width="160px"></asp:Label>
          </div>
          <asp:TextBox ID="txtGrupoNombre" runat="server" CssClass="form-control"></asp:TextBox>
          <div class="input-group mb-2">
            <asp:RequiredFieldValidator ID="vdGrupoNombre" runat="server"
              ErrorMessage="*Ingrese un nombre para el grupo" ControlToValidate="txtGrupoNombre" ValidationGroup="1">
            </asp:RequiredFieldValidator>
          </div>
        </div>

        <div class="input-group mb-5">
          <div class="input-group-prepend">
            <asp:Label ID="lblTurno" runat="server" Text="Turno" CssClass="input-group-text" BackColor="#FFFFFF"
              Width="160px"></asp:Label>
          </div>
          <uc4:wuc_turnos ID="Wuc_turnos1" runat="server" />
        </div>

        <button type="submit" id="btn_alta_grupo" class="btn btn-success btn-block" runat="server"
          validationgroup="1">AGREGAR GRUPO</button>
      </form>

    </div>
  </div>
</section>

</asp:Content>

