<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListarAtletas.aspx.cs" Inherits="ControleJogadores.ListarAtletas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Lista de atletas</h1>

    <div>
        <h4>Para cadastrar um atleta, <a href="IncluirAtleta.aspx">clique aqui</a></h4>

    </div>
   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CamisaNro" DataSourceID="Atletas">
    <Columns>
        <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
        <asp:BoundField DataField="Apelido" HeaderText="Apelido" SortExpression="Apelido" />
        <asp:BoundField DataField="DataNascimento" HeaderText="Data de Nascimento" SortExpression="DataNascimento" />
        <asp:BoundField DataField="Altura" HeaderText="Altura" SortExpression="Altura" />
        <asp:BoundField DataField="Peso" HeaderText="Peso" SortExpression="Peso" />
        <asp:BoundField DataField="Posicao" HeaderText="Posição" SortExpression="Posicao" />
        <asp:BoundField DataField="CamisaNro" HeaderText="Número da Camisa" SortExpression="CamisaNro" />
         <asp:HyperLinkField DataNavigateUrlFields="AtletaID" DataNavigateUrlFormatString="AlterarAtleta.aspx?AtletaID={0}" Text="Alterar" HeaderText="Alterar" />
         <asp:HyperLinkField DataNavigateUrlFields="AtletaID" DataNavigateUrlFormatString="DeletarAtleta.aspx?AtletaID={0}" Text="Excluir" HeaderText="Excluir" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="Atletas" runat="server" ConnectionString="<%$ ConnectionStrings:AtletasContext %>" SelectCommand="SELECT * FROM [Atletas]" />

</body>
</html>
