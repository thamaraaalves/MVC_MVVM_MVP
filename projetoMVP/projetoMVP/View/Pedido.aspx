<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="projetoMVP.View.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="Implementação MVP"></asp:Label>
    <br />
    <br />
    <br />
    
    <asp:Label ID="Label2" runat="server" Text="Produto"></asp:Label>
    <br />   
    <asp:TextBox ID="txbProduto" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label3" runat="server" Text="Quantidade"></asp:Label>
    <br />
    <asp:TextBox ID="txbQuantidade" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label4" runat="server" Text="Cliente"></asp:Label>
    <br />
    <asp:TextBox ID="txbCliente" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Label ID="Label5" runat="server" Text="Data"></asp:Label>
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Salvar" />
    <br />
    <br />
</asp:Content>
