<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Visual.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="estilo2.css" rel="stylesheet" type="text/css">
    <h2><%: Title %>.</h2>
    <h3>Reporte</h3>
    <div>
            <asp:Label ID="filtro" CssClass="ete" runat="server" Text="Tipo de prenda"></asp:Label>
            <asp:TextBox ID="filt_in" CssClass="box" runat="server"></asp:TextBox>
            <br />
        <br />
            <asp:Button ID="Button1" runat="server" Text="Generar reporte" OnClick="Button1_Click" />
            <asp:GridView ID="GridView1" CssClass="mGrid" PagerStyle-CssClass="pgr" AlternatingRowStyle-CssClass="alt" runat="server"></asp:GridView>
        </div>
</asp:Content>
