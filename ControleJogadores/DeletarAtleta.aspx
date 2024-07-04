<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeletarAtleta.aspx.cs" Inherits="ControleJogadores.DeletarAtleta" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Deletar Atleta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Deletar Atleta</h2>
            <asp:Label ID="lblMensagem" runat="server" Text="Você tem certeza que deseja deletar este atleta?"></asp:Label>
            <br /><br />
            <asp:Button ID="btnDelete" runat="server" Text="Excluir" OnClick="btnDelete_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
