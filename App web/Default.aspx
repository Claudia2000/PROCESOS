<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Visual._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server" align="center">
    <link href="estilo.css" rel="stylesheet" type="text/css">
 <p><p><p><p>
     <br />
<div class="text-center">
        <asp:Label ID="usuario" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="v_usuario" runat="server"  ToolTip="usuario" ></asp:TextBox>
        
    </div>
    <br />
    <div class="text-center">
        <asp:Label ID="contra" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="v_contra" runat="server" TextMode="Password" ToolTip="contraseña"></asp:TextBox>
    </div>
    
    <br />
    <div class="text-center">
    <asp:Button ID="validar" runat="server" Text="Ingresar" OnClick="validar_Click" align="center"/>
    </div>
</asp:Content>
