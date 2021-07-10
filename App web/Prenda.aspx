<%@ Page Title="Prenda" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prenda.aspx.cs" Inherits="Visual.Prenda" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link href="estilo2.css" rel="stylesheet" type="text/css">
    <h2><%: Title %>.</h2>
    <h3>Prenda</h3>
    <p>Información de prenda</p>

     <div class="text-center">  
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="IDPRENDA"
OnRowDataBound="OnRowDataBound" OnRowEditing="OnRowEditing" OnRowCancelingEdit="OnRowCancelingEdit"
OnRowUpdating="OnRowUpdating" OnRowDeleting="OnRowDeleting" EmptyDataText="No records has been added." >
<Columns>
    
    <asp:TemplateField HeaderText="Id" ItemStyle-Width="150" Visible="False">
        
        <ItemTemplate>
            <asp:Label ID="lblId" runat="server" Text='<%# Eval("IDPRENDA") %>' Visible="True"></asp:Label>
        </ItemTemplate>
        
        <EditItemTemplate>
            <asp:TextBox ID="txtId" runat="server" Text='<%# Eval("IDPRENDA") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    
    <asp:TemplateField HeaderText="Prenda" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblPrenda" runat="server" Text='<%# Eval("NOMPRENDA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtPrenda" runat="server" Text='<%# Eval("NOMPRENDA") %>'></asp:TextBox>
        </EditItemTemplate> 
    </asp:TemplateField>
    
    <asp:TemplateField HeaderText="Precio" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblPrecio" runat="server" Text='<%# Eval("PRECIOPRENDA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtPrecio" runat="server" Text='<%# Eval("PRECIOPRENDA") %>'></asp:TextBox>
        </EditItemTemplate>
    </asp:TemplateField>

    <asp:TemplateField HeaderText="Color" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblColor" runat="server" Text='<%# Eval("COLORPRENDA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtColor" runat="server" Text='<%# Eval("COLORPRENDA") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="Stock" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblStock" runat="server" Text='<%# Eval("STOCKPRENDA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtStock" runat="server" Text='<%# Eval("STOCKPRENDA") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="Talla" ItemStyle-Width="150">
        <ItemTemplate>
            <asp:Label ID="lblTalla" runat="server" Text='<%# Eval("TALLAPRENDA") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtTalla" runat="server" Text='<%# Eval("TALLAPRENDA") %>'></asp:TextBox>
        </EditItemTemplate>

    </asp:TemplateField>
    <asp:TemplateField HeaderText="IdTipo" ItemStyle-Width="150" Visible="False">
        <ItemTemplate>
            <asp:Label ID="lblIdTipo" runat="server" Text='<%# Eval("IDTIPOP") %>'></asp:Label>
        </ItemTemplate>
        <EditItemTemplate>
            <asp:TextBox ID="txtIdTipo" runat="server" Text='<%# Eval("IDTIPOP") %>'></asp:TextBox>
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
        Prenda:<br />
        <asp:TextBox ID="txtPrenda" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        Precio:<br />
        <asp:TextBox ID="txtPrecio" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        Color:<br />
        <asp:TextBox ID="txtColor" runat="server" Width="140" />
    </td>
    
    <td style="width: 150px">
        Stock:<br />
        <asp:TextBox ID="txtStock" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        Talla:<br />
        <asp:TextBox ID="txtTalla" runat="server" Width="140" />
    </td>

    <td style="width: 150px">
        IdTipo:<br />
        <asp:TextBox ID="txtIdTipo" runat="server" Width="140" />
    </td>
    <td style="width: 100px">
        <asp:Button ID="btnAdd" runat="server" Text="Añadir" OnClick="Insert" BorderStyle="double"/>
    </td>
</tr>
</table>
     </div>   
</asp:Content>
