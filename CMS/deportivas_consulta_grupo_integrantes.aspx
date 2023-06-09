<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="deportivas_consulta_grupo_integrantes.aspx.vb" Inherits="Default2" title="Untitled Page" %>

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
        <h2>coach</h2><hr/>
        <div style="text-align: right;">
            <button id="btn_cambio_grupo_coach" type="button" class="btn btn-dark" runat="server">cambiar coach</button>
        </div><br />
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_grupo_coach" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                    BorderWidth="1px" CellPadding="4" CssClass="table tbl-hover" ForeColor="Black" GridLines="Horizontal">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
        
        <h2>deportistas</h2><hr/>
        <div style="text-align: right;">
            <button id="btn_alta_inscripcion" type="button" class="btn btn-dark" runat="server">agregar deportista</button>
        </div><br />
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_grupo_inscripciones" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
                    BorderWidth="1px" CellPadding="4" CssClass="table tbl-hover" ForeColor="Black" GridLines="Horizontal">
                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                </asp:GridView>
            </div>
        </div>
        
        <h2>rooster</h2><hr/>
        <div class="container">
            <div class="table table-responsive table-hover small">
                <asp:GridView ID="tbl_grupo_rooster" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None"
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

</asp:Content>

