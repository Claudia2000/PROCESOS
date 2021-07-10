<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Visual.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="estilo2.css" rel="stylesheet" type="text/css">
    <h2><%: Title %>.</h2>
    <h3>Shopping</h3>
    <p>Información de cliente</p>

     <div class="text-center">  
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="IDCLIENTE"
OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added." >
<Columns>
    
    <asp:TemplateField HeaderText="Id" ItemStyle-Width="150" Visible="False">
        
        <ItemTemplate> 
            <asp:Label ID="lblId" runat="server" Text='<%# Eval("IDCLIENTE") %>' Visible="True"></asp:Label>
        </ItemTemplate>
        
        <EditItemTemplate>
            <asp:TextBox ID="txtId" runat="server" Text='<%# Eval("IDCLIENTE") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    
    <asp:TemplateField HeaderText="Nombre" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblName" runat="server" Text='<%# Eval("NOMCLIENTE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtName" runat="server" Text='<%# Eval("NOMCLIENTE") %>'></asp:TextBox>
        </EditItemTemplate>
    
    </asp:TemplateField>
    
    <asp:TemplateField HeaderText="Dirección" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblDireccion" runat="server" Text='<%# Eval("DIRCLIENTE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtDireccion" runat="server" Text='<%# Eval("DIRCLIENTE") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="Celular" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblCelular" runat="server" Text='<%# Eval("CELCLIENTE") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtCelular" runat="server" Text='<%# Eval("CELCLIENTE") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="Usuario" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblUsuario" runat="server" Text='<%# Eval("USERC") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtUsuario" runat="server" Text='<%# Eval("USERC") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="Contrasena" ItemStyle-Width="150" >
        <ItemTemplate>
            <asp:Label ID="lblContrasena" runat="server" Text='<%# Eval("CONTRA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtContrasena" runat="server" Text='<%# Eval("CONTRA") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:CommandField ButtonType="Link" ShowEditButton="true" ShowDeleteButton="true" ItemStyle-Width="150"/>

</Columns>
       
</asp:GridView>
         <br />
         <table border="1" cellpadding="0" cellspacing="0" style="border-collapse: collapse">
<tr>
    <td style="width: 150px">
        ID:<br />
        <asp:TextBox ID="txtId" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        Name:<br />
        <asp:TextBox ID="txtName" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        Direccion:<br />
        <asp:TextBox ID="txtDireccion" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        Celular:<br />
        <asp:TextBox ID="txtCelular" runat="server" Width="140" />
    </td>
    <td style="width: 150px">
        Usuario:<br />
        <asp:TextBox ID="txtUsuario" runat="server" Width="140" />
    </td>
    <td style="width: 150px">
        Contrasena:<br />
        <asp:TextBox ID="txtContrasena" runat="server" Width="140" />
    </td>

    <td style="width: 100px">
        <asp:Button ID="btnAdd" runat="server" Text="Añadir" OnClick="Insert" BorderStyle="double"/>
    </td>
</tr>
</table>
     </div>   
</asp:Content>
