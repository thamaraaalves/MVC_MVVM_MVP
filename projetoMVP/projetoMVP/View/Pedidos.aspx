<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="projetoMVP.View.Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
        <asp:Panel ID="Panel1" runat="server" Height="19px">
        </asp:Panel>
    
    </div>
    
    <br />
    <asp:Label ID="Label2" runat="server" Text="Produto"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged" 
        Width="232px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Quantidade"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox2" runat="server" Width="228px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Cliente"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox3" runat="server" Width="224px"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Data"></asp:Label>
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" />
    <br />
    <br />
    </form>
</body>
</html>
