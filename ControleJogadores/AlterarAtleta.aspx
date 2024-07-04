<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AlterarAtleta.aspx.cs" Inherits="ControleJogadores.AlterarAtleta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Alterar atleta</h1>
    <form id="form1" runat="server">
    <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
     <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>

<br /><br />

    <asp:Label ID="lblApelido" runat="server" Text="Apelido:"></asp:Label>
    <asp:TextBox ID="txtApelido" runat="server" />

<br /><br />

    <asp:Label ID="LblNasc" runat="server" Text="Data de Nascimento:"></asp:Label>
    <asp:TextBox ID="txtNasc" runat="server" />

<br /><br />

    <asp:Label ID="LblAltura" runat="server" Text="Altura:"></asp:Label>
    <asp:TextBox ID="txtAltura" runat="server" />

<br /><br />

    <asp:Label ID="LblPeso" runat="server" Text="Peso:"></asp:Label>
    <asp:TextBox ID="txtPeso" runat="server" />

<br /><br />

    <asp:Label ID="LblPosicao" runat="server" Text="Posição:"></asp:Label>
    <asp:TextBox ID="txtPosicao" runat="server" />

<br /><br />

    <asp:Label ID="LblCamisa" runat="server" Text="Camisa:"></asp:Label>
    <asp:TextBox ID="txtCamisa" runat="server" />

<br /><br />

<asp:Button ID="btnUpdate" runat="server" Text="Alterar" OnClick="btnUpdate_Click" />
    </form>
</body>
</html>
